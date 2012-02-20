<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_DataUser.aspx.vb"
    Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_DataUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript">
        function closeDialog() {
            var boton = parent.document.getElementById("ctl00_ContentPlaceHolder1_btn_load")
            parent.$.modal().closePopup();
            boton.click();
        }

    </script>
    <style type="text/css">
        body
        {
            background: #fff;
        }
        .style5
        {
            width: 126px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Datos de Usuario</p>
    </div>
    <table class="popup-form">
        <tr>
            <td class="style5">
                <label>
                    Login:</label>
            </td>
            <td>
                <asp:TextBox ID="txtbLog" runat="server" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvLogin" runat="server" ErrorMessage="Ingrese el Login"
                    ValidationGroup="Valusr" ControlToValidate="txtbLog">•</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                <label>
                    Nombre:</label>
            </td>
            <td>
                <asp:TextBox ID="txtbNombre" runat="server" MaxLength="150"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtbNombre"
                    ErrorMessage="Ingrese el Nombre" ValidationGroup="Valusr">•</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="style5">
                <label>
                    Perfil:</label>
            </td>
            <td>
                <div class="rowElem">
                    <asp:DropDownList ID="ddlPerfil" runat="server">
                        <asp:ListItem>Administrador</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr id="trPdw" runat="server">
            <td class="style5">
                <asp:Label ID="lblRotPwd" runat="server" Text="Contraseña:" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpwd" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvpwd" runat="server" ControlToValidate="txtpwd"
                    ErrorMessage="Ingrese Contraseña" ValidationGroup="Valusr">•</asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr id="trPdw0" runat="server">
            <td class="style5">
                <asp:Label ID="lblRotPwdRep" runat="server" Text="Repetir contraseña :" CssClass="label"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtpwd0" runat="server" TextMode="Password" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="pwd0" runat="server" ControlToValidate="txtpwd0"
                    ErrorMessage="Repita Contraseña" ValidationGroup="Valusr">•</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cmpval" runat="server" ControlToCompare="txtPwd" ControlToValidate="txtpwd0"
                    ErrorMessage="Las contraseñas no son iguales" ValidationGroup="Valusr">•</asp:CompareValidator>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <div class="content-popup">
                    <div class="buttom-popup">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" ValidationGroup="Valusr" />
                        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar datos" ValidationGroup="Valusr" />
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />
                    </div>
                </div>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td align="center" colspan="2">
                <asp:ValidationSummary ID="vlasmry" runat="server" CssClass="messbox" ValidationGroup="Valusr" />
                <asp:Label runat="server" ID="lblMsg" CssClass="messbox" Visible="false" ForeColor="Red"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
