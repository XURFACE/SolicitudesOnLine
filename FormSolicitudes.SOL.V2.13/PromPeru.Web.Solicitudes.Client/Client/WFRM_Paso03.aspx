<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso03.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso03" %>

<%@ Register Src="../UC/uc_GiroSector.ascx" TagName="uc_GiroSector" TagPrefix="uc1" %>
<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%= Page.ResolveClientUrl("~/js/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/modal-window.min.js") %>" type="text/javascript"></script>
    <script src="../js/jquery.tooltip.min.js" type="text/javascript"></script>
    <link href="../css/jquery.tooltip.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            //            $("#filedd").ready(function () {
            //                $(this).attr("class","file");
            //                alert("cargado...");
            //            });

            mostrarCampos();
            $('.div-info a').tooltip({
                track: true,
                delay: 0,
                showURL: false,
                showBody: " - ",
                fade: 250
            });
            function mostrarCampos() {
                var tipo = $("#<%= txtTipoEmpresa.ClientID %>").val();
                switch (tipo) {
                    case "0":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        break;
                    case "1":
                        $("#depto").css("display", "none");
                        $("#prov").css("display", "none");
                        $("#dist").css("display", "none");
                        //                        $("#ruc").css("display", "none");
                        // $("#licfun").css("display", "none");
                        //$("#dvLic").css("display", "none");
                        $("#prpj").css("display", "none");
                        $("#vgpoder").css("display", "none");
                        break;
                    case "2":
                        $("#ciudad").css("display", "none");
                        $("#pais").css("display", "none");
                        $("#prpj").css("display", "none");
                        //                        $("#rprlegal").css("display", "none");
                        //                        $("#cgorprs").css("display", "none");
                        $("#vgpoder").css("display", "none");
                        //                        $("#dto").css("display", "none");
                        $("#pcont").css("display", "none");
                        $("#cgo").css("display", "none");

                        //                     cargarPais();
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
            //         function cargarPais() {
            ////             var paises = ["Afganistán", "Akrotiri", "Albania", "Alemania", "Andorra", "Angola", "Anguila", "Antártida", "Antigua y Barbuda", "Antillas Neerlandesas", "Arabia Saudí", "Arctic Ocean", "Argelia", "Argentina", "Armenia", "Aruba", "Ashmore andCartier Islands", "Atlantic Ocean", "Australia", "Austria", "Azerbaiyán", "Bahamas", "Bahráin", "Bangladesh", "Barbados", "Bélgica", "Belice", "Benín", "Bermudas", "Bielorrusia", "Birmania Myanmar", "Bolivia", "Bosnia y Hercegovina", "Botsuana", "Brasil", "Brunéi", "Bulgaria", "Burkina Faso", "Burundi", "Bután", "Cabo Verde", "Camboya", "Camerún", "Canadá", "Chad", "Chile", "China", "Chipre", "Clipperton Island", "Colombia", "Comoras", "Congo", "Coral Sea Islands", "Corea del Norte", "Corea del Sur", "Costa de Marfil", "Costa Rica", "Croacia", "Cuba", "Dhekelia", "Dinamarca", "Dominica", "Ecuador", "Egipto", "El Salvador", "El Vaticano", "Emiratos Árabes Unidos", "Eritrea", "Eslovaquia", "Eslovenia", "España", "Estados Unidos", "Estonia", "Etiopía", "Filipinas", "Finlandia", "Fiyi", "Francia", "Gabón", "Gambia", "Gaza Strip", "Georgia", "Ghana", "Gibraltar", "Granada", "Grecia", "Groenlandia", "Guam", "Guatemala", "Guernsey", "Guinea", "Guinea Ecuatorial", "Guinea-Bissau", "Guyana", "Haití", "Honduras", "Hong Kong", "Hungría", "India", "Indian Ocean", "Indonesia", "Irán", "Iraq", "Irlanda", "Isla Bouvet", "Isla Christmas", "Isla Norfolk", "Islandia", "Islas Caimán", "Islas Cocos", "Islas Cook", "Islas Feroe", "Islas Georgia del Sur y Sandwich del Sur", "Islas Heard y McDonald", "Islas Malvinas", "Islas Marianas del Norte", "IslasMarshall", "Islas Pitcairn", "Islas Salomón", "Islas Turcas y Caicos", "Islas Vírgenes Americanas", "Islas Vírgenes Británicas", "Israel", "Italia", "Jamaica", "Jan Mayen", "Japón", "Jersey", "Jordania", "Kazajistán", "Kenia", "Kirguizistán", "Kiribati", "Kuwait", "Laos", "Lesoto", "Letonia", "Líbano", "Liberia", "Libia", "Liechtenstein", "Lituania", "Luxemburgo", "Macao", "Macedonia", "Madagascar", "Malasia", "Malaui", "Maldivas", "Malí", "Malta", "Man, Isle of", "Marruecos", "Mauricio", "Mauritania", "Mayotte", "México", "Micronesia", "Moldavia", "Mónaco", "Mongolia", "Montserrat", "Mozambique", "Namibia", "Nauru", "Navassa Island", "Nepal", "Nicaragua", "Níger", "Nigeria", "Niue", "Noruega", "Nueva Caledonia", "Nueva Zelanda", "Omán", "Pacific Ocean", "Países Bajos", "Pakistán", "Palaos", "Panamá", "Papúa-Nueva Guinea", "Paracel Islands", "Paraguay", "Perú", "Polinesia Francesa", "Polonia", "Portugal", "Puerto Rico", "Qatar", "Reino Unido", "República Centroafricana", "República Checa", "República Democrática del Congo", "República Dominicana", "Ruanda", "Rumania", "Rusia", "Sáhara Occidental", "Samoa", "Samoa Americana", "San Cristóbal y Nieves", "San Marino", "San Pedro y Miquelón", "San Vicente y las Granadinas", "Santa Helena", "Santa Lucía", "Santo Tomé y Príncipe", "Senegal", "Seychelles", "Sierra Leona", "Singapur", "Siria", "Somalia", "Southern Ocean", "Spratly Islands", "Sri Lanka", "Suazilandia", "Sudáfrica", "Sudán", "Suecia", "Suiza", "Surinam", "Svalbard y Jan Mayen", "Tailandia", "Taiwán", "Tanzania", "Tayikistán", "TerritorioBritánicodel Océano Indico", "Territorios Australes Franceses", "Timor Oriental", "Togo", "Tokelau", "Tonga", "Trinidad y Tobago", "Túnez", "Turkmenistán", "Turquía", "Tuvalu", "Ucrania", "Uganda", "Unión Europea", "Uruguay", "Uzbekistán", "Vanuatu", "Venezuela", "Vietnam", "Wake Island", "Wallis y Futuna", "West Bank", "World", "Yemen", "Yibuti", "Zambia", "Zimbabue"];
            ////             $.each(paises, function (indice, valor) {
            ////                 $("#<% =ddlPaises.clientID %>").append($("<option></option>").attr("value", indice).text(valor));
            ////             });
            //         }
            $("#<% =dlldepartamento.clientID %>").change(function () {
                var dpto = PromPeru.Web.Solicitudes.Client.WFRM_Paso03.cargarProvincia($(this).val());
                $("#<%=dllprovincia.ClientID%>").html("");
                cargarDDLProv(dpto);

            });
            function cargarDDLProv(resultado) {

                $("#<%=dllprovincia.ClientID%>").html(resultado.value);

                var distr = PromPeru.Web.Solicitudes.Client.WFRM_Paso03.cargarDistritos($("#<% =dlldepartamento.clientID %>").val(), $("#<%=dllprovincia.ClientID%>").val());
                cargarDDLDist(distr);
            }
            $("#<% =dllprovincia.clientID %>").change(function () {
                var distr = PromPeru.Web.Solicitudes.Client.WFRM_Paso03.cargarDistritos($("#<% =dlldepartamento.clientID %>").val(), $(this).val());
                $("#<%=dllDistrito.ClientID%>").html("");
                cargarDDLDist(distr);
            });
            function cargarDDLDist(resultado) {

                $("#<%=dllDistrito.ClientID%>").html(resultado.value);
            }
        });
    </script>
    <style type="text/css">
        .style9
        {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 3
        </h4>
    </div>
    <div class="contenet-form">
        <h6>
            Por favor registre los datos de su empresa</h6>
    </div>
    <table class="table-content-form">
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                <asp:HyperLink ID="lnkBuscar" runat="server" href="wfrm_BuscarEmpresa.aspx" class="enlace"
                    OnClick="$(this).modal({width:740, height:450}).open(); return false;">Buscar Empresa</asp:HyperLink>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="lblRotRazSoc" runat="server" Text="Razón social:*"></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtRazonSoc" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvRazonSocial" runat="server" ControlToValidate="txtRazonSoc"
                    ErrorMessage="Ingrese Razon Social" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="ruc">
            <td class="style6">
                <asp:Label ID="lblRucEtiq" runat="server" Text="RUC:*" Style="margin-right: -12px"></asp:Label>
                &nbsp;&nbsp;
                <div class="div-info" id="divInfoRuc" runat="server">
                    <a class="info" title=" - Documento de identificación que tiene la empresa ante la entidad tributaria de su país"
                        href="#"></a>
                </div>
            </td>
            <td>
                <asp:TextBox ID="Txt_RUC" runat="server" CssClass="textBox" MaxLength="11"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvRuc" runat="server" ControlToValidate="Txt_RUC"
                    ErrorMessage="Ingrese Ruc" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revRuc" runat="server" ControlToValidate="Txt_RUC"
                    ErrorMessage="Ingrese RUC(11 digitos) " ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"
                    ValidationGroup="vlrPaso">•</asp:RegularExpressionValidator>
                <div>
                    <asp:HyperLink Target="_blank" ID="lnkRuc" runat="server" Visible="False" class="EFile">[lnkRuc]</asp:HyperLink>
                    <asp:Button ID="btnQuitRuc" runat="server" Visible="False" class="quitar" />
                </div>
                <asp:Label ID="lblAyudaFichaRUC" runat="server" CssClass="ayuda" Text="Adjuntar ficha RUC"></asp:Label>
                <cc1:FileUploaderAJAX ID="FUAjaxRuc" runat="server" text_Add="Adjuntar Ruc" text_Uploading="Subiendo..."
                    CssClass="fileAjax" MaxFiles="1" text_Delete="Eliminar" text_X="[x]" />
            </td>
        </tr>
        <tr id="prpj">
            <td class="style6">
                <label id="RotNPartidalbl" for="npartida">
                    <asp:Label ID="RotNPartida" runat="server" Text="Número de Partida Registral:" Style="margin-right: -12px"></asp:Label>&nbsp;&nbsp;
                    <div class="div-info tooltips">
                        <a class="info" title=" - Número de inscripción en los registros públicos" href="#">
                        </a>
                    </div>
                    &nbsp;&nbsp;
                </label>
            </td>
            <td class="style5">
                <asp:TextBox ID="txtPartida" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="revPartida" runat="server" ControlToValidate="txtPartida"
                    ErrorMessage="Ingrese Partida Registral" ValidationGroup="vlrPaso" Visible="False">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="vgpoder">
            <td class="style6" style="height: 29px">
                <asp:Label ID="RtoVigencia" runat="server" Text="Vigencia de Poder: "></asp:Label>
                <div class="div-info tooltips">
                    <a class="info" title=" - Documento otorgado por la oficina registral respectiva con un periodo de antiguedad no mayor de 4 meses"
                        href="#"></a>
                </div>
                &nbsp;&nbsp;&nbsp; &nbsp;
            </td>
            <td class="style9">
                <p class="ayuda">
                    Adjuntar vigencia</p>
                <cc1:FileUploaderAJAX ID="FUAjaxVP" runat="server" CssClass="fileAjax" MaxFiles="1"
                    text_Add="Adjuntar VP" text_Uploading="Subiendo.." />
                <div>
                    <asp:HyperLink Target="_blank" ID="lnkVP" runat="server" Visible="False" class="EFile">[lnkVP]</asp:HyperLink>
                    <asp:Button ID="btnQuitVP" runat="server" Visible="False" class="quitar" />
                </div>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Página Web:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtWeb" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvWeb" runat="server" ControlToValidate="txtCargo"
                    ErrorMessage="Ingrese la Web" ValidationGroup="vlrPaso" Visible="False">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revPagWeb" runat="server" ControlToValidate="txtWeb"
                    ErrorMessage="Por favor ingrese la pagina con el formato www.google.com" ValidationExpression="([\w-]+\.)+[\w-]+(/[\w- ./?%&amp;amp;=]*)?"
                    ValidationGroup="vlrPaso">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                <asp:Label ID="lblGiro" runat="server" Text="Giro Principal de la Empresa:*"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <uc1:uc_GiroSector ID="uc_Giro" Tipo="Giro" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <div class="line">
                </div>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Domicilio:*&nbsp;&nbsp; &nbsp;&nbsp;
            </td>
            <td>
                <table class="style4" id="nacional">
                    <tr>
                        <td class="style8">
                            Direccion:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:TextBox ID="txtDireccion" runat="server" CssClass="direc"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ID="revDirec" runat="server" ControlToValidate="txtDireccion"
                                ErrorMessage="Ingrese Direccion" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                    <tr id="depto">
                        <td class="style8">
                            Departamento:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:DropDownList ID="dlldepartamento" runat="server" CssClass="comboBox">
                            </asp:DropDownList>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr id="prov">
                        <td class="style8">
                            Provincia:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:DropDownList ID="dllprovincia" runat="server" CssClass="comboBox">
                            </asp:DropDownList>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr id="dist">
                        <td class="style8">
                            Distrito:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:DropDownList ID="dllDistrito" runat="server" CssClass="comboBox">
                            </asp:DropDownList>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr id="ciudad">
                        <td class="style8">
                            Pais:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlPaises" runat="server">
                            </asp:DropDownList>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr id="pais">
                        <td class="style8">
                            Ciudad:&nbsp;&nbsp;
                        </td>
                        <td>
                            <asp:TextBox ID="txtCiudad" runat="server" CssClass="direc"></asp:TextBox>
                        </td>
                        <td>
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
                    <div id="dvLic" runat="server" class="div-info tooltips">
                        <a class="info" title=" - Documento otorgado  por la oficina registral o autoridad competente de su país a su empresa donde se acredita el poder del representante legal. El documento debe tener una antigüedad no mayor de 4 meses."
                            href="#"></a>
                    </div>
                    &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
                </label>
            </td>
            <td>
                <div>
                    &nbsp;<asp:HyperLink Target="_blank" ID="lnkLF" runat="server" Visible="False" class="EFile">[lnkLF]</asp:HyperLink>
                    <asp:Button ID="btnQuitFLF" runat="server" Visible="False" class="quitar" />
                    <br />
                </div>
                <p class="ayuda">
                    Adjuntar licencia</p>
                <cc1:FileUploaderAJAX ID="FUAjaxLF" runat="server" CssClass="fileAjax" MaxFiles="1"
                    text_Add="Adjuntar LF" text_Uploading="Subiendo.." />
            </td>
        </tr>
        <tr id="rprlegal">
            <td class="style6">
                <asp:Label ID="lblRepresLegal" runat="server" Text="Representante Legal:*"></asp:Label>
                &nbsp; &nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtRepresentante" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvRepres" runat="server" ControlToValidate="txtRepresentante"
                    ErrorMessage="Ingrese Representante" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="cgorprs">
            <td class="style6">
                <asp:Label ID="lblCgoRepre" runat="server" Text="Cargo del Representante Legal*:"></asp:Label>&nbsp;
                &nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtCgoRepres" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCgoRepre" runat="server" ControlToValidate="txtCgoRepres"
                    ErrorMessage="Cargo Representante" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="tipoDoc">
            <td class="style6">
                Tipo de Documento:&nbsp; &nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:DropDownList ID="ddlTipoDoc" runat="server" AutoPostBack="True">
                    <asp:ListItem>DNI</asp:ListItem>
                    <asp:ListItem>Pasaporte</asp:ListItem>
                    <asp:ListItem>Carnet de Extranjeria</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr id="dto">
            <td class="style6">
                <asp:Label ID="lblDNI" runat="server" Text="N° de documento de Identidad:* " Style="margin-right: -12px"></asp:Label>
                &nbsp; &nbsp;&nbsp;
                <div class="div-info">
                    <a class="info" title=" - Adjuntar copia del documento de Identidad del representante legal de la Persona Jurídica"
                        href="#"></a>
                </div>
            </td>
            <td>
                <asp:TextBox ID="txtdniRepr" runat="server" CssClass="textBox" MaxLength="8"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvDNI" runat="server" ControlToValidate="txtdniRepr"
                    ErrorMessage="Ingrese número de documento de identidad" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="rev" runat="server" ControlToValidate="txtdniRepr"
                    ErrorMessage="Ingrese DNI (8 Digitos) " ValidationExpression="[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"
                    ValidationGroup="vlrPaso">•</asp:RegularExpressionValidator>
                <br />
                Adjuntar Documento de Identidad
                <cc1:FileUploaderAJAX ID="FUAjaxDNI" runat="server" CssClass="fileAjax" MaxFiles="1"
                    text_Add="Adjuntar DNI" text_Uploading="Subiendo.." />
                <div>
                    <asp:HyperLink Target="_blank" ID="lnkDNI" runat="server" Visible="False" class="EFile">[lnkDNI]</asp:HyperLink>
                    <asp:Button ID="btnQuitDNI" runat="server" Visible="False" class="quitar" />
                </div>
            </td>
        </tr>
        <tr id="pcont">
            <td class="style6">
                <asp:Label ID="lblPContacto" runat="server" Text="Persona de Contacto:*"></asp:Label>
                &nbsp;&nbsp; &nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtContacto" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPerCont" runat="server" ControlToValidate="txtContacto"
                    ErrorMessage="Persona de Contacto" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="cgo">
            <td class="style6">
                <asp:Label ID="lblCargo" runat="server" Text="Cargo:* "></asp:Label>
                &nbsp; &nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtCargo" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvCargo" runat="server" ControlToValidate="txtCargo"
                    ErrorMessage="Ingrese Cargo" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Correo electrónico:*&nbsp;&nbsp; &nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtmail" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvMail" runat="server" ControlToValidate="txtmail"
                    ErrorMessage="Ingrese el Email" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtmail"
                    ErrorMessage="Por favor ingrese su Email con el formato ejmplo@domain.com " ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                    ValidationGroup="vlrPaso">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                Telefono:*&nbsp;&nbsp; &nbsp;&nbsp;
            </td>
            <td>
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="textBox"></asp:TextBox>
                <asp:RegularExpressionValidator ID="revTelefono" runat="server" ControlToValidate="txtTelefono"
                    ErrorMessage=" Ingrese Telefono" ValidationExpression="^[0-9]+(\[0-9]+)?$" ValidationGroup="vlrPaso">•</asp:RegularExpressionValidator>
                <asp:RequiredFieldValidator ID="refTelef" runat="server" ControlToValidate="txtTelefono"
                    ErrorMessage="Ingrese el Telefono" ValidationGroup="vlrPaso">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtSearchIdEmpresa" runat="server" Style="display: none;"></asp:TextBox>
                <br />
                <asp:Button ID="btnLoadEmpresa" runat="server" Text="Cargar Empresa" Style="display: none;" />
                <asp:TextBox ID="txtTipoEmpresa" runat="server" Style="display: none;"></asp:TextBox>
            </td>
            <td>
                &nbsp;
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class="buttom-left">
            <asp:Button ID="Btn_Cancelar" runat="server" Text="Atras" CssClass="btn-sumit" />
        </div>
        <div class="buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" CssClass="btn-sumit"
                ValidationGroup="vlrPaso" />
        </div>
    </div>
    <div style="margin: 0 auto; width: 450px;">
        <asp:Label ID="lblMsjError" Visible="false" runat="server"></asp:Label>
        <asp:ValidationSummary ID="vlatorSummary" runat="server" CssClass="messbox" ValidationGroup="vlrPaso" />
    </div>
    <div class="clear">
    </div>
</asp:Content>
