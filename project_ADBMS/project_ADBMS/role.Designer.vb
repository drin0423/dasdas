<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class role
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
        btnAdmin = New Button()
        btnTeacher = New Button()
        Button3 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnAdmin
        ' 
        btnAdmin.BackColor = Color.Silver
        btnAdmin.Font = New Font("Arial", 12F)
        btnAdmin.Location = New Point(144, 88)
        btnAdmin.Margin = New Padding(2)
        btnAdmin.Name = "btnAdmin"
        btnAdmin.Size = New Size(156, 34)
        btnAdmin.TabIndex = 4
        btnAdmin.Text = "ADMIN"
        btnAdmin.UseVisualStyleBackColor = False
        ' 
        ' btnTeacher
        ' 
        btnTeacher.BackColor = Color.Silver
        btnTeacher.Font = New Font("Arial", 12F)
        btnTeacher.Location = New Point(144, 126)
        btnTeacher.Margin = New Padding(2)
        btnTeacher.Name = "btnTeacher"
        btnTeacher.Size = New Size(156, 34)
        btnTeacher.TabIndex = 5
        btnTeacher.Text = "TEACHER"
        btnTeacher.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Silver
        Button3.Font = New Font("Arial", 12F)
        Button3.Location = New Point(144, 164)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 34)
        Button3.TabIndex = 10
        Button3.Text = "EXIT"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 37)
        Label1.TabIndex = 21
        Label1.Text = "CHOOSE THE ROLE"
        ' 
        ' chooserole
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 248)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(btnTeacher)
        Controls.Add(btnAdmin)
        Margin = New Padding(2)
        Name = "chooserole"
        Text = "ROLE"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAdmin As Button
    Friend WithEvents btnTeacher As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
End Class
