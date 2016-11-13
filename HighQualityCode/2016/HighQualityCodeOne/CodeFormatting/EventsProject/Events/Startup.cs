namespace Events
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var logger = new Logger();
            var eventHolder = new EventHolder(logger);
            var commandEngine = new CommandEngine(eventHolder);

            while (commandEngine.ExecuteNextCommand())
            {
            }

            Console.WriteLine(logger);
        }
    }
}
