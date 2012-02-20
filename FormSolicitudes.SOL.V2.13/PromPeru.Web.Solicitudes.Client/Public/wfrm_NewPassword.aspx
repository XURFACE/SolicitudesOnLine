<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master"
    CodeBehind="wfrm_NewPassword.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_NewPassword" %>

<%@ Register Src="../UC/uc_changePwd.ascx" TagName="uc_changePwd" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body" style="padding: 15px">
        <h4>
            Confirmación
        </h4>
    </div>
    <div class="contenet-form" style="padding: 15px">
        <table>
            <tr>
                <td>
                    Ingrese el código de restauracion que se le envió a:
                    <asp:Label ID="lblMail" runat="server" Text="mail@mail.com"></asp:Label>, una vez
                    que envies la confirmación se te enviará a tu correo tu nueva contraseña.
                </td>
            </tr>
            <tr>
                <td>
                    Código de confirmacion:
                    <asp:TextBox ID="txtValidacion" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                        ID="rfvConfirm" runat="server" ErrorMessage="Ingrese el codigo" ControlToValidate="txtValidacion"
                        ValidationGroup="ValConf">•</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td align="center" style="padding: 5px">
                    <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <div class="buttom-conten">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Continuar" ValidationGroup="ValConf" /></div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
