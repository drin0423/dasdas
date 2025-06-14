Public Class chooserole
    Inherits Form

    Private Sub chooserole_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Dim adminForm As New Adminlogin
        adminForm.Show()
        Hide()
    End Sub

    Private Sub btnTeacher_Click(sender As Object, e As EventArgs) Handles btnTeacher.Click
        Dim teacherForm As New formTclogin
        teacherForm.Show()
        Hide()
    End Sub

    Private Sub lblAdmin_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class