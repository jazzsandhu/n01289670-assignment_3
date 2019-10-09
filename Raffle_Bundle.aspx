<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raffle_Bundle.aspx.cs" Inherits="control_structres.Raffle_Bundle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h2>Input your number of tickets to purchase?</h2>
            <asp:TextBox runat="server" ID="number_of_tickets"></asp:TextBox>
            <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="number_of_tickets" ErrorMessage="please make a non-zero input"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="number_of_tickets" ErrorMessage="please make a non-zero inout" ValidationExpression="^-?[0-9]+$"></asp:RegularExpressionValidator>    
            <div id="a3" runat="server"></div>
        </section>
        <div>
           <asp:button ID="submit" runat="server" Text="Enter" />
        </div>
       
    </form>
</body>
</html>
