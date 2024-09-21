Imports System.Drawing.Printing
Imports System.Data.OleDb
Public Class Form18
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 0
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 200
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        DataGridView1.Rows.Clear()

        If CheckBox1.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox1.Text, TextBox1.Text, TextBox25.Text)

        End If
        If CheckBox2.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox2.Text, TextBox5.Text, TextBox24.Text)

        End If
        If CheckBox5.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox5.Text, TextBox12.Text, TextBox23.Text)

        End If
        If CheckBox3.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox3.Text, TextBox13.Text, TextBox22.Text)

        End If
        If CheckBox4.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox4.Text, TextBox14.Text, TextBox21.Text)

        End If
        If CheckBox6.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox6.Text, TextBox15.Text, TextBox20.Text)

        End If
        If CheckBox7.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox7.Text, TextBox16.Text, TextBox19.Text)

        End If
        If CheckBox9.Checked Then
            Me.DataGridView1.Rows.Add(CheckBox9.Text, TextBox17.Text, TextBox18.Text)

        End If
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print

    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        'pagesetup.PaperSize = New PaperSize("Custom", 250, 500) 'fixed size
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "--------------------------------------------------------------------------"

        'range from top
        e.Graphics.DrawString("ADCET Tailor Ashta", f14, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("Sangli road Ashta", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("mob:9373409250", f10, Brushes.Black, centermargin, 40, center)

        ' e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 60)
        ' e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        ' e.Graphics.DrawString("DRW8555RE", f8, Brushes.Black, 70, 60)

        ' e.Graphics.DrawString("Cashier", f8, Brushes.Black, 0, 75)
        ' e.Graphics.DrawString(":", f8, Brushes.Black, 50, 75)
        ' e.Graphics.DrawString("Steve Jobs", f8, Brushes.Black, 70, 75)

        'e.Graphics.DrawString("08/17/2021 | 15.34", f8, Brushes.Black, 0, 90)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 100)

        Dim height As Integer 'DGV Position
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        'If DataGridView1.CurrentCell.Value Is Nothing Then
        '    Exit Sub
        'Else
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f10, Brushes.Black, 0, 100 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f10, Brushes.Black, 25, 100 + height)

            i = DataGridView1.Rows(row).Cells(2).Value
            DataGridView1.Rows(row).Cells(2).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f10, Brushes.Black, rightmargin, 100 + height, right)
        Next
        'End If

        Dim height2 As Integer
        height2 = 110 + height
        sumprice() 'call sub
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("Total: " & Format(t_price, "##,##0"), f10b, Brushes.Black, rightmargin, 10 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 0, 10 + height2)
        e.Graphics.DrawString("** Thanks for choosing us **", f10, Brushes.Black, centermargin, 35 + height2, center)
        e.Graphics.DrawString("** RM TAILOR KADEGAON **", f10, Brushes.Black, centermargin, 50 + height2, center)
    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(2).Value * DataGridView1.Rows(rowitem).Cells(1).Value)
        Next
        t_price = countprice

        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + DataGridView1.Rows(rowitem).Cells(1).Value
        Next
        t_qty = countqty
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        print.Show()

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load







    End Sub
End Class
