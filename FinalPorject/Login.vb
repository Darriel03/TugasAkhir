Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String
        Dim password As String

        username = TextBox1.Text
        password = TextBox2.Text

        If username = "admin" And password = "admin" Then
            'Login berhasil, tutup form login dan tampilkan form utama aplikasi'
            Utama.Show()
            Me.Hide()
        Else
            'Login gagal, tampilkan eror'
            MsgBox(" Username atau Password Salah")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs)
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

End Class
