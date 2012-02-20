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
	''' Fecha Creacion: 05/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla FAQ
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_FAQTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Metodo de Inserción de Datos FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarFAQ(ByVal oLstFAQ As List(Of clsBE_FAQ)) As Boolean
			For Each oFAQ As clsBE_FAQ In oLstFAQ
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_Insert")
					Me.DataBase.AddInParameter(command, "@pPREGUNTA", DbType.String, oFAQ.strPREGUNTA)
					Me.DataBase.AddInParameter(command, "@pRESPUESTA", DbType.String, oFAQ.strRESPUESTA)
					Me.DataBase.AddInParameter(command, "@pNUMORDEN", DbType.Int32, oFAQ.intNUMORDEN)
					Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, oFAQ.blnIND_ACTIVO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oFAQ.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oFAQ.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oFAQ.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oFAQ.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oFAQ.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oFAQ.strAUD_USR_GENERICO) 
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
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Metodo de Modificación de datos FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarFAQ(ByVal oLstFAQ As List(Of clsBE_FAQ)) As Boolean
			For Each oFAQ As clsBE_FAQ In oLstFAQ
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oFAQ.intID)
					Me.DataBase.AddInParameter(command, "@pPREGUNTA", DbType.String, oFAQ.strPREGUNTA)
					Me.DataBase.AddInParameter(command, "@pRESPUESTA", DbType.String, oFAQ.strRESPUESTA)
					Me.DataBase.AddInParameter(command, "@pNUMORDEN", DbType.Int32, oFAQ.intNUMORDEN)
					Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, oFAQ.blnIND_ACTIVO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oFAQ.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oFAQ.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oFAQ.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oFAQ.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oFAQ.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oFAQ.strAUD_USR_GENERICO) 
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
		''' Fecha Creacion: 05/01/2012
		''' Proposito:  Metodo de Elimación FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarFAQ(ByVal oLstFAQ As List(Of clsBE_FAQ)) As Boolean
			For Each oFAQ As clsBE_FAQ In oLstFAQ
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oFAQ.intID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oFAQ.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oFAQ.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oFAQ.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oFAQ.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oFAQ.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oFAQ.strAUD_USR_GENERICO) 
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
	''' Fecha Creacion: 05/01/2012
	''' Proposito: Obtiene los valores de la tabla Abonado FAQ
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_FAQRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Lee datos de un registro de la tabla FAQ y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerFAQ(ByVal pFAQ As clsBE_FAQ) As clsBE_FAQ
			Dim oFAQ As clsBE_FAQ = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pFAQ.intID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oFAQ = Me.ReadItem(reader)
				End Using
			End Using
			Return oFAQ
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_FAQ
			Dim item As New clsBE_FAQ
			While (reader.Read())
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strPREGUNTA = iif(Convert.IsDBNull(reader("PREGUNTA")),String.Empty,CStrMP(reader("PREGUNTA")))
				item.strRESPUESTA = iif(Convert.IsDBNull(reader("RESPUESTA")),String.Empty,CStrMP(reader("RESPUESTA")))
				item.intNUMORDEN = iif(Convert.IsDBNull(reader("NUMORDEN")),0,CIntMP(reader("NUMORDEN")))
				item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")),Nothing,CBoolMP(reader("IND_ACTIVO")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtiene la lista de todos los registros de la entidad: FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaFAQ() As List(Of clsBE_FAQ)
			Dim olstFAQ As New List(Of clsBE_FAQ)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstFAQ = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstFAQ
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_FAQ)
			Dim result As List(Of  clsBE_FAQ) = New List(Of clsBE_FAQ)
			While (reader.Read())
				dim item as new clsBE_FAQ
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strPREGUNTA = iif(Convert.IsDBNull(reader("PREGUNTA")),String.Empty,CStrMP(reader("PREGUNTA")))
				item.strRESPUESTA = iif(Convert.IsDBNull(reader("RESPUESTA")),String.Empty,CStrMP(reader("RESPUESTA")))
				item.intNUMORDEN = iif(Convert.IsDBNull(reader("NUMORDEN")),0,CIntMP(reader("NUMORDEN")))
				item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")),Nothing,CBoolMP(reader("IND_ACTIVO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtiene la lista de registros de la entidad FAQ Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaFAQ_Paged(ByVal pFAQ As clsBE_FAQ) As List(Of clsBE_FAQ)
			Dim intCount As Int32 = 0
			Dim olstFAQ As New List(Of clsBE_FAQ)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pFAQ.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pFAQ.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pFAQ.intID)
				Me.DataBase.AddInParameter(command, "@pPREGUNTA", DbType.String, pFAQ.strPREGUNTA)
				Me.DataBase.AddInParameter(command, "@pRESPUESTA", DbType.String, pFAQ.strRESPUESTA)
				Me.DataBase.AddInParameter(command, "@pNUMORDEN", DbType.Int32, pFAQ.intNUMORDEN)
				Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, pFAQ.blnIND_ACTIVO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstFAQ = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstFAQ
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_FAQ)
			Dim result As List(Of  clsBE_FAQ) = New List(Of clsBE_FAQ)
			While (reader.Read())
				dim item as new clsBE_FAQ
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strPREGUNTA = iif(Convert.IsDBNull(reader("PREGUNTA")),String.Empty,CStrMP(reader("PREGUNTA")))
				item.strRESPUESTA = iif(Convert.IsDBNull(reader("RESPUESTA")),String.Empty,CStrMP(reader("RESPUESTA")))
				item.intNUMORDEN = iif(Convert.IsDBNull(reader("NUMORDEN")),0,CIntMP(reader("NUMORDEN")))
				item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")),Nothing,CBoolMP(reader("IND_ACTIVO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTFAQ() As Datatable
			Dim oDTFAQ As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_FAQ_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTFAQ
		End Function

	End Class
#End Region
End Namespace


