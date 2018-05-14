Imports System.Data.OleDb
Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ceklogin()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ceklogin()
        Dim user() As String = {"Siswa", "Guru", "Admin"}
        Dim login As Boolean
        Dim i As Integer
        i = 0
        login = False
        Call sambungin()
        While (i <= 2 And login = False)
            cmd = New OleDbCommand("select * from " + user(i) + " where UserName='" & Username.Text & "' and Password='" & Password.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                login = True
            Else
                i += 1
            End If
        End While

        If (login = True) Then
            MsgBox("Selamat Anda Berhasil Login")
            My.Settings.user = i
            Home.Show()
            Me.Close()
        Else
            MsgBox("Username atau Password salah")
        End If
    End Sub
End Class
