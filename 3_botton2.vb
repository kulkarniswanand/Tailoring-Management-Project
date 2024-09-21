Imports System.Data.OleDb

Public Class _3_botton2
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim c7 As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " update [Table5] set [ID]='" & TextBox11.Text & "',[name]='" & TextBox12.Text & "',[collor]='" & TextBox1.Text & "',[sholder]='" & TextBox2.Text & "',[chest]='" & TextBox3.Text & "',[length]='" & TextBox6.Text & "',[sleeve]='" & TextBox7.Text & "',[cuff]='" & TextBox8.Text & "',[front]='" & TextBox9.Text & "',[pocket]='" & TextBox10.Text & "',[cut_master]='" & TextBox13.Text & "',[worker]='" & TextBox14.Text & "',[3_button_no]= '" & ComboBox1.Text & "', [others]= '" & TextBox4.Text & "'  where [3_button_no]= " & ComboBox1.Text & " AND  [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@3_button_no", OleDbType.LongVarChar).Value = Me.ComboBox1.Text
        cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox11.Text
        MsgBox("Measurements updated successfully")
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
            command = " insert into Table5 ([ID],[name],[collor],[sholder],[chest],[length],[sleeve],[cuff],[front],[pocket],[cut_master],[worker],[3_button_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("name", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("collor", CType(TextBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("sholder", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("chest", CType(TextBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("length", CType(TextBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("sleeve", CType(TextBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("cuff", CType(TextBox8.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("front", CType(TextBox9.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("pocket", CType(TextBox10.Text, String)))



            cmp.Parameters.Add(New OleDbParameter("cut_master", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("3_button_no", CType(ComboBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox4.Text, String)))

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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        details2.Show()
    End Sub

  
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table5] where [3_button_no] =" & Me.ComboBox1.Text & " AND [ID]=" & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@3_button_no", OleDbType.LongVarChar).Value = Me.ComboBox1.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text


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
        Catch ee As InvalidOperationException
            Me.TextBox1.Clear()
            Me.TextBox2.Clear()
            Me.TextBox3.Clear()
            Me.TextBox4.Clear()

            Me.TextBox6.Clear()
            Me.TextBox7.Clear()
            Me.TextBox8.Clear()
            Me.TextBox9.Clear()
            Me.TextBox10.Clear()
            Me.TextBox11.Clear()
            Me.TextBox12.Clear()
            Me.TextBox13.Clear()
            Me.TextBox14.Clear()


          

          


        End Try
    End Sub
End Class