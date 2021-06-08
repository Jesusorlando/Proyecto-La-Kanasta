Public Class Corte_caja
    Dim conexion As Conexion = New Conexion()

    Dim TotalVenta As Decimal




    Sub CargarTotalDia()

        Try
            conexion.Consulta("SELECT SUM(total) from Venta2 WHERE fecha = cast(getdate() as Date)", "Total")

            TotalVenta = conexion.ds.Tables("Total").Rows(0).ItemArray(0)

            txtTotal.Text = TotalVenta.ToString()

        Catch
            MessageBox.Show("No se han generado ventas el dia de hoy :c")
        End Try
    End Sub



    Sub CalcularDiferencia()
        Dim efectivo = txtEfectivo.Value

        txtDiferencia.Text = (TotalVenta - efectivo).ToString()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTotalDia()
    End Sub

    Private Sub txtEfectivo_ValueChanged(sender As Object, e As EventArgs) Handles txtEfectivo.ValueChanged
        CalcularDiferencia()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub txtEfectivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEfectivo.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsPunctuation(e.KeyChar) Then
            MsgBox("Solo Puede digitar numeros")
        End If
    End Sub


End Class
