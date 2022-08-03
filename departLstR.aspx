<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="departLstR.aspx.cs" Inherits="WebForm1.departLstR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <div>
            <asp:Literal ID="ltTitle" runat="server" Text="部門資料維護作業"></asp:Literal>
        </div>
        <asp:Button ID="btnAdd" runat="server" Text="新增資料" OnClick="btnAdd_Click" />
&nbsp;<asp:TextBox ID="txtQry" runat="server"></asp:TextBox>
        <asp:Button ID="btnQry" runat="server" Text="查詢" OnClick="btnQry_Click" />
&nbsp; 預設資料數:<asp:TextBox ID="txtNum" runat="server" Width="28px">20</asp:TextBox>
        <br />
<asp:Repeater ID="Repeater1" runat="server">
<HeaderTemplate>
<table border="0">
<tr>
<th>部門編號</th>
<th>名稱</th>
<th>備註</th>
</tr>
</HeaderTemplate>
<ItemTemplate>
<tr>
<td><%#Eval("部門號")%></td>
<td><%#Eval("名稱")%></td>
<td><%#Eval("備註")%></td>
</tr>
</ItemTemplate>
<FooterTemplate>
</table>
</FooterTemplate>
</asp:Repeater>
        <br />
        <asp:Label ID="lbRecords" runat="server" Text="資料筆數"></asp:Label>
        <asp:Button ID="btnDelAll" runat="server" Text="刪除全部篩選的資料..." BorderColor="#FF3300" />
        <br />
    </form>
</body>
</html>
