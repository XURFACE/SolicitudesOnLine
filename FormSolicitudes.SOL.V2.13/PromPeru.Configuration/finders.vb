Imports MP.DW.BL
Namespace Finders
    Public Class finderAmbitoUso
        Private IDDETPUBLICO As Integer
        Sub New(ByVal _intIDDETPUBLICO As Integer)
            IDDETPUBLICO = _intIDDETPUBLICO
        End Sub
        Public Function findAmbitoUso(ByVal objAmbito As BE.clsBE_AMBITOUSO) As Boolean
            Return objAmbito.intIDDETPUBLICO = IDDETPUBLICO
        End Function
    End Class
End Namespace
