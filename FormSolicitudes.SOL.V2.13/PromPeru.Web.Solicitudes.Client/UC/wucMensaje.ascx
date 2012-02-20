<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="wucMensaje.ascx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wucMensaje" %>
<div id="Div1" style="max-width: 450px; min-width: 50px;">
    <table style="text-align: center; max-width: 450px; min-width: 50px; font-family: Arial, Helvetica, sans-serif;
        height: auto; margin: 2px 2px 2px 2px; padding: 0px; text-align: left;" runat="server"
        id="Div_Msg">
        <tr>
            <td runat="server" id="tdTitMensaje">
                <asp:Label ID="lblTitMensaje" runat="server" Text=" < Titulo del Mensaje > " Width="100%"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="left">
                <asp:Label ID="lblCuerpoMsg" CssClass="Con_FormGrillaItemStyleMull" runat="Server"
                    Text="< Cuerpo de mensaje >" Width="95%"></asp:Label>
            </td>
        </tr>
        <tr>
            <td align="center">
                <asp:Button ID="btnAceptarOk" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"
                    ValidationGroup="novalida" CssClass="Boton" Font-Size="8pt" />
                <asp:Button ID="btnCancelar" runat="server" Font-Size="8pt" Text="Cancelar" Visible="False" />
            </td>
        </tr>
    </table>
</div>