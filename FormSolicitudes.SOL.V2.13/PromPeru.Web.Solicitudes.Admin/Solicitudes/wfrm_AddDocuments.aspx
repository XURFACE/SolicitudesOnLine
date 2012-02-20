<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_AddDocuments.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_AddDocuments1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--Codigo para input file -->
    <link href="../js/inputfile/jquery.si.css" rel="stylesheet" type="text/css" media="all" />
    <script src="http://jqueryjs.googlecode.com/files/jquery-1.3.1.min.js" type="text/javascript"></script>
    <script src="../js/inputfile/jquery.si.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("input.file").si();
        });
    </script>
    <!-- fin del codigo para input file -->
    <script type="text/javascript">
        function cargarAplicacion() {
            var boton = parent.document.getElementById("ctl00_ContentPlaceHolder1_btn_load")
            parent.$.modal().closePopup();
            boton.click();
        }
    
    </script>
    <style type="text/css">
        body
        {
            background: #fff;
        }
    </style>
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Documentos Adicionales</p>
    </div>
    <table class="popup-form">
        <tr>
            <td>
                &nbsp;Documento solicitado:
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAplDesc" runat="server" MaxLength="250" Width="300px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="val"
                    ControlToValidate="txtAplDesc" ErrorMessage="Se requiere descripción">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btnOk" runat="server" Text="Aceptar" ValidationGroup="val" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().close()" />
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ID="ValidationSummary1" ValidationGroup="val" runat="server"
                    CssClass="messbox" />
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
