<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrmHistorial.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrmHistorial" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style type="text/css">
        body
        {
            background: #fff;
        }           
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <div class="title-popup">
            <p>
                Cambiar Estado</p>
        </div>

        <table>
            <tr>
                <td>
                    <p></p>
                </td>               
            </tr>
            <tr>
                <asp:GridView ID="GridView1" runat="server">
                </asp:GridView>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
