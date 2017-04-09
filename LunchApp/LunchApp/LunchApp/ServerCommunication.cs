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

        private static List<Group> CreateGroup()
        {
            return new List<Group>();
        }

        private static List<Event> CreateEvent()
        {
            return new List<Event>();
        }

        public static Event getDailyEvent(Guid personalID)
        {
            return new Event("Wednesday Foo", "CHIPOTLE", DateTime.Today);
        }

        public static Group getGroupName(Guid personalID)
        {
            Group returnGroup = new Group("Cracker Barrel Group");
            Event returnEvent = new Event("Wednesday Foo", "CHIPOTLE", DateTime.Today);
            returnGroup.m_events.Add(returnEvent);
            Person Chris = new Person("Chris");
            Person Brian = new Person("Brian");
            Person Ryan = new Person("Ryan");
            returnGroup.m_groupees.Add(Chris);
            returnGroup.m_groupees.Add()
            returnGroup.m_groupees.Add(Ryan);
            return 
        }

        public static 
    }
}