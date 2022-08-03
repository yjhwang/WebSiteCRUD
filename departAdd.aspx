﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="departAdd.aspx.cs" Inherits="WebForm1.departAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
<form id="form1" runat="server">
<div id="AlertMessage" title="信息确认">
    <p id="AlertMessageBody"  class="msgbody"></p>
</div>
<div id="ConfirmMessage" title="信息提问">
    <p id="ConfirmMessageBody" class="msgbody""></p>
</div>
        <div>
            <asp:Label ID="lbTitle" runat="server" Font-Size="X-Large" Text="新增部門資料"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="編號"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="名稱"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" Width="260px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="備註"></asp:Label>
            <asp:TextBox ID="txtRemark" runat="server" Height="63px" Width="262px"></asp:TextBox>
            <br />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="取消" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="確定" />
        </div>
    </form>
</body>
</html>
