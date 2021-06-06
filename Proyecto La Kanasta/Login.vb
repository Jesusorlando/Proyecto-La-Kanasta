Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario = txtUser.Text
        Dim pass = txtPass.Text
        Dim cnx = New Conexion()
        cnx.Consulta($"SELECT Usuario, Contraseña FROM Empleados WHERE Usuario ='{usuario}' AND Contraseña = '{pass}'", "Usuarios")
        If cnx.ds.Tables("Usuarios").Rows.Count > 0 Then
            Dim frm = New Ventas()
            frm.Location = Me.Location
            frm.StartPosition = FormStartPosition.Manual
            frm.Show()
            Me.Hide()
        Else
            MsgBox("Usuario o Contraseña no admitido")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If (e.KeyChar.ToString = "'") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPass_MouseDown(sender As Object, e As MouseEventArgs) Handles txtPass.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Right) Then
            MsgBox("No se permite utilizar el boton derecho del mouse en este campo",
            MsgBoxStyle.Critical, "Atencion")
            Exit Sub
        End If
    End Sub
End Class
