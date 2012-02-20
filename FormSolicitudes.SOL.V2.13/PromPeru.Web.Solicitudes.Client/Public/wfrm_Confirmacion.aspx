<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master"
    CodeBehind="wfrm_Confirmacion.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_Confirmacion" %>

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
                    Se le ha enviado un correo con un codigo de confirmacion a la direccion que usted
                    proporciono (<asp:Label ID="lblMail" runat="server" Text="mail@mail.com"></asp:Label>).
                    Ingrese el codigo dado en el cuadro para proseguir, si aun no recibe
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
                    <asp:Label ID="lblMessege" Visible="false" runat="server" CssClass="messbox" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <div class="buttom-conten">
                        <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar" ValidationGroup="ValConf" /></div>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
