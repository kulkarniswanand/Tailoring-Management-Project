Imports System.Data.OleDb
Public Class neharu_wizar2
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim c7 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 1
    Dim result As DialogResult
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        details2.Show()
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table8] where [ne_wi_no] =" & Me.ComboBox7.Text & " AND [ID]=" & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ne_wi_no", OleDbType.LongVarChar).Value = Me.ComboBox7.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text
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
            Me.TextBox15.Text = myreader("height")
            Me.TextBox10.Text = myreader("bottom")
            Me.ComboBox2.Text = myreader("style")
            Me.TextBox13.Text = myreader("N-cut_master")
            Me.TextBox14.Text = myreader("N-worker")
            Me.TextBox16.Text = myreader("N-sl_length")
            Me.TextBox8.Text = myreader("N-bicep")
            Me.TextBox9.Text = myreader("N-wrist")
            Me.TextBox17.Text = myreader("others")



            conn.Close()
        Catch ex As InvalidOperationException
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
            Me.TextBox3.Clear()
            Me.TextBox4.Clear()
            Me.TextBox5.Clear()
            Me.TextBox6.Clear()
            Me.TextBox7.Clear()
            Me.TextBox8.Clear()
            Me.TextBox9.Clear()
            Me.TextBox10.Clear()
            Me.TextBox11.Clear()
            Me.TextBox12.Clear()
            Me.TextBox13.Clear()
            Me.TextBox14.Clear()
            Me.TextBox15.Clear()
            Me.TextBox16.Clear()
            Me.TextBox17.Clear()


            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox2.SelectedIndex = -1
           
        End Try


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " update [Table8] set [ID]='" & TextBox11.Text & "',[NAME]='" & TextBox12.Text & "',[N-collor]='" & TextBox1.Text & "',[N-sholder]='" & TextBox2.Text & "',[N-chest]='" & TextBox3.Text & "',[N-stomoch]='" & TextBox4.Text & "',[N-waist]='" & TextBox5.Text & "',[N-length]='" & TextBox6.Text & "',[N-bottom]='" & TextBox7.Text & "',[N-collor_sty]='" & ComboBox1.Text & "',[height]='" & TextBox15.Text & "',[bottom]='" & TextBox10.Text & "',[style]='" & ComboBox2.Text & "',[N-cut_master]='" & TextBox13.Text & "',[N-worker]='" & TextBox14.Text & "',[ne_wi_no]='" & ComboBox7.Text & "',[others]='" & TextBox17.Text & "',[N-sl_length]='" & TextBox16.Text & "',[N-wrist]='" & TextBox8.Text & "',[N-bicep]='" & TextBox9.Text & "' where [ne_wi_no]= " & ComboBox7.Text & " AND [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@ne_wi_no", OleDbType.LongVarChar).Value = ComboBox7.Text
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
            command = " insert into Table8 ([ID],[NAME],[N-collor],[N-sholder],[N-chest],[N-stomoch],[N-waist],[N-length],[N-bottom],[N-collor_sty],[height],[bottom],[style],[N-cut_master],[N-worker],[ne_wi_no],[others],[N-sl_length],[N-wrist],[N-bicep]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox1.Text & "','" & TextBox15.Text & "','" & TextBox10.Text & "','" & ComboBox2.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox7.Text & "','" & TextBox17.Text & "','" & TextBox16.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-collor", CType(TextBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-sholder", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-chest", CType(TextBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-stomoch", CType(TextBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-waist", CType(TextBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-length", CType(TextBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-bottom", CType(TextBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-collor_sty", CType(ComboBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("height", CType(TextBox15.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("bottom", CType(TextBox10.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("style", CType(ComboBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-cut_master", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-worker", CType(TextBox14.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("ne_wi_no", CType(ComboBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox17.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-sl_length", CType(TextBox16.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-wrist", CType(TextBox9.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("N-bicep", CType(TextBox8.Text, String)))


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