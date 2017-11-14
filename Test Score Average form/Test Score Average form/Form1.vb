Public Class Form1

    Private Sub btnClaculateAverage_Click(sender As Object, e As EventArgs) Handles btnClaculateAverage.Click
        Dim decAverage As Decimal
        Dim decTotal As Decimal

        Try
            decTotal = CDec(txtTestScore1.Text) + CDec(txtTestScore2.Text) + CDec(txtTestScore3.Text) +
                (txtTestScore4.Text) + (txtTestScore5.Text)
            decAverage = (decTotal) / 5
            lblAverage.Text = decAverage.ToString("n")
        Catch
            lblError.Text = " Error all input numbers must be numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblError.Text = String.Empty
        txtTestScore1.Clear()
        txtTestScore2.Clear()
        txtTestScore3.Clear()
        txtTestScore4.Clear()
        txtTestScore5.Clear()
        lblAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
