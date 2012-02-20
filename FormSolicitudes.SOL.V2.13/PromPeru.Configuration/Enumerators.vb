Public Class Enumerators
    Public Enum enumTipoObj As UShort
        Button = 1
        ImageButton = 2
    End Enum
    Public Enum tipoControlUSR As UShort
        Ingresa = 0
        Actualiza_Datos = 1
        Actualiza_Password = 2
    End Enum
    Public Enum tipoPersona As UShort
        juridico = 0
        juridico_Extrangero = 1
        natural_Negocio = 2
        org_estatal = 3
    End Enum
    Public Enum tipoMensaje As UShort
        Fallido = 0
        Correcto = 1
        Simple = 2
    End Enum
    Public Enum tipoLista As UShort
        Giro = 0
        Sector = 1
        Ambos = 2
    End Enum
    Public Enum emCRUD As UShort
        CREA = 0
        LEE = 1
        ACTUALIZA = 2
        ELIMINA = 3
    End Enum
End Class
