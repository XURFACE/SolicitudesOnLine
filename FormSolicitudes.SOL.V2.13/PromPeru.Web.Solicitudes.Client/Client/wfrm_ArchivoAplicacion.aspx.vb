Imports MP.DW.BL
Imports System.Data
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Public Class wfrm_ArchivoAplicacion
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
        Dim objBCAplicacion As New BC.clsBC_APLICACIONTX
        Dim objBe As New BE.clsBE_APLICACION
        Dim idsol As Int64 = CType(Request.QueryString("idsol"), Int64)
        Dim strMsg As String = ""
        Dim guid As String = "Public"
        objBe.lngIDSOLICITUD = idsol
        If Not IsNothing(Session("rutaApl")) Then
            objBe.strRUTA_IMAGEN = CStr(Session("rutaApl"))
            Session.Remove("rutaApl")
        End If

        objBe.strDECRIPCION = txtAplDesc.Text
        objBCAplicacion.LstAPLICACION.Add(objBe)
        objBCAplicacion.InsertarAPLICACION()
        'Try
        '    If crearCarpeta(ConfigurationManager.AppSettings("RutaSubida"), strMsg, guid) Then
        '        objBe.strRUTA_IMAGEN = strMsg & fu_apl.FileName.ToString

        '        Subirarchivo(fu_apl, objBe.strRUTA_IMAGEN)

        '    Else
        '        Throw New Exception(strMsg)
        '    End If



        'Catch ex As Exception

        'End Try


        ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "cargarAplicacion();", True)


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
End Class