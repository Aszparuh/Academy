namespace Events
{
    using System;
    using Contracts;
    using Types;

    public class CommandEngine
    {
        private const char CommandSeparator = '|';
        private readonly IEventHolder eventHolder;

        public CommandEngine(IEventHolder eventHolder)
        {
            this.eventHolder = eventHolder;
        }

        public bool ExecuteNextCommand()
        {
            string command = Console.ReadLine();
            if (command[0] == 'A')
            {
                this.AddEvent(command);
                return true;
            }

            if (command[0] == 'D')
            {
                this.DeleteEvents(command);
                return true;
            }

            if (command[0] == 'L')
            {
                this.ListEvents(command);
                return true;
            }

            if (command[0] == 'E')
            {
                return false;
            }

            return false;
        }

        protected void AddEvent(string command)
        {
            var newEvent = this.CreateEventFromCommand(command, CommandType.Add);
            this.eventHolder.AddEvent(newEvent);
        }

        private void ListEvents(string command)
        {
            int pipeIndex = command.IndexOf(CommandSeparator);
            DateTime date = this.GetDate(command, CommandType.List);
            string countString = command.Substring(pipeIndex + 1);

            int count = int.Parse(countString);
            this.eventHolder.ListEvents(date, count);
        }

        private void DeleteEvents(string command)
        {
            string title = command.Substring((int)CommandType.Remove + 1);
            this.eventHolder.DeleteEvents(title);
        }

        private Event CreateEventFromCommand(string commandForExecution, CommandType commandType)
        {
            var dateAndTime = this.GetDate(commandForExecution, commandType);
            string eventTitle;
            string eventLocation;
            int firstPipeIndex = commandForExecution.IndexOf(CommandSeparator);
            int lastPipeIndex = commandForExecution.LastIndexOf(CommandSeparator);

            if (firstPipeIndex == lastPipeIndex)
            {
                eventTitle = commandForExecution
                    .Substring(firstPipeIndex + 1)
                    .Trim();

                eventLocation = string.Empty;
            }
            else
            {
                eventTitle = commandForExecution
                    .Substring(firstPipeIndex + 1, lastPipeIndex - firstPipeIndex - 1)
                    .Trim();

                eventLocation = commandForExecution
                    .Substring(lastPipeIndex + 1)
                    .Trim();
            }

            return new Event(dateAndTime, eventTitle, eventLocation);
        }

        private DateTime GetDate(string command, CommandType commandType)
        {
            DateTime date = DateTime.Parse(command.Substring((int)commandType + 1, 20));
            return date;
        }
    }
}
