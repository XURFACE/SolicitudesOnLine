<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/PublicMasterPage.Master"
    CodeBehind="wfrm_Ejemplos.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_Ejemplos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-example">
        <h3>
            Tipos de Licencia</h3>
        <asp:Literal ID="ltrlImages" runat="server"></asp:Literal>
        <asp:Literal ID="ltrlImagesProd" runat="server"></asp:Literal>
        <asp:Literal ID="ltrlImagesEvento" runat="server"></asp:Literal>
    </div>
    <!--End container-->
</asp:Content>
