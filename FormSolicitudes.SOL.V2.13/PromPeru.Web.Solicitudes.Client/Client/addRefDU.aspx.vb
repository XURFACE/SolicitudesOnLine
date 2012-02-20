Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports System.Data
Public Class addRefDU
    Inherits System.Web.UI.Page

    Protected Sub btn_add_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Try
            Dim cllClsBE_DETUSO As New List(Of BE.clsBE_DET_USO)
            Dim objBE_DETUSO As New BE.clsBE_DET_USO

            If Not IsNothing(Session("DetUso")) Then
                cllClsBE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))
            End If

            If Not IsNothing(Request.QueryString("orden")) And cllClsBE_DETUSO.Count > 0 Then
                Dim index As Int32 = CType(Request.QueryString("orden"), Int32)
                cllClsBE_DETUSO(index).strTIPOLIC = ddl_uso.SelectedValue
                cllClsBE_DETUSO(index).intSUBTIPO = ddl_subTipo.SelectedItem.Text
                cllClsBE_DETUSO(index).strDESCRIPCION = txtDesc.Text

            Else
                objBE_DETUSO.intSUBTIPO = ddl_subTipo.SelectedItem.Text
                objBE_DETUSO.strDESCRIPCION = txtDesc.Text
                objBE_DETUSO.strTIPOLIC = ddl_uso.SelectedItem.ToString

                cllClsBE_DETUSO.Add(objBE_DETUSO)
                Session("DetUso") = cllClsBE_DETUSO
            End If
            ScriptManager.RegisterStartupScript(Me, Me.GetType, "", "cargarUso();", True)
        Catch ex As Exception
            lblMessege.Text = ex.Message
            lblMessege.Visible = True
        End Try
    End Sub

    Private Sub cargaAplicacion(ByVal xitm As ListItem)
        Dim itm As ListItem
        If Not IsNothing(xitm) Then
            ddl_subTipo.Items.Clear()
            Select Case xitm.Value
                Case "INSTITUCIONAL"
                    itm = New ListItem("Papeleria / Impresos", "I0")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Web / Redes Sociales", "I1")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Material institucional (merchandising de distribución gratuita)", "I2")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Eventos institucionales (participación en ferias, talleres, etc)", "I3")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Local comercial / instalaciones", "I4")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Publicidad", "I5")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Otros", "I6")
                    ddl_subTipo.Items.Add(itm)
                Case "PRODUCTO"
                    itm = New ListItem("Etiquetas", "P0")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Envases", "P1")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Publicidad", "P2")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Otros", "P3")
                    ddl_subTipo.Items.Add(itm)
                Case "EVENTO"
                    itm = New ListItem("Ferias", "E0)")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Festivales", "E1")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Congresos / Seminarios", "E2")
                    ddl_subTipo.Items.Add(itm)
                    itm = New ListItem("Otros", "E3")
                    ddl_subTipo.Items.Add(itm)
            End Select
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            Dim itm As ListItem
            If Not IsNothing(Session("SessionInst")) Then
                itm = New ListItem("INSTITUCIONAL", "INSTITUCIONAL")
                ddl_uso.Items.Add(itm)
            End If
            If Not IsNothing(Session("SessionProd")) Then
                itm = New ListItem("PRODUCTO", "PRODUCTO")
                ddl_uso.Items.Add(itm)
            End If
            If Not IsNothing(Session("SessionEvent")) Then
                itm = New ListItem("EVENTO", "EVENTO")
                ddl_uso.Items.Add(itm)
            End If
            ddl_uso.Enabled = ddl_uso.Items.Count > 0
            ddl_subTipo.Enabled = ddl_uso.Items.Count > 0
            txtDesc.Enabled = ddl_uso.Items.Count > 0
            btn_add.Visible = ddl_uso.Items.Count > 0
            If ddl_uso.Items.Count <= 0 Then
                lblMessege.Text = "Hubo un error en la sesión le recomendamos inicie nuevamente el proceso."
                lblMessege.Visible = True
                Exit Sub
            End If
            cargaAplicacion(ddl_uso.SelectedItem)

            If Not IsNothing(Request.QueryString("orden")) Then
                Dim cllClsBE_DETUSO As New List(Of BE.clsBE_DET_USO)
                Dim index As Int32 = CType(Request.QueryString("orden"), Int32)
                cllClsBE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))

                ddl_uso.SelectedValue = cllClsBE_DETUSO(index).strTIPOLIC
                itm = ddl_subTipo.Items.FindByText(cllClsBE_DETUSO(index).intSUBTIPO)
                If IsNothing(itm) Then
                    ddl_subTipo.SelectedIndex = 0
                Else
                    ddl_subTipo.SelectedIndex = ddl_subTipo.Items.IndexOf(itm)
                End If

                txtDesc.Text = cllClsBE_DETUSO(index).strDESCRIPCION

            End If
        End If
    End Sub

    Protected Sub ddl_uso_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ddl_uso.SelectedIndexChanged
        cargaAplicacion(ddl_uso.SelectedItem)
    End Sub
End Class