Public Class Inventario

    Dim conexion As Conexion = New Conexion()

    Public Sub MostrarDatos()
        conexion.Consulta("select Id, pe.idProducto, pe.Cantidad , Fecha  from ProductosEntrada pe, Producto p where p.idProducto = pe.idProducto", "Inventario")
        DataGridView1.DataSource = conexion.ds.Tables("Inventario")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim frm = New Entrada2()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
        Me.Hide()
    End Sub
End Class