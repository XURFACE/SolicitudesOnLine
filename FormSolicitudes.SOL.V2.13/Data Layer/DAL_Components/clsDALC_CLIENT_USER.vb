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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla CLIENT_USER
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_CLIENT_USERTX
		Inherits clsDALC_Base

		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function InsertarCLIENT_USER(ByVal oLstCLIENT_USER As List(Of clsBE_CLIENT_USER)) As Boolean
			For Each oCLIENT_USER As clsBE_CLIENT_USER In oLstCLIENT_USER
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_Insert")
					Me.DataBase.AddInParameter(command, "@pLOGINUSR", DbType.String, oCLIENT_USER.strLOGINUSR)
					Me.DataBase.AddInParameter(command, "@pPWDUSR", DbType.String, oCLIENT_USER.strPWDUSR)
					Me.DataBase.AddInParameter(command, "@pNOMUSR", DbType.String, oCLIENT_USER.strNOMUSR)
					Me.DataBase.AddInParameter(command, "@pAPUSR", DbType.String, oCLIENT_USER.strAPUSR)
					Me.DataBase.AddInParameter(command, "@pAMUSR", DbType.String, oCLIENT_USER.strAMUSR)
					Me.DataBase.AddInParameter(command, "@pMAILUSR", DbType.String, oCLIENT_USER.strMAILUSR)
					Me.DataBase.AddInParameter(command, "@pFECHAREG", DbType.DateTime, oCLIENT_USER.dtmFECHAREG)
					Me.DataBase.AddInParameter(command, "@pESTADOUSR", DbType.Int32, oCLIENT_USER.intESTADOUSR)
					Me.DataBase.AddInParameter(command, "@pCODVERIFICACION", DbType.String, oCLIENT_USER.strCODVERIFICACION)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oCLIENT_USER.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oCLIENT_USER.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oCLIENT_USER.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oCLIENT_USER.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oCLIENT_USER.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oCLIENT_USER.strAUD_USR_GENERICO) 
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
		''' Proposito: Metodo de Modificación de datos CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function ModificarCLIENT_USER(ByVal oLstCLIENT_USER As List(Of clsBE_CLIENT_USER)) As Boolean
			For Each oCLIENT_USER As clsBE_CLIENT_USER In oLstCLIENT_USER
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_Update")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oCLIENT_USER.lngID)
					Me.DataBase.AddInParameter(command, "@pLOGINUSR", DbType.String, oCLIENT_USER.strLOGINUSR)
					Me.DataBase.AddInParameter(command, "@pPWDUSR", DbType.String, oCLIENT_USER.strPWDUSR)
					Me.DataBase.AddInParameter(command, "@pNOMUSR", DbType.String, oCLIENT_USER.strNOMUSR)
					Me.DataBase.AddInParameter(command, "@pAPUSR", DbType.String, oCLIENT_USER.strAPUSR)
					Me.DataBase.AddInParameter(command, "@pAMUSR", DbType.String, oCLIENT_USER.strAMUSR)
					Me.DataBase.AddInParameter(command, "@pMAILUSR", DbType.String, oCLIENT_USER.strMAILUSR)
					Me.DataBase.AddInParameter(command, "@pFECHAREG", DbType.DateTime, oCLIENT_USER.dtmFECHAREG)
					Me.DataBase.AddInParameter(command, "@pESTADOUSR", DbType.Int32, oCLIENT_USER.intESTADOUSR)
					Me.DataBase.AddInParameter(command, "@pCODVERIFICACION", DbType.String, oCLIENT_USER.strCODVERIFICACION)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oCLIENT_USER.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oCLIENT_USER.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oCLIENT_USER.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oCLIENT_USER.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oCLIENT_USER.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oCLIENT_USER.strAUD_USR_GENERICO) 
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
        ''' Fecha Creacion: 07/12/2011
        ''' Proposito: Metodo de Modificación de datos CLIENT_USER
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function ModificarPwdCLIENT_USER(ByVal oLstCLIENT_USER As List(Of clsBE_CLIENT_USER)) As Boolean
            For Each oCLIENT_USER As clsBE_CLIENT_USER In oLstCLIENT_USER
                Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_UpdatePwd")
                    Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oCLIENT_USER.lngID)
                    Me.DataBase.AddInParameter(command, "@pLOGINUSR", DbType.String, oCLIENT_USER.strLOGINUSR)
                    Me.DataBase.AddInParameter(command, "@pPWDUSR", DbType.String, oCLIENT_USER.strPWDUSR)
                    'Parametros de Auditoria
                    Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oCLIENT_USER.strAUD_SERVICIO)
                    Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oCLIENT_USER.strAUD_REGISTRO_AFECTADO)
                    Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oCLIENT_USER.strAUD_MATRICULA_USR)
                    Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oCLIENT_USER.strAUD_NOM_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oCLIENT_USER.strAUD_IP_MAQ)
                    Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oCLIENT_USER.strAUD_USR_GENERICO)
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
		''' Proposito:  Metodo de Elimación CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function EliminarCLIENT_USER(ByVal oLstCLIENT_USER As List(Of clsBE_CLIENT_USER)) As Boolean
			For Each oCLIENT_USER As clsBE_CLIENT_USER In oLstCLIENT_USER
				Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_Delete")
					Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, oCLIENT_USER.lngID)
					'Parametros de Auditoria
					Me.DataBase.AddInParameter(command, "@pAUD_SERVICIO", DbType.String, oCLIENT_USER.strAUD_SERVICIO) 
					Me.DataBase.AddInParameter(command, "@pAUD_REGISTRO_AFECTADO", DbType.String, oCLIENT_USER.strAUD_REGISTRO_AFECTADO) 
					Me.DataBase.AddInParameter(command, "@pAUD_MATRICULA_USR", DbType.String, oCLIENT_USER.strAUD_MATRICULA_USR)
					Me.DataBase.AddInParameter(command, "@pAUD_NOM_MAQ", DbType.String, oCLIENT_USER.strAUD_NOM_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_IP_MAQ", DbType.String, oCLIENT_USER.strAUD_IP_MAQ) 
					Me.DataBase.AddInParameter(command, "@pAUD_USR_GENERICO", DbType.String, oCLIENT_USER.strAUD_USR_GENERICO) 
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
	''' Proposito: Obtiene los valores de la tabla Abonado CLIENT_USER
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsDALC_CLIENT_USERRO
		Inherits clsDALC_Base

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Lee datos de un registro de la tabla CLIENT_USER y lo obtiene por su PK
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerCLIENT_USER(ByVal pCLIENT_USER As clsBE_CLIENT_USER) As clsBE_CLIENT_USER
			Dim oCLIENT_USER As clsBE_CLIENT_USER = Nothing
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_GetByID")
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pCLIENT_USER.lngID)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					oCLIENT_USER = Me.ReadItem(reader)
				End Using
			End Using
			Return oCLIENT_USER
        End Function
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 04/11/2011
        ''' Proposito: Lee datos de un registro de la tabla USUARIO y lo obtiene por su PK
        ''' Fecha Modificacion: 
        ''' </summary> 
        Public Function LeerUSUARIObyLogIn(ByVal pUSUARIO As clsBE_CLIENT_USER) As clsBE_CLIENT_USER
            Dim oUSUARIO As clsBE_CLIENT_USER = Nothing
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_USUARIO_GetByLogIn")
                Me.DataBase.AddInParameter(command, "@pCODUSUARIO", DbType.String, pUSUARIO.strLOGINUSR)
                Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
                    oUSUARIO = Me.ReadItem(reader)
                End Using
            End Using

            Return oUSUARIO
        End Function

		Private Function ReadItem(ByVal reader As IDataReader) As clsBE_CLIENT_USER
			Dim item As New clsBE_CLIENT_USER
			While (reader.Read())
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strLOGINUSR = iif(Convert.IsDBNull(reader("LOGINUSR")),String.Empty,CStrMP(reader("LOGINUSR")))
				item.strPWDUSR = iif(Convert.IsDBNull(reader("PWDUSR")),String.Empty,CStrMP(reader("PWDUSR")))
				item.strNOMUSR = iif(Convert.IsDBNull(reader("NOMUSR")),String.Empty,CStrMP(reader("NOMUSR")))
				item.strAPUSR = iif(Convert.IsDBNull(reader("APUSR")),String.Empty,CStrMP(reader("APUSR")))
				item.strAMUSR = iif(Convert.IsDBNull(reader("AMUSR")),String.Empty,CStrMP(reader("AMUSR")))
				item.strMAILUSR = iif(Convert.IsDBNull(reader("MAILUSR")),String.Empty,CStrMP(reader("MAILUSR")))
				item.dtmFECHAREG = iif(Convert.IsDBNull(reader("FECHAREG")),Nothing,CDateMP(reader("FECHAREG")))
				item.intESTADOUSR = iif(Convert.IsDBNull(reader("ESTADOUSR")),0,CIntMP(reader("ESTADOUSR")))
                item.strCODVERIFICACION = IIf(Convert.IsDBNull(reader("CODVERIFICACION")), String.Empty, CstrMP(reader("CODVERIFICACION")))
                item.strEXPEDIENTES = IIf(Convert.IsDBNull(reader("EXPEDIENTES")), String.Empty, CstrMP(reader("EXPEDIENTES")))
			End While
			Return item
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de todos los registros de la entidad: CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaCLIENT_USER() As List(Of clsBE_CLIENT_USER)
			Dim olstCLIENT_USER As New List(Of clsBE_CLIENT_USER)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_SelLst")
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					olstCLIENT_USER = Me.ReadListItem(reader)
				End Using
			End Using
			Return olstCLIENT_USER
		End Function

		Private Function ReadListItem(ByVal reader As IDataReader) As List(Of clsBE_CLIENT_USER)
			Dim result As List(Of  clsBE_CLIENT_USER) = New List(Of clsBE_CLIENT_USER)
			While (reader.Read())
				dim item as new clsBE_CLIENT_USER
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strLOGINUSR = iif(Convert.IsDBNull(reader("LOGINUSR")),String.Empty,CStrMP(reader("LOGINUSR")))
				item.strPWDUSR = iif(Convert.IsDBNull(reader("PWDUSR")),String.Empty,CStrMP(reader("PWDUSR")))
				item.strNOMUSR = iif(Convert.IsDBNull(reader("NOMUSR")),String.Empty,CStrMP(reader("NOMUSR")))
				item.strAPUSR = iif(Convert.IsDBNull(reader("APUSR")),String.Empty,CStrMP(reader("APUSR")))
				item.strAMUSR = iif(Convert.IsDBNull(reader("AMUSR")),String.Empty,CStrMP(reader("AMUSR")))
				item.strMAILUSR = iif(Convert.IsDBNull(reader("MAILUSR")),String.Empty,CStrMP(reader("MAILUSR")))
				item.dtmFECHAREG = iif(Convert.IsDBNull(reader("FECHAREG")),Nothing,CDateMP(reader("FECHAREG")))
				item.intESTADOUSR = iif(Convert.IsDBNull(reader("ESTADOUSR")),0,CIntMP(reader("ESTADOUSR")))
                item.strCODVERIFICACION = IIf(Convert.IsDBNull(reader("CODVERIFICACION")), String.Empty, CstrMP(reader("CODVERIFICACION")))
                item.strEXPEDIENTES = IIf(Convert.IsDBNull(reader("EXPEDIENTES")), String.Empty, CstrMP(reader("EXPEDIENTES")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros de la entidad CLIENT_USER Paginado en Base de datos
		''' Fecha Modificacion: 
		''' </summary> 
		Public Function LeerListaCLIENT_USER_Paged(ByVal pCLIENT_USER As clsBE_CLIENT_USER) As List(Of clsBE_CLIENT_USER)
			Dim intCount As Int32 = 0
			Dim olstCLIENT_USER As New List(Of clsBE_CLIENT_USER)
			Dim mintItem As Integer = 0
			Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_SelLst_Paged")
                'Atributos de paged
				Me.DataBase.AddInParameter(command, "@pCURRENTPAGE", DbType.Int32,pCLIENT_USER.intCURRENTPAGE)
				Me.DataBase.AddOutParameter(command, "@pITEMCOUNT", DbType.Int32, 4)
				'Atributos de la Entidad
				Me.DataBase.AddInParameter(command, "@pID", DbType.Int64, pCLIENT_USER.lngID)
				Me.DataBase.AddInParameter(command, "@pLOGINUSR", DbType.String, pCLIENT_USER.strLOGINUSR)
				Me.DataBase.AddInParameter(command, "@pPWDUSR", DbType.String, pCLIENT_USER.strPWDUSR)
				Me.DataBase.AddInParameter(command, "@pNOMUSR", DbType.String, pCLIENT_USER.strNOMUSR)
				Me.DataBase.AddInParameter(command, "@pAPUSR", DbType.String, pCLIENT_USER.strAPUSR)
				Me.DataBase.AddInParameter(command, "@pAMUSR", DbType.String, pCLIENT_USER.strAMUSR)
				Me.DataBase.AddInParameter(command, "@pMAILUSR", DbType.String, pCLIENT_USER.strMAILUSR)
				Me.DataBase.AddInParameter(command, "@pFECHAREG", DbType.DateTime, pCLIENT_USER.dtmFECHAREG)
				Me.DataBase.AddInParameter(command, "@pESTADOUSR", DbType.Int32, pCLIENT_USER.intESTADOUSR)
				Me.DataBase.AddInParameter(command, "@pCODVERIFICACION", DbType.String, pCLIENT_USER.strCODVERIFICACION)
				Using reader As IDataReader = Me.DataBase.ExecuteReader(command)
					intCount = Me.DataBase.GetParameterValue(command, "@pITEMCOUNT")
					olstCLIENT_USER = Me.ReadListItemPaged(reader, intCount)
				End Using
			End Using
			Return olstCLIENT_USER
		End Function

		Private Function ReadListItemPaged(ByVal reader As IDataReader, ByVal intCount As Integer) As List(Of clsBE_CLIENT_USER)
			Dim result As List(Of  clsBE_CLIENT_USER) = New List(Of clsBE_CLIENT_USER)
			While (reader.Read())
				dim item as new clsBE_CLIENT_USER
				'Atributos de paged del result set que devuelve el store
				item.intITEMCOUNT = intCount
				item.lngID = iif(Convert.IsDBNull(reader("ID")),0,CLngMP(reader("ID")))
				item.strLOGINUSR = iif(Convert.IsDBNull(reader("LOGINUSR")),String.Empty,CStrMP(reader("LOGINUSR")))
				item.strPWDUSR = iif(Convert.IsDBNull(reader("PWDUSR")),String.Empty,CStrMP(reader("PWDUSR")))
				item.strNOMUSR = iif(Convert.IsDBNull(reader("NOMUSR")),String.Empty,CStrMP(reader("NOMUSR")))
				item.strAPUSR = iif(Convert.IsDBNull(reader("APUSR")),String.Empty,CStrMP(reader("APUSR")))
				item.strAMUSR = iif(Convert.IsDBNull(reader("AMUSR")),String.Empty,CStrMP(reader("AMUSR")))
				item.strMAILUSR = iif(Convert.IsDBNull(reader("MAILUSR")),String.Empty,CStrMP(reader("MAILUSR")))
				item.dtmFECHAREG = iif(Convert.IsDBNull(reader("FECHAREG")),Nothing,CDateMP(reader("FECHAREG")))
				item.intESTADOUSR = iif(Convert.IsDBNull(reader("ESTADOUSR")),0,CIntMP(reader("ESTADOUSR")))
                item.strCODVERIFICACION = IIf(Convert.IsDBNull(reader("CODVERIFICACION")), String.Empty, CstrMP(reader("CODVERIFICACION")))
                item.strEXPEDIENTES = IIf(Convert.IsDBNull(reader("EXPEDIENTES")), String.Empty, CstrMP(reader("EXPEDIENTES")))
				result.Add(item)
			End While
			Return result
		End Function

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene la lista de registros y lo almacena en un DS CLIENT_USER
		''' Fecha Modificacion: 
		''' </summary> 
        Public Function LeerListaToDTCLIENT_USER(ByVal xstrName As String, ByVal xstrLoginmail As String) As DataTable
            Dim oDTCLIENT_USER As New DataTable
            Using command As DbCommand = Me.DataBase.GetStoredProcCommand("up_CLIENT_USER_SelLst")
                Me.DataBase.AddInParameter(command, "@pNombre", DbType.String, CnullMP(xstrName))
                Me.DataBase.AddInParameter(command, "@pLogMail", DbType.String, CnullMP(xstrLoginmail))
                Using ds As DataSet = Me.DataBase.ExecuteDataSet(command)
                    If ds.Tables.Count.Equals(0) Then
                        Return Nothing
                    Else
                        Return ds.Tables(0)
                    End If
                End Using
            End Using
            Return oDTCLIENT_USER
        End Function

	End Class
#End Region
End Namespace


