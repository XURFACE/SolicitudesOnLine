Imports MP.DW.BL
Imports System.Data
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL

Public Class wfrm_AddDocuments
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        guardarArchivos()

    End Sub
    Private Sub guardarArchivos()
        If FUAjaxApl.IsPosting Then
            Session("rutaApl") = clsUTL_AjaxFU.managePost(FUAjaxApl)
        End If

    End Sub
    Protected Sub btnOk_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOk.Click

        If Not IsNothing(Request.QueryString("idsol")) Then
            saveArchivo()
        End If

    End Sub
    Private Sub saveArchivo()
        Dim objBCAplicacion As New BC.clsBC_DOCUMENTOS_ADICIONALESTX
        Dim objBe As New BE.clsBE_DOCUMENTOS_ADICIONALES
        Dim idsol As Int64 = CType(Request.QueryString("idsol"), Int64)
        Dim strMsg As String = ""
        Dim guid As String = "Public"
        objBe.lngIDSOLICITUD = idsol
        If Not IsNothing(Session("rutaApl")) Then
            objBe.strRUTA_ARCHIVO = CStr(Session("rutaApl"))
            Session.Remove("rutaApl")
        End If

        objBe.strDESCRIPCION = txtAplDesc.Text
        objBCAplicacion.LstDOCUMENTOS_ADICIONALES.Add(objBe)
        objBCAplicacion.InsertarDOCUMENTOS_ADICIONALES()



        ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "cargarAplicacion();", True)


    End Sub
  End Class