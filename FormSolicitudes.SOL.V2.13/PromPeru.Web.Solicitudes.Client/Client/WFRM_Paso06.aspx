<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso06.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso06" %>

<%@ Register Assembly="FUA" Namespace="Subgurim.Controles" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%= Page.ResolveClientUrl("~/js/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/modal-window.min.js") %>" type="text/javascript"></script>
    <script src="../js/jquery.tooltip.min.js" type="text/javascript"></script>
    <link href="../css/jquery.tooltip.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        $(document).ready(function () {
            //$("#<% =grvProdRef.clientID %> tbody tr:first").css("display", "none");
            $('.div-info a').tooltip({
                track: true,
                delay: 0,
                showURL: false,
                showBody: " - ",
                fade: 250
            });
        });


    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="content-body">
        <h4>
            Paso 6</h4>
    </div>
    <div class="contenet-form">
        <h6>
            El producto y su capacidad de elevar la imagen del Perú</h6>
    </div>
    <table class="table-content-form paso5" style="width: 807px; margin: 0 auto;">
        <tr>
            <td>
                <p class="question">
                    ¿Cuáles de sus marcas desea que lleven la marca Perú?</p>
                <p class="formt-especial">
                    (El solicitante deberá indicar las marcas y los distintos productos identificados
                    con dichas marca)</p>
            </td>
        </tr>
        <tr>
            <td>
                <div class="clear">
                </div>
                <div class="clear">
                </div>
                <div class="div-lick" style="float: left;">
                    <asp:HyperLink ID="lnkMarca" runat="server" NavigateUrl="wfrm_AddMarca.aspx" onClick="$(this).modal({width:500, height:260}).open(); return false;">Agregar Marca</asp:HyperLink>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5">
                <div>
                    <asp:GridView ID="grvMarca" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                        <Columns>
                            <asp:BoundField DataField="strMARCA" HeaderText="Marca" />
                            <asp:TemplateField HeaderText="Archivo">
                                <ItemTemplate>
                                    <asp:HyperLink Target="_blank" ID="lnkMarca" class="EFile" runat="server" Text='<%# Bind("strRUTAREGISTROINDECOPI") %>'
                                        NavigateUrl='<%# Bind("strRUTAREGISTROINDECOPI") %>'></asp:HyperLink>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Opciones">
                                <ItemTemplate>
                                    <div class="div-lickEliminar">
                                        <asp:LinkButton ID="lnkEliminar" runat="server" CommandName="Eliminar" title="Eliminar">Eliminar</asp:LinkButton>
                                    </div>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                    <div class="div-lick" style="float: left; margin-top: 20px;">
                        <table>
                            <tr>
                                <td>
                                    <asp:HyperLink ID="btn_add_prod" runat="server" NavigateUrl="addProd.aspx" onClick="$(this).modal({width:700, height:330}).open(); return false;">Agregar Producto</asp:HyperLink>
                                </td>
                                <td>
                                    <div class="div-info">
                                        <a class="info" title=" - EN CASO QUE LA MARCA DISTINGA MÁS DE UN PRODUCTO, EL SOLICITANTE DEBERÁ INCLUIR TODOS LOS PRODUCTOS QUE PERTENEZCAN AL PORTAFOLIO DE LA MISMA PARA VERIFICAR EL CUMPLIMIENTO DE LA REGLA 80/20. PARA MAS INFORMACIÓN HAGA CLIC"
                                            href="../Public/FAQ.html" target="_blank"></a>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div class="clear">
                    </div>
                    <asp:GridView ID="gViewProd" runat="server" AutoGenerateColumns="False" class="mGrid"
                        EmptyDataText="No se registraron productos">
                        <Columns>
                            <asp:BoundField DataField="strMarca" Visible="false" />
                            <asp:BoundField DataField="strMarca" HeaderText="Marca" />
                            <asp:BoundField DataField="strNOMBRE" HeaderText="Producto" />
                            <asp:BoundField DataField="dblPORC_FABRICACION" HeaderText="Fabricacion Peruana(%)" />
                            <asp:BoundField DataField="dblPORC_UNIDVENC" HeaderText="En unidades Vendidas" />
                            <asp:BoundField DataField="dblPORC_VALORVENTA" HeaderText="En Valor de Venta" />
                            <asp:TemplateField HeaderText="Opciones" HeaderStyle-Width="140px" ItemStyle-Width="140px"
                                FooterStyle-Width="140px">
                                <ItemTemplate>
                                    <div class="div-lickEditar">
                                        <asp:LinkButton ID="lnkEdit" runat="server" CommandName="lnkEdit">Editar</asp:LinkButton>
                                    </div>
                                    <div class="div-lickEliminar">
                                        <asp:LinkButton ID="btn_eliminar" runat="server" CausesValidation="false" CommandName="btn_eliminar"
                                            Text="" title="Eliminar">Eliminar</asp:LinkButton>
                                    </div>
                                </ItemTemplate>
                                <FooterStyle Width="140px"></FooterStyle>
                                <HeaderStyle Width="140px"></HeaderStyle>
                                <ItemStyle Width="140px"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <br />
                <br />
                <br />
                <br />
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    El solicitante deberá listar las referencias sobre su producto y adjuntar el documento
                    correspondiente. Estas pueden ser cartas de referencia de instituciones públicas
                    o gremios al que pudiesen pertenecer; y/o certificaciones, acreditaciones, premios,
                    reconocimientos, entre otros.)</p>
            </td>
        </tr>
        <tr>
            <td>
                <br />
                <cc1:FileUploaderAJAX ID="FUAjaxProd" runat="server" text_Add="Adjuntar Referencia"
                    text_Uploading="Subiendo.." CssClass="fileAjax" MaxFiles="10" />
                <br />
                <%--<asp:FileUpload ID="FU_CalidadProd" runat="server" class="file" />--%>
                <%-- <asp:RegularExpressionValidator ID="revCalidad" runat="server" 
                ControlToValidate="FU_CalidadProd" ErrorMessage="Formato Permitido: jpg, gif" 
                ValidationExpression="(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$"></asp:RegularExpressionValidator>
                --%>
            </td>
        </tr>
        <tr>
            <td>
                <%--   <div  class="div-lickleft">
             <asp:LinkButton ID="lnkRef" runat="server">Agregar una referencia mas</asp:LinkButton>
             </div>--%>
                <asp:GridView ID="grvProdRef" runat="server" AutoGenerateColumns="False" CssClass="mGrid">
                    <Columns>
                        <asp:TemplateField HeaderText="Archivo">
                            <ItemTemplate>
                                <asp:HyperLink Target="_blank" ID="lnkRF" class="EFile" runat="server" Text='<%# Bind("strRUTA_REF") %>'
                                    NavigateUrl='<%# Bind("strRUTA_REF") %>'></asp:HyperLink>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField>
                            <ItemTemplate>
                                <asp:LinkButton ID="lnkEliminar" runat="server" CommandName="Eliminar">Eliminar</asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
                <br />
                <br />
                <br />
                <asp:Button ID="btn_loadPage" runat="server" Text="load page" Style="display: none" />
                <br />
                <br />
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="btn_cancelar" runat="server" Text="Atras" CssClass="btn-sumit" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" CssClass="btn-sumit" />
        </div>
        <div class="buttom-center" style="width: auto; max-width: 540px; text-align: center;
            vertical-align: middle">
            <asp:Literal ID="ltrMsg" runat="server"></asp:Literal></div>
    </div>
    <div class="clear">
    </div>
</asp:Content>
