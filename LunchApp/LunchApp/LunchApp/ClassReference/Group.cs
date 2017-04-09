using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchApp.ClassReference
{
    public class Group : IDedNamedClass
    {
        public List<Person> m_groupees;
        public List<Event> m_events;

        public Group(string name)
        {
            this.m_name = name;

            this.m_groupees = new List<Person>();
            this.m_events = new List<Event>();
        }

        public void PayMoney(Guid toPerson, Guid fromPerson, double moneyGiven)
        {
            //TODO: Do some more money stuff here.
        }

        public bool RemoveGroupee(Person groupeeToRemove)
        {
            if (this.m_groupees.Contains(groupeeToRemove))
            {
                this.m_groupees.Remove(groupeeToRemove);
                return true;
            }

            return false;
        }

        public bool RemoveEvent(Event eventToRemove)
        {
            if (this.m_events.Contains(eventToRemove))
            {
                this.m_events.Remove(eventToRemove);
                return true;
            }

            return false;
        }
    }
}