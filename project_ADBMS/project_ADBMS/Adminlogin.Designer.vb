<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminlogin
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
        txtpin = New TextBox()
        Label1 = New Label()
        btnenter = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' txtpin
        ' 
        txtpin.Location = New Point(89, 89)
        txtpin.Margin = New Padding(2)
        txtpin.Name = "txtpin"
        txtpin.Size = New Size(202, 23)
        txtpin.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(113, 55)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 23)
        Label1.TabIndex = 1
        Label1.Text = "ADMIN PASSWORD"
        ' 
        ' btnenter
        ' 
        btnenter.BackColor = Color.Silver
        btnenter.Font = New Font("Arial Narrow", 11.25F)
        btnenter.Location = New Point(89, 116)
        btnenter.Margin = New Padding(2)
        btnenter.Name = "btnenter"
        btnenter.Size = New Size(90, 32)
        btnenter.TabIndex = 3
        btnenter.Text = "ENTER"
        btnenter.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.Silver
        btnexit.Font = New Font("Arial Narrow", 11.25F)
        btnexit.Location = New Point(200, 116)
        btnexit.Margin = New Padding(2)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(91, 32)
        btnexit.TabIndex = 6
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' Adminlogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(369, 223)
        Controls.Add(btnexit)
        Controls.Add(btnenter)
        Controls.Add(Label1)
        Controls.Add(txtpin)
        Margin = New Padding(2)
        Name = "Adminlogin"
        Text = "Adminlogin"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtpin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnenter As Button
    Friend WithEvents btnexit As Button
End Class
