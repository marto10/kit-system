<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome))
        Me.welcomebtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'welcomebtn
        '
        Me.welcomebtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.welcomebtn.Font = New System.Drawing.Font("Goudy Old Style", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomebtn.ForeColor = System.Drawing.Color.DarkViolet
        Me.welcomebtn.Location = New System.Drawing.Point(157, 325)
        Me.welcomebtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.welcomebtn.Name = "welcomebtn"
        Me.welcomebtn.Size = New System.Drawing.Size(1119, 116)
        Me.welcomebtn.TabIndex = 0
        Me.welcomebtn.Text = "Welcome To SportsKit Management System"
        Me.welcomebtn.UseVisualStyleBackColor = False
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1479, 895)
        Me.Controls.Add(Me.welcomebtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Welcome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents welcomebtn As System.Windows.Forms.Button
End Class
