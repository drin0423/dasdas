<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class teacherforms
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
        Label3 = New Label()
        txtlname = New TextBox()
        txtfname = New TextBox()
        txtusn = New TextBox()
        txtpass = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtemail = New TextBox()
        Label7 = New Label()
        lstaccounts = New ListView()
        Label8 = New Label()
        cbofilter = New ComboBox()
        Label9 = New Label()
        txtsearch = New TextBox()
        btnadd = New Button()
        btnupdate = New Button()
        btnclear = New Button()
        btndelete = New Button()
        Button5 = New Button()
        chkshow = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(147, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(252, 22)
        Label1.TabIndex = 0
        Label1.Text = "TEACHER REGISTRATION"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(8, 52)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 15)
        Label3.TabIndex = 3
        Label3.Text = "LAST NAME"
        ' 
        ' txtlname
        ' 
        txtlname.Location = New Point(84, 52)
        txtlname.Margin = New Padding(2)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(158, 23)
        txtlname.TabIndex = 4
        ' 
        ' txtfname
        ' 
        txtfname.Location = New Point(84, 78)
        txtfname.Margin = New Padding(2)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(158, 23)
        txtfname.TabIndex = 5
        ' 
        ' txtusn
        ' 
        txtusn.Location = New Point(84, 107)
        txtusn.Margin = New Padding(2)
        txtusn.Name = "txtusn"
        txtusn.Size = New Size(158, 23)
        txtusn.TabIndex = 6
        ' 
        ' txtpass
        ' 
        txtpass.Location = New Point(334, 82)
        txtpass.Margin = New Padding(2)
        txtpass.Name = "txtpass"
        txtpass.Size = New Size(158, 23)
        txtpass.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(6, 80)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 15)
        Label4.TabIndex = 8
        Label4.Text = "FIRST NAME"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(8, 107)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(69, 15)
        Label5.TabIndex = 9
        Label5.Text = "USERNAME"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(252, 87)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 15)
        Label6.TabIndex = 10
        Label6.Text = "PASSWORD"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(334, 55)
        txtemail.Margin = New Padding(2)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(158, 23)
        txtemail.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(282, 52)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 15)
        Label7.TabIndex = 12
        Label7.Text = "EMAIL"
        ' 
        ' lstaccounts
        ' 
        lstaccounts.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lstaccounts.Location = New Point(8, 231)
        lstaccounts.Margin = New Padding(2)
        lstaccounts.Name = "lstaccounts"
        lstaccounts.Size = New Size(504, 133)
        lstaccounts.TabIndex = 13
        lstaccounts.UseCompatibleStateImageBehavior = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(38, 212)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 14
        Label8.Text = "FILTER"
        ' 
        ' cbofilter
        ' 
        cbofilter.FormattingEnabled = True
        cbofilter.Location = New Point(84, 209)
        cbofilter.Margin = New Padding(2)
        cbofilter.Name = "cbofilter"
        cbofilter.Size = New Size(158, 23)
        cbofilter.TabIndex = 15
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(286, 213)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(54, 15)
        Label9.TabIndex = 16
        Label9.Text = "SEARCH:"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(342, 209)
        txtsearch.Margin = New Padding(2)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(170, 23)
        txtsearch.TabIndex = 17
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Silver
        btnadd.Font = New Font("Arial Narrow", 9.75F)
        btnadd.Location = New Point(103, 148)
        btnadd.Margin = New Padding(2)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(77, 28)
        btnadd.TabIndex = 18
        btnadd.Text = "REGISTER"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Silver
        btnupdate.Font = New Font("Arial Narrow", 9.75F)
        btnupdate.Location = New Point(184, 148)
        btnupdate.Margin = New Padding(2)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(77, 28)
        btnupdate.TabIndex = 19
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Silver
        btnclear.Font = New Font("Arial Narrow", 9.75F)
        btnclear.Location = New Point(265, 148)
        btnclear.Margin = New Padding(2)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(77, 28)
        btnclear.TabIndex = 20
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.Silver
        btndelete.Font = New Font("Arial Narrow", 9.75F)
        btndelete.Location = New Point(346, 148)
        btndelete.Margin = New Padding(2)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(77, 28)
        btndelete.TabIndex = 21
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.Control
        Button5.Font = New Font("Arial Narrow", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = Color.Black
        Button5.Location = New Point(8, 368)
        Button5.Margin = New Padding(2)
        Button5.Name = "Button5"
        Button5.Size = New Size(75, 22)
        Button5.TabIndex = 22
        Button5.Text = "EXIT"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' chkshow
        ' 
        chkshow.AutoSize = True
        chkshow.Location = New Point(313, 114)
        chkshow.Margin = New Padding(2)
        chkshow.Name = "chkshow"
        chkshow.Size = New Size(125, 19)
        chkshow.TabIndex = 23
        chkshow.Text = "SHOW PASSWORD"
        chkshow.UseVisualStyleBackColor = True
        ' 
        ' formTeacher
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(520, 393)
        Controls.Add(chkshow)
        Controls.Add(Button5)
        Controls.Add(btndelete)
        Controls.Add(btnclear)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(txtsearch)
        Controls.Add(Label9)
        Controls.Add(cbofilter)
        Controls.Add(Label8)
        Controls.Add(lstaccounts)
        Controls.Add(Label7)
        Controls.Add(txtemail)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtpass)
        Controls.Add(txtusn)
        Controls.Add(txtfname)
        Controls.Add(txtlname)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Margin = New Padding(2)
        Name = "formTeacher"
        Text = "Teacher Registration Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtusn As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents lstaccounts As ListView
    Friend WithEvents Label8 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents chkshow As CheckBox
End Class
