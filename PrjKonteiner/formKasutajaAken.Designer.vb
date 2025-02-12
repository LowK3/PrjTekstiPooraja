<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKasutajaAken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.txtSisendTekst = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst1 = New System.Windows.Forms.TextBox()
        Me.txtValjundTekst2 = New System.Windows.Forms.TextBox()
        Me.btnPooraFunktsiooniga = New System.Windows.Forms.Button()
        Me.btnPooraProtseduuriga = New System.Windows.Forms.Button()
        Me.lblSisendtekst = New System.Windows.Forms.Label()
        Me.lblPooramineFunktsiooniga = New System.Windows.Forms.Label()
        Me.lblPooramineProtseduuriga = New System.Windows.Forms.Label()
        Me.btnStopp = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.timerUuenda = New System.Windows.Forms.Timer(Me.components)
        Me.lblPikkus = New System.Windows.Forms.Label()
        Me.lblTaishaalikuteArv = New System.Windows.Forms.Label()
        Me.lblAscViimane = New System.Windows.Forms.Label()
        Me.lblAscEsimene = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSisendTekst
        '
        Me.txtSisendTekst.Location = New System.Drawing.Point(228, 29)
        Me.txtSisendTekst.Name = "txtSisendTekst"
        Me.txtSisendTekst.Size = New System.Drawing.Size(431, 26)
        Me.txtSisendTekst.TabIndex = 0
        '
        'txtValjundTekst1
        '
        Me.txtValjundTekst1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtValjundTekst1.Location = New System.Drawing.Point(228, 140)
        Me.txtValjundTekst1.Name = "txtValjundTekst1"
        Me.txtValjundTekst1.ReadOnly = True
        Me.txtValjundTekst1.Size = New System.Drawing.Size(431, 26)
        Me.txtValjundTekst1.TabIndex = 1
        '
        'txtValjundTekst2
        '
        Me.txtValjundTekst2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtValjundTekst2.Location = New System.Drawing.Point(228, 263)
        Me.txtValjundTekst2.Name = "txtValjundTekst2"
        Me.txtValjundTekst2.ReadOnly = True
        Me.txtValjundTekst2.Size = New System.Drawing.Size(431, 26)
        Me.txtValjundTekst2.TabIndex = 2
        '
        'btnPooraFunktsiooniga
        '
        Me.btnPooraFunktsiooniga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPooraFunktsiooniga.Location = New System.Drawing.Point(295, 186)
        Me.btnPooraFunktsiooniga.Name = "btnPooraFunktsiooniga"
        Me.btnPooraFunktsiooniga.Size = New System.Drawing.Size(274, 34)
        Me.btnPooraFunktsiooniga.TabIndex = 3
        Me.btnPooraFunktsiooniga.Text = "Pööra Funktsiooniga"
        Me.btnPooraFunktsiooniga.UseVisualStyleBackColor = True
        '
        'btnPooraProtseduuriga
        '
        Me.btnPooraProtseduuriga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPooraProtseduuriga.Location = New System.Drawing.Point(295, 309)
        Me.btnPooraProtseduuriga.Name = "btnPooraProtseduuriga"
        Me.btnPooraProtseduuriga.Size = New System.Drawing.Size(274, 34)
        Me.btnPooraProtseduuriga.TabIndex = 4
        Me.btnPooraProtseduuriga.Text = "Pööra Protseduuriga"
        Me.btnPooraProtseduuriga.UseVisualStyleBackColor = True
        '
        'lblSisendtekst
        '
        Me.lblSisendtekst.AutoSize = True
        Me.lblSisendtekst.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSisendtekst.Location = New System.Drawing.Point(82, 30)
        Me.lblSisendtekst.Name = "lblSisendtekst"
        Me.lblSisendtekst.Size = New System.Drawing.Size(114, 25)
        Me.lblSisendtekst.TabIndex = 5
        Me.lblSisendtekst.Text = "Sisendtekst"
        '
        'lblPooramineFunktsiooniga
        '
        Me.lblPooramineFunktsiooniga.AutoSize = True
        Me.lblPooramineFunktsiooniga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPooramineFunktsiooniga.Location = New System.Drawing.Point(6, 141)
        Me.lblPooramineFunktsiooniga.Name = "lblPooramineFunktsiooniga"
        Me.lblPooramineFunktsiooniga.Size = New System.Drawing.Size(191, 25)
        Me.lblPooramineFunktsiooniga.TabIndex = 6
        Me.lblPooramineFunktsiooniga.Text = "Pööra Funktsiooniga"
        '
        'lblPooramineProtseduuriga
        '
        Me.lblPooramineProtseduuriga.AutoSize = True
        Me.lblPooramineProtseduuriga.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPooramineProtseduuriga.Location = New System.Drawing.Point(6, 264)
        Me.lblPooramineProtseduuriga.Name = "lblPooramineProtseduuriga"
        Me.lblPooramineProtseduuriga.Size = New System.Drawing.Size(190, 25)
        Me.lblPooramineProtseduuriga.TabIndex = 7
        Me.lblPooramineProtseduuriga.Text = "Pööra Protseduuriga"
        '
        'btnStopp
        '
        Me.btnStopp.Enabled = False
        Me.btnStopp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopp.Location = New System.Drawing.Point(455, 396)
        Me.btnStopp.Name = "btnStopp"
        Me.btnStopp.Size = New System.Drawing.Size(114, 36)
        Me.btnStopp.TabIndex = 8
        Me.btnStopp.Text = "Stopp"
        Me.btnStopp.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(295, 396)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(114, 36)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'timerUuenda
        '
        Me.timerUuenda.Interval = 3000
        '
        'lblPikkus
        '
        Me.lblPikkus.AutoSize = True
        Me.lblPikkus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPikkus.Location = New System.Drawing.Point(670, 32)
        Me.lblPikkus.Name = "lblPikkus"
        Me.lblPikkus.Size = New System.Drawing.Size(68, 22)
        Me.lblPikkus.TabIndex = 10
        Me.lblPikkus.Text = "Pikkus:"
        '
        'lblTaishaalikuteArv
        '
        Me.lblTaishaalikuteArv.AutoSize = True
        Me.lblTaishaalikuteArv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaishaalikuteArv.Location = New System.Drawing.Point(621, 58)
        Me.lblTaishaalikuteArv.Name = "lblTaishaalikuteArv"
        Me.lblTaishaalikuteArv.Size = New System.Drawing.Size(117, 22)
        Me.lblTaishaalikuteArv.TabIndex = 12
        Me.lblTaishaalikuteArv.Text = "Täishäälikud:"
        '
        'lblAscViimane
        '
        Me.lblAscViimane.AutoSize = True
        Me.lblAscViimane.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAscViimane.Location = New System.Drawing.Point(621, 102)
        Me.lblAscViimane.Name = "lblAscViimane"
        Me.lblAscViimane.Size = New System.Drawing.Size(119, 22)
        Me.lblAscViimane.TabIndex = 13
        Me.lblAscViimane.Text = "Viimane Asc: "
        '
        'lblAscEsimene
        '
        Me.lblAscEsimene.AutoSize = True
        Me.lblAscEsimene.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAscEsimene.Location = New System.Drawing.Point(621, 80)
        Me.lblAscEsimene.Name = "lblAscEsimene"
        Me.lblAscEsimene.Size = New System.Drawing.Size(124, 22)
        Me.lblAscEsimene.TabIndex = 14
        Me.lblAscEsimene.Text = "Esimene Asc: "
        '
        'formKasutajaAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblAscEsimene)
        Me.Controls.Add(Me.lblAscViimane)
        Me.Controls.Add(Me.lblTaishaalikuteArv)
        Me.Controls.Add(Me.lblPikkus)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnStopp)
        Me.Controls.Add(Me.lblPooramineProtseduuriga)
        Me.Controls.Add(Me.lblPooramineFunktsiooniga)
        Me.Controls.Add(Me.lblSisendtekst)
        Me.Controls.Add(Me.btnPooraProtseduuriga)
        Me.Controls.Add(Me.btnPooraFunktsiooniga)
        Me.Controls.Add(Me.txtValjundTekst2)
        Me.Controls.Add(Me.txtValjundTekst1)
        Me.Controls.Add(Me.txtSisendTekst)
        Me.Name = "formKasutajaAken"
        Me.Text = "Tekstitöötlus"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSisendTekst As TextBox
    Friend WithEvents txtValjundTekst1 As TextBox
    Friend WithEvents txtValjundTekst2 As TextBox
    Friend WithEvents btnPooraFunktsiooniga As Button
    Friend WithEvents btnPooraProtseduuriga As Button
    Friend WithEvents lblSisendtekst As Label
    Friend WithEvents lblPooramineFunktsiooniga As Label
    Friend WithEvents lblPooramineProtseduuriga As Label
    Friend WithEvents btnStopp As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents timerUuenda As Timer
    Friend WithEvents lblPikkus As Label
    Friend WithEvents lblTaishaalikuteArv As Label
    Friend WithEvents lblAscViimane As Label
    Friend WithEvents lblAscEsimene As Label
End Class
