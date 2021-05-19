
Imports System.Data.SqlClient
Public Class Producto

    Dim connect As SqlConnection = New SqlConnection

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click


    End Sub

    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DateTimePicker1.Visible = False
    End Sub

    Private Sub labelFecha_Click(sender As Object, e As EventArgs) Handles labelFecha.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        labelFecha.Text = fecha
    End Sub
End Class