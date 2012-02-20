<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Final.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Final" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="<%= Page.ResolveClientUrl("~/js/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/modal-window.min.js") %>" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            mostrarCampos();
            function mostrarCampos() {
                var tipo = $("#<%= txtTipoEmpresa.ClientID %>").text();

                switch (tipo) {
                    case "0":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        break;
                    case "1":
                        $("#prpj").css("display", "none");
                        $("#rprlegal").css("display", "none");
                        $("#cgorprs").css("display", "none");
                        //                        $("#vgpoder").css("display", "none");
                        //                        $("#dto").css("display", "none");
                        $("#pcont").css("display", "none");
                        //                        $("#cgo").css("display", "none");
                        $("#depto").css("display", "none");
                        $("#prov").css("display", "none");
                        $("#dist").css("display", "none");
                        break;
                    case "2":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        //                        $("#ruc").css("display", "none");
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
        });
    </script>
    <style type="text/css">
        table.table-content-form tr td span
        {
            outline: none;
            min-height: 15px;
            float: right;
            margin-right: 0px;
            font-size: 12px;
        }
        table.table-content-form tr td.style6
        {
            margin-right: 0px;
            width: 200px;
        }
        table.style4
        {
            border: 1px solid #fff;
            margin-left: 20px;
        }
        table.style4 tr td.line-tr
        {
            width: 400px;
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
            font-size: 10px;
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
        .table-content-form tr td h6
        {
            margin: 15px 0px 0px 0px;
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
    <div class="content-body">
        <h4>
            Paso de Confirmación</h4>
        <p>
            POR FAVOR REVISE LOS DATOS INGRESADOS ANTES DE ENVIAR</p>
    </div>
    <table class="table-content-form" style="width: 96%;">
        <tr>
            <td style="width: 80px">
            </td>
            <td colspan="2">
                <h6>
                    DATOS INGRESADOS DURANTE EL REGISTRO</h6>
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
                <label>
                    Razón social:</label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRazonSoc" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <label>
                    Página Web:</label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtWeb" runat="server" CssClass="textBox"></asp:Label>
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
        <tr>
            <td>
            </td>
            <td colspan="2">
                <br />
                <div class="line">
                </div>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                Domicilio:
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
                        <td class="style8">
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
            <td colspan="2">
                <div class="line">
                </div>
            </td>
        </tr>
        <tr id="licfun">
            <td>
            </td>
            <td class="style6">
                <label>
                    <asp:Label ID="RotLicFunc" runat="server" Text="Licencia de Funcionamiento:"></asp:Label>
                </label>
            </td>
            <td class="line-tr">
                <asp:HyperLink Target="_blank" ID="lnkLF" runat="server">[lnkLF]</asp:HyperLink>
            </td>
        </tr>
        <tr id="prpj">
            <td>
            </td>
            <td class="style6">
                <label id="RotNPartida" for="npartida">
                    <asp:Label ID="RotNPartida" runat="server" Text="# de Partida Registral de la Persona Jurídica:"></asp:Label>
                </label>
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
                Correo:
            </td>
            <td class="line-tr">
                <asp:Label ID="txtmail" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                Telefono:
            </td>
            <td class="line-tr">
                <asp:Label ID="txtTelefono" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <asp:Label ID="txtSearchIdEmpresa" runat="server" Style="display: none;"></asp:Label>
                <br />
                <asp:Button ID="btnLoadEmpresa" runat="server" Text="Cargar Empresa" Style="display: none;" />
                <asp:Label ID="txtTipoEmpresa" runat="server" Style="display: none;"></asp:Label>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr id="solCom01">
            <td>
            </td>
            <td colspan="2">
                <h6>
                    EL SOLICITANTE Y SU COMPROMISO CON EL PERÚ</h6>
            </td>
        </tr>
        <tr id="solCom02">
            <td>
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
            <td>
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
        <tr id="solCom06">
            <td>
            </td>
            <td class="style6" style="padding-left: 20px" colspan="2">
                <asp:GridView ID="GVRefEmpresa" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                    Width="550px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                    <Columns>
                        <asp:BoundField DataField="IDAPL" HeaderText="ID" Visible="False" />
                        <asp:TemplateField HeaderText="Referencias adjuntadas">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("strRUTA_REF") %>'
                                    NavigateUrl='<%# Bind("strRUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                            <ItemStyle HorizontalAlign="Center" />
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="solCom07">
            <td>
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
            <td>
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
            <td>
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
            <td class="contenet-form" colspan="2">
                <h6>
                    DATOS DE USOS SELECCIONADOS</h6>
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
            <td>
            </td>
            <td class="style6" colspan="2">
                <span style="float: left" class="RotbigDetail">Ámbito de Uso Solicitado</span>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <div style="padding: 0px 0px 0px 15px">
                    <asp:GridView ID="grvambito" runat="server" AutoGenerateColumns="False" GridLines="None"
                        CssClass="mGrid" PagerStyle-CssClass="pgr" Width="500px" BorderColor="Red" BorderStyle="Dashed"
                        BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="strPUBLICO" HeaderText="PÚBLICO">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="strDETPUBLICO" HeaderText="DETALLE">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="strLISTADETALLADA" HeaderText="NOMBRES(PAISES/REGIONES)">
                                <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                            </asp:BoundField>
                        </Columns>
                        <PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <span style="float: left" class="RotbigDetail">Detalle de Usos solicitados</span>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <div style="padding: 0px 0px 0px 15px">
                    <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" GridLines="None"
                        CssClass="mGrid" PagerStyle-CssClass="pgr" Width="500px" BorderColor="Red" BorderStyle="Dashed"
                        BorderWidth="1px">
                        <Columns>
                            <asp:BoundField HeaderText="USO" DataField="strTIPOLIC">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="APLICACIÓN" DataField="intSUBTIPO">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField HeaderText="DETALLE" DataField="strDESCRIPCION">
                                <ItemStyle HorizontalAlign="Justify" VerticalAlign="Middle" />
                            </asp:BoundField>
                        </Columns>
                        <PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>
                </div>
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
            </td>
            <td class="style6" colspan="2">
                <div style="width: 500px; margin: 0 auto;">
                    <asp:GridView ID="grvProd" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                        Width="500px" BorderColor="Red" BorderStyle="Dashed" BorderWidth="1px">
                        <Columns>
                            <asp:BoundField DataField="strMARCA" HeaderText="MARCA">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:BoundField DataField="strNOMBRE" HeaderText="PRODUCTO">
                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            </asp:BoundField>
                            <asp:TemplateField HeaderText="ARCHIVO">
                                <ItemTemplate>
                                    <asp:HyperLink Target="_blank" ID="lnkMarca" class="EFile" runat="server" Text='<%# Bind("strRUTAREGISTROINDECOPI") %>'
                                        NavigateUrl='<%# Bind("strRUTAREGISTROINDECOPI") %>'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
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
                <table style="border: 1px solid #CCC; width: 97%;">
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
                                <asp:HyperLink ID="lnkRef" Target="_blank" runat="server">[lnkreferencias]</asp:HyperLink>
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
            <td class="contenet-form" colspan="2">
                <h6>
                    DECLARACIÓN JURADA</h6>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6">
                <span style="float: left;">Adjuntar Declaración Jurada:&nbsp;&nbsp;&nbsp;</span>
            </td>
            <td>
                <cc1:FileUploaderAJAX ID="FUAjaxDJurada" runat="server" text_Add="Adjuntar Ref" text_Uploading="Subiendo.."
                    CssClass="fileAjax" MaxFiles="1" />
                <br />
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td class="style6" colspan="2">
                <span style="float: left;">Si no descargó su Declaración Jurada en el Paso 01 puede
                    hacerlo desde <a href="../Public/ANEXO_2.pdf" target="_blank" style="color: #ee2d23">
                        aquí.</a> </span>
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="Button1" runat="server" Text="Atras" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Enviar" />
        </div>
    </div>
    <div style="margin: 0 auto; width: 214px">
        <asp:Literal ID="msg" runat="server"></asp:Literal>
    </div>
    <div class="clear">
    </div>
    <%--<div class="div-lick" style="margin-right:100px;">
        <asp:LinkButton ID="lnkAddApl" runat="server"  href="javascript:cargarPopupAdd()">Agregar Archivo</asp:LinkButton>
        </div> --%>
    <div class="clear">
    </div>
    <div class="clear">
    </div>
    <asp:Button ID="btn_load" runat="server" Text="load" Style="display: none;" />
    <div class="clear">
    </div>
</asp:Content>
