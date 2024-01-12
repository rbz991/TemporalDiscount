<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnComenzar = New System.Windows.Forms.Button()
        Me.txbParticipante = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txbSesion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txbCOM = New System.Windows.Forms.TextBox()
        Me.rdoPhase1 = New System.Windows.Forms.RadioButton()
        Me.rdoPhase2 = New System.Windows.Forms.RadioButton()
        Me.rdoPhase3 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnComenzar
        '
        Me.btnComenzar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnComenzar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComenzar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnComenzar.Location = New System.Drawing.Point(1565, 658)
        Me.btnComenzar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnComenzar.Name = "btnComenzar"
        Me.btnComenzar.Size = New System.Drawing.Size(316, 165)
        Me.btnComenzar.TabIndex = 0
        Me.btnComenzar.Text = "Comenzar"
        Me.btnComenzar.UseVisualStyleBackColor = False
        '
        'txbParticipante
        '
        Me.txbParticipante.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbParticipante.Location = New System.Drawing.Point(717, 550)
        Me.txbParticipante.Margin = New System.Windows.Forms.Padding(4)
        Me.txbParticipante.Name = "txbParticipante"
        Me.txbParticipante.Size = New System.Drawing.Size(260, 85)
        Me.txbParticipante.TabIndex = 1
        Me.txbParticipante.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(257, 554)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(398, 79)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Participante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(257, 691)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(245, 79)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Sesión"
        '
        'txbSesion
        '
        Me.txbSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbSesion.Location = New System.Drawing.Point(717, 687)
        Me.txbSesion.Margin = New System.Windows.Forms.Padding(4)
        Me.txbSesion.Name = "txbSesion"
        Me.txbSesion.Size = New System.Drawing.Size(260, 85)
        Me.txbSesion.TabIndex = 3
        Me.txbSesion.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 833)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 79)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Puerto"
        '
        'txbCOM
        '
        Me.txbCOM.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbCOM.Location = New System.Drawing.Point(717, 829)
        Me.txbCOM.Margin = New System.Windows.Forms.Padding(4)
        Me.txbCOM.Name = "txbCOM"
        Me.txbCOM.Size = New System.Drawing.Size(260, 85)
        Me.txbCOM.TabIndex = 5
        Me.txbCOM.Text = "COM3"
        '
        'rdoPhase1
        '
        Me.rdoPhase1.AutoSize = True
        Me.rdoPhase1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPhase1.Location = New System.Drawing.Point(1069, 543)
        Me.rdoPhase1.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoPhase1.Name = "rdoPhase1"
        Me.rdoPhase1.Size = New System.Drawing.Size(274, 83)
        Me.rdoPhase1.TabIndex = 10
        Me.rdoPhase1.Text = "Fase 1"
        Me.rdoPhase1.UseVisualStyleBackColor = True
        '
        'rdoPhase2
        '
        Me.rdoPhase2.AutoSize = True
        Me.rdoPhase2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPhase2.Location = New System.Drawing.Point(1069, 687)
        Me.rdoPhase2.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoPhase2.Name = "rdoPhase2"
        Me.rdoPhase2.Size = New System.Drawing.Size(274, 83)
        Me.rdoPhase2.TabIndex = 11
        Me.rdoPhase2.TabStop = True
        Me.rdoPhase2.Text = "Fase 2"
        Me.rdoPhase2.UseVisualStyleBackColor = True
        '
        'rdoPhase3
        '
        Me.rdoPhase3.AutoSize = True
        Me.rdoPhase3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoPhase3.Location = New System.Drawing.Point(1069, 831)
        Me.rdoPhase3.Margin = New System.Windows.Forms.Padding(6)
        Me.rdoPhase3.Name = "rdoPhase3"
        Me.rdoPhase3.Size = New System.Drawing.Size(274, 83)
        Me.rdoPhase3.TabIndex = 12
        Me.rdoPhase3.TabStop = True
        Me.rdoPhase3.Text = "Fase 3"
        Me.rdoPhase3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 15)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(772, 42)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Universidad Nacional Autónoma de México"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(791, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(428, 42)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Facultad de Psicología "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(465, 175)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(938, 42)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Laboratorio de Analisis Experimental de la Conducta"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(1565, 485)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(316, 165)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Bomba I/O"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TemporalDiscount.My.Resources.Resources.unam
        Me.PictureBox1.Location = New System.Drawing.Point(15, 15)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(211, 227)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TemporalDiscount.My.Resources.Resources.psi
        Me.PictureBox2.Location = New System.Drawing.Point(1627, 15)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(252, 221)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnFinalizar.Location = New System.Drawing.Point(1565, 831)
        Me.btnFinalizar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(316, 165)
        Me.btnFinalizar.TabIndex = 19
        Me.btnFinalizar.Text = "Finalizar"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Data
        '
        Me.AcceptButton = Me.btnComenzar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1894, 1009)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rdoPhase3)
        Me.Controls.Add(Me.rdoPhase2)
        Me.Controls.Add(Me.rdoPhase1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txbCOM)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txbSesion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txbParticipante)
        Me.Controls.Add(Me.btnComenzar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Data"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComenzar As Button
    Friend WithEvents txbParticipante As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txbSesion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txbCOM As TextBox
    Friend WithEvents rdoPhase1 As RadioButton
    Friend WithEvents rdoPhase2 As RadioButton
    Friend WithEvents rdoPhase3 As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnFinalizar As Button
End Class
