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
            MsgBox("No Logeado jajaja")
        End If
    End Sub
End Class
