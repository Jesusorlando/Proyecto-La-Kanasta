Public Class Reporte_venta

    Dim conexion As Conexion = New Conexion()

    Public Sub MostrarDatos()
        conexion.Consulta($" select v.idVenta as 'Venta', fecha as 'Fecha', idProducto as 'Producto', Cantidad, total  from Venta2 v , ProductosVenta pv where v.idVenta = v.IdVenta AND fecha between '{txtInicio.Text}' and '{txtFin.Text}' ", "ReporteVenta")
        DataGridView1.DataSource = conexion.ds.Tables("ReporteVenta")
    End Sub
    Private Sub Reporte_venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btbAceptar_Click(sender As Object, e As EventArgs) Handles btbAceptar.Click
        txtInicio.Text = MonthCalendar1.SelectionStart.ToString("yyyy-MM-dd")
        txtFin.Text = MonthCalendar2.SelectionStart.ToString("yyyy-MM-dd")


        MostrarDatos()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Dispose()
    End Sub
End Class