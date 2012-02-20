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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DET_USO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_DET_USOTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCDET_USOTX As clsDALC_DET_USOTX
		Public oBEDET_USO As clsBE_DET_USO
		Public LstDET_USO As New List(Of clsBE_DET_USO)
		
		Sub New()
			oDALCDET_USOTX = New clsDALC_DET_USOTX
			oBEDET_USO = New clsBE_DET_USO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEDET_USO = New clsBE_DET_USO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Inserción de Datos DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarDET_USO() As Boolean
			Try
				Return oDALCDET_USOTX.InsertarDET_USO(LstDET_USO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarDET_USO() As Boolean
			Try
				Return oDALCDET_USOTX.EliminarDET_USO(LstDET_USO)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarDET_USO() As Boolean
			Try
				Return oDALCDET_USOTX.ModificarDET_USO(LstDET_USO)
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
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DET_USO
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_DET_USORO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCDET_USORO As clsDALC_DET_USORO
		Public oBEDET_USO As clsBE_DET_USO
		Public LstDET_USO As New List(Of clsBE_DET_USO)
		Public oDTDET_USO As New DataTable
		
		Sub New()
			oDALCDET_USORO = New clsDALC_DET_USORO
			oBEDET_USO = New clsBE_DET_USO
		End Sub
		
		Public Sub NuevaEntidad()
			oBEDET_USO = New clsBE_DET_USO
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un campo de la entidad: DET_USO filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerDET_USO
			Try
				oBEDET_USO = oDALCDET_USORO.LeerDET_USO(oBEDET_USO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtinene una lista de la Entidad: DET_USO
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Sub LeerListaDET_USO()
            Try
                LstDET_USO = oDALCDET_USORO.LeerListaDET_USO()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 23/12/2011
        ''' Proposito: Obtinene una lista de la Entidad: DET_USO
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Sub LeerListaDET_USO_ByIdSol()
            Try
                LstDET_USO = oDALCDET_USORO.LeerListaDET_USOByIdSol(oBEDET_USO.lngIDSOLICITUD)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaDET_USO_Paged()
			Try
				LstDET_USO = oDALCDET_USORO.LeerListaDET_USO_Paged(oBEDET_USO)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 23/12/2011
		''' Proposito: Obtiene un Datatable de la Entidad: DET_USO
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTDET_USO() As Datatable
			Try
				oDTDET_USO = oDALCDET_USORO.LeerListaToDTDET_USO()
				Return oDTDET_USO
			Catch ex As Exception
				Throw ex
			End Try
		End Function 
		
	End Class
#End Region
End Namespace


