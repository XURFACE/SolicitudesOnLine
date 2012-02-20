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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_PRODUCTOS
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_REF_PRODUCTOSTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCREF_PRODUCTOSTX As clsDALC_REF_PRODUCTOSTX
		Public oBEREF_PRODUCTOS As clsBE_REF_PRODUCTOS
		Public LstREF_PRODUCTOS As New List(Of clsBE_REF_PRODUCTOS)
		
		Sub New()
			oDALCREF_PRODUCTOSTX = New clsDALC_REF_PRODUCTOSTX
			oBEREF_PRODUCTOS = New clsBE_REF_PRODUCTOS
		End Sub
		
		Public Sub NuevaEntidad()
			oBEREF_PRODUCTOS = New clsBE_REF_PRODUCTOS
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarREF_PRODUCTOS() As Boolean
			Try
				Return oDALCREF_PRODUCTOSTX.InsertarREF_PRODUCTOS(LstREF_PRODUCTOS)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarREF_PRODUCTOS() As Boolean
			Try
				Return oDALCREF_PRODUCTOSTX.EliminarREF_PRODUCTOS(LstREF_PRODUCTOS)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarREF_PRODUCTOS() As Boolean
			Try
				Return oDALCREF_PRODUCTOSTX.ModificarREF_PRODUCTOS(LstREF_PRODUCTOS)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_PRODUCTOS
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_REF_PRODUCTOSRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCREF_PRODUCTOSRO As clsDALC_REF_PRODUCTOSRO
		Public oBEREF_PRODUCTOS As clsBE_REF_PRODUCTOS
		Public LstREF_PRODUCTOS As New List(Of clsBE_REF_PRODUCTOS)
		Public oDTREF_PRODUCTOS As New DataTable
		
		Sub New()
			oDALCREF_PRODUCTOSRO = New clsDALC_REF_PRODUCTOSRO
			oBEREF_PRODUCTOS = New clsBE_REF_PRODUCTOS
		End Sub
		
		Public Sub NuevaEntidad()
			oBEREF_PRODUCTOS = New clsBE_REF_PRODUCTOS
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: REF_PRODUCTOS filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerREF_PRODUCTOS
			Try
				oBEREF_PRODUCTOS = oDALCREF_PRODUCTOSRO.LeerREF_PRODUCTOS(oBEREF_PRODUCTOS)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaREF_PRODUCTOS()
			Try
				LstREF_PRODUCTOS = oDALCREF_PRODUCTOSRO.LeerListaREF_PRODUCTOS()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaREF_PRODUCTOS_Paged()
			Try
				LstREF_PRODUCTOS = oDALCREF_PRODUCTOSRO.LeerListaREF_PRODUCTOS_Paged(oBEREF_PRODUCTOS)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: REF_PRODUCTOS
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTREF_PRODUCTOS() As Datatable
			Try
				oDTREF_PRODUCTOS = oDALCREF_PRODUCTOSRO.LeerListaToDTREF_PRODUCTOS()
				Return oDTREF_PRODUCTOS
			Catch ex As Exception
				Throw ex
			End Try
        End Function


        Public Function LeerListaToDTREF_PRODUCTOS(ByVal idProd As Long) As DataTable
            Try
                oDTREF_PRODUCTOS = oDALCREF_PRODUCTOSRO.LeerListaToDTREF_PRODUCTOS(idProd)
                Return oDTREF_PRODUCTOS
            Catch ex As Exception
                Throw ex
            End Try
        End Function
		
	End Class
#End Region
End Namespace


