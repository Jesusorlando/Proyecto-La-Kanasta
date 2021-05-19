Public Class Ventas


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm = New Form3()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm = New Empleado()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm = New Producto()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim frm = New Corte_caja()
        frm.Location = Me.Location
        frm.StartPosition = FormStartPosition.Manual
        frm.Show()
    End Sub

    Private Sub lblHora_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        DateTimePicker1.Visible = False
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim fecha As String
        fecha = DateTimePicker1.Text
        Label16.Text = fecha
    End Sub
End Class