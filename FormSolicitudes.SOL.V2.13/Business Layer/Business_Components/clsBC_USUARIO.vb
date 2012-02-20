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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla USUARIO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_USUARIOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCUSUARIOTX As clsDALC_USUARIOTX
		Public oBEUSUARIO As clsBE_USUARIO
		Public LstUSUARIO As New List(Of clsBE_USUARIO)
		
		Sub New()
			oDALCUSUARIOTX = New clsDALC_USUARIOTX
			oBEUSUARIO = New clsBE_USUARIO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEUSUARIO = New clsBE_USUARIO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarUSUARIO() As Boolean
			Try
				Return oDALCUSUARIOTX.InsertarUSUARIO(LstUSUARIO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarUSUARIO() As Boolean
			Try
				Return oDALCUSUARIOTX.EliminarUSUARIO(LstUSUARIO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarUSUARIO() As Boolean
			Try
				Return oDALCUSUARIOTX.ModificarUSUARIO(LstUSUARIO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla USUARIO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_USUARIORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCUSUARIORO As clsDALC_USUARIORO
		Public oBEUSUARIO As clsBE_USUARIO
		Public LstUSUARIO As New List(Of clsBE_USUARIO)
		Public oDTUSUARIO As New DataTable
		
		Sub New()
			oDALCUSUARIORO = New clsDALC_USUARIORO
			oBEUSUARIO = New clsBE_USUARIO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEUSUARIO = New clsBE_USUARIO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: USUARIO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
        Public Sub LeerUSUARIO()
            Try
                oBEUSUARIO = oDALCUSUARIORO.LeerUSUARIO(oBEUSUARIO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaUSUARIO()
			Try
				LstUSUARIO = oDALCUSUARIORO.LeerListaUSUARIO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
        Public Sub LeerUSUARIOLogIn()
            Try
                oBEUSUARIO = oDALCUSUARIORO.LeerUSUARIObyLogIn(oBEUSUARIO)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaUSUARIO_Paged()
			Try
				LstUSUARIO = oDALCUSUARIORO.LeerListaUSUARIO_Paged(oBEUSUARIO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: USUARIO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTUSUARIO() As Datatable
			Try
				oDTUSUARIO = oDALCUSUARIORO.LeerListaToDTUSUARIO()
				Return oDTUSUARIO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


