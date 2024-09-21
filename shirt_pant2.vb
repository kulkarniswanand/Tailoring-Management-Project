
Imports System.Data.OleDb

Public Class shirt_pant2
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim c7 As OleDbConnection = New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        details2.Show()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " update [Table7] set [ID]='" & TextBox11.Text & "',[NAME]='" & TextBox12.Text & "',[S-collor]='" & TextBox1.Text & "',[S-sholder]='" & TextBox2.Text & "',[S-chest]='" & TextBox3.Text & "',[S-stomoch]='" & TextBox4.Text & "',[S-waist]='" & TextBox5.Text & "',[S-length]='" & TextBox6.Text & "',[S-sleeve]='" & TextBox7.Text & "',[S-cuff]='" & TextBox8.Text & "',[S-front]='" & TextBox9.Text & "',[S-pocket]='" & TextBox10.Text & "',[S-bicep]='" & TextBox21.Text & "',[S-collor_sty]='" & ComboBox1.Text & "',[S-cut_sty]='" & ComboBox2.Text & "',[S-sleeve_sty]='" & ComboBox3.Text & "',[S-fiting_sty]='" & ComboBox4.Text & "',[P-height]='" & TextBox20.Text & "',[P-waist]='" & TextBox19.Text & "',[P-seat]='" & TextBox18.Text & "',[P-thigh]='" & TextBox17.Text & "',[P-knee]='" & TextBox16.Text & "',[P-bottom]='" & TextBox15.Text & "',[P-style]='" & ComboBox5.Text & "',[P-pleate]='" & ComboBox8.Text & "',[P-fiting_sty]='" & ComboBox6.Text & "',[S-cut_master]='" & TextBox13.Text & "',[S-worker]='" & TextBox14.Text & "',[shirt_pant_no]='" & ComboBox7.Text & "',[others]='" & TextBox22.Text & "' where [shirt_pant_no]= " & ComboBox7.Text & " AND [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@shirt_pant_no", OleDbType.LongVarChar).Value = ComboBox7.Text
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
            command = " insert into Table7 ([ID],[NAME],[S-collor],[S-sholder],[S-chest],[S-stomoch],[S-waist],[S-length],[S-sleeve],[S-cuff],[S-front],[S-pocket],[S-bicep],[S-collor_sty],[S-cut_sty],[S-sleeve_sty],[S-fiting_sty],[P-height],[P-waist],[P-seat],[P-thigh],[P-knee],[P-bottom],[P-style],[P-pleate],[P-fiting_sty],[S-cut_master],[S-worker],[shirt_pant_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox21.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & TextBox20.Text & "','" & TextBox19.Text & "','" & TextBox18.Text & "','" & TextBox17.Text & "','" & TextBox16.Text & "','" & TextBox15.Text & "','" & ComboBox5.Text & "','" & ComboBox8.Text & "','" & ComboBox6.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox7.Text & "','" & TextBox22.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-collor", CType(TextBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-sholder", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-chest", CType(TextBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-stomoch", CType(TextBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-waist", CType(TextBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-length", CType(TextBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-sleeve", CType(TextBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-cuff", CType(TextBox8.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-front", CType(TextBox9.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-pocket", CType(TextBox10.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-bicep", CType(TextBox21.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-collor_sty", CType(ComboBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-cut_sty", CType(ComboBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-sleeve_sty", CType(ComboBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-fiting_sty", CType(ComboBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-height", CType(TextBox20.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-waist", CType(TextBox19.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-seat", CType(TextBox18.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-thigh", CType(TextBox17.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-knee", CType(TextBox16.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-bottom", CType(TextBox15.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-style", CType(ComboBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-fiting_sty", CType(ComboBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-cut_master", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("S-worker", CType(TextBox14.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("shirt_pant_no", CType(ComboBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-pleate", CType(ComboBox8.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox22.Text, String)))

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

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table7] where [shirt_pant_no] =" & Me.ComboBox7.Text & " AND [ID]=" & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@shirt_pant_no", OleDbType.LongVarChar).Value = Me.ComboBox7.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text
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

        Catch ee As InvalidOperationException
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
            Me.TextBox18.Clear()
            Me.TextBox19.Clear()
            Me.TextBox20.Clear()
            Me.TextBox21.Clear()
            Me.TextBox22.Clear()

            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox4.SelectedIndex = -1
            Me.ComboBox5.SelectedIndex = -1
            Me.ComboBox6.SelectedIndex = -1
            Me.ComboBox8.SelectedIndex = -1

        End Try

    End Sub
End Class