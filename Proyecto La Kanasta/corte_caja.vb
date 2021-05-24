Public Class Corte_caja
    Dim conexion As Conexion = New Conexion()

    Dim TotalVenta As Decimal

    Sub CargarTotalDia()
        conexion.Consulta("SELECT SUM(total) from Venta2 WHERE fecha = cast(getdate() as Date)", "Total")

        TotalVenta = conexion.ds.Tables("Total").Rows(0).ItemArray(0)

        txtTotal.Text = TotalVenta.ToString()
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
End Class
