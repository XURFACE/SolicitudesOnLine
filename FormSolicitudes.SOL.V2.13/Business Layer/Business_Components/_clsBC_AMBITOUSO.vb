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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla AMBITOUSO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_AMBITOUSOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCAMBITOUSOTX As clsDALC_AMBITOUSOTX
		Public oBEAMBITOUSO As clsBE_AMBITOUSO
		Public LstAMBITOUSO As New List(Of clsBE_AMBITOUSO)
		
		Sub New()
			oDALCAMBITOUSOTX = New clsDALC_AMBITOUSOTX
			oBEAMBITOUSO = New clsBE_AMBITOUSO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEAMBITOUSO = New clsBE_AMBITOUSO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarAMBITOUSO() As Boolean
			Try
				Return oDALCAMBITOUSOTX.InsertarAMBITOUSO(LstAMBITOUSO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarAMBITOUSO() As Boolean
			Try
				Return oDALCAMBITOUSOTX.EliminarAMBITOUSO(LstAMBITOUSO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarAMBITOUSO() As Boolean
			Try
				Return oDALCAMBITOUSOTX.ModificarAMBITOUSO(LstAMBITOUSO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla AMBITOUSO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_AMBITOUSORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCAMBITOUSORO As clsDALC_AMBITOUSORO
		Public oBEAMBITOUSO As clsBE_AMBITOUSO
		Public LstAMBITOUSO As New List(Of clsBE_AMBITOUSO)
		Public oDTAMBITOUSO As New DataTable
		
		Sub New()
			oDALCAMBITOUSORO = New clsDALC_AMBITOUSORO
			oBEAMBITOUSO = New clsBE_AMBITOUSO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEAMBITOUSO = New clsBE_AMBITOUSO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: AMBITOUSO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerAMBITOUSO
			Try
				oBEAMBITOUSO = oDALCAMBITOUSORO.LeerAMBITOUSO(oBEAMBITOUSO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista de la Entidad: AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaAMBITOUSO()
			Try
				LstAMBITOUSO = oDALCAMBITOUSORO.LeerListaAMBITOUSO()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaAMBITOUSO_Paged()
			Try
				LstAMBITOUSO = oDALCAMBITOUSORO.LeerListaAMBITOUSO_Paged(oBEAMBITOUSO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: AMBITOUSO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTAMBITOUSO() As Datatable
			Try
				oDTAMBITOUSO = oDALCAMBITOUSORO.LeerListaToDTAMBITOUSO()
				Return oDTAMBITOUSO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


