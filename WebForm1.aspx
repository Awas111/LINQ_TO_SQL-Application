<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="wwr.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView    BackColor="Yellow"  ID="GridView1" runat="server">

            </asp:GridView>
        </div>
        <p style="margin-left: 40px">
            <asp:Button ID="btngetdata" runat="server" BorderStyle="Double" OnClick="Button1_Click" Text="GetData" />
&nbsp;
            <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        &nbsp;&nbsp;
            <asp:Button ID="btndelete" runat="server" OnClick="btndelete_Click" Text="Delete" />
        &nbsp;
            <asp:Button ID="btnupdate" runat="server" OnClick="btnupdate_Click" Text="update" />
        </p>
    </form>
</body>
</html>
