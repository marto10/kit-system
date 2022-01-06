<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.Product_TableTableAdapter = New Sportmgkit.CategoryDataSetTableAdapters.Product_TableTableAdapter()
        Me.phonelbl = New System.Windows.Forms.Label()
        Me.Custphonetxt = New System.Windows.Forms.TextBox()
        Me.Custnametxt = New System.Windows.Forms.TextBox()
        Me.Customeridtxt = New System.Windows.Forms.TextBox()
        Me.CustomerDGV = New System.Windows.Forms.DataGridView()
        Me.Searchbtn = New System.Windows.Forms.Button()
        Me.CategoryDataSet = New Sportmgkit.CategoryDataSet()
        Me.Deletebtn = New System.Windows.Forms.Button()
        Me.AddCustbtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ProductTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CustCountlbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Ordcountlbl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Product_TableTableAdapter
        '
        Me.Product_TableTableAdapter.ClearBeforeFill = True
        '
        'phonelbl
        '
        Me.phonelbl.AutoSize = True
        Me.phonelbl.BackColor = System.Drawing.Color.White
        Me.phonelbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phonelbl.ForeColor = System.Drawing.Color.Purple
        Me.phonelbl.Location = New System.Drawing.Point(608, 107)
        Me.phonelbl.Name = "phonelbl"
        Me.phonelbl.Size = New System.Drawing.Size(80, 21)
        Me.phonelbl.TabIndex = 48
        Me.phonelbl.Text = "PHONE"
        '
        'Custphonetxt
        '
        Me.Custphonetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custphonetxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Custphonetxt.Location = New System.Drawing.Point(612, 143)
        Me.Custphonetxt.Name = "Custphonetxt"
        Me.Custphonetxt.Size = New System.Drawing.Size(145, 26)
        Me.Custphonetxt.TabIndex = 47
        '
        'Custnametxt
        '
        Me.Custnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custnametxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Custnametxt.Location = New System.Drawing.Point(325, 143)
        Me.Custnametxt.Name = "Custnametxt"
        Me.Custnametxt.Size = New System.Drawing.Size(216, 26)
        Me.Custnametxt.TabIndex = 45
        '
        'Customeridtxt
        '
        Me.Customeridtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customeridtxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.Customeridtxt.Location = New System.Drawing.Point(141, 143)
        Me.Customeridtxt.Name = "Customeridtxt"
        Me.Customeridtxt.Size = New System.Drawing.Size(86, 26)
        Me.Customeridtxt.TabIndex = 44
        '
        'CustomerDGV
        '
        Me.CustomerDGV.BackgroundColor = System.Drawing.Color.White
        Me.CustomerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerDGV.GridColor = System.Drawing.Color.Purple
        Me.CustomerDGV.Location = New System.Drawing.Point(87, 315)
        Me.CustomerDGV.Name = "CustomerDGV"
        Me.CustomerDGV.Size = New System.Drawing.Size(780, 218)
        Me.CustomerDGV.TabIndex = 42
        '
        'Searchbtn
        '
        Me.Searchbtn.BackColor = System.Drawing.Color.Purple
        Me.Searchbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Searchbtn.Location = New System.Drawing.Point(612, 202)
        Me.Searchbtn.Name = "Searchbtn"
        Me.Searchbtn.Size = New System.Drawing.Size(107, 36)
        Me.Searchbtn.TabIndex = 41
        Me.Searchbtn.Text = "SEARCH"
        Me.Searchbtn.UseVisualStyleBackColor = False
        '
        'CategoryDataSet
        '
        Me.CategoryDataSet.DataSetName = "CategoryDataSet"
        Me.CategoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Deletebtn
        '
        Me.Deletebtn.BackColor = System.Drawing.Color.Purple
        Me.Deletebtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Deletebtn.Location = New System.Drawing.Point(277, 202)
        Me.Deletebtn.Name = "Deletebtn"
        Me.Deletebtn.Size = New System.Drawing.Size(118, 36)
        Me.Deletebtn.TabIndex = 39
        Me.Deletebtn.Text = "DELETE"
        Me.Deletebtn.UseVisualStyleBackColor = False
        '
        'AddCustbtn
        '
        Me.AddCustbtn.BackColor = System.Drawing.Color.Purple
        Me.AddCustbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.AddCustbtn.Location = New System.Drawing.Point(141, 202)
        Me.AddCustbtn.Name = "AddCustbtn"
        Me.AddCustbtn.Size = New System.Drawing.Size(88, 36)
        Me.AddCustbtn.TabIndex = 38
        Me.AddCustbtn.Text = "ADD"
        Me.AddCustbtn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(321, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "CUSTOMER NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(137, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Customer ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(361, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "MANAGE CUSTOMERS"
        '
        'ProductTableBindingSource
        '
        Me.ProductTableBindingSource.DataMember = "Product_Table"
        Me.ProductTableBindingSource.DataSource = Me.CategoryDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.clearbtn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.phonelbl)
        Me.Panel1.Controls.Add(Me.Custphonetxt)
        Me.Panel1.Controls.Add(Me.Custnametxt)
        Me.Panel1.Controls.Add(Me.Customeridtxt)
        Me.Panel1.Controls.Add(Me.CustomerDGV)
        Me.Panel1.Controls.Add(Me.Searchbtn)
        Me.Panel1.Controls.Add(Me.Deletebtn)
        Me.Panel1.Controls.Add(Me.AddCustbtn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 582)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Purple
        Me.Panel5.Controls.Add(Me.CustCountlbl)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(814, 96)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(159, 100)
        Me.Panel5.TabIndex = 54
        '
        'CustCountlbl
        '
        Me.CustCountlbl.AutoSize = True
        Me.CustCountlbl.BackColor = System.Drawing.Color.Purple
        Me.CustCountlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustCountlbl.ForeColor = System.Drawing.Color.White
        Me.CustCountlbl.Location = New System.Drawing.Point(7, 64)
        Me.CustCountlbl.Name = "CustCountlbl"
        Me.CustCountlbl.Size = New System.Drawing.Size(50, 21)
        Me.CustCountlbl.TabIndex = 52
        Me.CustCountlbl.Text = "Num"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Purple
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 21)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Customer Count"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Purple
        Me.Panel3.Controls.Add(Me.Ordcountlbl)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(814, 202)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(160, 100)
        Me.Panel3.TabIndex = 53
        '
        'Ordcountlbl
        '
        Me.Ordcountlbl.AutoSize = True
        Me.Ordcountlbl.BackColor = System.Drawing.Color.Purple
        Me.Ordcountlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ordcountlbl.ForeColor = System.Drawing.Color.White
        Me.Ordcountlbl.Location = New System.Drawing.Point(3, 64)
        Me.Ordcountlbl.Name = "Ordcountlbl"
        Me.Ordcountlbl.Size = New System.Drawing.Size(50, 21)
        Me.Ordcountlbl.TabIndex = 53
        Me.Ordcountlbl.Text = "Num"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Purple
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 21)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Order Count"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(427, 534)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.Purple
        Me.clearbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.clearbtn.Location = New System.Drawing.Point(475, 202)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(107, 36)
        Me.clearbtn.TabIndex = 51
        Me.clearbtn.Text = "CLEAR"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(423, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 21)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Customer List"
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(986, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customervb"
        CType(Me.CustomerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Product_TableTableAdapter As Sportmgkit.CategoryDataSetTableAdapters.Product_TableTableAdapter
    Friend WithEvents phonelbl As System.Windows.Forms.Label
    Friend WithEvents Custphonetxt As System.Windows.Forms.TextBox
    Friend WithEvents Custnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Customeridtxt As System.Windows.Forms.TextBox
    Friend WithEvents CustomerDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Searchbtn As System.Windows.Forms.Button
    Friend WithEvents CategoryDataSet As Sportmgkit.CategoryDataSet
    Friend WithEvents Deletebtn As System.Windows.Forms.Button
    Friend WithEvents AddCustbtn As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ProductTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents clearbtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Ordcountlbl As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CustCountlbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
