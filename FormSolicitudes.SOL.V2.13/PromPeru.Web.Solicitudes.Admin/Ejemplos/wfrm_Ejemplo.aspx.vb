Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports MP.DW.UTL.seguridad
Imports Subgurim.Controles
Public Class wfrm_Ejemplo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not IsNothing(Request.QueryString("IdEjmp")) Then
                Dim objBC As New BC.clsBC_EJEMPLORO
                objBC.oBEEJEMPLO.intID = Request.QueryString("IdEjmp")
                objBC.LeerEJEMPLO()
                txtDesc.Text = CstrMP(objBC.oBEEJEMPLO.strDESCRIPCION)
                Dim itm As ListItem = ddltipoLic.Items.FindByText(objBC.oBEEJEMPLO.strTIPOLIC)
                If IsNothing(itm) Then ddltipoLic.SelectedIndex = 0 : ddltipoLic.SelectedIndex = ddltipoLic.Items.IndexOf(itm)
                rdbSI.Checked = objBC.oBEEJEMPLO.blnIND_ACTIVO
                rdbNO.Checked = Not objBC.oBEEJEMPLO.blnIND_ACTIVO
            End If
            trImg.Visible = IsNothing(Request.QueryString("IdEjmp"))
            btnUpdate.Visible = Not IsNothing(Request.QueryString("IdEjmp"))
            btnGuardar.Visible = IsNothing(Request.QueryString("IdEjmp"))
        End If

        guardarArchivos()

    End Sub
    Private Sub guardarArchivos()
       
        If FUAjaxEjm.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxEjm)
        End If

    End Sub
    Private Function guardarArchivosPaso(ByRef FUAjax As FileUploaderAJAX)
        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            If rutas.Count > 0 Then
                Return rutas(0).ToString
            End If
        End If
        Return ""
    End Function
    Private Sub saveArchivo()
        Dim objBCEjem As New BC.clsBC_EJEMPLOTX
        Dim objBe As New BE.clsBE_EJEMPLO
        Dim strMsg As String = ""
        Dim guid As String = "EJEMPLOS"

        ' objBe.strRUTA_ARCHIVO = FUAjaxEjm.FileName.ToString
        objBe.strDESCRIPCION = txtDesc.Text
        objBe.strTIPOLIC = ddltipoLic.SelectedItem.Text
        objBe.blnIND_ACTIVO = rdbSI.Checked
        Try
            DatosAuditoria(objBe, "", "")
            If IsNothing(Request.QueryString("IdEjmp")) Then
                'If crearCarpeta(ConfigurationManager.AppSettings("RutaSubida"), strMsg, guid) Then
                '    objBe.strRUTA_ARCHIVO = strMsg & FU_copiaEjm.FileName.ToString
                '    If FU_copiaEjm.HasFile Then
                '        FU_copiaEjm.SaveAs(objBe.strRUTA_ARCHIVO)
                '    End If
                'Else
                '    Throw New Exception(strMsg)
                'End If
                objBe.strRUTA_ARCHIVO = ConfigurationManager.AppSettings("rutaImagenEjemplo") & guardarArchivosPaso(FUAjaxEjm)
                objBCEjem.LstEJEMPLO.Add(objBe)
                objBCEjem.InsertarEJEMPLO()
            Else
                objBe.intID = Request.QueryString("IdEjmp")
                objBCEjem.LstEJEMPLO.Add(objBe)
                objBCEjem.ModificarEJEMPLO()
            End If
            ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "cargarAplicacion();", True)
        Catch ex As Exception
            lblMsg.Text = ex.Message
            lblMsg.Visible = True
        End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        saveArchivo()
    End Sub

    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        saveArchivo()
    End Sub
End Class