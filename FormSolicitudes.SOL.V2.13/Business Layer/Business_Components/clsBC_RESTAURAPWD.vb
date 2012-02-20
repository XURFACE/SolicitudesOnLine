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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla RESTAURAPWD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_RESTAURAPWDTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCRESTAURAPWDTX As clsDALC_RESTAURAPWDTX
		Public oBERESTAURAPWD As clsBE_RESTAURAPWD
		Public LstRESTAURAPWD As New List(Of clsBE_RESTAURAPWD)
		
		Sub New()
			oDALCRESTAURAPWDTX = New clsDALC_RESTAURAPWDTX
			oBERESTAURAPWD = New clsBE_RESTAURAPWD
		End Sub
		
		Public Sub NuevaEntidad()
			oBERESTAURAPWD = New clsBE_RESTAURAPWD
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarRESTAURAPWD() As Boolean
			Try
				Return oDALCRESTAURAPWDTX.InsertarRESTAURAPWD(LstRESTAURAPWD)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarRESTAURAPWD() As Boolean
			Try
				Return oDALCRESTAURAPWDTX.EliminarRESTAURAPWD(LstRESTAURAPWD)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarRESTAURAPWD() As Boolean
			Try
				Return oDALCRESTAURAPWDTX.ModificarRESTAURAPWD(LstRESTAURAPWD)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla RESTAURAPWD
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_RESTAURAPWDRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCRESTAURAPWDRO As clsDALC_RESTAURAPWDRO
		Public oBERESTAURAPWD As clsBE_RESTAURAPWD
		Public LstRESTAURAPWD As New List(Of clsBE_RESTAURAPWD)
		Public oDTRESTAURAPWD As New DataTable
		
		Sub New()
			oDALCRESTAURAPWDRO = New clsDALC_RESTAURAPWDRO
			oBERESTAURAPWD = New clsBE_RESTAURAPWD
		End Sub
		
		Public Sub NuevaEntidad()
			oBERESTAURAPWD = New clsBE_RESTAURAPWD
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: RESTAURAPWD filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerRESTAURAPWD
			Try
				oBERESTAURAPWD = oDALCRESTAURAPWDRO.LeerRESTAURAPWD(oBERESTAURAPWD)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaRESTAURAPWD()
			Try
				LstRESTAURAPWD = oDALCRESTAURAPWDRO.LeerListaRESTAURAPWD()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaRESTAURAPWD_Paged()
			Try
				LstRESTAURAPWD = oDALCRESTAURAPWDRO.LeerListaRESTAURAPWD_Paged(oBERESTAURAPWD)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: RESTAURAPWD
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTRESTAURAPWD() As Datatable
			Try
				oDTRESTAURAPWD = oDALCRESTAURAPWDRO.LeerListaToDTRESTAURAPWD()
				Return oDTRESTAURAPWD
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


