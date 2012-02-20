Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration
Imports MP.DW.UTL.seguridad
Public Class wfrm_NewPassword
    Inherits System.Web.UI.Page

    Private Sub Confirmar(ByVal xstrCodValidacion As String, ByRef xstrpwd As String, ByRef strMail As String)
        xstrpwd = MP.DW.UTL.clsUTL_Helpers.GenerateRandomCode(New Random)
        Try
            If IsNothing(Request.QueryString("cod")) Then
                Throw New Exception("Entró a un enlace inválido")
            End If
            Dim objbcRO As New BC.clsBC_CLIENT_USERRO
            objbcRO.oBECLIENT_USER.strLOGINUSR = DesEncripta(Request.QueryString("cod"))
            objbcRO.LeerUSUARIOLogIn()
            strMail = objbcRO.oBECLIENT_USER.strMAILUSR
            If objbcRO.oBECLIENT_USER.strCODVERIFICACION = xstrCodValidacion Then
                Dim objBEuser As New BE.clsBE_CLIENT_USER
                objBEuser = objbcRO.oBECLIENT_USER
                DatosAuditoria(objBEuser, Me.ToString.Substring(4), "")
                Dim objbcTX As New BC.clsBC_CLIENT_USERTX
                objBEuser.intESTADOUSR = 1
                objBEuser.strPWDUSR = Encripta(Encripta(AlgoritmoDeEncriptacion.MD5, xstrpwd))
                objbcTX.LstCLIENT_USER.Add(objBEuser)
                objbcTX.ModificarCLIENT_USER()
                Session(Konstantes.kstrNombreSession) = objBEuser
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Protected Sub btnConfirmar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirmar.Click
        Try
            Dim strpdw, strMail As String

            Confirmar(txtValidacion.Text, strpdw, strMail)
            Dim strmsgBody = String.Format("Se cambió la contraseña satisfactoriamente, su nueva contraseña asignada es: {0}, se le recomienda cambiarla al ingresar.", _
                                            strpdw, strMail)
            Dim objUTLEnvioEmail As New MP.DW.UTL.clsUTL_EnvioCorreo
            objUTLEnvioEmail.EnvioEmail(strMail, "", strmsgBody)
            Throw New Exception("Confirmación correcta, se te envió tu nueva contraseña, se recomienda la cambies al entrar")
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message.Split(New Char() {"/"}, StringSplitOptions.RemoveEmptyEntries))
        End Try
    End Sub

    Private Sub wfrm_NewPassword_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        btnConfirmar.Visible = Not IsNothing(Request.QueryString("cod"))
    End Sub
End Class