Public Class AlgoritmilineTekstiPooraja
    Implements ITeisendaja

    Public Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub TeisendaTekst(ByRef sisendTekst As String) Implements ITeisendaja.TeisendaTekst
        Throw New NotImplementedException()
    End Sub

    Public Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Throw New NotImplementedException()
    End Function

    Public Function LoeTaishaalikud(ByRef sisendTekst As String) As Object Implements ITeisendaja.LoeTaishaalikud
        Throw New NotImplementedException()
    End Function
End Class
