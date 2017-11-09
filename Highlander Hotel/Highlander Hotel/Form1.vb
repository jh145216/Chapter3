
Private Sub btnExit_Click(sender As Object, e As EventArgs)
    ' Close the form.
    Me.Close()
End Sub
Private Sub btnClear_Click(sender As Object, e As EventArgs)
    ' Clear the room info fields.
    txtNights.Clear()
    txtNightlyCharge.Clear()

    ' Clear the additional charges fields.
    txtRoomService.Clear()
    txtTelephone.Clear()
    txtMisc.Clear()

    ' Clear the decTotal fields.
    lblRoomCharges.Clear()
    lblAddCharges.Clear()
    lblSubtotal.Clear()
    lblTax.Text = String.Empty
    lblTotal.Text = String.Empty

    ' Get today's date from the operating system anf display it.
    lblDateToday.Text = Now.ToString("D")

    ' Get the current time from the operating system and display it.
    lblTimeToday.Text = Now.ToString("T")

    ' Reset the focus to the first field.
    txtNights.Focus()
End Sub

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare variables for the calculations.
        Dim decRoomCharges As Decimal     ' Room charges total
        Dim decAddCharges As Decimal      ' Additional charges
        Dim decSubtotal As Decimal        ' Subtotal
        Dim decTax As Decimal             ' Tax
        Dim decTotal As Decimal           ' Total of all charges
        Const decTAX_RATE As Decimal      ' Tax rate

        Try
            ' Calculate and display the room charges.
            decRoomCharges = CDec(txtNights.Text) *
                             CDec(txtNightlyCharges.Text)
            lblRoomCharges.Text = decRoomCharges.ToString("c")

            ' Calculate and display the additional charges.
            decAddCharges = CDec(txtRoomService.Text) +
                            CDec(txtTelephone.Text) +
                            CDec(txtMisc.Text)
            lblAddCharges.Text = decAddCharges.ToString("c")

            ' Calculate and display the subtotal.
            decSubtotal = decRoomCharges + decAddCharges
            lblSubtotal.Text = decSubtotal.ToString("c")

            ' Calculate and display the total charges.
            decTotal = decSubtotal + decTax
            lblTotal.Text = decTotal.ToString("c")

            ' Change the colors for the total charges.
            lblTotal.BackColor = Color.Blue
            lblTotal.BackColor = Color.White
        Catch
            ' Error message
            MessageBox.Show("All input must be vaild numeric values.")
        End Try
    End Sub
