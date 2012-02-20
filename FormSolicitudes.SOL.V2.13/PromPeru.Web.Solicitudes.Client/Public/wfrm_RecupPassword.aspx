<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master" CodeBehind="wfrm_RecupPassword.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_RecupPassword" %>
<%@ Register Src="~/UC/uc_RestorePwd.ascx" TagName="uc_RestorePwd" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  <div class="content-body">
        <h4>
            Solicitar Clave
        </h4>
    </div>
    <div class="contenet-form">
        <h6>
            Restaurar Contraseña</h6>
        <div class="content-info">
            <uc1:uc_RestorePwd ID="uc_RestorePwd1" runat="server" /> 
        </div>
    </div>
</asp:Content>
