Imports System.Data
Imports System.Data.SqlClient
Public Class Producto

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToLongDateString()
        Label4.Text = DateTime.Now.ToLongTimeString()
        Dim cn As String
        cn = "Data Source=DESKTOP-4NV35QT\SQLEXPRESS;Initial Catalog=BDKanasta;Integrated Security=True"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




    End Sub
End Class