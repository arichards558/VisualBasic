Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        lblAddress.Text = "Waynesville, NC 28786"
        lblName.Text = "William Wolfe"
        lblStreetZip.Text = "888 South Main Street"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
