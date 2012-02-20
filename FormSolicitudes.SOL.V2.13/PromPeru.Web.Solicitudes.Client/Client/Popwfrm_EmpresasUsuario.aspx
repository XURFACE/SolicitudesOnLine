<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Popwfrm_EmpresasUsuario.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.Popwfrm_EmpresasUsuario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/fonts.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/styles_full.css" rel="stylesheet" type="text/css" />
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Empresas registradas</p>
    </div>
    <table class="popup-form" style="margin-top: 10px; margin-bottom: 20px; margin-left: 10px;">
        <tr>
            <td style="height: 250px;">
                <asp:GridView ID="grvLstEmpresa" runat="server" AutoGenerateColumns="False" AllowPaging="True"
                    CssClass="mGrid" PageSize="5" PagerStyle-CssClass="pgr" Font-Size="6pt" Width="435px">
                    <Columns>
                        <asp:BoundField HeaderText="id" DataField="ID" Visible="False" />
                        <asp:BoundField HeaderText="Expediente" DataField="NRO_EXPEDIENTE">
                            <ItemStyle Font-Size="9px" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="RUC" HeaderText="Ruc">
                            <ItemStyle Font-Size="9px" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField HeaderText="Razón Social" DataField="RAZONSOCIAL">
                            <ItemStyle Font-Size="9px" VerticalAlign="Middle" />
                        </asp:BoundField>
                    </Columns>
                    <HeaderStyle Font-Size="8px" />
                    <PagerStyle CssClass="pgr"></PagerStyle>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <div class="content-popup">
                    <div class="buttom-popup" style="text-align: center;">
                        <asp:Button ID="btn_Cancelar" runat="server" Text="Cerrar" class="mw-button" OnClientClick="parent.$.modal().closePopup()" />
                    </div>
                </div>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
