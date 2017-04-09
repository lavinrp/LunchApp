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
        protected void updateDisplayedGroup(int index)
        {
            PopulateDisplayedGroupList(index);
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
        public bool PopulateDisplayedGroupList(int groupNum)
        {
            List<Group> dummygroups = ServerCommunication.GetGroups();
            Group dumbGroup = dummygroups[groupNum];
            BulletedList1.Items.Clear();
            BulletedList2.Items.Clear();

            foreach (var attendee in dumbGroup.m_groupees)
            {
                ListItem li = new ListItem();
                //li.Value = "*.html";  //html goes here i.e.  xtab1.html
                li.Text = attendee.m_name;  //text name goes i.e. here tab1
                BulletedList1.Items.Add(li);
            }
            foreach (var group_event in dumbGroup.m_events)
            {
                ListItem li = new ListItem();
                li.Text = group_event.m_name;
                BulletedList2.Items.Add(li);
            }
            return false;
        }

        protected void groups_lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplayedGroup(groups_lstBox.SelectedIndex);
        }

        protected void groups_lstBox_Init(object sender, EventArgs e)
        {
            var avialableGroups = ServerCommunication.GetGroups();
            groups_lstBox.Items.Clear();
            foreach (var group in avialableGroups)
            {
                groups_lstBox.Items.Add(group.m_name);
            }
        }
    }
}