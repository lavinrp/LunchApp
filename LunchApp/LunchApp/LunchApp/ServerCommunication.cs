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

            Order order1 = new Order("Chipotle", "Burito", 8.57);
            Order order2 = new Order("TacoBell", "Taco", 100.57);
            Order order3 = new Order("Currito", "Buritos", 2000.57);

            List<Order> newOrders = new List<Order>();
            newOrders.Add(order1);
            newOrders.Add(order2);
            newOrders.Add(order3);

            return new List<Order>();
        }
    
        private static List<Person> CreatePeople()
        {
            List<Person> returnPeople = new List<Person>();

            for (int i = 0; i < 5; i++)
            {
                string name = "Person Name " + i;
                Person person = new Person(name);

                if (i > 0)
                {
                    //assign debt
                    person.m_debtors.Add(returnPeople[i - 1].GetID(), i);
                    returnPeople[i - 1].m_debtees.Add(person.GetID(), i);
                }

                person.m_savedOrders = CreateOrders();

                returnPeople.Add(person);

            }
            return new List<Person>();
        }

        private static List<Event> CreateEvents(Group owningGroup)
        {
            List<string> returnLocations = CreateLocations();
            List<Order> returnOrders = CreateOrders();
            List<Person> returnPeople = CreatePeople();
            List<Event> returnEvent = new List<Event>();
            for (int x = 0; x < 10; x++)
            {
                returnEvent.Add(new Event(("Event " + x), returnLocations[x], owningGroup.m_name, DateTime.Today));
            }
            return returnEvent;
        }

        private static List<Group> CreateGroups()
        {   
            List<Group> returnGroups = new List<Group>();
            for (int x = 0; x < 10; x++)
            {
                returnGroups.Add(new Group("Group " + x));
            }
            return returnGroups;
        }

        public static Event getDailyEvent(Guid personalID)
        {
            return new Event("Wednesday Foo", "CHIPOTLE", "nothing_string", DateTime.Today);
        }

        public static Group getGroupName(Guid personalID)
        {
            return new Group("dummy");
        }

        public static Group createDummyGroup()
        {
            Group dummyGroup = new Group("Dummy Group");
            for (var i = 0; i < 10; i++)
            {
                string name = "Person Name " + i;
                Person person = new Person(name);
                dummyGroup.m_groupees.Add(person);
            }
            return dummyGroup;
        }

    }
}