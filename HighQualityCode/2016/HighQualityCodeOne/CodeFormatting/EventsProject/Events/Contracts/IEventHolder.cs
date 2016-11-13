namespace Events.Contracts
{
    using System;

    public interface IEventHolder
    {
        void AddEvent(Event newEvent);

        void DeleteEvents(string titleToDelete);

        void ListEvents(DateTime date, int count);
    }
}
