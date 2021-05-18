Public Class Form3
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) 

    End Sub 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As New ClaseLogin(TextBox1.Text, TextBox2.Text)
        'Validamos si el usuario que intenta acceder al sistema está registrado
        'éste usuario es un registro de la tabla de usuarios, NO ES el usuario
        'de ORACLE, el el usuario final
        If usuario.consultaUsuario() = False Then
            MsgBox("Usuario no registrado, favor de llamar al ADMINISTRADOR del sistema", MsgBoxStyle.Exclamation)
            cnx.Close()
        Else
            ' si está registrado el usuario, cerramos la conexión a la BD
            cnx.Close()
            ' presentamos la pantalla del Menú del sistema
            MenuUsuarios.Show()
            ' descargamos la pantalla actual LOGIN
            Me.Hide()
        End If
    End Sub
End Class
