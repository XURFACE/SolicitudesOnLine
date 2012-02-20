Imports MP.DW.BL
Public Class wfrm_FAQ
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then

            Try
                Dim objBC_FAQ As New BC.clsBC_FAQRO
                Dim dSet As DataSet
                Dim preguntas As New StringBuilder
                objBC_FAQ.LeerListaToDTFAQ()

                dSet = objBC_FAQ.oDTFAQ.DataSet
                preguntas.Append("<ul id='faq'>")
                For orden As Int32 = 0 To dSet.Tables(0).Rows.Count - 1
                    preguntas.Append("<li><h4>")
                    preguntas.Append(dSet.Tables(0).Rows(orden)(1))
                    preguntas.Append("</h4><p>")
                    preguntas.Append(dSet.Tables(0).Rows(orden)(2))
                    preguntas.Append("</p></li>")
                Next
                preguntas.Append("</ul>")

                ltrlFAQ.Text = preguntas.ToString
            Catch ex As Exception

            End Try

            

        End If
    End Sub

End Class