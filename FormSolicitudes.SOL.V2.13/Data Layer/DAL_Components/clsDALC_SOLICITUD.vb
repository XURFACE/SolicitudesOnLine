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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla SOLICITUD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_SOLICITUDTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function InsertarSOLICITUD(ByRef oLstSOLICITUD As List(Of clsBE_SOLICITUD)) As Boolean

            Dim opLstSOLICITUD As New List(Of clsBE_SOLICITUD)

            For Each oSOLICITUD As clsBE_SOLICITUD In oLstSOLICITUD
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_Insert")
                    Me.DataBase.AddInParameter(command, "@pIDEMP", DbType.Int64, oSOLICITUD.lngIDEMP)
                    Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oSOLICITUD.strTIPOLIC)
                    Me.DataBase.AddInParameter(command, "@pRPTAUSOMARCAPAIS", DbType.String, oSOLICITUD.strRPTAUSOMARCAPAIS)
                    Me.DataBase.AddInParameter(command, "@pIDAPLICACION", DbType.Int32, oSOLICITUD.intIDAPLICACION)
                    Me.DataBase.AddInParameter(command, "@pSTSSOL", DbType.String, oSOLICITUD.strSTSSOL)
                    Me.DataBase.AddInParameter(command, "@pREFCONSULADO", DbType.String, oSOLICITUD.strREFCONSULADO)
                    Me.DataBase.AddInParameter(command, "@pDECLARACIONJUR", DbType.String, oSOLICITUD.strDECLARACIONJUR)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oSOLICITUD.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oSOLICITUD.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oSOLICITUD.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oSOLICITUD.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oSOLICITUD.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oSOLICITUD.strAUD_USR_GENERICO)



                    Try
                        Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                            Dim dalcRO As New clsDALC_SOLICITUDRO
                            oSOLICITUD = dalcRO.ReadItem(reader)
                            opLstSOLICITUD.Add(oSOLICITUD)
                        End Using
                    Catch ex As Exception
                        Throw ex
                        Return False
                    End Try
                End Using
            Next
            oLstSOLICITUD = opLstSOLICITUD
            Return True
        End Function

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Modificación de datos SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarSOLICITUD(ByVal oLstSOLICITUD As List(Of clsBE_SOLICITUD)) As Boolean
			For Each oSOLICITUD As clsBE_SOLICITUD In oLstSOLICITUD
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oSOLICITUD.lngID)
					Me.DataBase.AddInParameter(command, "@pIDEMP", DbType.Int64, oSOLICITUD.lngIDEMP)
					Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, oSOLICITUD.strTIPOLIC)
					Me.DataBase.AddInParameter(command, "@pRPTAUSOMARCAPAIS", DbType.String, oSOLICITUD.strRPTAUSOMARCAPAIS)
					Me.DataBase.AddInParameter(command, "@pIDAPLICACION", DbType.Int32, oSOLICITUD.intIDAPLICACION)
                    Me.DataBase.AddInParameter(command, "@pSTSSOL", DbType.String, oSOLICITUD.strSTSSOL)
                    Me.DataBase.AddInParameter(command, "@pREFCONSULADO", DbType.String, oSOLICITUD.strREFCONSULADO)
                    Me.DataBase.AddInParameter(command, "@pDECLARACIONJUR", DbType.String, oSOLICITUD.strDECLARACIONJUR)

                    'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oSOLICITUD.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oSOLICITUD.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oSOLICITUD.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oSOLICITUD.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oSOLICITUD.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oSOLICITUD.strAUD_USR_GENERICO) 
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
		''' Proposito:  Metodo de Elimación SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarSOLICITUD(ByVal oLstSOLICITUD As List(Of clsBE_SOLICITUD)) As Boolean
			For Each oSOLICITUD As clsBE_SOLICITUD In oLstSOLICITUD
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oSOLICITUD.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oSOLICITUD.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oSOLICITUD.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oSOLICITUD.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oSOLICITUD.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oSOLICITUD.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oSOLICITUD.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado SOLICITUD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_SOLICITUDRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla SOLICITUD y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerSOLICITUD(ByVal pSOLICITUD As clsBE_SOLICITUD) As clsBE_SOLICITUD
			Dim oSOLICITUD As clsBE_SOLICITUD = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pSOLICITUD.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oSOLICITUD = Me.ReadItem(reader)
				End Using
			End Using
			Return oSOLICITUD
		End Function

        Public Function ReadItem(ByVal reader As IDataReader) As clsBE_SOLICITUD
            Dim item As New clsBE_SOLICITUD
            While (reader.Read())
                item.lngID = iif(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
                item.lngIDEMP = iif(Convert.IsDBNull(reader("IDEMP")), 0, CLngMP(reader("IDEMP")))
                item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")), String.Empty, CStrMP(reader("TIPOLIC")))
                item.strRPTAUSOMARCAPAIS = iif(Convert.IsDBNull(reader("RPTAUSOMARCAPAIS")), String.Empty, CStrMP(reader("RPTAUSOMARCAPAIS")))
                item.intIDAPLICACION = iif(Convert.IsDBNull(reader("IDAPLICACION")), 0, CIntMP(reader("IDAPLICACION")))
                item.strSTSSOL = IIf(Convert.IsDBNull(reader("STSSOL")), String.Empty, CstrMP(reader("STSSOL")))
                item.strNUMLIC = IIf(Convert.IsDBNull(reader("NUMLIC")), String.Empty, CstrMP(reader("NUMLIC")))
                item.strREFCONSULADO = IIf(Convert.IsDBNull(reader("REF_CONSULADO")), String.Empty, CstrMP(reader("REF_CONSULADO")))
                item.strDECLARACIONJUR = IIf(Convert.IsDBNull(reader("DECL_JURADA")), String.Empty, CstrMP(reader("DECL_JURADA")))
            End While
            Return item
        End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaSOLICITUD() As List(Of clsBE_SOLICITUD)
			Dim olstSOLICITUD As New List(Of clsBE_SOLICITUD)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstSOLICITUD = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstSOLICITUD
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_SOLICITUD)
			Dim result As List(Of  clsBE_SOLICITUD) = New List(Of clsBE_SOLICITUD)
			While (reader.Read())
				dim item as new clsBE_SOLICITUD
                item.lngID = IIf(Convert.IsDBNull(reader("ID")), 0, CLngMP(reader("ID")))
				item.lngIDEMP = iif(Convert.IsDBNull(reader("IDEMP")),0,CLngMP(reader("IDEMP")))
				item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")),String.Empty,CStrMP(reader("TIPOLIC")))
				item.strRPTAUSOMARCAPAIS = iif(Convert.IsDBNull(reader("RPTAUSOMARCAPAIS")),String.Empty,CStrMP(reader("RPTAUSOMARCAPAIS")))
				item.intIDAPLICACION = iif(Convert.IsDBNull(reader("IDAPLICACION")),0,CIntMP(reader("IDAPLICACION")))
				item.strSTSSOL = iif(Convert.IsDBNull(reader("STSSOL")),String.Empty,CStrMP(reader("STSSOL")))
                item.strSTSSOL = IIf(Convert.IsDBNull(reader("REF_CONSULADO")), String.Empty, CstrMP(reader("REF_CONSULADO")))
                item.strSTSSOL = IIf(Convert.IsDBNull(reader("DECL_JURADA")), String.Empty, CstrMP(reader("DECL_JURADA")))

                result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad SOLICITUD Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaSOLICITUD_Paged(ByVal pSOLICITUD As clsBE_SOLICITUD) As List(Of clsBE_SOLICITUD)
			Dim intCount As Int32 = 0
			Dim olstSOLICITUD As New List(Of clsBE_SOLICITUD)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_SelLst_Paged")
				'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pSOLICITUD.intPAGESIZE)
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pSOLICITUD.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pSOLICITUD.lngID)
				Me.DataBase.AddInParameter(command, "@pIDEMP", DbType.Int64, pSOLICITUD.lngIDEMP)
				Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, pSOLICITUD.strTIPOLIC)
				Me.DataBase.AddInParameter(command, "@pRPTAUSOMARCAPAIS", DbType.String, pSOLICITUD.strRPTAUSOMARCAPAIS)
				Me.DataBase.AddInParameter(command, "@pIDAPLICACION", DbType.Int32, pSOLICITUD.intIDAPLICACION)
				Me.DataBase.AddInParameter(command, "@pSTSSOL", DbType.String, pSOLICITUD.strSTSSOL)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstSOLICITUD = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstSOLICITUD
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_SOLICITUD)
			Dim result As List(Of  clsBE_SOLICITUD) = New List(Of clsBE_SOLICITUD)
			While (reader.Read())
				dim item as new clsBE_SOLICITUD
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.lngIDEMP = iif(Convert.IsDBNull(reader("IDEMP")),0,CLngMP(reader("IDEMP")))
				item.strTIPOLIC = iif(Convert.IsDBNull(reader("TIPOLIC")),String.Empty,CStrMP(reader("TIPOLIC")))
				item.strRPTAUSOMARCAPAIS = iif(Convert.IsDBNull(reader("RPTAUSOMARCAPAIS")),String.Empty,CStrMP(reader("RPTAUSOMARCAPAIS")))
				item.intIDAPLICACION = iif(Convert.IsDBNull(reader("IDAPLICACION")),0,CIntMP(reader("IDAPLICACION")))
				item.strSTSSOL = iif(Convert.IsDBNull(reader("STSSOL")),String.Empty,CStrMP(reader("STSSOL")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaToDTSOLICITUD() As Datatable
			Dim oDTSOLICITUD As New DataTable
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_SelLst")
				Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
					If ds.Tables.Count.Equals(0) Then
						return Nothing
					Else
						return ds.Tables(0)
					End If
				End Using
			End Using
			Return oDTSOLICITUD
        End Function

        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene la lista de registros y lo almacena en un DS SOLICITUD
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerListaVigentes(ByVal IDEMP As Long, ByVal xstrTipo As String) As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_Vigentes")
                Me.DataBase.AddInParameter(command, "@pIDEMP", DbType.Int64, IDEMP)
                Me.DataBase.AddInParameter(command, "@pTIPOLIC", DbType.String, xstrTipo)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTSOLICITUD
        End Function

        Public Function LeerListaToDTSOLICITUDES(ByVal pSOLICITUD As clsBE_SOLICITUD, _
                                                 Optional ByRef lngTotalRow As Long = 0, _
                                                 Optional ByVal xstrRUC As String = "", Optional ByVal xstrRAZONSOCIAL As String = "", Optional ByVal xstrGIRO As String = "") As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUDES_SelLst_Paged")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pIDEMP", DbType.Int32, pSOLICITUD.lngIDEMP)
                Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, CnullMP(xstrRAZONSOCIAL))
                Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, CnullMP(xstrRUC))
                Me.DataBase.AddInParameter(command, "@pGIRO", DbType.String, CnullMP(xstrGIRO))
                Me.DataBase.AddInParameter(command, "@pPAGESIZE", DbType.Int32, pSOLICITUD.intPAGESIZE)
                Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32, pSOLICITUD.intCURRENTPAGE)
                Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int64, 8)
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        lngTotalRow = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTSOLICITUD
        End Function

        Public Function LeerListaToDTSOLICITUDES_SEARCH(Optional ByVal xstrRUC As String = "", Optional ByVal xstrRAZONSOCIAL As String = "", Optional ByVal xstrGIRO As String = "") As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUDE_SEARCH")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, CnullMP(CstrIgnoreAccentoMP(xstrRAZONSOCIAL)))
                Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, CnullMP(CstrIgnoreAccentoMP(xstrRUC)))
                Me.DataBase.AddInParameter(command, "@pGIRO", DbType.String, CnullMP(CstrIgnoreAccentoMP(xstrGIRO)))

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else


                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTSOLICITUD
        End Function

        Public Function LeerListaToDTSOLICITUDESBYCLIENT(ByVal lngClientId As Long) As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUDES_SelLstByClientUser")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pClientUser", DbType.Int64, lngClientId)

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTSOLICITUD
        End Function


        Public Function LeerListaToDTSOLICITUDESBYID(ByVal lngId As Long) As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUDES_SelByIDSol")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pIDSol", DbType.Int64, lngId)

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTSOLICITUD
        End Function

        Public Function LeerSearchToDTSOLICITUDCriter(ByVal tipoEmp As String, ByVal razonSoc As String, ByVal Inst As String,
                                                      ByVal Prod As String, ByVal evento As String, ByVal xstrRUC As String, _
                                                      ByVal xstrStsSol As String) As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_CRIT_SEARCH")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pTIPOEMPRESA", DbType.String, CnullMP(CstrIgnoreAccentoMP(tipoEmp)))
                Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, CnullMP(CstrIgnoreAccentoMP(razonSoc)))
                Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, CnullMP(xstrRUC))
                Me.DataBase.AddInParameter(command, "@pTIPLICInst", DbType.String, CnullMP(Inst))
                Me.DataBase.AddInParameter(command, "@pTIPLICProd", DbType.String, CnullMP(Prod))
                Me.DataBase.AddInParameter(command, "@pTIPLICEvent", DbType.String, CnullMP(evento))
                Me.DataBase.AddInParameter(command, "@pSTSSOL", DbType.String, CnullMP(xstrStsSol))

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using

            Return oDTSOLICITUD
        End Function

        Public Function LeerSearchToDTSOLICITUDCriterDateRange(ByVal tipoEmp As String, ByVal razonSoc As String, ByVal Inst As String,
                                        ByVal Prod As String, ByVal evento As String, ByVal xstrRUC As String, ByVal xstrStsSol As String,
                                        ByVal initDateDesde As Date, ByVal initDateHasta As Date, ByVal endDateDesde As Date,
                                        ByVal endDateHasta As Date) As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_CRIT_SEARCH_DATA_RANGE")
                'Atributos de paged
                Me.DataBase.AddInParameter(command, "@pTIPOEMPRESA", DbType.String, CnullMP(CstrIgnoreAccentoMP(tipoEmp)))
                Me.DataBase.AddInParameter(command, "@pRAZONSOCIAL", DbType.String, CnullMP(CstrIgnoreAccentoMP(razonSoc)))
                Me.DataBase.AddInParameter(command, "@pRUC", DbType.String, CnullMP(xstrRUC))
                Me.DataBase.AddInParameter(command, "@pTIPLICInst", DbType.String, CnullMP(Inst))
                Me.DataBase.AddInParameter(command, "@pTIPLICProd", DbType.String, CnullMP(Prod))
                Me.DataBase.AddInParameter(command, "@pTIPLICEvent", DbType.String, CnullMP(evento))
                Me.DataBase.AddInParameter(command, "@pSTSSOL", DbType.String, CnullMP(xstrStsSol))
                'fechas
                Me.DataBase.AddInParameter(command, "@regDateDesde", DbType.DateTime, initDateDesde)
                Me.DataBase.AddInParameter(command, "@regDateHasta", DbType.DateTime, initDateHasta)
                Me.DataBase.AddInParameter(command, "@acepDateDesde", DbType.DateTime, endDateDesde)
                Me.DataBase.AddInParameter(command, "@acepDateHasta", DbType.DateTime, endDateHasta)

                'command.Parameters(0).Value.ToString()
                'For Each para In command.Parameters
                'MsgBox(para.ToString + ">>> " + para.Value.ToString)
                'Next



                'MsgBox(">>>" + initDateDesde.ToString)
                'MsgBox(">>>" + initDateHasta.ToString)
                'MsgBox(">>>" + endDateDesde.ToString)
                'MsgBox(">>>" + endDateHasta.ToString)

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)

                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        'MsgBox("hay :" + ds.Tables(0).Rows.Count.ToString)
                        Return ds.Tables(0)
                    End If
                End Using
            End Using

            Return oDTSOLICITUD
        End Function
        Public Function LeerSearchToDTSOLICITUDCriterLst() As DataTable
            Dim oDTSOLICITUD As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_SOLICITUD_CRIT_SEARCH_SELLST")

                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using

            Return oDTSOLICITUD
        End Function


    End Class
#End Region
End Namespace


