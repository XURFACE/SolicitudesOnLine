Imports Subgurim.Controles
Namespace MP.DW.UTL
    Public Class clsUTL_AjaxFU
        Public Shared Function managePost(ByVal FUAjax As FileUploaderAJAX) As String
            Dim pf As HttpPostedFileAJAX = FUAjax.PostedFile ' FUAjaxRuc.PostedFile

            Dim ext As String = System.IO.Path.GetExtension(pf.FileName)


            'If pf.Type = HttpPostedFileAJAX.fileType.image Or pf.Type = HttpPostedFileAJAX.fileType.office Then
            If ext.ToUpper().Equals(".DOC") Or ext.ToUpper().Equals(".DOCX") Or ext.ToUpper().Equals(".JPG") Or ext.ToUpper().Equals(".JPEG") Or ext.ToUpper().Equals(".PNG") Or ext.ToUpper().Equals(".GIF") Or ext.ToUpper().Equals(".PDF") Then
                ' pf.responseMessage_Uploaded = "<p style='color:red; float:left;'>" + pf.FileName + "</p>"
                FUAjax.SaveAs("ArchivosAdjuntos/", pf.FileName)

                Return pf.FileName_SavedAs
            End If
            Return ""
        End Function

        Public Shared Function historialFUAjax(ByVal FUAjax As FileUploaderAJAX) As List(Of String)
            If IsNothing(FUAjax.History) Then
                Return Nothing
            End If
            Dim rutas As New List(Of String)
            For Each file As HttpPostedFileAJAX In FUAjax.History
                If Not file.Deleted Then
                    rutas.Add(file.FileName_SavedAs)
                End If
            Next
            Return rutas
        End Function
    End Class
   
End Namespace

