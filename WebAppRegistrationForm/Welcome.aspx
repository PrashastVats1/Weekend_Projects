<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="WebAppRegistrationForm.Welcome" %>

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

    .welcome-message {
        margin-bottom: 20px;
        color: #333;
        font-size: 18px;
    }

    .username-label {
        color: #007bff;
        font-weight: bold;
    }

    .password-label {
        color: #007bff;
        font-weight: bold;
    }

    .logout-link {
        text-align: center;
    }

    .logout-link a {
        color: #007bff;
        text-decoration: none;
    }

    .logout-link a:hover {
        text-decoration: underline;
    }
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Login Success!!! Welcome to Company Website!!</h2>
        </div>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
