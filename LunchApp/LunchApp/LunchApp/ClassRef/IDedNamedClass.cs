using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LunchApp.ClassReference
{


    public class IDedNamedClass
    {
        public string m_name = "";
        protected Guid m_id;

        public IDedNamedClass()
        {
            this.m_id = Guid.NewGuid();
        }

        public Guid GetID()
        {
            return this.m_id;
        }
    }
}