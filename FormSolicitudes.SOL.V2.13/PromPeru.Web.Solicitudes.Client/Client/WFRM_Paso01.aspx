<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master" CodeBehind="WFRM_Paso01.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso01" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%= Page.ResolveClientUrl("~/js/jquery.validate.min.js") %>" type="text/javascript"></script>
<script type="text/javascript" >

    $(document).ready(function () {

        $("#<% =txtObjOtros.clientID %>").css("display", "none");

        if ($("#<% =dllObjetivos.clientID%> option:selected").val() == "Otros") {
            $("#<% =txtObjOtros.clientID %>").css("display", "block");
        }

        $("#aspnetForm").validate();


        //$("select option:selected[value='Otros']").attr("disabled", true);
        $("select").change(function () {
            var str = "";
            $("select option:selected").each(function () {
                str = $(this).text();
                if (str == "Otros") {
                    $("#<% =txtObjOtros.clientID %>").css("display", "block");
                    $("#<% =txtObjOtros.clientID %>").addClass("required");
                }
                else {
                     $("#<% =txtObjOtros.clientID %>").val("")
                    .css("display", "none")
                    .removeClass("required");

                }
            });

        });

    });

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 1</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Introducción</h6>
        <div class="img-conten">
            <img src="../images/paso1.PNG" alt="img" />
        </div>
        <div class="conten-text-right">
            <p>Muchas gracias por iniciar el proceso para solicitar el uso de la marca país y así contribuir con la campaña de promocionar la imagen del Perú.</p>
           <p>Al finalizar el proceso, tendrá que adjuntar una declaración jurada la cual puede ir descargando del siguiente <a href="../Public/ANEXO_2.pdf" target="_blank" style="color:#ee2d23">enlace.</a></p>

            <p>La Marca País Perú es la herramienta de promoción del Perú que tiene como objetivo 
            la promoción del turismo, las exportaciones, las inversiones y la imagen del país
             , a nivel nacional e internacional.</p>
        </div>
        <div class="conten-text-right">
            <table class="table-content-form">
                <tr>
                    <td colspan="2">
                        <p>Por favor indicar a cuál de estos objetivos se encuentra alineada su empresa.</p>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                     
                        <asp:DropDownList ID="dllObjetivos" runat="server" class="form1">
                            <asp:ListItem Value="Exportaciones">Exportaciones</asp:ListItem>
                            <asp:ListItem Value="Turismo">Turismo</asp:ListItem>
                            <asp:ListItem Value="Inversiones">Inversiones</asp:ListItem>
                            <asp:ListItem Value="Imagen País - Gastronomia">Imagen País - Gastronomia</asp:ListItem>
                            <asp:ListItem Value="Imagen País - Arte y Cultura">Imagen País - Arte y Cultura</asp:ListItem>
                            <asp:ListItem Value="Imagen País - Desarrollo de Valores">Imagen País - Desarrollo de Valores</asp:ListItem>
                            <asp:ListItem Value="Imagen País - Deportes">Imagen País - Deportes</asp:ListItem>
                            <asp:ListItem Value="Otros">Otros</asp:ListItem>
                        </asp:DropDownList>
                  
                    </td>                  
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="txtObjOtros" runat="server" MaxLength="50" class="paso1" Width="261px"></asp:TextBox>
                                   
                    </td>
                    <td> <asp:RequiredFieldValidator ID="rvfOtros" runat="server" 
                            ControlToValidate="txtObjOtros" ErrorMessage="*" Visible="False"></asp:RequiredFieldValidator>  </td>
                </tr>

                 <tr>
                    <td colspan="2">
                    
                    <p>¿Cuéntenos cómo está alineada su empresa a dicho objetivo?</p>                      
                        
                       
                    </td>
                    
                </tr>
                <tr>
                    <td>
                    
                                
                        <asp:TextBox ID="txtAPorq" runat="server" TextMode="MultiLine" class="paso1"></asp:TextBox>
                       
                    </td>
                    <td> <asp:RequiredFieldValidator ID="rfvObj" runat="server" CssClass="msgbox"
                            ControlToValidate="txtAPorq" ErrorMessage="*"></asp:RequiredFieldValidator></td>
                </tr>
            </table>
        </div>
    </div>
    <div class="clear">
    </div>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="Btn_Cancelar" runat="server" Text="Atras" Visible="False" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" />
        </div>
    </div>
    
    <div class="clear">
    </div>
</asp:Content>
