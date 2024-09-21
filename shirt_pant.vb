Imports System.Data.OleDb
Public Class shirt_pant
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 1
    Dim result As DialogResult
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        details.Show()
    End Sub

    Private Sub shirt_pant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table7] where [shirt_pant_no] =" & Me.ComboBox7.Text & " AND [ID]=" & TextBox11.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@shirt_pant_no", OleDbType.LongVarChar).Value = Me.ComboBox7.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox11.Text
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox1.Text = myreader("S-collor")
            Me.TextBox2.Text = myreader("S-sholder")
            Me.TextBox3.Text = myreader("S-chest")
            Me.TextBox4.Text = myreader("S-stomoch")
            Me.TextBox5.Text = myreader("S-waist")
            Me.TextBox6.Text = myreader("S-length")
            Me.TextBox7.Text = myreader("S-sleeve")
            Me.TextBox8.Text = myreader("S-cuff")
            Me.TextBox9.Text = myreader("S-front")
            Me.TextBox10.Text = myreader("S-pocket")
            Me.TextBox21.Text = myreader("S-bicep")
            Me.ComboBox1.Text = myreader("S-collor_sty")
            Me.ComboBox2.Text = myreader("S-cut_sty")
            Me.ComboBox3.Text = myreader("S-sleeve_sty")
            Me.ComboBox4.Text = myreader("S-fiting_sty")
            Me.TextBox20.Text = myreader("P-height")
            Me.TextBox19.Text = myreader("P-waist")
            Me.TextBox18.Text = myreader("P-seat")
            Me.TextBox17.Text = myreader("P-thigh")
            Me.TextBox16.Text = myreader("P-knee")
            Me.TextBox15.Text = myreader("P-bottom")
            Me.ComboBox5.Text = myreader("P-style")
            Me.ComboBox8.Text = myreader("P-pleate")
            Me.ComboBox6.Text = myreader("P-fiting_sty")
            Me.TextBox13.Text = myreader("S-cut_master")
            Me.TextBox14.Text = myreader("S-worker")

            Me.TextBox22.Text = myreader("others")
            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class