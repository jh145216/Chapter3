Public Class lblStatus

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decAnnualSalary As Decimal  ' Annual salary
        Dim intPayPeriods As Integer    ' Number of pay periods
        Dim decSalary As Decimal        'Salary per pay period

        ' Get the annual salary and number of pay periods.
        decAnnualSalary = CDec(txtAnnualSalary.Text)
        intPayPeriods = CInt(txtPayPeriods.Text)

        ' Calculate the salary per pay period.
        decSalary = decAnnualSalary / intPayPeriods

        ' Display the salary per pay period.
        lblSalary.Text = decSalary.ToString("c")
    End Sub
End Class
