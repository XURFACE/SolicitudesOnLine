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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DET_USO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_DET_USOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarDET_USO(ByVal oLstDET_USO As List(Of clsBE_DET_USO)) As Boolean
			For Each oDET_USO As clsBE_DET_USO In oLstDET_USO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_Insert")
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oDET_USO.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oDET_USO.strTIPOLIC)
                    Me.DataBase.AddInParameter(command, "@pSUBTIPO", DbType.String, oDET_USO.intSUBTIPO)
					Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oDET_USO.strDESCRIPCION)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDET_USO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDET_USO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDET_USO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDET_USO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDET_USO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDET_USO.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarDET_USO(ByVal oLstDET_USO As List(Of clsBE_DET_USO)) As Boolean
			For Each oDET_USO As clsBE_DET_USO In oLstDET_USO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oDET_USO.lngID)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oDET_USO.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oDET_USO.strTIPOLIC)
                    Me.DataBase.AddInParameter(command, "@pSUBTIPO", DbType.String, oDET_USO.intSUBTIPO)
					Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oDET_USO.strDESCRIPCION)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDET_USO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDET_USO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDET_USO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDET_USO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDET_USO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDET_USO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarDET_USO(ByVal oLstDET_USO As List(Of clsBE_DET_USO)) As Boolean
			For Each oDET_USO As clsBE_DET_USO In oLstDET_USO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oDET_USO.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDET_USO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDET_USO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDET_USO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDET_USO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDET_USO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDET_USO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado DET_USO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_DET_USORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla DET_USO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerDET_USO(ByVal pDET_USO As clsBE_DET_USO) As clsBE_DET_USO
			Dim oDET_USO As clsBE_DET_USO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pDET_USO.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oDET_USO = Me.ReadItem(reader)
				End Using
			End Using
			Return oDET_USO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_DET_USO
			Dim item As New clsBE_DET_USO
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")),String.Empty,CStrMP(reader("TIPOLIC")))
                item.intSUBTIPO = IIf(Convert.IsDBNull(reader("SUBTIPO")), String.Empty, CstrMP(reader("SUBTIPO")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaDET_USO() As List(Of clsBE_DET_USO)
			Dim olstDET_USO As New List(Of clsBE_DET_USO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstDET_USO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstDET_USO
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de todos los registros de la entidad: DET_USO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaDET_USOByIdSol(ByVal xlngIdSol As Long) As List(Of clsBE_DET_USO)
            Dim olstDET_USO As New List(Of clsBE_DET_USO)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_SelLstbyIdSOL")
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, xlngIdSol)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    olstDET_USO = Me.ReadListItem(reader)
                End Using
            End Using
            Return olstDET_USO
        End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_DET_USO)
			Dim result As List(Of  clsBE_DET_USO) = New List(Of clsBE_DET_USO)
			While (reader.Read())
				dim item as new clsBE_DET_USO
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")),String.Empty,CStrMP(reader("TIPOLIC")))
                item.intSUBTIPO = IIf(Convert.IsDBNull(reader("SUBTIPO")), String.Empty, CstrMP(reader("SUBTIPO")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad DET_USO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaDET_USO_Paged(ByVal pDET_USO As clsBE_DET_USO) As List(Of clsBE_DET_USO)
			Dim intCount As Int32 = 0
			Dim olstDET_USO As New List(Of clsBE_DET_USO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pDET_USO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pDET_USO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pDET_USO.lngID)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pDET_USO.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, pDET_USO.strTIPOLIC)
				Me.DataBase.AddInParameter(command, "@pSUBTIPO", DbType.Int32, pDET_USO.intSUBTIPO)
				Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, pDET_USO.strDESCRIPCION)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstDET_USO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstDET_USO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_DET_USO)
			Dim result As List(Of  clsBE_DET_USO) = New List(Of clsBE_DET_USO)
			While (reader.Read())
				dim item as new clsBE_DET_USO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")),String.Empty,CStrMP(reader("TIPOLIC")))
				item.intSUBTIPO = iif(Convert.IsDBNull(reader("SUBTIPO")),0,CIntMP(reader("SUBTIPO")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTDET_USO() As Datatable
			Dim oDTDET_USO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DET_USO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTDET_USO
		End Function

	End Class
#End Region
End Namespace


