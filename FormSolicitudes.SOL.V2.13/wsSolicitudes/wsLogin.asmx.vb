Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports MP.DW.UTL.seguridad
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.BL

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class wsLogin
    Inherits System.Web.Services.WebService

    <WebMethod()> Public Function Login(ByVal xusr As String, ByVal xpwd As String) As String
        Try
            Dim objBC_USUARIO As New BC.clsBC_CLIENT_USERRO
            objBC_USUARIO.oBECLIENT_USER.strLOGINUSR = xusr
            objBC_USUARIO.LeerUSUARIOLogIn()
            If objBC_USUARIO.oBECLIENT_USER.lngID = 0 Then
                Throw New Exception("El usuario no existe")
            Else
                If Encripta(AlgoritmoDeEncriptacion.MD5, xpwd) = DesEncripta(objBC_USUARIO.oBECLIENT_USER.strPWDUSR) Then
                    Return ""
                Else
                    Throw New Exception("Contraseña incorrecta")
                End If
            End If
        Catch ex As Exception
            Return ex.Message 
        End Try
    End Function
    <WebMethod()> Public Function ejemplos() As DataSet
        Try
            Dim objBC_Ejemplo As New BC.clsBC_EJEMPLORO
            'objBC_Ejemplo.oBEEJEMPLO.strLOGINUSR = xusr
            objBC_Ejemplo.LeerListaToDTEJEMPLO()
            
            Return objBC_Ejemplo.oDTEJEMPLO.DataSet
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    <WebMethod()> Public Function PreguntasFrecuentes() As DataSet
        Try
            Dim objBC_FAQ As New BC.clsBC_FAQRO
            'objBC_Ejemplo.oBEEJEMPLO.strLOGINUSR = xusr
            objBC_FAQ.LeerListaToDTFAQ()
            
            Return objBC_FAQ.oDTFAQ.DataSet
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Class