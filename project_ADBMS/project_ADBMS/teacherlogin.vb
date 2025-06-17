Public Class teacherlogin
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusn.Text = "" Then
            MsgBox("Enter username", vbInformation, "Missing")
            txtusn.Focus()
            Exit Sub
        ElseIf txtpass.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpass.Focus()
            Exit Sub
        End If
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then Close()
            .Open("Select * from tc_registrations where TC_USN='" + txtusn.Text + "' and TC_PWORD='" + txtpass.Text + "'", cn, 1, 2)
            If .EOF = True Then
                MsgBox("Log in Failed", vbInformation, "Failed")
                Exit Sub
            End If
            MsgBox("Log in Successful", vbInformation, "Success")
            .Close()
        End With
        Me.Hide()
        grades.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub formTclogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con()
    End Sub
End Class