<%@ Page Title="Calander for Real" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="True" CodeBehind="Calander.aspx.cs" Inherits="LunchApp.Calander" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <h3>This a calender to view your events for the day <asp:Calendar ID="Calendar1" runat="server" Height="323px" Width="554px" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:TextBox ID="TextBox1" runat="server" Height="56px" Width="268px"></asp:TextBox>
    </h3>
    <p>Use this area to provide additional information.</p>
</asp:Content>
