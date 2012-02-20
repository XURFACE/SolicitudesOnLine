Imports System.Collections.ObjectModel
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Data
Imports MP.DW.BL.BE
Imports MP.DW.DAL.DALC

Namespace MP.DW.BL.BC
#Region "Clase Escritura" 
	'<ComVisible(True)> _
	'<Transaction(TransactionOption.Required)> _
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla SOLICITUD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_SOLICITUDTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCSOLICITUDTX As clsDALC_SOLICITUDTX
		Public oBESOLICITUD As clsBE_SOLICITUD
		Public LstSOLICITUD As New List(Of clsBE_SOLICITUD)
		
		Sub New()
			oDALCSOLICITUDTX = New clsDALC_SOLICITUDTX
			oBESOLICITUD = New clsBE_SOLICITUD
		End Sub
		
		Public Sub NuevaEntidad()
			oBESOLICITUD = New clsBE_SOLICITUD
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarSOLICITUD() As Boolean
			Try
				Return oDALCSOLICITUDTX.InsertarSOLICITUD(LstSOLICITUD)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarSOLICITUD() As Boolean
			Try
				Return oDALCSOLICITUDTX.EliminarSOLICITUD(LstSOLICITUD)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarSOLICITUD() As Boolean
			Try
				Return oDALCSOLICITUDTX.ModificarSOLICITUD(LstSOLICITUD)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
	End Class
#End Region

#Region "Clase Lectura" 
	'<ComVisible(True)> _
	'<Transaction(TransactionOption.Required)> _
	''' <summary>
	''' Escrito por: Alejandro Mayta C.
	''' Fecha Creacion: 23/12/2011
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla SOLICITUD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_SOLICITUDRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCSOLICITUDRO As clsDALC_SOLICITUDRO
		Public oBESOLICITUD As clsBE_SOLICITUD
		Public LstSOLICITUD As New List(Of clsBE_SOLICITUD)
		Public oDTSOLICITUD As New DataTable
		
		Sub New()
			oDALCSOLICITUDRO = New clsDALC_SOLICITUDRO
			oBESOLICITUD = New clsBE_SOLICITUD
		End Sub
		
		Public Sub NuevaEntidad()
			oBESOLICITUD = New clsBE_SOLICITUD
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: SOLICITUD filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 		
		Public Sub LeerSOLICITUD
			Try
				oBESOLICITUD = oDALCSOLICITUDRO.LeerSOLICITUD(oBESOLICITUD)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 		
		Public Sub LeerListaSOLICITUD()
			Try
				LstSOLICITUD = oDALCSOLICITUDRO.LeerListaSOLICITUD()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 		
		Public Sub LeerListaSOLICITUD_Paged()
			Try
				LstSOLICITUD = oDALCSOLICITUDRO.LeerListaSOLICITUD_Paged(oBESOLICITUD)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: SOLICITUD
		''' Fecha Modificacion: 
		''' </summary> 		
		Public Function  LeerListaToDTSOLICITUD() As Datatable
			Try
				oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaToDTSOLICITUD()
				Return oDTSOLICITUD
			Catch ex As Exception
				Throw ex
			End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene un Datatable de la Entidad: SOLICITUD
        ''' Fecha Modificacion: 
        ''' </summary> 		
        Public Function LeerListaVigentes() As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaVigentes(oBESOLICITUD.lngIDEMP, oBESOLICITUD.strTIPOLIC)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDTSOLICITUDES_SEARCH(Optional ByVal xstrRRUC As String = "", _
                                                        Optional ByVal xstrRAZONSOCIAL As String = "", _
                                                        Optional ByVal xstrGIRO As String = "") As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaToDTSOLICITUDES_SEARCH(xstrRRUC, xstrRAZONSOCIAL, xstrGIRO)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDTSOLICITUDES(Optional ByRef lngTotalRow As Long = 0, _
                                                             Optional ByVal xstrRRUC As String = "", _
                                                             Optional ByVal xstrRAZONSOCIAL As String = "", _
                                                             Optional ByVal xstrGIRO As String = "") As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaToDTSOLICITUDES(oBESOLICITUD, lngTotalRow, xstrRRUC, xstrRAZONSOCIAL, xstrGIRO)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDTSOLICITUDESBYCLIENT(ByVal lngIdClient As Long) As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaToDTSOLICITUDESBYCLIENT(lngIdClient)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerListaToDTSOLICITUDESBYID(ByVal lngId As Long) As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerListaToDTSOLICITUDESBYID(lngId)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LeerSearchToDTSOLICITUDCriter(ByVal tipoEmp As String, ByVal razonSoc As String, ByVal Inst As String,
                                                      ByVal Prod As String, ByVal evento As String, ByVal xstrRUC As String, _
                                                      ByVal xstrStsSol As String) As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerSearchToDTSOLICITUDCriter(tipoEmp, razonSoc, Inst, Prod, evento, xstrRUC, xstrStsSol)
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function LeerSearchToDTSOLICITUDCriterLst() As DataTable
            Try
                oDTSOLICITUD = oDALCSOLICITUDRO.LeerSearchToDTSOLICITUDCriterLst()
                Return oDTSOLICITUD
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
#End Region
End Namespace


