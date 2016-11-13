namespace Events
{
    using System.Text;
    using Contracts;

    public class Logger : ILogger
    {
        private readonly StringBuilder output;

        public Logger()
        {
            this.output = new StringBuilder();
        }

        public void EventAdded()
        {
            this.output.Append("Event added\n");
        }

        public void EventDeleted(int x)
        {
            if (x == 0)
            {
                this.NoEventsFound();
            }
            else
            {
                this.output.AppendFormat("{0} events deleted\n", x);
            }
        }

        public void NoEventsFound()
        {
            this.output.Append("No events found\n");
        }

        public void PrintEvent(Event eventToPrint)
        {
            if (eventToPrint != null)
            {
                this.output.Append(eventToPrint + "\n");
            }
        }

        public override string ToString()
        {
            return this.output.ToString();
        }
    }
}
