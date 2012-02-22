Imports MP.DW.BL.BC
Imports System.IO

Public Class wfrm_solicitudes1

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Session.Remove("data")
            lnkExportar.Visible = False
        End If
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        cargarGrid()
    End Sub
    Private Function buscar() As DataTable
        Dim objSOLICITUDRO As New clsBC_SOLICITUDRO
        Dim tipoEmpresa As String = ""
        Dim razonSocial As String = ""
        Dim tipolic(2) As String
        Dim institucion As String = ""
        Dim producto As String = ""
        Dim evento As String = ""

        Dim culture As String = "en-US"
        Dim fechDesde As String = "01/01/1980"
        Dim fechHasta As String = "10/10/2020" '"12/31/2020 23:59:29 999"
        Dim fechaAproDesde As Date = Date.Parse(fechDesde, Globalization.CultureInfo.CreateSpecificCulture(culture))  'CDate(fechDesde)
        Dim fechaAproHasta As Date = Date.Parse(fechHasta, Globalization.CultureInfo.CreateSpecificCulture(culture))
        Dim fechaRegDesde As Date = Date.Parse(fechDesde, Globalization.CultureInfo.CreateSpecificCulture(culture))
        Dim fechaRegHasta As Date = Date.Parse(fechHasta, Globalization.CultureInfo.CreateSpecificCulture(culture))
        
        If rbPerJur.Checked Then
            tipoEmpresa = "PERSONA JURÍDICA"
        ElseIf rbPerNat.Checked Then
            tipoEmpresa = "PERSONA JURÍDICA EXTRANJERA"
        ElseIf rbPerNatNeg.Checked Then
            tipoEmpresa = "PERSONA NATURAL CON NEGOCIO"
        ElseIf rbPerOrEst.Checked Then
            tipoEmpresa = "ORGANISMO ESTATAL"
        End If

        razonSocial = txtRznSocial.Text

        If chckInst.Checked Then
            institucion = "INSTITUCIONAL"
            tipolic(0) = institucion
        End If
        If chckProd.Checked Then
            producto = "PRODUCTO"
            tipolic(1) = producto
        End If
        If chckEvent.Checked Then
            evento = "EVENTO"
            tipolic(2) = evento
        End If
        If (institucion + producto + evento).Length > 0 Then
            For i As UShort = 0 To tipolic.Length - 1
                If String.IsNullOrEmpty(tipolic(i)) Then
                    tipolic(i) = "_"
                End If
            Next
        End If
        If chkFechAprovacion.Checked Then
            If txtFechaAprovacionDesde.Text.Length > 0 Then
                fechaAproDesde = Date.Parse(txtFechaAprovacionDesde.Text, Globalization.CultureInfo.CreateSpecificCulture(culture))
            End If
            If txtFechaAprovacionHasta.Text.Length > 0 Then
                fechaAproHasta = Date.Parse(txtFechaAprovacionHasta.Text, Globalization.CultureInfo.CreateSpecificCulture(culture))
            End If

        End If

        If chkFechRegistro.Checked Then
            If txtFechaRegistroDesde.Text.Length > 0 Then
                fechaRegDesde = Date.Parse(txtFechaRegistroDesde.Text, Globalization.CultureInfo.CreateSpecificCulture(culture))
            End If
            If txtFechaRegistroHasta.Text.Length > 0 Then
                fechaRegHasta = Date.Parse(txtFechaRegistroHasta.Text, Globalization.CultureInfo.CreateSpecificCulture(culture))
            End If

        End If

        'Return objSOLICITUDRO.LeerSearchToDTSOLICITUDCriter(
        '    tipoEmpresa, razonSocial, tipolic(0), tipolic(1), tipolic(2),
        '    txtRUC.Text, IIf(dllCamEst.SelectedIndex = 0, "",
        '    dllCamEst.SelectedItem.Text))

        Return objSOLICITUDRO.LeerSearchToDTSOLICITUDCriterDateRange(
           tipoEmpresa, razonSocial, tipolic(0), tipolic(1), tipolic(2),
           txtRUC.Text, IIf(dllCamEst.SelectedIndex = 0, "",
           dllCamEst.SelectedItem.Text), fechaRegDesde, fechaRegHasta,
           fechaAproDesde, fechaAproHasta)
    End Function
    Private Sub cargarGrid(Optional ByVal dt As DataTable = Nothing)
        If IsNothing(dt) Then
            dt = buscar()
            Session("data") = dt
        End If
        lnkExportar.Visible = dt.Rows.Count > 0
        gViewDU.DataSource = dt
        gViewDU.DataBind()
    End Sub

    Protected Sub lnkExportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkExportar.Click
        exportarXls(buscar)
    End Sub
    Private Sub exportarXls(ByVal dt As DataTable)
        Dim sb As StringBuilder = New StringBuilder()
        Dim sw As StringWriter = New StringWriter(sb)
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim grilla As New GridView

        grilla.EnableViewState = False
        grilla.AllowPaging = False
        grilla.DataSource = dt
        grilla.DataBind()
        Dim form = New HtmlForm
        pagina.EnableEventValidation = False
        pagina.DesignerInitialize()
        pagina.Controls.Add(form)
        form.Controls.Add(grilla)
        pagina.RenderControl(htw)
        Response.Clear() 'Limpia la respuesta
        Response.Buffer = True
        Response.ContentType = "application/vnd.ms-excel" 'indica que el archivo será un EXCEL
        Response.AddHeader("Content-Disposition", "attachment;filename=data_" & DateTime.Now.ToString("ddMMyyyy") & ".xls") 'Indica el nombre del archivo
        Response.Charset = "UTF-8"
        Response.ContentEncoding = Encoding.Default
        Response.Write(sb.ToString())
        Response.End()
    End Sub

    Protected Sub gViewDU_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles gViewDU.PageIndexChanging
        gViewDU.PageIndex = e.NewPageIndex
        cargarGrid(Session("data"))
    End Sub
End Class

