<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDayofWeek = New System.Windows.Forms.TextBox()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.txtDayofMonth = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.lblDayofWeek = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblDayoftheMonth = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblDateString = New System.Windows.Forms.Label()
        Me.btnShowDate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtDayofWeek
        '
        Me.txtDayofWeek.Location = New System.Drawing.Point(43, 27)
        Me.txtDayofWeek.Name = "txtDayofWeek"
        Me.txtDayofWeek.Size = New System.Drawing.Size(100, 20)
        Me.txtDayofWeek.TabIndex = 0
        '
        'txtMonth
        '
        Me.txtMonth.Location = New System.Drawing.Point(43, 53)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtMonth.TabIndex = 1
        '
        'txtDayofMonth
        '
        Me.txtDayofMonth.Location = New System.Drawing.Point(43, 79)
        Me.txtDayofMonth.Name = "txtDayofMonth"
        Me.txtDayofMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtDayofMonth.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(43, 105)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 3
        '
        'lblDayofWeek
        '
        Me.lblDayofWeek.AutoSize = True
        Me.lblDayofWeek.Location = New System.Drawing.Point(185, 27)
        Me.lblDayofWeek.Name = "lblDayofWeek"
        Me.lblDayofWeek.Size = New System.Drawing.Size(129, 13)
        Me.lblDayofWeek.TabIndex = 4
        Me.lblDayofWeek.Text = "Enter the day of the week"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(185, 53)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(82, 13)
        Me.lblMonth.TabIndex = 5
        Me.lblMonth.Text = "Enter the month"
        '
        'lblDayoftheMonth
        '
        Me.lblDayoftheMonth.AutoSize = True
        Me.lblDayoftheMonth.Location = New System.Drawing.Point(185, 79)
        Me.lblDayoftheMonth.Name = "lblDayoftheMonth"
        Me.lblDayoftheMonth.Size = New System.Drawing.Size(132, 13)
        Me.lblDayoftheMonth.TabIndex = 6
        Me.lblDayoftheMonth.Text = "Enter the day of the month"
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(185, 105)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(73, 13)
        Me.lblYear.TabIndex = 7
        Me.lblYear.Text = "Enter the year"
        '
        'lblDateString
        '
        Me.lblDateString.Location = New System.Drawing.Point(185, 168)
        Me.lblDateString.Name = "lblDateString"
        Me.lblDateString.Size = New System.Drawing.Size(39, 13)
        Me.lblDateString.TabIndex = 8
        '
        'btnShowDate
        '
        Me.btnShowDate.Location = New System.Drawing.Point(31, 199)
        Me.btnShowDate.Name = "btnShowDate"
        Me.btnShowDate.Size = New System.Drawing.Size(75, 20)
        Me.btnShowDate.TabIndex = 9
        Me.btnShowDate.Text = "Show Date"
        Me.btnShowDate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(138, 199)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 20)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(242, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 20)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(54, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 29)
        Me.Label5.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(335, 262)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowDate)
        Me.Controls.Add(Me.lblDateString)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblDayoftheMonth)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.lblDayofWeek)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtDayofMonth)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtDayofWeek)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDayofWeek As System.Windows.Forms.TextBox
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtDayofMonth As System.Windows.Forms.TextBox
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents lblDayofWeek As System.Windows.Forms.Label
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblDayoftheMonth As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblDateString As System.Windows.Forms.Label
    Friend WithEvents btnShowDate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
