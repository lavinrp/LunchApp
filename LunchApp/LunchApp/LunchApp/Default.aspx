<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LunchApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    

    <asp:TextBox ID="TextBox1" runat="server" Height="23px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>

    

    <asp:Table ID="Table1" runat="server" Height="314px" Width="749px">
    </asp:Table>

    

</asp:Content>
