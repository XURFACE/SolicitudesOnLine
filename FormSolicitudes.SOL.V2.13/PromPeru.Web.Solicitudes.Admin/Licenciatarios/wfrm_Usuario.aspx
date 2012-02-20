<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_Usuario.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_Usuario" %>

<%@ Register Src="uc_newClientUser.ascx" TagName="uc_newClientUser" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/fonts.css" rel="stylesheet" type="text/css" />
    <script src="<%= Page.ResolveClientUrl("~/js/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/modal-window.min.js") %>" type="text/javascript"></script>
    <link href="../css/styles_full.css" rel="stylesheet" type="text/css" />
    <!-- Internet Explorer HTML5 enabling code: -->
    <!--[if IE]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script>
         <style type="text/css">
        .clear { zoom: 1;display: block; }
     </style><![endif]-->
    <!--[if lte IE 6]><link href="css/modal-window-ie6.css" type="text/css" rel="stylesheet" /><![endif]-->
    <script type="text/javascript">
        function cargarAplicacion() {
            var boton = parent.document.getElementById("ctl00_ContentPlaceHolder1_btnBuscar")
            parent.$.modal().closePopup();
            boton.click();
        }    
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: White">
        <div class="title-popup">
            <p>
                Datos de usuario</p>
        </div>
        <uc1:uc_newClientUser ID="uc_newClientUser1" runat="server" TipoControl="Actualiza_Datos" />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
