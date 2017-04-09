using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LunchApp.ClassReference;

namespace LunchApp
{
    public partial class _Default : Page
    {
        Event defualtDailyEvent;
        protected void Page_Load(object sender, EventArgs e)
        {
            defualtDailyEvent = ServerCommunication.getDailyEvent(Guid.NewGuid());
            TextBox1.Text = defualtDailyEvent.m_name;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}