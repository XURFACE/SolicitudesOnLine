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
        function cargarImage(id) {
            $(this).modal({ width: 370, height: 300, src: "wfrm_Afiche.aspx?id=" + id }).open();
        }
        $(document).ready(function () {
            mostrarCampos();
            function mostrarCampos() {
                var tipo = $("#<%= txtload.ClientID %>").val();
                switch (tipo) {
                    case "0":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        break;
                    case "1":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        $("#ruc").css("display", "none");
                        $("#licfun").css("display", "none");
                        $("#prpj").css("display", "none");
                        $("#vgpoder").css("display", "none");
                        break;
                    case "2":
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
            float: right;
            margin-right: 0px;
        }
        table.table-content-form tr td
        {
            padding: 5px 0px;
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
        .table-content-form tr td.line-tr2
        {
            width: 350px;
        }
        .dr-libe
        {
            width: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table class="table-content-form" style="width: 96%;">
        <tr>
            <td align="right">
                Estado actual:&nbsp;
            </td>
            <td align="left" class="line-tr">
                <asp:Label ID="lblEstadoActual" runat="server" Text="APROBADO"></asp:Label>
                <asp:LinkButton ID="lnkEstado" runat="server" href="javascript:cargarPopupAdd()">Cambiar Estado</asp:LinkButton>
            </td>
        </tr>
        <tr>
            <td>
                <h6>
                    1. DATOS DEL SOLICITANTE</h6>
            </td>
            <td>
            </td>
        </tr>
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
                <span>Razon social:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtRazonSoc" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <span>Página Web:</span>
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
            <td colspan="2">
                <div class="line">
                </div>
            </td>
        </tr>
        <tr id="licfun">
            <td class="style6">
                <asp:Label ID="RotLicFunc" runat="server" Text="Licencia de Funcionamiento:"></asp:Label>
            </td>
            <td class="line-tr">
                <asp:HyperLink Target="_blank" ID="lnkLF" runat="server">[lnkLF]</asp:HyperLink>
            </td>
        </tr>
        <tr id="prpj">
            <td class="style6">
                <asp:Label ID="RotNPartida" runat="server" Text="Partida Registral de la Persona Jurídica:"
                    Height="16px" Width="228px"></asp:Label>
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
                <span>Correo:</span>
            </td>
            <td class="line-tr">
                <asp:Label ID="txtmail" runat="server" CssClass="textBox"></asp:Label>
            </td>
        </tr>
        <tr>
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
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <h6>
                    2. AMBITO DE USO SOLICITADO</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td>
                <label>
                    USO:</label>
                <strong>
                    <asp:Label ID="LUso" runat="server" Text=""></asp:Label></strong>
            </td>
            <td class="line-tr" style="border: 0px">
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <label>
                    <asp:Label ID="lblRotProd" runat="server" Text="LICENCIA AUTORIZADA PARA LOS PRODUCTOS:"></asp:Label>
                </label>
            </td>
            <td>
                <asp:GridView ID="grvProd" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                    <Columns>
                        <asp:BoundField DataField="NOMBRE" HeaderText="PRODUCTO" SortExpression="Estado" />
                        <asp:BoundField DataField="MARCA" HeaderText="MARCA" SortExpression="Fecha" />
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <br />
                <h6>
                    3. ARCHIVOS RELACIONADOS AL USO</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <span>Referencias de Empresa:</span>
            </td>
            <td valign="top">
                <asp:GridView ID="GVDocs" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                    <Columns>
                        <asp:BoundField DataField="IDAPL" HeaderText="ID" Visible="False" />
                        <asp:TemplateField HeaderText="Descripcion">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("DESCRIPCION") %>'
                                    NavigateUrl='<%# Bind("RUTA_ARCHIVO") %>'></asp:HyperLink>
                            </ItemTemplate>
                            <HeaderStyle Width="200px" />
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Opciones">
                            <ItemTemplate>
                                <div class="div-lickEliminar">
                                    <asp:LinkButton ID="LBDelete" runat="server" CausesValidation="False" CommandName="DeleteDoc"
                                        CommandArgument='<%# Bind("ID") %>' Text="Eliminar"></asp:LinkButton>
                                </div>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr id="trRefProds">
            <td class="style6">
                <span>Referencias de Producto:</span>
            </td>
            <td valign="top">
                <asp:GridView ID="grvProdRef" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                    <Columns>
                        <asp:TemplateField HeaderText="Archivo">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("strRUTA_REF") %>'
                                    NavigateUrl='<%# Bind("strRUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
        <tr>
            <td>
                <h6>
                    4. ARCHIVOS ADICIONALES</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width: 500px; margin: 0 auto;">
                    <asp:GridView ID="grvarcAdic" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                        DataKeyNames="IDAPL,STSAPLICACION">
                        <Columns>
                            <asp:BoundField DataField="RUTA_IMAGEN" HeaderText="Archivos" />
                            <asp:TemplateField HeaderText="Vista previa">
                                <ItemTemplate>
                                    <a href='javascript:cargarImage(<%#Eval("IDAPL") %>)' class="zoom">
                                        <img src="../images/pixel.gif" alt="cambiar" style="width: 14px; height: 14px;" />
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Aprobado">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkAprob" runat="server" AutoPostBack="true" Text="Aprobado" OnCheckedChanged="chkAprob_CheckedChanged" />
                                    <br />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </td>
        </tr>
        <tr>
            <td>
                <h6>
                    5. ARTES</h6>
            </td>
            <td>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div style="width: 500px; margin: 0 auto;">
                    <asp:GridView ID="grvAplicUso" runat="server" AutoGenerateColumns="False" CssClass="mGrid"
                        DataKeyNames="IDAPL,STSAPLICACION">
                        <Columns>
                            <asp:BoundField DataField="RUTA_IMAGEN" HeaderText="Archivos" />
                            <asp:TemplateField HeaderText="Vista previa">
                                <ItemTemplate>
                                    <a href='javascript:cargarImage(<%#Eval("IDAPL") %>)' class="zoom">
                                        <img src="../images/pixel.gif" alt="cambiar" style="width: 14px; height: 14px;" />
                                    </a>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Aprobado">
                                <ItemTemplate>
                                    <asp:CheckBox ID="chkAprob" runat="server" AutoPostBack="true" Text="Aprobado" OnCheckedChanged="chkAprob_CheckedChanged" />
                                    <br />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <asp:TextBox ID="txtload" runat="server" Style="display: none;"></asp:TextBox>
    <div class="clear">
    </div>
</asp:Content>
