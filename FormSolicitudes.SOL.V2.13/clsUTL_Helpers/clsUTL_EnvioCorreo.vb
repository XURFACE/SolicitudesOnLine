Imports System
Imports System.Collections
Imports System.Net
Imports System.Net.Mail
Imports System.Net.Mime
Imports System.Configuration
Imports MP.DW.UTL.seguridad
Imports System.Text
Imports System.Data.OracleClient

Namespace MP.DW.UTL
    Public Class clsUTL_EnvioCorreo
        Public Shared Sub enviarCorreobyOracle(ByVal p_to As String, ByVal p_bcc As String, ByVal p_from As String, ByVal p_subject As String, ByVal p_html As String, ByVal xstrConexion As String)
            Using con As New OracleConnection(xstrConexion)
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
        Public Sub EnvioEmail(ByVal correo As String, ByVal codVerficacion As String, _
                              Optional ByVal xstrMsg As String = "", Optional ByVal xstrSubject As String = "")
            Try

                Dim userName As String = System.Configuration.ConfigurationManager.AppSettings("UserName")
                Dim userMail As String = System.Configuration.ConfigurationManager.AppSettings("UserMail")
                Dim strsubject As String = "Correo de verificación de registro a Marca Perú"

                If xstrSubject.Length > 0 Then strsubject = xstrSubject
                If xstrMsg = "" Then
                    xstrMsg = String.Concat("Su Código de Verificación es: ", codVerficacion)
                End If


                If System.Configuration.ConfigurationManager.AppSettings("SendByOracle") = 1 Then
                    Dim strMegErr As New StringBuilder
                    correo = correo.Replace(";", ",")
                    For Each strCorreo As String In correo.Split(New Char() {","}, StringSplitOptions.RemoveEmptyEntries)
                        Try
                            enviarCorreobyOracle(strCorreo, _
                                                 System.Configuration.ConfigurationManager.AppSettings("CCMail"), _
                                                 userMail, strsubject, xstrMsg, _
                                                 System.Configuration.ConfigurationManager.ConnectionStrings("oraRec").ConnectionString)
                        Catch ex As Exception
                            strMegErr.Append("No se pudo enviar el mail a " & strCorreo & " : " & ex.Message & "/")
                        End Try
                    Next
                    If strMegErr.Length > 0 Then
                        Throw New Exception(strMegErr.ToString)
                    End If
                Else
                    ''''''''''''''''''''''''''''ENVIO SMTP''''''''''''''''''''''''''''''''''''
                    Dim password As String = System.Configuration.ConfigurationManager.AppSettings("UserMailPass")
                    Dim lstrServer As String = System.Configuration.ConfigurationManager.AppSettings("ServerSMTP")
                    Dim lintPort As String = System.Configuration.ConfigurationManager.AppSettings("PortSMTP")
                    Dim lobjClient As SmtpClient = New SmtpClient(lstrServer, lintPort)
                    lobjClient.DeliveryMethod = SmtpDeliveryMethod.Network
                    Dim msg As New System.Net.Mail.MailMessage()
                    msg.To.Add(correo)
                    msg.From = New System.Net.Mail.MailAddress(userMail, userName, System.Text.Encoding.UTF8)
                    msg.Subject = strsubject
                    msg.SubjectEncoding = System.Text.Encoding.UTF8
                    msg.Body = xstrMsg
                    msg.BodyEncoding = System.Text.Encoding.UTF8
                    msg.IsBodyHtml = False
                    lobjClient.Credentials = New System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings("UserMailSMTP"), _
                                                                              System.Configuration.ConfigurationManager.AppSettings("UserMailPass"))
                    ''''''''''''''
                    lobjClient.Send(msg)
                End If
            Catch ex As System.Net.Mail.SmtpException
                Throw ex
            End Try

        End Sub
        

        Public Shared Function SendSimpleMessage(ByVal subject As String, ByVal correoTO As String, ByVal correoCC As String, _
                                                 ByRef title As String, ByVal subtitle As String, ByVal message As String, _
                                                 ByVal lstrServer As String, ByVal lintPort As String) As String()
            Dim strResult(2) As String
            Dim userName As String = System.Configuration.ConfigurationManager.AppSettings("UserName")
            'Dim userMail As String = System.Configuration.ConfigurationManager.AppSettings("UserMail")
            Dim userMail As String = System.Configuration.ConfigurationManager.AppSettings("UserMailSMTP")
            Dim password As String = System.Configuration.ConfigurationManager.AppSettings("UserMailPass")
            Dim pathlogo As String = System.Configuration.ConfigurationManager.AppSettings("MailHeaderLogo")
            '
            ''''''''''''''
            Dim mail As New MailMessage()
            Try
                Dim htmlBody As String = MakeSimpleMessage(title, subtitle, message)
                If System.Configuration.ConfigurationManager.AppSettings("SendByOracle") = 1 Then
                    Dim strMegErr As New StringBuilder
                    If Not String.IsNullOrEmpty(correoTO) Then
                        correoTO = correoTO.Replace(";", ",")
                    Else
                        Throw New Exception("No se tiene dirección de correo del remitente")
                    End If

                    For Each strCorreo As String In correoTO.Split(New Char() {","}, StringSplitOptions.RemoveEmptyEntries)
                        Try
                            enviarCorreobyOracle(strCorreo, _
                                                 System.Configuration.ConfigurationManager.AppSettings("CCMail"), _
                                                 userMail, subject, htmlBody, _
                                                 System.Configuration.ConfigurationManager.ConnectionStrings("oraRec").ConnectionString)
                        Catch ex As Exception
                            strMegErr.Append("No se pudo enviar el mail a " & strCorreo & " : " & ex.Message & "/")
                        End Try
                    Next
                    If strMegErr.Length > 0 Then
                        Throw New Exception(strMegErr.ToString)
                    End If
                Else
                    Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(htmlBody, Nothing, "text/html")
                    Dim imageView As New AlternateView(pathlogo, System.Net.Mime.MediaTypeNames.Image.Jpeg)
                    imageView.ContentId = "LogoID"
                    imageView.TransferEncoding = Net.Mime.TransferEncoding.Base64
                    mail.From = New MailAddress(userMail, userName)
                    If Not String.IsNullOrEmpty(correoTO) Then
                        mail.To.Add(correoTO)
                    Else
                        Throw New Exception("No se tiene dirección de correo del remitente")
                    End If
                    If Not String.IsNullOrEmpty(correoCC) Then
                        mail.CC.Add(correoCC)
                    End If
                    mail.Subject = subject
                    mail.AlternateViews.Add(htmlView)
                    mail.AlternateViews.Add(imageView)

                    Dim lobjClient As SmtpClient = New SmtpClient(lstrServer, lintPort)
                    lobjClient.DeliveryMethod = SmtpDeliveryMethod.Network
                    lobjClient.Credentials = New System.Net.NetworkCredential(System.Configuration.ConfigurationManager.AppSettings("UserMailSMTP"), _
                                                                              System.Configuration.ConfigurationManager.AppSettings("UserMailPass"))
                    lobjClient.Send(mail)
                End If
                strResult(1) = "1"
            Catch ex As InvalidOperationException
                strResult(0) = "Error: " & ex.Message & vbCrLf & ex.Source
            Catch ex As Net.Mail.SmtpException
                strResult(0) = "Error: " & ex.Message & vbCrLf & ex.Source
            Catch ex As Exception
                ''strResult(0) = "Error: " & ex.Message & vbCrLf & ex.Source
                Throw ex
            Finally
                Mail.Dispose()
            End Try
            Return strResult
        End Function


        Private Shared Function MakeSimpleMessage(ByVal Title As String, ByVal subTitle As String, ByVal message As String) As String
            Dim strmessage = New StringBuilder

            strmessage.Append("<div style='font-family: arial, verdana; line-height:20px; font-size:12px; color:#666;'>")
            strmessage.Append("<div style='padding:10px 0; background: #ee2e24;'>")
            'strmessage.Append("<div style='width:600px; margin:0 auto;'><img src='cid:LogoID'/></div>")
            strmessage.Append("<div style='width:600px; margin:0 auto;'></div>")
            strmessage.Append("</div>")

            strmessage.Append("<div class='content' style='width:600px; margin:0 auto;'><!--Inicio content-->")

            strmessage.Append("<h1 style='font-family: arial, verdana; font-size: 25px; color: #ee2e24'>" + Title + "</h1>")
            If (Not subTitle.Equals("")) Then
                strmessage.Append("<h2 style='line-height:0; font-family: arial, verdana; font-size: 18px; color: #666; line-height:22px;' >" + subTitle + "</h2>")
            End If

            strmessage.Append("<p style='margin:0;'>")
            strmessage.Append(message)
            strmessage.Append("</p>")


            strmessage.Append("</div><!--Fin Content-->")

            strmessage.Append("<div style='margin-top:15px; padding:8px 0; background: #ee2e24;'>")
            strmessage.Append("<div style='width:600px; margin:0 auto;'>")
            strmessage.Append("<ul style='padding:0;list-style: none; width: 400px; margin: 0 auto;' >")
            strmessage.Append("<li style='float: left; padding: 5px 8px;'><a target='_blank' style='padding: 5px 15px;;background: #b4221b;color: #fff; text-decoration: none;' href='http://www.facebook.com/marcaPERU'  title='Ir a Facebook'>Facebook</a></li>")
            strmessage.Append("<li style='float: left; padding: 5px 8px;'><a target='_blank' style='padding: 5px 15px;;background: #b4221b;color: #fff; text-decoration: none;'  href='https://twitter.com/marcaperu' title='Ir a Twitter'>Twitter</a></li>")
            'strmessage.Append("<li style='float: left; padding: 5px 8px;'><a target='_blank' style='padding: 5px 15px;;background: #b4221b;color: #fff; text-decoration: none;'  href='http://www.facebook.com/marcaPERU' title='Ir a Youtube'>Youtube</a></li>")
            strmessage.Append("<div style='clear: both;'></div>")
            strmessage.Append("</ul>")
            strmessage.Append("</div>")
            strmessage.Append("</div>")
            strmessage.Append("</div>")
            Return strmessage.ToString
        End Function

    End Class
End Namespace

