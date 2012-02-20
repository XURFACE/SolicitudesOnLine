<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_Ejemplo.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_Ejemplo" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
</head>
<body>
    <style type="text/css">
        body
        {
            background: #fff;
        }
        .img-popup
        {
            width: 200px;
            margin: 20px;
        }
        .img-popup img
        {
            width: 200px;
            height: 275px;
        }
    </style>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Datos de Ejemplo</p>
    </div>
    <table class="popup-form">
        <tr>
            <td valign="top">
                <label>
                    Descripción:</label>
            </td>
            <td>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td valign="top" colspan="2">
                <asp:TextBox ID="txtDesc" runat="server" Style="max-width: 310px; min-width: 310px; max-height:120px; min-height:120px"
                    MaxLength="250" Height="75px" TextMode="MultiLine" Width="250px"></asp:TextBox>
            </td>
            <td valign="top">
                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="Ingrese la descripción"
                    ValidationGroup="Valejm" ControlToValidate="txtDesc">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <label>
                    Tipo Licencia:</label>
            </td>
            <td>
                <div class="rowElem">
                    <asp:DropDownList ID="ddltipoLic" runat="server">
                        <asp:ListItem>INSTITUCIONAL</asp:ListItem>
                        <asp:ListItem>PRODUCTO</asp:ListItem>
                        <asp:ListItem>EVENTO</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <label>
                    Activado:</label>
            </td>
            <td>
                <asp:RadioButton ID="rdbSI" runat="server" Text="SI" GroupName="ActEjm" Checked="true" />
                <asp:RadioButton ID="rdbNO" runat="server" Text="NO" GroupName="ActEjm" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr id="trImg" runat="server">
            <td>
                <br />
                <label>
                    Imagen:</label>
            </td>
            <td colspan="2" style="height: 50px">
                <cc1:FileUploaderAJAX ID="FUAjaxEjm" runat="server" text_Add="Adjuntar Imagen" text_Uploading="Subiendo..."
                    CssClass="fileAjax" MaxFiles="1" text_Delete="Eliminar" text_X="[x]" />
                <%--<asp:FileUpload ID="FU_copiaEjm" runat="server" class="file"/>
                <asp:RegularExpressionValidator ID="revFUEJM" runat="server" ErrorMessage="Ejemplos formato permitidos: jpg, JPG, gif, GIF, jpeg, JPEG, bmp, BMP, png, PNG"
                    ValidationGroup="Valejm" ControlToValidate="FU_copiaEjm" ValidationExpression="(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$">•</asp:RegularExpressionValidator>--%>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="Valejm" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" ValidationGroup="Valejm" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().closePopup();" />
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td align="center" colspan="3">
                <asp:ValidationSummary ID="vlasmry" runat="server" CssClass="messbox" ValidationGroup="Valejm" />
                <asp:Label runat="server" ID="lblMsg" CssClass="messbox" Visible="false"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
