using System;
using System.Collections.Generic;
using System.Text;

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
                        break;
                    case "Serve":
                        break;
                    case "Find":
                        break;
                    case "Insert":
                        break;
                    default:
                        throw new ArgumentException();
                }

                line = Console.ReadLine();
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

        }
    }
}
