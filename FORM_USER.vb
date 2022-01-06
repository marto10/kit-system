Public Class FORM_USER

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + Login.unametxt1.Text




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Const Soccerball As Integer = 1500
        Const Rugbyball As Integer = 4000
        Const Tennisball As Integer = 1500
        Const Basketball As Integer = 2999
        Const Soccerkits As Integer = 1300
        Const Rugbykits As Integer = 3000
        Const Tenniskits As Integer = 1700
        Const Basketballkits As Integer = 1200

        Dim sum As Integer
        If CheckBox1.Checked = True Then
            sum = sum + Soccerball
        End If
        If CheckBox2.Checked = True Then
            sum = sum + Rugbyball
        End If
        If CheckBox3.Checked = True Then
            sum = sum + Tennisball
        End If
        If CheckBox4.Checked = True Then
            sum = sum + Basketball
        End If
        If CheckBox5.Checked = True Then
            sum = sum + Soccerkits
        End If
        If CheckBox6.Checked = True Then
            sum = sum + Rugbykits
        End If
        If CheckBox7.Checked = True Then
            sum = sum + Tenniskits
        End If
        If CheckBox8.Checked = True Then
            sum = sum + Basketballkits
        End If

        totaltxt.Text = sum.ToString("ksh.")
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class