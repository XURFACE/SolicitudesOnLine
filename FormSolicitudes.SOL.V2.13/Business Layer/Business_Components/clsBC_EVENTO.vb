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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EVENTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EVENTOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEVENTOTX As clsDALC_EVENTOTX
		Public oBEEVENTO As clsBE_EVENTO
		Public LstEVENTO As New List(Of clsBE_EVENTO)
		
		Sub New()
			oDALCEVENTOTX = New clsDALC_EVENTOTX
			oBEEVENTO = New clsBE_EVENTO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEVENTO = New clsBE_EVENTO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarEVENTO() As Boolean
			Try
				Return oDALCEVENTOTX.InsertarEVENTO(LstEVENTO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarEVENTO() As Boolean
			Try
				Return oDALCEVENTOTX.EliminarEVENTO(LstEVENTO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarEVENTO() As Boolean
			Try
				Return oDALCEVENTOTX.ModificarEVENTO(LstEVENTO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla EVENTO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_EVENTORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCEVENTORO As clsDALC_EVENTORO
		Public oBEEVENTO As clsBE_EVENTO
		Public LstEVENTO As New List(Of clsBE_EVENTO)
		Public oDTEVENTO As New DataTable
		
		Sub New()
			oDALCEVENTORO = New clsDALC_EVENTORO
			oBEEVENTO = New clsBE_EVENTO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEEVENTO = New clsBE_EVENTO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: EVENTO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerEVENTO
			Try
				oBEEVENTO = oDALCEVENTORO.LeerEVENTO(oBEEVENTO)
			Catch ex As Exception
				Throw ex
			End Try
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtiene un campo de la entidad: EVENTO filtrada por el ID o Codigo de la misma.
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Sub LeerEVENTO(ByVal IDSol As Long)
            Try
                oBEEVENTO = oDALCEVENTORO.LeerEVENTO(IDSol)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEVENTO()
			Try
				LstEVENTO = oDALCEVENTORO.LeerListaEVENTO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaEVENTO_Paged()
			Try
				LstEVENTO = oDALCEVENTORO.LeerListaEVENTO_Paged(oBEEVENTO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: EVENTO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTEVENTO() As Datatable
			Try
				oDTEVENTO = oDALCEVENTORO.LeerListaToDTEVENTO()
				Return oDTEVENTO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


