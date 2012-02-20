<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master"
    CodeBehind="wfrm_NewSolicitud.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_NewSolicitud" %>

<%@ Register Src="../UC/uc_newClientUser.ascx" TagName="uc_newClientUser" TagPrefix="uc1" %>
<%@ Register Src="../UC/uc_Login.ascx" TagName="uc_Login" TagPrefix="uc2" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="Server">
<script type="text/javascript">
    $(document).ready(function () {
        var contentLogin = $("#ctl00_ContentPlaceHolder1_uc_Login1_txtlogin").val();
        var contentPwd = $("#ctl00_ContentPlaceHolder1_uc_Login1_txtPwd").val();
        $("#ctl00_ContentPlaceHolder1_uc_Login1_txtlogin").keyup(function () {
            if (contentLogin != "") {
                $(".messbox").css("display", "none");
            }
        });
        $("#ctl00_ContentPlaceHolder1_uc_Login1_txtPwd").keyup(function () {
            if (contentLogin != "") {
                $(".messbox").css("display", "none");
            }
        });
        $("#ctl00_ContentPlaceHolder1_uc_Login1_txtlogin, #ctl00_ContentPlaceHolder1_uc_Login1_txtPwd").keydown(function (event) {
            if (event.which == 13) {
                event.preventDefault();
                $("#ctl00_ContentPlaceHolder1_uc_Login1_btningresar").click();
            }
        });
        $("#ctl00_ContentPlaceHolder1_uc_newClientUser1_txtLogin, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtPwd, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtpwdConf, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtNom, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtAP, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtAM, #ctl00_ContentPlaceHolder1_uc_newClientUser1_txtMail").keydown(function (event) {
            if (event.which == 13) {
                event.preventDefault();
                $("#ctl00_ContentPlaceHolder1_uc_newClientUser1_btnGuardar").click();
            }
        });
    });
   
</script>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

  

    <div class="form-content">
       <div class="contenet-form">
        <h6>
            Crear una nueva cuenta</h6>
            <uc1:uc_newClientUser ID="uc_newClientUser1" runat="server" TipoControl="Ingresa"
            Redireccionar="wfrm_Confirmacion.aspx" Redireccionar_Conf="wfrm_Confirmacion.aspx" />
        </div>
        
    </div>
    <div class="form-right">
            <div class="contenet-form">
                <h6>Iniciar sesión</h6> 
                 <h4>si ya tiene solicitudes registradas</h4>
            <uc2:uc_Login ID="uc_Login1" runat="server" />
       </div>
           
    </div>
    <div class="clear">
    </div>
</asp:Content>
