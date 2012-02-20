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
    ''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EMPRESA
    ''' Fecha Modificacion: 
    ''' </summary> 
    '''
    <Serializable()> _
    Public Class clsDALC_EMPRESATX
        Inherits clsDALC_Base

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Metodo de Inserción de Datos EMPRESA
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function InsertarEMPRESA(ByRef oLstEMPRESA As List(Of clsBE_EMPRESA)) As Boolean
            Dim opLstEMPRESA As New List(Of clsBE_EMPRESA)
            For Each oEMPRESA As clsBE_EMPRESA In oLstEMPRESA
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_Insert")
                    Me.DataBase.AddInParameter(command, "@pIDUSUARIO", DbType.Int64, oEMPRESA.lngIDUSUARIO)
                    Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, oEMPRESA.strRAZONSOCIAL)
                    Me.DataBase.AddInParameter(command, "@pREPRESENTANTE", DbType.String, oEMPRESA.strREPRESENTANTE)
                    Me.DataBase.AddInParameter(command, "@pCARGO", DbType.String, oEMPRESA.strCARGO)
                    Me.DataBase.AddInParameter(command, "@pDNI", DbType.String, oEMPRESA.strDNI)
                    Me.DataBase.AddInParameter(command, "@pRUTADNI", DbType.String, oEMPRESA.strRUTADNI)
                    Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, oEMPRESA.strRUC)
                    Me.DataBase.AddInParameter(command, "@pRUTARUC", DbType.String, oEMPRESA.strRUTARUC)
                    Me.DataBase.AddInParameter(command, "@pRUTAVIGPODER", DbType.String, oEMPRESA.strRUTAVIGPODER)
                    Me.DataBase.AddInParameter(command, "@pGIRO", DbType.String, oEMPRESA.strGIRO)
                    Me.DataBase.AddInParameter(command, "@pDET_GIRO", DbType.String, oEMPRESA.strDET_GIRO)
                    Me.DataBase.AddInParameter(command, "@pWEB", DbType.String, oEMPRESA.strWEB)
                    Me.DataBase.AddInParameter(command, "@pDOMICILIO", DbType.String, oEMPRESA.strDOMICILIO)
                    Me.DataBase.AddInParameter(command, "@pNUMPARTIDA", DbType.String, oEMPRESA.strNUMPARTIDA)
                    Me.DataBase.AddInParameter(command, "@pNUMTEL", DbType.String, oEMPRESA.strNUMTEL)
                    Me.DataBase.AddInParameter(command, "@pEMAIL", DbType.String, oEMPRESA.strEMAIL)
                    Me.DataBase.AddInParameter(command, "@pNOMPERCONTACTO", DbType.String, oEMPRESA.strNOMPERCONTACTO)
                    Me.DataBase.AddInParameter(command, "@pMSGORG", DbType.String, oEMPRESA.strMSGORG)
                    Me.DataBase.AddInParameter(command, "@pREFERENCIAS", DbType.String, oEMPRESA.strREFERENCIAS)
                    Me.DataBase.AddInParameter(command, "@pCOMPROMISO", DbType.String, oEMPRESA.strCOMPROMISO)
                    Me.DataBase.AddInParameter(command, "@pNOMBREPROGRAMASOCIAL", DbType.String, oEMPRESA.strNOMBREPROGRAMASOCIAL)
                    Me.DataBase.AddInParameter(command, "@pDET_PROGRAMASOCIAL", DbType.String, oEMPRESA.strDET_PROGRAMASOCIAL)
                    Me.DataBase.AddInParameter(command, "@pRUTALICENCIA", DbType.String, oEMPRESA.strRUTALICENCIA)
                    Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, oEMPRESA.strCOD_DPTO)
                    Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, oEMPRESA.strCOD_PROV)
                    Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, oEMPRESA.strCOD_DIST)
                    Me.DataBase.AddInParameter(command, "@pOBJETIVO", DbType.String, oEMPRESA.strOBJETIVO)
                    Me.DataBase.AddInParameter(command, "@pOBJ_PORQUE", DbType.String, oEMPRESA.strOBJ_PORQUE)
                    Me.DataBase.AddInParameter(command, "@pTIPOEMPRESA", DbType.String, oEMPRESA.strTIPOEMPRESA)
                    Me.DataBase.AddInParameter(command, "@pCARGOREPRESENTANTE", DbType.String, oEMPRESA.strCARGOREPRESENTANTE)
                    Me.DataBase.AddInParameter(command, "@pCIUDAD", DbType.String, oEMPRESA.strCIUDAD)
                    Me.DataBase.AddInParameter(command, "@pPAIS", DbType.String, oEMPRESA.strPAIS)
                    Me.DataBase.AddInParameter(command, "@pNROEXPEDIENTE", DbType.String, oEMPRESA.strNROEXPEDIENTE)
                    Me.DataBase.AddInParameter(command, "@pTIPODOCUMENTO", DbType.String, oEMPRESA.strTIPODOCUMENTO)

                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEMPRESA.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEMPRESA.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEMPRESA.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEMPRESA.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEMPRESA.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEMPRESA.strAUD_USR_GENERICO)


                    Try
                        Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                            Dim dalcRO As New clsDALC_EMPRESARO
                            oEMPRESA = dalcRO.ReadItem(reader)
                            opLstEMPRESA.Add(oEMPRESA)
                        End Using
                    Catch ex As Exception
                        Throw ex
                        Return False
                    End Try

                End Using
            Next
            oLstEMPRESA = opLstEMPRESA
            Return True
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Metodo de Modificación de datos EMPRESA
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function ModificarEMPRESA(ByVal oLstEMPRESA As List(Of clsBE_EMPRESA)) As Boolean
            For Each oEMPRESA As clsBE_EMPRESA In oLstEMPRESA
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_Update")
                    Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oEMPRESA.lngID)
                    Me.DataBase.AddInParameter(command, "@pIDUSUARIO", DbType.Int64, oEMPRESA.lngIDUSUARIO)
                    Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, oEMPRESA.strRAZONSOCIAL)
                    Me.DataBase.AddInParameter(command, "@pREPRESENTANTE", DbType.String, oEMPRESA.strREPRESENTANTE)
                    Me.DataBase.AddInParameter(command, "@pCARGO", DbType.String, oEMPRESA.strCARGO)
                    Me.DataBase.AddInParameter(command, "@pDNI", DbType.String, oEMPRESA.strDNI)
                    Me.DataBase.AddInParameter(command, "@pRUTADNI", DbType.String, oEMPRESA.strRUTADNI)
                    Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, oEMPRESA.strRUC)
                    Me.DataBase.AddInParameter(command, "@pRUTARUC", DbType.String, oEMPRESA.strRUTARUC)
                    Me.DataBase.AddInParameter(command, "@pRUTAVIGPODER", DbType.String, oEMPRESA.strRUTAVIGPODER)
                    Me.DataBase.AddInParameter(command, "@pGIRO", DbType.String, oEMPRESA.strGIRO)
                    Me.DataBase.AddInParameter(command, "@pDET_GIRO", DbType.String, oEMPRESA.strDET_GIRO)
                    Me.DataBase.AddInParameter(command, "@pWEB", DbType.String, oEMPRESA.strWEB)
                    Me.DataBase.AddInParameter(command, "@pDOMICILIO", DbType.String, oEMPRESA.strDOMICILIO)
                    Me.DataBase.AddInParameter(command, "@pNUMPARTIDA", DbType.String, oEMPRESA.strNUMPARTIDA)
                    Me.DataBase.AddInParameter(command, "@pNUMTEL", DbType.String, oEMPRESA.strNUMTEL)
                    Me.DataBase.AddInParameter(command, "@pEMAIL", DbType.String, oEMPRESA.strEMAIL)
                    Me.DataBase.AddInParameter(command, "@pNOMPERCONTACTO", DbType.String, oEMPRESA.strNOMPERCONTACTO)
                    Me.DataBase.AddInParameter(command, "@pMSGORG", DbType.String, oEMPRESA.strMSGORG)
                    Me.DataBase.AddInParameter(command, "@pREFERENCIAS", DbType.String, oEMPRESA.strREFERENCIAS)
                    Me.DataBase.AddInParameter(command, "@pCOMPROMISO", DbType.String, oEMPRESA.strCOMPROMISO)
                    Me.DataBase.AddInParameter(command, "@pNOMBREPROGRAMASOCIAL", DbType.String, oEMPRESA.strNOMBREPROGRAMASOCIAL)
                    Me.DataBase.AddInParameter(command, "@pDET_PROGRAMASOCIAL", DbType.String, oEMPRESA.strDET_PROGRAMASOCIAL)
                    Me.DataBase.AddInParameter(command, "@pRUTALICENCIA", DbType.String, oEMPRESA.strRUTALICENCIA)
                    Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, oEMPRESA.strCOD_DPTO)
                    Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, oEMPRESA.strCOD_PROV)
                    Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, oEMPRESA.strCOD_DIST)
                    Me.DataBase.AddInParameter(command, "@pOBJETIVO", DbType.String, oEMPRESA.strOBJETIVO)
                    Me.DataBase.AddInParameter(command, "@pOBJ_PORQUE", DbType.String, oEMPRESA.strOBJ_PORQUE)
                    Me.DataBase.AddInParameter(command, "@pMONTODEUDA", DbType.Double, oEMPRESA.dblMONTODEUDA)
                    Me.DataBase.AddInParameter(command, "@pCARGOREPRESENTANTE", DbType.String, oEMPRESA.strCARGOREPRESENTANTE)
                    Me.DataBase.AddInParameter(command, "@pCIUDAD", DbType.String, oEMPRESA.strCIUDAD)
                    Me.DataBase.AddInParameter(command, "@pPAIS", DbType.String, oEMPRESA.strPAIS)
                    Me.DataBase.AddInParameter(command, "@pNROEXPEDIENTE", DbType.String, oEMPRESA.strNROEXPEDIENTE)
                    Me.DataBase.AddInParameter(command, "@pTIPODOCUMENTO", DbType.String, oEMPRESA.strTIPODOCUMENTO)


                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEMPRESA.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEMPRESA.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEMPRESA.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEMPRESA.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEMPRESA.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEMPRESA.strAUD_USR_GENERICO)
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
        ''' Proposito:  Metodo de Elimación EMPRESA
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function EliminarEMPRESA(ByVal oLstEMPRESA As List(Of clsBE_EMPRESA)) As Boolean
            For Each oEMPRESA As clsBE_EMPRESA In oLstEMPRESA
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_Delete")
                    Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oEMPRESA.lngID)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEMPRESA.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEMPRESA.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEMPRESA.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEMPRESA.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEMPRESA.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEMPRESA.strAUD_USR_GENERICO)
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
    ''' Proposito: Obtiene los valores de la tabla Abonado EMPRESA
    ''' Fecha Modificacion: 
    ''' </summary> 
    '''
    <Serializable()> _
    Public Class clsDALC_EMPRESARO
        Inherits clsDALC_Base

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Lee datos de un registro de la tabla EMPRESA y lo obtiene por su PK
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerEMPRESA(ByVal pEMPRESA As clsBE_EMPRESA) As clsBE_EMPRESA
            Dim oEMPRESA As clsBE_EMPRESA = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_GetByID")
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pEMPRESA.lngID)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oEMPRESA = Me.ReadItem(reader)
                End Using
            End Using
            Return oEMPRESA
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Lee datos de un registro de la tabla EMPRESA y lo obtiene por su PK
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerEMPRESA(ByVal xstrRuc As String, ByVal idUsuario As Long, ByVal xstrTipoPersona As String) As clsBE_EMPRESA
            Dim oEMPRESA As clsBE_EMPRESA = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_GetByRUC")
                Me.DataBase.AddInParameter(command, "@RUC", DbType.String, xstrRuc)
                Me.DataBase.AddInParameter(command, "@idUsuario", DbType.Int64, idUsuario)
                Me.DataBase.AddInParameter(command, "@TipoPersona", DbType.String, xstrTipoPersona)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oEMPRESA = Me.ReadItem(reader)
                End Using
            End Using
            Return oEMPRESA
        End Function

        Public Function ReadItem(ByVal reader As IDataReader) As clsBE_EMPRESA
            Dim item As New clsBE_EMPRESA
            While (reader.Read())
                item.lngID = iif(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDUSUARIO = iif(Convert.IsDBNull(reader("IDUSUARIO")), 0, CLngMP(reader("IDUSUARIO")))
                item.strRAZONSOCIAL = iif(Convert.IsDBNull(reader("RAZONSOCIAL")), String.Empty, CStrMP(reader("RAZONSOCIAL")))
                item.strREPRESENTANTE = iif(Convert.IsDBNull(reader("REPRESENTANTE")), String.Empty, CStrMP(reader("REPRESENTANTE")))
                item.strCARGO = iif(Convert.IsDBNull(reader("CARGO")), String.Empty, CStrMP(reader("CARGO")))
                item.strDNI = iif(Convert.IsDBNull(reader("DNI")), String.Empty, CStrMP(reader("DNI")))
                item.strRUTADNI = iif(Convert.IsDBNull(reader("RUTADNI")), String.Empty, CStrMP(reader("RUTADNI")))
                item.strRUC = iif(Convert.IsDBNull(reader("RUC")), String.Empty, CStrMP(reader("RUC")))
                item.strRUTARUC = iif(Convert.IsDBNull(reader("RUTARUC")), String.Empty, CStrMP(reader("RUTARUC")))
                item.strRUTAVIGPODER = iif(Convert.IsDBNull(reader("RUTAVIGPODER")), String.Empty, CStrMP(reader("RUTAVIGPODER")))
                item.strGIRO = iif(Convert.IsDBNull(reader("GIRO")), String.Empty, CStrMP(reader("GIRO")))
                item.strDET_GIRO = iif(Convert.IsDBNull(reader("DET_GIRO")), String.Empty, CStrMP(reader("DET_GIRO")))
                item.strWEB = iif(Convert.IsDBNull(reader("WEB")), String.Empty, CStrMP(reader("WEB")))
                item.strDOMICILIO = iif(Convert.IsDBNull(reader("DOMICILIO")), String.Empty, CStrMP(reader("DOMICILIO")))
                item.strNUMPARTIDA = iif(Convert.IsDBNull(reader("NUMPARTIDA")), String.Empty, CStrMP(reader("NUMPARTIDA")))
                item.strNUMTEL = iif(Convert.IsDBNull(reader("NUMTEL")), String.Empty, CStrMP(reader("NUMTEL")))
                item.strEMAIL = iif(Convert.IsDBNull(reader("EMAIL")), String.Empty, CStrMP(reader("EMAIL")))
                item.strNOMPERCONTACTO = iif(Convert.IsDBNull(reader("NOMPERCONTACTO")), String.Empty, CStrMP(reader("NOMPERCONTACTO")))
                item.strMSGORG = iif(Convert.IsDBNull(reader("MSGORG")), String.Empty, CStrMP(reader("MSGORG")))
                item.strREFERENCIAS = iif(Convert.IsDBNull(reader("REFERENCIAS")), String.Empty, CStrMP(reader("REFERENCIAS")))
                item.strCOMPROMISO = iif(Convert.IsDBNull(reader("COMPROMISO")), String.Empty, CStrMP(reader("COMPROMISO")))
                item.strNOMBREPROGRAMASOCIAL = iif(Convert.IsDBNull(reader("NOMBREPROGRAMASOCIAL")), String.Empty, CStrMP(reader("NOMBREPROGRAMASOCIAL")))
                item.strDET_PROGRAMASOCIAL = iif(Convert.IsDBNull(reader("DET_PROGRAMASOCIAL")), String.Empty, CStrMP(reader("DET_PROGRAMASOCIAL")))
                item.strRUTALICENCIA = iif(Convert.IsDBNull(reader("RUTALICENCIA")), String.Empty, CStrMP(reader("RUTALICENCIA")))
                item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")), String.Empty, CStrMP(reader("COD_DPTO")))
                item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")), String.Empty, CStrMP(reader("COD_PROV")))
                item.strCOD_DIST = IIf(Convert.IsDBNull(reader("COD_DIST")), String.Empty, CstrMP(reader("COD_DIST")))
                item.strNOMBREDPTO = IIf(Convert.IsDBNull(reader("DEPARTAMENTO")), String.Empty, CstrMP(reader("DEPARTAMENTO")))
                item.strNOMBREPROV = IIf(Convert.IsDBNull(reader("PROVINCIA")), String.Empty, CstrMP(reader("PROVINCIA")))
                item.strNOMBREDIST = IIf(Convert.IsDBNull(reader("DISTRITO")), String.Empty, CstrMP(reader("DISTRITO")))
                item.strOBJETIVO = iif(Convert.IsDBNull(reader("OBJETIVO")), String.Empty, CStrMP(reader("OBJETIVO")))
                item.strOBJ_PORQUE = IIf(Convert.IsDBNull(reader("OBJ_PORQUE")), String.Empty, CstrMP(reader("OBJ_PORQUE")))
                item.strTIPOEMPRESA = IIf(Convert.IsDBNull(reader("TIPO_EMPRESA")), String.Empty, CstrMP(reader("TIPO_EMPRESA")))
                item.dblMONTODEUDA = IIf(Convert.IsDBNull(reader("MONTO_DEUDA")), String.Empty, CstrMP(reader("MONTO_DEUDA")))
                item.strCARGOREPRESENTANTE = IIf(Convert.IsDBNull(reader("CARGO_REPRESENTANTE")), String.Empty, CstrMP(reader("CARGO_REPRESENTANTE")))
                item.strCIUDAD = IIf(Convert.IsDBNull(reader("CIUDAD")), String.Empty, CstrMP(reader("CIUDAD")))
                item.strPAIS = IIf(Convert.IsDBNull(reader("PAIS")), String.Empty, CstrMP(reader("PAIS")))
                item.strNROEXPEDIENTE = IIf(Convert.IsDBNull(reader("NRO_EXPEDIENTE")), String.Empty, CstrMP(reader("NRO_EXPEDIENTE")))
                item.strTIPODOCUMENTO = IIf(Convert.IsDBNull(reader("TIPO_DOCUMENTO")), String.Empty, CstrMP(reader("TIPO_DOCUMENTO")))
                item.strRENOVACION = IIf(Convert.IsDBNull(reader("RENOVACION")), String.Empty, CstrMP(reader("RENOVACION")))
            End While
            Return item
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de todos los registros de la entidad: EMPRESA
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaEMPRESA() As List(Of clsBE_EMPRESA)
            Dim olstEMPRESA As New List(Of clsBE_EMPRESA)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_SelLst")
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    olstEMPRESA = Me.ReadListItem(reader)
                End Using
            End Using
            Return olstEMPRESA
        End Function

        Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_EMPRESA)
            Dim result As List(Of clsBE_EMPRESA) = New List(Of clsBE_EMPRESA)
            While (reader.Read())
                Dim item As New clsBE_EMPRESA
                item.lngID = iif(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDUSUARIO = iif(Convert.IsDBNull(reader("IDUSUARIO")), 0, CLngMP(reader("IDUSUARIO")))
                item.strRAZONSOCIAL = iif(Convert.IsDBNull(reader("RAZONSOCIAL")), String.Empty, CStrMP(reader("RAZONSOCIAL")))
                item.strREPRESENTANTE = iif(Convert.IsDBNull(reader("REPRESENTANTE")), String.Empty, CStrMP(reader("REPRESENTANTE")))
                item.strCARGO = iif(Convert.IsDBNull(reader("CARGO")), String.Empty, CStrMP(reader("CARGO")))
                item.strDNI = iif(Convert.IsDBNull(reader("DNI")), String.Empty, CStrMP(reader("DNI")))
                item.strRUTADNI = iif(Convert.IsDBNull(reader("RUTADNI")), String.Empty, CStrMP(reader("RUTADNI")))
                item.strRUC = iif(Convert.IsDBNull(reader("RUC")), String.Empty, CStrMP(reader("RUC")))
                item.strRUTARUC = iif(Convert.IsDBNull(reader("RUTARUC")), String.Empty, CStrMP(reader("RUTARUC")))
                item.strRUTAVIGPODER = iif(Convert.IsDBNull(reader("RUTAVIGPODER")), String.Empty, CStrMP(reader("RUTAVIGPODER")))
                item.strGIRO = iif(Convert.IsDBNull(reader("GIRO")), String.Empty, CStrMP(reader("GIRO")))
                item.strDET_GIRO = iif(Convert.IsDBNull(reader("DET_GIRO")), String.Empty, CStrMP(reader("DET_GIRO")))
                item.strWEB = iif(Convert.IsDBNull(reader("WEB")), String.Empty, CStrMP(reader("WEB")))
                item.strDOMICILIO = iif(Convert.IsDBNull(reader("DOMICILIO")), String.Empty, CStrMP(reader("DOMICILIO")))
                item.strNUMPARTIDA = iif(Convert.IsDBNull(reader("NUMPARTIDA")), String.Empty, CStrMP(reader("NUMPARTIDA")))
                item.strNUMTEL = iif(Convert.IsDBNull(reader("NUMTEL")), String.Empty, CStrMP(reader("NUMTEL")))
                item.strEMAIL = iif(Convert.IsDBNull(reader("EMAIL")), String.Empty, CStrMP(reader("EMAIL")))
                item.strNOMPERCONTACTO = iif(Convert.IsDBNull(reader("NOMPERCONTACTO")), String.Empty, CStrMP(reader("NOMPERCONTACTO")))
                item.strMSGORG = iif(Convert.IsDBNull(reader("MSGORG")), String.Empty, CStrMP(reader("MSGORG")))
                item.strREFERENCIAS = iif(Convert.IsDBNull(reader("REFERENCIAS")), String.Empty, CStrMP(reader("REFERENCIAS")))
                item.strCOMPROMISO = iif(Convert.IsDBNull(reader("COMPROMISO")), String.Empty, CStrMP(reader("COMPROMISO")))
                item.strNOMBREPROGRAMASOCIAL = iif(Convert.IsDBNull(reader("NOMBREPROGRAMASOCIAL")), String.Empty, CStrMP(reader("NOMBREPROGRAMASOCIAL")))
                item.strDET_PROGRAMASOCIAL = iif(Convert.IsDBNull(reader("DET_PROGRAMASOCIAL")), String.Empty, CStrMP(reader("DET_PROGRAMASOCIAL")))
                item.strRUTALICENCIA = iif(Convert.IsDBNull(reader("RUTALICENCIA")), String.Empty, CStrMP(reader("RUTALICENCIA")))
                item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")), String.Empty, CStrMP(reader("COD_DPTO")))
                item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")), String.Empty, CStrMP(reader("COD_PROV")))
                item.strCOD_DIST = IIf(Convert.IsDBNull(reader("COD_DIST")), String.Empty, CstrMP(reader("COD_DIST")))
                item.strNOMBREDPTO = IIf(Convert.IsDBNull(reader("DEPARTAMENTO")), String.Empty, CstrMP(reader("DEPARTAMENTO")))
                item.strNOMBREPROV = IIf(Convert.IsDBNull(reader("PROVINCIA")), String.Empty, CstrMP(reader("PROVINCIA")))
                item.strNOMBREDIST = IIf(Convert.IsDBNull(reader("DISTRITO")), String.Empty, CstrMP(reader("DISTRITO")))
                item.strOBJETIVO = iif(Convert.IsDBNull(reader("OBJETIVO")), String.Empty, CStrMP(reader("OBJETIVO")))
                item.strOBJ_PORQUE = IIf(Convert.IsDBNull(reader("OBJ_PORQUE")), String.Empty, CstrMP(reader("OBJ_PORQUE")))
                item.strCARGOREPRESENTANTE = IIf(Convert.IsDBNull(reader("CARGO_REPRESENTANTE")), String.Empty, CstrMP(reader("CARGO_REPRESENTANTE")))
                item.strCIUDAD = IIf(Convert.IsDBNull(reader("CIUDAD")), String.Empty, CstrMP(reader("CIUDAD")))
                item.strPAIS = IIf(Convert.IsDBNull(reader("PAIS")), String.Empty, CstrMP(reader("PAIS")))
                item.strNROEXPEDIENTE = IIf(Convert.IsDBNull(reader("NRO_EXPEDIENTE")), String.Empty, CstrMP(reader("NRO_EXPEDIENTE")))
                item.strTIPODOCUMENTO = IIf(Convert.IsDBNull(reader("TIPO_DOCUMENTO")), String.Empty, CstrMP(reader("TIPO_DOCUMENTO")))
                item.strRENOVACION = IIf(Convert.IsDBNull(reader("RENOVACION")), String.Empty, CstrMP(reader("RENOVACION")))
                result.Add(item)
            End While
            Return result
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de registros de la entidad EMPRESA Paginado en Base de datos
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaEMPRESA_Paged(ByVal pEMPRESA As clsBE_EMPRESA) As List(Of clsBE_EMPRESA)
            Dim intCount As Int32 = 0
            Dim olstEMPRESA As New List(Of clsBE_EMPRESA)
            Dim mintItem As Integer = 0
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_SelLst_Paged")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pEMPRESA.intPAGESIZE)
                Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32, pEMPRESA.intCURRENTPAGE)
                Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
                'Atributos de la Entidad
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pEMPRESA.lngID)
                Me.DataBase.AddInParameter(command, "@pIDUSUARIO", DbType.Int64, pEMPRESA.lngIDUSUARIO)
                Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, pEMPRESA.strRAZONSOCIAL)
                Me.DataBase.AddInParameter(command, "@pREPRESENTANTE", DbType.String, pEMPRESA.strREPRESENTANTE)
                Me.DataBase.AddInParameter(command, "@pCARGO", DbType.String, pEMPRESA.strCARGO)
                Me.DataBase.AddInParameter(command, "@pDNI", DbType.String, pEMPRESA.strDNI)
                Me.DataBase.AddInParameter(command, "@pRUTADNI", DbType.String, pEMPRESA.strRUTADNI)
                Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, pEMPRESA.strRUC)
                Me.DataBase.AddInParameter(command, "@pRUTARUC", DbType.String, pEMPRESA.strRUTARUC)
                Me.DataBase.AddInParameter(command, "@pRUTAVIGPODER", DbType.String, pEMPRESA.strRUTAVIGPODER)
                Me.DataBase.AddInParameter(command, "@pGIRO", DbType.String, pEMPRESA.strGIRO)
                Me.DataBase.AddInParameter(command, "@pDET_GIRO", DbType.String, pEMPRESA.strDET_GIRO)
                Me.DataBase.AddInParameter(command, "@pWEB", DbType.String, pEMPRESA.strWEB)
                Me.DataBase.AddInParameter(command, "@pDOMICILIO", DbType.String, pEMPRESA.strDOMICILIO)
                Me.DataBase.AddInParameter(command, "@pNUMPARTIDA", DbType.String, pEMPRESA.strNUMPARTIDA)
                Me.DataBase.AddInParameter(command, "@pNUMTEL", DbType.String, pEMPRESA.strNUMTEL)
                Me.DataBase.AddInParameter(command, "@pEMAIL", DbType.String, pEMPRESA.strEMAIL)
                Me.DataBase.AddInParameter(command, "@pNOMPERCONTACTO", DbType.String, pEMPRESA.strNOMPERCONTACTO)
                Me.DataBase.AddInParameter(command, "@pMSGORG", DbType.String, pEMPRESA.strMSGORG)
                Me.DataBase.AddInParameter(command, "@pREFERENCIAS", DbType.String, pEMPRESA.strREFERENCIAS)
                Me.DataBase.AddInParameter(command, "@pCOMPROMISO", DbType.String, pEMPRESA.strCOMPROMISO)
                Me.DataBase.AddInParameter(command, "@pNOMBREPROGRAMASOCIAL", DbType.String, pEMPRESA.strNOMBREPROGRAMASOCIAL)
                Me.DataBase.AddInParameter(command, "@pDET_PROGRAMASOCIAL", DbType.String, pEMPRESA.strDET_PROGRAMASOCIAL)
                Me.DataBase.AddInParameter(command, "@pRUTALICENCIA", DbType.String, pEMPRESA.strRUTALICENCIA)
                Me.DataBase.AddInParameter(command, "@pCOD_DPTO", DbType.String, pEMPRESA.strCOD_DPTO)
                Me.DataBase.AddInParameter(command, "@pCOD_PROV", DbType.String, pEMPRESA.strCOD_PROV)
                Me.DataBase.AddInParameter(command, "@pCOD_DIST", DbType.String, pEMPRESA.strCOD_DIST)
                Me.DataBase.AddInParameter(command, "@pOBJETIVO", DbType.String, pEMPRESA.strOBJETIVO)
                Me.DataBase.AddInParameter(command, "@pOBJ_PORQUE", DbType.String, pEMPRESA.strOBJ_PORQUE)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
                    olstEMPRESA = Me.ReadListItemPaged(reader, intCount)
                End Using
            End Using
            Return olstEMPRESA
        End Function

        Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_EMPRESA)
            Dim result As List(Of clsBE_EMPRESA) = New List(Of clsBE_EMPRESA)
            While (reader.Read())
                Dim item As New clsBE_EMPRESA
                'Atributos de paged del result set que devuelve el store
                item.intITEMCOUNT = intCount
                item.lngID = iif(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDUSUARIO = iif(Convert.IsDBNull(reader("IDUSUARIO")), 0, CLngMP(reader("IDUSUARIO")))
                item.strRAZONSOCIAL = iif(Convert.IsDBNull(reader("RAZONSOCIAL")), String.Empty, CStrMP(reader("RAZONSOCIAL")))
                item.strREPRESENTANTE = iif(Convert.IsDBNull(reader("REPRESENTANTE")), String.Empty, CStrMP(reader("REPRESENTANTE")))
                item.strCARGO = iif(Convert.IsDBNull(reader("CARGO")), String.Empty, CStrMP(reader("CARGO")))
                item.strDNI = iif(Convert.IsDBNull(reader("DNI")), String.Empty, CStrMP(reader("DNI")))
                item.strRUTADNI = iif(Convert.IsDBNull(reader("RUTADNI")), String.Empty, CStrMP(reader("RUTADNI")))
                item.strRUC = iif(Convert.IsDBNull(reader("RUC")), String.Empty, CStrMP(reader("RUC")))
                item.strRUTARUC = iif(Convert.IsDBNull(reader("RUTARUC")), String.Empty, CStrMP(reader("RUTARUC")))
                item.strRUTAVIGPODER = iif(Convert.IsDBNull(reader("RUTAVIGPODER")), String.Empty, CStrMP(reader("RUTAVIGPODER")))
                item.strGIRO = iif(Convert.IsDBNull(reader("GIRO")), String.Empty, CStrMP(reader("GIRO")))
                item.strDET_GIRO = iif(Convert.IsDBNull(reader("DET_GIRO")), String.Empty, CStrMP(reader("DET_GIRO")))
                item.strWEB = iif(Convert.IsDBNull(reader("WEB")), String.Empty, CStrMP(reader("WEB")))
                item.strDOMICILIO = iif(Convert.IsDBNull(reader("DOMICILIO")), String.Empty, CStrMP(reader("DOMICILIO")))
                item.strNUMPARTIDA = iif(Convert.IsDBNull(reader("NUMPARTIDA")), String.Empty, CStrMP(reader("NUMPARTIDA")))
                item.strNUMTEL = iif(Convert.IsDBNull(reader("NUMTEL")), String.Empty, CStrMP(reader("NUMTEL")))
                item.strEMAIL = iif(Convert.IsDBNull(reader("EMAIL")), String.Empty, CStrMP(reader("EMAIL")))
                item.strNOMPERCONTACTO = iif(Convert.IsDBNull(reader("NOMPERCONTACTO")), String.Empty, CStrMP(reader("NOMPERCONTACTO")))
                item.strMSGORG = iif(Convert.IsDBNull(reader("MSGORG")), String.Empty, CStrMP(reader("MSGORG")))
                item.strREFERENCIAS = iif(Convert.IsDBNull(reader("REFERENCIAS")), String.Empty, CStrMP(reader("REFERENCIAS")))
                item.strCOMPROMISO = iif(Convert.IsDBNull(reader("COMPROMISO")), String.Empty, CStrMP(reader("COMPROMISO")))
                item.strNOMBREPROGRAMASOCIAL = iif(Convert.IsDBNull(reader("NOMBREPROGRAMASOCIAL")), String.Empty, CStrMP(reader("NOMBREPROGRAMASOCIAL")))
                item.strDET_PROGRAMASOCIAL = iif(Convert.IsDBNull(reader("DET_PROGRAMASOCIAL")), String.Empty, CStrMP(reader("DET_PROGRAMASOCIAL")))
                item.strRUTALICENCIA = iif(Convert.IsDBNull(reader("RUTALICENCIA")), String.Empty, CStrMP(reader("RUTALICENCIA")))
                item.strCOD_DPTO = iif(Convert.IsDBNull(reader("COD_DPTO")), String.Empty, CStrMP(reader("COD_DPTO")))
                item.strCOD_PROV = iif(Convert.IsDBNull(reader("COD_PROV")), String.Empty, CStrMP(reader("COD_PROV")))
                item.strCOD_DIST = IIf(Convert.IsDBNull(reader("COD_DIST")), String.Empty, CstrMP(reader("COD_DIST")))
                item.strNOMBREDPTO = IIf(Convert.IsDBNull(reader("DEPARTAMENTO")), String.Empty, CstrMP(reader("DEPARTAMENTO")))
                item.strNOMBREPROV = IIf(Convert.IsDBNull(reader("PROVINCIA")), String.Empty, CstrMP(reader("PROVINCIA")))
                item.strNOMBREDIST = IIf(Convert.IsDBNull(reader("DISTRITO")), String.Empty, CstrMP(reader("DISTRITO")))
                item.strOBJETIVO = iif(Convert.IsDBNull(reader("OBJETIVO")), String.Empty, CStrMP(reader("OBJETIVO")))
                item.strOBJ_PORQUE = IIf(Convert.IsDBNull(reader("OBJ_PORQUE")), String.Empty, CstrMP(reader("OBJ_PORQUE")))
                item.strRENOVACION = IIf(Convert.IsDBNull(reader("RENOVACION")), String.Empty, CstrMP(reader("RENOVACION")))
                result.Add(item)
            End While
            Return result
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS EMPRESA
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaToDTEMPRESA() As Datatable
            Dim oDTEMPRESA As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_SelLst")
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTEMPRESA
        End Function

        Public Function LeerListaToEMPRESABYCLIENTUSER(ByVal lngIDClient As Long) As DataTable
            Dim oDTEMPRESA As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EMPRESA_SelLstByClientUser")
                Me.DataBase.AddInParameter(command, "@pIdUser", DbType.Int64, lngIDClient)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTEMPRESA
        End Function
    End Class
#End Region
End Namespace