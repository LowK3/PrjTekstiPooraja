Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports PrjTekstiPoorajaKomponent

Public Class formKasutajaAken
    Private Sub formKasutajaAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Klass = New PrjTekstiPoorajaKomponent.TekstiPooraja

    Private Sub btnPooraFunktsiooniga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraFunktsiooniga.Click

        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = Klass

        pooraja.Tekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.PooraTekst
    End Sub

    Private Sub btnPooraProtseduuriga_Click(sender As Object, e As EventArgs) _
        Handles btnPooraProtseduuriga.Click

        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = Klass

        pooraja.TeisendaTekst(txtSisendTekst.Text)

        txtValjundTekst2.Text = pooraja.Tekst
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timerUuenda.Enabled = True

        btnStart.Enabled = False

        btnStopp.Enabled = True
    End Sub

    Private Sub btnStopp_Click(sender As Object, e As EventArgs) Handles btnStopp.Click
        timerUuenda.Enabled = False

        btnStart.Enabled = True

        btnStopp.Enabled = False
    End Sub

    Private Sub timerUuenda_Tick(sender As Object, e As EventArgs) Handles timerUuenda.Tick
        Dim pooraja As PrjTekstiPoorajaKomponent.ITeisendaja

        pooraja = Klass

        pooraja.Tekst = txtSisendTekst.Text

        txtValjundTekst1.Text = pooraja.PooraTekst
    End Sub

    Private Sub txtSisendTekst_TextChanged(sender As Object, e As EventArgs) Handles txtSisendTekst.TextChanged
        Dim nTaishaalikud As PrjTekstiPoorajaKomponent.ITeisendaja
        nTaishaalikud = Klass

        Dim tekst As String = txtSisendTekst.Text

        lblPikkus.Text = "Pikkus: " & tekst.Length

        lblTaishaalikuteArv.Text = "Täishäälikud: " & nTaishaalikud.LoeTaishaalikud(tekst)

        If Len(tekst) > 0 Then
            lblAscEsimene.Text = "Esimene Asc: " & Asc(Mid(tekst, 1, 1))
            lblAscViimane.Text = "Viimane Asc: " & Asc(Mid(tekst, Len(tekst), 1))
        Else
            lblAscEsimene.Text = "Esimene Asc: -"
            lblAscViimane.Text = "Viimane Asc: -"
        End If

    End Sub

    Private Sub chcAlgoritmilinePooraja_CheckedChanged(sender As Object, e As EventArgs) Handles chcAlgoritmilinePooraja.CheckedChanged
        If chcAlgoritmilinePooraja.Checked Then
            Klass = New PrjTekstiPoorajaKomponent.AlgoritmilineTekstiPooraja
        Else
            Klass = New PrjTekstiPoorajaKomponent.TekstiPooraja
        End If
    End Sub

End Class
