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
        protected void updateDisplayGroup(int index)
        {
            //Group groupToDisplay = getGroupInfo(index);get group data
            
        }
        protected void newGroup_btn_Click(object sender, EventArgs e)
        {
            groups_lstBox.Items.Add(new ListItem("Default Group"));
        }

        protected void profileSettings_btn_Click(object sender, EventArgs e)
        {

        }

        protected void View1_Init(object sender, EventArgs e)
        {

        }

        //, System.Web.UI.WebControls.BulletedList AttendeeList
        public bool PopulateGroupList(int groupNum)
        {
            //AttendeeList.Items.Clear();
            //foreach (var attendee in )
            //{
            //    ListItem li = new ListItem();
                //li.Value = "*.html";  //html goes here i.e.  xtab1.html
            //    li.Text = attendee.m_name;  //text name goes i.e. here tab1
                //AttendeeList.Items.Add(li);
            //}
            return false;
        }

    }
}