Imports System.Data.OleDb
Public Class kurta
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub
    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub
    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub
    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub
    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged

    End Sub
    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged

    End Sub
    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub
    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
    Private Sub kurta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        command = " insert into Table9 ([ID], [NAME],[K-collor] ,[K-chest], [K-stomoch], [K-waist], [K-hip], [K-Sleeve], [K-sl_style], [K-cuff_wrist],  [K-regular_wrist], [K-pocket_sty], [waist], [seat], [thigh], [knee], [bottom], [style], [cutting-mst], [worker], [others], [kurta_pant_no]) values ('" & TextBox11.Text & "','" & TextBox12.Text & "','" & TextBox1.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "','" & TextBox2.Text & "','" & ComboBox3.Text & "','" & TextBox15.Text & "','" & TextBox10.Text & "','" & TextBox18.Text & "','" & TextBox8.Text & "','" & TextBox16.Text & "','" & ComboBox2.Text & "','" & TextBox13.Text & "','" & TextBox14.Text & "','" & TextBox17.Text & "','" & ComboBox4.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
        cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox11.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("NAME", CType(TextBox12.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-collor", CType(TextBox1.Text, String)))

        cmd.Parameters.Add(New OleDbParameter("K-chest", CType(TextBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-stomoch", CType(TextBox4.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-waist", CType(TextBox5.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-hip", CType(TextBox7.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-sleeve", CType(TextBox6.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-sl_style", CType(ComboBox1.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-cuff_wrist", CType(TextBox9.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-regular_wrist", CType(TextBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("K-pocket_sty", CType(ComboBox3.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("waist", CType(TextBox15.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("seat", CType(TextBox10.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("thigh", CType(TextBox18.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("knee", CType(TextBox8.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("bottom", CType(TextBox16.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("style", CType(ComboBox2.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("cutting-mst", CType(TextBox13.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("worker", CType(TextBox14.Text, String)))


        cmd.Parameters.Add(New OleDbParameter("others", CType(TextBox17.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("kurta_pant_no", CType(ComboBox4.Text, String)))
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
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1







    End Sub
End Class