<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Corte_caja
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Corte_caja))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.txtDiferencia = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtEfectivo = New System.Windows.Forms.NumericUpDown()
        CType(Me.txtEfectivo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe de saldo final de caja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(199, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Saldo final Autorizado por el sistema"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Diferiencia de Caja. Esta faltando"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Observaciones"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button1.Location = New System.Drawing.Point(108, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 42)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Cerrar Caja"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(316, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 33)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(152, 300)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(167, 81)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(297, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(228, 23)
        Me.DateTimePicker1.TabIndex = 8
        '
        'txtDiferencia
        '
        Me.txtDiferencia.Location = New System.Drawing.Point(152, 244)
        Me.txtDiferencia.Name = "txtDiferencia"
        Me.txtDiferencia.ReadOnly = True
        Me.txtDiferencia.Size = New System.Drawing.Size(172, 23)
        Me.txtDiferencia.TabIndex = 10
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(152, 170)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(172, 23)
        Me.txtTotal.TabIndex = 11
        '
        'txtEfectivo
        '
        Me.txtEfectivo.Location = New System.Drawing.Point(152, 88)
        Me.txtEfectivo.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtEfectivo.Name = "txtEfectivo"
        Me.txtEfectivo.Size = New System.Drawing.Size(172, 23)
        Me.txtEfectivo.TabIndex = 12
        '
        'Corte_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSalmon
        Me.ClientSize = New System.Drawing.Size(537, 488)
        Me.Controls.Add(Me.txtEfectivo)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtDiferencia)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Corte_caja"
        Me.Text = "Corte Caja"
        CType(Me.txtEfectivo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents txtDiferencia As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtEfectivo As NumericUpDown
End Class
