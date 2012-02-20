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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_REF_EMPRESATX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCREF_EMPRESATX As clsDALC_REF_EMPRESATX
		Public oBEREF_EMPRESA As clsBE_REF_EMPRESA
		Public LstREF_EMPRESA As New List(Of clsBE_REF_EMPRESA)
		
		Sub New()
			oDALCREF_EMPRESATX = New clsDALC_REF_EMPRESATX
			oBEREF_EMPRESA = New clsBE_REF_EMPRESA
		End Sub
		
		Public Sub NuevaEntidad()
			oBEREF_EMPRESA = New clsBE_REF_EMPRESA
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarREF_EMPRESA() As Boolean
			Try
				Return oDALCREF_EMPRESATX.InsertarREF_EMPRESA(LstREF_EMPRESA)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarREF_EMPRESA() As Boolean
			Try
				Return oDALCREF_EMPRESATX.EliminarREF_EMPRESA(LstREF_EMPRESA)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarREF_EMPRESA() As Boolean
			Try
				Return oDALCREF_EMPRESATX.ModificarREF_EMPRESA(LstREF_EMPRESA)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla REF_EMPRESA
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_REF_EMPRESARO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCREF_EMPRESARO As clsDALC_REF_EMPRESARO
		Public oBEREF_EMPRESA As clsBE_REF_EMPRESA
		Public LstREF_EMPRESA As New List(Of clsBE_REF_EMPRESA)
		Public oDTREF_EMPRESA As New DataTable
		
		Sub New()
			oDALCREF_EMPRESARO = New clsDALC_REF_EMPRESARO
			oBEREF_EMPRESA = New clsBE_REF_EMPRESA
		End Sub
		
		Public Sub NuevaEntidad()
			oBEREF_EMPRESA = New clsBE_REF_EMPRESA
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: REF_EMPRESA filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerREF_EMPRESA
			Try
				oBEREF_EMPRESA = oDALCREF_EMPRESARO.LeerREF_EMPRESA(oBEREF_EMPRESA)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaREF_EMPRESA()
			Try
				LstREF_EMPRESA = oDALCREF_EMPRESARO.LeerListaREF_EMPRESA()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaREF_EMPRESA_Paged()
			Try
				LstREF_EMPRESA = oDALCREF_EMPRESARO.LeerListaREF_EMPRESA_Paged(oBEREF_EMPRESA)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: REF_EMPRESA
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTREF_EMPRESA() As Datatable
			Try
				oDTREF_EMPRESA = oDALCREF_EMPRESARO.LeerListaToDTREF_EMPRESA()
				Return oDTREF_EMPRESA
			Catch ex As Exception
				Throw ex
			End Try
		End Function 


        Public Function LeerListaToDTREF_EMPRESA(ByVal lngIDEmpresa As Long) As DataTable
            Try
                oDTREF_EMPRESA = oDALCREF_EMPRESARO.LeerListaToDTREF_EMPRESA(lngIDEmpresa)
                Return oDTREF_EMPRESA
            Catch ex As Exception
                Throw ex
            End Try
        End Function
	End Class
#End Region
End Namespace


