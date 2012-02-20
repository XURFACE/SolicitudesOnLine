
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL

Imports PromPeru.Configuration.Konstantes
Public Class uc_Login
    Inherits System.Web.UI.UserControl

    Public Property Redireccionar As String
        Set(ByVal value As String)
            ViewState("_Redireccionar_") = value
        End Set
        Get
            Return ViewState("_Redireccionar_")
        End Get
    End Property
    Public Property Redireccionar_Cancelar As String
        Set(ByVal value As String)
            ViewState("_Redireccionar_Cancelar_") = value
        End Set
        Get
            Return ViewState("_Redireccionar_Cancelar_")
        End Get
    End Property
    Protected Sub btnIngresar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btningresar.Click
        Dim mensaje As New StringBuilder
        Try
            Dim objBC_USUARIO As New BC.clsBC_CLIENT_USERRO
            objBC_USUARIO.oBECLIENT_USER.strLOGINUSR = txtlogin.Text
            objBC_USUARIO.LeerUSUARIOLogIn()
            If objBC_USUARIO.oBECLIENT_USER.lngID = 0 Then
                Throw New Exception("El usuario no existe")
            Else
                If Encripta(AlgoritmoDeEncriptacion.MD5, txtPwd.Text) = DesEncripta(objBC_USUARIO.oBECLIENT_USER.strPWDUSR) Then
                    Session(kstrNombreSession) = objBC_USUARIO.oBECLIENT_USER
                    Response.Redirect("../Client/main.aspx")
                Else
                    Throw New Exception("Contraseña incorrecta")
                End If
            End If
        Catch ex As Exception
            'mensaje.Append("<scrcip> function Agregar(){")
            'mensaje.Append("var incrus = $('#ctl00_ContentPlaceHolder1_uc_Login1_vldSmr');")
            'mensaje.Append("incrus.append('<li>")
            'mensaje.Append(ex.Message)
            'mensaje.Append("</li>');")
            'mensaje.Append("} Agregar();</scrcip>")
            mensaje.Append("<div class='messbox'><ul><li>")
            mensaje.Append(ex.Message)
            mensaje.Append("</li></ul></div>")
            lblMsg.Text = mensaje.ToString
            lblMsg.Visible = True

        End Try
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Response.Redirect("../index.aspx")
    End Sub

    Private Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            txtPwd.Attributes.Add("onKeyPress", "doClick('" + btningresar.ClientID + "',event)")
        End If
    End Sub
End Class