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

        protected void updateDisplayedGroup(int idx)
        {

        }

        protected void newGroup_btn_Click(object sender, EventArgs e)
        {
            groups_lstBox.Items.Add(new ListItem("Default Group"));
        }

        protected void profileSettings_btn_Click(object sender, EventArgs e)
        {

        }

        protected void groups_lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplayedGroup(groups_lstBox.SelectedIndex);
        }
    }
}