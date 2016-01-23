<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="HelloApp.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="tb" runat="server" placeholder="Enter your name"/>
            <button id="button" runat="server" onserverclick="OnButtonClick">Greet me</button>
            <span id="span" runat="server"></span>
        </div>
        <div id="div" runat="server"></div>
    </form>
</body>
</html>
