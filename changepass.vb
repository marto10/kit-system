Imports System.Data.OleDb
Imports System.Data


Public Class changepass

    ReadOnly con As New OleDbConnection(My.Settings.dbstring)
    Dim flag As Integer = 0
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Register.Show()
    End Sub

    Private Sub changepass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mobtxt.Clear()
        passtxt1.Clear()
        unametxt1.Clear()
        unametxt1.Visible = True
        passtxt1.Visible = True
    End Sub

    Private Sub changebtn_Click(sender As Object, e As EventArgs) Handles changebtn.Click
        If unametxt1.Text = Nothing Or passtxt1.Text = Nothing Then
            MessageBox.Show("Please enter empty details !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If mobtxt.Text.Length < 10 Then
            MessageBox.Show("Invalid mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\database + code\Database1.mdb;")
        ' C:\Users\User\Documents\Visual Studio 2012\Projects\Sportmgkit\Sportmgkit
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        If flag = 0 Then



            Using Command As New OleDbCommand("SELECT COUNT(*) FROM Table1 WHERE [mobile] = @mobile", con)
                Command.Parameters.AddWithValue("@mobile", OleDbType.VarChar).Value = mobtxt.Text.Trim

                Dim count = Convert.ToInt32(Command.ExecuteScalar())

                If count > 0 Then
                    mobtxt.Enabled = False
                    unametxt1.Visible = True
                    passtxt1.Visible = True
                    unametxt1.Enabled = False
                    passtxt1.Enabled = False

                    flag = 1
                    Exit Sub
                Else
                    MessageBox.Show("Oops !!, Invalid Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            End Using
        End If
        If flag = 1 Then
            If unametxt1.Text = Nothing Or passtxt1.Text = Nothing Then
                MessageBox.Show("Please enter empty details !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using create As New OleDbCommand("UPDATE Table1 SET [uname]=@name,[pass]=@pass WHERE [mobile]=@mobile", con)


                create.Parameters.AddWithValue("@uname", OleDbType.VarChar).Value = unametxt1.Text.Trim
                create.Parameters.AddWithValue("@pass", OleDbType.VarChar).Value = passtxt1.Text.Trim
                create.Parameters.AddWithValue("@mobile", OleDbType.VarChar).Value = mobtxt.Text.Trim

                If create.ExecuteNonQuery Then
                    MessageBox.Show("Account Updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                    FORM_USER.Show()
                    flag = 0
                Else
                    MsgBox("Update Error.")
                End If
            End Using
        End If
        con.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Login.Show()
    End Sub

    Private Sub unametxt1_TextChanged(sender As Object, e As EventArgs) Handles unametxt1.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class