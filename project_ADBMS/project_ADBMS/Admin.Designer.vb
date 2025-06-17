<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        btnstudent = New Button()
        btnteacher = New Button()
        btnlogout = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnstudent
        ' 
        btnstudent.BackColor = Color.Silver
        btnstudent.Font = New Font("Arial", 9F)
        btnstudent.Location = New Point(182, 91)
        btnstudent.Margin = New Padding(2)
        btnstudent.Name = "btnstudent"
        btnstudent.Size = New Size(124, 30)
        btnstudent.TabIndex = 2
        btnstudent.Text = "STUDENT"
        btnstudent.UseVisualStyleBackColor = False
        ' 
        ' btnteacher
        ' 
        btnteacher.BackColor = Color.Silver
        btnteacher.Font = New Font("Arial", 9F)
        btnteacher.Location = New Point(182, 125)
        btnteacher.Margin = New Padding(2)
        btnteacher.Name = "btnteacher"
        btnteacher.Size = New Size(124, 30)
        btnteacher.TabIndex = 3
        btnteacher.Text = "TEACHER"
        btnteacher.UseVisualStyleBackColor = False
        ' 
        ' btnlogout
        ' 
        btnlogout.BackColor = Color.Silver
        btnlogout.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnlogout.Location = New Point(182, 159)
        btnlogout.Margin = New Padding(2)
        btnlogout.Name = "btnlogout"
        btnlogout.Size = New Size(124, 29)
        btnlogout.TabIndex = 6
        btnlogout.Text = "LOG OUT"
        btnlogout.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(71, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 37)
        Label1.TabIndex = 20
        Label1.Text = "CHOOSE THE ROLE"
        ' 
        ' Admin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 248)
        Controls.Add(Label1)
        Controls.Add(btnlogout)
        Controls.Add(btnteacher)
        Controls.Add(btnstudent)
        Margin = New Padding(2)
        Name = "Admin"
        Text = "Admin"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnstudent As Button
    Friend WithEvents btnteacher As Button
    Friend WithEvents btnlogout As Button
    Friend WithEvents Label1 As Label
End Class
