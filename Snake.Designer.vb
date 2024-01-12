<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Snake
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
        Me.tmrSnake = New System.Windows.Forms.Timer(Me.components)
        Me.lblSnake = New System.Windows.Forms.Label()
        Me.lblFood = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tmrSnake
        '
        Me.tmrSnake.Interval = 300
        '
        'lblSnake
        '
        Me.lblSnake.BackColor = System.Drawing.Color.Transparent
        Me.lblSnake.ForeColor = System.Drawing.Color.Transparent
        Me.lblSnake.Image = Global.TemporalDiscount.My.Resources.Resources.ball1
        Me.lblSnake.Location = New System.Drawing.Point(300, 300)
        Me.lblSnake.Name = "lblSnake"
        Me.lblSnake.Size = New System.Drawing.Size(50, 50)
        Me.lblSnake.TabIndex = 0
        '
        'lblFood
        '
        Me.lblFood.BackColor = System.Drawing.Color.Transparent
        Me.lblFood.ForeColor = System.Drawing.Color.Transparent
        Me.lblFood.Image = Global.TemporalDiscount.My.Resources.Resources.ball1
        Me.lblFood.Location = New System.Drawing.Point(100, 250)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(50, 50)
        Me.lblFood.TabIndex = 1
        Me.lblFood.Visible = False
        '
        'Snake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1874, 979)
        Me.Controls.Add(Me.lblFood)
        Me.Controls.Add(Me.lblSnake)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "Snake"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblSnake As Label
    Friend WithEvents tmrSnake As Timer
    Friend WithEvents lblFood As Label
End Class
