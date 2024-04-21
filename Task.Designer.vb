<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Task
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Task))
        Me.lblPrefieres = New System.Windows.Forms.Label()
        Me.btnIzquierda = New System.Windows.Forms.Button()
        Me.btnDerecha = New System.Windows.Forms.Button()
        Me.tmrDelay = New System.Windows.Forms.Timer(Me.components)
        Me.btnRef = New System.Windows.Forms.Button()
        Me.tmrRestart = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.tmrProgressBar = New System.Windows.Forms.Timer(Me.components)
        Me.lblEspera = New System.Windows.Forms.Label()
        Me.btnButton = New System.Windows.Forms.Button()
        Me.tmrDebug = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPhase1Intervals = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrSnake = New System.Windows.Forms.Timer(Me.components)
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblSnake = New System.Windows.Forms.Label()
        Me.tmrForcedDelay = New System.Windows.Forms.Timer(Me.components)
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.tmrVideoPlay = New System.Windows.Forms.Timer(Me.components)
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPrefieres
        '
        Me.lblPrefieres.AutoSize = True
        Me.lblPrefieres.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefieres.Location = New System.Drawing.Point(10, 7)
        Me.lblPrefieres.Name = "lblPrefieres"
        Me.lblPrefieres.Size = New System.Drawing.Size(1094, 65)
        Me.lblPrefieres.TabIndex = 0
        Me.lblPrefieres.Text = "Da click para iniciar la toma de decisiones"
        '
        'btnIzquierda
        '
        Me.btnIzquierda.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnIzquierda.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnIzquierda.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIzquierda.Location = New System.Drawing.Point(10, 245)
        Me.btnIzquierda.Name = "btnIzquierda"
        Me.btnIzquierda.Size = New System.Drawing.Size(488, 320)
        Me.btnIzquierda.TabIndex = 1
        Me.btnIzquierda.Text = "."
        Me.btnIzquierda.UseVisualStyleBackColor = False
        Me.btnIzquierda.Visible = False
        '
        'btnDerecha
        '
        Me.btnDerecha.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDerecha.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnDerecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDerecha.Location = New System.Drawing.Point(923, 245)
        Me.btnDerecha.Name = "btnDerecha"
        Me.btnDerecha.Size = New System.Drawing.Size(488, 320)
        Me.btnDerecha.TabIndex = 2
        Me.btnDerecha.Text = "."
        Me.btnDerecha.UseVisualStyleBackColor = False
        Me.btnDerecha.Visible = False
        '
        'tmrDelay
        '
        '
        'btnRef
        '
        Me.btnRef.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRef.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRef.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRef.Location = New System.Drawing.Point(484, 251)
        Me.btnRef.Name = "btnRef"
        Me.btnRef.Size = New System.Drawing.Size(450, 308)
        Me.btnRef.TabIndex = 3
        Me.btnRef.Text = "Comenzar"
        Me.btnRef.UseVisualStyleBackColor = False
        '
        'tmrRestart
        '
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(18, 754)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1384, 35)
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.Visible = False
        '
        'tmrProgressBar
        '
        Me.tmrProgressBar.Interval = 500
        '
        'lblEspera
        '
        Me.lblEspera.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblEspera.AutoSize = True
        Me.lblEspera.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEspera.Location = New System.Drawing.Point(473, 180)
        Me.lblEspera.Name = "lblEspera"
        Me.lblEspera.Size = New System.Drawing.Size(451, 65)
        Me.lblEspera.TabIndex = 5
        Me.lblEspera.Text = "Por favor espera"
        Me.lblEspera.Visible = False
        '
        'btnButton
        '
        Me.btnButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnButton.Location = New System.Drawing.Point(348, 572)
        Me.btnButton.Name = "btnButton"
        Me.btnButton.Size = New System.Drawing.Size(150, 150)
        Me.btnButton.TabIndex = 15
        Me.btnButton.UseVisualStyleBackColor = True
        Me.btnButton.Visible = False
        '
        'tmrDebug
        '
        Me.tmrDebug.Interval = 5
        '
        'tmrPhase1Intervals
        '
        Me.tmrPhase1Intervals.Interval = 2000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Label1"
        Me.Label1.Visible = False
        '
        'tmrSnake
        '
        Me.tmrSnake.Interval = 300
        '
        'lblFood
        '
        Me.lblFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFood.ForeColor = System.Drawing.Color.Transparent
        Me.lblFood.Image = Global.TemporalDiscount.My.Resources.Resources.ball1
        Me.lblFood.Location = New System.Drawing.Point(124, -48)
        Me.lblFood.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(45, 48)
        Me.lblFood.TabIndex = 18
        Me.lblFood.Visible = False
        '
        'lblSnake
        '
        Me.lblSnake.BackColor = System.Drawing.Color.Transparent
        Me.lblSnake.ForeColor = System.Drawing.Color.Transparent
        Me.lblSnake.Image = Global.TemporalDiscount.My.Resources.Resources.ball1
        Me.lblSnake.Location = New System.Drawing.Point(75, -48)
        Me.lblSnake.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSnake.Name = "lblSnake"
        Me.lblSnake.Size = New System.Drawing.Size(45, 48)
        Me.lblSnake.TabIndex = 17
        '
        'tmrForcedDelay
        '
        Me.tmrForcedDelay.Interval = 10000
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(10, 12)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1022, 615)
        Me.AxWindowsMediaPlayer1.TabIndex = 19
        Me.AxWindowsMediaPlayer1.Visible = False
        '
        'tmrVideoPlay
        '
        '
        'Task
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1420, 807)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblSnake)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnButton)
        Me.Controls.Add(Me.lblEspera)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btnRef)
        Me.Controls.Add(Me.btnDerecha)
        Me.Controls.Add(Me.btnIzquierda)
        Me.Controls.Add(Me.lblPrefieres)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Task"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPrefieres As Label
    Friend WithEvents btnIzquierda As Button
    Friend WithEvents btnDerecha As Button
    Friend WithEvents tmrDelay As Timer
    Friend WithEvents btnRef As Button
    Friend WithEvents tmrRestart As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents tmrProgressBar As Timer
    Friend WithEvents lblEspera As Label
    Friend WithEvents btnButton As Button
    Friend WithEvents tmrDebug As Timer
    Friend WithEvents tmrPhase1Intervals As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrSnake As Timer
    Friend WithEvents lblFood As Label
    Friend WithEvents lblSnake As Label
    Friend WithEvents tmrForcedDelay As Timer
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents tmrVideoPlay As Timer
End Class
