<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Source.aspx.cs" Inherits="Redirect_Example.Source" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <a href="Target.aspx">Target.aspx</a>
            <br />
            <br />
            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="btn_Resedirect" Text="Response.Redirect" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="btn_ServerTransfer" Text="Server.Transfer" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="btn_CrossPagePostBack" PostBackUrl="~/Target.aspx" Text="Cross page post back" />

        </div>
    </form>
    <p>
        &nbsp;
    </p>
</body>
</html>
