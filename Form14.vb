Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text
Imports System.Data.OleDb

Public Class Form14
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim apikey = "MzU3NzU1MzY3ODRhNjQzMTQyNmY1MTUwMzkzOTM5NDc="
            Dim message = "Hii, This is msg from RM Tailors kadegaon. Your Dress is ready. Now you may come and take it."
            Dim numbers = "91" + TextBox3.Text
            Dim strGet As String
            Dim sendername = "RMTALR"
            Dim url As String = "https://api.textlocal.in/send/?"

            strGet = url + "apikey=" + apikey _
            + "&numbers=" + numbers _
            + "&message=" + WebUtility.UrlEncode(message) _
            + "&sender=" + sendername

            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(strGet)
            ' Console.WriteLine(result)
            ' Return result
            MessageBox.Show(result, "information")
        Catch ex As WebException
            MsgBox("you are offline...Please check your internet connection", 30, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
            connstring = con
            c6.ConnectionString = connstring
            c6.Open()


            command = "update [table1] set [status]='" & CheckBox1.CheckState & "',[icom]='" & CheckBox2.CheckState & "' where [id]= " & TextBox9.Text & ""
            Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox9.Text



            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Close()

        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1 where [status] = '1'"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Form2.Label4.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1 where [icom] = '1'"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Form2.Label6.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CheckBox2.CheckState = CheckState.Unchecked
       
    End Sub

  
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
End Class