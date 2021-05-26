Public Class Entrada

    Dim conexion As Conexion = New Conexion()
    Private CurrentEntrada As Integer = 0
    Private TotalVenta As Decimal = 0.00

    Public Sub MostrarDatos()
        conexion.Consulta($"SELECT pv.Id as 'ID', p.Nombre as 'Producto', pv.Cantidad as 'Cantidad', p.Precio as 'Precio Unitario', (p.Precio * pv.Cantidad) as 'Subtotal' 
                             FROM ProductosEntrada pv, Producto p, Entrada v 
                             WHERE pv.IdProducto = p.idProducto AND pv.idEntrada = v.idEntrada AND v.idEntrada = {CurrentEntrada}", "Entrada")
        DataGridView1.DataSource = conexion.ds.Tables("Entrada")

        conexion.Consulta($"SELECT SUM(p.Precio * pv.Cantidad)
            FROM ProductosEntrada pv, Producto p, Entrada v 
            WHERE pv.IdProducto = p.idProducto AND pv.idEntrada = v.idEntrada AND v.idEntrada = {CurrentEntrada}", "Total")

        Dim total As String = conexion.ds.Tables("Total").Rows(0).ItemArray(0).ToString()

        If (Not String.IsNullOrEmpty(total)) Then
            TotalVenta = Decimal.Parse(total)
        End If

        lblTotal.Text = TotalVenta.ToString()


    End Sub


    Public Sub RellenarComboProductos()
        conexion.Consulta("SELECT idProducto, Nombre FROM Producto", "Producto")
        ComboBox1.DataSource = conexion.ds.Tables("Producto")
        ComboBox1.ValueMember = "idProducto"
        ComboBox1.DisplayMember = "Nombre"
    End Sub



    Private Sub Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        RellenarComboProductos()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idProducto As DataRowView = ComboBox1.SelectedItem
        Dim cantidad As Integer = intCantidad.Value

        conexion.Instertar($"INSERT INTO ProductosEntrada (IdProducto, IdEntrada, Cantidad) VALUES ('{idProducto.Row.ItemArray(0)}', {CurrentEntrada}, {cantidad})")

        MostrarDatos()
    End Sub
End Class