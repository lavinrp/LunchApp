using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LunchApp.ClassReference;

namespace LunchApp
{
    public static class ServerCommunication
    {
        private static List<String> CreateLocations()
        {
            List<String> returnLocations = new List<String>();
            for (int x = 0; x < 10; x++)
            {
                returnLocations.Add("Location " + x);
            }
            return returnLocations;
        }

        private static List<Order> CreateOrders()
        {
            return new List<Order>();
        }

        private static List<Person> CreatePeople()
        {
            return new List<Person>();
        }

        private static List<Event> CreateEvents()
        {
            List<String> returnLocations = CreateLocations();
            List<Order> returnOrders = CreateOrders();
            List<Person> returnPeople = CreatePeople();
            List<Event> returnEvent = new List<Event>();
            for (int x = 0; x < 10; x++)
            {
                returnEvent.Add(new Event(("Event " + x), returnLocations[x], DateTime.Today));
            }
            return returnEvent;
        }

        private static List<Group> CreateGroups()
        {   
            List<Person> returnPerson = CreatePeople();
            List<Event> returnEvent = CreateEvents();
            Guid.NewGuid();
            List<Group> returnGroups = new List<Group>();
            for (int x = 0; x < 10; x++)
            {
                returnGroups.Add(new Group("Group " + x));
            }
            return returnGroups;
        }

        public static Event getDailyEvent(Guid personalID)
        {
            return new Event("Wednesday Foo", "CHIPOTLE", DateTime.Today);
        }

        public static Group getGroupName(Guid personalID)
        {
            return new Group("dummy");
        }

    }
}