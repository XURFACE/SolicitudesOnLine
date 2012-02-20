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
	''' Fecha Creacion: 05/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla FAQ
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_FAQTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCFAQTX As clsDALC_FAQTX
		Public oBEFAQ As clsBE_FAQ
		Public LstFAQ As New List(Of clsBE_FAQ)
		
		Sub New()
			oDALCFAQTX = New clsDALC_FAQTX
			oBEFAQ = New clsBE_FAQ
		End Sub
		
		Public Sub NuevaEntidad()
			oBEFAQ = New clsBE_FAQ
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Metodo de Inserción de Datos FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarFAQ() As Boolean
			Try
				Return oDALCFAQTX.InsertarFAQ(LstFAQ)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarFAQ() As Boolean
			Try
				Return oDALCFAQTX.EliminarFAQ(LstFAQ)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarFAQ() As Boolean
			Try
				Return oDALCFAQTX.ModificarFAQ(LstFAQ)
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
	''' Fecha Creacion: 05/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla FAQ
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_FAQRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCFAQRO As clsDALC_FAQRO
		Public oBEFAQ As clsBE_FAQ
		Public LstFAQ As New List(Of clsBE_FAQ)
		Public oDTFAQ As New DataTable
		
		Sub New()
			oDALCFAQRO = New clsDALC_FAQRO
			oBEFAQ = New clsBE_FAQ
		End Sub
		
		Public Sub NuevaEntidad()
			oBEFAQ = New clsBE_FAQ
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtiene un campo de la entidad: FAQ filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerFAQ
			Try
				oBEFAQ = oDALCFAQRO.LeerFAQ(oBEFAQ)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtinene una lista de la Entidad: FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaFAQ()
			Try
				LstFAQ = oDALCFAQRO.LeerListaFAQ()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaFAQ_Paged()
			Try
				LstFAQ = oDALCFAQRO.LeerListaFAQ_Paged(oBEFAQ)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 05/01/2012
		''' Proposito: Obtiene un Datatable de la Entidad: FAQ
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTFAQ() As Datatable
			Try
				oDTFAQ = oDALCFAQRO.LeerListaToDTFAQ()
				Return oDTFAQ
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


