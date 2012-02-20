<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/MainMasterPage.Master"
    CodeBehind="wfrm_DetalleSolicitud.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Admin.wfrm_DetalleSolicitud" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function cargarPopupAdd() {
            var url = "" + document.location;
            var datoGet = url.split('?')[1];
            if (datoGet != null)
                $(this).modal({ width: 620, height: 600, src: "wfrm_CmbEstado.aspx?" + datoGet }).open();
        }
        function cargarPopupAddDocuments() {
            var url = "" + document.location;
            var id = url.split('idSol=')[1];

            if (id != null)
                $(this).modal({ width: 370, height: 300, src: "wfrm_AddDocuments.aspx?idsol=" + id }).open();
        }
        function cargarImage(id) {
            $(this).modal({ width: 550, height: 600, src: "wfrm_Afiche.aspx?id=" + id }).open();
        }
        function solArchAdic(id) {
            $(this).modal({ width: 550, height: 600, src: "wfrm_Afiche.aspx?id=" + id }).open();
        }
        $(document).ready(function () {
            mostrarCampos();
        });
        function mostrarCampos() {
            tipo = $("#<%= txtload.ClientID %>").val();

            switch (tipo) {
                case "0":
                    $("#ciudad").css("display", "none");
                    $("#pais").css("display", "none");
                    break;
                case "1":
                    $("#prpj").css("display", "none");
                    $("#rprlegal").css("display", "none");
                    $("#cgorprs").css("display", "none");
                    $("#vgpoder").css("display", "none");
                    $("#dto").css("display", "none");
                    $("#pcont").css("display", "none");
                    $("#cgo").css("display", "none");
                    $("#depto").css("display", "none");
                    $("#prov").css("display", "none");
                    $("#dist").css("display", "none");
                    break;
                case "2":
                    $("#ciudad").css("display", "none");
                    $("#pais").css("display", "none");
                    $("#ruc").css("display", "none");
                    $("#licfun").css("display", "none");
                    $("#prpj").css("display", "none");
                    $("#vgpoder").css("display", "none");
                    $("#pcont").css("display", "none");
                    $("#cgo").css("display", "none");
                    break;
                case "3":
                    $("#licfun").css("display", "none");
                    $("#prpj").css("display", "none");
                    $("#vgpoder").css("display", "none");
                    $("#ciudad").css("display", "none");
                    $("#pais").css("display", "none");
                    $("#solCom01").css("display", "none");
                    $("#solCom02").css("display", "none");
                    $("#solCom03").css("display", "none");
                    $("#solCom04").css("display", "none");
                    $("#solCom05").css("display", "none");
                    $("#solCom06").css("display", "none");
                    $("#solCom07").css("display", "none");
                    $("#solCom08").css("display", "none");
                    $("#<%= trProgDet.ClientID %>").css("display", "none");
                    $("#<%= trProgRotDet.ClientID %>").css("display", "none");
                    $("#<%= trProgNom.ClientID %>").css("display", "none");
                    $("#<%= trProgRotNom.ClientID %>").css("display", "none");
                    break;
            }
        }
    </script>
    <style type="text/css">
        table.table-content-form tr td span
        {
            outline: none;
            float: right;
            margin-right: 0px;
        }
        table.table-content-form tr td
        {
            padding: 5px 0px;
            color: black;
        }
        table.table-content-form tr td.style6
        {
            margin-right: 0px;
            padding-left: 20px;
        }
        table.style4
        {
            border: 1px solid #fff;
            margin-left: 20px;
        }
        table.style4 tr td.line-tr
        {
            width: 350px;
            border-bottom: 1px solid #ccc;
        }
        table.style4 tr td span
        {
            margin-top: 5px;
            display: block;
        }
        table.style4
        {
        }
        .table-content-form tr td.line-tr span
        {
            float: left;
            margin-left: 20px;
            color: #222222;
            font-weight: bold;
        }
        .table-content-form tr td.line-tr a
        {
            color: #EE2E24;
            font-size: 12px;
            font-weight: normal;
            margin-bottom: 2px;
            float: right;
        }
        .table-content-form tr td.line-tr a:hover
        {
            text-decoration: underline;
        }
        .table-content-form tr td.line-tr
        {
            width: 350px;
            border-bottom: 1px solid #ccc;
        }
        table.table-content-form tr td h6
        {
            margin: 15px 0px 0px 0px;
        }
        .table-content-form tr td.line-tr2
        {
            width: 350px;
        }
        .dr-libe
        {
            width: 180px;
        }
        .bigDetail
        {
            border-bottom: 1px solid #CCC;
            border-left: 1px solid #CCC;
            padding-bottom: 5px;
            padding-left: 5px;
            float: left;
            font-weight: bold;
            text-align: justify;
            line-height: 17px;
            font-size: 13px;
            width: 100%;
        }
        .RotbigDetail
        {
            font-weight: normal;
            text-align: left;
            margin-top: 5px;
            font-size: 14px;
            color: #727272;
            text-transform: uppercase;
        }
        .raddio label
        {
            float: none;
            margin: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="table-content-form" style="width: 96%;">
        <tr>
            <td>
            </td>
            <td align="right">
                Estado actual de la solicitud:&nbsp;
            </td>
            <td align="left" class="line-tr">
                <asp:Label ID="lblEstadoActual" runat="server" Text="APROBADO"></asp:Label>
                <asp:LinkButton ID="lnkEstado" runat="server" href="javascript:cargarPopupAdd()">Cambiar Estado</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <h6>
                    1. DATOS DEL SOLICITANTE</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr id="expediente">
            <td>
            </td>
            <td class="style6">
                <span>Número de expediente:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="Txt_Expediente" runat="server" CssClass="textBox"></asp:Label>                
            </td>
        </tr>
        <tr id="ruc">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblRucEtiq" runat="server" Text="RUC:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="Txt_RUC" runat="server" CssClass="textBox"></asp:Label>
                <div>
                    <asp:HyperLink ID="lnkRuc" Target="_blank" runat="server">[lnkRuc]</asp:HyperLink>
                </div>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Razón social:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRazonSoc" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Objetivo:&nbsp;</span>
            </td>
            <td align="left" class="line-tr">
                <asp:Label ID="lblObjetivo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="style6">
                &nbsp;
            </td>
            <td align="left" class="line-tr">
                <asp:Label ID="lblDetObjetivo" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblGiro" runat="server" Text="Giro Principal de la Empresa:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="lblNameGiro" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr id="licfun">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="RotLicFunc" runat="server" Text="Licencia de Funcionamiento:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:HyperLink Target="_blank" ID="lnkLF" runat="server">[lnkLF]</asp:HyperLink>
            </td>
        </tr>
        <tr id="prpj">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="RotNPartida" runat="server" Text="Partida Registral de la Persona Jurídica:"
                    Height="16px" Width="228px"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtPartida" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="rprlegal">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblRepresLegal" runat="server" Text="Representante Legal:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRepresentante" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="cgorprs">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblCgoRepre" runat="server" Text="Cargo de Representante Legal:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtCgoRepres" runat="server"></asp:Label>
            </td>
        </tr>
        <tr id="vgpoder">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="RtoVigencia" runat="server" Text="Vigencia de Poder: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:HyperLink Target="_blank" ID="lnkVP" runat="server">[lnkVP]</asp:HyperLink>
            </td>
        </tr>
        <tr id="dto">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblDNI" runat="server" Text="Documento de Identidad: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtdniRepr" runat="server" CssClass="textBox" MaxLength="8"></asp:Label>
                <asp:HyperLink Target="_blank" ID="lnkDNI" runat="server">[lnkDNI]</asp:HyperLink>
            </td>
        </tr>
        <tr id="pcont">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblPContacto" runat="server" Text="Persona de Contacto:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtContacto" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="cgo">
            <td>
            </td>
            <td class="style6">
                <asp:Label ID="lblCargo" runat="server" Text="Cargo: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtCargo" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Correo:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtmail" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Telefono:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtTelefono" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Domicilio:</span>
            </td>
            <td>
                <table class="style4" id="nacional">
                    <tr>
                        <td class="style8">
                            Direccion:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="txtDireccion" runat="server" CssClass="direc"></asp:Label>
                        </td>
                    </tr>
                    <tr id="depto">
                        <td class="">
                            Departamento:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lbldpto" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr id="prov">
                        <td class="style8">
                            Provincia:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblProv" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr id="dist">
                        <td class="style8">
                            Distrito:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblDistr" runat="server" Text=""></asp:Label>
                        </td>
                    </tr>
                    <tr id="ciudad">
                        <td class="style8">
                            Ciudad:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="txtCiudad" runat="server" CssClass="direc"></asp:Label>
                        </td>
                    </tr>
                    <tr id="pais">
                        <td class="style8">
                            Pais:
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="txtPais" runat="server" CssClass="direc"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span>Página Web:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtWeb" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td class="style6">
                <span>Declaración Jurada:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="lblDeclaracion" runat="server" CssClass="textBox" MaxLength="8"></asp:Label>
                <asp:HyperLink Target="_blank" ID="lnkDeclaracion" runat="server">[lnkDNI]</asp:HyperLink>
            </td>
        </tr>
        <tr id="solCom01">
            <td>
                &nbsp;
            </td>
            <td colspan="2">
                <h6>
                    2. EL SOLICITANTE Y SU COMPROMISO CON EL PERÚ</h6>
            </td>
        </tr>
        <tr id="solCom02">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblRotTray" Style="float: left" CssClass="RotbigDetail" runat="server"
                    Text="Giro de negocio y la trayectoria de su empresa:"></asp:Label>
            </td>
        </tr>
        <tr id="solCom03">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lblTray" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr id="solCom04">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblRotRef" Style="float: left" CssClass="RotbigDetail" runat="server"
                    Text="Referencias de la Empresa:"></asp:Label>
            </td>
        </tr>
        <tr id="solCom05">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lblRef" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr id="solCom06" class="noover">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:GridView ID="GVDocs" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    Width="550px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="IDAPL" HeaderText="ID" Visible="False" />
                        <asp:TemplateField HeaderText="Referencias adjuntadas">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("RUTA_REF") %>'
                                    NavigateUrl='<%# Bind("RUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="solCom07">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblrotAct" Style="float: left" CssClass="RotbigDetail" runat="server"
                    Text="Actividades abocadas a desarrollar nuestro país"></asp:Label>
            </td>
        </tr>
        <tr id="solCom08">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lblAct" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr id="trProgRotNom" runat="server">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblrotProg" Style="float: left" CssClass="RotbigDetail" runat="server"
                    Text="Programa de responsabilidad social"></asp:Label>
            </td>
        </tr>
        <tr id="trProgNom" runat="server">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lblNomProg" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr id="trProgRotDet" runat="server">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblrotdetProg" Style="float: left" CssClass="RotbigDetail" runat="server"
                    Text="Recursos que destinan y actividades que comprende el programa"></asp:Label>
            </td>
        </tr>
        <tr id="trProgDet" runat="server">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lbldetProg" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2">
                <h6>
                    3. SOBRE EL USO DE LA MARCA PAÍS</h6>
            </td>
        </tr>
        <tr>
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <span style="float: left" class="RotbigDetail">¿Para qué quiere usar la marca País?</span>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:Label ID="lblRptaUso" runat="server" Style="float: left" CssClass="bigDetail"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <span style="float: left" class="RotbigDetail">ÁMBITO DE USO</span>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <asp:GridView ID="grvAmbitoUso" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    Width="700px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="strPUBLICO" HeaderText="PÚBLICO">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="strDETPUBLICO" HeaderText="DETALLE">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="200px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="strLISTADETALLADA" HeaderText="NOMBRES(PAISES/REGIONES)">
                            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                        </asp:BoundField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2">
                <h6>
                    <asp:Label ID="lblUSO" Style="float: left; font-size: 16px; font-family: 'Bree';"
                        runat="server" Text="4. DATOS RELACIONADOS AL USO"></asp:Label></h6>
            </td>
        </tr>
        <tr id="tr2" runat="server">
            <td style="width: 76px;">
            </td>
            <td class="style6" colspan="2">
                <span style="float: left" class="RotbigDetail">DETALLE DE USO</span>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    GridLines="None" PagerStyle-CssClass="pgr" Width="700px" BorderColor="Red" BorderStyle="Dashed"
                    BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="strTIPOLIC" HeaderText="USO">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="intSUBTIPO" HeaderText="APLICACIÓN">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="250px" />
                        </asp:BoundField>
                        <asp:BoundField DataField="strDESCRIPCION" HeaderText="DETALLE">
                            <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                        </asp:BoundField>
                    </Columns>
                    <PagerStyle CssClass="pgr" />
                </asp:GridView>
            </td>
        </tr>
        <tr id="trRotProd1" runat="server">
            <td>
            </td>
            <td class="style6" style="vertical-align: top" colspan="2">
                <asp:Label ID="lblRotProd2" runat="server" Style="float: left" CssClass="RotbigDetail"
                    Text="LICENCIA AUTORIZADA PARA LOS PRODUCTOS"></asp:Label>
            </td>
        </tr>
        <tr id="trRotProd2" runat="server">
            <td>
                &nbsp;
            </td>
            <td class="style6" style="vertical-align: top" colspan="2">
                <asp:GridView ID="grvProd" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    Width="650px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="MARCA" HeaderText="MARCA">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="NOMBRE" HeaderText="PRODUCTO">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PORC_FABRICACION" HeaderText="% DE FABRICACIÓN">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PORC_UNIDVENC" HeaderText="% Unid. Vend.">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:BoundField DataField="PORC_VALORVENTA" HeaderText="% Valor Venta">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="REGISTRO MARCA">
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("RUTA_REGISTROINDECOPI") %>'
                                    NavigateUrl='<%# Bind("RUTA_REGISTROINDECOPI") %>'></asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="trRefProds1" runat="server">
            <td>
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblRotRefProd" runat="server" Style="float: left" CssClass="RotbigDetail"
                    Text="Referencias de Marca:"></asp:Label>
            </td>
        </tr>
        <tr id="trRefProds2" runat="server">
            <td>
            </td>
            <td class="style6" colspan="2">
                <asp:GridView ID="grvProdRef" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    Width="350px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:TemplateField HeaderText="Referencia">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("RUTA_REF") %>'
                                    NavigateUrl='<%# Bind("RUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="trRotEvento" runat="server">
            <td>
            </td>
            <td class="style6" colspan="2">
                <asp:Label ID="lblRotEvento" runat="server" Style="float: left" CssClass="RotbigDetail"
                    Text="Detalle del evento:"></asp:Label>
            </td>
        </tr>
        <tr id="trEvento" runat="server">
            <td>
            </td>
            <td class="style6" colspan="2">
                <table style="border: 1px solid #CCC">
                    <tr>
                        <td class="style6">
                            <span>Nombre evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblNombre" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Organizador:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblOrganizador" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Referencias del evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblRefEvento" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                            <div>
                                <asp:HyperLink ID="lnkreferencia" Target="_blank" runat="server">[referencia]</asp:HyperLink>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Descripción del Evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblDescEvento" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Agenda / Programa del evento (De ser el caso):</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblAgenda" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                            <div>
                                <asp:HyperLink ID="kplnkAgenda" Target="_blank" runat="server">[lnkRuc]</asp:HyperLink>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>No. Edición del Evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblEdicEvnto" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Peridiocidad del Evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblPer" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Lugar de Realización:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblLugar" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Fecha de Realización:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblFecha" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Descripción del Publico General del Evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblDescPubEvnto" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Participantes/Asistentes:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblPart" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Costo promedio de la participación / asistencia al evento:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblCosto" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            <span>Auspiciadores y/o patrocinadores:</span>
                        </td>
                        <td class="line-tr">
                            <asp:Label ID="lblAuspiciadores" runat="server" Text="Evento" CssClass="textBox"></asp:Label>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <h6>
                    5. ARCHIVOS ADICIONALES</h6>
            </td>
            <td align="left" class="line-tr">
                <asp:Button ID="btn_load" runat="server" Text="btn_load" Style="display: none" />
                <asp:LinkButton ID="lnkBtn" runat="server" href="javascript:cargarPopupAddDocuments()">Agregar archivo a solicitar</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2">
                <div style="width: 500px; margin: 0 auto;">
                    <asp:GridView ID="grvarcAdic" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                        Width="500px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="DESCRIPCION" HeaderText="Descripción" />
                            <asp:TemplateField HeaderText="Archivos">
                                <ItemTemplate>
                                    <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("RUTA_ARCHIVO") %>'
                                        NavigateUrl='<%# Bind("RUTA_ARCHIVO") %>' ForeColor="Red"></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td colspan="2" style="text-align:center">
                <div class="buttom-popup" style="text-align: center; width: 100%;">
                    <asp:Button ID="btnSolicitar" runat="server" Style="margin-left: 0px;" Text="Enviar Solicitud" /></div>
                <asp:Literal ID="ltrMsg" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <h6>
                    6. ARTES</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td colspan="2">
                <%--<div style="width: 500px; margin: 0 auto;">--%>
                <asp:GridView ID="grvAplicUso" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    DataKeyNames="IDAPL,STSAPLICACION" Width="500px" BorderColor="Red" BorderStyle="Dashed"
                    BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="RUTA_IMAGEN" HeaderText="Archivos" />
                        <asp:TemplateField HeaderText="Vista&amp;nbsp;previa">
                            <ItemTemplate>
                                <a href='javascript:cargarImage(<%#Eval("IDAPL") %>)' class="zoom">
                                    <img src="../images/pixel.gif" alt="cambiar" style="width: 14px; height: 20px;" />
                                </a>
                            </ItemTemplate>
                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Estado">
                            <ItemTemplate>
                                <asp:DropDownList ID="ddlEstado" runat="server" AutoPostBack="True" OnSelectedIndexChanged="chkAprob_CheckedChanged">
                                    <asp:ListItem Value="0">EN EVALUACIÓN</asp:ListItem>
                                    <asp:ListItem Value="1">APROBADA</asp:ListItem>
                                    <asp:ListItem Value="2">RECHAZADA</asp:ListItem>
                                </asp:DropDownList>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="DECRIPCION" HeaderText="Descripción" />
                    </Columns>
                </asp:GridView>
                <%--</div>--%>
            </td>
        </tr>
        <tr>
            <td colspan="3">
                <div class="buttom-popup" style="text-align: center; width: 100%;">
                    <asp:Button ID="btnAtras" runat="server" Style="margin-left: 0px;" Text="Atras" />
                </div>
            </td>
        </tr>
    </table>
    <asp:TextBox ID="txtload" runat="server" Style="display: none;"></asp:TextBox>
    <div class="clear">
    </div>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Style="display: none" />
</asp:Content>
