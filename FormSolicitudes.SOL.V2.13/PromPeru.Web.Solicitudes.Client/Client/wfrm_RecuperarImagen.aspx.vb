Imports MP.DW.BL
Imports PromPeru.Configuration
Public Class wfrm_RecuperarImagen
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim objSolTlt As New BE.clsBE_SOLICITUDTOTAL
        Dim objBEAplicacionRO As New BC.clsBC_APLICACIONRO
        Dim rutaRelativa As String
        Dim id As Int32
        If Not IsPostBack Then

            If Not IsPostBack Then
                If Not IsNothing(Request.QueryString("id")) Then
                    If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                        objSolTlt = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

                    End If


                    id = CType(Request.QueryString("id"), Int32)
                    objBEAplicacionRO.oBEAPLICACION.lngID = id
                    objBEAplicacionRO.LeerAPLICACION()
                    rutaRelativa = objBEAplicacionRO.oBEAPLICACION.strRUTA_IMAGEN
                    rutaRelativa = rutaRelativa.Replace(System.Configuration.ConfigurationManager.AppSettings("rutaImagenCorto"), "~")
                    imgMostrar.ImageUrl = rutaRelativa

                End If
            End If


        End If
    End Sub

End Class