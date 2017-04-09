﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LunchApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<table style="table-layout: fixed; width:100%; min-height:500px">
        <tr>
            <td>
                <asp:Button style="width:100%" ID="newGroup_btn" runat="server" Text="New Group" OnClick="newGroup_btn_Click"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:ListBox style="background-color:purple; color:white; width: 100%; min-height:400px" ID="groups_lstBox" runat="server" OnSelectedIndexChanged="groups_lstBox_SelectedIndexChanged" OnInit="groups_lstBox_Init">
                    <asp:ListItem>
                        Default Group
                    </asp:ListItem>
                </asp:ListBox>
            </td>
            <td>
                <h3>Attendees</h3>
                <asp:BulletedList ID="BulletedList1" runat="server">
                    <asp:ListItem Text="testest"> Testestsetsets</asp:ListItem>
                </asp:BulletedList>
            </td>
            <td>
                <h3>Events</h3>
                <asp:BulletedList ID="BulletedList2" runat="server">
                    <asp:ListItem>test2</asp:ListItem>
                </asp:BulletedList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button style="width:100%" ID="profileSettings_btn" runat="server" Text="Profile Settings" OnClick="profileSettings_btn_Click"/>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
