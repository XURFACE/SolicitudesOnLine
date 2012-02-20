<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_Afiche.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_Afiche" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <%--<script type="text/javascript">

        $(window).load(function () {

            var ancho = $("#imgMostrar").width();
            var alto = $("#imgMostrar").height();
            var margin = 20;


            $("#modal", parent.document).width(ancho + margin);
            $("#modal", parent.document).height(alto + margin);

        });
    </script>--%>
    <style type="text/css">
        body
        {
            background: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Vista Previa</p>
    </div>
    <div style="text-align: center">
        <br />
        <asp:HyperLink ID="hprlinkImgComplete" Target="_blank" runat="server">Ver Tamaño Real</asp:HyperLink><br />
        <br />
        <asp:Image ID="imgMostrar" runat="server" AlternateText="Vista Previa" Width="498px"
            Height="498px" />
    </div>
    </form>
</body>
</html>
