Imports System.Data.SqlClient


Public Class Empleado

    Dim conexion As Conexion = New Conexion()

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()

    End Sub

    Public Sub MostrarDatos()
        conexion.Consulta("select idEmpleados, Nombre, Apellido from Empleados", "Empleados")
        dgvEmpleado.DataSource = conexion.ds.Tables("Empleados")

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim cnx = New Conexion()
        Dim valido = txtUsuario.Text

        cnx.Consulta($"select usuario from empleados where usuario = '{valido}' ", "lol")

            If (cnx.ds.Tables("lol").Rows.Count <= 0) Then

            Try

                If (txtNombre.Text = "" Or txtApellido.Text = "" Or txtUsuario.Text = "" Or txtContraseña.Text = "" Or txtRpContraseña.Text = "") Then

                    MessageBox.Show("Campos vacios invalidos")


                Else

                    If (txtContraseña.Text <> txtRpContraseña.Text) Then

                        MessageBox.Show("Las contraseñas deben coincidir ")
                    Else

                        Dim Agregar As String = "Insert into Empleados values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUsuario.Text + "','" + txtContraseña.Text + "'  )"

                        If (conexion.Instertar(Agregar)) Then
                            MessageBox.Show("Datos agregados correctamente")
                            MostrarDatos()

                        Else
                            MessageBox.Show("Error al agregar")
                        End If

                        Dim limpiar As Conexion = New Conexion
                        limpiar.LimpiarCampos(Me)

                    End If

                End If
            Catch ex As Exception
                MessageBox.Show("No se permite caracter tipo  ' ")
            End Try

        Else
            MessageBox.Show("El usuario ya existe")
        End If



    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub dgvEmpleado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleado.CellContentClick

    End Sub

    Private Sub txtUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsuario.KeyPress
        If (e.KeyChar.ToString = "'") Then
            e.Handled = True
        End If
    End Sub
End Class