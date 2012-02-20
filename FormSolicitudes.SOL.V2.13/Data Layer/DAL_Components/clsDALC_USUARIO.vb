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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla USUARIO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_USUARIOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarUSUARIO(ByVal oLstUSUARIO As List(Of clsBE_USUARIO)) As Boolean
			For Each oUSUARIO As clsBE_USUARIO In oLstUSUARIO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_Insert")
					Me.DataBase.AddInParameter(command, "@pLOGIN", DbType.String, oUSUARIO.strLOGIN)
					Me.DataBase.AddInParameter(command, "@pPASSWORD", DbType.String, oUSUARIO.strPASSWORD)
					Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oUSUARIO.strNOMBRE)
					Me.DataBase.AddInParameter(command, "@pPERFIL", DbType.String, oUSUARIO.strPERFIL)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUSUARIO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUSUARIO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUSUARIO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUSUARIO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUSUARIO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUSUARIO.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarUSUARIO(ByVal oLstUSUARIO As List(Of clsBE_USUARIO)) As Boolean
			For Each oUSUARIO As clsBE_USUARIO In oLstUSUARIO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oUSUARIO.intID)
					Me.DataBase.AddInParameter(command, "@pLOGIN", DbType.String, oUSUARIO.strLOGIN)
					Me.DataBase.AddInParameter(command, "@pPASSWORD", DbType.String, oUSUARIO.strPASSWORD)
					Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oUSUARIO.strNOMBRE)
					Me.DataBase.AddInParameter(command, "@pPERFIL", DbType.String, oUSUARIO.strPERFIL)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUSUARIO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUSUARIO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUSUARIO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUSUARIO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUSUARIO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUSUARIO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarUSUARIO(ByVal oLstUSUARIO As List(Of clsBE_USUARIO)) As Boolean
			For Each oUSUARIO As clsBE_USUARIO In oLstUSUARIO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oUSUARIO.intID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oUSUARIO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oUSUARIO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oUSUARIO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oUSUARIO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oUSUARIO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oUSUARIO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado USUARIO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_USUARIORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla USUARIO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerUSUARIO(ByVal pUSUARIO As clsBE_USUARIO) As clsBE_USUARIO
			Dim oUSUARIO As clsBE_USUARIO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pUSUARIO.intID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oUSUARIO = Me.ReadItem(reader)
				End Using
			End Using
			Return oUSUARIO
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_USUARIO
			Dim item As New clsBE_USUARIO
			While (reader.Read())
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strLOGIN = iif(Convert.IsDBNull(reader("LOGIN")),String.Empty,CStrMP(reader("LOGIN")))
				item.strPASSWORD = iif(Convert.IsDBNull(reader("PASSWORD")),String.Empty,CStrMP(reader("PASSWORD")))
				item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")),String.Empty,CStrMP(reader("NOMBRE")))
				item.strPERFIL = iif(Convert.IsDBNull(reader("PERFIL")),String.Empty,CStrMP(reader("PERFIL")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaUSUARIO() As List(Of clsBE_USUARIO)
			Dim olstUSUARIO As New List(Of clsBE_USUARIO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstUSUARIO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstUSUARIO
        End Function
        Public Function LeerUSUARIObyLogIn(ByVal pUSUARIO As clsBE_USUARIO) As clsBE_USUARIO
            Dim oUSUARIO As clsBE_USUARIO = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_ADMIN_GetByLogIn")
                Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, pUSUARIO.strLOGIN)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oUSUARIO = Me.ReadItem(reader)
                End Using
            End Using
            Return oUSUARIO
        End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_USUARIO)
			Dim result As List(Of  clsBE_USUARIO) = New List(Of clsBE_USUARIO)
			While (reader.Read())
				dim item as new clsBE_USUARIO
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strLOGIN = iif(Convert.IsDBNull(reader("LOGIN")),String.Empty,CStrMP(reader("LOGIN")))
				item.strPASSWORD = iif(Convert.IsDBNull(reader("PASSWORD")),String.Empty,CStrMP(reader("PASSWORD")))
				item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")),String.Empty,CStrMP(reader("NOMBRE")))
				item.strPERFIL = iif(Convert.IsDBNull(reader("PERFIL")),String.Empty,CStrMP(reader("PERFIL")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad USUARIO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaUSUARIO_Paged(ByVal pUSUARIO As clsBE_USUARIO) As List(Of clsBE_USUARIO)
			Dim intCount As Int32 = 0
			Dim olstUSUARIO As New List(Of clsBE_USUARIO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pUSUARIO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pUSUARIO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pUSUARIO.intID)
				Me.DataBase.AddInParameter(command, "@pLOGIN", DbType.String, pUSUARIO.strLOGIN)
				Me.DataBase.AddInParameter(command, "@pPASSWORD", DbType.String, pUSUARIO.strPASSWORD)
				Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, pUSUARIO.strNOMBRE)
				Me.DataBase.AddInParameter(command, "@pPERFIL", DbType.String, pUSUARIO.strPERFIL)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstUSUARIO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstUSUARIO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_USUARIO)
			Dim result As List(Of  clsBE_USUARIO) = New List(Of clsBE_USUARIO)
			While (reader.Read())
				dim item as new clsBE_USUARIO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.intID = iif(Convert.IsDBNull(reader("ID")),0,CIntMP(reader("ID")))
				item.strLOGIN = iif(Convert.IsDBNull(reader("LOGIN")),String.Empty,CStrMP(reader("LOGIN")))
				item.strPASSWORD = iif(Convert.IsDBNull(reader("PASSWORD")),String.Empty,CStrMP(reader("PASSWORD")))
				item.strNOMBRE = iif(Convert.IsDBNull(reader("NOMBRE")),String.Empty,CStrMP(reader("NOMBRE")))
				item.strPERFIL = iif(Convert.IsDBNull(reader("PERFIL")),String.Empty,CStrMP(reader("PERFIL")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTUSUARIO() As Datatable
			Dim oDTUSUARIO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTUSUARIO
		End Function

	End Class
#End Region
End Namespace


