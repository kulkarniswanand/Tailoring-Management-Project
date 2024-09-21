Imports System.Data.OleDb
Public Class pant3
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
        command = " update [Table3] set [ID]='" & TextBox11.Text & "',[NAME]='" & TextBox12.Text & "',[P-height]='" & TextBox7.Text & "',[P-waist]='" & TextBox2.Text & "',[P-seat]='" & TextBox3.Text & "' ,[P-thigh]='" & TextBox4.Text & "' ,[P-knee]='" & TextBox5.Text & "' ,[P-bottom]='" & TextBox6.Text & "' ,[P-style]= '" & ComboBox1.Text & "',[P-fiting_sty]='" & ComboBox4.Text & "' ,[P-cutting_master]='" & TextBox13.Text & "' ,[P-worker]= '" & TextBox14.Text & "',[pleate]= '" & ComboBox3.Text & "' , [others]= '" & TextBox9.Text & "'  where [pant_no]= " & ComboBox5.Text & " AND [ID]= " & Me.TextBox11.Text & ""
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add("@pant_no", OleDbType.LongVarChar).Value = ComboBox5.Text
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
            command = " insert into Table3 ([ID],[NAME],[P-height],[P-waist],[P-seat],[P-thigh],[P-knee],[P-bottom],[P-style],[pleate],[P-fiting_sty],[P-cutting_master],[P-worker],[pant_no],[in_seam],[pocket_sty],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox8.Text & "','" & ComboBox2.Text & "','" & TextBox9.Text & "')"
            Dim cmp As OleDbCommand = New OleDbCommand(command, c7)
            cmp.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-height", CType(TextBox7.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-waist", CType(TextBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-seat", CType(TextBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-thigh", CType(TextBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-knee", CType(TextBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-bottom", CType(TextBox6.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-style", CType(ComboBox1.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("pleate", CType(ComboBox3.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-fiting_sty", CType(ComboBox4.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-cutting_master", CType(TextBox13.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("P-worker", CType(TextBox14.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("pant_no", CType(ComboBox5.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("in_seam", CType(TextBox8.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("pocket_sty", CType(ComboBox2.Text, String)))
            cmp.Parameters.Add(New OleDbParameter("others", CType(TextBox9.Text, String)))


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

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from [Table3] where [pant_no] =" & Me.ComboBox5.Text & " AND [ID]= " & details2.TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@pant_no", OleDbType.LongVarChar).Value = Me.ComboBox5.Text
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = details2.TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Me.TextBox11.Text = myreader("ID")
            Me.TextBox12.Text = myreader("NAME")
            Me.TextBox7.Text = myreader("P-height")
            Me.TextBox2.Text = myreader("P-waist")
            Me.TextBox3.Text = myreader("P-seat")
            Me.TextBox4.Text = myreader("P-thigh")
            Me.TextBox5.Text = myreader("P-knee")
            Me.TextBox6.Text = myreader("P-bottom")
            Me.ComboBox1.Text = myreader("P-style")
            Me.ComboBox4.Text = myreader("P-fiting_sty")
            Me.TextBox13.Text = myreader("P-cutting_master")
            Me.TextBox14.Text = myreader("P-worker")
            Me.TextBox9.Text = myreader("others")
            Me.ComboBox3.Text = myreader("pleate")
            conn.Close()

        Catch ex As InvalidOperationException
            Me.TextBox2.Clear()
            Me.TextBox3.Clear()
            Me.TextBox4.Clear()
            Me.TextBox5.Clear()
            Me.TextBox6.Clear()
            Me.TextBox7.Clear()
            Me.TextBox8.Clear()
            Me.TextBox9.Clear()

            Me.TextBox11.Clear()
            Me.TextBox12.Clear()
            Me.TextBox13.Clear()
            Me.TextBox14.Clear()
            Me.ComboBox1.SelectedIndex = -1
            Me.ComboBox2.SelectedIndex = -1
            Me.ComboBox3.SelectedIndex = -1
            Me.ComboBox4.SelectedIndex = -1

        End Try
    End Sub

    Private Sub pant3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class