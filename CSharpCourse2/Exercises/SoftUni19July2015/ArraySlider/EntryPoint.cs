namespace ArraySlider
{
    using System;
    using System.Linq;

    class EntryPoint
    {
        static void Main()
        {
            char[] separator = new char[] { ' ', '\t' };
            var inputArray = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => ulong.Parse(n))
                .ToArray();

            int index = 0;
            string line = Console.ReadLine();
            while (line != "stop")
            {
                var command = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                int offset = int.Parse(command[0]);
                string operation = command[1];
                int operand = int.Parse(command[2]);
             
                if (offset < 0)
                {
                    offset += inputArray.Length;
                }

                index = (index + offset) % inputArray.Length;

                switch (operation)
                {
                    case "&": inputArray[index] = inputArray[index] & operand;
                        break;
                    case "|": inputArray[index] = inputArray[index] | operand;
                        break;
                    case "^": inputArray[index] = inputArray[index] ^ operand;
                        break;
                    case "+": inputArray[index] = inputArray[index] + operand;
                        break;
                    case "-": inputArray[index] = inputArray[index] - operand;
                        break;
                    case "*": inputArray[index] = inputArray[index] * operand;
                        break;
                    case "/": inputArray[index] = inputArray[index] / operand;
                        break;
                    default: throw new ArgumentException();
                }

                if (inputArray[index] < 0)
                {
                    inputArray[index] = 0;
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", inputArray));
        }
    }
}
