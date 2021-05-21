Imports System.Data.SqlClient
Public Class Perdida

    Dim conexion As Conexion = New Conexion()
    Public Sub MostrarDatos()
        conexion.Consulta("select a.idProducto, a.Cantidad, b.Precio  from Detalle_Perdida a, Producto b  where a.idProducto = b.idProducto ", "DPerdida")
        DataGridView1.DataSource = conexion.ds.Tables("DPerdida")

    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Dim uno As Int16
        uno = 5

        MessageBox.Show("insert into Detalle_entrada values ('" + uno + "','" + txtidProducto.Text + "','" + uno + "') ")


        ' Dim Agregar As String = "insert into Detalle_entrada values ('" + 2 + "','" + TextBox1.Text + "','" + 2 + "')"


        'If (conexion.Instertar(Agregar)) Then
        'MessageBox.Show("Datos agregados correctamente")
        '   MostrarDatos()

        'Else
        '    MessageBox.Show("Error al agregar")
        'End If

    End Sub

    Private Sub Perdida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
        conexion.conectar()
        Dim fecha As String = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        Dim Agregar As String = "Insert into (idPerdida, idProducto, Cantidad) Detalle_Perdida values ('" + 2 + "','" + txtidProducto.Text + "','" + 2 + "')"

        If (conexion.Instertar(Agregar)) Then
            MessageBox.Show("Datos agregados correctamente")

        Else
            MessageBox.Show("Error al agregar")
        End If

    End Sub
End Class