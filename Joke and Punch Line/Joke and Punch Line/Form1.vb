Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblAnswer.Text = "How many programmers does it take to change a lightbulb?"
    End Sub

    Private Sub btnPunchline_Click(sender As Object, e As EventArgs) Handles btnPunchline.Click
        lblAnswer.Text = "None. That's a hardware problem."
    End Sub

    Private Sub lblAnswer_Click(sender As Object, e As EventArgs) Handles lblAnswer.Click

    End Sub
End Class
