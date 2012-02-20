<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="wfrm_ArchivoAplicacion.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_ArchivoAplicacion" %>
<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %> 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../css/style.css" rel="stylesheet" type="text/css" media="all" />
    <!--Codigo para input file -->
    <link href="../js/inputfile/jquery.si.css" rel="stylesheet" type="text/css" media="all" />  
    <script src="http://jqueryjs.googlecode.com/files/jquery-1.3.1.min.js" type="text/javascript"></script>  
    <script src="../js/inputfile/jquery.si.js" type="text/javascript"></script>
       <script type="text/javascript">
           $(document).ready(function () {
               $("input.file").si();
           });
     </script>

    <!-- fin del codigo para input file -->
    <script type="text/javascript">
        function cargarAplicacion() {
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
    </style>
</head>
<body class="body-popup">
    <form id="form1" runat="server">
    <div class="title-popup">
        <p>
            Aplicación</p>
    </div>

    <table class="popup-form">
        <tr>
            <td>
      
            &nbsp;Seleccione un Archivo de Aplicación:
 
            </td>
            <td>
      
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            <br />
            <cc1:FileUploaderAJAX ID="FUAjaxApl" runat="server" CssClass="fileAjax" 
                    MaxFiles="1" text_Add="Adjuntar DNI" text_Uploading="Subiendo.." />
               <%-- <asp:FileUpload ID="fu_apl" runat="server" class="file" />--%>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;Descripción:
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtAplDesc" runat="server" Height="67px" TextMode="MultiLine" 
                Width="300px"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="val"
                    ControlToValidate="txtAplDesc" ErrorMessage="Ingrese la descripción">•</asp:RequiredFieldValidator>
            </td>
        </tr>
       
    </table>
    <div class="content-popup">
                <div class="buttom-popup">
             <asp:Button ID="btnOk" runat="server" Text="Aceptar" ValidationGroup="val"/>
             <asp:Button ID="btnCancelar" runat="server" Text="Cancelar"  OnClientClick="parent.$.modal().closePopup()" />
                  </div>
              </div>
    </form>
</body>
</html>
