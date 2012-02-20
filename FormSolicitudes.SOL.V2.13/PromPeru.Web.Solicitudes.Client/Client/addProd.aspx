<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="addProd.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.addProd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <script src="../js/jquery.tooltip.min.js" type="text/javascript"></script>
    <link href="../css/jquery.tooltip.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            $('.div-info a').tooltip({
                track: true,
                delay: 0,
                showURL: false,
                showBody: " - ",
                fade: 250
            });

        });
       
    </script>
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Producto</p>
    </div>
    <div>
        <table class="popup-form">
            <tr>
                <td class="style_r">
                    <asp:Label ID="Label1" runat="server" Text="Marca:" CssClass="label" Style="margin-right: 24px;">
                    </asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlMarca" runat="server" Height="22px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style_r">
                    <asp:Label ID="Label2" runat="server" Text="Nombre de producto:" CssClass="label"
                        Style="margin-right: 24px;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNombre" runat="server" EnableTheming="True"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfNombre" runat="server" ControlToValidate="txtNombre"
                        ErrorMessage="Ingrese el Nombre de producto" ValidationGroup="newProd">•</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style_r">
                    <div class="div-info">
                        <a class="info" title=" - El Producto debe ser al menos un 50% de su costo de venta de procedencia peruana, entendiéndose como procedencia peruana la materia prima o el proceso de transformación a productos terminados."
                            href="#"></a>
                    </div>
                    <asp:Label ID="Label3" runat="server" Text="Porcentaje de fabricación:" CssClass="label"
                        Style="margin-right: 0px;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPorcFabri" runat="server" MaxLength="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfPF" runat="server" ControlToValidate="txtPorcFabri"
                        ErrorMessage="Ingrese el % Fabricación" ValidationGroup="newProd">•</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPF" runat="server" ControlToValidate="txtPorcFabri"
                        ErrorMessage="Ingrese un valor numérico" ValidationExpression="^[0-9]+(\.[0-9]+)?$"
                        ValidationGroup="newProd">•</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style_r">
                    <div class="div-info">
                        <a class="info" title=" - Debe indicar, en porcentaje, la cantidad de unidades vendidas del producto sobre el total de unidades vendidas de la marca.<br> Ejemplo: si su marca tiene un solo producto registrar 100%."
                            href="#"></a>
                    </div>
                    <asp:Label ID="Label4" runat="server" Text="Porcentaje en unidades vendidas:" CssClass="label"
                        Style="margin-right: 0px;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPorcUnd" runat="server" MaxLength="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPUV" runat="server" ControlToValidate="txtPorcUnd"
                        ErrorMessage="Ingrese Unidades Vendidas" ValidationGroup="newProd">•</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPUV" runat="server" ControlToValidate="txtPorcUnd"
                        ErrorMessage="Unidades vendidas debe ser un número entero" ValidationExpression="^[0-9]+(\.[0-9]+)?$"
                        ValidationGroup="newProd">•</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="style_r">
                    <div class="div-info">
                        <a class="info" title=" - Debe indicar, en porcentaje, el valor total de ventas del producto sobre el valor total de ventas de la marca.<br> Ejemplo: si su marca tiene un solo producto registrar 100%"
                            href="#"></a>
                    </div>
                    <asp:Label ID="Label5" runat="server" Text="Porcentaje en valor de venta:" CssClass="label"
                        Style="margin-right: 0px;"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPorcValVnt" runat="server" MaxLength="3"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rvfPVV" runat="server" ControlToValidate="txtPorcValVnt"
                        ErrorMessage="Ingrese Porcentaje de valor" ValidationGroup="newProd">•</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPVV" runat="server" ControlToValidate="txtPorcValVnt"
                        ErrorMessage="Porcentaje de valor debe ser un valor entero" ValidationExpression="^[0-9]+(\.[0-9]+)?$"
                        ValidationGroup="newProd">•</asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="hplnkEjems" NavigateUrl="~/Public/FAQ.html" Target="_blank" runat="server">Ver ejemplos</asp:HyperLink>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <div class="content-popup">
                        <div class="buttom-popup">
                            <asp:Button ID="btn_add" runat="server" Text="Agregar" class="mw-button" ValidationGroup="newProd" />
                            <asp:Button ID="bnt_cancelar" runat="server" Text="Cancelar" class="mw-button" OnClientClick="parent.$.modal().closePopup()" />
                        </div>
                    </div>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
                    <asp:ValidationSummary ID="vs" runat="server" CssClass="messbox" ValidationGroup="newProd" />
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
