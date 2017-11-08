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
        Me.lblEnter = New System.Windows.Forms.Label()
        Me.lblFormatted = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.btnFix = New System.Windows.Forms.Button()
        Me.btnExponential = New System.Windows.Forms.Button()
        Me.btnCurrency = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnShortDate = New System.Windows.Forms.Button()
        Me.btnLongDate = New System.Windows.Forms.Button()
        Me.btnShortTime = New System.Windows.Forms.Button()
        Me.btnLongTime = New System.Windows.Forms.Button()
        Me.btnFullDateTime = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEnter
        '
        Me.lblEnter.AutoSize = True
        Me.lblEnter.Location = New System.Drawing.Point(40, 38)
        Me.lblEnter.Name = "lblEnter"
        Me.lblEnter.Size = New System.Drawing.Size(115, 13)
        Me.lblEnter.TabIndex = 0
        Me.lblEnter.Text = "Enter a number or date"
        '
        'lblFormatted
        '
        Me.lblFormatted.AutoSize = True
        Me.lblFormatted.Location = New System.Drawing.Point(40, 112)
        Me.lblFormatted.Name = "lblFormatted"
        Me.lblFormatted.Size = New System.Drawing.Size(54, 13)
        Me.lblFormatted.TabIndex = 1
        Me.lblFormatted.Text = "Formatted"
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(186, 101)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(191, 24)
        Me.lblResult.TabIndex = 2
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(186, 35)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnFullDateTime)
        Me.GroupBox1.Controls.Add(Me.btnLongTime)
        Me.GroupBox1.Controls.Add(Me.btnShortTime)
        Me.GroupBox1.Controls.Add(Me.btnLongDate)
        Me.GroupBox1.Controls.Add(Me.btnShortDate)
        Me.GroupBox1.Controls.Add(Me.btnPercent)
        Me.GroupBox1.Controls.Add(Me.btnCurrency)
        Me.GroupBox1.Controls.Add(Me.btnExponential)
        Me.GroupBox1.Controls.Add(Me.btnFix)
        Me.GroupBox1.Controls.Add(Me.btnNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 178)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 235)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select a Format"
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(24, 29)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(106, 23)
        Me.btnNumber.TabIndex = 0
        Me.btnNumber.Text = "Number Format (n)"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'btnFix
        '
        Me.btnFix.Location = New System.Drawing.Point(24, 68)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(121, 23)
        Me.btnFix.TabIndex = 1
        Me.btnFix.Text = "Fixed-point format (f)"
        Me.btnFix.UseVisualStyleBackColor = True
        '
        'btnExponential
        '
        Me.btnExponential.Location = New System.Drawing.Point(24, 114)
        Me.btnExponential.Name = "btnExponential"
        Me.btnExponential.Size = New System.Drawing.Size(121, 23)
        Me.btnExponential.TabIndex = 2
        Me.btnExponential.Text = "Exponential format (e)"
        Me.btnExponential.UseVisualStyleBackColor = True
        '
        'btnCurrency
        '
        Me.btnCurrency.Location = New System.Drawing.Point(24, 154)
        Me.btnCurrency.Name = "btnCurrency"
        Me.btnCurrency.Size = New System.Drawing.Size(106, 23)
        Me.btnCurrency.TabIndex = 3
        Me.btnCurrency.Text = "Currency format (c)"
        Me.btnCurrency.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Location = New System.Drawing.Point(24, 195)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(106, 23)
        Me.btnPercent.TabIndex = 4
        Me.btnPercent.Text = "Percent format (p)"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnShortDate
        '
        Me.btnShortDate.Location = New System.Drawing.Point(194, 29)
        Me.btnShortDate.Name = "btnShortDate"
        Me.btnShortDate.Size = New System.Drawing.Size(98, 23)
        Me.btnShortDate.TabIndex = 5
        Me.btnShortDate.Text = "Short Date (d)"
        Me.btnShortDate.UseVisualStyleBackColor = True
        '
        'btnLongDate
        '
        Me.btnLongDate.Location = New System.Drawing.Point(194, 68)
        Me.btnLongDate.Name = "btnLongDate"
        Me.btnLongDate.Size = New System.Drawing.Size(98, 23)
        Me.btnLongDate.TabIndex = 6
        Me.btnLongDate.Text = "Long Date (D)"
        Me.btnLongDate.UseVisualStyleBackColor = True
        '
        'btnShortTime
        '
        Me.btnShortTime.Location = New System.Drawing.Point(194, 114)
        Me.btnShortTime.Name = "btnShortTime"
        Me.btnShortTime.Size = New System.Drawing.Size(98, 23)
        Me.btnShortTime.TabIndex = 7
        Me.btnShortTime.Text = "Short Time (t)"
        Me.btnShortTime.UseVisualStyleBackColor = True
        '
        'btnLongTime
        '
        Me.btnLongTime.Location = New System.Drawing.Point(194, 154)
        Me.btnLongTime.Name = "btnLongTime"
        Me.btnLongTime.Size = New System.Drawing.Size(98, 23)
        Me.btnLongTime.TabIndex = 8
        Me.btnLongTime.Text = "Long Time (T)"
        Me.btnLongTime.UseVisualStyleBackColor = True
        '
        'btnFullDateTime
        '
        Me.btnFullDateTime.Location = New System.Drawing.Point(194, 195)
        Me.btnFullDateTime.Name = "btnFullDateTime"
        Me.btnFullDateTime.Size = New System.Drawing.Size(98, 23)
        Me.btnFullDateTime.TabIndex = 9
        Me.btnFullDateTime.Text = "Full date/time (F)"
        Me.btnFullDateTime.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 425)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFormatted)
        Me.Controls.Add(Me.lblEnter)
        Me.Name = "Form1"
        Me.Text = "Format Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblEnter As System.Windows.Forms.Label
    Friend WithEvents lblFormatted As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFullDateTime As System.Windows.Forms.Button
    Friend WithEvents btnLongTime As System.Windows.Forms.Button
    Friend WithEvents btnShortTime As System.Windows.Forms.Button
    Friend WithEvents btnLongDate As System.Windows.Forms.Button
    Friend WithEvents btnShortDate As System.Windows.Forms.Button
    Friend WithEvents btnPercent As System.Windows.Forms.Button
    Friend WithEvents btnCurrency As System.Windows.Forms.Button
    Friend WithEvents btnExponential As System.Windows.Forms.Button
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents btnNumber As System.Windows.Forms.Button

End Class
