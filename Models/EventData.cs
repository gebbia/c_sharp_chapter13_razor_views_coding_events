using System;

namespace CodingEvents.Models
{
    public class EventData
    {
        // store events
        private static Dictionary<int, Event> Events = new Dictionary<int, Event>();    

        // add events - Add
        public static void Add(Event newEvent)
        {
            Events.Add(newEvent.Id, newEvent);
        }

        // retrieve the events - GetAll
        public static IEnumerable<Event> GetAll()
        {
            return Events.Values;
        }

        // retrieve a single event - GetById
        public static Event GetById(int id)
        {
            return Events[id];
        }

        // remove an event -  Remove
        public static void Remove(int id)
        {
            Events.Remove(id);
        }

    }
}
