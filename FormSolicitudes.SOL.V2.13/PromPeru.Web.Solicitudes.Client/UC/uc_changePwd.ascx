<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uc_changePwd.ascx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.uc_changePwd" %>
<%@ Register Src="wucMensaje.ascx" TagName="wucMensaje" TagPrefix="uc1" %>
<div class="title-popup">
    <p>
        Cambiar Contraseña</p>
</div>
<table class="popup-form">
    <tr>
        <td>
            <label>
                Password Actual:</label>
        </td>
        <td>
            <asp:TextBox ID="txtPwdact" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPwdact"
                ErrorMessage="Ingrese el password" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Nueva Password:</label>
        </td>
        <td>
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPwd"
                ErrorMessage="Ingrese el password" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Repetir Password:</label>
        </td>
        <td>
            <asp:TextBox ID="txtpwdConf" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtpwdConf"
                ErrorMessage="Ingrese la confirmación" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Las contraseñas no son iguales"
                ControlToCompare="txtPwd" ValidationGroup="Val_User" ControlToValidate="txtpwdConf">•</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <div class="content-popup">
                <div class="buttom-popup">
                    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="Val_User" />
                    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().closePopup()"/>
                </div>
            </div>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:ValidationSummary ID="vlasmry" ValidationGroup="Val_User" CssClass="messbox"
                runat="server" />
            <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:HiddenField ID="hfdldLogin" runat="server" />
            <asp:HiddenField ID="hfdldNew" runat="server" />
        </td>
    </tr>
</table>
