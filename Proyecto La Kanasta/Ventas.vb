Public Class Ventas

    Dim conexion As Conexion = New Conexion()

    Private CurrentVenta As Integer = 0
    Private TotalVenta As Decimal = 0.00

    Public Sub MostrarDatos()
        conexion.Consulta($"SELECT pv.Id as 'ID', p.Nombre as 'Producto', pv.Cantidad as 'Cantidad', p.Precio as 'Precio Unitario', (p.Precio * pv.Cantidad) as 'Subtotal' FROM ProductosVenta pv, Producto p, Venta2 v WHERE pv.IdProducto = p.idProducto AND pv.IdVenta = v.idVenta AND v.idVenta = {CurrentVenta}", "Venta")
        DataGridView1.DataSource = conexion.ds.Tables("Venta")

        conexion.Consulta($"SELECT SUM(p.Precio * pv.Cantidad)
            FROM ProductosVenta pv, Producto p, Venta2 v 
            WHERE pv.IdProducto = p.idProducto AND pv.IdVenta = v.idVenta AND v.idVenta = {CurrentVenta}", "Total")

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

    Public Sub NuevaVenta()
        conexion.Instertar($"INSERT INTO Venta2 (fecha) VALUES ('{Date.Now.ToString("yyyy-MM-dd")}')")

        conexion.Consulta("SELECT MAX(IdVenta) FROM Venta2", "MaxVenta")

        Dim result = conexion.ds.Tables("MaxVenta").Rows(0).ItemArray(0)

        CurrentVenta = Integer.Parse(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm = New Form3()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm = New Empleado()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm = New Producto()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm = New Corte_caja()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        Timer1.Start()
        DateTimePicker1.Visible = False
        NuevaVenta()
        MostrarDatos()
        RellenarComboProductos()

        Button4.Visible = False
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        Label16.Text = fecha
    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        Dim frm = New Inventario()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub btnCancelarArticulo_Click(sender As Object, e As EventArgs) Handles btnCancelarArticulo.Click
        Dim id As String = DataGridView1.SelectedRows(0).Cells.Item(0).Value
        conexion.Instertar($"DELETE FROM ProductosVenta WHERE Id = '{id}' AND IdVenta = {CurrentVenta}")
        MostrarDatos()
    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click
        NuevaVenta()
        MostrarDatos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim idProducto As DataRowView = ComboBox1.SelectedItem
        Dim cantidad As Integer = intCantidad.Value

        conexion.Instertar($"INSERT INTO ProductosVenta (IdProducto, IdVenta, Cantidad) VALUES ('{idProducto.Row.ItemArray(0)}', {CurrentVenta}, {cantidad})")

        MostrarDatos()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Nueva venta
        NuevaVenta()
        MostrarDatos()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conexion.Instertar($"UPDATE Venta2 SET total = {TotalVenta} WHERE idVenta = {CurrentVenta}")

        If (txtPago.Text >= lblTotal.Text) Then
            NuevaVenta()
            MostrarDatos()
            lblTotal.Text = 0.00
            txtPago.Text = ""
        Else
            MessageBox.Show("Cantidad de pago invalida")
        End If
    End Sub



    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub btnReporteVenta_Click(sender As Object, e As EventArgs) Handles btnReporteVenta.Click
        Dim frm = New Reporte_venta()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        Dim frm = New Entrada2()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub btnAgregarPerdida_Click(sender As Object, e As EventArgs) Handles btnAgregarPerdida.Click
        Dim frm = New Perdida2
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub
End Class