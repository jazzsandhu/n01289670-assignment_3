<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Weekly_Calender.aspx.cs" Inherits="control_structres.Weekly_Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>your weekly calender for october month as follows:</h2>
            <asp:CheckBoxList ID="working_days" runat="server">
                <asp:ListItem Value="Monday">Monady</asp:ListItem>
                <asp:ListItem Value="Tuesday">Tuesday</asp:ListItem>
                <asp:ListItem Value="Wednesday">Wednesday</asp:ListItem>
                <asp:ListItem Value="Thursday">Thursday</asp:ListItem>
                <asp:ListItem Value="Friday">Friday</asp:ListItem>
                <asp:ListItem Value="Saturday">Saturday</asp:ListItem>
                <asp:ListItem Value="Sunday">Sunday</asp:ListItem>
            </asp:CheckBoxList>
            <div id="a2" runat="server"></div>
        </section>
        <div>
           <asp:button ID="submit" runat="server" Text="Enter" />
        </div>
       
    </form>
</body>
</html>
