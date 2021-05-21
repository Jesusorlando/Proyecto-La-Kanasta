Public Class Ventas

    Dim conexion As Conexion = New Conexion()
    Public Sub MostrarDatos()
        conexion.Consulta("select Nombre, Precio  from producto ", "Venta")
        DataGridView1.DataSource = conexion.ds.Tables("Venta")

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

    End Sub

    Private Sub btnCancelarVenta_Click(sender As Object, e As EventArgs) Handles btnCancelarVenta.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        MostrarDatos()
    End Sub
End Class