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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla APLICACION
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_APLICACIONTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarAPLICACION(ByVal oLstAPLICACION As List(Of clsBE_APLICACION)) As Boolean
			For Each oAPLICACION As clsBE_APLICACION In oLstAPLICACION
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_Insert")
					Me.DataBase.AddInParameter(command, "@pDECRIPCION", DbType.String, oAPLICACION.strDECRIPCION)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oAPLICACION.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pSTSAPLICACION", DbType.Int32, oAPLICACION.intSTSAPLICACION)
					Me.DataBase.AddInParameter(command, "@pRUTA_IMAGEN", DbType.String, oAPLICACION.strRUTA_IMAGEN)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAPLICACION.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAPLICACION.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAPLICACION.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAPLICACION.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAPLICACION.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAPLICACION.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarAPLICACION(ByVal oLstAPLICACION As List(Of clsBE_APLICACION)) As Boolean
			For Each oAPLICACION As clsBE_APLICACION In oLstAPLICACION
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oAPLICACION.lngID)
					Me.DataBase.AddInParameter(command, "@pDECRIPCION", DbType.String, oAPLICACION.strDECRIPCION)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oAPLICACION.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pSTSAPLICACION", DbType.Int32, oAPLICACION.intSTSAPLICACION)
					Me.DataBase.AddInParameter(command, "@pRUTA_IMAGEN", DbType.String, oAPLICACION.strRUTA_IMAGEN)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAPLICACION.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAPLICACION.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAPLICACION.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAPLICACION.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAPLICACION.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAPLICACION.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarAPLICACION(ByVal oLstAPLICACION As List(Of clsBE_APLICACION)) As Boolean
			For Each oAPLICACION As clsBE_APLICACION In oLstAPLICACION
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oAPLICACION.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oAPLICACION.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oAPLICACION.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oAPLICACION.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oAPLICACION.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oAPLICACION.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oAPLICACION.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado APLICACION
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_APLICACIONRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla APLICACION y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerAPLICACION(ByVal pAPLICACION As clsBE_APLICACION) As clsBE_APLICACION
			Dim oAPLICACION As clsBE_APLICACION = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pAPLICACION.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oAPLICACION = Me.ReadItem(reader)
				End Using
			End Using
			Return oAPLICACION
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_APLICACION
			Dim item As New clsBE_APLICACION
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strDECRIPCION = iif(Convert.IsDBNull(reader("DECRIPCION")),String.Empty,CStrMP(reader("DECRIPCION")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.intSTSAPLICACION = iif(Convert.IsDBNull(reader("STSAPLICACION")),0,CIntMP(reader("STSAPLICACION")))
				item.strRUTA_IMAGEN = iif(Convert.IsDBNull(reader("RUTA_IMAGEN")),String.Empty,CStrMP(reader("RUTA_IMAGEN")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaAPLICACION() As List(Of clsBE_APLICACION)
			Dim olstAPLICACION As New List(Of clsBE_APLICACION)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstAPLICACION = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstAPLICACION
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_APLICACION)
			Dim result As List(Of  clsBE_APLICACION) = New List(Of clsBE_APLICACION)
			While (reader.Read())
				dim item as new clsBE_APLICACION
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strDECRIPCION = iif(Convert.IsDBNull(reader("DECRIPCION")),String.Empty,CStrMP(reader("DECRIPCION")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.intSTSAPLICACION = iif(Convert.IsDBNull(reader("STSAPLICACION")),0,CIntMP(reader("STSAPLICACION")))
				item.strRUTA_IMAGEN = iif(Convert.IsDBNull(reader("RUTA_IMAGEN")),String.Empty,CStrMP(reader("RUTA_IMAGEN")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad APLICACION Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaAPLICACION_Paged(ByVal pAPLICACION As clsBE_APLICACION) As List(Of clsBE_APLICACION)
			Dim intCount As Int32 = 0
			Dim olstAPLICACION As New List(Of clsBE_APLICACION)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pAPLICACION.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pAPLICACION.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pAPLICACION.lngID)
				Me.DataBase.AddInParameter(command, "@pDECRIPCION", DbType.String, pAPLICACION.strDECRIPCION)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pAPLICACION.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pSTSAPLICACION", DbType.Int32, pAPLICACION.intSTSAPLICACION)
				Me.DataBase.AddInParameter(command, "@pRUTA_IMAGEN", DbType.String, pAPLICACION.strRUTA_IMAGEN)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstAPLICACION = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstAPLICACION
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_APLICACION)
			Dim result As List(Of  clsBE_APLICACION) = New List(Of clsBE_APLICACION)
			While (reader.Read())
				dim item as new clsBE_APLICACION
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strDECRIPCION = iif(Convert.IsDBNull(reader("DECRIPCION")),String.Empty,CStrMP(reader("DECRIPCION")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.intSTSAPLICACION = iif(Convert.IsDBNull(reader("STSAPLICACION")),0,CIntMP(reader("STSAPLICACION")))
				item.strRUTA_IMAGEN = iif(Convert.IsDBNull(reader("RUTA_IMAGEN")),String.Empty,CStrMP(reader("RUTA_IMAGEN")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS APLICACION
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTAPLICACION() As Datatable
			Dim oDTAPLICACION As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTAPLICACION
        End Function

        Public Function LeerListaToDTAAPLICACIONBYSOL(ByVal idSol As Int64) As DataTable
            Dim oDTAPLICACION As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_APLICACION_GetBySol")
                Me.DataBase.AddInParameter(command, "@pIdSol", DbType.Int64, idSol)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTAPLICACION
        End Function

	End Class
#End Region
End Namespace


