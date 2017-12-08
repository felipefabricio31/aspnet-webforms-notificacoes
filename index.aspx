<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="MENSAGEM_ALERTS.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link href="notificacoes.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnMensagem" runat="server" Text="Clique" OnClick="btnMensagem_Click1"/>
    </div>

        <div id="snackbar">Some text some message..</div>

        <script src="notificacao.js"></script>        
    </form> 

</body>
</html>
