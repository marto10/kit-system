Imports System.Data.OleDb
Imports System.Data

Public Class Login
    ReadOnly con As New OleDbConnection(My.Settings.dbstring)

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Tusername_TextChanged(sender As Object, e As EventArgs) Handles unametxt1.TextChanged

    End Sub

    Private Sub Tpassword_TextChanged(sender As Object, e As EventArgs) Handles passtxt1.TextChanged

    End Sub

    Private Sub BTlogin_Click(sender As Object, e As EventArgs) Handles BTlogin.Click
        If unametxt1.Text = Nothing Or passtxt1.Text = Nothing Then
            MessageBox.Show("Enter username or password you type !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Exit Sub
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\database + code\Database1.mdb;")
        ' C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\Sportmgkit
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using Command As New OleDbCommand("SELECT COUNT(*) FROM Table1 WHERE [uname] = @uname AND [pass] = @pass", con)
            Command.Parameters.AddWithValue("@uname", OleDbType.VarChar).Value = unametxt1.Text.Trim
            Command.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = passtxt1.Text.Trim

            Dim count = Convert.ToInt32(Command.ExecuteScalar())


            If count > 0 Then
                Me.Hide()
                Home.Show()
            Else
                MessageBox.Show("Oops !!, Invalid Credentials", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LinkLabel2.Visible = True

            End If
        End Using
        con.Close()
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim response As Integer
        response = MessageBox.Show("Are you sure you wish to quit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = vbYes Then
            Application.Exit()
        End If
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.BackColor = Color.Red()
        Label1.ForeColor = Color.White()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave
        Label1.BackColor = Color.Purple()
        Label1.BackColor = Color.White()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Register.ShowDialog()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Hide()
        changepass.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class


