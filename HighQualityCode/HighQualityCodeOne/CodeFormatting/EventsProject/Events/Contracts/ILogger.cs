namespace Events.Contracts
{
    public interface ILogger
    {
        void EventAdded();

        void EventDeleted(int x);

        void NoEventsFound();

        void PrintEvent(Event eventToPrint);
    }
}
