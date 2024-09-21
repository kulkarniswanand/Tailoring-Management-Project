Imports System.Data.OleDb
Public Class Form9
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label15_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()
        command = " insert into Table5 ([ID],[name],[collor],[sholder],[chest],[length],[sleeve],[cuff],[front],[pocket],[cut_master],[worker],[3_button_no],[others]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & ComboBox5.Text & "','" & TextBox4.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("collor", CType(TextBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("sholder", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("chest", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("length", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("sleeve", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("cuff", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("front", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("pocket", CType(TextBox10.Text, String)))
       
        
        cmd.Parameters.Add(New OleDbParameter("cut_master", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("3_button_no", CType(ComboBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox4.Text, String)))
        MsgBox("Measurements saved successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
   
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        Form3.Show()
    End Sub
    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub
    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub
    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub
    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class