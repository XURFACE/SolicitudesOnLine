Imports MP.DW.UTL
Imports System.Drawing
Imports System.Drawing.Imaging
Public Class cpchaImg
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ci As New CaptchaImage(Session("CaptchaImageText").ToString(), 200, 50, "Century Schoolbook")

        '// Change the response headers to output a JPEG image.
        Response.Clear()
        Response.ContentType = "image/jpeg"

        '// Write the image to the response stream in JPEG format.
        ci.Image.Save(Response.OutputStream, ImageFormat.Jpeg)

        '// Dispose of the CAPTCHA image object.
        ci.Dispose()
    End Sub

End Class