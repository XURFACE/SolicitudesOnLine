<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_CmbEstado.aspx.vb"
    ValidateRequest="false" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_CmbEstado" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script text="text/javascript">
        $(document).ready(function () {

            //            if ($("#<%= txtMontDeu.ClientID%>").val() == "0") {
            //                $("#ocultar").css("display", "none");
            //            }

            //            $("#<%= dllCamEst.ClientID%>").change(function () {

            //                var selected = $("#<%= dllCamEst.ClientID%>").val();
            //                if (selected == 4) {
            //                    $("#ocultar").css("display", "");
            //                    $("#<%= txtMontDeu.ClientID%>").val("0");
            //                }
            //                else
            //                    $("#ocultar").css("display", "none");
            //            });



        });
        function recargar() {

            var boton = $("#ctl00_ContentPlaceHolder1_btnBuscar", parent.document);
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
<body>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Cambiar&nbsp;Estado</p>
    </div>
    <table class="popup-form" style="font-weight:bold" cellpadding="1" cellspacing="1">
        <tr>
            <td>
                <label>
                    Licencia:
                </label>
            </td>
            <td colspan="3">
                <asp:Label ID="lblLic" runat="server" Text="00001-2011- PROMPERU/DPIP/"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style_r">
                <label>
                    Estado&nbsp;Actual:
                </label>
            </td>
            <td colspan="3">
                <strong>
                    <asp:Label ID="lblEval" runat="server" Text="EN EVALUACION"></asp:Label></strong>
            </td>
        </tr>
        <tr>
            <td>
                <label>
                    Cambiar&nbsp;a:
                </label>
            </td>
            <td>
                <asp:DropDownList ID="dllCamEst" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="0">EN EVALUACIÓN - DOCUMENTACIÓN</asp:ListItem>
                    <asp:ListItem Value="1">EN EVALUACIÓN - REFERENCIAS</asp:ListItem>
                    <asp:ListItem Value="2">EN EVALUACIÓN - COMITÉ</asp:ListItem>
                    <asp:ListItem Value="3">APROBADO</asp:ListItem>
                    <asp:ListItem Value="4">RECHAZADO</asp:ListItem>
                    <asp:ListItem Value="5">REVOCADO</asp:ListItem>
                    <asp:ListItem Value="6">SUSPENDIDO</asp:ListItem>
                    <asp:ListItem Value="7">SUSPENDIDO POR DEUDA</asp:ListItem>
                    <asp:ListItem Value="8">CADUCADO</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td id="ocultar1" runat="server" visible="false">
                <label>
                    Monto de Deuda:
                </label>
            </td>
            <td id="ocultar2" runat="server" visible="false">
                <asp:TextBox ID="txtMontDeu" runat="server">0</asp:TextBox>
                <asp:RegularExpressionValidator ID="revDeuda" runat="server" ControlToValidate="txtMontDeu"
                    ErrorMessage="*" ValidationExpression="^[0-9]+(\.[0-9]+)?$">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top;">
                <label>
                    Mensaje:
                </label>
            </td>
            <td class="style5" colspan="3">
                <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine" Height="350px" CssClass="textarea"
                    Width="450px" Font-Size="Small"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="4">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="mw-button" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="mw-button" OnClientClick="parent.$.modal().closePopup()" />
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="4">
                <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
    </form>
    <div class="clear">
    </div>
</body>
</html>
