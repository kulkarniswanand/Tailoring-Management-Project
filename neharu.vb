Imports System.Data.OleDb
Public Class neharu
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

    Private Sub neharu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table4] where [neharu_no] =" & Me.ComboBox5.Text & " AND [ID]=" & TextBox11.Text & ""




            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@neharu_no", OleDbType.LongVarChar).Value = Me.ComboBox5.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox11.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox1.Text = myreader("N-collor")
            Me.TextBox2.Text = myreader("N-sholder")
            Me.TextBox3.Text = myreader("N-chest")
            Me.TextBox4.Text = myreader("N-stomoch")
            Me.TextBox5.Text = myreader("N-waist")
            Me.TextBox6.Text = myreader("N-length")
            Me.TextBox7.Text = myreader("N-bottom")
            Me.ComboBox1.Text = myreader("N-collor_sty")
            Me.TextBox13.Text = myreader("N-cut_master")
            Me.TextBox14.Text = myreader("N-worker")
            Me.TextBox8.Text = myreader("N-sl_length")
            Me.TextBox9.Text = myreader("N-wrist")
            Me.TextBox10.Text = myreader("N-bicep")
            Me.TextBox15.Text = myreader("others")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class