<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LunchApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<table style="width:100%; min-height:500px">
        <tr>
            <td>
                <asp:Button ID="newGroup_btn" runat="server" Text="New Group" OnClick="newGroup_btn_Click"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox ID="groups_lstBox" runat="server" OnSelectedIndexChanged="groups_lstBox_SelectedIndexChanged">
                    <asp:ListItem>
                        Default Group
                    </asp:ListItem>
                </asp:ListBox>
            </td>
            <td>
                <asp:MultiView ID="MultiView1" runat="server">
                    <asp:View ID="View1" runat="server">
                    </asp:View>
                </asp:MultiView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="profileSettings_btn" runat="server" Text="Profile Settings" OnClick="profileSettings_btn_Click"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="notifications_txtBox" runat="server">
                    No Notifications
                </asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
