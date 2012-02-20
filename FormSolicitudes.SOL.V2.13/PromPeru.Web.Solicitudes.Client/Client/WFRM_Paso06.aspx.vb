Imports MP.DW.BL
Imports MP.DW.BL.BC
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.UTL
Imports System.Data
Imports PromPeru.Configuration.Enumerators
Imports PromPeru.Configuration
Imports Subgurim.Controles
Public Class WFRM_Paso06
    Inherits System.Web.UI.Page
    Shared marca As String
    Private hashProducts = True
    Protected Sub Btn_Seguir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Btn_Seguir.Click
        Dim pasos As New Rastro
        pasos = CType(Session(Konstantes.kstrPasos), Rastro)
        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Dim objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
            If IsNothing(Session("cllObjProductosMarca")) OrElse CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO)).Count = 0 Then
                ltrMsg.Text = "<div class='messbox'><ul><li>Ingrese al menos una marca</li></ul></div>"
                Exit Sub
            End If
            If Not IsNothing(Session("cllObjProductos")) Then
                objSolicitudTotal.LIST_BE_PRODUCTO = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))
            Else
                ltrMsg.Text = "<div class='messbox'><ul><li>Ingrese al menos un producto para la(s) marca(s) ingresada(s)</li></ul></div>"
                Exit Sub
            End If
            If Not validarProductos(ltrMsg.Text, objSolicitudTotal) Then
                Exit Sub
            End If
            guardarArchivosPasoRefEmp(FUAjaxProd)
        End If

        pasos.PASOS.Push(6)
        If Not IsNothing(Session("SessionEvent")) Then
            Response.Redirect("WFRM_Paso07.aspx")
        Else
            Response.Redirect("WFRM_Paso08.aspx")
        End If
    End Sub
    Private Sub Subirarchivo(ByVal xfup As FileUpload, ByVal xstrRuta As String)
        Try
            If xfup.HasFile Then
                xfup.SaveAs(xstrRuta)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Function validarProductos(ByRef xstrMsg As String, ByVal objSolicitudTotal As BE.clsBE_SOLICITUDTOTAL) As Boolean

        xstrMsg = ""

        Dim blnInderr As Boolean = False
        Dim unidadesMay As Decimal = 0
        Dim ventaMay As Decimal = 0
        Dim unidadesMen As Decimal = 0
        Dim ventaMen As Decimal = 0
        Dim fabPeruana As Decimal = 0

        If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO) Then
            Dim marcas(objSolicitudTotal.LIST_BE_PRODUCTO.Count - 1) As String
            Dim strMarca As String = ""

            For Each xmarca As BE.clsBE_PRODUCTO In CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))

                unidadesMay = 0
                ventaMay = 0
                unidadesMen = 0
                ventaMen = 0
                fabPeruana = 0
                strMarca = ""
                For Each obj In objSolicitudTotal.LIST_BE_PRODUCTO
                    If obj.strMARCA = xmarca.strMARCA Then
                        fabPeruana = CDecMP(obj.dblPORC_FABRICACION)
                        If fabPeruana >= 50 Then
                            unidadesMay += CDecMP(obj.dblPORC_UNIDVENC)
                            ventaMay += CDecMP(obj.dblPORC_VALORVENTA)
                        Else
                            unidadesMen += CDecMP(obj.dblPORC_UNIDVENC)
                            ventaMen += CDecMP(obj.dblPORC_VALORVENTA)
                        End If
                    End If
                Next
                If unidadesMay + unidadesMen = 100 And ventaMen + ventaMay = 100 Then
                    If (unidadesMen = 100 And ventaMen = 100) AndAlso fabPeruana < 50 Then
                        blnInderr = True
                        strMarca = "<li>" & xmarca.strMARCA & " NO puede llevar la marca Perú ya que sólo el " & _
                                    fabPeruana * 100 & "% del costo de venta de su único producto es de procedencia peruana</li>"
                    Else
                        If unidadesMay < 80 Or ventaMay < 80 Then
                            blnInderr = True
                            strMarca = "<li> La marca " & xmarca.strMARCA & " no cumple con la regla 80/20</li>"
                        End If
                    End If
                Else
                    blnInderr = True
                    strMarca = "<li> El porcetaje de unidades vendidas y del valor de venta de " & xmarca.strMARCA & " deben sumar 100%</li>"
                End If
            Next
            xstrMsg += strMarca
        End If
        xstrMsg = String.Format("<div class='messbox'><ul>{0}</ul></div>", xstrMsg)
        Return Not blnInderr
    End Function
   
    Private Sub addRowFileUpload()
        Dim cllFUpload As New List(Of FileUpload)
        If Not IsNothing(Session("cllFileUpload")) Then
            cllFUpload = CType(Session("cllFileUpload"), List(Of FileUpload))

            For Each fileU As FileUpload In cllFUpload
                Dim tRows As New TableRow
                Dim tCell As New TableCell()

                tCell.Controls.Add(fileU)
                tRows.Cells.Add(tCell)
                'tbl_ref_prod.Rows.Add(tRows)
            Next

        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            Response.Redirect("WFRM_Paso01.aspx")
        End If


        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        If Not IsPostBack Then
            'FUAjaxProd.addCustomJS(FileUploaderAJAX.customJSevent.postLoad, " jsCargado()")
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then

                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                If Not IsNothing(objSolicitudTotal.LIST_BE_PRODUCTO) Then


                    If objSolicitudTotal.LIST_BE_PRODUCTO.Count > 0 Then
                        Session("cllObjProductos") = objSolicitudTotal.LIST_BE_PRODUCTO
                    End If
                End If
                If objSolicitudTotal.LIST_BE_PRODUCTO_REF.Count > 0 Then
                    grvProdRef.DataSource = objSolicitudTotal.LIST_BE_PRODUCTO_REF
                    grvProdRef.DataBind()
                End If
            End If
        End If

        cargarMarca()
        cargarGridProductos()


        If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
            guardarArchivos()
        End If
        'addRowFileUpload()
    End Sub

    'Private Sub postUploadJS()
    '    Dim sb As New StringBuilder()
    '    sb.Append(
    'End Sub
    Private Sub cargarGridProductos()
        Dim cllObjProductos As New List(Of BE.clsBE_PRODUCTO)

        If Not IsNothing(Session("cllObjProductos")) Then
            cllObjProductos = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))
            gViewProd.DataSource = cllObjProductos
        Else
            Dim objBE_PRODUCTO As New BE.clsBE_PRODUCTO
            Dim list As New List(Of BE.clsBE_PRODUCTO)
            objBE_PRODUCTO.lngID = -1
            objBE_PRODUCTO.strMARCA = "-1"
            objBE_PRODUCTO.strNOMBRE = "-1"
            list.Add(objBE_PRODUCTO)
            gViewProd.DataSource = list
        End If
        gViewProd.DataBind()
    End Sub
    Private Sub guardarArchivos()
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)

        If FUAjaxProd.IsPosting Then
            ' Dim objRefProdRef As New BE.clsBE_REF_PRODUCTOS
            ' objRefProdRef.strRUTA_REF = clsUTL_AjaxFU.managePost(FUAjaxProd)
            clsUTL_AjaxFU.managePost(FUAjaxProd)
            '  objSolTtl.LIST_BE_PRODUCTO_REF.Add(objRefProdRef)
        End If
    End Sub
    Private Sub guardarArchivosPasoRefEmp(ByRef FUAjax As FileUploaderAJAX)
        Dim objSolTtl As BE.clsBE_SOLICITUDTOTAL = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
        Dim rutas As List(Of String)
        rutas = clsUTL_AjaxFU.historialFUAjax(FUAjax)
        If Not IsNothing(rutas) Then
            For Each ruta As String In rutas
                Dim objRefProdRef As New BE.clsBE_REF_PRODUCTOS
                objRefProdRef.strRUTA_REF = ruta
                objSolTtl.LIST_BE_PRODUCTO_REF.Add(objRefProdRef)
            Next
        End If
    End Sub

    Protected Sub gViewProd_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gViewProd.RowCommand
        Dim strCommand As String = e.CommandName
        Dim intIndex As Integer
        intIndex = CInt(e.CommandSource.parent.parent.rowindex)

        If strCommand = "btn_eliminar" Then

            If Not IsNothing(Session("cllObjProductos")) Then
                Dim cllProductos As New List(Of BE.clsBE_PRODUCTO)
                cllProductos = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))
                cllProductos.RemoveAt(intIndex)
                If cllProductos.Count = 0 Then
                    Session("cllObjProductos") = Nothing
                Else
                    Session("cllObjProductos") = cllProductos
                End If
                gViewProd.DataSource = cllProductos
                gViewProd.DataBind()
            End If
        ElseIf strCommand = "lnkEdit" Then

            ScriptManager.RegisterStartupScript(Me, Me.GetType, "", " $(this).modal({width:580, height:305, src:'addProd.aspx?id=" & intIndex & "'}).open();", True)
        End If
    End Sub

    Protected Sub btn_cancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btn_cancelar.Click
        Dim pasos As New Rastro
        Dim page As String = "Main.aspx"
        If Not IsNothing(Session(Konstantes.kstrPasos)) Then
            pasos = CType(Session(Konstantes.kstrPasos), Rastro)
            page = String.Concat("WFRM_Paso0", pasos.PASOS.Pop(), ".aspx")
        End If


        Response.Redirect(page)
    End Sub

    Private Function nameFile(ByVal ruta As String) As String
        Dim file As String = ""
        Dim seccion() As String
        If ruta <> "" Then
            seccion = ruta.Split("\")
            If seccion(seccion.Length - 1) <> "" Then
                file = seccion(seccion.Length - 1)
            End If
        End If
        Return file
    End Function

    Protected Sub grvProdRef_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grvProdRef.RowCommand
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        Dim listProdRef As New List(Of BE.clsBE_REF_PRODUCTOS)

        Dim index As Int32 = e.CommandSource.parent.parent.rowIndex
        Dim strCommand As String = e.CommandName

        If strCommand = "Eliminar" Then
            If Not IsNothing(Session(Konstantes.kstrSessionTotal)) Then
                objSolicitudTotal = CType(Session(Konstantes.kstrSessionTotal), BE.clsBE_SOLICITUDTOTAL)
                listProdRef = objSolicitudTotal.LIST_BE_PRODUCTO_REF
                listProdRef.RemoveAt(index)
                objSolicitudTotal.LIST_BE_PRODUCTO_REF = listProdRef
                grvProdRef.DataSource = listProdRef
                grvProdRef.DataBind()
            End If
        End If
    End Sub

    Private Sub cargarMarca()
        Dim cllObjBE As New List(Of BE.clsBE_PRODUCTO)

        If Not IsNothing(Session("cllObjProductosMarca")) Then
            cllObjBE = CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))
            grvMarca.DataSource = cllObjBE
        Else
            Dim objProducto As New BE.clsBE_PRODUCTO
            Dim list As New List(Of BE.clsBE_PRODUCTO)
            objProducto.strMARCA = "-1"
            list.Add(objProducto)
            grvMarca.DataSource = list
        End If

        grvMarca.DataBind()
    End Sub

    Protected Sub grvMarca_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles grvMarca.RowCommand
        Dim objSolicitudTotal As New BE.clsBE_SOLICITUDTOTAL
        Dim listProd As New List(Of BE.clsBE_PRODUCTO)
        Dim listProdDos As New List(Of BE.clsBE_PRODUCTO)
        Dim ints As New List(Of Int32)

        Dim index As Int32 = e.CommandSource.parent.parent.rowIndex
        Dim strCommand As String = e.CommandName

        If strCommand = "Eliminar" Then
            If Not IsNothing(Session("cllObjProductosMarca")) Then
                listProd = CType(Session("cllObjProductosMarca"), List(Of BE.clsBE_PRODUCTO))
                If Not IsNothing(Session("cllObjProductos")) Then
                    listProdDos = CType(Session("cllObjProductos"), List(Of BE.clsBE_PRODUCTO))

                    marca = listProd(index).strMARCA
                    listProdDos.RemoveAll(AddressOf Encuentra)

                    gViewProd.DataSource = listProdDos
                    gViewProd.DataBind()
                End If
                listProd.RemoveAt(index)

                If listProd.Count = 0 Then
                    Session("cllObjProductosMarca") = Nothing
                End If

                grvMarca.DataSource = listProd
                grvMarca.DataBind()
            End If

        End If
    End Sub

    Private Shared Function Encuentra(ByVal obj As BE.clsBE_PRODUCTO) As Boolean
        Return obj.strMARCA = marca
    End Function

    Protected Sub gViewProd_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles gViewProd.RowDataBound
        Dim prod As MP.DW.BL.BE.clsBE_PRODUCTO

        prod = CType(e.Row.DataItem, MP.DW.BL.BE.clsBE_PRODUCTO)

        If e.Row.RowType = DataControlRowType.DataRow Then

            If prod.lngID = -1 Or prod.lngID = 0 Then
                e.Row.Visible = False
            End If

           
        End If
    End Sub

    Protected Sub grvMarca_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvMarca.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow And e.Row.Cells(0).Text = "-1" Then
            e.Row.Visible = False
        Else
            Dim lnk As HyperLink = e.Row.Cells(1).FindControl("lnkMarca")
            If Not IsNothing(lnk) Then
                lnk.Text = nombreLink(lnk.Text)
            End If
        End If
    End Sub
    Private Function nombreLink(ByVal ruta As String) As String
        Dim link() As String
        If ruta <> "" Then
            link = ruta.Split("/")
            Return link(link.Length - 1)
        End If
        Return ""
    End Function

    Protected Sub grvProdRef_RowDataBound(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewRowEventArgs) Handles grvProdRef.RowDataBound
        If e.Row.RowType = DataControlRowType.DataRow Then
            Dim lnk As HyperLink = e.Row.Cells(0).FindControl("lnkRF")
            lnk.Text = nombreLink(lnk.Text)
        End If
    End Sub
End Class
