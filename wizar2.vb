

Imports System.Data.OleDb
Public Class wizar2
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim c7 As OleDbConnection = New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        details2.Show()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table6] where [wizar_no] =" & Me.ComboBox5.Text & " AND [ID]= " & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@wizar_no", OleDbType.LongVarChar).Value = Me.ComboBox5.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text


            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox1.Text = myreader("height")
            Me.TextBox2.Text = myreader("bottom")
            Me.ComboBox1.Text = myreader("style")
            Me.TextBox13.Text = myreader("cut_master")
            Me.TextBox14.Text = myreader("worker")
            Me.TextBox15.Text = myreader("others")
            conn.Close()

        Catch ee As InvalidOperationException
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
          
            Me.TextBox11.Clear()
            Me.TextBox12.Clear()
            Me.TextBox13.Clear()
            Me.TextBox14.Clear()
            Me.TextBox15.Clear()

            Me.ComboBox1.SelectedIndex = -1
           


        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " update [Table6] set [ID]='" & TextBox11.Text & "',[name]='" & TextBox12.Text & "',[height]='" & TextBox1.Text & "',[bottom]='" & TextBox2.Text & "',[style]='" & ComboBox1.Text & "',[cut_master]='" & TextBox13.Text & "',[worker]='" & TextBox14.Text & "',[wizar_no]='" & ComboBox5.Text & "',[others]='" & TextBox15.Text & "'  where [wizar_no]= " & ComboBox5.Text & " AND [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@wizar_no", OleDbType.LongVarChar).Value = ComboBox5.Text
        cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox11.Text
        MsgBox("Measurements Updated successfully")

        Try
            cmd.ExecuteNonQuery()

            cmd.Dispose()
            c6.Close()



        Catch ex As FormatException
            TextBox11.Text = details2.TextBox9.Text
            TextBox12.Text = details2.TextBox2.Text
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
            connstring = con
            c7.ConnectionString = connstring
            c7.Open()
            command = " insert into Table6 ([ID],[name],[height],[bottom],[style],[cut_master],[worker],[wizar_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox15.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("name", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("height", CType(TextBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("bottom", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("style", CType(ComboBox1.Text, String)))


            cmp.Parameters.Add(New OleDbParameter("cut_master", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("wizar_no", CType(ComboBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox15.Text, String)))


            Try
                cmp.ExecuteNonQuery()
                cmp.Dispose()
                c7.Close()
                c6.Close()


            Catch ee As Exception
                MsgBox(ee.Message)
            End Try
        End Try
    End Sub
End Class