Imports System.Data.OleDb
Public Class Form4
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
        command = " insert into Table2 ([ID],[NAME],[S-collor],[S-sholder],[S-chest],[S-stomoch],[S-waist],[S-length],[S-sleeve],[S-cuff],[S-front],[S-pocket],[S-bicep],[S-collor_sty],[S-cut_sty],[S-sleeve_sty],[S-fiting_sty],[S-cut_master],[S-worker],[shirt_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox15.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "','" & ComboBox3.Text & "','" & ComboBox4.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox16.Text & "')"
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
        cmd.Parameters.Add(New OleDbParameter("S-bicep", CType(TextBox15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-collor_sty", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-cut_sty", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-sleeve_sty", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-fiting_sty", CType(ComboBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-cut_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("S-worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("shirt_no", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox16.Text, String)))
        MsgBox("Measurements saved successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged


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

        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1
        ComboBox4.SelectedIndex = -1
        ComboBox5.SelectedIndex = -1





    End Sub
End Class