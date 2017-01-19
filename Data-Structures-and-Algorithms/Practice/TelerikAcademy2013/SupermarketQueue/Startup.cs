using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace SupermarketQueue
{
    public class Startup
    {
        public static void Main()
        {
            var result = new StringBuilder();
            var supermarketQueue = new SupermarketQueue();

            var line = Console.ReadLine();
            while (line != "End")
            {
                var command = Command.Parse(line);
                switch (command.Name)
                {
                    case "Append":
                        supermarketQueue.Append(command.Arguments[0]);
                        result.AppendLine("OK");
                        break;

                    case "Serve":

                        try
                        {
                            var clients = supermarketQueue.Serve(int.Parse(command.Arguments[0]));
                            result.AppendLine(string.Join(" ", clients));
                        }
                        catch (Exception)
                        {
                            result.AppendLine("Error");
                        }

                        break;
                    case "Find":

                        var number = supermarketQueue.Find(command.Arguments[0]);
                        result.AppendLine(number.ToString());

                        break;
                    case "Insert":

                        try
                        {
                            supermarketQueue.Insert(int.Parse(command.Arguments[0]), command.Arguments[1]);
                            result.AppendLine("OK");
                        }
                        catch (Exception)
                        {
                            result.AppendLine("Error");
                        }

                        break;
                    default:
                        throw new ArgumentException();
                }

                line = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }

        public class Command
        {
            public Command(string name, IList<string> arguments)
            {
                this.Name = name;
                this.Arguments = arguments;
            }

            public string Name { get; private set; }

            public IList<string> Arguments { get; set; }

            public static Command Parse(string commandAsString)
            {
                var commandParts = commandAsString.Split(' ');
                var name = commandParts[0];
                var arguments = new List<string>();

                for (int i = 1; i < commandParts.Length; i++)
                {
                    arguments.Add(commandParts[i]);
                }

                return new Command(name, arguments);
            }
        }

        public class SupermarketQueue
        {
            public SupermarketQueue()
            {
                this.ListOfClients = new BigList<string>();
                this.ByName = new Dictionary<string, int>();
            }

            public BigList<string> ListOfClients { get; private set; }

            public IDictionary<string, int> ByName { get; private set; }

            public void Append(string name)
            {
                this.ListOfClients.Add(name);

                if (!this.ByName.ContainsKey(name))
                {
                    this.ByName.Add(name, 0);
                }

                this.ByName[name] += 1;
            }

            public void Insert(int position, string name)
            {
                this.ListOfClients.Insert(position, name);

                if (!this.ByName.ContainsKey(name))
                {
                    this.ByName.Add(name, 0);
                }

                this.ByName[name] += 1;
            }

            public int Find(string name)
            {
                if (!this.ByName.ContainsKey(name))
                {
                    return 0;
                }
                else
                {
                    return this.ByName[name];
                }
            }

            public IEnumerable<string> Serve(int number)
            {
                var clients = this.ListOfClients.Range(0, number).ToList();
                this.ListOfClients.RemoveRange(0, number);

                foreach (var item in clients)
                {
                    this.ByName[item] -= 1;
                }

                return clients;
            }
        }
    }
}
