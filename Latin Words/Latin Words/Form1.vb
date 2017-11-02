Public Class Form1

    Private Sub btnSinister_Click(sender As Object, e As EventArgs) Handles btnSinister.Click
        lblLeft.Text = "Left"
    End Sub

    Private Sub lblRight_Click(sender As Object, e As EventArgs) Handles lblRight.Click

    End Sub

    Private Sub btnDexter_Click(sender As Object, e As EventArgs) Handles btnDexter.Click
        lblRight.Text = "Right"
    End Sub

    Private Sub btnMedium_Click(sender As Object, e As EventArgs) Handles btnMedium.Click
        lblCenter.Text = "Center"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
