using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchApp.ClassReference
{
    public class Order : IDedNamedClass
    {
        public string m_text;
        public double m_price;

        // Constructor:
        public Order(string name, string text, double price)
        {
            this.m_name = name;


            this.m_text = text;
            this.m_price = price;
        }
    }
}