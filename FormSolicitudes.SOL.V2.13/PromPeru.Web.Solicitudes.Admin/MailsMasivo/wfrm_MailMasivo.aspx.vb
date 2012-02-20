Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_EnvioCorreo
Imports MP.DW.UTL.clsUTL_Helpers
Public Class wfrm_MailMasivo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAceptar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAceptar.Click
        Dim tot As Long = 0
        Dim Err As Long = 0
        Try
            Dim objemp As New BC.clsBC_EMPRESARO
            objemp.LeerListaEMPRESA()
            tot = objemp.LstEMPRESA.Count
            Dim strErrores As New StringBuilder
            For Each obj As BE.clsBE_EMPRESA In objemp.LstEMPRESA
                Try
                    SendSimpleMessage(txtTitulo.Text, obj.strEMAIL, "", txtTitulo.Text, txtSubTitulo.Text, txtMsg.Text, _
                                      ConfigurationManager.AppSettings("ServerSMTP"), ConfigurationManager.AppSettings("PortSMTP"))
                Catch ex As Exception
                    Err += 1
                    strErrores.Append(String.Format("<b>Error al enviar a la empresa: {0} detalle:</b> {1}\",
                                                    obj.strRAZONSOCIAL,
                                                    Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))))
                End Try
            Next
            If strErrores.Length > 0 Then
                Throw New Exception(strErrores.ToString)
            End If
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"\"}, StringSplitOptions.RemoveEmptyEntries))
            ltrMsg.Visible = True
        Finally
            lblmsgResumen.Text = String.Format("Se envió el mensaje satisfactoriamente a {0} de {1} entidades, los {2} errores se detallan líneas abajo", CstrMP(tot - Err), CstrMP(tot), CstrMP(Err))
            lblmsgResumen.Visible = True
        End Try
    End Sub
End Class