Public Class Form1

    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        Dim decGallonhold As Decimal
        Try
            decGallonhold = (txtMiles.Text) / (txtGallons.Text)
            lblMilesPerGallon.Text = decGallonhold.ToString("n2")
        Catch
            lblError.Text = "Error be sure to enter non zero numeric values "
        End Try
       
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblError.Text = String.Empty
        txtGallons.Clear()
        txtMiles.Clear()
        lblMilesPerGallon.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
