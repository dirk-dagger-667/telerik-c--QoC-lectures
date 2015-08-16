namespace CodeFormatting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class EventHolder
    {
        private MultiDictionary<string, Event> byTitle = new MultiDictionary<string, Event>(true);
        private OrderedBag<Event> byDate = new OrderedBag<Event>();

        public void AddEvent(DateTime date, string title, string location, StringBuilder output)
        {
            Event newEvent = new Event(date, title, location);
            byTitle.Add(title.ToLower(), newEvent);
            byDate.Add(newEvent);
            Messages.EventAdded(output);
        }

        public void DeleteEvents(string titleToDelete, StringBuilder output)
        {
            string title = titleToDelete.ToLower();
            int removed = 0;

            if (byTitle[title] != null)
            {
                removed++;
                byDate.Remove(byTitle[title]);
            }

            byTitle.Remove(title);
            Messages.EventDeleted(removed, output);
        }

        public void ListEvents(DateTime date, int count, StringBuilder output)
        {
            OrderedBag<Event> eventsToShow = byDate.RangeFrom(new Event(date, "", ""), true);
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
                Messages.NoEventsFound(output);
            }
        }
    }
}
