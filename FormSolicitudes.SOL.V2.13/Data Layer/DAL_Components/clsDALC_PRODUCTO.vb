Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data
Imports MP.DW.BL.BE
Imports MP.DW.UTL.clsUTL_Helpers
Imports MP.DW.SC

Namespace MP.DW.DAL.DALC
#Region "Clase Escritura" 
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PRODUCTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_PRODUCTOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function InsertarPRODUCTO(ByRef oLstPRODUCTO As List(Of clsBE_PRODUCTO)) As Boolean
            Dim opLstPRODUCTO As New List(Of clsBE_PRODUCTO)

            For Each oPRODUCTO As clsBE_PRODUCTO In oLstPRODUCTO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_Insert")
                    Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oPRODUCTO.lngIDSOLICITUD)
                    Me.DataBase.AddInParameter(command, "@pMARCA", DbType.String, oPRODUCTO.strMARCA)
                    Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oPRODUCTO.strNOMBRE)
                    Me.DataBase.AddInParameter(command, "@pPORC_FABRICACION", DbType.Double, oPRODUCTO.dblPORC_FABRICACION)
                    Me.DataBase.AddInParameter(command, "@pPORC_UNIDVENC", DbType.Double, oPRODUCTO.dblPORC_UNIDVENC)
                    Me.DataBase.AddInParameter(command, "@pPORC_VALORVENTA", DbType.Double, oPRODUCTO.dblPORC_VALORVENTA)
                    Me.DataBase.AddInParameter(command, "@pRUTAREFERENCIAS", DbType.String, oPRODUCTO.strRUTAREFERENCIAS)
                    Me.DataBase.AddInParameter(command, "@pRUTAINDECOPI", DbType.String, oPRODUCTO.strRUTAREGISTROINDECOPI)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPRODUCTO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPRODUCTO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPRODUCTO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPRODUCTO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPRODUCTO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPRODUCTO.strAUD_USR_GENERICO)

                    Try
                        Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                            Dim dalcRO As New clsDALC_PRODUCTORO
                            oPRODUCTO = dalcRO.ReadItem(reader)
                            opLstPRODUCTO.Add(oPRODUCTO)
                        End Using
                    Catch ex As Exception
                        Throw ex
                        Return False
                    End Try


                End Using
            Next

            oLstPRODUCTO = opLstPRODUCTO
            Return True
        End Function

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Modificación de datos PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarPRODUCTO(ByVal oLstPRODUCTO As List(Of clsBE_PRODUCTO)) As Boolean
			For Each oPRODUCTO As clsBE_PRODUCTO In oLstPRODUCTO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oPRODUCTO.lngID)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oPRODUCTO.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pMARCA", DbType.String, oPRODUCTO.strMARCA)
					Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oPRODUCTO.strNOMBRE)
					Me.DataBase.AddInParameter(command, "@pPORC_FABRICACION", DbType.Double, oPRODUCTO.dblPORC_FABRICACION)
					Me.DataBase.AddInParameter(command, "@pPORC_UNIDVENC", DbType.Double, oPRODUCTO.dblPORC_UNIDVENC)
					Me.DataBase.AddInParameter(command, "@pPORC_VALORVENTA", DbType.Double, oPRODUCTO.dblPORC_VALORVENTA)
                    Me.DataBase.AddInParameter(command, "@pRUTAREFERENCIAS", DbType.String, oPRODUCTO.strRUTAREFERENCIAS)
                    Me.DataBase.AddInParameter(command, "@pRUTAINDECOPI", DbType.String, oPRODUCTO.strRUTAREGISTROINDECOPI)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPRODUCTO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPRODUCTO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPRODUCTO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPRODUCTO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPRODUCTO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPRODUCTO.strAUD_USR_GENERICO) 
					Try
						Me.DataBase.ExecuteNonQuery(command)
					Catch ex As Exception
						Throw ex
						Return False
					End Try
				End Using
			Next
			Return True
		End Function

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito:  Metodo de Elimación PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarPRODUCTO(ByVal oLstPRODUCTO As List(Of clsBE_PRODUCTO)) As Boolean
			For Each oPRODUCTO As clsBE_PRODUCTO In oLstPRODUCTO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oPRODUCTO.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPRODUCTO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPRODUCTO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPRODUCTO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPRODUCTO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPRODUCTO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPRODUCTO.strAUD_USR_GENERICO) 
					Try
						Me.DataBase.ExecuteNonQuery(command)
					Catch ex As Exception
						Throw ex
						Return False
					End Try
				End Using
			Next
			Return True
		End Function

	End Class
