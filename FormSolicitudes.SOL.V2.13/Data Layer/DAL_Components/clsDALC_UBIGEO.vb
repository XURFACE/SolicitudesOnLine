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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla UBIGEO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_UBIGEOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarUBIGEO(ByVal oLstUBIGEO As List(Of clsBE_UBIGEO)) As Boolean
			For Each oUBIGEO As clsBE_UBIGEO In oLstUBIGEO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_Insert")
					Me.DataBase.AddInParameter(command, "@pCOD_UBIGEO", DbType.String, oUBIGEO.strCOD_UBIGEO)
					Me.DataBase.AddInParameter(command, "@pCOD_TOTAL", DbType.String, oUBIGEO.strCOD_TOTAL)
					Me.DataBase.AddInParameter(command, "@pNOMBRE_LARGO", DbType.String, oUBIGEO.strNOMBRE_LARGO)
					Me.DataBase.AddInParameter(command, "@pNOMBRE_CORTO", DbType.String, oUBIGEO.strNOMBRE_CORTO)
					Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, oUBIGEO.strCOD_DPTO)
					Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, oUBIGEO.strCOD_PROV)
					Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, oUBIGEO.strCOD_DIST)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUBIGEO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUBIGEO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUBIGEO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUBIGEO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUBIGEO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUBIGEO.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarUBIGEO(ByVal oLstUBIGEO As List(Of clsBE_UBIGEO)) As Boolean
			For Each oUBIGEO As clsBE_UBIGEO In oLstUBIGEO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_Update")
					Me.DataBase.AddInParameter(command, "@pCOD_UBIGEO", DbType.String, oUBIGEO.strCOD_UBIGEO)
					Me.DataBase.AddInParameter(command, "@pCOD_TOTAL", DbType.String, oUBIGEO.strCOD_TOTAL)
					Me.DataBase.AddInParameter(command, "@pNOMBRE_LARGO", DbType.String, oUBIGEO.strNOMBRE_LARGO)
					Me.DataBase.AddInParameter(command, "@pNOMBRE_CORTO", DbType.String, oUBIGEO.strNOMBRE_CORTO)
					Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, oUBIGEO.strCOD_DPTO)
					Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, oUBIGEO.strCOD_PROV)
					Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, oUBIGEO.strCOD_DIST)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUBIGEO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUBIGEO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUBIGEO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUBIGEO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUBIGEO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUBIGEO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarUBIGEO(ByVal oLstUBIGEO As List(Of clsBE_UBIGEO)) As Boolean
			For Each oUBIGEO As clsBE_UBIGEO In oLstUBIGEO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_Delete")
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUBIGEO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUBIGEO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUBIGEO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUBIGEO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUBIGEO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUBIGEO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado UBIGEO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_UBIGEORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla UBIGEO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerUBIGEO(ByVal pUBIGEO As clsBE_UBIGEO) As clsBE_UBIGEO
			Dim oUBIGEO As clsBE_UBIGEO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_GetByID")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oUBIGEO = Me.ReadItem(reader)
				End Using
			End Using
			Return oUBIGEO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_UBIGEO
			Dim item As New clsBE_UBIGEO
			While (reader.Read())
				item.strCOD_UBIGEO = iif(Convert.IsDBNull(reader("COD_UBIGEO")),String.Empty,CStrMP(reader("COD_UBIGEO")))
				item.strCOD_TOTAL = iif(Convert.IsDBNull(reader("COD_TOTAL")),String.Empty,CStrMP(reader("COD_TOTAL")))
				item.strNOMBRE_LARGO = iif(Convert.IsDBNull(reader("NOMBRE_LARGO")),String.Empty,CStrMP(reader("NOMBRE_LARGO")))
				item.strNOMBRE_CORTO = iif(Convert.IsDBNull(reader("NOMBRE_CORTO")),String.Empty,CStrMP(reader("NOMBRE_CORTO")))
				item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")),String.Empty,CStrMP(reader("COD_DPTO")))
				item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")),String.Empty,CStrMP(reader("COD_PROV")))
				item.strCOD_DIST = iif(Convert.IsDBNull(reader("COD_DIST")),String.Empty,CStrMP(reader("COD_DIST")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaUBIGEO() As List(Of clsBE_UBIGEO)
			Dim olstUBIGEO As New List(Of clsBE_UBIGEO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstUBIGEO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstUBIGEO
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_UBIGEO)
			Dim result As List(Of  clsBE_UBIGEO) = New List(Of clsBE_UBIGEO)
			While (reader.Read())
				dim item as new clsBE_UBIGEO
				item.strCOD_UBIGEO = iif(Convert.IsDBNull(reader("COD_UBIGEO")),String.Empty,CStrMP(reader("COD_UBIGEO")))
				item.strCOD_TOTAL = iif(Convert.IsDBNull(reader("COD_TOTAL")),String.Empty,CStrMP(reader("COD_TOTAL")))
				item.strNOMBRE_LARGO = iif(Convert.IsDBNull(reader("NOMBRE_LARGO")),String.Empty,CStrMP(reader("NOMBRE_LARGO")))
				item.strNOMBRE_CORTO = iif(Convert.IsDBNull(reader("NOMBRE_CORTO")),String.Empty,CStrMP(reader("NOMBRE_CORTO")))
				item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")),String.Empty,CStrMP(reader("COD_DPTO")))
				item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")),String.Empty,CStrMP(reader("COD_PROV")))
				item.strCOD_DIST = iif(Convert.IsDBNull(reader("COD_DIST")),String.Empty,CStrMP(reader("COD_DIST")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad UBIGEO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaUBIGEO_Paged(ByVal pUBIGEO As clsBE_UBIGEO) As List(Of clsBE_UBIGEO)
			Dim intCount As Int32 = 0
			Dim olstUBIGEO As New List(Of clsBE_UBIGEO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pUBIGEO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pUBIGEO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pCOD_UBIGEO", DbType.String, pUBIGEO.strCOD_UBIGEO)
				Me.DataBase.AddInParameter(command, "@pCOD_TOTAL", DbType.String, pUBIGEO.strCOD_TOTAL)
				Me.DataBase.AddInParameter(command, "@pNOMBRE_LARGO", DbType.String, pUBIGEO.strNOMBRE_LARGO)
				Me.DataBase.AddInParameter(command, "@pNOMBRE_CORTO", DbType.String, pUBIGEO.strNOMBRE_CORTO)
				Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, pUBIGEO.strCOD_DPTO)
				Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, pUBIGEO.strCOD_PROV)
				Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, pUBIGEO.strCOD_DIST)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstUBIGEO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstUBIGEO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_UBIGEO)
			Dim result As List(Of  clsBE_UBIGEO) = New List(Of clsBE_UBIGEO)
			While (reader.Read())
				dim item as new clsBE_UBIGEO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.strCOD_UBIGEO = iif(Convert.IsDBNull(reader("COD_UBIGEO")),String.Empty,CStrMP(reader("COD_UBIGEO")))
				item.strCOD_TOTAL = iif(Convert.IsDBNull(reader("COD_TOTAL")),String.Empty,CStrMP(reader("COD_TOTAL")))
				item.strNOMBRE_LARGO = iif(Convert.IsDBNull(reader("NOMBRE_LARGO")),String.Empty,CStrMP(reader("NOMBRE_LARGO")))
				item.strNOMBRE_CORTO = iif(Convert.IsDBNull(reader("NOMBRE_CORTO")),String.Empty,CStrMP(reader("NOMBRE_CORTO")))
				item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")),String.Empty,CStrMP(reader("COD_DPTO")))
				item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")),String.Empty,CStrMP(reader("COD_PROV")))
				item.strCOD_DIST = iif(Convert.IsDBNull(reader("COD_DIST")),String.Empty,CStrMP(reader("COD_DIST")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTUBIGEO() As Datatable
			Dim oDTUBIGEO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_UBIGEO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTUBIGEO
		End Function

	End Class
#End Region
End Namespace


