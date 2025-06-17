Public Class teacherforms
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtlname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtlname.Focus()
            Exit Sub
        ElseIf txtfname.Text = "" Then
            MsgBox("Enter first name", vbInformation, "Missing")
            txtfname.Focus()
            Exit Sub
        ElseIf txtusn.Text = "" Then
            MsgBox("Enter username", vbInformation, "Missing")
            txtusn.Focus()
            Exit Sub
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpass.Focus()
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Enter email", vbInformation, "Missing")
            txtemail.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tc_registrations where TC_USN='" + txtusn.Text + "'", cn, 1, 2)
            If .EOF = False Then
                MsgBox("Username already exist, use a different username", vbInformation, "Exist")
                txtusn.Text = ""
                txtusn.Focus()
                Exit Sub
            End If
            .AddNew()
            .Fields("TC_FNAME").Value = txtfname.Text
            .Fields("TC_LNAME").Value = txtlname.Text
            .Fields("TC_USN").Value = txtusn.Text
            .Fields("TC_PWORD").Value = txtpass.Text
            .Fields("TC_EMAIL").Value = txtemail.Text
            .Update()
            MsgBox("Account was added", vbInformation, "Add")
            .Close()
            Call fill_account()
        End With
    End Sub

    Private Sub formTeacher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbofilter.Items.Clear()
        cbofilter.Items.Add("Username")
        cbofilter.Items.Add("Last Name")
        cbofilter.Items.Add("First Name")
        cbofilter.Items.Add("Email")
        cbofilter.SelectedIndex = 0
        lstaccounts.View = View.Details
        lstaccounts.Columns.Clear()
        lstaccounts.Columns.Add("Username", 100)
        lstaccounts.Columns.Add("First Name", 100)
        lstaccounts.Columns.Add("Last Name", 100)
        lstaccounts.Columns.Add("Email", 100)
        Call con()
        Call fill_account()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtpass.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpass.Focus()
            Exit Sub
        ElseIf txtlname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtlname.Focus()
            Exit Sub
        ElseIf txtfname.Text = "" Then
            MsgBox("Enter first name", vbInformation, "Missing")
            txtfname.Focus()
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Enter email", vbInformation, "Missing")
            txtemail.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tc_registrations where TC_USN='" + txtusn.Text + "'", cn, 1, 2)
            .Fields("TC_FNAME").Value = txtfname.Text
            .Fields("TC_LNAME").Value = txtlname.Text
            .Fields("TC_PWORD").Value = txtpass.Text
            .Fields("TC_EMAIL").Value = txtemail.Text
            If MsgBox("Do you really want to update this account?", vbQuestion + vbYesNo, "Update") = vbNo Then
                Exit Sub
            End If
            .Update()
            MsgBox("Account was updated", vbInformation, "Add")
            .Close()
            Call fill_account()
        End With
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        clear()
    End Sub
    Sub clear()
        txtusn.Text = ""
        txtpass.Text = ""
        txtlname.Text = ""
        txtfname.Text = ""
        chkshow.Checked = False
        txtemail.Text = ""
        txtusn.Enabled = True
        txtusn.Focus()
    End Sub

    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged
        If chkshow.Checked = True Then
            txtpass.PasswordChar = ""
        Else
            txtpass.PasswordChar = "*"
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tc_registrations where TC_USN='" + txtusn.Text + "'", cn, 1, 2)
            If MsgBox("Are you sure you want to delet this account?", vbQuestion + vbYesNo, "Delete") = vbNo Then
                Exit Sub
            End If
            .Delete()
            .Update()
            MsgBox("Account was deleted", vbInformation, "Delete")
            .Close()
        End With
        Call clear()
        Call fill_account()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        role.Show()
        Me.Hide()
    End Sub
    Dim rec As ListViewItem

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            If cbofilter.SelectedIndex = 0 Then
                .Open("Select * from tc_registrations where TC_USN like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 1 Then
                .Open("Select * from tc_registrations where TC_LNAME like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 2 Then
                .Open("Select * from tc_registrations where TC_FNAME like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 3 Then
                .Open("Select * from tc_registrations where TC_EMAIL like '%" + txtsearch.Text + "%'", cn, 1, 2)
            Else
                Exit Sub
            End If
            lstaccounts.Items.Clear()
            While .EOF = False
                myrec = lstaccounts.Items.Add(.Fields("TC_USN").Value)
                myrec.SubItems.Add(.Fields("TC_FNAME").Value)
                myrec.SubItems.Add(.Fields("TC_LNAME").Value)
                myrec.SubItems.Add(.Fields("TC_EMAIL").Value)
                .MoveNext()
            End While
        End With
    End Sub

    Dim myrec As ListViewItem
    Sub fill_account()
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tc_registrations ORDER BY TC_USN ASC", cn, 1, 2)
            If .EOF = True Then
                Exit Sub
            End If
            lstaccounts.Items.Clear()
            While .EOF = False
                myrec = lstaccounts.Items.Add(.Fields("TC_USN").Value)
                myrec.SubItems.Add(.Fields("TC_FNAME").Value)
                myrec.SubItems.Add(.Fields("TC_LNAME").Value)
                myrec.SubItems.Add(.Fields("TC_EMAIL").Value)
                .MoveNext()
            End While
            .Close()
        End With
    End Sub

    Private Sub lstaccounts_DoubleClick(sender As Object, e As EventArgs) Handles lstaccounts.DoubleClick
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tc_registrations where TC_USN='" + lstaccounts.FocusedItem.Text + "'", cn, 1, 2)
            If .EOF = True Then
                Exit Sub
            End If
            txtfname.Text = .Fields("TC_FNAME").Value
            txtlname.Text = .Fields("TC_LNAME").Value
            txtusn.Text = .Fields("TC_USN").Value
            txtpass.Text = .Fields("TC_PWORD").Value
            txtemail.Text = .Fields("TC_EMAIL").Value
            txtusn.Enabled = False
            .Close()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        grades.Show()
        Hide()
    End Sub
End Class