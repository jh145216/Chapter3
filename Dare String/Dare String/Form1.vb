﻿Public Class Form1

    Private Sub btnShowDate_Click(sender As Object, e As EventArgs) Handles btnShowDate.Click
        lblDateString.Text = txtDayofWeek.Text & ", " & txtMonth.Text & 
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDayofMonth.Clear()
        txtDayofWeek.Clear()
        txtMonth.Clear()
        txtYear.Clear()



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
