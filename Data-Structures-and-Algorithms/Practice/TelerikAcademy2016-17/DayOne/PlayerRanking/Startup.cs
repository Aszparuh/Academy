using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wintellect.PowerCollections;

namespace PlayerRanking
{
    public class Startup
    {
        public static void Main()
        {
            var result = new StringBuilder();
            var repository = new PlayerRepository();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var command = Command.Parse(line);
                switch (command.Name)
                {
                    case "add":
                        var player = Player.Parse(command.Arguments);
                        repository.Add(player);
                        result.AppendLine(string.Format("Added player {0} to position {1}", player.Name, player.Position));

                        break;
                    case "find":
                        var type = command.Arguments[0];

                        var players = repository.FindByType(type);
                        result.AppendLine(string.Format("Type {0}: {1}", type, string.Join("; ", players)));

                        break;
                    case "ranklist":
                        var start = int.Parse(command.Arguments[0]);
                        var end = int.Parse(command.Arguments[1]);

                        start -= 1;
                        var playersByRank = repository.RankList(start, end).Select(p => new { Position = ++start, Player = p }).ToList();

                        result.AppendLine(string.Join("; ", playersByRank.Select(r => string.Format("{0}. {1}", r.Position, r.Player))));
                        break;
                    default:
                        throw new InvalidOperationException("Invalid command: " + command.Name);
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(result.ToString().Trim());
        }
    }

    public class Command
    {
        public Command(string name, IList<string> arguments)
        {
            this.Name = name;
            this.Arguments = arguments;
        }

        public IList<string> Arguments { get; private set; }

        public string Name { get; private set; }

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

    public class Player : IComparable<Player>
    {
        public Player(string name, string type, int age, int position)
        {
            this.Name = name;
            this.Type = type;
            this.Age = age;
            this.Position = position;
        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public int Age { get; private set; }

        public int Position { get; set; }

        public override string ToString()
        {
            return string.Format("{0}({1})", this.Name,this.Age);
        }

        public int CompareTo(Player other)
        {
            var res = this.Name.CompareTo(other.Name);

            if (res == 0)
            {
                res = this.Age.CompareTo(other.Age) * -1;
            }

            return res;
        }

        public static Player Parse(IList<string> playerArguments)
        {
            var age = int.Parse(playerArguments[2]);
            var position = int.Parse(playerArguments[3]);
            return new Player(playerArguments[0], playerArguments[1], age, position);
        }
    }

    public class PlayerRepository
    {
        private readonly IDictionary<string, SortedSet<Player>> playersByType;
        private readonly BigList<Player> playersByPosition;

        public PlayerRepository()
        {
            this.playersByType = new Dictionary<string, SortedSet<Player>>();
            this.playersByPosition = new BigList<Player>();
        }

        public void Add(Player player)
        {
            if (!this.playersByType.ContainsKey(player.Type))
            {
                this.playersByType[player.Type] = new SortedSet<Player>();
            }

            this.playersByType[player.Type].Add(player);
            this.playersByPosition.Insert(player.Position - 1, player);
        }

        public IEnumerable<Player> RankList(int start, int end)
        {
            return this.playersByPosition.Range(start, end - start);    
        }

        public IEnumerable<Player> FindByType(string type)
        {
            if (!this.playersByType.ContainsKey(type))
            {
                return Enumerable.Empty<Player>();
            }

            return this.playersByType[type].Take(5);
        }
    }
}
