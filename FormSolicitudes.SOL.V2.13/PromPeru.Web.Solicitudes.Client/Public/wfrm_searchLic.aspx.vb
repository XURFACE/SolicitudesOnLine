
Imports MP.DW.BL
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports System.IO

Public Class wfrm_searchLic
    Inherits System.Web.UI.Page
    Dim objBC As New BC.clsBC_SOLICITUDRO
    Dim data As DataTable
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            If Not IsNothing(Session("data")) Then
                lnkExportar.Visible = False
                Session.Remove("data")
            Else
                lnkExportar.Visible = False
            End If

        End If
    End Sub
    Private Sub cargarGrid()

        Dim lngtotalRows As Long
        Dim giro As String = uc_GiroSector.SelectecItem.ToString

        'If giro = "--MOSTRAR TODOS--" Then
        '    cargarTodos()
        '    Exit Sub
        'End If


        data = objBC.LeerListaToDTSOLICITUDES_SEARCH(CstrMP(Txt_RUC.Text), CstrMP(txt_razonsocial.Text), giro)

        Session("data") = data
        lnkExportar.Visible = CType(Session("data"), DataTable).Rows.Count > 0
        cargarGridView()
    End Sub
    Private Sub cargarTodos()
        data = objBC.LeerSearchToDTSOLICITUDCriterLst()
        Session("data") = data
        lnkExportar.Visible = CType(Session("data"), DataTable).Rows.Count > 0
        cargarGridView()
    End Sub

    'Protected Sub btn_Todos_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_Todos.Click
    '    cargarTodos()
    'End Sub

    Protected Sub Btn_buscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Btn_buscar.Click
        cargarGrid()
    End Sub
    Private Sub cargarGridView()
        grvSolicitudes.DataSource = CType(Session("data"), DataTable)
        grvSolicitudes.DataBind()
    End Sub
    Private Sub exportarXls()
        If IsNothing(Session("data")) Then
            Exit Sub
        End If
        Dim sb As StringBuilder = New StringBuilder()
        Dim sw As StringWriter = New StringWriter(sb)
        Dim htw As HtmlTextWriter = New HtmlTextWriter(sw)
        Dim pagina As Page = New Page
        Dim grilla As New GridView

        grilla.EnableViewState = False
        grilla.AllowPaging = False
        grilla.DataSource = CType(Session("data"), DataTable)
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

    Protected Sub lnkExportar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lnkExportar.Click
        exportarXls()
    End Sub

    Protected Sub grvSolicitudes_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles grvSolicitudes.PageIndexChanging
        grvSolicitudes.PageIndex = e.NewPageIndex
        cargarGridView()
    End Sub
End Class