Imports System.Data.SqlClient
Public Class Customer
    Dim Con As New SqlConnection("Data Source=WINDOWS-CT800DV;Initial Catalog=ProgrammingDB;Integrated Security=True")
    Public Sub Populate()
        Con.Open()
        Dim sql = "select * from Customer_Table"
        Dim adapter As New SqlDataAdapter
        adapter = New SqlDataAdapter(sql, Con)
        Dim builder As SqlCommandBuilder
        builder = New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        CustomerDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Addbtn_Click(sender As Object, e As EventArgs) Handles AddCustbtn.Click
        Con.Open()
        Dim cid As Integer = Customeridtxt.Text
        Dim cname As String = Custnametxt.Text
        Dim cphone As Integer = Custphonetxt.Text
        Dim command As New SqlCommand("Insert into Customer_Table Values ('" & cid & "','" & cname & "','" & cphone & "')", Con)
        command.ExecuteNonQuery()
        MsgBox("Customer Added Successfully")
        Con.Close()
        Populate()
    End Sub

    Private Sub Customervb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
        Dim query = "Select Count (*) from Customer_Table"
        Dim query1 = "Select Count (*) from Order_Table"
        Dim cmd As SqlCommand
        Dim cmd1 As SqlCommand
        Con.Open()
        cmd = New SqlCommand(query, Con)
        Dim count As Int16 = Convert.ToInt16(cmd.ExecuteScalar())
        CustCountlbl.Text = count.ToString()
        cmd1 = New SqlCommand(query1, Con)
        Dim count1 As Int16 = Convert.ToInt16(cmd1.ExecuteScalar())
        Ordcountlbl.Text = count1.ToString()
        Con.Close()
    End Sub

    Private Sub Deletebtn_Click(sender As Object, e As EventArgs) Handles Deletebtn.Click
        If Customeridtxt.Text = "" Then
            MsgBox("Enter the Customer id to be Deleted")
        Else
            Con.Open()
            Dim query As String
            query = "delete from Customer_Table where Customer_ID =" & Customeridtxt.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Customer Deleted Successfully")
            Con.Close()
            Populate()
        End If
    End Sub

    Private Sub Searchbtn_Click(sender As Object, e As EventArgs) Handles Searchbtn.Click
        Dim cid As Integer = Customeridtxt.Text
        Dim command As New SqlCommand("select * from Customer_Table where Customer_ID ='" & cid & "'", Con)
        Dim sda As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sda.Fill(dt)
        CustomerDGV.DataSource = dt
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        Customeridtxt.Text = ""
        Custnametxt.Text = ""
        Custphonetxt.Text = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Home
        home.Show()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class