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
        }

        protected void createGroup_btn_Click(object sender, EventArgs e)
        {
        }

        protected void groupList_lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}