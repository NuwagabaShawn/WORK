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
        txtNumber = New TextBox()
        btnCountDown = New Button()
        lblCountdownResult = New Label()
        SuspendLayout()
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(96, 91)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(139, 23)
        txtNumber.TabIndex = 0
        ' 
        ' btnCountDown
        ' 
        btnCountDown.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCountDown.Location = New Point(121, 131)
        btnCountDown.Name = "btnCountDown"
        btnCountDown.Size = New Size(86, 43)
        btnCountDown.TabIndex = 1
        btnCountDown.Text = "Display"
        btnCountDown.UseVisualStyleBackColor = True
        ' 
        ' lblCountdownResult
        ' 
        lblCountdownResult.AutoSize = True
        lblCountdownResult.Location = New Point(144, 194)
        lblCountdownResult.Name = "lblCountdownResult"
        lblCountdownResult.Size = New Size(39, 15)
        lblCountdownResult.TabIndex = 2
        lblCountdownResult.Text = "Result"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(335, 272)
        Controls.Add(lblCountdownResult)
        Controls.Add(btnCountDown)
        Controls.Add(txtNumber)
        Name = "Form1"
        Text = "While Loop"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumber As TextBox
    Friend WithEvents btnCountDown As Button
    Friend WithEvents lblCountdownResult As Label

End Class
