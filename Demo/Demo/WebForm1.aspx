<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Demo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="lblDept" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:Button runat="server" OnClick="btmDetData" SkinID="btmDetData" Text="Get Data" Width="59px" />
        <asp:Button runat="server" OnClick="BtmInsert" Text="Insert" Width="64px" />
        <asp:Button ID="Button1" runat="server" OnClick="BtmUpdate" Text="Update" />
        <asp:Button ID="Button2" runat="server" OnClick="BtmDelete" Text="Delete" />
        <asp:Button ID="Button3" runat="server" OnClick="GetEmpoyeesByDepartment" Text="GetEmpoyeesByDepartment" />
    </form>
</body>
</html>
