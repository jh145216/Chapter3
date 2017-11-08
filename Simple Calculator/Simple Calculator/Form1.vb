Public Class Form1



    Private Sub btbPlus_Click(sender As Object, e As EventArgs) Handles btbPlus.Click
        'This event hardler performs addition
        'Declare a variable to hold the result
        Dim dblResult As Double

        lblOperation.Text = " + "

        dblResult = CDbl(txtNumber1.Text) + CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        'This event hardler performs subtraction
        Dim dblResult As Double

        lblOperation.Text = " - "

        dblResult = CDbl(txtNumber1.Text) - CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnMutlitply_Click(sender As Object, e As EventArgs) Handles btnMutlitply.Click
        'This event hardler performs multiplication
        Dim dblResult As Double

        lblOperation.Text = " * "

        dblResult = CDbl(txtNumber1.Text) * CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        'This event hardler performs division
        Dim dblResult As Double

        lblOperation.Text = " / "

        dblResult = CDbl(txtNumber1.Text) / CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnExponant_Click(sender As Object, e As EventArgs) Handles btnExponant.Click
        'This event hardler performs exponentiation
        Dim dblResult As Double

        lblOperation.Text = " ^ "

        dblResult = CDbl(txtNumber1.Text) ^ CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnModuls_Click(sender As Object, e As EventArgs) Handles btnModuls.Click
        'This event hardler performs modulus
        Dim dblResult As Double

        lblOperation.Text = " MOD "

        dblResult = CDbl(txtNumber1.Text) Mod CDbl(txtNumber2.Text)

        lblResult.Text = CStr(dblResult)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumber1.Clear()
        txtNumber2.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
