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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla AMBITOUSO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_AMBITOUSOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function InsertarAMBITOUSO(ByVal oLstAMBITOUSO As List(Of clsBE_AMBITOUSO)) As Boolean
            For Each oAMBITOUSO As clsBE_AMBITOUSO In oLstAMBITOUSO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_Insert")
                    Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oAMBITOUSO.lngIDSOLICITUD)
                    Me.DataBase.AddInParameter(command, "@pIDEVENTO", DbType.Int64, oAMBITOUSO.lngIDEVENTO)
                    Me.DataBase.AddInParameter(command, "@pIDPUBLICO", DbType.Int32, oAMBITOUSO.intIDPUBLICO)
                    Me.DataBase.AddInParameter(command, "@pIDDETPUBLICO", DbType.Int32, oAMBITOUSO.intIDDETPUBLICO)
                    Me.DataBase.AddInParameter(command, "@pLISTADETALLADA", DbType.String, oAMBITOUSO.strLISTADETALLADA)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAMBITOUSO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAMBITOUSO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAMBITOUSO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAMBITOUSO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAMBITOUSO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAMBITOUSO.strAUD_USR_GENERICO)
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
		''' Proposito: Metodo de Modificación de datos AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarAMBITOUSO(ByVal oLstAMBITOUSO As List(Of clsBE_AMBITOUSO)) As Boolean
			For Each oAMBITOUSO As clsBE_AMBITOUSO In oLstAMBITOUSO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oAMBITOUSO.lngID)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oAMBITOUSO.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pIDEVENTO", DbType.Int64, oAMBITOUSO.lngIDEVENTO)
					Me.DataBase.AddInParameter(command, "@pIDPUBLICO", DbType.Int32, oAMBITOUSO.intIDPUBLICO)
					Me.DataBase.AddInParameter(command, "@pIDDETPUBLICO", DbType.Int32, oAMBITOUSO.intIDDETPUBLICO)
					Me.DataBase.AddInParameter(command, "@pLISTADETALLADA", DbType.String, oAMBITOUSO.strLISTADETALLADA)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAMBITOUSO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAMBITOUSO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAMBITOUSO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAMBITOUSO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAMBITOUSO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAMBITOUSO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarAMBITOUSO(ByVal oLstAMBITOUSO As List(Of clsBE_AMBITOUSO)) As Boolean
			For Each oAMBITOUSO As clsBE_AMBITOUSO In oLstAMBITOUSO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oAMBITOUSO.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAMBITOUSO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAMBITOUSO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAMBITOUSO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAMBITOUSO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAMBITOUSO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAMBITOUSO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado AMBITOUSO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_AMBITOUSORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla AMBITOUSO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerAMBITOUSO(ByVal pAMBITOUSO As clsBE_AMBITOUSO) As clsBE_AMBITOUSO
			Dim oAMBITOUSO As clsBE_AMBITOUSO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pAMBITOUSO.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oAMBITOUSO = Me.ReadItem(reader)
				End Using
			End Using
			Return oAMBITOUSO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_AMBITOUSO
			Dim item As New clsBE_AMBITOUSO
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.lngIDEVENTO = iif(Convert.IsDBNull(reader("IDEVENTO")),0,CLngMP(reader("IDEVENTO")))
				item.intIDPUBLICO = iif(Convert.IsDBNull(reader("IDPUBLICO")),0,CIntMP(reader("IDPUBLICO")))
                item.intIDDETPUBLICO = IIf(Convert.IsDBNull(reader("IDDETPUBLICO")), 0, CIntMP(reader("IDDETPUBLICO")))
                item.strPUBLICO = IIf(Convert.IsDBNull(reader("PUBLICO")), 0, CIntMP(reader("PUBLICO")))
                item.strDETPUBLICO = IIf(Convert.IsDBNull(reader("DETPUBLICO")), 0, CIntMP(reader("DETPUBLICO")))
				item.strLISTADETALLADA = iif(Convert.IsDBNull(reader("LISTADETALLADA")),String.Empty,CStrMP(reader("LISTADETALLADA")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaAMBITOUSO() As List(Of clsBE_AMBITOUSO)
			Dim olstAMBITOUSO As New List(Of clsBE_AMBITOUSO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstAMBITOUSO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstAMBITOUSO
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de todos los registros de la entidad: AMBITOUSO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaAMBITOUSOByIDSol(ByVal idsol As Long) As List(Of clsBE_AMBITOUSO)
            Dim olstAMBITOUSO As New List(Of clsBE_AMBITOUSO)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_GetByIDSOL")
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, idsol)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    olstAMBITOUSO = Me.ReadListItem(reader)
                End Using
            End Using
            Return olstAMBITOUSO
        End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_AMBITOUSO)
			Dim result As List(Of  clsBE_AMBITOUSO) = New List(Of clsBE_AMBITOUSO)
			While (reader.Read())
				dim item as new clsBE_AMBITOUSO
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.lngIDEVENTO = iif(Convert.IsDBNull(reader("IDEVENTO")),0,CLngMP(reader("IDEVENTO")))
				item.intIDPUBLICO = iif(Convert.IsDBNull(reader("IDPUBLICO")),0,CIntMP(reader("IDPUBLICO")))
                item.intIDDETPUBLICO = IIf(Convert.IsDBNull(reader("IDDETPUBLICO")), 0, CIntMP(reader("IDDETPUBLICO")))
                item.strPUBLICO = IIf(Convert.IsDBNull(reader("PUBLICO")), "", CstrMP(reader("PUBLICO")))
                item.strDETPUBLICO = IIf(Convert.IsDBNull(reader("DETPUBLICO")), "", CstrMP(reader("DETPUBLICO")))
                item.strLISTADETALLADA = IIf(Convert.IsDBNull(reader("LISTADETALLADA")), String.Empty, CstrMP(reader("LISTADETALLADA")))

				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad AMBITOUSO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaAMBITOUSO_Paged(ByVal pAMBITOUSO As clsBE_AMBITOUSO) As List(Of clsBE_AMBITOUSO)
			Dim intCount As Int32 = 0
			Dim olstAMBITOUSO As New List(Of clsBE_AMBITOUSO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pAMBITOUSO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pAMBITOUSO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pAMBITOUSO.lngID)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pAMBITOUSO.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pIDEVENTO", DbType.Int64, pAMBITOUSO.lngIDEVENTO)
				Me.DataBase.AddInParameter(command, "@pIDPUBLICO", DbType.Int32, pAMBITOUSO.intIDPUBLICO)
				Me.DataBase.AddInParameter(command, "@pIDDETPUBLICO", DbType.Int32, pAMBITOUSO.intIDDETPUBLICO)
				Me.DataBase.AddInParameter(command, "@pLISTADETALLADA", DbType.String, pAMBITOUSO.strLISTADETALLADA)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstAMBITOUSO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstAMBITOUSO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_AMBITOUSO)
			Dim result As List(Of  clsBE_AMBITOUSO) = New List(Of clsBE_AMBITOUSO)
			While (reader.Read())
				dim item as new clsBE_AMBITOUSO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.lngIDEVENTO = iif(Convert.IsDBNull(reader("IDEVENTO")),0,CLngMP(reader("IDEVENTO")))
				item.intIDPUBLICO = iif(Convert.IsDBNull(reader("IDPUBLICO")),0,CIntMP(reader("IDPUBLICO")))
                item.intIDDETPUBLICO = IIf(Convert.IsDBNull(reader("IDDETPUBLICO")), 0, CIntMP(reader("IDDETPUBLICO")))
                item.strPUBLICO = IIf(Convert.IsDBNull(reader("PUBLICO")), 0, CIntMP(reader("PUBLICO")))
                item.strDETPUBLICO = IIf(Convert.IsDBNull(reader("DETPUBLICO")), 0, CIntMP(reader("DETPUBLICO")))
				item.strLISTADETALLADA = iif(Convert.IsDBNull(reader("LISTADETALLADA")),String.Empty,CStrMP(reader("LISTADETALLADA")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTAMBITOUSO() As Datatable
			Dim oDTAMBITOUSO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_AMBITOUSO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTAMBITOUSO
		End Function
        Public Function LeerListaToDTAMBITOUSO(ByVal idsol As Long) As DataTable
            Dim oDTAMBITOUSO As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_GetByIDSOL")
                Me.DataBase.AddInParameter(command, "@IDSOL", DbType.Int64, idsol)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTAMBITOUSO
        End Function
	End Class
#End Region
End Namespace


