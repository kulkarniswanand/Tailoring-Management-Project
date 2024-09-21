Imports System.Data.OleDb
Public Class kurta2
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 1
    Dim result As DialogResult
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        details.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table9] where [kurta_pant_no] =" & Me.ComboBox4.Text & " AND [ID]= " & TextBox11.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@kurta_pant_no", OleDbType.LongVarChar).Value = Me.ComboBox4.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox11.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox1.Text = myreader("K-collor")
            Me.TextBox3.Text = myreader("K-chest")
            Me.TextBox4.Text = myreader("K-stomoch")
            Me.TextBox5.Text = myreader("K-waist")
            Me.TextBox7.Text = myreader("K-hip")
            Me.TextBox6.Text = myreader("K-sleeve")
            Me.ComboBox1.Text = myreader("K-sl_style")
            Me.TextBox9.Text = myreader("K-cuff_wrist")
            Me.TextBox2.Text = myreader("K-regular_wrist")
            Me.ComboBox3.Text = myreader("K-pocket_sty")
            Me.TextBox15.Text = myreader("waist")
            Me.TextBox10.Text = myreader("seat")
            Me.TextBox18.Text = myreader("thigh")
            Me.TextBox8.Text = myreader("knee")
            Me.TextBox16.Text = myreader("bottom")
            Me.ComboBox2.Text = myreader("style")
            Me.TextBox13.Text = myreader("cutting-mst")
            Me.TextBox14.Text = myreader("worker")
            Me.TextBox17.Text = myreader("others")
            Me.ComboBox4.Text = myreader("kurta_pant_no")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class