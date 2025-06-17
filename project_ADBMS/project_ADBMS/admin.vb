Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnstudent_Click(sender As Object, e As EventArgs) Handles btnstudent.Click
        studentforms.Show()
        Me.Hide()
    End Sub

    Private Sub btnteacher_Click(sender As Object, e As EventArgs) Handles btnteacher.Click
        teacherforms.Show()
        Me.Hide()
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        role.Show()
        Me.Hide()
    End Sub

    Private Sub Admin_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
    End Sub
End Class