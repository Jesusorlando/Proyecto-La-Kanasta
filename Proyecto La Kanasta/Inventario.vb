Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO

Public Class Inventario

    Dim conexion As Conexion = New Conexion()

    Public Sub MostrarDatos()
        conexion.Consulta("select idProducto , SUM(pe.Cantidad) as 'Cantidad' from ProductosEntrada pe group by idProducto", "Inventario")
        DataGridView1.DataSource = conexion.ds.Tables("Inventario")

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dispose()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()

    End Sub

    Private Sub btnPDF_Click(sender As Object, e As EventArgs) Handles btnPDF.Click
        'Dim pdfdoc As New Document()
        'Dim pdfwrite As PdfWriter = PdfWriter.GetInstance(pdfdoc, New FileStream("c:\users\orlan\onedrive\escritorio/simple.pdf", FileMode.Create))

        'pdfdoc.Open()
        'pdfdoc.Add(New Paragraph("hello word"))
        'pdfdoc.NewPage()
        'pdfdoc.Add(New Paragraph("new hello word"))
        'pdfdoc.Close()

        Try

            Dim sfd As New SaveFileDialog With {.Filter = "PDF Files (*.pdf) | *.pdf"}
            sfd.FileName = "Inventario-PDF"
            If sfd.ShowDialog = 1 Then
                Dim doc As New Document(PageSize.A4, 40, 40, 80, 20)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(sfd.FileName, FileMode.Create))
                Dim pColumn As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK)
                Dim pRow As New Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK)

                Dim pdftable As New PdfPTable(2) ' Number of columns
                pdftable.TotalWidth = 550.0F
                pdftable.LockedWidth = True
                pdftable.HorizontalAlignment = Element.ALIGN_CENTER
                pdftable.HeaderRows = 1

                Dim widths As Single() = New Single() {0.4F, 1.0F}
                pdftable.SetWidths(widths)


                Dim pdfcell As PdfPCell = Nothing

                doc.Open()
                pdfcell = New PdfPCell(New Paragraph("Producto", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.MinimumHeight = 18
                pdfcell.PaddingLeft = 5.0F
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                pdfcell = New PdfPCell(New Paragraph("Cantidad", pColumn))
                pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                pdfcell.MinimumHeight = 18
                pdfcell.PaddingLeft = 5.0F
                pdfcell.BackgroundColor = BaseColor.LIGHT_GRAY
                pdftable.AddCell(pdfcell)

                Dim imagenURL As String = "C:\Users\orlan\OneDrive\Escritorio\Proyecto La Kanasta\Proyecto La Kanasta\My Project/unnamed.png"
                Dim imagenBMP As iTextSharp.text.Image
                imagenBMP = iTextSharp.text.Image.GetInstance(imagenURL)
                imagenBMP.ScaleToFit(100.0F, 140.0F)
                imagenBMP.SpacingBefore = 20.0F
                imagenBMP.SpacingAfter = 10.0F
                imagenBMP.SetAbsolutePosition(100, 750)



                Dim encabezado As New Paragraph("PRODUCTOS INVENTARIO", New Font(Font.Name = "Tahoma", 20, Font.Bold))

                'Se crea el texto abajo del encabezado.
                Dim texto As New Phrase("Reporte productos:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))

                Dim dt As DataTable = GetDateTable()

                For i = 0 To dt.Rows.Count - 1
                    For j = 0 To dt.Columns.Count - 1
                        pdfcell = New PdfPCell(New Paragraph(dt.Rows(i)(j).ToString, pRow))
                        pdfcell.MinimumHeight = 18
                        pdfcell.PaddingLeft = 5.0F
                        pdfcell.HorizontalAlignment = Element.ALIGN_LEFT
                        pdftable.AddCell(pdfcell)
                    Next
                Next

                doc.Add(imagenBMP)
                doc.Add(encabezado)
                doc.Add(texto)
                doc.Add(pdftable)
                doc.Close()

                MsgBox("PDF Creado con exito!" & sfd.FileName, vbInformation)
                Process.Start(sfd.FileName)

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    Private Function GetDateTable()

        Try


            Dim datatable As New DataTable("dt")
            Dim datacolumn1 As New DataColumn(DataGridView1.Columns(0).HeaderText.ToString, GetType(String))
            Dim datacolumn2 As New DataColumn(DataGridView1.Columns(1).HeaderText.ToString, GetType(String))

            datatable.Columns.Add(datacolumn1)
            datatable.Columns.Add(datacolumn2)

            Dim row As DataRow
            For i = 0 To DataGridView1.Rows.Count - 1
                row = datatable.NewRow
                row(datacolumn1) = DataGridView1.Rows(i).Cells(0).Value.ToString
                row(datacolumn2) = DataGridView1.Rows(i).Cells(1).Value.ToString
                datatable.Rows.Add(row)
            Next
            datatable.AcceptChanges()
            Return datatable


        Catch ex As Exception
            MessageBox.Show("Error")

        End Try
    End Function
End Class