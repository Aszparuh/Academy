using SchoolSystem.Logic;

namespace SchoolSystem.ConsoleApplication
{
    public class Startup
    {
        public static void Main()
        {
            var consoleReader = new ConsoleReaderProvider();
            var consoleWriter = new ConsoleWriterProvider();

            var engine = new Engine(consoleReader, consoleWriter);
            engine.Start();
        }
    }
}
