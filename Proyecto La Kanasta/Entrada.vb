Public Class Entrada

    Dim conexion As Conexion = New Conexion()


    Public Sub MostrarDatos()
        conexion.Consulta("select  Cantidad idProducto from Detalle_entrada  ", "Entrada")
        DataGridView1.DataSource = conexion.ds.Tables("Entrada")

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

    End Sub
End Class