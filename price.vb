Imports System.Data.OleDb
Public Class price
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " update [Table10] set [shirt]='" & TextBox1.Text & "',[pant]='" & TextBox2.Text & "',[wizar]='" & TextBox3.Text & "',[neharu_shirt]='" & TextBox4.Text & "',[3_button_shirt]='" & TextBox5.Text & "',[shirt_and_pant]='" & TextBox6.Text & "',[neharu_wizar]='" & TextBox7.Text & "',[kurta_pant]='" & TextBox8.Text & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)


        MsgBox("Price updated successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub price_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class