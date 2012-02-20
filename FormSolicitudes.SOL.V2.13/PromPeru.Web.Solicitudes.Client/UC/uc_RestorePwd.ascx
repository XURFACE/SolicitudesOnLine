<%@ Control Language="vb" AutoEventWireup="false" CodeBehind="uc_RestorePwd.ascx.vb"
    Inherits="PromPeru.Web.Solicitudes.Client.uc_RestorePwd" %>
<%@ Register Src="wucMensaje.ascx" TagName="wucMensaje" TagPrefix="uc1" %>
<style type="text/css">
    table.tblstyle1
    {
        width: 425px;
        margin-top: 30px;
        margin-left: 20px;
        margin-right: 20px;
    }
    table.tblstyle1 tr td input[type=text]
    {
        height: 20px;
        width: 220px;
        margin: 5px;
        border: 1px solid #ccc;
    }
    table.tblstyle1 tr td input[type=password]
    {
        height: 20px;
        width: 220px;
        margin: 5px;
        border: 1px solid #ccc;
    }
    table.tblstyle1 tr td a:active
    {
        color: #EE2E24;
        text-decoration: underline;
    }
    table.tblstyle1 tr td a:hover
    {
        color: #EE2E24;
        text-decoration: underline;
    }
    table.tblstyle1 tr td a
    {
        color: #EE2E24;
    }
    table.tblstyle1 tr td p
    {
        font-size: 10px;
        color: #888888;
        margin-left: 5px;
    }
    table.tblstyle1 tr td input[type=text]:focus
    {
        outline: none;
        border: 1px solid #ee2d23;
    }
    table.tblstyle1 tr td input[type=password]:focus
    {
        outline: none;
        border: 1px solid #ee2d23;
    }
    table.tblstyle1 tr td label, span.label
    {
        margin-right: 20px;
        margin-left: 20px;
    }
    
    .btncenter
    {
        width: 225px;
        margin: 0 auto;
    }
</style>

 <table class="popup-form">
    <tr>
        <td>
            <label>
                Ingrese su Usuario o Mail</label>
        </td>
        <td>
            <asp:TextBox ID="txtusrMail" MaxLength="50" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <label>
                Ingrese el codigo que se muestra en la imagen</label>
        </td>
        <td>
            <asp:Image ID="imgCmp" runat="server" ImageUrl="~/UC/cpchaImg.aspx" />
            <%--<img src="cpchaImg.aspx">--%>
            <br />
            <asp:TextBox ID="txtCodCatpcha" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCaptcha" runat="server" ControlToValidate="txtCodCatpcha"
                ErrorMessage="Ingrese el codigo de la imagen">•</asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td align="center" colspan="2" style="padding:5px">
            <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        <div class="buttom-conten buttom-right" style="margin-right:20px; margin-top:10px;">
                <asp:Button ID="btnSolicitar" runat="server" Text="Restaurar" />
            </div>
        </td>
    </tr>
</table>

<div class="clear">
</div>
