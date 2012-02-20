<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso05.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso05" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/CustomRadioCheck.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#<% =grvFiles.clientID %> tbody tr:first").css("display", "none");
//            switch ($("input[name='ctl00$ContentPlaceHolder1$camp']:checked").val()) {
//                case "rbtn_si":
//                    habilitar();
//                    break;
//                case "rbtn_no":
//                    desabilitar();
//                    break;
//            }
//            $("#<%=rbtn_si.clientID %>").click(function () {
//                habilitar();
//            });
//            $("#<%=rbtn_no.clientID %>").click(function () {
//                desabilitar();
//            });
            function OcultarMensajeServer() {
                $("#<% =lblMsjError.clientID %>").css("display", "none");
            }
            function MostrarMensajeServer() {
                $("#<% =lblMsjError.clientID %>").css("display", "block");
            }
            function habilitar() {
                $("#NomprogSoc").fadeIn();
                $("#rotDetprogSoc").fadeIn();
                $("#DetprogSoc").fadeIn();

                /* $("#ctl00_ContentPlaceHolder1_txtProgRespSocial").fadeIn();
                $("#ctl00_ContentPlaceHolder1_txtProgSocDet").fadeIn();
                $("#ctl00_ContentPlaceHolder1_Label1").fadeIn();
                $("#ctl00_ContentPlaceHolder1_Label3").fadeIn();
                */
                if ($("#ctl00_ContentPlaceHolder1_txtProgRespSocial").val() == "__") $("#ctl00_ContentPlaceHolder1_txtProgRespSocial").val("");
                if ($("#ctl00_ContentPlaceHolder1_txtProgSocDet").val() == "__") $("#ctl00_ContentPlaceHolder1_txtProgSocDet").val("");
            }
            function desabilitar() {
                $("#NomprogSoc").fadeOut();
                $("#rotDetprogSoc").fadeOut();
                $("#DetprogSoc").fadeOut();
                /*
                $("#ctl00_ContentPlaceHolder1_txtProgRespSocial").fadeOut();
                $("#ctl00_ContentPlaceHolder1_txtProgSocDet").fadeOut();
                $("#ctl00_ContentPlaceHolder1_Label1").fadeOut();
                $("#ctl00_ContentPlaceHolder1_Label3").fadeOut();*/
                $("#ctl00_ContentPlaceHolder1_txtProgRespSocial").val("__");
                $("#ctl00_ContentPlaceHolder1_txtProgSocDet").val("__");


                if ($("#ctl00_ContentPlaceHolder1_txtDetGiro").val() == "") $("#ctl00_ContentPlaceHolder1_txtDetGiro").val("__");
                if ($("#ctl00_ContentPlaceHolder1_txtReferencias").val() == "") $("#ctl00_ContentPlaceHolder1_txtReferencias").val("__");
                Page_ClientValidate('valgrp');
                if ($("#ctl00_ContentPlaceHolder1_txtDetGiro").val() == "__") $("#ctl00_ContentPlaceHolder1_txtDetGiro").val("");
                if ($("#ctl00_ContentPlaceHolder1_txtReferencias").val() == "__") $("#ctl00_ContentPlaceHolder1_txtReferencias").val("");
            }

        });

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 5</h4>
    </div>
    <div class="contenet-form">
        <h6>
            El solicitante y su compromiso con el Perú</h6>
    </div>
    <table class="table-content-form paso5" style="width: 807px; margin: 0 auto;">
        <tr>
            <td colspan="2">
                <p>
                    La marca Perú debe ser una herramienta que también sirva para fomentar que todos
                    trabajemos para el desarrollo del Perú y mejorar la competitividad de nuestras empresas.</p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="question">
                    Por favor cuéntenos un poco más sobre el giro de negocio y la trayectoria de su
                    empresa:
                </p>
                <asp:TextBox ID="txtDetGiro" runat="server" TextMode="MultiLine" class="solic"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvGiro" runat="server" ControlToValidate="txtDetGiro"
                    ValidationGroup="valgrp" ErrorMessage="Ingrese giro de negocio y la trayectoria de su empresa">Dato requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="question">
                    Mencionar al menos dos referencias sobre la trayectoria y/o calidad de los servicios
                    que brinda su empresa.
                </p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="formt-especial">
                    El solicitante deberá listar las referencias sobre su organización y adjuntar el
                    documento correspondiente. Estas pueden ser cartas de referencia de instituciones
                    públicas o gremios al que pudiesen pertenecer; y/o certificaciones, acreditaciones,
                    premios, reconocimientos, entre otros.)</p>
                <asp:TextBox ID="txtReferencias" runat="server" TextMode="MultiLine" class="solic"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvRef" runat="server" ControlToValidate="txtReferencias"
                    ValidationGroup="valgrp" ErrorMessage="Ingrese datos de referencia">Dato requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="ayuda">
                <asp:Label ID="lblConsulado" runat="server" Text="Adjuntar carta de referencia del consulado:"
                    Visible="False"></asp:Label>
            </td>
            <td>
                <%--<asp:LinkButton ID="lnkRef" runat="server">Subir Referencia</asp:LinkButton>--%>
            </td>
        </tr>
        <tr>
            <td class="ayuda">
                <cc1:FileUploaderAJAX ID="FUAjaxCons" runat="server" text_Add="Agregar Referencia"
                    text_Uploading="Subiendo..." CssClass="fileAjax" MaxFiles="1" Visible="False"
                    text_Delete="Eliminar" />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td class="ayuda">
                <br />
                <br />
                Agregar un mínimo de dos referencias
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <cc1:FileUploaderAJAX ID="FUAjaxREMP" runat="server" text_Add="Agregar nueva referencia"
                    text_Uploading="Subiendo..." CssClass="fileAjax" MaxFiles="10" text_Delete="Eliminar" />
                <%--<asp:LinkButton ID="lnkRef" runat="server">Subir Referencia</asp:LinkButton>--%>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <div class="div-lickleft">
                    <%--<asp:LinkButton ID="lnkRef" runat="server">Subir Referencia</asp:LinkButton>--%>
                </div>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvFiles" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                    <Columns>
                        <asp:TemplateField HeaderText="Archivo">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("strRUTA_REF") %>'
                                    NavigateUrl='<%# Bind("strRUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Opciones">
                            <ItemTemplate>
                                <div class="div-lickEliminar">
                                    <asp:LinkButton ID="lnkDelete" runat="server" CommandName="Eliminar">Eliminar</asp:LinkButton>
                                </div>
                            </ItemTemplate>
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("eliminar") %>'></asp:TextBox>
                            </EditItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="question">
                    Indicar cómo la empresa se involucra en actividades abocadas a desarrollar nuestro
                    país</p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="formt-especial">
                    El solicitante deberá hacer referencias a su aporte para el crecimiento del país
                    (material social, medio ambiental y/o de otra índole)</p>
                <asp:TextBox ID="txtCompro" runat="server" Height="65px" TextMode="MultiLine" class="solic"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2" class="lb-radio">
                <p>
                    ¿<span>Desarrolla&nbsp;o&nbsp;participa&nbsp;en&nbsp;programas&nbsp;de&nbsp;responsabilidad&nbsp;social?&nbsp;&nbsp;</span>
                    <label class="label_radio" for="<%=rbtn_si.clientID %>">
                        <asp:RadioButton ID="rbtn_si" runat="server" Text="SI" GroupName="camp" 
                        AutoPostBack="True" />
                    </label>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                    <label class="label_radio" for="<%=rbtn_no.clientID %>">
                        <asp:RadioButton ID="rbtn_no" runat="server" Text="NO" GroupName="camp" 
                        AutoPostBack="True" />
                    </label>
                </p>
            </td>
        </tr>
        <tr id="NomprogSoc" runat="server">
            <td colspan="2">
                <p class="question">
                    <asp:Label ID="Label1" runat="server" Text="Nombre el principal programa de responsabilidad social en el que participa:"></asp:Label>
                </p>
                <asp:TextBox ID="txtProgRespSocial" runat="server" Width="413px" MaxLength="50"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfv1" ControlToValidate="txtProgRespSocial" ValidationGroup="valgrp"
                    runat="server" ErrorMessage="Ingrese el Nombre del programa">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="rotDetprogSoc" runat="server">
            <td colspan="2">
                <p>
                    <asp:Label ID="Label3" runat="server" Text="Detalle los recursos que destinan y actividades que comprende el programa"></asp:Label>
                </p>
            </td>
        </tr>
        <tr id="DetprogSoc" runat="server">
            <td colspan="2">
                <asp:TextBox ID="txtProgSocDet" runat="server" TextMode="MultiLine" class="solic"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="rfv2" ControlToValidate="txtProgSocDet" ValidationGroup="valgrp"
                    runat="server" ErrorMessage="Ingrese los detalles del programa">Dato requerido</asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="btn_atras" runat="server" Text="Atras" CssClass="btn-sumit" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" CssClass="btn-sumit"
                ValidationGroup="valgrp" />
        </div>
    </div>
    <div style="margin: 0 auto; width: 500px">
        <asp:Label ID="lblMsjError" runat="server"></asp:Label>
        <asp:ValidationSummary ID="vlsmrPaso" CssClass="messbox" runat="server" ValidationGroup="valgrp"
            Enabled="true" />
    </div>
    <div class="clear">
    </div>
</asp:Content>
