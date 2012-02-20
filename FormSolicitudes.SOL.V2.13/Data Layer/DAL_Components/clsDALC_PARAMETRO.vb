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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla PARAMETRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_PARAMETROTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarPARAMETRO(ByVal oLstPARAMETRO As List(Of clsBE_PARAMETRO)) As Boolean
			For Each oPARAMETRO As clsBE_PARAMETRO In oLstPARAMETRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_Insert")
					Me.DataBase.AddInParameter(command, "@pDESCPARAM", DbType.String, oPARAMETRO.strDESCPARAM)
					Me.DataBase.AddInParameter(command, "@pCODMAESTRO", DbType.Int32, oPARAMETRO.intCODMAESTRO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPARAMETRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPARAMETRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPARAMETRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPARAMETRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPARAMETRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPARAMETRO.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarPARAMETRO(ByVal oLstPARAMETRO As List(Of clsBE_PARAMETRO)) As Boolean
			For Each oPARAMETRO As clsBE_PARAMETRO In oLstPARAMETRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oPARAMETRO.intID)
					Me.DataBase.AddInParameter(command, "@pDESCPARAM", DbType.String, oPARAMETRO.strDESCPARAM)
					Me.DataBase.AddInParameter(command, "@pCODMAESTRO", DbType.Int32, oPARAMETRO.intCODMAESTRO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPARAMETRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPARAMETRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPARAMETRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPARAMETRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPARAMETRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPARAMETRO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarPARAMETRO(ByVal oLstPARAMETRO As List(Of clsBE_PARAMETRO)) As Boolean
			For Each oPARAMETRO As clsBE_PARAMETRO In oLstPARAMETRO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oPARAMETRO.intID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oPARAMETRO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oPARAMETRO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oPARAMETRO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oPARAMETRO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oPARAMETRO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oPARAMETRO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado PARAMETRO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_PARAMETRORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla PARAMETRO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerPARAMETRO(ByVal pPARAMETRO As clsBE_PARAMETRO) As clsBE_PARAMETRO
			Dim oPARAMETRO As clsBE_PARAMETRO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pPARAMETRO.intID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oPARAMETRO = Me.ReadItem(reader)
				End Using
			End Using
			Return oPARAMETRO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_PARAMETRO
			Dim item As New clsBE_PARAMETRO
			While (reader.Read())
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCPARAM = iif(Convert.IsDBNull(reader("DESCPARAM")),String.Empty,CStrMP(reader("DESCPARAM")))
				item.intCODMAESTRO = iif(Convert.IsDBNull(reader("CODMAESTRO")),0,CIntMP(reader("CODMAESTRO")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaPARAMETRO() As List(Of clsBE_PARAMETRO)
			Dim olstPARAMETRO As New List(Of clsBE_PARAMETRO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstPARAMETRO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstPARAMETRO
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_PARAMETRO)
			Dim result As List(Of  clsBE_PARAMETRO) = New List(Of clsBE_PARAMETRO)
			While (reader.Read())
				dim item as new clsBE_PARAMETRO
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCPARAM = iif(Convert.IsDBNull(reader("DESCPARAM")),String.Empty,CStrMP(reader("DESCPARAM")))
				item.intCODMAESTRO = iif(Convert.IsDBNull(reader("CODMAESTRO")),0,CIntMP(reader("CODMAESTRO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad PARAMETRO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaPARAMETRO_Paged(ByVal pPARAMETRO As clsBE_PARAMETRO) As List(Of clsBE_PARAMETRO)
			Dim intCount As Int32 = 0
			Dim olstPARAMETRO As New List(Of clsBE_PARAMETRO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pPARAMETRO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pPARAMETRO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pPARAMETRO.intID)
				Me.DataBase.AddInParameter(command, "@pDESCPARAM", DbType.String, pPARAMETRO.strDESCPARAM)
				Me.DataBase.AddInParameter(command, "@pCODMAESTRO", DbType.Int32, pPARAMETRO.intCODMAESTRO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstPARAMETRO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstPARAMETRO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_PARAMETRO)
			Dim result As List(Of  clsBE_PARAMETRO) = New List(Of clsBE_PARAMETRO)
			While (reader.Read())
				dim item as new clsBE_PARAMETRO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strDESCPARAM = iif(Convert.IsDBNull(reader("DESCPARAM")),String.Empty,CStrMP(reader("DESCPARAM")))
				item.intCODMAESTRO = iif(Convert.IsDBNull(reader("CODMAESTRO")),0,CIntMP(reader("CODMAESTRO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS PARAMETRO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTPARAMETRO() As Datatable
			Dim oDTPARAMETRO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_PARAMETRO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTPARAMETRO
		End Function

	End Class
#End Region
End Namespace


