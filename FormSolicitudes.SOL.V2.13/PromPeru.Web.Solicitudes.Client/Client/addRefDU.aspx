<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="addRefDU.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.addRefDU" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript">
        function cargarUso() {
            var boton = parent.document.getElementById("ctl00_ContentPlaceHolder1_btn_load");
            parent.$.modal().closePopup();
            boton.click();
        }
    </script>
    <style type="text/css">
        .style9
        {
            width: 216px;
        }
    </style>
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Aplicación</p>
    </div>
    <div>
        <table class="popup-form">
            <tr>
                <td class="style_r2">
                    <asp:Label ID="Label1" runat="server" Text="Uso: " CssClass="label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="ddl_uso" runat="server" AutoPostBack="True">
                    </asp:DropDownList>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style_r2">
                    <asp:Label ID="Label2" runat="server" Text="Sub Tipo: " CssClass="label"></asp:Label>
                </td>
                <td colspan="2">
                    <asp:DropDownList ID="ddl_subTipo" runat="server">
                        <asp:ListItem Value="0">Pagina Web</asp:ListItem>
                        <asp:ListItem Value="1">Papeleria / Impresos</asp:ListItem>
                        <asp:ListItem Value="2">Material Insitucional</asp:ListItem>
                        <asp:ListItem Value="3">Web / Redes Sociales</asp:ListItem>
                        <asp:ListItem Value="4">Otros</asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style_r2" style="vertical-align: top;">
                    <asp:Label ID="Label3" runat="server" Text="Descripcion:" CssClass="label"></asp:Label>
                </td>
                <td valign="top" class="style9">
                    <asp:TextBox ID="txtDesc" runat="server" TextMode="MultiLine" Style="width: 200px;
                        min-width: 200px;"></asp:TextBox>
                </td>
                <td valign="top">
                    <asp:RequiredFieldValidator ControlToValidate="txtDesc" ID="rfvDesc" ValidationGroup="val" runat="server" ErrorMessage="Ingrese descripción">•</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style_r2" style="vertical-align: top;" colspan="3">
                    <div class="content-popup">
                        <div class="buttom-popup">
                            <asp:Button ID="btn_add" runat="server" Text="Aceptar" class="mw-button" ValidationGroup="val" />
                            <asp:Button ID="Button2" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().closePopup()"
                                class="mw-button" />
                        </div>
                    </div>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td class="style_r2" style="vertical-align: top;" align="center" colspan="3">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="messbox" ValidationGroup="val" />
                    <asp:Label ID="lblMessege" Visible="false" runat="server" CssClass="messbox" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
