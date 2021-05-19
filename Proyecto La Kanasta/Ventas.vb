Public Class Ventas
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblFecha.Text = DateTime.Now.ToLongDateString
        lblHora.Text = DateTime.Now.ToLongTimeString


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblFecha.Text = DateTime.Now.ToLongDateString
        lblHora.Text = DateTime.Now.ToLongTimeString

    End Sub
End Class