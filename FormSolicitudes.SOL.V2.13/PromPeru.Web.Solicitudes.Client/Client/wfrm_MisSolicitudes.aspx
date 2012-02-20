<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/MasterPages/ClientMasterPage.Master"
    CodeBehind="wfrm_MisSolicitudes.aspx.vb" Inherits="PromPeru.Web.Solicitudes.Client.wfrm_MisSolicitudes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="contenet-form" style="padding-top: 31px;">
        <h6>
            Solicitudes Ingresadas</h6>
    </div>
    <br />
    <div style="width: 95%; margin: 0 auto;">
        <asp:GridView ID="gViewSol" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            CssClass="mGrid" GridLines="None" PagerStyle-CssClass="pgr">
            <Columns>
                <asp:BoundField DataField="RAZONSOCIAL" HeaderText="Empresa" />
                <asp:BoundField DataField="NUMLIC" HeaderText="Número de Licencia">
                    <ItemStyle Font-Size="7pt" />
                </asp:BoundField>
                <asp:BoundField DataField="ENDDATE" HeaderText="Fecha de Venc." DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="TIPOLIC" HeaderText="USO">
                    <ItemStyle Font-Size="8pt" />
                </asp:BoundField>
                <asp:BoundField DataField="STSSOL" HeaderText="Estado" />
                <asp:BoundField DataField="RENOVACION" HeaderText="Estado" Visible="false"/>
                <asp:BoundField DataField="NOMBREPROGRAMASOCIAL" HeaderText="Responsabilidad Social" />
                <asp:TemplateField HeaderText="Opciones">
                    <ItemTemplate>
                        <div class="div-lickDetalle">
                            <a href='wfrm_DetalleSolicitud.aspx?idsol=<%#Eval("IDSOL")%>' style="font-size: 10px;
                                height: 15px" title="Detalle">Detalle
                                <asp:LinkButton ID="lnkRen" runat="server"></asp:LinkButton>
                            </a>
                        </div>
                        <div class="div-renovar">
                            <%# IIf(Eval("RENOVACION").ToString.Trim().ToUpper().Equals("0"), IIf(Eval("STSSOL").ToString.Trim().ToUpper().Equals("APROBADO"), "<a href='WFRM_Paso03.aspx?tipo=" + Eval("TIPO_EMPRESA").ToString + "&id=" + Eval("IDEMPRESA").ToString + "&renov=0&idsol=" + Eval("IDSOL").ToString + "'style='font-size:10px; height:12px'>Renovar</a>", ""), IIf(Eval("STSSOL").ToString.Trim().ToUpper().Equals("APROBADO"), "<a href='WFRM_Paso01.aspx?tipo=" + Eval("TIPO_EMPRESA").ToString + "&id=" + Eval("IDEMPRESA").ToString + "&idsol=" + Eval("IDSOL").ToString + "'style='font-size:10px; height:12px'>Renovar</a>", ""))%>
                        </div>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <PagerStyle CssClass="pgr" />
        </asp:GridView>
    </div>
    <br />
</asp:Content>
