Imports System.Data.SqlClient
Public Class Sellproducts
    Dim Con As New SqlConnection("Data Source=WINDOWS-CT800DV;Initial Catalog=ProgrammingDB;Integrated Security=True")

    Private Sub Fillproduct()
        Con.Open()
        Dim command As New SqlCommand("select * from Product_Table", Con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        ProductidCB.DataSource = dt
        ProductidCB.DisplayMember = "Product_ID"
        ProductidCB.ValueMember = "Product_ID"
        Con.Close()
    End Sub
    Private Sub Fillcustomer()
        Con.Open()
        Dim command As New SqlCommand("select * from Customer_Table", Con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        CustomeridCB.DataSource = dt
        CustomeridCB.DisplayMember = "Customer_ID"
        CustomeridCB.ValueMember = "Customer_ID"
        Con.Close()
    End Sub
    Private Sub FetchName()
        Con.Open()
        Dim query = "select * from Customer_Table where Customer_ID =" & CustomeridCB.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            Custnametxt.Text = reader(1).ToString()
        End While
        Con.Close()
    End Sub
    Dim prodname As String
    Dim prodprice As Integer
    Dim AvailprodQty As Integer
    Private Sub FetchData()
        Con.Open()
        Dim query = "select * from Product_Table where Product_ID =" & ProductidCB.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(query, Con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader()
        While reader.Read
            'Custnametxt.Text = reader(1).ToString()
            prodname = reader(1).ToString()
            AvailprodQty = Convert.ToInt32(reader(2).ToString())
            prodprice = Convert.ToUInt32(reader(3).ToString())
            prodnametxt.Text = prodname
        End While
        Con.Close()
    End Sub

    Private Sub Sellproducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fillproduct()
        Fillcustomer()
        Populate()
    End Sub
    Dim newQty
    Private Sub Updateprod()
        newQty = AvailprodQty - Convert.ToInt32(quantityordertxt.Text)
        Con.Open()
        Dim sql = "update Product_Table set ProductQuantity='" & newQty & "' where Product_ID = " & ProductidCB.SelectedItem.ToString() & ""
        Dim cmd As New SqlCommand(sql, Con)
        cmd.ExecuteNonQuery()
        Con.Close()
        ' Populate()
    End Sub
    Dim Grtot = 0, i = 0, Total = 0
    Public Sub Populate()
        Con.Open()
        Dim sql = "select * from Order_Table"
        Dim adapter As New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        OrderDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Addtobillbtn_Click(sender As Object, e As EventArgs) Handles Addtobillbtn.Click
        If quantityordertxt.Text = "" Then
            MsgBox("Enter The Product Quantity")
        Else
            Dim rnum As Integer = BillDGV.Rows.Add()
            i = i + 1
            Total = prodprice * Convert.ToInt32(quantityordertxt.Text)
            BillDGV.Rows.Item(rnum).Cells("Column1").Value = i
            BillDGV.Rows.Item(rnum).Cells("Column2").Value = prodnametxt.Text
            BillDGV.Rows.Item(rnum).Cells("Column3").Value = prodprice
            BillDGV.Rows.Item(rnum).Cells("Column4").Value = quantityordertxt.Text
            BillDGV.Rows.Item(rnum).Cells("Column5").Value = Total
            Grtot = Grtot + Total
            amountlbl.Text = Grtot
        End If
        


    End Sub
   
    Private Sub BillDataGrid_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)

    End Sub

    Private Sub CustomeridCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustomeridCB.SelectionChangeCommitted
        FetchName()
    End Sub

    Private Sub ProductidCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles ProductidCB.SelectionChangeCommitted
        FetchData()
    End Sub
    Private Sub InsertOrder()
        If Custnametxt.Text = "" Then
            MsgBox("Select Customer Name")
        Else
            Con.Open()
            Dim command As New SqlCommand("Insert into Order_Table Values ('" & oidtxt.Text & "', '" & CustomeridCB.SelectedValue.ToString() & "','" & Custnametxt.Text & "','" & amountlbl.Text & "')", Con)
            command.ExecuteNonQuery()
            MsgBox("Order Added Successfully")
            Con.Close()
            Populate()

        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.BillDGV.Width, Me.BillDGV.Height)
        BillDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.BillDGV.Width, Me.BillDGV.Height))
        e.Graphics.DrawImage(bm, 110, 130)
        e.Graphics.DrawString("**********SPORTS KIT MANAGEMENT SYSTEM**********", New Font("Century Gothic", 14), Brushes.BlueViolet, 200, 20)
        e.Graphics.DrawImage(bm, 150, 130)
        e.Graphics.DrawString("**********YOUR ORDER**********", New Font("Century Gothic", 8), Brushes.BlueViolet, 100, 10)
        e.Graphics.DrawImage(bm, 200, 130)
        e.Graphics.DrawString("**********THANK YOU VERY MUCH FOR YOUR PURCHASE**********", New Font("Century Gothic", 10), Brushes.BlueViolet, 250, 80)
        InsertOrder()
    End Sub

    Private Sub printbtn_Click(sender As Object, e As EventArgs) Handles printbtn.Click
        PrintPreviewDialog1.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class