<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class progbar
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.L1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Prog = New CircularProgressBar.CircularProgressBar()
        Me.T1 = New System.Windows.Forms.Timer(Me.components)
        Me.T2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.L1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Prog)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 292)
        Me.Panel1.TabIndex = 0
        '
        'L1
        '
        Me.L1.AutoSize = True
        Me.L1.BackColor = System.Drawing.Color.DarkMagenta
        Me.L1.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.L1.ForeColor = System.Drawing.Color.White
        Me.L1.Location = New System.Drawing.Point(236, 238)
        Me.L1.Name = "L1"
        Me.L1.Size = New System.Drawing.Size(163, 29)
        Me.L1.TabIndex = 27
        Me.L1.Text = "LOADING..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(509, 29)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "SPORTS KIT MANAGEMENT SYSTEM"
        '
        'Prog
        '
        Me.Prog.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner
        Me.Prog.AnimationSpeed = 500
        Me.Prog.BackColor = System.Drawing.Color.Transparent
        Me.Prog.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold)
        Me.Prog.ForeColor = System.Drawing.Color.Black
        Me.Prog.InnerColor = System.Drawing.Color.Gray
        Me.Prog.InnerMargin = 2
        Me.Prog.InnerWidth = -1
        Me.Prog.Location = New System.Drawing.Point(177, 54)
        Me.Prog.MarqueeAnimationSpeed = 2000
        Me.Prog.Name = "Prog"
        Me.Prog.OuterColor = System.Drawing.Color.Black
        Me.Prog.OuterMargin = -25
        Me.Prog.OuterWidth = 26
        Me.Prog.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Prog.ProgressWidth = 25
        Me.Prog.SecondaryFont = New System.Drawing.Font("Microsoft Sans Serif", 36.0!)
        Me.Prog.Size = New System.Drawing.Size(244, 152)
        Me.Prog.StartAngle = 270
        Me.Prog.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.Prog.SubscriptColor = System.Drawing.Color.Black
        Me.Prog.SubscriptMargin = New System.Windows.Forms.Padding(10, -35, 0, 0)
        Me.Prog.SubscriptText = "%"
        Me.Prog.SuperscriptColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Prog.SuperscriptMargin = New System.Windows.Forms.Padding(10, 35, 0, 0)
        Me.Prog.SuperscriptText = ""
        Me.Prog.TabIndex = 24
        Me.Prog.Text = "0"
        Me.Prog.TextMargin = New System.Windows.Forms.Padding(8, 8, 0, 0)
        Me.Prog.Value = 68
        '
        'T1
        '
        Me.T1.Interval = 30
        '
        'T2
        '
        Me.T2.Interval = 30
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 292)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Prog As CircularProgressBar.CircularProgressBar
    Friend WithEvents L1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents T1 As System.Windows.Forms.Timer
    Friend WithEvents T2 As System.Windows.Forms.Timer
End Class
