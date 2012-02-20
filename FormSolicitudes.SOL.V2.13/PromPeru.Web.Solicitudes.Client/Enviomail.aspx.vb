Imports System.Net.Mail
Imports System.Data
Imports System.Data.OracleClient

Public Class Envio_de_mail
    Inherits System.Web.UI.Page

    Public Sub EnvioEmail()

        Dim msg As New System.Net.Mail.MailMessage("syslacs@hotmail.com", "ivan.tasso@xurface.com", "asunto", "prueba")



        'Cliente google api
        '------------------------------
        Dim client As New SmtpClient()
        client.Port = 25

        client.Host = "cashub1.promperu.gob.pe"

        '-------------------------------
        ''''''''''''''''
        'SMTP

        ''''''''''''''

        client.Send(msg)


    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn1.Click

        MP.DW.UTL.clsUTL_EnvioCorreo.SendSimpleMessage("Prueba1", _
                                                       "ivan.tasso@xurface.com;ivan.tasso@gmail.com,ivantc_fis@hotmail.com", _
                                                       "ivan.tasso@gmail.com", _
                                                       "Solicitud de uso de la Marca País Perú", _
                                                       "Subtitulo", _
                                                       "Probando metodo SendSimpleMessage()", _
                                                       ConfigurationManager.AppSettings("ServerSMTP"), _
                                                       ConfigurationManager.AppSettings("PortSMTP"))

    End Sub

    Protected Sub btn2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn2.Click
        Dim objUTLEnvioEmail As New MP.DW.UTL.clsUTL_EnvioCorreo
        objUTLEnvioEmail.EnvioEmail("ivan.tasso@xurface.com", "555555", "Prueba EnvioEmail()")
    End Sub

    Private Sub Envio_de_mail_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'EnvioEmail()
        Label1.Text = ConfigurationManager.AppSettings("ServerSMTP") & "<br>" & _
                      ConfigurationManager.AppSettings("PortSMTP") & "<br>" & _
                      ConfigurationManager.AppSettings("UserMailSMTP")
    End Sub
    Private strConexion As String = ConfigurationManager.ConnectionStrings("oraRec").ConnectionString

    Protected Sub enviarCorreo(ByVal p_to As String, ByVal p_bcc As String, ByVal p_from As String, ByVal p_subject As String, ByVal p_html As String)
        Using con As New OracleConnection(strConexion)
            con.Open()
            Dim cmd As New OracleCommand("html_email", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("p_to", OracleType.VarChar).Value = p_to
            cmd.Parameters.Add("p_bcc", OracleType.VarChar).Value = p_bcc
            cmd.Parameters.Add("p_from", OracleType.VarChar).Value = p_from
            cmd.Parameters.Add("p_subject", OracleType.VarChar).Value = p_subject
            cmd.Parameters.Add("p_html", OracleType.VarChar).Value = p_html
            cmd.ExecuteNonQuery()
        End Using
    End Sub
    Protected Sub Button1_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        enviarCorreo(ConfigurationManager.AppSettings("mailpromperu1"), "ivan.tasso@gmail.com", "marcapais@promperu.com.pe", "Prueba oracle", "Cuerpo<br>algo")
        Label1.Text = "correo enviado a: " & ConfigurationManager.AppSettings("mailpromperu1") + _
                      "Con copia a:" & ConfigurationManager.AppSettings("mailpromperu2")
    End Sub
End Class