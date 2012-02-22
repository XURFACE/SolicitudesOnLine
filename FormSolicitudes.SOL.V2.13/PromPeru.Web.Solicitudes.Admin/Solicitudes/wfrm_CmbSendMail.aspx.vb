Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_EnvioCorreo
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration
Public Class wfrm_CmbSendMail
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim id As Int64
        Dim idSol As Int64
        ' If Not IsNothing(Request.QueryString("id")) Then
        'id = CType(Request.QueryString("id"), Int64)
        'End If

        If Not IsNothing(Request.QueryString("idSol")) Then
            idSol = CType(Request.QueryString("idSol"), Int64)
        End If

        Dim objDocs As New BC.clsBC_DOCUMENTOS_ADICIONALESRO
        grvarcAdic.DataSource = objDocs.LeerListaToDTDOCUMENTOS_ADICIONALES(idSol)
        grvarcAdic.DataBind()
    End Sub

    Protected Sub grvarcAdic_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grvarcAdic.SelectedIndexChanged

    End Sub

    Protected Sub btnSolicitar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSolicitar.Click
        Try
            Dim strbl As New Text.StringBuilder
            Dim strBody As String = "El evaluador ha considerado que para su solicitud sea aprobada se agreguen siguientes archivos adicionales:<br><ul>{0}</ul><br>" & _
                                    "Para ello ingrese al sistema de Solicitudes En línea desde http://peru.info"
            For Each dr As GridViewRow In grvarcAdic.Rows
                Dim hylnk As HyperLink = dr.FindControl("lnkRF")
                If Not IsNothing(hylnk) Then
                    If Not String.IsNullOrEmpty(hylnk.NavigateUrl.Trim.Replace("&nbsp;", "")) Then
                        strbl.Append("<li>" & dr.Cells(0).Text & "</li>")
                    End If
                End If
            Next
            SendSimpleMessage("Marca país - Archivos adicionales", txtAreaDetalle.Text, "", "Se requiere archivos adicionales", "&nbsp;",
                              String.Format(strBody, strbl.ToString), _
                              ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))

        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        End Try
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub
End Class
