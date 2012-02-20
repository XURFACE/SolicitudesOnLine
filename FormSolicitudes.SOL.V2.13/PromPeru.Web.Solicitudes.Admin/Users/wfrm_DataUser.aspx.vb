Imports MP.DW.BL
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL.seguridad
Public Class wfrm_DataUser
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not IsNothing(Request.QueryString("IdUsr")) Then
                Dim objBC As New BC.clsBC_USUARIORO
                objBC.oBEUSUARIO.intID = Request.QueryString("IdUsr")
                objBC.LeerUSUARIO()
                txtbLog.Text = CstrMP(objBC.oBEUSUARIO.strLOGIN)
                txtbNombre.Text = CstrMP(objBC.oBEUSUARIO.strNOMBRE)
                Dim itm As ListItem = ddlPerfil.Items.FindByText(objBC.oBEUSUARIO.strPERFIL)
                If IsNothing(itm) Then ddlPerfil.SelectedIndex = 0 : ddlPerfil.SelectedIndex = ddlPerfil.Items.IndexOf(itm)
            Else

            End If
            trPdw.Visible = IsNothing(Request.QueryString("IdUsr"))
            trPdw0.Visible = IsNothing(Request.QueryString("IdUsr"))
            btnUpdate.Visible = Not IsNothing(Request.QueryString("IdUsr"))
            btnGuardar.Visible = IsNothing(Request.QueryString("IdUsr"))
        End If

    End Sub

    Private Function returnBC() As BC.clsBC_USUARIOTX
        Dim objBC As New BC.clsBC_USUARIOTX
        objBC.oBEUSUARIO.intID = Request.QueryString("IdUsr")
        objBC.oBEUSUARIO.strLOGIN = txtbLog.Text
        objBC.oBEUSUARIO.strNOMBRE = txtbNombre.Text
        objBC.oBEUSUARIO.strPERFIL = ddlPerfil.SelectedValue
        DatosAuditoria(objBC.oBEUSUARIO, "DatosUsuario", "")
        Return objBC
    End Function
    Protected Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        Try
            Dim objBCRead As New BC.clsBC_USUARIORO
            objBCRead.oBEUSUARIO.intID = Request.QueryString("IdUsr")
            objBCRead.LeerUSUARIO()
            Dim objBC As BC.clsBC_USUARIOTX = returnBC()
            objBC.oBEUSUARIO.intID = Request.QueryString("IdUsr")
            objBC.oBEUSUARIO.strPASSWORD = objBCRead.oBEUSUARIO.strPASSWORD
            objBC.LstUSUARIO.Add(objBC.oBEUSUARIO)
            objBC.ModificarUSUARIO()
            ScriptManager.RegisterClientScriptBlock(Me, GetType(Page), UniqueID, "closeDialog()", True)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnGuardar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGuardar.Click
        Try
            Dim objBC As BC.clsBC_USUARIOTX = returnBC()
            objBC.oBEUSUARIO.strPASSWORD = Encripta(Encripta(AlgoritmoDeEncriptacion.MD5, txtpwd.Text))
            objBC.LstUSUARIO.Add(objBC.oBEUSUARIO)
            objBC.InsertarUSUARIO()
            ScriptManager.RegisterClientScriptBlock(Me, GetType(Page), UniqueID, "closeDialog()", True)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        ScriptManager.RegisterClientScriptBlock(Me, GetType(Page), UniqueID, "closeDialog()", True)
    End Sub
End Class