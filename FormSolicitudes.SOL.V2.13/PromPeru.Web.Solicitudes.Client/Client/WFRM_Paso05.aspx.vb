Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports Subgurim.Controles

Public Class WFRM_Paso05
    Inherits System.Web.UI.Page

    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Dim pasos As New Rastro
            Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
            Dim guid As String = "public" 'System.Guid.NewGuid.ToString()
            Dim cllobjRefEmpresa As New List(Of BE.clsBE_REF_EMPRESA)
            Dim objRefEmpresa As New BE.clsBE_REF_EMPRESA
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
            objSolicitudTotal.BE_EMPRESA.strDET_GIRO = txtDetGiro.Text        
            objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL = txtProgRespSocial.Text.Replace("__", "")
            objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL = txtProgSocDet.Text.Replace("__", "")
            
            objSolicitudTotal.BE_EMPRESA.strCOMPROMISO = txtCompro.Text
            objSolicitudTotal.BE_EMPRESA.strREFERENCIAS = txtReferencias.Text

            guardarArchivosPasoRefEmp(FUAjaxREMP)

            If objSolicitudTotal.LIST_BE_REF_EMPRESA.Count < 2 Then
                lblMsjError.Text = "<div class='messbox'><ul><li>Agregar minimo dos referencias, si ya los seleccionó presione seguir</li></ul></div>"
                Exit Sub
            End If
            Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
            pasos.PASOS.Push(5)
        End If


        If Not IsNothing(Session("SessionProd")) Then
            Response.Redirect("WFRM_Paso06.aspx")
        ElseIf Not IsNothing(Session("SessionEvent")) Then
            Response.Redirect("WFRM_Paso07.aspx")
        Else
            Response.Redirect("WFRM_Paso08.aspx")
        End If
    End Sub

    Private Sub Subirarchivo(ByVal xfup As FileUpload, ByVal xstrRuta As String)
        Try
            If xfup.HasFile Then
                xfup.SaveAs(xstrRuta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Protected Sub btn_atras_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_atras.Click
        Dim pasos As New Rastro
        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx")
        End If
        Response.Redirect(page)
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If
        If Not IsPostBack Then
            ShowResponsabilidadSocia(False)
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
                objSolicitudTotal = CType(Session("SessionTotal"), BE.clsBE_SOLICITUDTOTAL)
                txtDetGiro.Text = objSolicitudTotal.BE_EMPRESA.strDET_GIRO
                txtCompro.Text = objSolicitudTotal.BE_EMPRESA.strCOMPROMISO
                txtReferencias.Text = objSolicitudTotal.BE_EMPRESA.strREFERENCIAS
                Dim item As Int32 = 0
                FUAjaxCons.Visible = objSolicitudTotal.tipo_persona = tipoPersona.juridico_Extrangero
                lblConsulado.Visible = objSolicitudTotal.tipo_persona = tipoPersona.juridico_Extrangero
                If objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL = "" Or objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL = "" Then
                    txtProgRespSocial.Text = ""
                    txtProgSocDet.Text = ""
                    rbtn_no.Checked = True
                Else
                    txtProgRespSocial.Text = objSolicitudTotal.BE_EMPRESA.strNOMBREPROGRAMASOCIAL
                    txtProgSocDet.Text = objSolicitudTotal.BE_EMPRESA.strDET_PROGRAMASOCIAL
                    rbtn_si.Checked = True
                End If

                grvFiles.DataSource = objSolicitudTotal.LIST_BE_REF_EMPRESA
                grvFiles.DataBind()
            End If
            vlsmrPaso.Enabled = True
        End If
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            guardarArchivos()
        End If
    End Sub
    Private Sub guardarArchivos()
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        If FUAjaxREMP.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxREMP)
        End If
        If FUAjaxCons.IsPosting Then
            objSolTtl.BE_SOLICITUD_INST.strREFCONSULADO = clsUTL_AjaxFU.managePost(FUAjaxCons)
        End If
    End Sub
    Private Sub guardarArchivosPasoRefEmp(ByRef FUAjax As FileUploaderAJAX)
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            For Each ruta As String In rutas
                Dim objRefEmp As New BE.clsBE_REF_EMPRESA
                objRefEmp.strRUTA_REF = ruta
                objSolTtl.LIST_BE_REF_EMPRESA.Add(objRefEmp)
            Next
        End If
    End Sub
    Protected Sub grvFiles_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grvFiles.RowCommand
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        Dim listEmpresaRef As New List(Of BE.clsBE_REF_EMPRESA)

        Dim strComand As String = e.CommandName
        Dim index As Int32 = CInt(e.CommandSource.parent.parent.rowindex)

        If strComand = "Eliminar" Then
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                listEmpresaRef = objSolicitudTotal.LIST_BE_REF_EMPRESA
                listEmpresaRef.RemoveAt(index)
                objSolicitudTotal.LIST_BE_REF_EMPRESA = listEmpresaRef
                Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
                grvFiles.DataSource = listEmpresaRef
                grvFiles.DataBind()
            End If
        End If
    End Sub
    Protected Sub grvFiles_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvFiles.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lnk As HyperLink = e.Row.Cells(0).FindControl("lnkRF")
            lnk.Text = nombreLink(lnk.Text)
        End If
    End Sub
    Private Function nombreLink(ByVal ruta As String) As String
        Dim link() As String
        If ruta <> "" Then
            link = ruta.Split("/")
            Return link(link.Length - 1)
        End If
        Return ""
    End Function
    Private Sub ShowResponsabilidadSocia(ByVal xblnShow As Boolean)
        NomprogSoc.Visible = xblnShow
        rotDetprogSoc.Visible = xblnShow
        DetprogSoc.Visible = xblnShow
        rfv1.Enabled = xblnShow
        rfv2.Enabled = xblnShow

    End Sub
    Protected Sub rbtn_si_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtn_si.CheckedChanged
        ShowResponsabilidadSocia(sender.Checked)
        txtProgRespSocial.Focus()
    End Sub

    Protected Sub rbtn_no_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles rbtn_no.CheckedChanged
        ShowResponsabilidadSocia(Not sender.Checked)
    End Sub
End Class