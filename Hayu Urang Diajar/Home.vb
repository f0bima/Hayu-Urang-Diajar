Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Select Case My.Settings.user
            Case 0
                userlb.Text = "Siswa"
            Case 1
                userlb.Text = "Guru"
            Case 2
                userlb.Text = "Admin"
        End Select
    End Sub

    Private Sub Crud_Click(sender As Object, e As EventArgs) Handles crud.Click
        crudform.Show()
        Me.Hide()
    End Sub
End Class
