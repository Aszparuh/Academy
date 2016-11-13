namespace Events
{
    using System;
    using Contracts;
    using Wintellect.PowerCollections;

    public class EventHolder : IEventHolder
    {
        private MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> byDate = new OrderedBag<Event>();
        private ILogger logger;

        public EventHolder(ILogger logger)
        {
            this.logger = logger;
        }

        public void AddEvent(Event newEvent)
        {
            this.byTitle.Add(newEvent.Title.ToLower(), newEvent);
            this.byDate.Add(newEvent);
            this.logger.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            foreach (var eventToRemove in this.byTitle[title])
            {
                removed++;
                this.byDate.Remove(eventToRemove);
            }

            this.byTitle.Remove(title);
            this.logger.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.byDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;

            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                this.logger.PrintEvent(eventToShow);

                showed++;
            }

            if (showed == 0)
            {
                this.logger.NoEventsFound();
            }
        }
    }
}
