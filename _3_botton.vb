Imports System.Data.OleDb
Public Class _3_botton
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

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table5] where [3_button_no] =" & Me.ComboBox5.Text & " AND [ID]=" & TextBox11.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@3_button_no", OleDbType.LongVarChar).Value = Me.ComboBox5.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox11.Text


            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox1.Text = myreader("collor")
            Me.TextBox2.Text = myreader("sholder")
            Me.TextBox3.Text = myreader("chest")
            Me.TextBox6.Text = myreader("length")
            Me.TextBox7.Text = myreader("sleeve")
            Me.TextBox8.Text = myreader("cuff")
            Me.TextBox9.Text = myreader("front")
            Me.TextBox10.Text = myreader("pocket")

            Me.TextBox13.Text = myreader("cut_master")
            Me.TextBox14.Text = myreader("worker")
            Me.TextBox4.Text = myreader("others")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub _3_botton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class