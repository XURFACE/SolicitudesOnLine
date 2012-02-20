Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL
Imports PromPeru.Configuration
Public Class uc_changePwd
    Inherits System.Web.UI.UserControl

    Public WriteOnly Property Login As String
        Set(ByVal value As String)
            hfdldLogin.Value = value
        End Set
    End Property
    Public WriteOnly Property Newp As String
        Set(ByVal value As String)
            If Not String.IsNullOrEmpty(value) Then hfdldNew.Value = value
        End Set
    End Property
    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Try
            Dim objBC_USUARIO As New BC.clsBC_CLIENT_USERRO
            objBC_USUARIO.oBECLIENT_USER.strLOGINUSR = hfdldLogin.Value
            objBC_USUARIO.LeerUSUARIOLogIn()
            If objBC_USUARIO.oBECLIENT_USER.lngID = 0 Then
                Throw New Exception("El usuario no existe")
            Else
                'If String.IsNullOrEmpty(hfdldNew.Value) Then
                If Encripta(AlgoritmoDeEncriptacion.MD5, txtPwdact.Text) = DesEncripta(objBC_USUARIO.oBECLIENT_USER.strPWDUSR) Then
                    Dim objBC_USUARIOTX As New BC.clsBC_CLIENT_USERTX

                    objBC_USUARIOTX.oBECLIENT_USER = objBC_USUARIO.oBECLIENT_USER
                    objBC_USUARIOTX.oBECLIENT_USER.strPWDUSR = Encripta(Encripta(AlgoritmoDeEncriptacion.MD5, txtPwd.Text))
                    objBC_USUARIOTX.LstCLIENT_USER.Add(objBC_USUARIOTX.oBECLIENT_USER)
                    objBC_USUARIOTX.ModificarPWDCLIENT_USER()
                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "parent.$.modal().closePopup();", True)
                Else
                    Throw New Exception("Contraseña actual incorrecta")
                End If
            End If
        Catch ex As Exception
            ltrMsg.Text = Formatomsgerr(ex.Message)
            ltrMsg.Visible = True
        End Try
    End Sub

End Class