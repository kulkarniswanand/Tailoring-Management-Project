Imports System.Data.OleDb
Public Class Form11
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged

    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form3.Show()
    End Sub

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " insert into Table7 ([ID],[NAME],[S-collor],[S-sholder],[S-chest],[S-stomoch],[S-waist],[S-length],[S-sleeve],[S-cuff],[S-front],[S-pocket],[S-bicep],[S-collor_sty],[S-cut_sty],[S-sleeve_sty],[S-fiting_sty],[P-height],[P-waist],[P-seat],[P-thigh],[P-knee],[P-bottom],[P-style],[P-pleate],[P-fiting_sty],[S-cut_master],[S-worker],[shirt_pant_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox21.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & TextBox20.Text & "','" & TextBox19.Text & "','" & TextBox18.Text & "','" & TextBox17.Text & "','" & TextBox16.Text & "','" & TextBox15.Text & "','" & ComboBox5.Text & "','" & ComboBox8.Text & "','" & ComboBox6.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox7.Text & "','" & TextBox22.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-collor", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-sholder", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-chest", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-stomoch", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-waist", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-length", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-sleeve", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-cuff", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-front", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-pocket", CType(TextBox10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-bicep", CType(TextBox21.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-collor_sty", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-cut_sty", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-sleeve_sty", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-fiting_sty", CType(ComboBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-height", CType(TextBox20.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-waist", CType(TextBox19.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-seat", CType(TextBox18.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-thigh", CType(TextBox17.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-knee", CType(TextBox16.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-bottom", CType(TextBox15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-style", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-fiting_sty", CType(ComboBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-cut_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("shirt_pant_no", CType(ComboBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("P-pleate", CType(ComboBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox22.Text, String)))
        MsgBox("Measurements saved successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
        TextBox18.Clear()
        TextBox19.Clear()
        TextBox20.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1
        ComboBox6.SelectedIndex = -1
        ComboBox8.SelectedIndex = -1


    End Sub
End Class