Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports PromPeru.Configuration
Public Class WFRM_Paso01
    Inherits System.Web.UI.Page

    Private Sub Btn_Seguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Dim pasos As New Rastro
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL

        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        End If

        If (dllObjetivos.SelectedValue = "Otros") Then
            objSolicitudTotal.BE_EMPRESA.strOBJETIVO = txtObjOtros.Text
        Else
            objSolicitudTotal.BE_EMPRESA.strOBJETIVO = dllObjetivos.SelectedItem.ToString
        End If

        objSolicitudTotal.BE_EMPRESA.strOBJ_PORQUE = txtAPorq.Text

        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal

        pasos.PASOS.Push(1)
        Session(Konstantes.kstrPasos) = pasos

        ResponseRedirect()

    End Sub
    Private Sub ResponseRedirect()
        Dim strbld As New Text.StringBuilder
        Dim blnFlag As Boolean = False
        If Not IsNothing(Request.QueryString("tipo")) Then
            blnFlag = True
            strbld.Append("tipo=" & Request.QueryString("tipo") & "&")
        End If
        If Not IsNothing(Request.QueryString("id")) Then
            blnFlag = True
            strbld.Append("id=" & Request.QueryString("id") & "&")
        End If
        If Not IsNothing(Request.QueryString("idsol")) Then
            blnFlag = True
            strbld.Append("idsol=" & Request.QueryString("idsol"))
        End If
        If blnFlag Then
            Response.Redirect("WFRM_Paso02.aspx?" & strbld.ToString)
        Else
            Response.Redirect("WFRM_Paso02.aspx")
        End If
    End Sub
    Protected Sub Btn_Cancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Cancelar.Click
        Response.Redirect("../main.aspx")
    End Sub

    Protected Sub dllObjetivos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dllObjetivos.SelectedIndexChanged
        If (dllObjetivos.SelectedValue = "Otros") Then
            txtObjOtros.Enabled = True

        Else
            txtObjOtros.Enabled = False
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        If Not IsPostBack Then
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                If Not IsNothing(objSolicitudTotal.BE_EMPRESA) Then
                    
                    txtAPorq.Text = objSolicitudTotal.BE_EMPRESA.strOBJ_PORQUE
                    objSolicitudTotal.BE_EMPRESA = objSolicitudTotal.BE_EMPRESA

                    dllObjetivos.SelectedValue = objSolicitudTotal.BE_EMPRESA.strOBJETIVO
                    If dllObjetivos.SelectedValue <> objSolicitudTotal.BE_EMPRESA.strOBJETIVO Then
                        dllObjetivos.SelectedValue = "Otros"
                        txtObjOtros.Text = objSolicitudTotal.BE_EMPRESA.strOBJETIVO
                    End If
                End If
            End If
        End If
    End Sub
End Class