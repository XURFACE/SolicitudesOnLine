
Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports System.Data
Public Class addProd
    Inherits System.Web.UI.Page
    Dim index As Int32 = -1
    Protected Sub btn_add_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Try
            If ddlMarca.SelectedItem.ToString.Trim.Equals("") Then
                Exit Sub
            End If
            Dim lstProd As New List(Of BE.clsBE_PRODUCTO)
            Dim solicitudPro As New BE.clsBE_SOLICITUD
            Dim cllProductos As New List(Of BE.clsBE_PRODUCTO)
            Dim objProd As New BE.clsBE_PRODUCTO

            If Not IsNothing(Session("cllObjProductos")) Then
                cllProductos = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))
            Else
                Session("cllObjProductos") = cllProductos
            End If


            If Not IsNothing(Request.QueryString("id")) Then

                index = CType(Request.QueryString("id"), Int32)
                cllProductos(index).strMARCA = ddlMarca.SelectedItem.ToString
                cllProductos(index).strNOMBRE = txtNombre.Text
                cllProductos(index).dblPORC_FABRICACION = txtPorcFabri.Text
                cllProductos(index).dblPORC_UNIDVENC = txtPorcUnd.Text
                cllProductos(index).dblPORC_VALORVENTA = txtPorcValVnt.Text

            Else
                objProd.lngID = 1
                objProd.strMARCA = ddlMarca.SelectedItem.ToString
                objProd.strNOMBRE = txtNombre.Text
                objProd.dblPORC_FABRICACION = txtPorcFabri.Text
                objProd.dblPORC_UNIDVENC = txtPorcUnd.Text
                objProd.dblPORC_VALORVENTA = txtPorcValVnt.Text
                If Not IsNothing(Session("cllObjProductosMarca")) Then
                    lstProd = CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))
                    objProd.strRUTAREGISTROINDECOPI = lstProd(CType(ddlMarca.SelectedValue, Int32)).strRUTAREGISTROINDECOPI
                End If
                cllProductos.Add(objProd)
            End If
            Session("cllObjProductos") = cllProductos
            'Me.Parent.Page.ClientScript.GetPostBackEventReference(New PostBackOptions(Me.Parent.Page))
            ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "parent.document.location = parent.document.location", True)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        Dim lstProd As New List(Of BE.clsBE_PRODUCTO)
        Dim lst As New List(Of BE.clsBE_PRODUCTO)
        Dim listItem As ListItem
        Dim idex As Int32 = 0
        Dim value As Int32 = 0
        If Not IsPostBack Then

            btn_add.Visible = Not IsNothing(Session("cllObjProductosMarca"))
            ddlMarca.Enabled = Not IsNothing(Session("cllObjProductosMarca"))
            txtNombre.Enabled = Not IsNothing(Session("cllObjProductosMarca"))
            txtPorcFabri.Enabled = Not IsNothing(Session("cllObjProductosMarca"))
            txtPorcUnd.Enabled = Not IsNothing(Session("cllObjProductosMarca"))
            txtPorcValVnt.Enabled = Not IsNothing(Session("cllObjProductosMarca"))

            If Not IsNothing(Session("cllObjProductosMarca")) Then
                lstProd = CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))
                For Each objprod As BE.clsBE_PRODUCTO In lstProd
                    If (objprod.strMARCA <> "-1") Then
                        listItem = New ListItem()
                        listItem.Value = value
                        listItem.Text = objprod.strMARCA
                        ddlMarca.Items.Add(listItem)
                        value += 1
                    End If
                Next
                'ddlMarca.DataSource = lstProd
                'ddlMarca.DataTextField = "strMARCA"
                'ddlMarca.DataValueField = "strMARCA"
                'ddlMarca.DataBind()
            Else
                ltrMsg.Text = "<div class='messbox'><ul><li>Primero ingrese al menos una marca</li></ul></div>"
                Exit Sub
            End If

            If Not IsNothing(Request.QueryString("id")) Then
                idex = CType(Request.QueryString("id"), Int32)
                If Not IsNothing(Session("cllObjProductos")) Then
                    lst = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))

                    index = idex
                    If index >= 0 Then
                        Dim itm As ListItem = ddlMarca.Items.FindByText(lst(index).strMARCA)
                        If Not IsNothing(itm) Then ddlMarca.SelectedIndex = ddlMarca.Items.IndexOf(itm)
                        txtNombre.Text = lst(index).strNOMBRE
                        txtPorcFabri.Text = lst(index).dblPORC_FABRICACION.ToString
                        txtPorcUnd.Text = lst(index).dblPORC_UNIDVENC.ToString
                        txtPorcValVnt.Text = lst(index).dblPORC_VALORVENTA.ToString
                    End If
                End If


            End If
        End If
    End Sub
End Class