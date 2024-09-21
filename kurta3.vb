Imports System.Data.OleDb

Public Class kurta3
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
        command = " update [Table9] set [ID]='" & TextBox11.Text & "', [NAME]='" & TextBox12.Text & "',[K-collor]='" & TextBox1.Text & "' ,[K-chest]='" & TextBox3.Text & "', [K-stomoch]='" & TextBox4.Text & "', [K-waist]='" & TextBox5.Text & "', [K-hip]='" & TextBox7.Text & "', [K-Sleeve]='" & TextBox6.Text & "', [K-sl_style]='" & ComboBox1.Text & "', [K-cuff_wrist]='" & TextBox9.Text & "',  [K-regular_wrist]='" & TextBox2.Text & "', [K-pocket_sty]='" & ComboBox3.Text & "', [waist]='" & TextBox15.Text & "', [seat]='" & TextBox10.Text & "', [thigh]='" & TextBox18.Text & "', [knee]='" & TextBox8.Text & "', [bottom]='" & TextBox16.Text & "', [style]='" & ComboBox2.Text & "', [cutting-mst]='" & TextBox13.Text & "', [worker]='" & TextBox14.Text & "', [others]='" & TextBox17.Text & "', [kurta_pant_no]='" & ComboBox4.Text & "'   where [kurta_pant_no]= " & ComboBox4.Text & " AND [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox11.Text
        cmd.Parameters.Add("@kurta_pant_no", OleDbType.LongVarChar).Value = ComboBox4.Text

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
            command = " insert into Table9 ([ID], [NAME],[K-collor] ,[K-chest], [K-stomoch], [K-waist], [K-hip], [K-Sleeve], [K-sl_style], [K-cuff_wrist],  [K-regular_wrist], [K-pocket_sty], [waist], [seat], [thigh], [knee], [bottom], [style], [cutting-mst], [worker], [others], [kurta_pant_no]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "','" & TextBox2.Text & "','" & ComboBox3.Text & "','" & TextBox15.Text & "','" & TextBox10.Text & "','" & TextBox18.Text & "','" & TextBox8.Text & "','" & TextBox16.Text & "','" & ComboBox2.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox17.Text & "','" & ComboBox4.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-collor", CType(TextBox1.Text, String)))

            cmp.Parameters.Add(New OleDbParameter("K-chest", CType(TextBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-stomoch", CType(TextBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-waist", CType(TextBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-hip", CType(TextBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-sleeve", CType(TextBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-sl_style", CType(ComboBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-cuff_wrist", CType(TextBox9.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-regular_wrist", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("K-pocket_sty", CType(ComboBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("waist", CType(TextBox15.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("seat", CType(TextBox10.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("thigh", CType(TextBox18.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("knee", CType(TextBox8.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("bottom", CType(TextBox16.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("style", CType(ComboBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("cutting-mst", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))


            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox17.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("kurta_pant_no", CType(ComboBox4.Text, String)))


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

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table9] where [kurta_pant_no] =" & Me.ComboBox4.Text & " AND [ID]= " & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@kurta_pant_no", OleDbType.LongVarChar).Value = Me.ComboBox4.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text

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
            Me.TextBox18.Clear()
            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox7.SelectedIndex = -1



        End Try
    End Sub
End Class