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
	''' Fecha Creacion: 10/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DOCUMENTOS_ADICIONALES
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_DOCUMENTOS_ADICIONALESTX
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCDOCUMENTOS_ADICIONALESTX As clsDALC_DOCUMENTOS_ADICIONALESTX
		Public oBEDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES
		Public LstDOCUMENTOS_ADICIONALES As New List(Of clsBE_DOCUMENTOS_ADICIONALES)
		
		Sub New()
			oDALCDOCUMENTOS_ADICIONALESTX = New clsDALC_DOCUMENTOS_ADICIONALESTX
			oBEDOCUMENTOS_ADICIONALES = New clsBE_DOCUMENTOS_ADICIONALES
		End Sub
		
		Public Sub NuevaEntidad()
			oBEDOCUMENTOS_ADICIONALES = New clsBE_DOCUMENTOS_ADICIONALES
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Metodo de Inserción de Datos DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function InsertarDOCUMENTOS_ADICIONALES() As Boolean
			Try
				Return oDALCDOCUMENTOS_ADICIONALESTX.InsertarDOCUMENTOS_ADICIONALES(LstDOCUMENTOS_ADICIONALES)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Metodo de Actualizacion de Datos de la Entidad: DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function EliminarDOCUMENTOS_ADICIONALES() As Boolean
			Try
				Return oDALCDOCUMENTOS_ADICIONALESTX.EliminarDOCUMENTOS_ADICIONALES(LstDOCUMENTOS_ADICIONALES)
			Catch ex As Exception
				Throw ex
				Return False
			End Try
		End Function
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Metodo de Eliminación de Datos de la Entidad: DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function ModificarDOCUMENTOS_ADICIONALES() As Boolean
			Try
				Return oDALCDOCUMENTOS_ADICIONALESTX.ModificarDOCUMENTOS_ADICIONALES(LstDOCUMENTOS_ADICIONALES)
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
	''' Fecha Creacion: 10/01/2012
	''' Proposito: Ejecuta las transacciones directas a la Base de Datos para la tabla DOCUMENTOS_ADICIONALES
	''' Fecha Modificacion: 
	''' </summary> 
	'''
	<Serializable()> _
	Public Class clsBC_DOCUMENTOS_ADICIONALESRO
		'Inherits ServicedComponent

		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Ejecuta los metodos transaccionales de la clase clsDALC_DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		'''
		
		Private oDALCDOCUMENTOS_ADICIONALESRO As clsDALC_DOCUMENTOS_ADICIONALESRO
		Public oBEDOCUMENTOS_ADICIONALES As clsBE_DOCUMENTOS_ADICIONALES
		Public LstDOCUMENTOS_ADICIONALES As New List(Of clsBE_DOCUMENTOS_ADICIONALES)
		Public oDTDOCUMENTOS_ADICIONALES As New DataTable
		
		Sub New()
			oDALCDOCUMENTOS_ADICIONALESRO = New clsDALC_DOCUMENTOS_ADICIONALESRO
			oBEDOCUMENTOS_ADICIONALES = New clsBE_DOCUMENTOS_ADICIONALES
		End Sub
		
		Public Sub NuevaEntidad()
			oBEDOCUMENTOS_ADICIONALES = New clsBE_DOCUMENTOS_ADICIONALES
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtiene un campo de la entidad: DOCUMENTOS_ADICIONALES filtrada por el ID o Codigo de la misma.
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerDOCUMENTOS_ADICIONALES
			Try
				oBEDOCUMENTOS_ADICIONALES = oDALCDOCUMENTOS_ADICIONALESRO.LeerDOCUMENTOS_ADICIONALES(oBEDOCUMENTOS_ADICIONALES)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtinene una lista de la Entidad: DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaDOCUMENTOS_ADICIONALES()
			Try
				LstDOCUMENTOS_ADICIONALES = oDALCDOCUMENTOS_ADICIONALESRO.LeerListaDOCUMENTOS_ADICIONALES()
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtinene una lista paginada y filtrada de la Entidad:DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Sub LeerListaDOCUMENTOS_ADICIONALES_Paged()
			Try
				LstDOCUMENTOS_ADICIONALES = oDALCDOCUMENTOS_ADICIONALESRO.LeerListaDOCUMENTOS_ADICIONALES_Paged(oBEDOCUMENTOS_ADICIONALES)
			Catch ex As Exception
				Throw ex
			End Try
		End Sub
		
		'<AutoComplete()> _
		''' <summary>
		''' Escrito por: Alejandro Mayta C.
		''' Fecha Creacion: 10/01/2012
		''' Proposito: Obtiene un Datatable de la Entidad: DOCUMENTOS_ADICIONALES
		''' Fecha Modificacion: 
		''' </summary> 
		
		Public Function  LeerListaToDTDOCUMENTOS_ADICIONALES() As Datatable
			Try
				oDTDOCUMENTOS_ADICIONALES = oDALCDOCUMENTOS_ADICIONALESRO.LeerListaToDTDOCUMENTOS_ADICIONALES()
				Return oDTDOCUMENTOS_ADICIONALES
			Catch ex As Exception
				Throw ex
			End Try
        End Function

        '<AutoComplete()> _
        ''' <summary>
        ''' Escrito por: Alejandro Mayta C.
        ''' Fecha Creacion: 10/01/2012
        ''' Proposito: Obtiene un Datatable de la Entidad: DOCUMENTOS_ADICIONALES
        ''' Fecha Modificacion: 
        ''' </summary> 

        Public Function LeerListaToDTDOCUMENTOS_ADICIONALES(ByVal xIDsol As Long) As DataTable
            Try
                oDTDOCUMENTOS_ADICIONALES = oDALCDOCUMENTOS_ADICIONALESRO.LeerListaToDTDOCUMENTOS_ADICIONALESByIdSol(xIDsol)
                Return oDTDOCUMENTOS_ADICIONALES
            Catch ex As Exception
                Throw ex
            End Try
        End Function
		
	End Class
#End Region
End Namespace


