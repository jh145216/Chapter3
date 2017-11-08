Public Class Form1

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtInput.Text)

        strResult = dblAnswer.ToString("n")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFix_Click(sender As Object, e As EventArgs) Handles btnFix.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtInput.Text)

        strResult = dblAnswer.ToString("f")
        lblResult.Text = strResult
    End Sub

    Private Sub btnExponential_Click(sender As Object, e As EventArgs) Handles btnExponential.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtInput.Text)

        strResult = dblAnswer.ToString("e")
        lblResult.Text = strResult
    End Sub

    Private Sub btnCurrency_Click(sender As Object, e As EventArgs) Handles btnCurrency.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtInput.Text)

        strResult = dblAnswer.ToString("c")
        lblResult.Text = strResult
    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        Dim dblAnswer As Double
        Dim strResult As String

        dblAnswer = CDbl(txtInput.Text)

        strResult = dblAnswer.ToString("p")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortDate_Click(sender As Object, e As EventArgs) Handles btnShortDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtInput.Text)

        strResult = Answer.ToString("d")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongDate_Click(sender As Object, e As EventArgs) Handles btnLongDate.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtInput.Text)

        strResult = Answer.ToString("D")
        lblResult.Text = strResult
    End Sub

    Private Sub btnShortTime_Click(sender As Object, e As EventArgs) Handles btnShortTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtInput.Text)

        strResult = Answer.ToString("t")
        lblResult.Text = strResult
    End Sub

    Private Sub btnLongTime_Click(sender As Object, e As EventArgs) Handles btnLongTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtInput.Text)

        strResult = Answer.ToString("T")
        lblResult.Text = strResult
    End Sub

    Private Sub btnFullDateTime_Click(sender As Object, e As EventArgs) Handles btnFullDateTime.Click
        Dim Answer As Date
        Dim strResult As String

        Answer = CDate(txtInput.Text)

        strResult = Answer.ToString("F")
        lblResult.Text = strResult
    End Sub
End Class
