<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="General_Users.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
      
        <div class="Heading">
            <asp:Label ID="lbl_Heading" runat="server" Text="Register Your Self Bellow and press Continue after to LogIn"></asp:Label>
        </div><br /><br />
        <div class="content">
            <asp:Label ID="lbl_Username" runat="server" Text="Username:"></asp:Label><br />
            <asp:TextBox ID="txt_Username" runat="server"></asp:TextBox><br />
            <asp:Label ID="lbl_Password" runat="server" Text="Password:"></asp:Label><br />
            <asp:TextBox ID="txt_Password" runat="server"></asp:TextBox><br />
             <asp:Label ID="lbl_Confirm" runat="server" Text="Confirm Password:"></asp:Label><br />
            <asp:TextBox ID="txt_Confirm" runat="server"></asp:TextBox><br /><br />
             <asp:Button ID="btn_Register" runat="server" Text="Register" OnClick="btn_Register_Click" /> &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp <asp:Button ID="btn_Continue" runat="server" Text="Continue" OnClick="btn_Continue_Click" />

            <br />
            <br />
            <asp:Button ID="btn_Exit" runat="server" OnClick="btn_Exit_Click" Text="Exit" Width="217px" />

        </div>
    </form>
</body>
</html>
