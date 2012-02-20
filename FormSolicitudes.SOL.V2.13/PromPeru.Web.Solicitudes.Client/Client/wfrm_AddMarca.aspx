<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_AddMarca.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.wfrm_AddMarca" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--Codigo para input file -->
    <link href="../js/inputfile/jquery.si.css" rel="stylesheet" type="text/css" media="all" />
    <script src="http://jqueryjs.googlecode.com/files/jquery-1.3.1.min.js" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/inputfile/jquery.si.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("input.file").si();
        });
    </script>
    <!-- fin del codigo para input file -->
    <script type="text/javascript">
        function cargarAplicacion() {
            var boton = parent.document.getElementById("ctl00_ContentPlaceHolder1_btn_loadPage")
            parent.$.modal().closePopup();
            boton.click();
        }
    
    </script>
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Marca</p>
    </div>
    <table class="popup-form">
        <tr>
            <td>
                <label>
                    Nombre de la Marca:</label>
            </td>
            <td>
                <asp:TextBox ID="txtMarca" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvMarca" runat="server" ControlToValidate="txtMarca"
                    ValidationGroup="val" ErrorMessage="Ingrese el nombre de la marca">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                Registro de INDECOPI:
            </td>
            <td colspan="2">
                <cc1:FileUploaderAJAX ID="FUAjaxIndecopi" runat="server" text_Add="Adjuntar Ref"
                    text_Uploading="Subiendo.." CssClass="fileAjax" MaxFiles="1" />
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btn_add" runat="server" Text="Agregar" ValidationGroup="val" />
                        <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().close()" />
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="3" align="center">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="messbox"
                    ValidationGroup="val" /><br />
                <asp:Label ID="lblMessege" Visible="false" runat="server" CssClass="messbox" ForeColor="#a45d59"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
