Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports PrjTekstiPoorajaKomponent

Public Class formKasutajaAken
    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = New PrjTekstiPoorajaKomponent.TekstiPooraja

        pooraja.Tekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.PooraTekst
    End Sub
End Class
