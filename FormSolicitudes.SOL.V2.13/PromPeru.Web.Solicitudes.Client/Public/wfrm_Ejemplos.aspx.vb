Imports MP.DW.BL
Public Class wfrm_Ejemplos
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Try
                Dim objBC_Ejemplo As New BC.clsBC_EJEMPLORO
                objBC_Ejemplo.LeerListaToDTEJEMPLO()
                Dim dSet As DataSet
                Dim ejemplos As New StringBuilder

                dSet = objBC_Ejemplo.oDTEJEMPLO.DataSet

                cargarEjemplos(ejemplos, dSet, "Institucional")
                ltrlImages.Text = ejemplos.ToString

                ejemplos = New StringBuilder
                cargarEjemplos(ejemplos, dSet, "Producto")
                ltrlImagesProd.Text = ejemplos.ToString

                ejemplos = New StringBuilder
                cargarEjemplos(ejemplos, dSet, "Evento")
                ltrlImagesEvento.Text = ejemplos.ToString

            Catch ex As Exception

            End Try

          
        End If
    End Sub

    Private Sub cargarEjemplos(ByRef ejemplo As StringBuilder, ByVal dSet As DataSet, ByRef tipoS As String)

        ejemplo.Append(" <div id='")
        ejemplo.Append(tipoS)
        ejemplo.Append("'>")
        ejemplo.Append("<h4>Uso ")
        ejemplo.Append(tipoS)
        ejemplo.Append("</h4>")
        For orden As Int32 = 0 To dSet.Tables(0).Rows.Count - 1
            If dSet.Tables(0).Rows(orden)(2).Equals(tipoS.ToUpper) Then
                ejemplo.Append("<div  class='list-empresa'><div class='img'><img src='")
                ejemplo.Append(dSet.Tables(0).Rows(orden)(4))
                ejemplo.Append("'/></div><p>")
                ejemplo.Append(dSet.Tables(0).Rows(orden)(1))
                ejemplo.Append("</p></div>")
            End If
        Next

        ejemplo.Append("<div class='clear'></div></div>")
    End Sub

End Class