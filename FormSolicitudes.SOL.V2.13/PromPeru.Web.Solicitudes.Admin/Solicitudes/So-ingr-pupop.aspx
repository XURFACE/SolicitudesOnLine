<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="So-ingr-pupop.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.So_ingr_pupop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
</head>
<body>

    <form id="form1" runat="server">
    <div id="popup">
        <table class="mw-tabla">
            <tr>
                <td class="style_r">
                 Licencia:
                </td>
                <td>
                 00001-2011- PROMPERU/DPIP/
                </td>
            </tr>
            <tr>
                <td class="style_r">
                 Estado Actual:
                </td>
                <td>
                 <strong>EN EVALUACION</strong>
                </td>
            </tr>
            <tr>
                <td class="style_r">
                 Cambiar a:
                </td>
                <td>
                 <asp:DropDownList ID="DropDownList2" runat="server" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="style_r" style="vertical-align:top;">
                 Mensaje:
                </td>
                <td>
                 <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" 
                   ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                   &nbsp;
                </td>
                <td>
                     <asp:Button ID="Button1" runat="server" Text="Cancelar"  class="mw-button"
                        OnClientClick="parent.$.modal().close()"  />
                    <asp:Button ID="Button2" runat="server" Text="Cambiar" class="mw-button" />
                </td>
            </tr>
         </table>
    </div>
    </form>
    <div class="clear"></div>
</body>
</html>