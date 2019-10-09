<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cordinate.aspx.cs" Inherits="control_structres.control" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>These quadrant would lie in coordinate of:</h1>
            <div>
                <label>value of 'x'</label>
                <asp:TextBox runat="server" ID="quadrpole_x"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="quadrpole_x" ErrorMessage="please make a non-zero input"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="quadrpole_x" ErrorMessage="please make a non-zero inout" ValidationExpression="^-?[0-9]+$"></asp:RegularExpressionValidator>    
            </div>
            <div>
                <label>value of 'y'</label>
                <asp:TextBox runat="server" ID="quadrpole_y"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" EnableClientScript="true" ControlToValidate="quadrpole_y" ErrorMessage="please make a non-zero input"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" EnableClientScript="true" ControlToValidate="quadrpole_y" ErrorMessage="please make a non-zero inout" ValidationExpression="^-?[0-9]+$"></asp:RegularExpressionValidator>    
            </div>
            <div id="a1" runat="server"></div>
        </section>
        <div>
           <asp:button ID="submit" runat="server" Text="Enter" />
        </div>
       
    </form>
</body>
</html>
