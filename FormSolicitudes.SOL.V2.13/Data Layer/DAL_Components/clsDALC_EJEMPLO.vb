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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EJEMPLO
    ''' Fecha Modificacion: 
    ''' </summary> 
    '''
    <Serializable()> _
    Public Class clsDALC_EJEMPLOTX
        Inherits clsDALC_Base

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 05/01/2012
        ''' Proposito: Metodo de Inserción de Datos EJEMPLO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function InsertarEJEMPLO(ByVal oLstEJEMPLO As List(Of clsBE_EJEMPLO)) As Boolean
            For Each oEJEMPLO As clsBE_EJEMPLO In oLstEJEMPLO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_Insert")
                    Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oEJEMPLO.strDESCRIPCION)
                    Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oEJEMPLO.strTIPOLIC)
                    Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, oEJEMPLO.blnIND_ACTIVO)
                    Me.DataBase.AddInParameter(command, "@pRUTA_ARCHIVO", DbType.String, oEJEMPLO.strRUTA_ARCHIVO)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEJEMPLO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEJEMPLO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEJEMPLO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEJEMPLO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEJEMPLO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEJEMPLO.strAUD_USR_GENERICO)
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
        ''' Proposito: Metodo de Modificación de datos EJEMPLO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function ModificarEJEMPLO(ByVal oLstEJEMPLO As List(Of clsBE_EJEMPLO)) As Boolean
            For Each oEJEMPLO As clsBE_EJEMPLO In oLstEJEMPLO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_Update")
                    Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oEJEMPLO.intID)
                    Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oEJEMPLO.strDESCRIPCION)
                    Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oEJEMPLO.strTIPOLIC)
                    Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, oEJEMPLO.blnIND_ACTIVO)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEJEMPLO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEJEMPLO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEJEMPLO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEJEMPLO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEJEMPLO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEJEMPLO.strAUD_USR_GENERICO)
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
        ''' Proposito:  Metodo de Elimación EJEMPLO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function EliminarEJEMPLO(ByVal oLstEJEMPLO As List(Of clsBE_EJEMPLO)) As Boolean
            For Each oEJEMPLO As clsBE_EJEMPLO In oLstEJEMPLO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_Delete")
                    Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, oEJEMPLO.intID)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEJEMPLO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEJEMPLO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEJEMPLO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEJEMPLO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEJEMPLO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEJEMPLO.strAUD_USR_GENERICO)
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
    ''' Proposito: Obtiene los valores de la tabla Abonado EJEMPLO
    ''' Fecha Modificacion: 
    ''' </summary> 
    '''
    <Serializable()> _
    Public Class clsDALC_EJEMPLORO
        Inherits clsDALC_Base

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 05/01/2012
        ''' Proposito: Lee datos de un registro de la tabla EJEMPLO y lo obtiene por su PK
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerEJEMPLO(ByVal pEJEMPLO As clsBE_EJEMPLO) As clsBE_EJEMPLO
            Dim oEJEMPLO As clsBE_EJEMPLO = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_GetByID")
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pEJEMPLO.intID)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oEJEMPLO = Me.ReadItem(reader)
                End Using
            End Using
            Return oEJEMPLO
        End Function

        Private Function ReadItem(ByVal reader As IDataReader) As clsBE_EJEMPLO
            Dim item As New clsBE_EJEMPLO
            While (reader.Read())
                item.intID = iif(Convert.IsDBNull(reader("ID")), 0, CIntMP(reader("ID")))
                item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")), String.Empty, CStrMP(reader("DESCRIPCION")))
                item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")), String.Empty, CStrMP(reader("TIPOLIC")))
                item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")), Nothing, CBoolMP(reader("IND_ACTIVO")))
                item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")), String.Empty, CStrMP(reader("RUTA_ARCHIVO")))
            End While
            Return item
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 05/01/2012
        ''' Proposito: Obtiene la lista de todos los registros de la entidad: EJEMPLO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaEJEMPLO() As List(Of clsBE_EJEMPLO)
            Dim olstEJEMPLO As New List(Of clsBE_EJEMPLO)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_SelLst")
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    olstEJEMPLO = Me.ReadListItem(reader)
                End Using
            End Using
            Return olstEJEMPLO
        End Function

        Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_EJEMPLO)
            Dim result As List(Of clsBE_EJEMPLO) = New List(Of clsBE_EJEMPLO)
            While (reader.Read())
                Dim item As New clsBE_EJEMPLO
                item.intID = iif(Convert.IsDBNull(reader("ID")), 0, CIntMP(reader("ID")))
                item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")), String.Empty, CStrMP(reader("DESCRIPCION")))
                item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")), String.Empty, CStrMP(reader("TIPOLIC")))
                item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")), Nothing, CBoolMP(reader("IND_ACTIVO")))
                item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")), String.Empty, CStrMP(reader("RUTA_ARCHIVO")))
                result.Add(item)
            End While
            Return result
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 05/01/2012
        ''' Proposito: Obtiene la lista de registros de la entidad EJEMPLO Paginado en Base de datos
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaEJEMPLO_Paged(ByVal pEJEMPLO As clsBE_EJEMPLO) As List(Of clsBE_EJEMPLO)
            Dim intCount As Int32 = 0
            Dim olstEJEMPLO As New List(Of clsBE_EJEMPLO)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_SelLst_Paged")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pEJEMPLO.intPAGESIZE)
                Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32, pEJEMPLO.intCURRENTPAGE)
                Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
                'Atributos de la Entidad
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int32, pEJEMPLO.intID)
                Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, pEJEMPLO.strDESCRIPCION)
                Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, pEJEMPLO.strTIPOLIC)
                Me.DataBase.AddInParameter(command, "@pIND_ACTIVO", DbType.Boolean, pEJEMPLO.blnIND_ACTIVO)
                Me.DataBase.AddInParameter(command, "@pRUTA_ARCHIVO", DbType.String, pEJEMPLO.strRUTA_ARCHIVO)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
                    olstEJEMPLO = Me.ReadListItemPaged(reader, intCount)
                End Using
            End Using
            Return olstEJEMPLO
        End Function

        Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_EJEMPLO)
            Dim result As List(Of clsBE_EJEMPLO) = New List(Of clsBE_EJEMPLO)
            While (reader.Read())
                Dim item As New clsBE_EJEMPLO
                'Atributos de paged del result set que devuelve el store
                item.intITEMCOUNT = intCount
                item.intID = iif(Convert.IsDBNull(reader("ID")), 0, CIntMP(reader("ID")))
                item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")), String.Empty, CStrMP(reader("DESCRIPCION")))
                item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")), String.Empty, CStrMP(reader("TIPOLIC")))
                item.blnIND_ACTIVO = iif(Convert.IsDBNull(reader("IND_ACTIVO")), Nothing, CBoolMP(reader("IND_ACTIVO")))
                item.strRUTA_ARCHIVO = iif(Convert.IsDBNull(reader("RUTA_ARCHIVO")), String.Empty, CStrMP(reader("RUTA_ARCHIVO")))
                result.Add(item)
            End While
            Return result
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 05/01/2012
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS EJEMPLO
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaToDTEJEMPLO() As Datatable
            Dim oDTEJEMPLO As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EJEMPLO_SelLst")
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTEJEMPLO
        End Function

    End Class
#End Region
End Namespace