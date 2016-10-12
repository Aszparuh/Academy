using System;
using SchoolSystem.Logic.Contracts;

namespace SchoolSystem.Logic
{
    public class ConsoleWriterProvider : IWriter
    {
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
