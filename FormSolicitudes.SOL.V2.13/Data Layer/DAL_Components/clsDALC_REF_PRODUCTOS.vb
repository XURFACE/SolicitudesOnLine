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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_PRODUCTOS
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_REF_PRODUCTOSTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarREF_PRODUCTOS(ByVal oLstREF_PRODUCTOS As List(Of clsBE_REF_PRODUCTOS)) As Boolean
			For Each oREF_PRODUCTOS As clsBE_REF_PRODUCTOS In oLstREF_PRODUCTOS
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_Insert")
					Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, oREF_PRODUCTOS.strRUTA_REF)
					Me.DataBase.AddInParameter(command, "@pID_PROD", DbType.Int64, oREF_PRODUCTOS.lngID_PROD)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_PRODUCTOS.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_PRODUCTOS.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_PRODUCTOS.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_PRODUCTOS.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarREF_PRODUCTOS(ByVal oLstREF_PRODUCTOS As List(Of clsBE_REF_PRODUCTOS)) As Boolean
			For Each oREF_PRODUCTOS As clsBE_REF_PRODUCTOS In oLstREF_PRODUCTOS
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_Update")
					Me.DataBase.AddInParameter(command, "@pid", DbType.Int64, oREF_PRODUCTOS.lngid)
					Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, oREF_PRODUCTOS.strRUTA_REF)
					Me.DataBase.AddInParameter(command, "@pID_PROD", DbType.Int64, oREF_PRODUCTOS.lngID_PROD)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_PRODUCTOS.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_PRODUCTOS.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_PRODUCTOS.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_PRODUCTOS.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarREF_PRODUCTOS(ByVal oLstREF_PRODUCTOS As List(Of clsBE_REF_PRODUCTOS)) As Boolean
			For Each oREF_PRODUCTOS As clsBE_REF_PRODUCTOS In oLstREF_PRODUCTOS
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_Delete")
					Me.DataBase.AddInParameter(command, "@pid", DbType.Int64, oREF_PRODUCTOS.lngid)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oREF_PRODUCTOS.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oREF_PRODUCTOS.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oREF_PRODUCTOS.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oREF_PRODUCTOS.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oREF_PRODUCTOS.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado REF_PRODUCTOS
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_REF_PRODUCTOSRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla REF_PRODUCTOS y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerREF_PRODUCTOS(ByVal pREF_PRODUCTOS As clsBE_REF_PRODUCTOS) As clsBE_REF_PRODUCTOS
			Dim oREF_PRODUCTOS As clsBE_REF_PRODUCTOS = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_GetByID")
				Me.DataBase.AddInParameter(command, "@pid", DbType.Int64, pREF_PRODUCTOS.lngid)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oREF_PRODUCTOS = Me.ReadItem(reader)
				End Using
			End Using
			Return oREF_PRODUCTOS
		End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_REF_PRODUCTOS
			Dim item As New clsBE_REF_PRODUCTOS
			While (reader.Read())
				item.lngid = iif(Convert.IsDBNull(reader("id")),0,CLngMP(reader("id")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
				item.lngID_PROD = iif(Convert.IsDBNull(reader("ID_PROD")),0,CLngMP(reader("ID_PROD")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaREF_PRODUCTOS() As List(Of clsBE_REF_PRODUCTOS)
			Dim olstREF_PRODUCTOS As New List(Of clsBE_REF_PRODUCTOS)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstREF_PRODUCTOS = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstREF_PRODUCTOS
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_REF_PRODUCTOS)
			Dim result As List(Of  clsBE_REF_PRODUCTOS) = New List(Of clsBE_REF_PRODUCTOS)
			While (reader.Read())
				dim item as new clsBE_REF_PRODUCTOS
				item.lngid = iif(Convert.IsDBNull(reader("id")),0,CLngMP(reader("id")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
				item.lngID_PROD = iif(Convert.IsDBNull(reader("ID_PROD")),0,CLngMP(reader("ID_PROD")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad REF_PRODUCTOS Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaREF_PRODUCTOS_Paged(ByVal pREF_PRODUCTOS As clsBE_REF_PRODUCTOS) As List(Of clsBE_REF_PRODUCTOS)
			Dim intCount As Int32 = 0
			Dim olstREF_PRODUCTOS As New List(Of clsBE_REF_PRODUCTOS)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pREF_PRODUCTOS.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pREF_PRODUCTOS.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pid", DbType.Int64, pREF_PRODUCTOS.lngid)
				Me.DataBase.AddInParameter(command, "@pRUTA_REF", DbType.String, pREF_PRODUCTOS.strRUTA_REF)
				Me.DataBase.AddInParameter(command, "@pID_PROD", DbType.Int64, pREF_PRODUCTOS.lngID_PROD)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstREF_PRODUCTOS = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstREF_PRODUCTOS
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_REF_PRODUCTOS)
			Dim result As List(Of  clsBE_REF_PRODUCTOS) = New List(Of clsBE_REF_PRODUCTOS)
			While (reader.Read())
				dim item as new clsBE_REF_PRODUCTOS
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngid = iif(Convert.IsDBNull(reader("id")),0,CLngMP(reader("id")))
				item.strRUTA_REF = iif(Convert.IsDBNull(reader("RUTA_REF")),String.Empty,CStrMP(reader("RUTA_REF")))
				item.lngID_PROD = iif(Convert.IsDBNull(reader("ID_PROD")),0,CLngMP(reader("ID_PROD")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTREF_PRODUCTOS() As Datatable
			Dim oDTREF_PRODUCTOS As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTREF_PRODUCTOS
        End Function

        Public Function LeerListaToDTREF_PRODUCTOS(ByVal idProd As Long) As DataTable
            Dim oDTREF_PRODUCTOS As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_REF_PRODUCTOS_BYIDPROD")
                Me.DataBase.AddInParameter(command, "@pIDPROD", DbType.Int64, idProd)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTREF_PRODUCTOS
        End Function

	End Class
#End Region
End Namespace


