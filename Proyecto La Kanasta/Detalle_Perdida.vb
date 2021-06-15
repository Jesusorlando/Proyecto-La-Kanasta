Public Class Detalle_Perdida

    Dim conexion As Conexion = New Conexion()
    Public Sub MostrarDatos()
        conexion.Consulta($" select idProducto as 'Producto',idPerdida as 'Numero de Registro', Cantidad  from ProductosPerdida ", "Detalle_perdida")
        DataGridView1.DataSource = conexion.ds.Tables("Detalle_perdida")
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Detalle_Perdida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Dispose()
    End Sub
End Class