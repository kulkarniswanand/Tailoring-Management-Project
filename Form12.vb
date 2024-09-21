Imports System.Data.OleDb
Public Class Form12
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
        command = " insert into Table8 ([ID],[NAME],[N-collor],[N-sholder],[N-chest],[N-stomoch],[N-waist],[N-length],[N-bottom],[N-collor_sty],[height],[bottom],[style],[N-cut_master],[N-worker],[ne_wi_no],[others],[N-sl_length],[N-wrist],[N-bicep]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & ComboBox1.Text & "','" & TextBox15.Text & "','" & TextBox10.Text & "','" & ComboBox2.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox7.Text & "','" & TextBox17.Text & "','" & TextBox16.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-collor", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-sholder", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-chest", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-stomoch", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-waist", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-length", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-bottom", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-collor_sty", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("height", CType(TextBox15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("bottom", CType(TextBox10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("style", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-cut_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("ne_wi_no", CType(ComboBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox17.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-sl_length", CType(TextBox16.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-wrist", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("N-bicep", CType(TextBox8.Text, String)))

        MsgBox("Measurements saved successfully", MsgBoxStyle.ApplicationModal, 20)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class