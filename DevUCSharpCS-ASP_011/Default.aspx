<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DevUCSharpCS_ASP_011.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Is
            <asp:TextBox ID="firstTextBox" runat="server"></asp:TextBox>
&nbsp;equal to
            <asp:TextBox ID="secondTextBox" runat="server"></asp:TextBox>
&nbsp;?<br />
            <br />
            <br />
            <asp:CheckBox ID="awesomeCheckBox" runat="server" Text="Are you awesome?" />
            <br />
            <br />
            <asp:RadioButton ID="pizzaRadioButton" runat="server" Checked="True" GroupName="FoodGroup" Text="Pizza" />
            <br />
            <asp:RadioButton ID="saladRadioButton" runat="server" GroupName="FoodGroup" Text="Salad" />
            <br />
            <asp:RadioButton ID="pbjRadioButton" runat="server" GroupName="FoodGroup" Text="Peanut Butter and Jelly" />
            <br />
            <br />
            <asp:Button ID="okButton" runat="server" OnClick="Button1_Click" Text="OK" />
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
