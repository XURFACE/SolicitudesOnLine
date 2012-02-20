<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_BuscarEmpresa.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_BuscarEmpresa" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../js/jquery-1.3.2.min.js" type="text/javascript"></script>
    <link href="../css/style.css" rel="stylesheet" type="text/css" />
    <link href="../css/modal-window.css" rel="stylesheet" type="text/css" media="all" />
    <script type="text/javascript">
        function cargarEmpresa(id) {
            var boton = window.parent.document.getElementById("ctl00_ContentPlaceHolder1_btnLoadEmpresa");
            window.parent.document.getElementById("ctl00_ContentPlaceHolder1_txtSearchIdEmpresa").value = id;
            parent.$.modal().closePopup();
            boton.click();
        }
    </script>
  
</head>
<body class="body-popup">
    <form id="form1" runat="server">

     <div class="title-popup">
        <p>
            Empresas</p>
    </div>
     <table class="popup-form">
        <tr>
            <td>
                <asp:GridView ID="grvLstEmpresa" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" CssClass="mGrid" PageSize="6"  PagerStyle-CssClass="pgr"> 
            <Columns>
                <asp:BoundField HeaderText="id" DataField="ID" Visible="False" />
                <asp:BoundField HeaderText="Empresa" DataField="RAZONSOCIAL" />
                <asp:BoundField HeaderText="Representante" DataField="REPRESENTANTE" />
                <asp:BoundField DataField="RUC" HeaderText="Ruc" />
                <asp:BoundField DataField="GIRO" HeaderText="Giro" />
                <asp:BoundField DataField="WEB" HeaderText="Web" />
                <asp:TemplateField ShowHeader="False" HeaderText="Opciones">
                    <ItemTemplate>
                    <div class="div-lickSeleccionar">
                        <a href='javascript:cargarEmpresa(<%# Eval("ID") %>);'>Seleccionar</a>
                    </div>
                       
                    </ItemTemplate>
                </asp:TemplateField>
           
            </Columns>
        </asp:GridView>
            </td>
        </tr>
   
    </table>
          <div class="content-popup">
        <div class="buttom-popup">
        <asp:Button ID="btn_Cancelar" runat="server" Text="Cancelar" class="mw-button" OnClientClick="parent.$.modal().closePopup()"  />
            </div>
    </div>

    </form>
</body>
</html>
