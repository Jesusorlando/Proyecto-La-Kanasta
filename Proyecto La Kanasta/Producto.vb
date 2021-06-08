
Imports System.Data.SqlClient
Public Class Producto

    Dim conexion As Conexion = New Conexion()




    Public Sub MostrarDatos()
        conexion.Consulta("select idProducto, Nombre, Fecha, Precio  from Producto  ", "Productos")
        DataGridView1.DataSource = conexion.ds.Tables("Productos")

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click

        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
        Dim cantidad As Integer = 1

        Try

            Dim cnx = New Conexion()
            Dim valido = txtNombre.Text
            cnx.Consulta($"select nombre from producto where nombre = '{valido}' ", "lal")

            If (cnx.ds.Tables("lal").Rows.Count > 0) Then
                MessageBox.Show("El producto ya existe :(")

            Else

                If (txtNombre.Text = "" Or txtPrecio.Text = "" Or txtProducto.Text = "") Then

                    MessageBox.Show("No se aceptan campos vacios :D")

                Else

                    Dim Agregar As String = $"Insert into Producto values ('{txtProducto.Text}','{txtNombre.Text}',{cbState.Text},'{fecha}',{txtPrecio.Text},{cbMedida.Text},{cantidad} )"

                    If (conexion.Instertar(Agregar)) Then
                        MessageBox.Show("Datos agregados correctamente")
                        MostrarDatos()

                    Else
                        MessageBox.Show("Error al agregar")
                    End If

                    Dim limpiar As Conexion = New Conexion
                    limpiar.LimpiarCampos(Me)

                End If
            End If
        Catch x As Exception
            MessageBox.Show("No se admiten caracteres "" '' ")
        End Try
    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DateTimePicker1.Visible = False
        cbState.Visible = False
        cbMedida.Visible = False
        conexion.conectar()
        MostrarDatos()
        ComboBox1.Items.Add("Pieza")
        ComboBox1.Items.Add("Gramos")
        ComboBox1.Items.Add("Litros")
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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub
End Class