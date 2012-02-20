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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EVENTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_EVENTOTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function InsertarEVENTO(ByRef oLstEVENTO As List(Of clsBE_EVENTO)) As Boolean

            Dim opLstEVENTO As New List(Of clsBE_EVENTO)
            For Each oEVENTO As clsBE_EVENTO In oLstEVENTO
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_Insert")
                    Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oEVENTO.lngIDSOLICITUD)
                    Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oEVENTO.strNOMBRE)
                    Me.DataBase.AddInParameter(command, "@pORGANIZADOR", DbType.String, oEVENTO.strORGANIZADOR)
                    Me.DataBase.AddInParameter(command, "@pREFERENCIA", DbType.String, oEVENTO.strREFERENCIA)
                    Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oEVENTO.strDESCRIPCION)
                    Me.DataBase.AddInParameter(command, "@pRUTAAGENDA", DbType.String, oEVENTO.strRUTAAGENDA)
                    Me.DataBase.AddInParameter(command, "@pNUMEDICION", DbType.String, oEVENTO.strNUMEDICION)
                    Me.DataBase.AddInParameter(command, "@pTIPOPERIODO", DbType.Int32, oEVENTO.intTIPOPERIODO)
                    Me.DataBase.AddInParameter(command, "@pLUGAR", DbType.String, oEVENTO.strLUGAR)
                    Me.DataBase.AddInParameter(command, "@pFECHA", DbType.String, oEVENTO.dtmFECHA)
                    Me.DataBase.AddInParameter(command, "@pDESCPUBLICOGRL", DbType.String, oEVENTO.strDESCPUBLICOGRL)
                    Me.DataBase.AddInParameter(command, "@pNUMPART", DbType.Int32, oEVENTO.intNUMPART)
                    Me.DataBase.AddInParameter(command, "@pCOSTOPROM", DbType.Double, oEVENTO.dblCOSTOPROM)
                    Me.DataBase.AddInParameter(command, "@pAUSPICIADORES", DbType.String, oEVENTO.strAUSPICIADORES)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEVENTO.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEVENTO.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEVENTO.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEVENTO.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEVENTO.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEVENTO.strAUD_USR_GENERICO)
                    Try
                        Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                            Dim dalcRO As New clsDALC_EVENTORO
                            oEVENTO = dalcRO.ReadItem(reader)
                            opLstEVENTO.Add(oEVENTO)
                        End Using
                    Catch ex As Exception
                        Throw ex
                        Return False
                    End Try
                End Using
            Next
            oLstEVENTO = opLstEVENTO
            Return True
        End Function

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Modificación de datos EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarEVENTO(ByVal oLstEVENTO As List(Of clsBE_EVENTO)) As Boolean
			For Each oEVENTO As clsBE_EVENTO In oLstEVENTO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oEVENTO.lngID)
                    Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, oEVENTO.lngIDSOLICITUD)
                    Me.DataBase.AddInParameter(command, "@pNOMBRE", DbType.String, oEVENTO.strNOMBRE)
					Me.DataBase.AddInParameter(command, "@pORGANIZADOR", DbType.String, oEVENTO.strORGANIZADOR)
					Me.DataBase.AddInParameter(command, "@pREFERENCIA", DbType.String, oEVENTO.strREFERENCIA)
					Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, oEVENTO.strDESCRIPCION)
					Me.DataBase.AddInParameter(command, "@pRUTAAGENDA", DbType.String, oEVENTO.strRUTAAGENDA)
					Me.DataBase.AddInParameter(command, "@pNUMEDICION", DbType.String, oEVENTO.strNUMEDICION)
					Me.DataBase.AddInParameter(command, "@pTIPOPERIODO", DbType.Int32, oEVENTO.intTIPOPERIODO)
					Me.DataBase.AddInParameter(command, "@pLUGAR", DbType.String, oEVENTO.strLUGAR)
                    Me.DataBase.AddInParameter(command, "@pFECHA", DbType.String, oEVENTO.dtmFECHA)
					Me.DataBase.AddInParameter(command, "@pDESCPUBLICOGRL", DbType.String, oEVENTO.strDESCPUBLICOGRL)
					Me.DataBase.AddInParameter(command, "@pNUMPART", DbType.Int32, oEVENTO.intNUMPART)
					Me.DataBase.AddInParameter(command, "@pCOSTOPROM", DbType.Double, oEVENTO.dblCOSTOPROM)
					Me.DataBase.AddInParameter(command, "@pAUSPICIADORES", DbType.String, oEVENTO.strAUSPICIADORES)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEVENTO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEVENTO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEVENTO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEVENTO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEVENTO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEVENTO.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarEVENTO(ByVal oLstEVENTO As List(Of clsBE_EVENTO)) As Boolean
			For Each oEVENTO As clsBE_EVENTO In oLstEVENTO
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oEVENTO.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oEVENTO.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oEVENTO.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oEVENTO.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oEVENTO.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oEVENTO.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oEVENTO.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado EVENTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_EVENTORO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla EVENTO y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerEVENTO(ByVal pEVENTO As clsBE_EVENTO) As clsBE_EVENTO
			Dim oEVENTO As clsBE_EVENTO = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pEVENTO.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oEVENTO = Me.ReadItem(reader)
				End Using
			End Using
			Return oEVENTO
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Lee datos de un registro de la tabla EVENTO y lo obtiene por su PK
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerEVENTO(ByVal IDSol As Long) As clsBE_EVENTO
            Dim oEVENTO As clsBE_EVENTO = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_GetByIDSol")
                Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, IDSol)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oEVENTO = Me.ReadItem(reader)
                End Using
            End Using
            Return oEVENTO
        End Function

        Public Function ReadItem(ByVal reader As IDataReader) As clsBE_EVENTO
            Dim item As New clsBE_EVENTO
            While (reader.Read())
                item.lngID = IIf(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDSOLICITUD = IIf(Convert.IsDBNull(reader("IDSOLICITUD")), 0, CLngMP(reader("IDSOLICITUD")))
                item.strNOMBRE = IIf(Convert.IsDBNull(reader("NOMBRE")), String.Empty, CstrMP(reader("NOMBRE")))
                item.strORGANIZADOR = IIf(Convert.IsDBNull(reader("ORGANIZADOR")), String.Empty, CstrMP(reader("ORGANIZADOR")))
                item.strREFERENCIA = iif(Convert.IsDBNull(reader("REFERENCIA")), String.Empty, CStrMP(reader("REFERENCIA")))
                item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")), String.Empty, CStrMP(reader("DESCRIPCION")))
                item.strRUTAAGENDA = iif(Convert.IsDBNull(reader("RUTAAGENDA")), String.Empty, CStrMP(reader("RUTAAGENDA")))
                item.strNUMEDICION = iif(Convert.IsDBNull(reader("NUMEDICION")), String.Empty, CStrMP(reader("NUMEDICION")))
                item.intTIPOPERIODO = IIf(Convert.IsDBNull(reader("TIPOPERIODO")), 0, CIntMP(reader("TIPOPERIODO")))
                item.strPERIODO = IIf(Convert.IsDBNull(reader("PERIODO")), String.Empty, CstrMP(reader("PERIODO")))
                item.strLUGAR = iif(Convert.IsDBNull(reader("LUGAR")), String.Empty, CStrMP(reader("LUGAR")))
                item.dtmFECHA = IIf(Convert.IsDBNull(reader("FECHA")), String.Empty, CstrMP(reader("FECHA")))
                item.strDESCPUBLICOGRL = iif(Convert.IsDBNull(reader("DESCPUBLICOGRL")), String.Empty, CStrMP(reader("DESCPUBLICOGRL")))
                item.intNUMPART = iif(Convert.IsDBNull(reader("NUMPART")), 0, CIntMP(reader("NUMPART")))
                item.dblCOSTOPROM = iif(Convert.IsDBNull(reader("COSTOPROM")), 0, CDblMP(reader("COSTOPROM")))
                item.strAUSPICIADORES = iif(Convert.IsDBNull(reader("AUSPICIADORES")), String.Empty, CStrMP(reader("AUSPICIADORES")))
            End While
            Return item
        End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaEVENTO() As List(Of clsBE_EVENTO)
			Dim olstEVENTO As New List(Of clsBE_EVENTO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstEVENTO = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstEVENTO
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_EVENTO)
			Dim result As List(Of  clsBE_EVENTO) = New List(Of clsBE_EVENTO)
			While (reader.Read())
				dim item as new clsBE_EVENTO
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
                item.lngIDSOLICITUD = IIf(Convert.IsDBNull(reader("IDSOLICITUD")), 0, CLngMP(reader("IDSOLICITUD")))
                item.strNOMBRE = IIf(Convert.IsDBNull(reader("NOMBRE")), String.Empty, CstrMP(reader("NOMBRE")))
                item.strORGANIZADOR = IIf(Convert.IsDBNull(reader("ORGANIZADOR")), String.Empty, CstrMP(reader("ORGANIZADOR")))
				item.strREFERENCIA = iif(Convert.IsDBNull(reader("REFERENCIA")),String.Empty,CStrMP(reader("REFERENCIA")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				item.strRUTAAGENDA = iif(Convert.IsDBNull(reader("RUTAAGENDA")),String.Empty,CStrMP(reader("RUTAAGENDA")))
				item.strNUMEDICION = iif(Convert.IsDBNull(reader("NUMEDICION")),String.Empty,CStrMP(reader("NUMEDICION")))
				item.intTIPOPERIODO = iif(Convert.IsDBNull(reader("TIPOPERIODO")),0,CIntMP(reader("TIPOPERIODO")))
				item.strLUGAR = iif(Convert.IsDBNull(reader("LUGAR")),String.Empty,CStrMP(reader("LUGAR")))
                item.dtmFECHA = IIf(Convert.IsDBNull(reader("FECHA")), String.Empty, CstrMP(reader("FECHA")))
				item.strDESCPUBLICOGRL = iif(Convert.IsDBNull(reader("DESCPUBLICOGRL")),String.Empty,CStrMP(reader("DESCPUBLICOGRL")))
				item.intNUMPART = iif(Convert.IsDBNull(reader("NUMPART")),0,CIntMP(reader("NUMPART")))
				item.dblCOSTOPROM = iif(Convert.IsDBNull(reader("COSTOPROM")),0,CDblMP(reader("COSTOPROM")))
				item.strAUSPICIADORES = iif(Convert.IsDBNull(reader("AUSPICIADORES")),String.Empty,CStrMP(reader("AUSPICIADORES")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad EVENTO Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaEVENTO_Paged(ByVal pEVENTO As clsBE_EVENTO) As List(Of clsBE_EVENTO)
			Dim intCount As Int32 = 0
			Dim olstEVENTO As New List(Of clsBE_EVENTO)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pEVENTO.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pEVENTO.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pEVENTO.lngID)
				Me.DataBase.AddInParameter(command, "@pIDSOLICITUD", DbType.Int64, pEVENTO.lngIDSOLICITUD)
				Me.DataBase.AddInParameter(command, "@pORGANIZADOR", DbType.String, pEVENTO.strORGANIZADOR)
				Me.DataBase.AddInParameter(command, "@pREFERENCIA", DbType.String, pEVENTO.strREFERENCIA)
				Me.DataBase.AddInParameter(command, "@pDESCRIPCION", DbType.String, pEVENTO.strDESCRIPCION)
				Me.DataBase.AddInParameter(command, "@pRUTAAGENDA", DbType.String, pEVENTO.strRUTAAGENDA)
				Me.DataBase.AddInParameter(command, "@pNUMEDICION", DbType.String, pEVENTO.strNUMEDICION)
				Me.DataBase.AddInParameter(command, "@pTIPOPERIODO", DbType.Int32, pEVENTO.intTIPOPERIODO)
				Me.DataBase.AddInParameter(command, "@pLUGAR", DbType.String, pEVENTO.strLUGAR)
                Me.DataBase.AddInParameter(command, "@pFECHA", DbType.String, pEVENTO.dtmFECHA)
				Me.DataBase.AddInParameter(command, "@pDESCPUBLICOGRL", DbType.String, pEVENTO.strDESCPUBLICOGRL)
				Me.DataBase.AddInParameter(command, "@pNUMPART", DbType.Int32, pEVENTO.intNUMPART)
				Me.DataBase.AddInParameter(command, "@pCOSTOPROM", DbType.Double, pEVENTO.dblCOSTOPROM)
				Me.DataBase.AddInParameter(command, "@pAUSPICIADORES", DbType.String, pEVENTO.strAUSPICIADORES)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstEVENTO = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstEVENTO
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_EVENTO)
			Dim result As List(Of  clsBE_EVENTO) = New List(Of clsBE_EVENTO)
			While (reader.Read())
				dim item as new clsBE_EVENTO
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDSOLICITUD = iif(Convert.IsDBNull(reader("IDSOLICITUD")),0,CLngMP(reader("IDSOLICITUD")))
				item.strORGANIZADOR = iif(Convert.IsDBNull(reader("ORGANIZADOR")),String.Empty,CStrMP(reader("ORGANIZADOR")))
				item.strREFERENCIA = iif(Convert.IsDBNull(reader("REFERENCIA")),String.Empty,CStrMP(reader("REFERENCIA")))
				item.strDESCRIPCION = iif(Convert.IsDBNull(reader("DESCRIPCION")),String.Empty,CStrMP(reader("DESCRIPCION")))
				item.strRUTAAGENDA = iif(Convert.IsDBNull(reader("RUTAAGENDA")),String.Empty,CStrMP(reader("RUTAAGENDA")))
				item.strNUMEDICION = iif(Convert.IsDBNull(reader("NUMEDICION")),String.Empty,CStrMP(reader("NUMEDICION")))
				item.intTIPOPERIODO = iif(Convert.IsDBNull(reader("TIPOPERIODO")),0,CIntMP(reader("TIPOPERIODO")))
				item.strLUGAR = iif(Convert.IsDBNull(reader("LUGAR")),String.Empty,CStrMP(reader("LUGAR")))
                item.dtmFECHA = IIf(Convert.IsDBNull(reader("FECHA")), String.Empty, CstrMP(reader("FECHA")))
				item.strDESCPUBLICOGRL = iif(Convert.IsDBNull(reader("DESCPUBLICOGRL")),String.Empty,CStrMP(reader("DESCPUBLICOGRL")))
				item.intNUMPART = iif(Convert.IsDBNull(reader("NUMPART")),0,CIntMP(reader("NUMPART")))
				item.dblCOSTOPROM = iif(Convert.IsDBNull(reader("COSTOPROM")),0,CDblMP(reader("COSTOPROM")))
				item.strAUSPICIADORES = iif(Convert.IsDBNull(reader("AUSPICIADORES")),String.Empty,CStrMP(reader("AUSPICIADORES")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTEVENTO() As Datatable
			Dim oDTEVENTO As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_EVENTO_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTEVENTO
		End Function

	End Class
#End Region
End Namespace


