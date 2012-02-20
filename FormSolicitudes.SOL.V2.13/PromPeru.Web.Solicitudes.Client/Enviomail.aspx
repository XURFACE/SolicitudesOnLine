<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Enviomail.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.Envio_de_mail" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/modal-window.css" rel="stylesheet" type="text/css" />
    
    <script src="js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="js/modal-window.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:Button ID="btn1" runat="server" style="height: 26px" Text="SendSimpleMessage" /><br />
        <asp:Button ID="btn2" runat="server" style="height: 26px" Text="EnvioEmail" />
         <asp:HyperLink ID="lnkBuscar" runat="server" href="Public/wfrm_FAQ.aspx" class="enlace"
                    OnClick="$(this).modal({width:740, height:450}).open(); return false;">Buscar</asp:HyperLink>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
    </form>
</body>
</html>
