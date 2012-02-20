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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla UBIGEO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_UBIGEOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCUBIGEOTX As clsDALC_UBIGEOTX
		Public oBEUBIGEO As clsBE_UBIGEO
		Public LstUBIGEO As New List(Of clsBE_UBIGEO)
		
		Sub New()
			oDALCUBIGEOTX = New clsDALC_UBIGEOTX
			oBEUBIGEO = New clsBE_UBIGEO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEUBIGEO = New clsBE_UBIGEO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarUBIGEO() As Boolean
			Try
				Return oDALCUBIGEOTX.InsertarUBIGEO(LstUBIGEO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarUBIGEO() As Boolean
			Try
				Return oDALCUBIGEOTX.EliminarUBIGEO(LstUBIGEO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarUBIGEO() As Boolean
			Try
				Return oDALCUBIGEOTX.ModificarUBIGEO(LstUBIGEO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla UBIGEO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_UBIGEORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCUBIGEORO As clsDALC_UBIGEORO
		Public oBEUBIGEO As clsBE_UBIGEO
		Public LstUBIGEO As New List(Of clsBE_UBIGEO)
		Public oDTUBIGEO As New DataTable
		
		Sub New()
			oDALCUBIGEORO = New clsDALC_UBIGEORO
			oBEUBIGEO = New clsBE_UBIGEO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEUBIGEO = New clsBE_UBIGEO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: UBIGEO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerUBIGEO
			Try
				oBEUBIGEO = oDALCUBIGEORO.LeerUBIGEO(oBEUBIGEO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaUBIGEO()
			Try
				LstUBIGEO = oDALCUBIGEORO.LeerListaUBIGEO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaUBIGEO_Paged()
			Try
				LstUBIGEO = oDALCUBIGEORO.LeerListaUBIGEO_Paged(oBEUBIGEO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: UBIGEO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTUBIGEO() As Datatable
			Try
				oDTUBIGEO = oDALCUBIGEORO.LeerListaToDTUBIGEO()
				Return oDTUBIGEO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


