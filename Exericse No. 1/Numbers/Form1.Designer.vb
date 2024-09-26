<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblNumber = New Label()
        txtNumber = New TextBox()
        btnCheck = New Button()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Location = New Point(153, 100)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(51, 15)
        lblNumber.TabIndex = 0
        lblNumber.Text = "Number"
        ' 
        ' txtNumber
        ' 
        txtNumber.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtNumber.Location = New Point(112, 129)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(138, 29)
        txtNumber.TabIndex = 1
        ' 
        ' btnCheck
        ' 
        btnCheck.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCheck.Location = New Point(139, 175)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(89, 45)
        btnCheck.TabIndex = 2
        btnCheck.Text = "SUBMIT"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblResult.Location = New Point(151, 249)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(53, 20)
        lblResult.TabIndex = 3
        lblResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 315)
        Controls.Add(lblResult)
        Controls.Add(btnCheck)
        Controls.Add(txtNumber)
        Controls.Add(lblNumber)
        Name = "Form1"
        Text = "Numbers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnCheck As Button
    Friend WithEvents lblResult As Label

End Class
