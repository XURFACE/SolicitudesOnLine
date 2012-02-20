<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="main.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.main" %>

<%@ Register Src="../UC/uc_GiroSector.ascx" TagName="uc_GiroSector" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenet-form">
        <div class="img-conten" style="margin-top: 25px; margin-right: 15px;">
            <img src="../images/inicio.PNG" alt="img" />
        </div>

        <div class="conten-text-inicio" style="width: 385px;">
            <p>
                El actual proceso tiene como fin obtener el Certificado de Licencia de Uso de la
                Marca País Perú otorgado por PROMPERU. Aquellas personas que obtengan una evaluación
                favorable tendrán el título de LICENCIATARIOS de la Marca País Perú.
                <br />
                <br />
                Las marcas EMBAJADORAS cumplen requisitos adicionales, estas deben ser marcas tradicionalmente
                peruanas y apoyar a la Dirección de Imagen País de PROMPERU a alcanzar ciertos objetivos
                de promocionar al país.</p>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
