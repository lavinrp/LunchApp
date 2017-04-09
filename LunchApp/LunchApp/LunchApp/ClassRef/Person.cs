using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchApp.ClassReference
{
    public class Person : IDedNamedClass
    {
        public Dictionary<Guid, double> m_debtors;
        public Dictionary<Guid, double> m_debtees;
        public List<Order> m_savedOrders;

        public Person(string name)
        {
            this.m_name = name;


            this.m_debtors = new Dictionary<Guid, double>();
            this.m_debtees = new Dictionary<Guid, double>();
            this.m_savedOrders = new List<Order>();
        }

        public void ExchangeMoney(Person recipient, double moneyAmount)
        {
            //TODO: Do money stuff now.
        }

        public bool RemoveOrder(Order orderToRemove)
        {
            if (this.m_savedOrders.Contains(orderToRemove))
            {
                this.m_savedOrders.Remove(orderToRemove);
                return true;
            }

            return false;
        }

        public Order GetOrder(Guid orderToGet)
        {
            foreach (Order iterOrder in this.m_savedOrders)
            {
                if (iterOrder.GetID() == orderToGet)
                {
                    return iterOrder;
                }
            }

            return null;
        }
    }
}