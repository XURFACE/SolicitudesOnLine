<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uc_Login.ascx.vb" Inherits="PromPeru.Web.Solicitudes.Client.uc_Login" %>
<table class="popup-form" style="margin-left:0px;">
    <tr>
        <td>
        <label>Usuario:</label>
        </td>
        <td>
         <asp:TextBox ID="txtlogin" MaxLength="50" runat="server"></asp:TextBox>
        </td>
        <td>
        <asp:RequiredFieldValidator ID="rfvLogin" ControlToValidate="txtlogin" runat="server"
                ErrorMessage="Ingrese el usuario" ValidationGroup="ValLogin">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
           <label>Contraseña:</label> 
        </td>
        <td>
           <asp:TextBox ID="txtPwd" MaxLength="50" runat="server" TextMode="Password"></asp:TextBox>
        </td>
        <td>
         <asp:RequiredFieldValidator ID="rfvPwd" ControlToValidate="txtPwd" runat="server"
                ValidationGroup="ValLogin" ErrorMessage="Ingrese el Password">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
            <a href="#"></a>
             <asp:HyperLink ID="lnkOPwd" runat="server" href="../Public/wfrm_RestorePwd.aspx" class="enlace"
                    OnClick="$(this).modal({width:600, height:250}).open(); return false;">¿Olvido su clave?</asp:HyperLink>
        </td>
        <td>
        </td>
    </tr>
</table>
<div class="clear"></div>
<div class="buttom-conten btncenter">
		   <asp:Button ID="btningresar" ValidationGroup="ValLogin" runat="server" Text="Ingresar" />
            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
            <br/>
            <br/>
            <asp:ValidationSummary ID="vldSmr" ValidationGroup="ValLogin" runat="server" 
               CssClass="messbox" />
</div>

<div class="clear">
</div>
            <asp:Label ID="lblMsg" runat="server"></asp:Label>



