<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class studentforms
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtstdno = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtfname = New TextBox()
        txtlname = New TextBox()
        Label5 = New Label()
        txtmi = New TextBox()
        Label6 = New Label()
        rbmale = New RadioButton()
        rbfemale = New RadioButton()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtbdate = New TextBox()
        txtcontact = New TextBox()
        txtaddress = New TextBox()
        Label11 = New Label()
        Label13 = New Label()
        cbocourse = New ComboBox()
        txtsy = New TextBox()
        Label16 = New Label()
        Label17 = New Label()
        txtparent = New TextBox()
        txtpcontact = New TextBox()
        Label22 = New Label()
        cbofilter = New ComboBox()
        Label23 = New Label()
        txtsearch = New TextBox()
        btnadd = New Button()
        btnupdate = New Button()
        btndelete = New Button()
        btnclear = New Button()
        btnexit = New Button()
        lstdetails = New ListView()
        btnnext = New Button()
        button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(196, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 22)
        Label1.TabIndex = 0
        Label1.Text = "Student Registration Form"
        ' 
        ' txtstdno
        ' 
        txtstdno.Location = New Point(120, 50)
        txtstdno.Name = "txtstdno"
        txtstdno.Size = New Size(151, 23)
        txtstdno.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 11.25F)
        Label2.Location = New Point(19, 53)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 17)
        Label2.TabIndex = 2
        Label2.Text = "STUDENT ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.25F)
        Label3.Location = New Point(20, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 17)
        Label3.TabIndex = 3
        Label3.Text = "FIRST NAME:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(26, 140)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 17)
        Label4.TabIndex = 4
        Label4.Text = "LAST NAME:"
        ' 
        ' txtfname
        ' 
        txtfname.Location = New Point(120, 79)
        txtfname.Name = "txtfname"
        txtfname.Size = New Size(151, 23)
        txtfname.TabIndex = 5
        ' 
        ' txtlname
        ' 
        txtlname.Location = New Point(120, 137)
        txtlname.Name = "txtlname"
        txtlname.Size = New Size(151, 23)
        txtlname.TabIndex = 6
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(3, 111)
        Label5.Name = "Label5"
        Label5.Size = New Size(115, 17)
        Label5.TabIndex = 7
        Label5.Text = "MIDDLE INITIAL:"
        ' 
        ' txtmi
        ' 
        txtmi.Location = New Point(120, 108)
        txtmi.Name = "txtmi"
        txtmi.Size = New Size(151, 23)
        txtmi.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 11.25F)
        Label6.Location = New Point(76, 198)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 17)
        Label6.TabIndex = 9
        Label6.Text = "SEX:"
        ' 
        ' rbmale
        ' 
        rbmale.AutoSize = True
        rbmale.Font = New Font("Arial", 11.25F)
        rbmale.Location = New Point(123, 195)
        rbmale.Name = "rbmale"
        rbmale.Size = New Size(56, 21)
        rbmale.TabIndex = 10
        rbmale.TabStop = True
        rbmale.Text = "Male"
        rbmale.UseVisualStyleBackColor = True
        ' 
        ' rbfemale
        ' 
        rbfemale.AutoSize = True
        rbfemale.Font = New Font("Arial", 11.25F)
        rbfemale.Location = New Point(196, 195)
        rbfemale.Name = "rbfemale"
        rbfemale.Size = New Size(75, 21)
        rbfemale.TabIndex = 11
        rbfemale.TabStop = True
        rbfemale.Text = "Female"
        rbfemale.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 11.25F)
        Label7.Location = New Point(-2, 169)
        Label7.Name = "Label7"
        Label7.Size = New Size(122, 17)
        Label7.TabIndex = 12
        Label7.Text = "DATE OF BIRTH:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 11.25F)
        Label8.Location = New Point(299, 53)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 17)
        Label8.TabIndex = 13
        Label8.Text = "CONTACT NO:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 11.25F)
        Label9.Location = New Point(323, 82)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 17)
        Label9.TabIndex = 14
        Label9.Text = "ADDRESS:"
        ' 
        ' txtbdate
        ' 
        txtbdate.Location = New Point(120, 166)
        txtbdate.Name = "txtbdate"
        txtbdate.Size = New Size(151, 23)
        txtbdate.TabIndex = 15
        ' 
        ' txtcontact
        ' 
        txtcontact.Location = New Point(410, 50)
        txtcontact.Name = "txtcontact"
        txtcontact.Size = New Size(151, 23)
        txtcontact.TabIndex = 16
        ' 
        ' txtaddress
        ' 
        txtaddress.Location = New Point(410, 79)
        txtaddress.Name = "txtaddress"
        txtaddress.Size = New Size(151, 23)
        txtaddress.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 11.25F)
        Label11.Location = New Point(332, 140)
        Label11.Name = "Label11"
        Label11.Size = New Size(76, 17)
        Label11.TabIndex = 19
        Label11.Text = "COURSE:"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(291, 111)
        Label13.Name = "Label13"
        Label13.Size = New Size(117, 17)
        Label13.TabIndex = 21
        Label13.Text = "SCHOOL YEAR:"
        ' 
        ' cbocourse
        ' 
        cbocourse.FormattingEnabled = True
        cbocourse.Location = New Point(410, 137)
        cbocourse.Name = "cbocourse"
        cbocourse.Size = New Size(151, 23)
        cbocourse.TabIndex = 24
        ' 
        ' txtsy
        ' 
        txtsy.Location = New Point(410, 108)
        txtsy.Name = "txtsy"
        txtsy.Size = New Size(151, 23)
        txtsy.TabIndex = 25
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(279, 169)
        Label16.Name = "Label16"
        Label16.Size = New Size(130, 17)
        Label16.TabIndex = 28
        Label16.Text = "GUARDIAN NAME:"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(299, 198)
        Label17.Name = "Label17"
        Label17.Size = New Size(108, 17)
        Label17.TabIndex = 29
        Label17.Text = "CONTACT NO:"
        ' 
        ' txtparent
        ' 
        txtparent.Location = New Point(410, 166)
        txtparent.Name = "txtparent"
        txtparent.Size = New Size(151, 23)
        txtparent.TabIndex = 34
        ' 
        ' txtpcontact
        ' 
        txtpcontact.Location = New Point(410, 195)
        txtpcontact.Name = "txtpcontact"
        txtpcontact.Size = New Size(151, 23)
        txtpcontact.TabIndex = 35
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(9, 244)
        Label22.Name = "Label22"
        Label22.Size = New Size(50, 15)
        Label22.TabIndex = 39
        Label22.Text = "FILTER:"
        ' 
        ' cbofilter
        ' 
        cbofilter.FormattingEnabled = True
        cbofilter.Location = New Point(60, 241)
        cbofilter.Name = "cbofilter"
        cbofilter.Size = New Size(211, 23)
        cbofilter.TabIndex = 40
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(311, 245)
        Label23.Name = "Label23"
        Label23.Size = New Size(60, 15)
        Label23.TabIndex = 41
        Label23.Text = "SEARCH:"
        ' 
        ' txtsearch
        ' 
        txtsearch.Location = New Point(373, 241)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(203, 23)
        txtsearch.TabIndex = 42
        ' 
        ' btnadd
        ' 
        btnadd.BackColor = Color.Silver
        btnadd.Font = New Font("Arial", 11.25F)
        btnadd.Location = New Point(54, 546)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(83, 36)
        btnadd.TabIndex = 43
        btnadd.Text = "ADD"
        btnadd.UseVisualStyleBackColor = False
        ' 
        ' btnupdate
        ' 
        btnupdate.BackColor = Color.Silver
        btnupdate.Font = New Font("Arial", 11.25F)
        btnupdate.ForeColor = Color.Black
        btnupdate.Location = New Point(152, 546)
        btnupdate.Name = "btnupdate"
        btnupdate.Size = New Size(83, 36)
        btnupdate.TabIndex = 44
        btnupdate.Text = "UPDATE"
        btnupdate.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = SystemColors.ActiveCaption
        btndelete.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btndelete.ForeColor = Color.Black
        btndelete.Location = New Point(1399, 477)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(288, 52)
        btndelete.TabIndex = 45
        btndelete.Text = "DELETE"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnclear
        ' 
        btnclear.BackColor = Color.Silver
        btnclear.Font = New Font("Arial", 11.25F)
        btnclear.ForeColor = SystemColors.ActiveCaptionText
        btnclear.Location = New Point(250, 546)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(85, 35)
        btnclear.TabIndex = 46
        btnclear.Text = "CLEAR"
        btnclear.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = SystemColors.ActiveCaption
        btnexit.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnexit.ForeColor = Color.DarkRed
        btnexit.Location = New Point(1399, 537)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(288, 51)
        btnexit.TabIndex = 47
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' lstdetails
        ' 
        lstdetails.BackColor = SystemColors.Window
        lstdetails.Location = New Point(8, 270)
        lstdetails.Name = "lstdetails"
        lstdetails.Size = New Size(568, 270)
        lstdetails.TabIndex = 48
        lstdetails.UseCompatibleStateImageBehavior = False
        ' 
        ' btnnext
        ' 
        btnnext.BackColor = SystemColors.ActiveCaption
        btnnext.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnnext.Location = New Point(1399, 593)
        btnnext.Name = "btnnext"
        btnnext.Size = New Size(316, 51)
        btnnext.TabIndex = 49
        btnnext.Text = "GO TO TEACHER REGISTRATION"
        btnnext.UseVisualStyleBackColor = False
        ' 
        ' button1
        ' 
        button1.BackColor = Color.Silver
        button1.Font = New Font("Arial", 11.25F)
        button1.ForeColor = SystemColors.ActiveCaptionText
        button1.Location = New Point(432, 547)
        button1.Name = "button1"
        button1.Size = New Size(85, 35)
        button1.TabIndex = 50
        button1.Text = "EXIT"
        button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Silver
        Button2.Font = New Font("Arial", 11.25F)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(341, 546)
        Button2.Name = "Button2"
        Button2.Size = New Size(85, 35)
        Button2.TabIndex = 51
        Button2.Text = "DELETE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' formStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(583, 604)
        Controls.Add(Button2)
        Controls.Add(button1)
        Controls.Add(btnnext)
        Controls.Add(lstdetails)
        Controls.Add(btnexit)
        Controls.Add(btnclear)
        Controls.Add(btndelete)
        Controls.Add(btnupdate)
        Controls.Add(btnadd)
        Controls.Add(txtsearch)
        Controls.Add(Label23)
        Controls.Add(cbofilter)
        Controls.Add(Label22)
        Controls.Add(txtpcontact)
        Controls.Add(txtparent)
        Controls.Add(Label17)
        Controls.Add(Label16)
        Controls.Add(txtsy)
        Controls.Add(cbocourse)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(txtaddress)
        Controls.Add(txtcontact)
        Controls.Add(txtbdate)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(rbfemale)
        Controls.Add(rbmale)
        Controls.Add(Label6)
        Controls.Add(txtmi)
        Controls.Add(Label5)
        Controls.Add(txtlname)
        Controls.Add(txtfname)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtstdno)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Name = "formStudent"
        Text = "Student Registration Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtstdno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtfname As TextBox
    Friend WithEvents txtlname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtmi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbdate As TextBox
    Friend WithEvents txtcontact As TextBox
    Friend WithEvents txtaddress As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents txtsy As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtparent As TextBox
    Friend WithEvents txtpcontact As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents listdetails As ListView
    Friend WithEvents lstdetails As ListView
    Friend WithEvents btnnext As Button
    Friend WithEvents button1 As Button
    Friend WithEvents Button2 As Button

End Class
