Public Class progbar

    Private Sub T1_Tick(sender As Object, e As EventArgs) Handles T1.Tick
        Prog.Value += 1
        Prog.Text = Prog.Value.ToString

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If
        If Prog.Value = 100 Then
            T1.Stop()
            T2.Start()
        End If

        If Me.Prog.Value = 10 Then
            Me.Text = "Loading Form..."
        ElseIf Me.Prog.Value = 20 Then
            Me.Text = "Preparing Database..."
        ElseIf Me.Prog.Value = 50 Then
            Me.Text = "Ready..."
        ElseIf Me.Prog.Value = 20 Then
            Me.Text = "Launching Main Form..."

        End If
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        Prog.Value = 0
        Me.Opacity = 0
        T1.Start()
    End Sub

    Private Sub T2_Tick(sender As Object, e As EventArgs) Handles T2.Tick
        T2.Stop()
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class