Imports System.Data.OleDb

Public Class Form10
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub
    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
        command = " insert into Table6 ([ID],[name],[height],[bottom],[style],[cut_master],[worker],[wizar_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & ComboBox1.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox15.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("height", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("bottom", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("style", CType(ComboBox1.Text, String)))
        

        cmd.Parameters.Add(New OleDbParameter("cut_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("wizar_no", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox15.Text, String)))

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
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        ComboBox1.SelectedIndex = -1



    End Sub
End Class