using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchApp.ClassReference
{
    public class Event : IDedNamedClass
    {
        public string m_location;
        public DateTime m_time;
        public Person m_runner;

        public Dictionary<Guid, Order> m_attendeeOrders;
        public List<Person> m_attendees;

        public Event(string name, string location, DateTime time)
        {
            this.m_name = name;


            this.m_location = location;
            this.m_time = time;

            this.m_attendeeOrders = new Dictionary<Guid, Order>();
            this.m_attendees = new List<Person>();
        }

        public bool PlaceOrder()
        {
            //TODO: Place the order, and manage all the stuff.
            return true;
        }

        public bool RemoveAttendee(Person attendeeToRemove)
        {
            if (this.m_attendees.Contains(attendeeToRemove))
            {
                this.m_attendees.Remove(attendeeToRemove);
                return true;
            }

            return false;
        }
    }
}