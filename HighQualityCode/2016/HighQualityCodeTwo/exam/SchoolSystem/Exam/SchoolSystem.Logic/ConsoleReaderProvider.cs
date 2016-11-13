using System;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
