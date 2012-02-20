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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla RESTAURAPWD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_RESTAURAPWDTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarRESTAURAPWD(ByVal oLstRESTAURAPWD As List(Of clsBE_RESTAURAPWD)) As Boolean
			For Each oRESTAURAPWD As clsBE_RESTAURAPWD In oLstRESTAURAPWD
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_Insert")
					Me.DataBase.AddInParameter(command, "@pCLAVECONFIRMACION", DbType.Guid, oRESTAURAPWD.uidCLAVECONFIRMACION)
					Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, oRESTAURAPWD.strCODUSUARIO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oRESTAURAPWD.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oRESTAURAPWD.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oRESTAURAPWD.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oRESTAURAPWD.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oRESTAURAPWD.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oRESTAURAPWD.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarRESTAURAPWD(ByVal oLstRESTAURAPWD As List(Of clsBE_RESTAURAPWD)) As Boolean
			For Each oRESTAURAPWD As clsBE_RESTAURAPWD In oLstRESTAURAPWD
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_Update")
					Me.DataBase.AddInParameter(command, "@pCLAVECONFIRMACION", DbType.Guid, oRESTAURAPWD.uidCLAVECONFIRMACION)
					Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, oRESTAURAPWD.strCODUSUARIO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oRESTAURAPWD.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oRESTAURAPWD.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oRESTAURAPWD.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oRESTAURAPWD.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oRESTAURAPWD.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oRESTAURAPWD.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarRESTAURAPWD(ByVal oLstRESTAURAPWD As List(Of clsBE_RESTAURAPWD)) As Boolean
			For Each oRESTAURAPWD As clsBE_RESTAURAPWD In oLstRESTAURAPWD
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_Delete")
					Me.DataBase.AddInParameter(command, "@pCLAVECONFIRMACION", DbType.Guid, oRESTAURAPWD.uidCLAVECONFIRMACION)
					Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, oRESTAURAPWD.strCODUSUARIO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oRESTAURAPWD.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oRESTAURAPWD.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oRESTAURAPWD.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oRESTAURAPWD.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oRESTAURAPWD.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oRESTAURAPWD.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado RESTAURAPWD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_RESTAURAPWDRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla RESTAURAPWD y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerRESTAURAPWD(ByVal pRESTAURAPWD As clsBE_RESTAURAPWD) As clsBE_RESTAURAPWD
			Dim oRESTAURAPWD As clsBE_RESTAURAPWD = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_GetByID")
				Me.DataBase.AddInParameter(command, "@pCLAVECONFIRMACION", DbType.Guid, pRESTAURAPWD.uidCLAVECONFIRMACION)
				Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, pRESTAURAPWD.strCODUSUARIO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oRESTAURAPWD = Me.ReadItem(reader)
				End Using
			End Using
			Return oRESTAURAPWD
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_RESTAURAPWD
			Dim item As New clsBE_RESTAURAPWD
			While (reader.Read())
				item.uidCLAVECONFIRMACION = iif(Convert.IsDBNull(reader("CLAVECONFIRMACION")),Nothing,CUidMP(reader("CLAVECONFIRMACION")))
				item.strCODUSUARIO = iif(Convert.IsDBNull(reader("CODUSUARIO")),String.Empty,CStrMP(reader("CODUSUARIO")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaRESTAURAPWD() As List(Of clsBE_RESTAURAPWD)
			Dim olstRESTAURAPWD As New List(Of clsBE_RESTAURAPWD)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstRESTAURAPWD = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstRESTAURAPWD
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_RESTAURAPWD)
			Dim result As List(Of  clsBE_RESTAURAPWD) = New List(Of clsBE_RESTAURAPWD)
			While (reader.Read())
				dim item as new clsBE_RESTAURAPWD
				item.uidCLAVECONFIRMACION = iif(Convert.IsDBNull(reader("CLAVECONFIRMACION")),Nothing,CUidMP(reader("CLAVECONFIRMACION")))
				item.strCODUSUARIO = iif(Convert.IsDBNull(reader("CODUSUARIO")),String.Empty,CStrMP(reader("CODUSUARIO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad RESTAURAPWD Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaRESTAURAPWD_Paged(ByVal pRESTAURAPWD As clsBE_RESTAURAPWD) As List(Of clsBE_RESTAURAPWD)
			Dim intCount As Int32 = 0
			Dim olstRESTAURAPWD As New List(Of clsBE_RESTAURAPWD)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pRESTAURAPWD.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pRESTAURAPWD.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pCLAVECONFIRMACION", DbType.Guid, pRESTAURAPWD.uidCLAVECONFIRMACION)
				Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, pRESTAURAPWD.strCODUSUARIO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstRESTAURAPWD = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstRESTAURAPWD
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_RESTAURAPWD)
			Dim result As List(Of  clsBE_RESTAURAPWD) = New List(Of clsBE_RESTAURAPWD)
			While (reader.Read())
				dim item as new clsBE_RESTAURAPWD
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.uidCLAVECONFIRMACION = iif(Convert.IsDBNull(reader("CLAVECONFIRMACION")),Nothing,CUidMP(reader("CLAVECONFIRMACION")))
				item.strCODUSUARIO = iif(Convert.IsDBNull(reader("CODUSUARIO")),String.Empty,CStrMP(reader("CODUSUARIO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTRESTAURAPWD() As Datatable
			Dim oDTRESTAURAPWD As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_RESTAURAPWD_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTRESTAURAPWD
		End Function

	End Class
#End Region
End Namespace


