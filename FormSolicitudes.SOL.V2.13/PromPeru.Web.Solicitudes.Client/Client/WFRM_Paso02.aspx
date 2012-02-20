<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso02.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso02" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="../js/CustomRadioCheck.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 2</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Solicitante</h6>
    </div>
    <div class="div-solicitante">
        <table class="table-content-form">
            <tr>
                <td colspan="2" class="lb-radio">
                    <p>
                        <label class="label_radio" for="<%=Rb_pjuridica.clientID %>">
                            <asp:RadioButton ID="Rb_pjuridica" runat="server" Text="Persona Jurídica" GroupName="tipopersona" /><br />
                        </label>
                        <br />
                        <label class="label_radio" for="<%=Rb_pJuridicaExt.clientID %>">
                            <asp:RadioButton ID="Rb_pJuridicaExt" runat="server" Text="Persona Jurídica Extranjera"
                                GroupName="tipopersona" /><br />
                        </label>
                        <br />
                        <label class="label_radio" for="<%=Rb_pnaturalneg.clientID %>">
                            <asp:RadioButton ID="Rb_pnaturalneg" runat="server" Text="Persona Natural con Negocio"
                                GroupName="tipopersona" /></label><br />
                        <br />
                        <label class="label_radio" for="<%=Rb_orgestatal.clientID %>">
                            <asp:RadioButton ID="Rb_orgestatal" runat="server" Text="Organismo Estatal" GroupName="tipopersona" />
                        </label>
                    </p>
                </td>
            </tr>
        </table>
    </div>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="Btn_Cancelar" runat="server" Text="Atras" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" />
        </div>
        <div style="width: 500px; position: relative; top: 43px; left: 150px">
            <asp:Label ID="lblMsjError" CssClass="messbox" Visible="false" runat="server"></asp:Label>
        </div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
