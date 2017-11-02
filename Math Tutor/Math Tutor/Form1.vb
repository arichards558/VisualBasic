Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAnswer_Click(sender As Object, e As EventArgs) Handles btnAnswer.Click
        lblEquation.Text = "18 + 64 = 82"
    End Sub
End Class
