<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sellproducts
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sellproducts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.amountlbl = New System.Windows.Forms.Label()
        Me.prodnametxt = New System.Windows.Forms.TextBox()
        Me.prodnamelbl = New System.Windows.Forms.Label()
        Me.Custnametxt = New System.Windows.Forms.TextBox()
        Me.Custnamlbl = New System.Windows.Forms.Label()
        Me.quantityordertxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ProductidCB = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.OrderDGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.oidtxt = New System.Windows.Forms.TextBox()
        Me.BillDGV = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomeridCB = New System.Windows.Forms.ComboBox()
        Me.printbtn = New System.Windows.Forms.Button()
        Me.Addtobillbtn = New System.Windows.Forms.Button()
        Me.orderidlbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Datasetdatagrid = New Sportmgkit.Datasetdatagrid()
        Me.DatasetdatagridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Datasetdatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatasetdatagridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.amountlbl)
        Me.Panel1.Controls.Add(Me.prodnametxt)
        Me.Panel1.Controls.Add(Me.prodnamelbl)
        Me.Panel1.Controls.Add(Me.Custnametxt)
        Me.Panel1.Controls.Add(Me.Custnamlbl)
        Me.Panel1.Controls.Add(Me.quantityordertxt)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.ProductidCB)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.OrderDGV)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.oidtxt)
        Me.Panel1.Controls.Add(Me.BillDGV)
        Me.Panel1.Controls.Add(Me.CustomeridCB)
        Me.Panel1.Controls.Add(Me.printbtn)
        Me.Panel1.Controls.Add(Me.Addtobillbtn)
        Me.Panel1.Controls.Add(Me.orderidlbl)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 582)
        Me.Panel1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(457, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 36)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "HOME"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(553, 292)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Ksh"
        '
        'amountlbl
        '
        Me.amountlbl.AutoSize = True
        Me.amountlbl.BackColor = System.Drawing.Color.White
        Me.amountlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amountlbl.ForeColor = System.Drawing.Color.Purple
        Me.amountlbl.Location = New System.Drawing.Point(604, 292)
        Me.amountlbl.Name = "amountlbl"
        Me.amountlbl.Size = New System.Drawing.Size(78, 21)
        Me.amountlbl.TabIndex = 65
        Me.amountlbl.Text = "Amount"
        '
        'prodnametxt
        '
        Me.prodnametxt.Enabled = False
        Me.prodnametxt.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold)
        Me.prodnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.prodnametxt.Location = New System.Drawing.Point(140, 122)
        Me.prodnametxt.Name = "prodnametxt"
        Me.prodnametxt.Size = New System.Drawing.Size(218, 24)
        Me.prodnametxt.TabIndex = 64
        '
        'prodnamelbl
        '
        Me.prodnamelbl.AutoSize = True
        Me.prodnamelbl.BackColor = System.Drawing.Color.White
        Me.prodnamelbl.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prodnamelbl.ForeColor = System.Drawing.Color.Purple
        Me.prodnamelbl.Location = New System.Drawing.Point(2, 124)
        Me.prodnamelbl.Name = "prodnamelbl"
        Me.prodnamelbl.Size = New System.Drawing.Size(136, 17)
        Me.prodnamelbl.TabIndex = 63
        Me.prodnamelbl.Text = "PRODUCT NAME"
        '
        'Custnametxt
        '
        Me.Custnametxt.Enabled = False
        Me.Custnametxt.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Custnametxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Custnametxt.Location = New System.Drawing.Point(195, 232)
        Me.Custnametxt.Name = "Custnametxt"
        Me.Custnametxt.Size = New System.Drawing.Size(163, 24)
        Me.Custnametxt.TabIndex = 62
        '
        'Custnamlbl
        '
        Me.Custnamlbl.AutoSize = True
        Me.Custnamlbl.BackColor = System.Drawing.Color.White
        Me.Custnamlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Custnamlbl.ForeColor = System.Drawing.Color.Purple
        Me.Custnamlbl.Location = New System.Drawing.Point(3, 237)
        Me.Custnamlbl.Name = "Custnamlbl"
        Me.Custnamlbl.Size = New System.Drawing.Size(182, 21)
        Me.Custnamlbl.TabIndex = 61
        Me.Custnamlbl.Text = "CUSTOMER NAME"
        '
        'quantityordertxt
        '
        Me.quantityordertxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantityordertxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.quantityordertxt.Location = New System.Drawing.Point(124, 154)
        Me.quantityordertxt.Name = "quantityordertxt"
        Me.quantityordertxt.Size = New System.Drawing.Size(88, 26)
        Me.quantityordertxt.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Purple
        Me.Label6.Location = New System.Drawing.Point(3, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 21)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "QUANTITY"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Purple
        Me.Label3.Location = New System.Drawing.Point(3, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 21)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "PRODUCT ID"
        '
        'ProductidCB
        '
        Me.ProductidCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductidCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ProductidCB.FormattingEnabled = True
        Me.ProductidCB.Items.AddRange(New Object() {"Soccer", "Basketball", "Rugby", "Tennis"})
        Me.ProductidCB.Location = New System.Drawing.Point(141, 87)
        Me.ProductidCB.Name = "ProductidCB"
        Me.ProductidCB.Size = New System.Drawing.Size(95, 28)
        Me.ProductidCB.TabIndex = 55
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Purple
        Me.Label7.Location = New System.Drawing.Point(305, 357)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 21)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Inseted Bill"
        '
        'OrderDGV
        '
        Me.OrderDGV.BackgroundColor = System.Drawing.Color.White
        Me.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDGV.GridColor = System.Drawing.Color.Purple
        Me.OrderDGV.Location = New System.Drawing.Point(28, 381)
        Me.OrderDGV.Name = "OrderDGV"
        Me.OrderDGV.Size = New System.Drawing.Size(793, 158)
        Me.OrderDGV.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Purple
        Me.Label2.Location = New System.Drawing.Point(3, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 21)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "CUSTOMER ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Purple
        Me.Label4.Location = New System.Drawing.Point(636, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Bill"
        '
        'oidtxt
        '
        Me.oidtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oidtxt.ForeColor = System.Drawing.Color.DarkViolet
        Me.oidtxt.Location = New System.Drawing.Point(108, 55)
        Me.oidtxt.Name = "oidtxt"
        Me.oidtxt.Size = New System.Drawing.Size(125, 26)
        Me.oidtxt.TabIndex = 48
        '
        'BillDGV
        '
        Me.BillDGV.BackgroundColor = System.Drawing.Color.White
        Me.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BillDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.BillDGV.GridColor = System.Drawing.Color.Purple
        Me.BillDGV.Location = New System.Drawing.Point(433, 60)
        Me.BillDGV.Name = "BillDGV"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BillDGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BillDGV.Size = New System.Drawing.Size(549, 218)
        Me.BillDGV.TabIndex = 47
        '
        'Column1
        '
        Me.Column1.HeaderText = "Id"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Product"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        '
        'CustomeridCB
        '
        Me.CustomeridCB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomeridCB.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CustomeridCB.FormattingEnabled = True
        Me.CustomeridCB.Items.AddRange(New Object() {"Soccer", "Basketball", "Rugby", "Tennis"})
        Me.CustomeridCB.Location = New System.Drawing.Point(156, 198)
        Me.CustomeridCB.Name = "CustomeridCB"
        Me.CustomeridCB.Size = New System.Drawing.Size(93, 28)
        Me.CustomeridCB.TabIndex = 43
        '
        'printbtn
        '
        Me.printbtn.BackColor = System.Drawing.Color.Purple
        Me.printbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.printbtn.Location = New System.Drawing.Point(718, 284)
        Me.printbtn.Name = "printbtn"
        Me.printbtn.Size = New System.Drawing.Size(118, 36)
        Me.printbtn.TabIndex = 39
        Me.printbtn.Text = "PRINT"
        Me.printbtn.UseVisualStyleBackColor = False
        '
        'Addtobillbtn
        '
        Me.Addtobillbtn.BackColor = System.Drawing.Color.Purple
        Me.Addtobillbtn.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Addtobillbtn.Location = New System.Drawing.Point(0, 261)
        Me.Addtobillbtn.Name = "Addtobillbtn"
        Me.Addtobillbtn.Size = New System.Drawing.Size(212, 36)
        Me.Addtobillbtn.TabIndex = 38
        Me.Addtobillbtn.Text = "INSERT TO BILL"
        Me.Addtobillbtn.UseVisualStyleBackColor = False
        '
        'orderidlbl
        '
        Me.orderidlbl.AutoSize = True
        Me.orderidlbl.BackColor = System.Drawing.Color.White
        Me.orderidlbl.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.orderidlbl.ForeColor = System.Drawing.Color.Purple
        Me.orderidlbl.Location = New System.Drawing.Point(4, 55)
        Me.orderidlbl.Name = "orderidlbl"
        Me.orderidlbl.Size = New System.Drawing.Size(96, 21)
        Me.orderidlbl.TabIndex = 31
        Me.orderidlbl.Text = "ODER ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Purple
        Me.Label5.Location = New System.Drawing.Point(350, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 29)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "MANAGE ORDER"
        '
        'Datasetdatagrid
        '
        Me.Datasetdatagrid.DataSetName = "Datasetdatagrid"
        Me.Datasetdatagrid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatasetdatagridBindingSource
        '
        Me.DatasetdatagridBindingSource.DataSource = Me.Datasetdatagrid
        Me.DatasetdatagridBindingSource.Position = 0
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Sellproducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Purple
        Me.ClientSize = New System.Drawing.Size(986, 582)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Sellproducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sellprodcuts"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OrderDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BillDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Datasetdatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatasetdatagridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CustomeridCB As System.Windows.Forms.ComboBox
    Friend WithEvents printbtn As System.Windows.Forms.Button
    Friend WithEvents Addtobillbtn As System.Windows.Forms.Button
    Friend WithEvents orderidlbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DatasetdatagridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Datasetdatagrid As Sportmgkit.Datasetdatagrid
    Friend WithEvents oidtxt As System.Windows.Forms.TextBox
    Friend WithEvents BillDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents quantityordertxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProductidCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents OrderDGV As System.Windows.Forms.DataGridView
    Friend WithEvents Custnametxt As System.Windows.Forms.TextBox
    Friend WithEvents Custnamlbl As System.Windows.Forms.Label
    Friend WithEvents prodnametxt As System.Windows.Forms.TextBox
    Friend WithEvents prodnamelbl As System.Windows.Forms.Label
    Friend WithEvents amountlbl As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
