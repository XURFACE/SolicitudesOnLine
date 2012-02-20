<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso07.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso07" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script type="text/javascript">
        $(document).ready(function () {
            $('.div-info a').tooltip({
                track: true,
                delay: 0,
                showURL: false,
                showBody: " - ",
                fade: 250
            });

        });
       
    </script>
    <div class="content-body">
        <h4>
            Paso 7</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Cuéntenos sobre el evento</h6>
    </div>
    <table class="table-content-form paso5" style="width: 807px; margin: 0 auto;">
        <tr>
            <td colspan="2">
                <p>
                    Es importante que la marca Perú acompañe todos los eventos que de alguna manera
                    pueden generar un impacto positivo en la imagen del Perú. Agradecemos su interés
                    en invitarnos a ser parte de su evento.</p>
                <br />
            </td>
            _
        </tr>
        <tr>
            <td class="style7">
                Nombre del evento:*
            </td>
            <td>
                <asp:TextBox ID="txtNomEvento" MaxLength="50" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNomEvento"
                    ErrorMessage="Ingrese Nombre del evento" ValidationGroup="valPso7">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Organizador:*
            </td>
            <td>
                <asp:TextBox ID="txtOrg" MaxLength="150" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvOrg" runat="server" ControlToValidate="txtOrg"
                    ErrorMessage="Ingrese organizador" ValidationGroup="valPso7">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Referencias del evento:<div class="div-info">
                    <a class="info" title="Adjuntar documentos (Notas de prensa, cartas, reconocimientos, entre otros) que certifiquen la calidad del evento."
                        href="#"></a>
                </div>
            </td>
            <td>
                <cc1:FileUploaderAJAX ID="FUAjaxRef0" runat="server" CssClass="fileAjax" MaxFiles="1"
                    text_Add="Adjuntar Referencia" text_Uploading="Subiendo.." />
                <div>
                    <asp:HyperLink ID="lnkRef" runat="server" class="EFile" Target="_blank" Visible="False">[lnkDNI]</asp:HyperLink>
                    <asp:Button ID="btnref" runat="server" class="quitar" Text="" Visible="False" />
                </div>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Descripción del Evento*:
            </td>
            <td>
                <asp:TextBox ID="txtDescEvento" runat="server" MaxLength="250" Width="400px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvOrg0" runat="server" ControlToValidate="txtDescEvento"
                    ErrorMessage="Ingrese descripción del evento" ValidationGroup="valPso7">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Agenda / Programa del evento:
            </td>
            <td>
                <cc1:FileUploaderAJAX ID="FUAjaxRef" runat="server" text_Add="Adjuntar Programa"
                    text_Uploading="Subiendo.." CssClass="fileAjax" MaxFiles="1" />
                <div>
                    <asp:HyperLink Target="_blank" ID="lnkAPE" runat="server" Visible="False" class="EFile">[lnkDNI]</asp:HyperLink>
                    <asp:Button ID="btnAPE" runat="server" Text="" Visible="False" class="quitar" />
                </div>
            </td>
        </tr>
        <tr>
            <td class="style7">
                No. Edición del Evento:
            </td>
            <td>
                <asp:TextBox ID="txtEdicEvento" runat="server" MaxLength="5"></asp:TextBox><asp:RequiredFieldValidator
                    ControlToValidate="txtEdicEvento" ID="RequiredFieldValidator4" runat="server"
                    ValidationGroup="valPso7" ErrorMessage="Ingrese No. Edición del Evento">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEdicEvento"
                    ErrorMessage="Edición debe ser numérico" ValidationExpression="^[0-9]*" ValidationGroup="valPso7">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Peridiocidad del Evento:
            </td>
            <td>
                <asp:DropDownList ID="ddlPeriodo" runat="server">
                    <asp:ListItem Value="29">SEMESTRAL</asp:ListItem>
                    <asp:ListItem Value="30">SEMANAL</asp:ListItem>
                    <asp:ListItem Value="31">MENSUAL</asp:ListItem>
                    <asp:ListItem Value="32">ANUAL</asp:ListItem>
                    <asp:ListItem Value="28">OTROS</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Lugar de Realización*:
            </td>
            <td>
                <asp:TextBox ID="txtRealiz" MaxLength="150" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ControlToValidate="txtRealiz" ID="RequiredFieldValidator2"
                    runat="server" ValidationGroup="valPso7" ErrorMessage="Ingrese número de participantes esperados">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Fecha de Realización:<div class="div-info">
                    <a class="info" title="Indicar inicio y fin del evento" href="#"></a>
                </div>
            </td>
            <td>
                <table>
                    <tr>
                        <td align="center">
                            Inicio
                        </td>
                        <td align="center">
                            &nbsp;
                        </td>
                        <td align="center">
                            Fin
                        </td>
                        <td align="center">
                            &nbsp;
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="txtFechaIni" runat="server" Width="150px" MaxLength="10"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ControlToValidate="txtFechaIni" ID="rfvfini" runat="server"
                                ValidationGroup="valPso7" ErrorMessage="Ingrese fecha de inicio">•</asp:RequiredFieldValidator>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFechaFin" runat="server" Width="150px" MaxLength="10"></asp:TextBox>
                        </td>
                        <td>
                            <asp:RequiredFieldValidator ControlToValidate="txtFechaFin" ID="rfvffin" runat="server"
                                ValidationGroup="valPso7" ErrorMessage="Ingrese fecha de fin">•</asp:RequiredFieldValidator>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Público Objetivo:
            </td>
            <td>
                <asp:TextBox ID="txtDescPGEvento" runat="server"></asp:TextBox><asp:RequiredFieldValidator
                    ControlToValidate="txtDescPGEvento" ID="RequiredFieldValidator3" runat="server"
                    ValidationGroup="valPso7" ErrorMessage="Ingrese Público Objetivo">•</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Participantes/Asistentes Esperados*:
            </td>
            <td>
                <asp:TextBox ID="txtPtesAtes" runat="server" MaxLength="5" Width="80px"></asp:TextBox><asp:RequiredFieldValidator
                    ControlToValidate="txtPtesAtes" ID="RequiredFieldValidator1" runat="server" ValidationGroup="valPso7"
                    ErrorMessage="Ingrese número de participantes esperados">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revParct" runat="server" ControlToValidate="txtPtesAtes"
                    ErrorMessage="debe ser numérico" ValidationExpression="^[0-9]*" ValidationGroup="valPso7">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Costo promedio de la participación / asistencia al evento:
            </td>
            <td>
                <asp:TextBox ID="txtCPartAsistEvento" runat="server" MaxLength="6" Width="80px"></asp:TextBox><asp:RequiredFieldValidator
                    ControlToValidate="txtCPartAsistEvento" ID="RequiredFieldValidator5" runat="server" ValidationGroup="valPso7"
                    ErrorMessage="Ingrese costo promedio">•</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revcost" runat="server" ControlToValidate="txtCPartAsistEvento"
                    ErrorMessage="Costo debe ser numérico" ValidationExpression="^[0-9]*" ValidationGroup="valPso7">•</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="style7">
                Auspiciadores y/o patrocinadores:
            </td>
            <td>
                <asp:TextBox ID="txtAuspPatron" MaxLength="500" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="bt_atras" runat="server" Text="Atras" CssClass="btn-sumit" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" CssClass="btn-sumit"
                ValidationGroup="valPso7" />
        </div>
        <div class="buttom-center" style="width: 565px; text-align: center; vertical-align: middle">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="messbox"
                ValidationGroup="valPso7" />
            <asp:Label ID="lblMessege" Visible="false" runat="server" CssClass="messbox" ForeColor="Red"></asp:Label></div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
