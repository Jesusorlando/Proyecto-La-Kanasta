Imports System.Data.SqlClient

Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source=tcp:192.168.100.21\SQLEXPRESS,1444;Initial Catalog=BDKanasta;Persist Security Info=True;User ID=admin;Password=12345")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand
    Public Sub conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

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
End Class
