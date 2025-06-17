Public Class Adminlogin
    Private Sub Adminlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        role.Show()
        Hide()
    End Sub

    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        If txtpin.Text = "1234" Then
            Admin.Show()
            Hide()
        Else
            MsgBox("Incorrect PIN. Please try again.", MsgBoxStyle.Critical, "Access Denied")
            txtpin.Clear()
            txtpin.Focus()
        End If
    End Sub
End Class