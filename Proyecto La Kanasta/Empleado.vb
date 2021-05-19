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
        conexion.Consulta("Select * from Empleados", "Empleados")
        dgvEmpleado.DataSource = conexion.ds.Tables("Empleados")

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim Agregar As String = "Insert into Empleados values ('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtUsuario.Text + "','" + txtContraseña.Text + "'  )"
        'MessageBox.Show(Agregar)
        If (conexion.Instertar(Agregar)) Then
            MessageBox.Show("Datos agregados correctamente")
            MostrarDatos()

        Else
            MessageBox.Show("Error al agregar")
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub
End Class