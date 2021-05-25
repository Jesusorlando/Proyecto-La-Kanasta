Imports System.Data.SqlClient

Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=DESKTOP-4NV35QT\SQLEXPRESS;Initial Catalog=BDKanasta;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public Sub conectar()
        Try
            conexion.Open()
            Console.WriteLine("Conectado")

        Catch ex As Exception
            MessageBox.Show("No Conectado")

        Finally
            conexion.Close()

        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Instertar(ByVal sql)
        conexion.Open()
        comando = New SqlCommand(sql, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub LimpiarCampos(ByVal control As Form)
        Dim txt As Object
        Dim txtTemporal As TextBox

        For Each txt In control.Controls
            If TypeOf txt Is TextBox Then
                txtTemporal = CType(txt, TextBox)
                txtTemporal.Clear()
            End If

        Next

    End Sub


End Class
