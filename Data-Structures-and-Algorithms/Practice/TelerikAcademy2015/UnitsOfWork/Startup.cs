using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitsOfWork
{
    public class Startup
    {
        private const string SuccessAddMessage = "SUCCESS: {0} added!";
        private const string FailAddMessage = "FAIL: {0} already exists!";
        private const string SuccessRemoveMessage = "SUCCESS: {0} removed!";
        private const string FaileRemoveMessage = "FAIL: {0} could not be found!";
        private const string FindResultMessage = "RESULT: {0}";

        public static StringBuilder result = new StringBuilder();
        public static UnitsRepository repository = new UnitsRepository();

        public static void Main()
        {
            var line = Console.ReadLine();
            while (line != "end")
            {
                ProcessCommand(line);
                line = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }

        public static void ProcessCommand(string command)
        {
            var commandParts = command.Split(' ');
            var commandName = commandParts[0];

            switch (commandName)
            {
                case "add":
                    var unitName = commandParts[1];
                    var unitType = commandParts[2];
                    var unitAttack = int.Parse(commandParts[3]);
                    ProcessAppendAddCommand(unitName, unitType, unitAttack);
                    break;
                case "remove":
                    var unitToRemoveName = commandParts[1];
                    ProcessAppendRemoveCommand(unitToRemoveName);
                    break;
                case "find":
                    var typeToFind = commandParts[1];
                    ProcessAppendFindCommand(typeToFind);
                    break;
                case "power":
                    var count = int.Parse(commandParts[1]);
                    ProcessAppendPowerCommand(count);
                    break;
                case "end":
                    break;
                default:
                    throw new InvalidOperationException("Invalid command: " + command);
            }
        }

        public static void ProcessAppendAddCommand(string unitName, string unitType, int unitAttack)
        {
            var unit = new Unit(unitName, unitType, unitAttack);
            var added = repository.Add(unit);
            if (added)
            {
                result.AppendLine(string.Format(SuccessAddMessage, unitName));
            }
            else
            {
                result.AppendLine(string.Format(FailAddMessage, unitName));
            }
        }

        public static void ProcessAppendRemoveCommand(string unitName)
        {
            var removed = repository.Remove(unitName);
            if (removed)
            {
                result.AppendLine(string.Format(SuccessRemoveMessage, unitName));
            }
            else
            {
                result.AppendLine(string.Format(FaileRemoveMessage, unitName));
            }
        }

        public static void ProcessAppendFindCommand(string type)
        {
            var units = repository.Find(type);

            result.AppendLine(string.Format(FindResultMessage, string.Join(", ", units)));
        }

        public static void ProcessAppendPowerCommand(int number)
        {
            var units = repository.FindByPower(number);

            result.AppendLine(string.Format(FindResultMessage, string.Join(", ", units)));
        }
    }

    public class Unit : IComparable<Unit>
    {
        public Unit(string name, string type, int attack)
        {
            this.Name = name;
            this.Type = type;
            this.Attack = attack;
        }

        public string Name { get; private set; }

        public string Type { get; private set; }

        public int Attack { get; private set; }

        public int CompareTo(Unit other)
        {
            var result = this.Attack.CompareTo(other.Attack) * -1;
            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }

            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
        }
    }

    public class UnitsRepository
    {
        private IDictionary<string, Unit> unitsByName;
        private IDictionary<string, SortedSet<Unit>> unitsByType;
        private ISet<Unit> unitsByAttack;

        public UnitsRepository()
        {
            this.unitsByName = new Dictionary<string, Unit>();
            this.unitsByType = new Dictionary<string, SortedSet<Unit>>();
            this.unitsByAttack = new SortedSet<Unit>();
        }

        public bool Add(Unit unit)
        {
            if (this.unitsByName.ContainsKey(unit.Name))
            {
                return false;
            }
            else
            {
                this.unitsByName.Add(unit.Name, unit);
                this.unitsByAttack.Add(unit);
                if (this.unitsByType.ContainsKey(unit.Type))
                {
                    this.unitsByType[unit.Type].Add(unit);
                }
                else
                {
                    this.unitsByType.Add(unit.Type, new SortedSet<Unit>());
                    this.unitsByType[unit.Type].Add(unit);
                }

                return true;
            }
        }

        public bool Remove(string name)
        {
            if (unitsByName.ContainsKey(name))
            {
                var unitByName = this.unitsByName[name];
                var unitsWithSameType = this.unitsByType[unitByName.Type];
                
                unitsWithSameType.Remove(unitByName);
                this.unitsByAttack.Remove(unitByName);
                this.unitsByName.Remove(name);

                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Unit> Find(string type)
        {
            if (this.unitsByType.ContainsKey(type))
            {
                return this.unitsByType[type].Take(10);
            }
            else
            {
                return Enumerable.Empty<Unit>();
            }
        }

        public IEnumerable<Unit> FindByPower(int number)
        {
            return this.unitsByAttack.Take(number);
        }
    }
}
