Public Class AlgoritmilineTekstiPooraja
    Implements ITeisendaja

    ' Klassi TekstiPooraja atribuudid
    Private AlgusSymbol As Integer
    Private LoppSymbol As Integer
    Private PooratavTekst As String
    Private Const Taishaalikud As String = "aeiouõäöü"

    Private Property EsimeseTaheAsciiKood As Integer Implements ITeisendaja.EsimeseTaheAsciiKood
        Get
            Return AlgusSymbol
        End Get
        Set(value As Integer)
            AlgusSymbol = value
        End Set
    End Property

    Private Property ViimaseTaheAsciiKood As Integer Implements ITeisendaja.ViimaseTaheAsciiKood
        Get
            Return LoppSymbol
        End Get
        Set(value As Integer)
            LoppSymbol = value
        End Set
    End Property

    Private Property Tekst As String Implements ITeisendaja.Tekst
        Get
            Return PooratavTekst
        End Get
        Set(value As String)
            PooratavTekst = value
        End Set
    End Property

    Private Sub TeisendaTekst(ByRef sisendTekst As String) _
        Implements ITeisendaja.TeisendaTekst

        Dim tagurpidiTekst As String

        For i = sisendTekst.Length - 1 To 0 Step -1
            tagurpidiTekst = tagurpidiTekst & sisendTekst.Chars(i)
        Next
        PooratavTekst = tagurpidiTekst
    End Sub

    Private Function PooraTekst() As String _
        Implements ITeisendaja.PooraTekst
        Dim tagurpidiTekst As String

        For i = PooratavTekst.Length - 1 To 0 Step -1
            tagurpidiTekst = tagurpidiTekst & PooratavTekst.Chars(i)
        Next
        Return tagurpidiTekst
    End Function

    Private Function LoeTaishaalikud(ByRef sisendTekst As String) _
        Implements ITeisendaja.LoeTaishaalikud
        Dim numTaishaalikud As Integer = 0

        For i = 1 To Len(sisendTekst)
            If InStr(Taishaalikud, Mid(sisendTekst, i, 1)) Then
                numTaishaalikud = numTaishaalikud + 1
            End If
        Next
        Return numTaishaalikud
    End Function
End Class