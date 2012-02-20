<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/MainMasterPage.Master"
    CodeBehind="wfrm_MailMasivo.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_MailMasivo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Correos masivos</h4>
    </div>
    <br />
    <table class="popup-form">
        <tr>
            <td>
                <label>
                    Título:
                </label>
            </td>
            <td>
                <asp:TextBox ID="txtTitulo" runat="server" Width="426px"></asp:TextBox><asp:RequiredFieldValidator
                    ID="rfvTitulo" ControlToValidate="txtTitulo" runat="server" ErrorMessage="Ingrese el titulo del mensaje">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <label>
                    Sub título:
                </label>
            </td>
            <td>
                <asp:TextBox ID="txtSubTitulo" runat="server" Width="426px"></asp:TextBox><asp:RequiredFieldValidator
                    ID="rfvsbTitulo" ControlToValidate="txtSubTitulo" runat="server" ErrorMessage="Ingrese el titulo del mensaje">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top;">
                <label>
                    Mensaje:
                </label>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtMsg" runat="server" TextMode="MultiLine" Height="350px" CssClass="textarea"
                    Width="450px" Font-Size="Small"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" class="mw-button" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" class="mw-button" />
                    </div>
                </div>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top;padding: 15px;text-align: center;" colspan="2">
                <asp:Label ID="lblmsgResumen" CssClass="messbox" Style="font-size: 15px; color: black;"
                    runat="server" Visible="false" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: top;" colspan="2">
                <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
            </td>
        </tr>
    </table>
</asp:Content>
