Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip

Public Class formStudent


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbocourse.Items.Clear()
        cbocourse.Items.Add("BSIT")
        cbocourse.Items.Add("BSCS")
        cbocourse.Items.Add("BSTM")
        cbocourse.Items.Add("BSBA")
        cbocourse.Items.Add("BSA")
        cbocourse.Items.Add("BSED")
        cbocourse.Items.Add("BSCRIM")

        cbofilter.Items.Clear()
        cbofilter.Items.Add("Student Number")
        cbofilter.Items.Add("Last Name")
        cbofilter.Items.Add("First Name")
        cbofilter.SelectedIndex = 0

        lstdetails.View = View.Details
        lstdetails.Columns.Clear()
        lstdetails.Columns.Add("Student No", 100)
        lstdetails.Columns.Add("First Name", 100)
        lstdetails.Columns.Add("Last Name", 100)
        lstdetails.Columns.Add("MI", 50)
        lstdetails.Columns.Add("Gender", 70)
        lstdetails.Columns.Add("Contact", 100)
        lstdetails.Columns.Add("Birth Date", 100)
        lstdetails.Columns.Add("Address", 150)
        lstdetails.Columns.Add("Municipality", 100)
        lstdetails.Columns.Add("Province", 100)
        lstdetails.Columns.Add("Course", 100)
        lstdetails.Columns.Add("School Year", 100)
        lstdetails.Columns.Add("Parent Name", 120)
        lstdetails.Columns.Add("Parent Contact", 100)
        lstdetails.Columns.Add("Senior High", 100)
        lstdetails.Columns.Add("Year", 70)
        Call con()
        Call fill_account()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()

    End Sub
    Sub clear()
        txtstdno.Text = ""
        txtlname.Text = ""
        txtfname.Text = ""
        txtmi.Text = ""
        txtcontact.Text = ""
        txtaddress.Text = ""
        txtsy.Text = ""
        txtparent.Text = ""
        txtpcontact.Text = ""
        cbocourse.SelectedIndex = -1
        rbmale.Checked = False
        rbfemale.Checked = False
        txtbdate.Text = ""
        txtbdate.Enabled = True
        txtstdno.Focus()
        txtstdno.ReadOnly = False
    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btndelete.Click
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from std_registrations where STD_ID='" + txtstdno.Text + "'", cn, 1, 2)
            If MsgBox("Are you sure you want to delete this account?", vbQuestion + vbYesNo, "Delete") = vbNo Then
                Exit Sub
            End If
            .Delete()
            .Update()
            MsgBox("Details was deleted", vbInformation, "Delete")
            .Close()
        End With
        Call clear()
        Call fill_account()
    End Sub



    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        If cbofilter.SelectedIndex = -1 Then Exit Sub
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            If cbofilter.SelectedIndex = 0 Then
                .Open("SELECT * FROM std_registrations WHERE STD_ID LIKE '%" & txtsearch.Text & "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 1 Then
                .Open("SELECT * FROM std_registrations WHERE STD_LNAME LIKE '%" & txtsearch.Text & "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 2 Then
                .Open("SELECT * FROM std_registrations WHERE STD_FNAME LIKE '%" & txtsearch.Text & "%'", cn, 1, 2)
            Else
                Exit Sub
            End If

            lstdetails.Items.Clear()
            While Not .EOF
                myrec = lstdetails.Items.Add(.Fields("STD_ID").Value)
                myrec.SubItems.Add(.Fields("STD_FNAME").Value)
                myrec.SubItems.Add(.Fields("STD_LNAME").Value)
                myrec.SubItems.Add(.Fields("STD_MI").Value)
                myrec.SubItems.Add(.Fields("STD_SEX").Value)
                myrec.SubItems.Add(.Fields("STD_CONTACT").Value)
                myrec.SubItems.Add(.Fields("STD_BDATE").Value)
                myrec.SubItems.Add(.Fields("STD_ADDRESS").Value)
                myrec.SubItems.Add(.Fields("STD_MUNICIPALITY").Value)
                myrec.SubItems.Add(.Fields("STD_PROVINCE").Value)
                myrec.SubItems.Add(.Fields("STD_COURSE").Value)
                myrec.SubItems.Add(.Fields("STD_SY").Value)
                myrec.SubItems.Add(.Fields("PT_NAME").Value)
                myrec.SubItems.Add(.Fields("PT_CONTACT").Value)
                myrec.SubItems.Add(.Fields("STD_SH").Value)
                myrec.SubItems.Add(.Fields("STD_YR").Value)
                .MoveNext()
            End While
        End With
    End Sub
    Dim myrec As ListViewItem
    Sub fill_account()
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("SELECT * FROM std_registrations ORDER BY STD_ID ASC", cn, 1, 2)

            If .EOF Then Exit Sub

            lstdetails.Items.Clear()
            While Not .EOF
                myrec = lstdetails.Items.Add(.Fields("STD_ID").Value)
                myrec.SubItems.Add(.Fields("STD_FNAME").Value)
                myrec.SubItems.Add(.Fields("STD_LNAME").Value)
                myrec.SubItems.Add(.Fields("STD_MI").Value)
                myrec.SubItems.Add(.Fields("STD_SEX").Value)
                myrec.SubItems.Add(.Fields("STD_CONTACT").Value)
                myrec.SubItems.Add(.Fields("STD_BDATE").Value)
                myrec.SubItems.Add(.Fields("STD_ADDRESS").Value)
                myrec.SubItems.Add(.Fields("STD_MUNICIPALITY").Value)
                myrec.SubItems.Add(.Fields("STD_PROVINCE").Value)
                myrec.SubItems.Add(.Fields("STD_COURSE").Value)
                myrec.SubItems.Add(.Fields("STD_SY").Value)
                myrec.SubItems.Add(.Fields("PT_NAME").Value)
                myrec.SubItems.Add(.Fields("PT_CONTACT").Value)
                myrec.SubItems.Add(.Fields("STD_SH").Value)
                myrec.SubItems.Add(.Fields("STD_YR").Value)
                .MoveNext()
            End While

            .Close()
        End With
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
    Dim rec As ListViewItem
    Private Sub listdetails_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstdetails.SelectedIndexChanged

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtstdno.Text = "" Then
            MsgBox("Enter Student Number", vbInformation, "Missing")
            txtstdno.Focus()
            Exit Sub
        ElseIf txtfname.Text = "" Then
            MsgBox("Enter First Name", vbInformation, "Missing")
            txtfname.Focus()
            Exit Sub
        ElseIf txtlname.Text = "" Then
            MsgBox("Enter Last Name", vbInformation, "Missing")
            txtlname.Focus()
            Exit Sub
        ElseIf txtmi.Text = "" Then
            MsgBox("Enter Middle Initial", vbInformation, "Missing")
            txtmi.Focus()
            Exit Sub
        ElseIf txtbdate.Text = "" Then
            MsgBox("Enter Birth Date", vbInformation, "Missing")
            txtbdate.Focus()
            Exit Sub
        ElseIf Not rbmale.Checked And Not rbfemale.Checked Then
            MsgBox("Please select gender", vbInformation, "Missing")
            rbmale.Focus()
            Exit Sub
        ElseIf txtcontact.Text = "" Then
            MsgBox("Enter Contact", vbInformation, "Missing")
            txtcontact.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MsgBox("Enter Address", vbInformation, "Missing")
            txtaddress.Focus()
            Exit Sub
        ElseIf cbocourse.SelectedIndex = -1 Then
            MsgBox("Please select Course", vbInformation, "Missing")
            cbocourse.Focus()
            Exit Sub
        ElseIf txtsy.Text = "" Then
            MsgBox("Enter School Year", vbInformation, "Missing")
            txtsy.Focus()
            Exit Sub
        ElseIf txtparent.Text = "" Then
            MsgBox("Enter Parent/Guardian Name", vbInformation, "Missing")
            txtparent.Focus()
            Exit Sub
        ElseIf txtpcontact.Text = "" Then
            MsgBox("Enter Parent Contact", vbInformation, "Missing")
            txtpcontact.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("SELECT * FROM std_registrations WHERE STD_ID = '" & txtstdno.Text & "'", cn, 1, 2)
            If Not .EOF Then
                MsgBox("Student number already exists. Please enter a different one.", vbInformation, "Duplicate")
                txtstdno.Text = ""
                txtstdno.Focus()
                Exit Sub
            End If
            .Close()
        End With

        Dim gender As String = If(rbmale.Checked, "MALE", "FEMALE")

        Dim bdate As Date
        If Not Date.TryParseExact(txtbdate.Text, "MM/dd/yyyy", Nothing, Globalization.DateTimeStyles.None, bdate) Then
            MsgBox("Invalid birth date format. Use MM/dd/yyyy.", vbExclamation, "Error")
            txtbdate.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            .Open("std_registrations", cn, 1, 2)
            .AddNew()
            .Fields("STD_ID").Value = txtstdno.Text
            .Fields("STD_FNAME").Value = txtfname.Text
            .Fields("STD_LNAME").Value = txtlname.Text
            .Fields("STD_MI").Value = txtmi.Text
            .Fields("STD_BDATE").Value = bdate
            .Fields("STD_CONTACT").Value = txtcontact.Text
            .Fields("STD_SEX").Value = gender
            .Fields("STD_ADDRESS").Value = txtaddress.Text
            .Fields("STD_COURSE").Value = cbocourse.Text
            .Fields("STD_SY").Value = txtsy.Text
            .Fields("PT_NAME").Value = txtparent.Text
            .Fields("PT_CONTACT").Value = txtpcontact.Text
            .Update()
            .Close()
        End With
        MsgBox("Student added successfully!", vbInformation, "Success")
        Call clear()
        Call fill_account()
    End Sub


    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtstdno.Text = "" Then
            MsgBox("Enter Student Number", vbInformation, "Missing")
            txtstdno.Focus()
            Exit Sub
        ElseIf txtfname.Text = "" Then
            MsgBox("Enter First Name", vbInformation, "Missing")
            txtfname.Focus()
            Exit Sub
        ElseIf txtlname.Text = "" Then
            MsgBox("Enter Last Name", vbInformation, "Missing")
            txtlname.Focus()
            Exit Sub
        ElseIf txtmi.Text = "" Then
            MsgBox("Enter Middle Initial", vbInformation, "Missing")
            txtmi.Focus()
            Exit Sub
        ElseIf txtbdate.Text = "" Then
            MsgBox("Enter Birth Date", vbInformation, "Missing")
            txtbdate.Focus()
            Exit Sub
        ElseIf Not rbmale.Checked And Not rbfemale.Checked Then
            MsgBox("Please select gender", vbInformation, "Missing")
            rbmale.Focus()
            Exit Sub
        ElseIf txtcontact.Text = "" Then
            MsgBox("Enter Contact", vbInformation, "Missing")
            txtcontact.Focus()
            Exit Sub
        ElseIf txtaddress.Text = "" Then
            MsgBox("Enter Address", vbInformation, "Missing")
            txtaddress.Focus()
            Exit Sub
        ElseIf cbocourse.SelectedIndex = -1 Then
            MsgBox("Please select Course", vbInformation, "Missing")
            cbocourse.Focus()
            Exit Sub
        ElseIf txtsy.Text = "" Then
            MsgBox("Enter School Year", vbInformation, "Missing")
            txtsy.Focus()
            Exit Sub
        ElseIf txtparent.Text = "" Then
            MsgBox("Enter Parent/Guardian Name", vbInformation, "Missing")
            txtparent.Focus()
            Exit Sub
        ElseIf txtpcontact.Text = "" Then
            MsgBox("Enter Parent Contact", vbInformation, "Missing")
            txtpcontact.Focus()
            Exit Sub
        End If

        Dim bdate As Date
        If Not Date.TryParse(txtbdate.Text, bdate) Then
            MsgBox("Invalid birth date format. Use MM/dd/yyyy.", vbExclamation, "Error")
            txtbdate.Focus()
            Exit Sub
        End If

        Dim gender As String = If(rbmale.Checked, "MALE", "FEMALE")

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("SELECT * FROM std_registrations WHERE STD_ID='" & txtstdno.Text & "'", cn, 1, 2)
            If .EOF Then
                MsgBox("Student record not found!", vbExclamation, "Not Found")
                .Close()
                Exit Sub
            End If

            If MsgBox("Do you really want to update this student record?", vbQuestion + vbYesNo, "Update") = vbNo Then
                .Close()
                Exit Sub
            End If

            .Fields("STD_FNAME").Value = txtfname.Text
            .Fields("STD_LNAME").Value = txtlname.Text
            .Fields("STD_MI").Value = txtmi.Text
            .Fields("STD_BDATE").Value = bdate
            .Fields("STD_CONTACT").Value = txtcontact.Text
            .Fields("STD_SEX").Value = gender
            .Fields("STD_ADDRESS").Value = txtaddress.Text
            .Fields("STD_COURSE").Value = cbocourse.Text
            .Fields("STD_SY").Value = txtsy.Text
            .Fields("PT_NAME").Value = txtparent.Text
            .Fields("PT_CONTACT").Value = txtpcontact.Text
            .Update()

            MsgBox("Student record was updated successfully!", vbInformation, "Updated")
        End With
        Call clear()
        Call fill_account()

    End Sub


    Private Sub lstdetails_DoubleClick(sender As Object, e As EventArgs) Handles lstdetails.DoubleClick
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("SELECT * FROM std_registrations WHERE STD_ID = '" & lstdetails.FocusedItem.Text & "'", cn, 1, 2)
            If .EOF Then Exit Sub

            txtstdno.Text = .Fields("STD_ID").Value
            txtlname.Text = .Fields("STD_LNAME").Value
            txtfname.Text = .Fields("STD_FNAME").Value
            txtmi.Text = .Fields("STD_MI").Value
            If .Fields("STD_SEX").Value.ToString().ToUpper() = "MALE" Then
                rbmale.Checked = True
            ElseIf .Fields("STD_SEX").Value.ToString().ToUpper() = "FEMALE" Then
                rbfemale.Checked = True
            End If

            txtbdate.Text = CDate(.Fields("STD_BDATE").Value).ToShortDateString()
            txtcontact.Text = .Fields("STD_CONTACT").Value
            txtaddress.Text = .Fields("STD_ADDRESS").Value
            cbocourse.Text = .Fields("STD_COURSE").Value
            txtsy.Text = .Fields("STD_SY").Value
            txtparent.Text = .Fields("PT_NAME").Value
            txtpcontact.Text = .Fields("PT_CONTACT").Value
            txtstdno.ReadOnly = True
        End With
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        formTeacher.Show()
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        chooserole.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If lstdetails.SelectedItems.Count = 0 Then
            MessageBox.Show("Please select a student to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim stdID As String = lstdetails.FocusedItem.Text

        Dim confirmDelete As DialogResult = MessageBox.Show("Are you sure you want to delete this student record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirmDelete = DialogResult.Yes Then
            rs = New ADODB.Recordset
            With rs
                If .State = 1 Then .Close()
                .Open("DELETE FROM std_registrations WHERE STD_ID = '" & stdID & "'", cn, 1, 3)
            End With
            MessageBox.Show("Student record deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
