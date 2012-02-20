<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso04.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso04" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/CustomRadioCheck.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Ocultarchb(chbName) {
            $(chbName).css("display", "none");
        }
        $(document).ready(function () {
            var check = 0;
            var cont = 1;

            $("input[type='checkbox']").each(function () {
                if ($(this).is(":checked")) {
                    check++;
                    //alert(cont); //$(this).attr("id"))
                    var tag = ".divcheck" + cont / 2;
                    $(tag).css("display", "block");
                    $(".div-form4").css("display", "block");
                }

                cont++;
            });

            $("#<%= chbInst.ClientID%>").click(function () {

                if ($("#<%= chbInst.ClientID%>").attr("checked")) {
                    $(".divcheck1").css("display", "block");
                    $(".div-form4").css("display", "block");
                    check = check + 1;
                } else {

                    check = check - 1;
                    $(".divcheck1").css("display", "none");
                    if (check <= 0) {
                        $(".div-form4").css("display", "none");
                    }

                }
            });
            $("#<%= chbprod.ClientID%>").click(function () {
                if ($("#<%= chbprod.ClientID%>").attr("checked")) {
                    $(".divcheck3").css("display", "block");
                    $(".div-form4").css("display", "block");
                    check = check + 1;
                } else {
                    check = check - 1;

                    $(".divcheck3").css("display", "none");
                    if (check <= 0) {
                        $(".div-form4").css("display", "none");
                    }

                }
            });
            $("#<%= chbEventos.ClientID%>").click(function () {
                if ($("#<%= chbEventos.ClientID%>").attr("checked")) {
                    $(".divcheck2").css("display", "block");
                    $(".div-form4").css("display", "block");
                    check = check + 1;
                } else {
                    check = check - 1;
                    $(".divcheck2").css("display", "none");
                    if (check <= 0) {
                        $(".div-form4").css("display", "none");
                    }

                }
            });
        });
    </script>
    <style type="text/css">
        .title-p
        {
            font-family: 'Bree';
            font-size: 17px;
            font-weight: normal;
            color: #EE2D23;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 4</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Elija el uso requerido</h6>
    </div>
    <div class="div-formulario">
        <table class="table-content-form">
            <tr id="trinst">
                <td colspan="2" class="lb-radio">
                    <p>
                        <label class="label_check" for="<%=chbInst.clientID %>">
                            <input name="sample-checkbox-02" id="checkbox-02" value="1" type="checkbox" />
                            <asp:CheckBox ID="chbInst" runat="server" Text="USO INSTITUCIONAL" /><br />
                        </label>
                    </p>
                </td>
            </tr>
            <tr id="trProd">
                <td colspan="2" class="lb-radio">
                    <p>
                        <label class="label_check" for="<%=chbprod.clientID %>">
                            <input name="sample-checkbox-02" id="checkbox1" value="1" type="checkbox" />
                            <asp:CheckBox ID="chbprod" runat="server" Text="USO EN PRODUCTOS" /><br />
                        </label>
                    </p>
                </td>
            </tr>
            <tr id="trEvnt">
                <td colspan="2" class="lb-radio">
                    <p>
                        <label class="label_check" for="<%=chbEventos.clientID %>">
                            <input name="sample-checkbox-02" id="checkbox2" value="1" type="checkbox" />
                            <asp:CheckBox ID="chbEventos" runat="server" Text="USO EN EVENTOS" />
                        </label>
                    </p>
                </td>
            </tr>
        </table>
    </div>
    <div class="div-form4" style="display: none;">
        <div class="divcheck1" style="display: none;">
            <p class="title-p">
                Institucional:
            </p>
            <p>
                Es el uso de la Marca País a nivel organizacional para sus comunicaciones institucionales,
                tales como página web, papelería en general, material promocional de distribución
                gratuita, publicidad referida a la trayectoria de la institución o a la prestación
                de sus servicios (no en productos), entre otros.<br />
                <br />
                El Uso Institucional no incluye el uso en firmas de correos electrónicos, tarjetas
                de presentación, fotochecks y boletas o facturas salvo que se cuente con autorización
                expresa y escrita de PROMPERÚ.</p>
        </div>
        <div class="divcheck3" style="display: none;">
            <p class="title-p">
                Productos:</p>
            <p>
                Es el uso de la Marca País acompañando a marcas registradas que distinguen productos
                peruanos, a través de etiquetas, envases, envoltorios y publicidad referida al producto,
                entre otros.<br />
                <br />
                Cuando la marca del solicitante identifica a un portafolio de productos peruanos
                e importados; para autorizar el uso de la Marca País, es necesario que el 80% del
                portafolio, tanto en unidades vendidas como en valor de venta, esté compuesto de
                productos peruanos.<br />
                <br />
                PROMPERÚ podrá autorizar también el Uso en Productos, en los siguientes casos:<br />
                a.Productos peruanos de marca blanca, cuando son productos peruanos de exportación.<br />
                b.Productos que involucran derechos de autor, cuando el solicitante cuente con la
                documentación que acredite su titularidad sobre tales derechos o su derecho a usufructuar
                de los mismos, según el caso.</p>
        </div>
        <div class="divcheck2" style="display: none;">
            <p class="title-p">
                Eventos:</p>
            <p>
                Es el uso para organizar eventos nacionales o extranjeros por personas naturales
                con negocio o personas jurídicas nacionales o extranjeras que promocionan el turismo,
                las exportaciones, las inversiones o la imagen del país.
            </p>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="Btn_Cancelar" runat="server" Text="Atras" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" />
        </div>
        <div class="buttom-center" style="width: auto; text-align: center; vertical-align: middle">
            <asp:Label ID="lblMessege" Visible="false" runat="server" CssClass="messbox" ForeColor="Red"></asp:Label></div>
    </div>
    <asp:TextBox ID="txtTipoEmpresa" runat="server" Style="display: none;"></asp:TextBox>
    <div class="clear">
    </div>
</asp:Content>
