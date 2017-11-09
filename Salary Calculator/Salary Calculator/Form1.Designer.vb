<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lblStatus
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
        Me.lblAnnualSalary = New System.Windows.Forms.Label()
        Me.lblPayPeriodsPerYear = New System.Windows.Forms.Label()
        Me.lblSalaryPerPayDay = New System.Windows.Forms.Label()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtAnnualSalary = New System.Windows.Forms.TextBox()
        Me.txtPayPeriods = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblStatus1 = New System.Windows.Forms.StatusStrip()
        Me.SuspendLayout()
        '
        'lblAnnualSalary
        '
        Me.lblAnnualSalary.AutoSize = True
        Me.lblAnnualSalary.Location = New System.Drawing.Point(69, 24)
        Me.lblAnnualSalary.Name = "lblAnnualSalary"
        Me.lblAnnualSalary.Size = New System.Drawing.Size(70, 13)
        Me.lblAnnualSalary.TabIndex = 0
        Me.lblAnnualSalary.Text = "Annual salary"
        '
        'lblPayPeriodsPerYear
        '
        Me.lblPayPeriodsPerYear.AutoSize = True
        Me.lblPayPeriodsPerYear.Location = New System.Drawing.Point(36, 72)
        Me.lblPayPeriodsPerYear.Name = "lblPayPeriodsPerYear"
        Me.lblPayPeriodsPerYear.Size = New System.Drawing.Size(103, 13)
        Me.lblPayPeriodsPerYear.TabIndex = 1
        Me.lblPayPeriodsPerYear.Text = "Pay periods per year"
        '
        'lblSalaryPerPayDay
        '
        Me.lblSalaryPerPayDay.AutoSize = True
        Me.lblSalaryPerPayDay.Location = New System.Drawing.Point(45, 116)
        Me.lblSalaryPerPayDay.Name = "lblSalaryPerPayDay"
        Me.lblSalaryPerPayDay.Size = New System.Drawing.Size(94, 13)
        Me.lblSalaryPerPayDay.TabIndex = 2
        Me.lblSalaryPerPayDay.Text = "Salary per pay day"
        '
        'lblSalary
        '
        Me.lblSalary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSalary.Location = New System.Drawing.Point(211, 100)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(150, 29)
        Me.lblSalary.TabIndex = 3
        '
        'txtAnnualSalary
        '
        Me.txtAnnualSalary.Location = New System.Drawing.Point(211, 24)
        Me.txtAnnualSalary.Name = "txtAnnualSalary"
        Me.txtAnnualSalary.Size = New System.Drawing.Size(150, 20)
        Me.txtAnnualSalary.TabIndex = 4
        '
        'txtPayPeriods
        '
        Me.txtPayPeriods.Location = New System.Drawing.Point(211, 65)
        Me.txtPayPeriods.Name = "txtPayPeriods"
        Me.txtPayPeriods.Size = New System.Drawing.Size(150, 20)
        Me.txtPayPeriods.TabIndex = 5
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(140, 158)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(106, 37)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblStatus1
        '
        Me.lblStatus1.Location = New System.Drawing.Point(0, 208)
        Me.lblStatus1.Name = "lblStatus1"
        Me.lblStatus1.Size = New System.Drawing.Size(397, 22)
        Me.lblStatus1.TabIndex = 7
        Me.lblStatus1.Text = "StatusStrip1"
        '
        'lblStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 230)
        Me.Controls.Add(Me.lblStatus1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtPayPeriods)
        Me.Controls.Add(Me.txtAnnualSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.lblSalaryPerPayDay)
        Me.Controls.Add(Me.lblPayPeriodsPerYear)
        Me.Controls.Add(Me.lblAnnualSalary)
        Me.Name = "lblStatus"
        Me.Text = "Salary Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAnnualSalary As System.Windows.Forms.Label
    Friend WithEvents lblPayPeriodsPerYear As System.Windows.Forms.Label
    Friend WithEvents lblSalaryPerPayDay As System.Windows.Forms.Label
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtAnnualSalary As System.Windows.Forms.TextBox
    Friend WithEvents txtPayPeriods As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblStatus1 As System.Windows.Forms.StatusStrip

End Class
