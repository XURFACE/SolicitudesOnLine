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
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        //                        $("#ruc").css("display", "none");
                        $("#licfun").css("display", "none");
                        $("#prpj").css("display", "none");
                        $("#vgpoder").css("display", "none");
                        break;
                    case "2":
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
                    case "3":
                        $("#licfun").css("display", "none");
                        $("#prpj").css("display", "none");
                        $("#vgpoder").css("display", "none");
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        break;
                }
            }
        });
    </script>
    <style type="text/css">
        table.table-content-form tr td span
        {
            outline: none;
            height: 15px;
            float: right;
            margin-right: 0px;
        }
        table.table-content-form tr td.style6
        {
            margin-right: 0px;
        }
        table.style4
        {
            border: 1px solid #fff;
            margin-left: 20px;
        }
        table.style4 tr td.line-tr
        {
            width: 235px;
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
        .dr-libe
        {
            width: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content-body">
        <h4>
            Paso de Confirmación</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Datos Ingresados Durante el Registro</h6>
    </div>
    <table class="table-content-form" style="width: 607px;">
        <tr id="ruc">
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
            <td class="style6">
                <label>
                    Razón social:</label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRazonSoc" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <label>
                    Página Web:</label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtWeb" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="lblGiro" runat="server" Text="Giro Principal de la Empresa:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="lblNameGiro" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <br />
                <div class="line">
                </div>
            </td>
        </tr>
        <tr>
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
            <td colspan="2">
                <div class="line">
                </div>
            </td>
        </tr>
        <tr id="licfun">
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
            <td class="style6">
                <label id="RotNPartida" for="npartida">
                    <asp:Label ID="RotNPartida" runat="server" Text="Partida Registral de la Persona Jurídica:"></asp:Label>
                </label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtPartida" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="rprlegal">
            <td class="style6">
                <asp:Label ID="lblRepresLegal" runat="server" Text="Representante Legal:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRepresentante" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="cgorprs">
            <td class="style6">
                <asp:Label ID="lblCgoRepre" runat="server" Text="Cargo de Representante Legal:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtCgoRepres" runat="server"></asp:Label>
            </td>
        </tr>
        <tr id="vgpoder">
            <td class="style6">
                <asp:Label ID="RtoVigencia" runat="server" Text="Vigencia de Poder: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:HyperLink Target="_blank" ID="lnkVP" runat="server">[lnkVP]</asp:HyperLink>
            </td>
        </tr>
        <tr id="dto">
            <td class="style6">
                <asp:Label ID="lblDNI" runat="server" Text="Documento de Identidad: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtdniRepr" runat="server" CssClass="textBox" MaxLength="8"></asp:Label>
                <asp:HyperLink Target="_blank" ID="lnkDNI" runat="server">[lnkDNI]</asp:HyperLink>
            </td>
        </tr>
        <tr id="pcont">
            <td class="style6">
                <asp:Label ID="lblPContacto" runat="server" Text="Persona de Contacto:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtContacto" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr id="cgo">
            <td class="style6">
                <asp:Label ID="lblCargo" runat="server" Text="Cargo: "></asp:Label>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtCargo" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Correo:
            </td>
            <td class="line-tr">
                <asp:Label ID="txtmail" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Telefono:
            </td>
            <td class="line-tr">
                <asp:Label ID="txtTelefono" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
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
        <tr>
            <td class="contenet-form">
                <h6>
                    Marcas y Productos</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Uso:
            </td>
            <td>
                <div style="width: 300px; margin: 0 auto;">
                    <asp:GridView ID="grvProd" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                        <Columns>
                            <asp:BoundField DataField="strMARCA" HeaderText="MARCA" />
                            <asp:BoundField DataField="strNOMBRE" HeaderText="PRODUCTO" />
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
        <tr>
            <td class="contenet-form">
                <h6>
                    Ámbito de Uso Solicitado</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
            </td>
            <td>
                <div>
                    <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" GridLines="None"
                        CssClass="mGrid" PagerStyle-CssClass="pgr">
                        <Columns>
                            <asp:BoundField HeaderText="USO" DataField="strTIPOLIC" />
                            <asp:BoundField HeaderText="APLICACIÓN" DataField="intSUBTIPO" />
                            <asp:BoundField HeaderText="DETALLE" DataField="strDESCRIPCION" />
                        </Columns>
                        <PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td class="contenet-form">
                <h6>
                    Declaración Jurada</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Declaración Jurada:&nbsp;&nbsp;
            </td>
            <td>
                &nbsp;&nbsp;
                <cc1:FileUploaderAJAX ID="FUAjaxDJurada" runat="server" text_Add="Adjuntar Ref" text_Uploading="Subiendo.."
                    CssClass="fileAjax" MaxFiles="1" />
                <br />
                <%-- <asp:FileUpload ID="FU_DJurada" runat="server" class="file"/>--%>
            </td>
        </tr>
        <tr>
            <td class="style6" colspan="2">
                Si no descargó su Declaración Jurada en el Paso 01 puede hacerlo desde <a href="../Public/ANEXO_2.pdf"
                    target="_blank" style="color: #ee2d23">aquí.</a>
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
