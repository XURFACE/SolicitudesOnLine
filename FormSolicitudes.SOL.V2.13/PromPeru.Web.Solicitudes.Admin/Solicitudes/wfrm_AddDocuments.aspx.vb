Imports MP.DW.BL
Imports System.Data
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Public Class wfrm_AddDocuments1
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
        Dim guid As String = "Admin"
        objBe.lngIDSOLICITUD = idsol
        objBe.strDESCRIPCION = txtAplDesc.Text
        objBCAplicacion.LstDOCUMENTOS_ADICIONALES.Add(objBe)
        objBCAplicacion.InsertarDOCUMENTOS_ADICIONALES()
        ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "cargarAplicacion();", True)
    End Sub
End Class