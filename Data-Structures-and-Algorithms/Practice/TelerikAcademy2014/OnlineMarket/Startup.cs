using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineMarket
{
    public class Startup
    {
        public static void Main()
        {
            var result = new StringBuilder();
            var onlineMarket = new OnlineMarket();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var command = Command.Parse(line);

                switch (command.Name)
                {
                    case "add":
                        var product = Product.Parse(command.Arguments);
                        try
                        {
                            onlineMarket.Add(product);
                            result.AppendLine(string.Format("Ok: Product {0} added successfully", product.Name));
                        }
                        catch (Exception ex)
                        {
                            result.AppendLine(string.Format("Error: Product {0} already exists", product.Name));
                        }

                        break;
                    case "filter":

                        IEnumerable<Product> products = null;
                        if (command.Arguments[1] == "type")
                        {
                            try
                            {
                                products = onlineMarket.FilterByType(command.Arguments[2]);
                                result.Append("Ok: ");
                                result.AppendLine(string.Join(", ", products));
                            }
                            catch (Exception)
                            {

                                result.AppendLine(string.Format("Error: Type {0} does not exists", command.Arguments[2]));
                            }
                        }
                        else
                        {
                            if (command.Arguments.Count > 4)
                            {
                                products = onlineMarket.FilterByPrice(float.Parse(command.Arguments[3]), float.Parse(command.Arguments[5]));
                                result.Append("Ok: ");
                                result.AppendLine(string.Join(", ", products));
                            }
                            else
                            {
                                if (command.Arguments[2] == "from")
                                {
                                    products = onlineMarket.FilterByPrice(min: float.Parse(command.Arguments[3]));
                                    result.Append("Ok: ");
                                    result.AppendLine(string.Join(", ", products));
                                }
                                else
                                {
                                    products = onlineMarket.FilterByPrice(max: float.Parse(command.Arguments[3]));
                                    result.Append("Ok: ");
                                    result.AppendLine(string.Join(", ", products));
                                }
                            }
                        }

                        break;
                    default:
                        throw new ArgumentException();
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }
    }

    public class Command
    {
        public Command(string name, IList<string> arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        public string Name { get; private set; }

        public IList<string> Arguments { get; private set; }

        public static Command Parse(string commandAsString)
        {
            var commandParts = commandAsString.Split(' ');
            var commandName = commandParts[0];
            var commandArguments = new List<string>();

            for (int i = 1; i < commandParts.Length; i++)
            {
                commandArguments.Add(commandParts[i]);
            }

            return new Command(commandName, commandArguments);
        }
    }

    public class Product : IComparable<Product>
    {
        public Product(string name, string type, float price)
        {
            this.Name = name;
            this.Type = type;
            this.Price = price;
        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public float Price { get; private set; }

        public static Product Parse(IList<string> productParts)
        {
            var name = productParts[0];
            var price = float.Parse(productParts[1]);
            var type = productParts[2];

            return new Product(name, type, price);
        }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name, this.Price);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Product) || obj == null)
            {
                return false;
            }

            Product other = (Product)obj;
            if (this.Name == other.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }

        public int CompareTo(Product other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }

    public class OnlineMarket
    {
        private IDictionary<string, SortedSet<Product>> byType;
        private ISet<string> uniqueNames;
        private SortedSet<Product> byPrice;

        public OnlineMarket()
        {
            this.byType = new Dictionary<string, SortedSet<Product>>();
            this.byPrice = new SortedSet<Product>();
            this.uniqueNames = new HashSet<string>();
        }

        public void Add(Product product)
        {
            if (this.uniqueNames.Contains(product.Name))
            {
                throw new ArgumentException();
            }

            if (!this.byType.ContainsKey(product.Type))
            {
                this.byType.Add(product.Type, new SortedSet<Product>());
            }

            this.byType[product.Type].Add(product);
            this.uniqueNames.Add(product.Name);
            this.byPrice.Add(product);
        }

        public IEnumerable<Product> FilterByType(string type)
        {
            var products = this.byType[type].Take(10);
            return products;
        }

        public IEnumerable<Product> FilterByPrice(float min = 0, float max = float.MaxValue)
        {
            var products = this.byPrice.Where(x => x.Price > min && x.Price < max).ToArray();
            return products;
        }
    }
}
