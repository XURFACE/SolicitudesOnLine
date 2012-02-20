Imports PromPeru.Configuration
Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports System.Data
Public Class WFRM_Paso08
    Inherits System.Web.UI.Page

    Private Sub Btn_Seguir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Try
            Dim objclsBC_SOLICITUDTX As New BC.clsBC_SOLICITUDTX
            Dim objclsBC_DETUSOTX As New BC.clsBC_DET_USOTX
            Dim cllclsBE_DETUSO As New List(Of BE.clsBE_DET_USO)


            Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

            If Not IsNothing(Session("SessionInst")) Then
                objSolicitudTotal.BE_SOLICITUD_INST.strRPTAUSOMARCAPAIS = txtRstaMP.Text
            End If
            If Not IsNothing(Session("SessionProd")) Then
                objSolicitudTotal.BE_SOLICITUD_PROD.strRPTAUSOMARCAPAIS = txtRstaMP.Text
            End If
            If Not IsNothing(Session("SessionEvent")) Then
                objSolicitudTotal.BE_SOLICITUD_EVENT.strRPTAUSOMARCAPAIS = txtRstaMP.Text
            End If

            If Not IsNothing(Session("DetUso")) Then
                objSolicitudTotal.LIST_BE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))
                If objSolicitudTotal.LIST_BE_DETUSO.Count = 0 Then
                    Throw New Exception("Ingrese al menos un detalle de Aplicación de uso")
                End If
            Else
                Throw New Exception("Ingrese al menos un detalle de Aplicación de uso")
            End If
            ambitoUso()
            Response.Redirect("WFRM_Final.aspx")
        Catch ex As Exception
            lblMsjError.Text = "<div class='messbox'><ul><li>" & ex.Message.Replace(":", "").Replace("*", "") & "</li></ul></div>"
            lblMsjError.Visible = True
        End Try
    End Sub


    
    Private Function ambitoUso() As Boolean

        Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL
        Dim objclsBC_AMBITOUSOTX As New BC.clsBC_AMBITOUSOTX

        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)


        'If chb_nacional.Checked Then

        If chb_lima.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 33
            objAmbitouso.intIDPUBLICO = 1
            objAmbitouso.strPUBLICO = chb_nacional.Text
            objAmbitouso.strDETPUBLICO = chb_lima.Text
            ' objAmbitouso.lngIDSOLICITUD = idSol
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_provincias.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 34
            objAmbitouso.intIDPUBLICO = 1
            objAmbitouso.strPUBLICO = chb_nacional.Text
            objAmbitouso.strDETPUBLICO = chb_provincias.Text
            ' objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtReg.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        'End If
        'If chb_internacional.Checked Then

        If chb_ams.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 35
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_ams.Text
            ' objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtAms.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_amn.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 36
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_amn.Text
            'objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtAmn.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_amcen.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 37
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_amcen.Text
            ' objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtAmc.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_eur.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 38
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_eur.Text
            ' objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtEur.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_asia.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 39
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_asia.Text
            'objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtAsia.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_afri.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 40
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_afri.Text
            'objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtAfr.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        If chb_oceania.Checked Then
            Dim objAmbitouso As New BE.clsBE_AMBITOUSO
            objAmbitouso.intIDDETPUBLICO = 41
            objAmbitouso.intIDPUBLICO = 2
            objAmbitouso.strPUBLICO = chb_internacional.Text
            objAmbitouso.strDETPUBLICO = chb_oceania.Text
            'objAmbitouso.lngIDSOLICITUD = idSol
            objAmbitouso.strLISTADETALLADA = txtOce.Text
            objclsBC_AMBITOUSOTX.LstAMBITOUSO.Add(objAmbitouso)
        End If
        'End If


        objSolicitudTotal.LIST_BE_AMBITOUSO = objclsBC_AMBITOUSOTX.LstAMBITOUSO
        ' objclsBC_AMBITOUSOTX.InsertarAMBITOUSO()
        Session(Konstantes.kstrSessionTotal) = objSolicitudTotal
        Return objclsBC_AMBITOUSOTX.LstAMBITOUSO.Count > 0
    End Function
    Private Sub cargaambitoUso()
        Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL
        objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        Dim objAmbitoUso As BE.clsBE_AMBITOUSO

        Dim finder As New Finders.finderAmbitoUso(33)

        chb_lima.Checked = Not IsNothing(objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso))

        finder = New Finders.finderAmbitoUso(34)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)

        If Not IsNothing(objAmbitoUso) Then
            chb_provincias.Checked = True
            txtReg.Text = objAmbitoUso.strLISTADETALLADA
        End If
        chb_nacional.Checked = chb_lima.Checked Or chb_provincias.Checked

        finder = New Finders.finderAmbitoUso(35)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtAms.Text = objAmbitoUso.strLISTADETALLADA
            chb_ams.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(36)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtAmn.Text = objAmbitoUso.strLISTADETALLADA
            chb_amn.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(37)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtAmc.Text = objAmbitoUso.strLISTADETALLADA
            chb_amcen.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(38)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtEur.Text = objAmbitoUso.strLISTADETALLADA
            chb_eur.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(39)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtAsia.Text = objAmbitoUso.strLISTADETALLADA
            chb_asia.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(40)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtAfr.Text = objAmbitoUso.strLISTADETALLADA
            chb_afri.Checked = True
        End If
        finder = New Finders.finderAmbitoUso(41)
        objAmbitoUso = objSolicitudTotal.LIST_BE_AMBITOUSO.Find(AddressOf finder.findAmbitoUso)
        If Not IsNothing(objAmbitoUso) Then
            txtOce.Text = objAmbitoUso.strLISTADETALLADA
            chb_oceania.Checked = True
        End If
        chb_internacional.Checked = chb_ams.Checked Or chb_amn.Checked Or chb_amcen.Checked Or _
                                    chb_eur.Checked Or chb_asia.Checked Or chb_afri.Checked Or chb_oceania.Checked
        
    End Sub
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If

        If Not IsPostBack Then
            If Not IsNothing(Session("SessionInst")) Then
                lblUso.Text += "INSTITUCIONAL<br/>"
            End If
            If Not IsNothing(Session("SessionProd")) Then
                lblUso.Text += "PRODUCTOS<br/>"
            End If
            If Not IsNothing(Session("SessionEvent")) Then
                lblUso.Text += "EVENTOS<br/>"
            End If
            cargaambitoUso()
            cargarPasoFinal()




        End If


        Dim cllClsBE_DETUSO As New List(Of BE.clsBE_DET_USO)

        If Not IsNothing(Session("DetUso")) Then
            cllClsBE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))
        Else
            Dim objBE_DETUSO As New BE.clsBE_DET_USO
            objBE_DETUSO.strTIPOLIC = "-1"
            cllClsBE_DETUSO.Add(objBE_DETUSO)

        End If
        gViewDU.DataSource = cllClsBE_DETUSO
        gViewDU.DataBind()
    End Sub
    Private Sub cargarPasoFinal()
        Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
            If Not IsNothing(Session("SessionInst")) Then
                txtRstaMP.Text = objSolicitudTotal.BE_SOLICITUD_INST.strRPTAUSOMARCAPAIS
            End If
            If Not IsNothing(Session("SessionProd")) Then
                txtRstaMP.Text = objSolicitudTotal.BE_SOLICITUD_PROD.strRPTAUSOMARCAPAIS
            End If
            If Not IsNothing(Session("SessionEvent")) Then
                txtRstaMP.Text = objSolicitudTotal.BE_SOLICITUD_EVENT.strRPTAUSOMARCAPAIS
            End If


        End If
    End Sub


    Private Sub guardarSolicitud(ByRef _BE_SOLICITUD As BE.clsBE_SOLICITUD)
        Dim objclsBC_SOLICITUDTX As New BC.clsBC_SOLICITUDTX
        DatosAuditoria(_BE_SOLICITUD, Me.ToString.Substring(4), "")
        objclsBC_SOLICITUDTX.LstSOLICITUD.Add(_BE_SOLICITUD)
        objclsBC_SOLICITUDTX.InsertarSOLICITUD()
        _BE_SOLICITUD = objclsBC_SOLICITUDTX.LstSOLICITUD(0)
    End Sub
    Private Sub guardarProducto(ByRef _BE_PRODUCTO As BE.clsBE_PRODUCTO)
        Dim objclsBC_PRODUCTOTX As New BC.clsBC_PRODUCTOTX
        DatosAuditoria(_BE_PRODUCTO, Me.ToString.Substring(4), "")
        objclsBC_PRODUCTOTX.LstPRODUCTO.Add(_BE_PRODUCTO)
        objclsBC_PRODUCTOTX.InsertarPRODUCTO()
        _BE_PRODUCTO = objclsBC_PRODUCTOTX.LstPRODUCTO(0)
    End Sub
    Private Sub guardarEvento(ByRef _BE_PRODUCTO As BE.clsBE_EVENTO)
        Dim objclsBC_EVENTOTX As New BC.clsBC_EVENTOTX
        DatosAuditoria(_BE_PRODUCTO, Me.ToString.Substring(4), "")
        objclsBC_EVENTOTX.LstEVENTO.Add(_BE_PRODUCTO)
        objclsBC_EVENTOTX.InsertarEVENTO()
        _BE_PRODUCTO = objclsBC_EVENTOTX.LstEVENTO(0)
    End Sub


    Protected Sub gViewDU_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gViewDU.RowCommand
        Dim cllClsBE_DETUSO As New List(Of BE.clsBE_DET_USO)
        Dim strComand As String = e.CommandName
        Dim index As Int32 = CInt(e.CommandSource.parent.parent.rowindex)
        If strComand = "btn_editar" Then

        ElseIf strComand = "lnkDelete" Then
            If Not IsNothing(Session("DetUso")) Then
                cllClsBE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))
                cllClsBE_DETUSO.RemoveAt(index)
                If (cllClsBE_DETUSO.Count = 0) Then
                    Dim objBE_DETUSO As New BE.clsBE_DET_USO
                    objBE_DETUSO.strTIPOLIC = "-1"
                    cllClsBE_DETUSO.Add(objBE_DETUSO)
                    Session.Remove("DetUso")
                End If
                gViewDU.DataSource = cllClsBE_DETUSO
                gViewDU.DataBind()
            End If
        ElseIf strComand = "lnkEdit" Then
            If Not IsNothing(Session("DetUso")) Then
                cllClsBE_DETUSO = CType(Session("DetUso"), List(Of BE.clsBE_DET_USO))
                If cllClsBE_DETUSO.Count > 0 Then

                    ScriptManager.RegisterStartupScript(Me, Me.GetType, "", " $(this).modal({width:440, height:335, src:'addRefDU.aspx?orden=" & index & "'}).open();", True)
                End If
            End If
        End If
    End Sub

   

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Dim pasos As New Rastro
        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx")
        End If


        Response.Redirect(page)
    End Sub

    Protected Sub gViewDU_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gViewDU.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow And e.Row.Cells(0).Text = "-1" Then
            e.Row.Visible = False
        End If
        If e.Row.RowType = DataControlRowType.DataRow Then
            If e.Row.Cells(1).Text = "0" Then
                e.Row.Cells(1).Text = "Pagina Web"
            ElseIf e.Row.Cells(1).Text = "1" Then
                e.Row.Cells(1).Text = "Panaderia/Impresos"
            ElseIf e.Row.Cells(1).Text = "2" Then
                e.Row.Cells(1).Text = "Material Institucional"
            ElseIf e.Row.Cells(1).Text = "3" Then
                e.Row.Cells(1).Text = "Web/Redes Sociales"
            ElseIf e.Row.Cells(1).Text = "4" Then
                e.Row.Cells(1).Text = "Otros"
            End If
        End If
    End Sub

   
End Class