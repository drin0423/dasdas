<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmgrades
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
        txtgradeid = New TextBox()
        txtname = New TextBox()
        Label3 = New Label()
        txtgpa = New TextBox()
        Label5 = New Label()
        txtstudid = New TextBox()
        Label8 = New Label()
        txtsy = New TextBox()
        Label10 = New Label()
        Label12 = New Label()
        cbocourse = New ComboBox()
        txtcode = New TextBox()
        Label14 = New Label()
        txttitle = New TextBox()
        Label16 = New Label()
        cbosem = New ComboBox()
        Label18 = New Label()
        btnsave = New Button()
        btnprint = New Button()
        txtsection = New TextBox()
        Label20 = New Label()
        txtinstructor = New TextBox()
        Label22 = New Label()
        btnupload = New Button()
        openfile = New OpenFileDialog()
        lstdetails = New ListView()
        Label2 = New Label()
        Label1 = New Label()
        Label4 = New Label()
        cbofilter = New ComboBox()
        txtsearch = New TextBox()
        Button1 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtgradeid
        ' 
        txtgradeid.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtgradeid.Location = New Point(99, 58)
        txtgradeid.Margin = New Padding(4)
        txtgradeid.Name = "txtgradeid"
        txtgradeid.Size = New Size(161, 22)
        txtgradeid.TabIndex = 17
        ' 
        ' txtname
        ' 
        txtname.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtname.Location = New Point(99, 83)
        txtname.Margin = New Padding(4)
        txtname.Name = "txtname"
        txtname.Size = New Size(161, 22)
        txtname.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Narrow", 9.75F)
        Label3.Location = New Point(55, 86)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 16)
        Label3.TabIndex = 19
        Label3.Text = "NAME:"
        ' 
        ' txtgpa
        ' 
        txtgpa.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtgpa.Location = New Point(99, 113)
        txtgpa.Margin = New Padding(4)
        txtgpa.Name = "txtgpa"
        txtgpa.Size = New Size(161, 22)
        txtgpa.TabIndex = 23
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(56, 115)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(38, 16)
        Label5.TabIndex = 22
        Label5.Text = "GPA:"
        ' 
        ' txtstudid
        ' 
        txtstudid.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtstudid.Location = New Point(99, 140)
        txtstudid.Margin = New Padding(4)
        txtstudid.Name = "txtstudid"
        txtstudid.Size = New Size(161, 22)
        txtstudid.TabIndex = 26
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 9.75F)
        Label8.Location = New Point(11, 143)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(86, 16)
        Label8.TabIndex = 25
        Label8.Text = "STUDENT ID:"
        ' 
        ' txtsy
        ' 
        txtsy.Font = New Font("Arial", 9.75F)
        txtsy.Location = New Point(381, 112)
        txtsy.Margin = New Padding(4)
        txtsy.Name = "txtsy"
        txtsy.Size = New Size(161, 22)
        txtsy.TabIndex = 29
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 9.75F)
        Label10.Location = New Point(273, 115)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(105, 16)
        Label10.TabIndex = 28
        Label10.Text = "SCHOOL YEAR:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 9.75F)
        Label12.Location = New Point(312, 144)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(66, 16)
        Label12.TabIndex = 31
        Label12.Text = "COURSE:"
        ' 
        ' cbocourse
        ' 
        cbocourse.DropDownStyle = ComboBoxStyle.DropDownList
        cbocourse.Font = New Font("Arial", 9.75F)
        cbocourse.FormattingEnabled = True
        cbocourse.Items.AddRange(New Object() {"BSCS", "BSIT", "BSBA", "BSTM", "BSCRIM", "BSED", "BSA"})
        cbocourse.Location = New Point(381, 140)
        cbocourse.Margin = New Padding(4)
        cbocourse.Name = "cbocourse"
        cbocourse.Size = New Size(161, 24)
        cbocourse.TabIndex = 34
        ' 
        ' txtcode
        ' 
        txtcode.Font = New Font("Arial", 9.75F)
        txtcode.Location = New Point(381, 197)
        txtcode.Margin = New Padding(4)
        txtcode.Name = "txtcode"
        txtcode.Size = New Size(161, 22)
        txtcode.TabIndex = 36
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 9.75F)
        Label14.Location = New Point(269, 200)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(110, 16)
        Label14.TabIndex = 35
        Label14.Text = "SUBJECT CODE:"
        ' 
        ' txttitle
        ' 
        txttitle.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txttitle.Location = New Point(99, 170)
        txttitle.Margin = New Padding(4)
        txttitle.Name = "txttitle"
        txttitle.Size = New Size(161, 22)
        txttitle.TabIndex = 39
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 9.75F)
        Label16.Location = New Point(28, 173)
        Label16.Margin = New Padding(4, 0, 4, 0)
        Label16.Name = "Label16"
        Label16.Size = New Size(68, 16)
        Label16.TabIndex = 38
        Label16.Text = "SUBJECT:"
        ' 
        ' cbosem
        ' 
        cbosem.DropDownStyle = ComboBoxStyle.DropDownList
        cbosem.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbosem.FormattingEnabled = True
        cbosem.Items.AddRange(New Object() {"FIRST", "SECOND"})
        cbosem.Location = New Point(99, 200)
        cbosem.Margin = New Padding(4)
        cbosem.Name = "cbosem"
        cbosem.Size = New Size(161, 24)
        cbosem.TabIndex = 43
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 9.75F)
        Label18.Location = New Point(13, 200)
        Label18.Margin = New Padding(4, 0, 4, 0)
        Label18.Name = "Label18"
        Label18.Size = New Size(83, 16)
        Label18.TabIndex = 41
        Label18.Text = "SEMESTER:"
        ' 
        ' btnsave
        ' 
        btnsave.Font = New Font("Arial Narrow", 9.75F)
        btnsave.ForeColor = Color.Black
        btnsave.Location = New Point(70, 451)
        btnsave.Margin = New Padding(4)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(80, 26)
        btnsave.TabIndex = 44
        btnsave.Text = "SAVE"
        btnsave.UseVisualStyleBackColor = True
        ' 
        ' btnprint
        ' 
        btnprint.Font = New Font("Arial Narrow", 9.75F)
        btnprint.ForeColor = Color.Black
        btnprint.Location = New Point(254, 451)
        btnprint.Margin = New Padding(4)
        btnprint.Name = "btnprint"
        btnprint.Size = New Size(119, 26)
        btnprint.TabIndex = 50
        btnprint.Text = "PRINT GRADE RECORDS"
        btnprint.UseVisualStyleBackColor = True
        ' 
        ' txtsection
        ' 
        txtsection.Font = New Font("Arial", 9.75F)
        txtsection.Location = New Point(381, 170)
        txtsection.Margin = New Padding(4)
        txtsection.Name = "txtsection"
        txtsection.Size = New Size(161, 22)
        txtsection.TabIndex = 46
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 9.75F)
        Label20.Location = New Point(311, 173)
        Label20.Margin = New Padding(4, 0, 4, 0)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 16)
        Label20.TabIndex = 45
        Label20.Text = "SECTION:"
        ' 
        ' txtinstructor
        ' 
        txtinstructor.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtinstructor.Location = New Point(381, 80)
        txtinstructor.Margin = New Padding(4)
        txtinstructor.Name = "txtinstructor"
        txtinstructor.Size = New Size(161, 22)
        txtinstructor.TabIndex = 49
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(284, 83)
        Label22.Margin = New Padding(4, 0, 4, 0)
        Label22.Name = "Label22"
        Label22.Size = New Size(92, 16)
        Label22.TabIndex = 48
        Label22.Text = "INSTRUCTOR:"
        ' 
        ' btnupload
        ' 
        btnupload.Font = New Font("Arial Narrow", 9.75F)
        btnupload.ForeColor = Color.Black
        btnupload.Location = New Point(158, 451)
        btnupload.Margin = New Padding(4)
        btnupload.Name = "btnupload"
        btnupload.Size = New Size(88, 26)
        btnupload.TabIndex = 51
        btnupload.Text = "BATCH UPLOAD"
        btnupload.UseVisualStyleBackColor = True
        ' 
        ' openfile
        ' 
        openfile.FileName = "OpenFileDialog1"
        ' 
        ' lstdetails
        ' 
        lstdetails.Location = New Point(16, 277)
        lstdetails.Margin = New Padding(2)
        lstdetails.Name = "lstdetails"
        lstdetails.Size = New Size(526, 168)
        lstdetails.TabIndex = 52
        lstdetails.UseCompatibleStateImageBehavior = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(210, 9)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 22)
        Label2.TabIndex = 53
        Label2.Text = "GRADES REPORT"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 9.75F)
        Label1.Location = New Point(25, 62)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 16)
        Label1.TabIndex = 54
        Label1.Text = "GRADE ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 255)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(56, 16)
        Label4.TabIndex = 55
        Label4.Text = "FILTER:"
        ' 
        ' cbofilter
        ' 
        cbofilter.DropDownStyle = ComboBoxStyle.DropDownList
        cbofilter.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        cbofilter.FormattingEnabled = True
        cbofilter.Items.AddRange(New Object() {"BSCS", "BSIT", "BSBA", "BSTM", "BSCRIM", "BSED", "BSA"})
        cbofilter.Location = New Point(71, 251)
        cbofilter.Margin = New Padding(4)
        cbofilter.Name = "cbofilter"
        cbofilter.Size = New Size(189, 24)
        cbofilter.TabIndex = 56
        ' 
        ' txtsearch
        ' 
        txtsearch.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtsearch.Location = New Point(358, 252)
        txtsearch.Margin = New Padding(4)
        txtsearch.Name = "txtsearch"
        txtsearch.Size = New Size(184, 22)
        txtsearch.TabIndex = 57
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(381, 451)
        Button1.Margin = New Padding(4)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 26)
        Button1.TabIndex = 60
        Button1.Text = "LOGOUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 9.75F)
        Label6.Location = New Point(285, 255)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(65, 16)
        Label6.TabIndex = 61
        Label6.Text = "SEARCH:"
        ' 
        ' frmgrades
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(575, 503)
        Controls.Add(Label6)
        Controls.Add(Button1)
        Controls.Add(txtsearch)
        Controls.Add(cbofilter)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(lstdetails)
        Controls.Add(btnupload)
        Controls.Add(txtinstructor)
        Controls.Add(Label22)
        Controls.Add(txtsection)
        Controls.Add(Label20)
        Controls.Add(btnsave)
        Controls.Add(cbosem)
        Controls.Add(Label18)
        Controls.Add(txttitle)
        Controls.Add(Label16)
        Controls.Add(txtcode)
        Controls.Add(Label14)
        Controls.Add(cbocourse)
        Controls.Add(Label12)
        Controls.Add(txtsy)
        Controls.Add(Label10)
        Controls.Add(txtstudid)
        Controls.Add(Label8)
        Controls.Add(txtgpa)
        Controls.Add(Label5)
        Controls.Add(txtname)
        Controls.Add(Label3)
        Controls.Add(txtgradeid)
        Controls.Add(btnprint)
        Margin = New Padding(4)
        Name = "frmgrades"
        Text = "GRADES"
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents txtgradeid As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtgpa As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtstudid As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsy As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cbocourse As ComboBox
    Friend WithEvents txtcode As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txttitle As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents cbosem As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents btnsave As Button
    Friend WithEvents btnprint As System.Windows.Forms.Button
    Friend WithEvents txtsection As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtinstructor As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents btnupload As Button
    Friend WithEvents openfile As OpenFileDialog
    Friend WithEvents lstdetails As ListView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
End Class
