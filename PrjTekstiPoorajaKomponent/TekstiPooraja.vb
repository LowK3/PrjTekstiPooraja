Public Class TekstiPooraja
    Implements ITeisendaja

    ' Klassi TekstiPooraja atribuudid
    Private AlguseSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String

    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Sub TeisendaTekst(ByRef sisendTekst As String) Implements ITeisendaja.TeisendaTekst
        Throw New NotImplementedException()
    End Sub

    Private Function PooraTekst() As String Implements ITeisendaja.PooraTekst
        Throw New NotImplementedException()
    End Function
End Class
