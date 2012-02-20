<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="WFRM_Paso08.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.WFRM_Paso08" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <script src="<%= Page.ResolveClientUrl("~/js/jquery-1.3.2.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/modal-window.min.js") %>" type="text/javascript"></script>
    <script src="<%= Page.ResolveClientUrl("~/js/jquery.validate.min.js") %>" type="text/javascript"></script>
    <script src="../js/CustomRadioCheck.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#aspnetForm").validate();
            $("#<% =btn_load.clientID %>").css("display", "none");
            $("input[type=text]").attr("disabled", true);
            $("input[type=checkbox]").each(function () {

                switchInpus($(this).attr("id"));
            });

            $("input[type=checkbox]").change(function () {

                switchInpus($(this).attr("id"));

            });
            function switchInpus(id) {
                switch (id) {

                    case "<% =chb_provincias.clientID %>":
                        cambiarEstado("#<% =txtReg.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_ams.clientID %>":
                        cambiarEstado("#<% =txtAms.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_amn.clientID %>":
                        cambiarEstado("#<% =txtAmn.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_amcen.clientID %>":
                        cambiarEstado("#<% =txtAmc.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_eur.clientID %>":
                        cambiarEstado("#<% =txtEur.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_asia.clientID %>":
                        cambiarEstado("#<% =txtAsia.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_afri.clientID %>":
                        cambiarEstado("#<% =txtAfr.clientID %>", $("#" + id).is(":checked"));
                        break;
                    case "<% =chb_oceania.clientID %>":
                        cambiarEstado("#<% =txtOce.clientID %>", $("#" + id).is(":checked"));
                        break;
                }

            }
            function cambiarEstado(id, valor) {

                if (valor) {
                    $(id).removeAttr("disabled").addClass("required");

                } else {
                    $(id).attr("disabled", true).removeClass("required");

                }
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
            Paso Final</h4>
    </div>
    <div class="contenet-form">
        <h6>
            Sobre el uso de la marca país</h6>
    </div>
    <table class="table-content-form paso5" style="width: 807px; margin: 0 auto;">
        <tr>
            <td colspan="2" class="style9">
                <p>
                    Es importante conocer más detalles sobre su motivación para usar la marca y cómo
                    la utilizarán.</p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p class="question">
                    ¿Para qué quiere usar la marca País?</p>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:TextBox ID="txtRstaMP" runat="server" class="solic" TextMode="MultiLine"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <h6 class="align">
                    Ámbito de Uso de la Marca País Perú</h6>
                <p>
                    Indicar todos los mercados donde comercializa sus productos</p>
                <div>
                    <table class="tabla-form">
                        <thead>
                            <tr>
                                <th class="style3">
                                    Público
                                </th>
                                <th class="style3">
                                    Detalle
                                </th>
                                <th class="style3">
                                    Nombres(paises/regiones)
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td rowspan="2">
                                    &nbsp;
                                     <asp:CheckBox ID="chb_nacional" runat="server" Text="NACIONAL" 
                                        Checked="True" Visible="False" />
                                   <%-- <label class="label_check" for="<%=chb_nacional.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox-02" value="1" type="checkbox" />
                                       
                                       
                                    </label>--%> NACIONAL
                                </td>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_lima.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox1" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_lima" runat="server" Text="Lima" />
                                    </label>
                                </td>
                                <th class="vacio">
                                    &nbsp;
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_provincias.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox2" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_provincias" runat="server" Text="Regiones" />
                                    </label>
                                </td>
                                <th>
                                    
                                    <asp:TextBox ID="txtReg" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td rowspan="7">
                                 <asp:CheckBox ID="chb_internacional" runat="server" Text="INTERNACIONAL" 
                                        Checked="True" Visible="False" />
                                    &nbsp;<%--<label class="label_check" for="<%=chb_internacional.clientID %>">
                                    <input name="sample-checkbox-02" id="checkbox3" value="1" type="checkbox" />
                                       
                                       
                                    </label>--%> INTERNACIONAL
                                </td>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_ams.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox4" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_ams" runat="server" Text="America del Sur" />
                                        
                                    </label>
                                </td>
                                <th>
                                    
                                    <asp:TextBox ID="txtAms" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_amn.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox6" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_amn" runat="server" Text="America del Norte" />
                                    </label>
                                </td>
                                <th>
                                   
                                    <asp:TextBox ID="txtAmn" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_amcen.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox8" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_amcen" runat="server" Text="Centromerica" />
                                    </label>
                                </td>
                                <th>
                                    
                                    <asp:TextBox ID="txtAmc" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_eur.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox10" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_eur" runat="server" Text="Europa" />
                                    </label>
                                </td>
                                <th>
                                    <asp:TextBox ID="txtEur" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_asia.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox12" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_asia" runat="server" Text="Asia" />
                                    </label>
                                </td>
                                <th>
                                    
                                    <asp:TextBox ID="txtAsia" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_afri.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox14" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_afri" runat="server" Text="Africa" />
                                    </label>
                                </td>
                                <th>
                                    <asp:TextBox ID="txtAfr" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                            <tr>
                                <td>
                                    &nbsp;
                                    <label class="label_check" for="<%=chb_oceania.clientID %>">
                                        <input name="sample-checkbox-02" id="checkbox16" value="1" type="checkbox" />
                                        <asp:CheckBox ID="chb_oceania" runat="server" Text="Oceanía" />
                                    </label>
                                </td>
                                <th>
                                  
                                    <asp:TextBox ID="txtOce" runat="server" CssClass="textbox" Width="250px"></asp:TextBox>
                                </th>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <h6 class="align">
                    Aplicación de la Marca País Perú</h6>               
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    USOS SOLICITADOS :</p>
            </td>
            <td style="width: 650px;">
                <asp:Label ID="lblUso" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <p>
                    Complete el cuadro indicando cómo y dónde desea utilizar la marca dando clic en Agregar</p>
                <div class="div-lick" style="float: left;">
                    <asp:LinkButton ID="lnkBtn" runat="server" href="addRefDU.aspx" OnClientClick="$(this).modal({width:440, height:335}).open(); return false;">Agregar</asp:LinkButton>
                </div>
            </td>
        </tr>
        <tr>
            <td class="style5" colspan="2">
                <div>
                    <asp:GridView ID="gViewDU" runat="server" AutoGenerateColumns="False" GridLines="None"
                        CssClass="mGrid" PagerStyle-CssClass="pgr">
                        <Columns>
                            <asp:BoundField HeaderText="USO" DataField="strTIPOLIC" />
                            <asp:BoundField HeaderText="APLICACIÓN" DataField="intSUBTIPO" />
                            <asp:BoundField HeaderText="DETALLE" DataField="strDESCRIPCION" />
                            <asp:TemplateField ShowHeader="False" HeaderText="OPCIONES" HeaderStyle-Width="140px"
                                ItemStyle-Width="140px" FooterStyle-Width="140px">
                                <ItemTemplate>
                                    <div class="div-lickEditar">
                                        <asp:LinkButton ID="lnkBtnEditar" runat="server" CommandName="lnkEdit" title="Editar">Editar</asp:LinkButton>
                                    </div>
                                    <div class="div-lickEliminar">
                                        <asp:LinkButton ID="lnkBtnEliminar" runat="server" CommandName="lnkDelete" title="Eliminar">Eliminar</asp:LinkButton>
                                    </div>
                                </ItemTemplate>
                                <FooterStyle Width="140px"></FooterStyle>
                                <HeaderStyle Width="140px"></HeaderStyle>
                                <ItemStyle Width="140px"></ItemStyle>
                            </asp:TemplateField>
                        </Columns>
                        <PagerStyle CssClass="pgr"></PagerStyle>
                    </asp:GridView>
                </div>
            </td>
        </tr>
    </table>
    <div class="buttom-conten">
        <div class=" buttom-left">
            <asp:Button ID="Button1" runat="server" Text="Atras" />
        </div>
        <div class=" buttom-right">
            <asp:Button ID="Btn_Seguir" runat="server" Text="Siguiente" />
        </div>
    </div>
    <div style="margin: 0 auto; width: 450px;">
        <asp:Label ID="lblMsjError" Visible="false" runat="server"></asp:Label>
        <asp:ValidationSummary ID="vlatorSummary" runat="server" CssClass="messbox" ValidationGroup="vlrPaso" />
    </div>
    <asp:Button ID="btn_load" runat="server" Text="load" CausesValidation="false"/>
    <div class="clear">
    </div>
</asp:Content>