#End Region

#Region "Clase Lectura" 
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Obtiene los valores de la tabla Abonado PRODUCTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_PRODUCTORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla PRODUCTO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerPRODUCTO(ByVal pPRODUCTO As clsBE_PRODUCTO) As clsBE_PRODUCTO
			Dim oPRODUCTO As clsBE_PRODUCTO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pPRODUCTO.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oPRODUCTO = Me.ReadItem(reader)
				End Using
			End Using
			Return oPRODUCTO
		End Function

        Public Function ReadItem(ByVal reader As IDataReader) As clsBE_PRODUCTO
            Dim item As New clsBE_PRODUCTO
            While (reader.Read())
                item.lngID = iif(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")), 0, CLngMP(reader("IDSOLICITUD")))
                item.strMARCA = iif(Convert.IsDBNull(reader("MARCA")), String.Empty, CStrMP(reader("MARCA")))
                item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")), String.Empty, CStrMP(reader("NOMBRE")))
                item.dblPORC_FABRICACION = iif(Convert.IsDBNull(reader("PORC_FABRICACION")), 0, CDblMP(reader("PORC_FABRICACION")))
                item.dblPORC_UNIDVENC = iif(Convert.IsDBNull(reader("PORC_UNIDVENC")), 0, CDblMP(reader("PORC_UNIDVENC")))
                item.dblPORC_VALORVENTA = iif(Convert.IsDBNull(reader("PORC_VALORVENTA")), 0, CDblMP(reader("PORC_VALORVENTA")))
                item.strRUTAREFERENCIAS = IIf(Convert.IsDBNull(reader("RUTAREFERENCIAS")), String.Empty, CstrMP(reader("RUTAREFERENCIAS")))
                item.strRUTAREGISTROINDECOPI = IIf(Convert.IsDBNull(reader("RUTA_REGISTROINDECOPI")), String.Empty, CstrMP(reader("RUTA_REGISTROINDECOPI")))
            End While
            Return item
        End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaPRODUCTO() As List(Of clsBE_PRODUCTO)
			Dim olstPRODUCTO As New List(Of clsBE_PRODUCTO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstPRODUCTO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstPRODUCTO
        End Function


        Public Function LeerListaPRODUCTOSOL(ByVal idSol As Long) As List(Of clsBE_PRODUCTO)
            Dim olstPRODUCTO As New List(Of clsBE_PRODUCTO)
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_GetBySOL")
                Me.DataBase.AddInParameter(command, "@pIdSol", DbType.Int64, idSol)

                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    olstPRODUCTO = Me.ReadListItem(reader)
                End Using
            End Using
            Return olstPRODUCTO
        End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_PRODUCTO)
			Dim result As List(Of  clsBE_PRODUCTO) = New List(Of clsBE_PRODUCTO)
			While (reader.Read())
				dim item as new clsBE_PRODUCTO
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strMARCA = iif(Convert.IsDBNull(reader("MARCA")),String.Empty,CStrMP(reader("MARCA")))
				item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")),String.Empty,CStrMP(reader("NOMBRE")))
				item.dblPORC_FABRICACION = iif(Convert.IsDBNull(reader("PORC_FABRICACION")),0,CDblMP(reader("PORC_FABRICACION")))
				item.dblPORC_UNIDVENC = iif(Convert.IsDBNull(reader("PORC_UNIDVENC")),0,CDblMP(reader("PORC_UNIDVENC")))
				item.dblPORC_VALORVENTA = iif(Convert.IsDBNull(reader("PORC_VALORVENTA")),0,CDblMP(reader("PORC_VALORVENTA")))
                item.strRUTAREFERENCIAS = IIf(Convert.IsDBNull(reader("RUTAREFERENCIAS")), String.Empty, CstrMP(reader("RUTAREFERENCIAS")))
                item.strRUTAREGISTROINDECOPI = IIf(Convert.IsDBNull(reader("RUTA_REGISTROINDECOPI")), String.Empty, CstrMP(reader("RUTA_REGISTROINDECOPI")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad PRODUCTO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaPRODUCTO_Paged(ByVal pPRODUCTO As clsBE_PRODUCTO) As List(Of clsBE_PRODUCTO)
			Dim intCount As Int32 = 0
			Dim olstPRODUCTO As New List(Of clsBE_PRODUCTO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pPRODUCTO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pPRODUCTO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pPRODUCTO.lngID)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pPRODUCTO.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pMARCA", DbType.String, pPRODUCTO.strMARCA)
				Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, pPRODUCTO.strNOMBRE)
				Me.DataBase.AddInParameter(command, "@pPORC_FABRICACION", DbType.Double, pPRODUCTO.dblPORC_FABRICACION)
				Me.DataBase.AddInParameter(command, "@pPORC_UNIDVENC", DbType.Double, pPRODUCTO.dblPORC_UNIDVENC)
				Me.DataBase.AddInParameter(command, "@pPORC_VALORVENTA", DbType.Double, pPRODUCTO.dblPORC_VALORVENTA)
				Me.DataBase.AddInParameter(command, "@pRUTAREFERENCIAS", DbType.String, pPRODUCTO.strRUTAREFERENCIAS)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstPRODUCTO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstPRODUCTO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_PRODUCTO)
			Dim result As List(Of  clsBE_PRODUCTO) = New List(Of clsBE_PRODUCTO)
			While (reader.Read())
				dim item as new clsBE_PRODUCTO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strMARCA = iif(Convert.IsDBNull(reader("MARCA")),String.Empty,CStrMP(reader("MARCA")))
				item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")),String.Empty,CStrMP(reader("NOMBRE")))
				item.dblPORC_FABRICACION = iif(Convert.IsDBNull(reader("PORC_FABRICACION")),0,CDblMP(reader("PORC_FABRICACION")))
				item.dblPORC_UNIDVENC = iif(Convert.IsDBNull(reader("PORC_UNIDVENC")),0,CDblMP(reader("PORC_UNIDVENC")))
				item.dblPORC_VALORVENTA = iif(Convert.IsDBNull(reader("PORC_VALORVENTA")),0,CDblMP(reader("PORC_VALORVENTA")))
                item.strRUTAREFERENCIAS = IIf(Convert.IsDBNull(reader("RUTAREFERENCIAS")), String.Empty, CstrMP(reader("RUTAREFERENCIAS")))
                item.strRUTAREGISTROINDECOPI = IIf(Convert.IsDBNull(reader("RUTA_REGISTROINDECOPI")), String.Empty, CstrMP(reader("RUTA_REGISTROINDECOPI")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS PRODUCTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTPRODUCTO() As Datatable
			Dim oDTPRODUCTO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTPRODUCTO
        End Function


        Public Function LeerListaToDTPRODUCTOSOL(ByVal idSol As Long) As DataTable
            Dim oDTPRODUCTO As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PRODUCTO_GetBySOL")
                Me.DataBase.AddInParameter(command, "@pIdSol", DbType.Int64, idSol)

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTPRODUCTO
        End Function

	End Class
#End Region
End Namespace


