using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LunchApp.ClassReference;

namespace LunchApp
{
    public static class ServerCommunication
    {
        private static List<Person> CreatePeople()
        {
            return new List<Person>();
        }

        private static List<Event> CreateEvent()
        {
            List<Group> returnGroup = CreateGroup();
            return new List<Event>();
        }

        private static List<Group> CreateGroup()
        {   
            List<Person> returnPerson = CreatePeople();
            List<Event> returnEvent = CreateEvent();
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