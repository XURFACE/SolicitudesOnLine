Imports MP.DW.BL
Imports PromPeru.Configuration
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports Subgurim.Controles
Public Class wfrm_AddMarca
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        guardarArchivos()
    End Sub
    Private Sub guardarArchivos()

        If FUAjaxIndecopi.IsPosting Then
            clsUTL_AjaxFU.managePost(FUAjaxIndecopi)
        End If
    End Sub
    Private Function guardarArchivosPaso(ByRef FUAjax As FileUploaderAJAX) As String
        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            If rutas.Count > 0 Then
                Return rutas(0).ToString
            End If
        End If
        Return ""
    End Function
    Protected Sub btn_add_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_add.Click

        Dim lstObjProd As New List(Of BE.clsBE_PRODUCTO)
        Dim objProducto As New BE.clsBE_PRODUCTO
        Dim strMsg As String = ""
        Dim guid As String = "public"

        If Not IsNothing(Session("cllObjProductosMarca")) Then
            lstObjProd = CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))
        Else
            Session("cllObjProductosMarca") = lstObjProd
        End If
        lblMessege.Visible = False

        For Each objBe As BE.clsBE_PRODUCTO In lstObjProd
            If objBe.strMARCA = txtMarca.Text Then
                lblMessege.Text = "Marca ya ingresada"
                lblMessege.Visible = True
                Exit Sub
            End If
        Next
        objProducto.strMARCA = txtMarca.Text
        objProducto.strRUTAREGISTROINDECOPI = guardarArchivosPaso(FUAjaxIndecopi)
        If objProducto.strRUTAREGISTROINDECOPI = "" Then
            lblMessege.Text = "Agregue una referencia"
            lblMessege.Visible = True
            Exit Sub
        End If

        lstObjProd.Add(objProducto)

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