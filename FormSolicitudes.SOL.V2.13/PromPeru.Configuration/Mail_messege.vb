Imports MP.DW.BL
Public Class Mail_messege
    Public Shared Function BodyMessege(ByVal xobjEmpresa As BE.clsBE_EMPRESA, ByVal xobjSolicitud As BE.clsBE_SOLICITUD) As String
        Dim strMsg As New Text.StringBuilder
        strMsg.Append("Estimado(a) Sr(a). " + xobjEmpresa.strNOMPERCONTACTO + vbNewLine + vbNewLine)
        strMsg.Append("Me da mucho gusto informarle que luego de evaluar su solicitud para la autorización de uso de la Marca País Perú, hemos procedido a emitir ")
        strMsg.Append("el certificado para uso " & xobjSolicitud.strTIPOLIC & ". " + xobjEmpresa.strRAZONSOCIAL + " es ahora Licenciataria de la marca país." + vbNewLine)
        strMsg.Append("{0}" + vbNewLine)
        strMsg.Append("Recuerde que todo diseño debe ser aprobado por la Dirección de Promoción de Imagen País previamente antes de ser impreso." + vbNewLine)
        strMsg.Append("Este proceso ya puede ser realizado a partir de la fecha a través del Sistema de Solicitudes En Línea." + vbNewLine)
        strMsg.Append("Primero: Ingrese a su cuenta" + vbNewLine)
        strMsg.Append("Segundo: Elija la opción 'Mis Solicitudes'" + vbNewLine)
        strMsg.Append("Tercera: Elija la solicitud y haga clic en el botón 'Agregar aplicación'" + vbNewLine)
        strMsg.Append("Puede descargar el logo de la Marca País Perú en Ilustrator, desde el Link siguiente http://www.peru.info/solicitudes/client/LOGOMARCAPAIS.ai" + vbNewLine + vbNewLine) ''<a href=""""#""""></a>
        strMsg.Append("Puede descargar el manual de uso del siguiente link http://www.peru.info/solicitudes/client/Manual_de_Uso_Licenciatarios.pdf" + vbNewLine)
        strMsg.Append("Quedamos a la espera de sus comentarios y que nos indique cuando vendrán a recoger su certificado al email marcapais@promperu.gob.pe." + vbNewLine)
        strMsg.Append("Saludos Cordiales" + vbNewLine)
        strMsg.Append("PROMPERU")

        Dim strMsgDetSol As New Text.StringBuilder
        strMsgDetSol.Append("El uso " + xobjSolicitud.strTIPOLIC + "será en: ")
        Dim objBCDetUSO As New BC.clsBC_DET_USORO
        objBCDetUSO.oBEDET_USO.lngIDSOLICITUD = xobjSolicitud.lngID
        objBCDetUSO.LeerListaDET_USO_ByIdSol()

        Dim objBCPRODS As New BC.clsBC_PRODUCTORO
        objBCPRODS.LeerListaPRODUCTOSOL(xobjSolicitud.lngID)
        Dim strMarca As String = ""
        For Each objProds As BE.clsBE_PRODUCTO In objBCPRODS.LstPRODUCTO
            If strMarca <> objProds.strMARCA Then
                strMarca += objProds.strMARCA + ", "
            End If
        Next


        For Each objDetUso As BE.clsBE_DET_USO In objBCDetUSO.LstDET_USO
            strMsgDetSol.Append(objDetUso.intSUBTIPO.ToString + "(" + objDetUso.strDESCRIPCION + "), ")
        Next
        strMsgDetSol.Append("." & vbNewLine & "Los usos No Permitidos son en: Tarjetas personales, firmas de email, boletas o facturas.")
        If Not String.IsNullOrEmpty(strMarca) Then
            strMarca = strMarca.Substring(0, strMarca.Length - 2)
            strMsgDetSol.Append(" de los productos de la(s) marca(s) " + strMarca)
        End If

        Return String.Format(strMsg.ToString, strMsgDetSol.ToString)
    End Function
End Class
