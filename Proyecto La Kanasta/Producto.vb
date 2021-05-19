
Imports System.Data.SqlClient
Public Class Producto

    Dim connect As SqlConnection = New SqlConnection
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelFecha.Text = DateTime.Now.ToLongDateString()
        laberHora.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click

        Dim product As String = txtProducto.Text
        Dim nombre As String = txtNombre.Text
        Dim precio As Double = txtPrecio.Text
        Dim fecha As String = labelFecha.Text = DateTime.Now.ToLongDateString()
        Dim hora As String = laberHora.Text = DateTime.Now.ToLongDateString()

        Dim query As String = "Insert into Producto values (@product, @nombre, @precio, @fecha, @hora, 1,1)"

        Dim connect As SqlConnection = New SqlConnection("Data Source=DESKTOP-4NV35QT\SQLEXPRESS;Initial Catalog=BDKanasta;Integrated Security=True")

        Using cmd As SqlCommand = New SqlCommand(query)
            cmd.Parameters.AddWithValue("@product", product)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@precio", precio)
            'cmd.Parameters.AddWithValue("@fecha", fecha)
            'cmd.Parameters.AddWithValue("@hora", hora)
            connect.Open()
            cmd.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Agragado")
        End Using
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub labelFecha_Click(sender As Object, e As EventArgs) Handles labelFecha.Click

    End Sub
End Class