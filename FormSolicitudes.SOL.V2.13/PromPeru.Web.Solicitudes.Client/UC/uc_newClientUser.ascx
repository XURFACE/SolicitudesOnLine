<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uc_newClientUser.ascx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.uc_newClientUser" %>
<style type="text/css">
    .btncenter
    {
        width: 250px;
        margin: 15px auto;
    }
</style>
<table class="popup-form" style="margin-left: 20px;">
    <tr>
        <td class="style_r">
            <label>
                Usuario:</label>
        </td>
        <td>
            <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ControlToValidate="txtLogin"
                ErrorMessage="Ingrese el login" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style_r">
            <label>
                Contraseña:</label>
        </td>
        <td>
            <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvPwd" runat="server" ControlToValidate="txtPwd"
                ErrorMessage="Ingrese el password" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="style_r">
            <label>
                Repetir Contraseña:</label>
        </td>
        <td>
            <asp:TextBox ID="txtpwdConf" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvPwd0" runat="server" ControlToValidate="txtpwdConf"
                ErrorMessage="Ingrese la confirmación" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cmvPw" runat="server" ErrorMessage="Las contraseñas no son iguales"
                ControlToCompare="txtPwd" ValidationGroup="Val_User" ControlToValidate="txtpwdConf">•</asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
            </label>
        </td>
        <td>
            <div class="line">
            </div>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Nombres:</label>
        </td>
        <td>
            <asp:TextBox ID="txtNom" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvNom" runat="server" ControlToValidate="txtNom"
                ErrorMessage="Ingresar el nombre" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Apellido Paterno:</label>
        </td>
        <td>
            <asp:TextBox ID="txtAP" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvAP" runat="server" ControlToValidate="txtAP" ErrorMessage="Ingresar el apellido paterno"
                ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Apellido Materno:</label>
        </td>
        <td>
            <asp:TextBox ID="txtAM" runat="server" MaxLength="50"></asp:TextBox>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvAM" runat="server" ControlToValidate="txtAM" ErrorMessage="Ingresar el apellido materno"
                ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Mail:</label>
        </td>
        <td>
            <asp:TextBox ID="txtMail" runat="server" MaxLength="150"></asp:TextBox>
            <p>
                (Debe indicar un correo corporativo)</p>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="txtMail"
                ErrorMessage="Ingresar el mail" ValidationGroup="Val_User">•</asp:RequiredFieldValidator><asp:RegularExpressionValidator
                    ID="revmail" runat="server" ControlToValidate="txtMail" ErrorMessage="Mail inválido"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Val_User">•</asp:RegularExpressionValidator>
        </td>
    </tr>
    <%--capcha--%>
    <tr>
        <td>
            <asp:Label ID="lblrotcapcha" runat="server" Text="Ingrese el codigo de la (imagen):"></asp:Label>
        </td>
        <td>
            <asp:Image ID="imgCmp" runat="server" ImageUrl="~/UC/cpchaImg.aspx" />
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <asp:TextBox ID="txtCodCatpcha" runat="server"></asp:TextBox><br />
        </td>
        <td>
            <asp:RequiredFieldValidator ID="rfvCaptcha" runat="server" ControlToValidate="txtCodCatpcha"
                ErrorMessage="Ingrese el codigo de la imagen" ValidationGroup="Val_User">•</asp:RequiredFieldValidator>
        </td>
    </tr>
</table>
<div class="buttom-conten btncenter" style=" width: auto; text-align: center;">
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="Val_User" />
    <asp:Button ID="btnUpdate" runat="server" Text="Actualizar datos" />
    <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" /><br /><br />
    <asp:ValidationSummary ID="vlasmry" ValidationGroup="Val_User" runat="server" CssClass="messbox" />
    <asp:Literal ID="lblMsg" runat="server"></asp:Literal>
</div>
<div class="clear">
</div>
<asp:HiddenField ID="hdfId" runat="server" />
