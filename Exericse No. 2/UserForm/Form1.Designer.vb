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
        Label1 = New Label()
        lblName = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        lblAge = New Label()
        txtColor = New TextBox()
        lblColor = New Label()
        btnSubmit = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Bodoni MT Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(310, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(145, 24)
        Label1.TabIndex = 0
        Label1.Text = "USERFORM"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(206, 104)
        lblName.Name = "lblName"
        lblName.Size = New Size(52, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(206, 127)
        txtName.Name = "txtName"
        txtName.Size = New Size(346, 27)
        txtName.TabIndex = 2
        ' 
        ' txtAge
        ' 
        txtAge.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtAge.Location = New Point(206, 192)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(346, 27)
        txtAge.TabIndex = 4
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAge.Location = New Point(206, 169)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(39, 20)
        lblAge.TabIndex = 3
        lblAge.Text = "Age:"
        ' 
        ' txtColor
        ' 
        txtColor.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtColor.Location = New Point(206, 262)
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(346, 27)
        txtColor.TabIndex = 6
        ' 
        ' lblColor
        ' 
        lblColor.AutoSize = True
        lblColor.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblColor.Location = New Point(206, 239)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(48, 20)
        lblColor.TabIndex = 5
        lblColor.Text = "Color:"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Font = New Font("Bodoni MT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(310, 334)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(143, 46)
        btnSubmit.TabIndex = 7
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(txtColor)
        Controls.Add(lblColor)
        Controls.Add(txtAge)
        Controls.Add(lblAge)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "USERFORM"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents lblColor As Label
    Friend WithEvents btnSubmit As Button

End Class
