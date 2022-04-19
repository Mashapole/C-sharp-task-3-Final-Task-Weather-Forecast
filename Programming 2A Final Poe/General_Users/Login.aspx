<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="General_Users.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <div class="Heading">
             <asp:Label ID="lbl_Login" runat="server" Text="Enter Your Details To Login Please!!!"></asp:Label>
        </div><br /><br />

        <div class="Content">
            <asp:Label ID="lbl_Username" runat="server" Text="Username:"></asp:Label> <br />
            <asp:TextBox ID="txt_Username" runat="server"></asp:TextBox><br />
            <asp:Label ID="lbl_password" runat="server" Text="Password:"></asp:Label><br />
            <asp:TextBox ID="txt_Password" runat="server" OnTextChanged="txt_Password_TextChanged" TextMode="Password"></asp:TextBox><br /><br />
            <asp:Button ID="btnSign" runat="server" Text="SignIn" OnClick="btnSign_Click" /> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <asp:Button ID="btn_Login" runat="server" Text="LogIn" OnClick="btn_Login_Click" />
            <br />
            <br />
            <asp:Button ID="btn_Exit" runat="server" OnClick="btn_Exit_Click" Text="Exit" Width="170px" />
        </div>
        

    </form>
</body>
</html>
