
Imports System.Data.SqlClient
Public Class Producto

    Dim conexion As Conexion = New Conexion()

    Public Sub MostrarDatos()
        conexion.Consulta("select * from Producto ", "Productos")
        DataGridView1.DataSource = conexion.ds.Tables("Productos")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click

        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")

        'MessageBox.Show(fecha)
        'MessageBox.Show("Insert into Productos values ('" + txtProducto.Text + "','" + txtNombre.Text + "','" + cbState.Text + "','" + fecha + "','" + txtPrecio.Text + "','" + cbMedida.Text + "'  )")
        Dim Agregar As String = "Insert into Producto values ('" + txtProducto.Text + "','" + txtNombre.Text + "','" + cbState.Text + "','" + fecha + "','" + txtPrecio.Text + "','" + cbMedida.Text + "'  )"

        If (conexion.Instertar(Agregar)) Then
            MessageBox.Show("Datos agregados correctamente")
            MostrarDatos()

        Else
            MessageBox.Show("Error al agregar")
        End If

    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DateTimePicker1.Visible = False
        cbState.Visible = False
        cbMedida.Visible = False

        conexion.conectar()
        MostrarDatos()
    End Sub

    Private Sub labelFecha_Click(sender As Object, e As EventArgs) Handles labelFecha.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        labelFecha.Text = fecha

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

End Class