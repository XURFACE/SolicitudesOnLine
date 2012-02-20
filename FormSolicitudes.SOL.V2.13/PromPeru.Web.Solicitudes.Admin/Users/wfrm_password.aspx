<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_password.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_password" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <style type="text/css">
        body
        {
            background: #fff;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Cambiar Contraseña</p>
    </div>
    <div>
        <table class="popup-form">
            <tr>
                <td>
                    <label>
                        Contraseña actual:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtPwdact" runat="server" MaxLength="50" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPwdact"
                        ErrorMessage="Ingrese la Contraseña" ValidationGroup="ValPwd">•</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Nueva Password:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvpwd" runat="server" ControlToValidate="txtpwd"
                        ErrorMessage="Ingrese Contraseña" ValidationGroup="ValPwd">•</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    <label>
                        Repetir nueva Password:</label>
                </td>
                <td>
                    <asp:TextBox ID="txtpwd0" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="pwd0" runat="server" ControlToValidate="txtpwd0"
                        ErrorMessage="Ingrese Contraseña" ValidationGroup="ValPwd">•</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cmpval" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtpwd0"
                        ErrorMessage="Las Contraseña no son iguales" ValidationGroup="ValPwd">•</asp:CompareValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <div class="content-popup">
                        <div class="buttom-popup">
                            <asp:Button ID="btnPwd" runat="server" Text="Cambiar" ValidationGroup="ValPwd" />
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClientClick="parent.$.modal().closePopup()" />
                        </div>
                    </div>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:ValidationSummary ID="vlasmry" runat="server" CssClass="messbox" ValidationGroup="ValPwd" />
                    <asp:Label runat="server" ID="lblMsg" CssClass="messbox" Visible="false" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
