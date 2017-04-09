<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventForm.aspx.cs" Inherits="LunchApp.EventForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 100%;">
            <tr>
                <td>
                    <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Event Name"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>

        </table>
    
    </div>
    </form>
</body>
</html>
