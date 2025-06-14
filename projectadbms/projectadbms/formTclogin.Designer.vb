<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formTclogin
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
        Label1 = New Label()
        Label2 = New Label()
        txtusn = New TextBox()
        txtpass = New TextBox()
        btnlogin = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 12F)
        Label1.Location = New Point(35, 50)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 18)
        Label1.TabIndex = 0
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F)
        Label2.Location = New Point(37, 79)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 18)
        Label2.TabIndex = 1
        Label2.Text = "Password:"
        ' 
        ' txtusn
        ' 
        txtusn.Location = New Point(120, 47)
        txtusn.Margin = New Padding(2)
        txtusn.Name = "txtusn"
        txtusn.Size = New Size(213, 23)
        txtusn.TabIndex = 2
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(120, 77)
        txtpass.Margin = New Padding(2)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(213, 23)
        txtpass.TabIndex = 3
        ' 
        ' btnlogin
        ' 
        btnlogin.Font = New Font("Arial Narrow", 9.75F)
        btnlogin.ForeColor = Color.Black
        btnlogin.Location = New Point(120, 113)
        btnlogin.Margin = New Padding(2)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(96, 25)
        btnlogin.TabIndex = 5
        btnlogin.Text = "LOG IN"
        btnlogin.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 9.75F)
        Button2.ForeColor = Color.Black
        Button2.Location = New Point(232, 114)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Size = New Size(101, 25)
        Button2.TabIndex = 6
        Button2.Text = "EXIT"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' formTclogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(416, 254)
        Controls.Add(Button2)
        Controls.Add(btnlogin)
        Controls.Add(txtpass)
        Controls.Add(txtusn)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "formTclogin"
        Text = "LOG IN"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusn As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents Button2 As Button
End Class
