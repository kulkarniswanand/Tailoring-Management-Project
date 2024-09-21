
Imports System.Data.OleDb
Public Class details2
    Dim connstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
        connstring = con
        c6.ConnectionString = connstring
        c6.Open()


        command = " update [Table1] set [name]='" & TextBox2.Text & "',[midname]='" & TextBox10.Text & "',[surname]='" & TextBox11.Text & "',[address]='" & TextBox4.Text & "',[contact_no]='" & TextBox3.Text & "',[date]='" & DateTimePicker1.Text & "',[dilevery_date]='" & DateTimePicker2.Text & "',[total_cost]='" & TextBox6.Text & "',[advance]='" & TextBox7.Text & "',[remain]='" & TextBox8.Text & "',[shirt]='" & CheckBox1.CheckState & "',[shirt_q]='" & TextBox1.Text & "',[pant]='" & CheckBox2.CheckState & "',[pant_q]='" & TextBox5.Text & "',[wizar]='" & CheckBox5.CheckState & "',[wizar_q]='" & TextBox12.Text & "',[neharu]='" & CheckBox3.CheckState & "',[neharu_q]='" & TextBox13.Text & "',[3_button]='" & CheckBox4.CheckState & "',[3_button_q]='" & TextBox14.Text & "',[shirt_pant]='" & CheckBox6.CheckState & "',[shirt_pant_q]='" & TextBox15.Text & "',[ne_wi]='" & CheckBox7.CheckState & "',[ne_wi_q]='" & TextBox16.Text & "',[kurta_pant]='" & CheckBox9.CheckState & "',[kurta_pant_q]='" & TextBox17.Text & "' where [ID]= " & TextBox9.Text & ""

        Dim cmd As OleDbCommand = New OleDbCommand(command, c6)

        cmd.Parameters.Add("@ID", OleDbType.Integer).Value = Me.TextBox9.Text

        MsgBox("Record Updated successfully")
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            c6.Close()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs)





        TextBox8.Text = Val(TextBox6.Text) - Val(TextBox7.Text)
    End Sub




    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If CheckBox1.CheckState = 1 Then
            shirt2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                shirt2.ComboBox5.Items.Add("shirt" + p)

            Loop Until p = TextBox1.Text


        End If
        shirt2.TextBox11.Text = Me.TextBox9.Text
        shirt2.TextBox12.Text = Me.TextBox2.Text
        shirt2.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox2.CheckState = 1 Then
            pant3.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                pant3.ComboBox5.Items.Add("pant" + p)

            Loop Until p = TextBox5.Text


        End If
        pant3.TextBox11.Text = Me.TextBox9.Text
        pant3.TextBox12.Text = Me.TextBox2.Text
        pant3.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CheckBox5.CheckState = 1 Then
            wizar2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                wizar2.ComboBox5.Items.Add("wizar" + p)

            Loop Until p = TextBox12.Text


        End If
        wizar2.TextBox11.Text = Me.TextBox9.Text
        wizar2.TextBox12.Text = Me.TextBox2.Text
        wizar2.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If CheckBox3.CheckState = 1 Then
            neharu2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                neharu2.ComboBox5.Items.Add("neharu" + p)

            Loop Until p = TextBox13.Text


        End If
        neharu2.TextBox11.Text = Me.TextBox9.Text
        neharu2.TextBox12.Text = Me.TextBox2.Text
        neharu2.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CheckBox4.CheckState = 1 Then
            _3_botton2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                _3_botton2.ComboBox1.Items.Add("shirt" + p)

            Loop Until p = TextBox14.Text


        End If
        _3_botton2.TextBox11.Text = Me.TextBox9.Text
        _3_botton2.TextBox12.Text = Me.TextBox2.Text
        _3_botton2.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox6.CheckState = 1 Then
            shirt_pant2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                shirt_pant2.ComboBox7.Items.Add("shirt_pant" + p)

            Loop Until p = TextBox15.Text



        End If
        shirt_pant2.TextBox11.Text = Me.TextBox9.Text
        shirt_pant2.TextBox12.Text = Me.TextBox2.Text
        shirt_pant2.ComboBox7.SelectedIndex = 0

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CheckBox7.CheckState = 1 Then
            neharu_wizar2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                neharu_wizar2.ComboBox7.Items.Add("neharu_wizar" + p)

            Loop Until p = TextBox16.Text


        End If
        neharu_wizar2.TextBox11.Text = Me.TextBox9.Text
        neharu_wizar2.TextBox12.Text = Me.TextBox2.Text
        neharu_wizar2.ComboBox7.SelectedIndex = 0
    End Sub

    Private Sub TextBox7_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox8.Text = Val(TextBox6.Text) - Val(TextBox7.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox9.CheckState = 1 Then
            kurta3.Show()

            Dim p As String = "0"

            Do
                p = p + 1
                kurta3.ComboBox4.Items.Add("kurta_pant" + p)

            Loop Until p = TextBox17.Text


        End If
        kurta3.TextBox11.Text = Me.TextBox9.Text
        kurta3.TextBox12.Text = Me.TextBox2.Text
        kurta3.ComboBox4.SelectedIndex = 0

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength < 10 Then
            Label5.Visible = True

        Else
            Label5.Visible = False

        End If

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If CheckBox1.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("shirt")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox26.Text = Val(TextBox18.Text) * Val(TextBox1.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If CheckBox2.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("pant")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox25.Text = Val(TextBox18.Text) * Val(TextBox5.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)


        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If CheckBox5.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("wizar")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox24.Text = Val(TextBox18.Text) * Val(TextBox12.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If CheckBox3.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("neharu_shirt")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox23.Text = Val(TextBox18.Text) * Val(TextBox13.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        If CheckBox4.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("3_button_shirt")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox22.Text = Val(TextBox18.Text) * Val(TextBox14.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If CheckBox6.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("shirt_and_pant")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox21.Text = Val(TextBox18.Text) * Val(TextBox15.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        If CheckBox7.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("neharu_wizar")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox20.Text = Val(TextBox18.Text) * Val(TextBox16.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If CheckBox9.Checked Then
            Try
                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                Dim c17 As OleDbConnection = New OleDbConnection
                connstring = con
                c17.ConnectionString = connstring
                c17.Open()
                command = " select * from [Table10] "

                Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

                Dim myreader As OleDbDataReader
                myreader = cmm.ExecuteReader
                myreader.Read()
                Me.TextBox18.Text = myreader("kurta_pant")
                c17.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox19.Text = Val(TextBox18.Text) * Val(TextBox17.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub
    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox8.Text = Val(TextBox6.Text) - Val(TextBox7.Text)
    End Sub
End Class