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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla MAESTRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_MAESTROTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarMAESTRO(ByVal oLstMAESTRO As List(Of clsBE_MAESTRO)) As Boolean
			For Each oMAESTRO As clsBE_MAESTRO In oLstMAESTRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_Insert")
					Me.DataBase.AddInParameter(command, "@pDESCMAESTRO", DbType.String, oMAESTRO.strDESCMAESTRO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oMAESTRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oMAESTRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oMAESTRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oMAESTRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oMAESTRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oMAESTRO.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarMAESTRO(ByVal oLstMAESTRO As List(Of clsBE_MAESTRO)) As Boolean
			For Each oMAESTRO As clsBE_MAESTRO In oLstMAESTRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oMAESTRO.intID)
					Me.DataBase.AddInParameter(command, "@pDESCMAESTRO", DbType.String, oMAESTRO.strDESCMAESTRO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oMAESTRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oMAESTRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oMAESTRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oMAESTRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oMAESTRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oMAESTRO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarMAESTRO(ByVal oLstMAESTRO As List(Of clsBE_MAESTRO)) As Boolean
			For Each oMAESTRO As clsBE_MAESTRO In oLstMAESTRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oMAESTRO.intID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oMAESTRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oMAESTRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oMAESTRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oMAESTRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oMAESTRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oMAESTRO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado MAESTRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_MAESTRORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla MAESTRO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerMAESTRO(ByVal pMAESTRO As clsBE_MAESTRO) As clsBE_MAESTRO
			Dim oMAESTRO As clsBE_MAESTRO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pMAESTRO.intID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oMAESTRO = Me.ReadItem(reader)
				End Using
			End Using
			Return oMAESTRO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_MAESTRO
			Dim item As New clsBE_MAESTRO
			While (reader.Read())
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCMAESTRO = iif(Convert.IsDBNull(reader("DESCMAESTRO")),String.Empty,CStrMP(reader("DESCMAESTRO")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaMAESTRO() As List(Of clsBE_MAESTRO)
			Dim olstMAESTRO As New List(Of clsBE_MAESTRO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstMAESTRO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstMAESTRO
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_MAESTRO)
			Dim result As List(Of  clsBE_MAESTRO) = New List(Of clsBE_MAESTRO)
			While (reader.Read())
				dim item as new clsBE_MAESTRO
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCMAESTRO = iif(Convert.IsDBNull(reader("DESCMAESTRO")),String.Empty,CStrMP(reader("DESCMAESTRO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad MAESTRO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaMAESTRO_Paged(ByVal pMAESTRO As clsBE_MAESTRO) As List(Of clsBE_MAESTRO)
			Dim intCount As Int32 = 0
			Dim olstMAESTRO As New List(Of clsBE_MAESTRO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pMAESTRO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pMAESTRO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pMAESTRO.intID)
				Me.DataBase.AddInParameter(command, "@pDESCMAESTRO", DbType.String, pMAESTRO.strDESCMAESTRO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstMAESTRO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstMAESTRO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_MAESTRO)
			Dim result As List(Of  clsBE_MAESTRO) = New List(Of clsBE_MAESTRO)
			While (reader.Read())
				dim item as new clsBE_MAESTRO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCMAESTRO = iif(Convert.IsDBNull(reader("DESCMAESTRO")),String.Empty,CStrMP(reader("DESCMAESTRO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS MAESTRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTMAESTRO() As Datatable
			Dim oDTMAESTRO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_MAESTRO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTMAESTRO
		End Function

	End Class
#End Region
End Namespace


