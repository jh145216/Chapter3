Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculateRevenue_Click(sender As Object, e As EventArgs) Handles btnCalculateRevenue.Click
        Dim decClassA As Decimal
        Dim decClassB As Decimal
        Dim decClassC As Decimal
        Dim decTotalRevenue As Decimal

        Try
            decClassA = (txtClassA.Text) * 15
            decClassB = (txtClassB.Text) * 12
            decClassC = (txtClassC.Text) * 9
            decTotalRevenue = (decClassA) + (decClassB) + (decClassC)

            lblClassA.Text = decClassA.ToString("c")
            lblClassB.Text = decClassB.ToString("c")
            lblClassC.Text = decClassC.ToString("c")

            lblTotalRevenue.Text = decTotalRevenue.ToString("c")
        Catch
            lblError.Text = "All inputs must be vaild numeric values"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblError.Text = String.Empty
        txtClassA.Clear()
        txtClassB.Clear()
        txtClassC.Clear()
        lblClassA.Text = String.Empty
        lblClassB.Text = String.Empty
        lblClassC.Text = String.Empty
        lblError.Text = String.Empty
        lblTotalRevenue.Text = String.Empty
    End Sub
End Class
