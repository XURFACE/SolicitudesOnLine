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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_REF_EMPRESATX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarREF_EMPRESA(ByVal oLstREF_EMPRESA As List(Of clsBE_REF_EMPRESA)) As Boolean
			For Each oREF_EMPRESA As clsBE_REF_EMPRESA In oLstREF_EMPRESA
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_Insert")
					Me.DataBase.AddInParameter(command, "@pIDEMPRESA", DbType.Int64, oREF_EMPRESA.lngIDEMPRESA)
					Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, oREF_EMPRESA.strRUTA_REF)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_EMPRESA.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_EMPRESA.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_EMPRESA.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_EMPRESA.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_EMPRESA.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_EMPRESA.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarREF_EMPRESA(ByVal oLstREF_EMPRESA As List(Of clsBE_REF_EMPRESA)) As Boolean
			For Each oREF_EMPRESA As clsBE_REF_EMPRESA In oLstREF_EMPRESA
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oREF_EMPRESA.lngID)
					Me.DataBase.AddInParameter(command, "@pIDEMPRESA", DbType.Int64, oREF_EMPRESA.lngIDEMPRESA)
					Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, oREF_EMPRESA.strRUTA_REF)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_EMPRESA.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_EMPRESA.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_EMPRESA.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_EMPRESA.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_EMPRESA.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_EMPRESA.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarREF_EMPRESA(ByVal oLstREF_EMPRESA As List(Of clsBE_REF_EMPRESA)) As Boolean
			For Each oREF_EMPRESA As clsBE_REF_EMPRESA In oLstREF_EMPRESA
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oREF_EMPRESA.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_EMPRESA.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_EMPRESA.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_EMPRESA.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_EMPRESA.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_EMPRESA.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_EMPRESA.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado REF_EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_REF_EMPRESARO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla REF_EMPRESA y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerREF_EMPRESA(ByVal pREF_EMPRESA As clsBE_REF_EMPRESA) As clsBE_REF_EMPRESA
			Dim oREF_EMPRESA As clsBE_REF_EMPRESA = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pREF_EMPRESA.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oREF_EMPRESA = Me.ReadItem(reader)
				End Using
			End Using
			Return oREF_EMPRESA
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_REF_EMPRESA
			Dim item As New clsBE_REF_EMPRESA
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDEMPRESA = iif(Convert.IsDBNull(reader("IDEMPRESA")),0,CLngMP(reader("IDEMPRESA")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaREF_EMPRESA() As List(Of clsBE_REF_EMPRESA)
			Dim olstREF_EMPRESA As New List(Of clsBE_REF_EMPRESA)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstREF_EMPRESA = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstREF_EMPRESA
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_REF_EMPRESA)
			Dim result As List(Of  clsBE_REF_EMPRESA) = New List(Of clsBE_REF_EMPRESA)
			While (reader.Read())
				dim item as new clsBE_REF_EMPRESA
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDEMPRESA = iif(Convert.IsDBNull(reader("IDEMPRESA")),0,CLngMP(reader("IDEMPRESA")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad REF_EMPRESA Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaREF_EMPRESA_Paged(ByVal pREF_EMPRESA As clsBE_REF_EMPRESA) As List(Of clsBE_REF_EMPRESA)
			Dim intCount As Int32 = 0
			Dim olstREF_EMPRESA As New List(Of clsBE_REF_EMPRESA)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pREF_EMPRESA.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pREF_EMPRESA.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pREF_EMPRESA.lngID)
				Me.DataBase.AddInParameter(command, "@pIDEMPRESA", DbType.Int64, pREF_EMPRESA.lngIDEMPRESA)
				Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, pREF_EMPRESA.strRUTA_REF)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstREF_EMPRESA = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstREF_EMPRESA
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_REF_EMPRESA)
			Dim result As List(Of  clsBE_REF_EMPRESA) = New List(Of clsBE_REF_EMPRESA)
			While (reader.Read())
				dim item as new clsBE_REF_EMPRESA
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDEMPRESA = iif(Convert.IsDBNull(reader("IDEMPRESA")),0,CLngMP(reader("IDEMPRESA")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTREF_EMPRESA() As Datatable
			Dim oDTREF_EMPRESA As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTREF_EMPRESA
		End Function


        Public Function LeerListaToDTREF_EMPRESA(ByVal lngIDEmpresa As Long) As DataTable
            Dim oDTREF_EMPRESA As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_EMPRESA_BYIDEMPRESA")
                Me.DataBase.AddInParameter(command, "@pIDEMPRESA", DbType.Int64, lngIDEmpresa)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTREF_EMPRESA
        End Function

	End Class
#End Region
End Namespace


