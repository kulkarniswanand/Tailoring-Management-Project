Imports System.Data.OleDb
Public Class pant
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form3.Show()
    End Sub

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " insert into Table3 ([ID],[NAME],[P-height],[P-waist],[P-seat],[P-thigh],[P-knee],[P-bottom],[P-style],[pleate],[P-fiting_sty],[P-cutting_master],[P-worker],[pant_no],[in_seam],[pocket_sty],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox7.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox8.Text & "','" & ComboBox2.Text & "','" & TextBox9.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-height", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-waist", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-seat", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-thigh", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-knee", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-bottom", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-style", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("pleate", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-fiting_sty", CType(ComboBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-cutting_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("pant_no", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("in_seam", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("pocket_sty", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox9.Text, String)))
       
        MsgBox("Measurements saved successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox13.Clear()
        TextBox14.Clear()

        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1


    End Sub
End Class