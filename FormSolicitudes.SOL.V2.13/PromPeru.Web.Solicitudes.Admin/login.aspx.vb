Imports MP.DW.BL
Imports MP.DW.UTL.seguridad
Imports PromPeru.Configuration.Konstantes
Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnIngresar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnIngresar.Click
        lblMsg.Text = ""
        Try
            Dim objBC_USUARIO As New BC.clsBC_USUARIORO

            objBC_USUARIO.oBEUSUARIO.strLOGIN = txtLogin.Text
            objBC_USUARIO.LeerUSUARIOLogIn()
            If objBC_USUARIO.oBEUSUARIO.intID = 0 Then
                Throw New Exception("El usuario no existe")
            Else
                If Encripta(AlgoritmoDeEncriptacion.MD5, txtPwd.Text) = DesEncripta(objBC_USUARIO.oBEUSUARIO.strPASSWORD) Then
                    Session(kstrNombreSessionAdm) = objBC_USUARIO.oBEUSUARIO
                    Response.Redirect("Users/wfrm_users.aspx")
                Else
                    Throw New Exception("Contraseña incorrecta")
                End If
            End If
        Catch ex As Exception
            lblMsg.CssClass = "msgerror"
            lblMsg.Text = ex.Message + "--"
            lblMsg.Visible = True
        End Try
    End Sub
End Class