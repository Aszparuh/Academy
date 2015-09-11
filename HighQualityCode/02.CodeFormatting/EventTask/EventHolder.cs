namespace EventTask
{
    using System;
    using Wintellect.PowerCollections;

    public class EventHolder
    {
        private MultiDictionary<string, Event> orderedByTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> orderedByDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location)
        {
            Event newEvent = new Event(date, title, location);
            this.orderedByTitle.Add(title.ToLower(), newEvent);
            this.orderedByDate.Add(newEvent); 
            Messages.EventAdded();
        }

        public void DeleteEvents(string titleToDelete)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;
            foreach (var eventToRemove in this.orderedByTitle[title])
            {
                removed++;
                this.orderedByDate.Remove(eventToRemove);
            }

            this.orderedByTitle.Remove(title);
            Messages.EventDeleted(removed);
        }

        public void ListEvents(DateTime date, int count)
        {
            OrderedBag<Event>.View eventsToShow = this.orderedByDate.RangeFrom(new Event(date, string.Empty, string.Empty), true);
            int showed = 0;
            foreach (var eventToShow in eventsToShow)
            {
                if (showed == count)
                {
                    break;
                }

                Messages.PrintEvent(eventToShow);
                showed++;
            }

            if (showed == 0)
            {
                Messages.NoEventsFound();
            }
        }
    }
}