Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data.SqlClient
Imports System.Data
Imports MP.DW.BL.BE
Imports MP.DW.UTL.clsUTL_Helpers


Namespace MP.DW.DAL.DALC
#Region "Clase Escritura" 
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 10/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DOCUMENTOS_ADICIONALES
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_DOCUMENTOS_ADICIONALESTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Metodo de Inserción de Datos DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarDOCUMENTOS_ADICIONALES(ByVal oLstDOCUMENTOS_ADICIONALES As List(Of clsBE_DOCUMENTOS_ADICIONALES)) As Boolean
			For Each oDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES In oLstDOCUMENTOS_ADICIONALES
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_Insert")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oDOCUMENTOS_ADICIONALES.lngID)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oDOCUMENTOS_ADICIONALES.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oDOCUMENTOS_ADICIONALES.strDESCRIPCION)
					Me.DataBase.AddInParameter(command, "@pRUTA_ARCHIVO", DbType.String, oDOCUMENTOS_ADICIONALES.strRUTA_ARCHIVO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_USR_GENERICO) 
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
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Metodo de Modificación de datos DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarDOCUMENTOS_ADICIONALES(ByVal oLstDOCUMENTOS_ADICIONALES As List(Of clsBE_DOCUMENTOS_ADICIONALES)) As Boolean
			For Each oDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES In oLstDOCUMENTOS_ADICIONALES
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oDOCUMENTOS_ADICIONALES.lngID)
					Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oDOCUMENTOS_ADICIONALES.lngIDSOLICITUD)
					Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oDOCUMENTOS_ADICIONALES.strDESCRIPCION)
					Me.DataBase.AddInParameter(command, "@pRUTA_ARCHIVO", DbType.String, oDOCUMENTOS_ADICIONALES.strRUTA_ARCHIVO)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_USR_GENERICO) 
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
		''' Fecha Creacion: 10/01/2012
		''' Proposito:  Metodo de Elimación DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarDOCUMENTOS_ADICIONALES(ByVal oLstDOCUMENTOS_ADICIONALES As List(Of clsBE_DOCUMENTOS_ADICIONALES)) As Boolean
			For Each oDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES In oLstDOCUMENTOS_ADICIONALES
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oDOCUMENTOS_ADICIONALES.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oDOCUMENTOS_ADICIONALES.strAUD_USR_GENERICO) 
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
	''' Fecha Creacion: 10/01/2012
	''' Proposito: Obtiene los valores de la tabla Abonado DOCUMENTOS_ADICIONALES
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_DOCUMENTOS_ADICIONALESRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Lee datos de un registro de la tabla DOCUMENTOS_ADICIONALES y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerDOCUMENTOS_ADICIONALES(ByVal pDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES) As clsBE_DOCUMENTOS_ADICIONALES
			Dim oDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pDOCUMENTOS_ADICIONALES.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oDOCUMENTOS_ADICIONALES = Me.ReadItem(reader)
				End Using
			End Using
			Return oDOCUMENTOS_ADICIONALES
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_DOCUMENTOS_ADICIONALES
			Dim item As New clsBE_DOCUMENTOS_ADICIONALES
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")),String.Empty,CStrMP(reader("RUTA_ARCHIVO")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtiene la lista de todos los registros de la entidad: DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaDOCUMENTOS_ADICIONALES() As List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim olstDOCUMENTOS_ADICIONALES As New List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstDOCUMENTOS_ADICIONALES = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstDOCUMENTOS_ADICIONALES
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim result As List(Of  clsBE_DOCUMENTOS_ADICIONALES) = New List(Of clsBE_DOCUMENTOS_ADICIONALES)
			While (reader.Read())
				dim item as new clsBE_DOCUMENTOS_ADICIONALES
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")),String.Empty,CStrMP(reader("RUTA_ARCHIVO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtiene la lista de registros de la entidad DOCUMENTOS_ADICIONALES Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaDOCUMENTOS_ADICIONALES_Paged(ByVal pDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES) As List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim intCount As Int32 = 0
			Dim olstDOCUMENTOS_ADICIONALES As New List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pDOCUMENTOS_ADICIONALES.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pDOCUMENTOS_ADICIONALES.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pDOCUMENTOS_ADICIONALES.lngID)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pDOCUMENTOS_ADICIONALES.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, pDOCUMENTOS_ADICIONALES.strDESCRIPCION)
				Me.DataBase.AddInParameter(command, "@pRUTA_ARCHIVO", DbType.String, pDOCUMENTOS_ADICIONALES.strRUTA_ARCHIVO)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstDOCUMENTOS_ADICIONALES = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstDOCUMENTOS_ADICIONALES
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_DOCUMENTOS_ADICIONALES)
			Dim result As List(Of  clsBE_DOCUMENTOS_ADICIONALES) = New List(Of clsBE_DOCUMENTOS_ADICIONALES)
			While (reader.Read())
				dim item as new clsBE_DOCUMENTOS_ADICIONALES
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")),String.Empty,CStrMP(reader("RUTA_ARCHIVO")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function LeerListaToDTDOCUMENTOS_ADICIONALESByIdSol(ByVal xidSOL As Long) As DataTable
            Dim oDTDOCUMENTOS_ADICIONALES As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_SelLstbyIDSOL")
                Me.DataBase.AddInParameter(command, "@IDSOLICITUD", DbType.Int64, xidSOL)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTDOCUMENTOS_ADICIONALES
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 10/01/2012
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS DOCUMENTOS_ADICIONALES
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaToDTDOCUMENTOS_ADICIONALES() As DataTable
            Dim oDTDOCUMENTOS_ADICIONALES As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_DOCUMENTOS_ADICIONALES_SelLstbyIDSOL")
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTDOCUMENTOS_ADICIONALES
        End Function

	End Class
#End Region
End Namespace


