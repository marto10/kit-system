Imports System.Data.OleDb
Imports System.Data

Public Class Register
    ReadOnly con As New OleDbConnection(My.Settings.dbstring)
    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs)
  
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Login.Show()
        Me.Hide()
    End Sub


    Private Sub Registerbtn_Click(sender As Object, e As EventArgs) Handles Registerbtn.Click
        If unametxt1.Text = Nothing Or passtxt1.Text = Nothing Or mobtxt.Text = Nothing Then
            MessageBox.Show("Please enter empty details !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If mobtxt.Text.Length < 10 Then
            MessageBox.Show("Ivalid Mobile Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\database + code\Database1.mdb;")
        ' C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\Sportmgkit
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If


        Using Command As New OleDbCommand("SELECT COUNT(*) FROM Table1 WHERE [mobile] = @mobile", con)
            Command.Parameters.AddWithValue("@mobile", OleDbType.VarChar).Value = mobtxt.Text.Trim

            Dim count = Convert.ToInt32(Command.ExecuteScalar())

            If count > 0 Then
                MessageBox.Show("Oops !!, Preregistered Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        End Using

        Using create As New OleDbCommand("INSERT INTO Table1 (uname,pass,mobile,Gender) VALUES (@name, @pass, @mobile, @Gender)", con)

            create.Parameters.AddWithValue("@uname", OleDbType.VarChar).Value = unametxt1.Text.Trim
            create.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = passtxt1.Text.Trim
            create.Parameters.AddWithValue("@mobile", OleDbType.VarChar).Value = mobtxt.Text.Trim
            create.Parameters.AddWithValue("@Gender", OleDbType.VarChar).Value = ComboGender.Text.Trim

            If create.ExecuteNonQuery Then
                MessageBox.Show("Account Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                Login.Show()
            Else
                MsgBox("Registration Error.")
            End If
        End Using
        con.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       unametxt1.Clear()
        passtxt1.Clear()
        mobtxt.Clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboGender.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim home = New Login
        home.Show()
    End Sub
End Class