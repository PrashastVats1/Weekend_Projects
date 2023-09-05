<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebAppRegistrationForm.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    body {
        font-family: Arial, Helvetica, sans-serif;
        background-color: #f2f2f2;
    }

    .container {
        width: 50%;
        margin: 0 auto;
        background-color: #fff;
        padding: 20px;
        border-radius: 5px;
        box-shadow: 0 0 10px rgba(0, 0, 0, 0.2);
    }

    h2 {
        color: #333;
    }

    .form-group {
        margin-bottom: 20px;
    }

    label {
        display: block;
        margin-bottom: 5px;
        color: #333;
    }

    input[type="text"],
    input[type="email"] {
        width: 100%;
        padding: 10px;
        border: 1px solid #ccc;
        border-radius: 5px;
    }

    .error-message {
        color: red;
        font-size: 12px;
    }

    .btn-register {
        background-color: #007bff;
        color: #fff;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
    }

    .btn-register:hover {
        background-color: #0056b3;
    }

    .login-link {
        text-align: center;
    }

    .login-link a {
        color: #007bff;
        text-decoration: none;
    }

    .login-link a:hover {
        text-decoration: underline;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td colspan="3">
                    <asp:Label ID="Label1" runat="server" BackColor="Red" BorderColor="#000066" ForeColor="White" Text="Registration Form"></asp:Label>
                </td>
            </tr>

            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">UserName</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please Enter User Name!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Email ID</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please Enter Email Id!!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Invalid Email!!!" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">City</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter City Name" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Button ID="Button1" runat="server" ForeColor="#000066" Text="Register" OnClick="Button1_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">
                    <asp:HyperLink ID="HyperLink1" runat="server" BackColor="#3333FF" BorderColor="Black" ForeColor="White" NavigateUrl="~/Login.aspx">Back to Login Page</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
            <asp:Label ID="Label2" runat="server" ForeColor="#009933"></asp:Label>
        </div>
    </form>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
<asp:Label ID="Label4" runat="server" Text=""></asp:Label>
</body>
</html>

