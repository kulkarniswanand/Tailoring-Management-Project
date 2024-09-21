Imports System.Data.OleDb
Public Class Form3
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 0
    Dim result As DialogResult





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If i = 0 And TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or DateTimePicker1.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Or TextBox8.Text = "" Then

            MsgBox("PLEASE FILL ALL DETAILS", 20, MsgBoxStyle.OkOnly)

        Else





            result = MsgBox("You want to save this record", MsgBoxStyle.YesNo)


            If result = Windows.Forms.DialogResult.Yes Then



                con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
                connstring = con
                c6.ConnectionString = connstring
                c6.Open()


                command = " insert into Table1 ([ID],[name],[midname],[surname],[address],[contact_no],[date],[dilevery_date],[total_cost],[advance],[remain],[shirt],[shirt_q],[pant],[pant_q],[wizar],[wizar_q],[neharu],[neharu_q],[3_button],[3_button_q],[shirt_pant],[shirt_pant_q],[ne_wi],[ne_wi_q],[icom],[kurta_pant],[kurta_pant_q],[status],[shirt_p],[pant_p],[wizar_p],[neharu_shirt_p],[3_button_shirt_p],[shirt_and_pant_p],[neharu_wizar_p],[kurta_pant_p]) values ('" & TextBox9.Text & "','" & TextBox2.Text & "','" & TextBox10.Text & "','" & TextBox11.Text & "','" & TextBox4.Text & "','" & TextBox3.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & CheckBox1.CheckState & "','" & TextBox1.Text & "','" & CheckBox2.CheckState & "','" & TextBox5.Text & "','" & CheckBox5.CheckState & "','" & TextBox12.Text & "','" & CheckBox3.CheckState & "','" & TextBox13.Text & "','" & CheckBox4.CheckState & "','" & TextBox14.Text & "','" & CheckBox6.CheckState & "','" & TextBox15.Text & "','" & CheckBox7.CheckState & "','" & TextBox16.Text & "','" & CheckBox8.CheckState & "','" & CheckBox9.CheckState & "','" & TextBox17.Text & "','" & CheckBox10.CheckState & "','" & TextBox34.Text & "','" & TextBox33.Text & "','" & TextBox32.Text & "','" & TextBox31.Text & "','" & TextBox30.Text & "','" & TextBox29.Text & "','" & TextBox28.Text & "','" & TextBox27.Text & "')"
                Dim cmd As OleDbCommand = New OleDbCommand(command, c6)
                cmd.Parameters.Add(New OleDbParameter("ID", CType(TextBox9.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("name", CType(TextBox2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("midname", CType(TextBox10.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("surname", CType(TextBox11.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("address", CType(TextBox4.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("contact_no", CType(TextBox3.Text, String)))

                cmd.Parameters.Add(New OleDbParameter("date", CType(DateTimePicker1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("dilevery_date", CType(DateTimePicker2.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("total_cost", CType(TextBox6.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("advance", CType(TextBox7.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("remain", CType(TextBox8.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt", CType(CheckBox1.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt_q", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("pant", CType(CheckBox2.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("pant_q", CType(TextBox5.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("wizar", CType(CheckBox5.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("wizar_q", CType(TextBox12.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("neharu", CType(CheckBox3.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("neharu_q", CType(TextBox13.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("3_button", CType(CheckBox4.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("3_button_q", CType(TextBox14.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt_pant", CType(CheckBox6.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt_pant_q", CType(TextBox15.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("ne_wi", CType(CheckBox7.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("ne_wi_q", CType(TextBox16.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("icom", CType(CheckBox8.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("kurta_pant", CType(CheckBox9.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("kurta_pant_q", CType(TextBox17.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("status", CType(CheckBox10.CheckState, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("pant_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("wizar_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("neharu_shirt_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("3_button_shirt_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("shirt_and_pant_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("neharu_wizar_p", CType(TextBox1.Text, String)))
                cmd.Parameters.Add(New OleDbParameter("kurta_pant_p", CType(TextBox1.Text, String)))

                MsgBox("Record saved successfully")
                Try
                    cmd.ExecuteNonQuery()
                    cmd.Dispose()
                    c6.Close()



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                i = 1
            Else
                Me.Refresh()

            End If

        End If
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Form2.Label2.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





       



        




    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Refresh()
    End Sub



    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TextBox8.Text = Val(TextBox6.Text) - Val(TextBox7.Text)
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
       
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox1.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox10.Clear()
        TextBox5.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        CheckBox1.CheckState = 0
        CheckBox2.CheckState = 0
        CheckBox3.CheckState = 0
        CheckBox4.CheckState = 0
        CheckBox5.CheckState = 0
        CheckBox6.CheckState = 0
        CheckBox7.CheckState = 0
        CheckBox9.CheckState = 0
        TextBox17.Clear()
        TextBox18.Clear()
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        conn.Open()
        Dim cm As String
        cm = " select ID from table1 where ID =(select max(ID) from table1)"



        Dim cmd As New OleDbCommand(cm, conn)


        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        Me.TextBox9.Text = myreader("ID")
        Me.TextBox9.Text = Me.TextBox9.Text + 1

        conn.Close()


    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            TextBox2.SelectedText = "_"
        Else
            Exit Sub
        End If
    End Sub

   

   

   

    Private Sub Button4_Click(sender As Object, e As EventArgs)



        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        conn.Open()
        Dim cm As String
        cm = " select ID from table1 where ID =(select max(ID) from table1)"



        Dim cmd As New OleDbCommand(cm, conn)


        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        myreader.Read()
        Me.TextBox9.Text = myreader("ID")
        Me.TextBox9.Text = Me.TextBox9.Text + 1

        conn.Close()
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()
    End Sub

   

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox11_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox11.MouseClick
        TextBox11.Clear()
    End Sub

    Private Sub TextBox11_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub TextBox10_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox10.MouseClick
        TextBox10.Clear()
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If i = 1 And CheckBox1.Checked Then

            Form4.Show()
            Me.Hide()
            Dim p As String = "0"

            Do
                p = p + 1
                Form4.ComboBox5.Items.Add("shirt" + p)

            Loop Until p = TextBox1.Text
           
            Form4.ComboBox5.SelectedIndex = 0

            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form4.TextBox11.Text = myreader("ID")
            Form4.TextBox12.Text = myreader("name")
            conn.Close()

        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If i = 1 And CheckBox2.Checked Then
            pant.Show()
            Me.Hide()

            Dim p As String = "0"

            Do
                p = p + 1
                pant.ComboBox5.Items.Add("pant" + p)

            Loop Until p = TextBox5.Text

            pant.ComboBox5.SelectedIndex = 0
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            pant.TextBox11.Text = myreader("ID")
            pant.TextBox12.Text = myreader("name")

            conn.Close()

        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If i = 1 And CheckBox5.Checked Then
            Form10.Show()
            Me.Hide()

            Dim p As String = "0"

            Do
                p = p + 1
                Form10.ComboBox5.Items.Add("wizar" + p)

            Loop Until p = TextBox12.Text

            Form10.ComboBox5.SelectedIndex = 0


            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form10.TextBox11.Text = myreader("ID")
            Form10.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If i = 1 And CheckBox3.Checked Then
            Form8.Show()
            Me.Hide()

            Dim p As String = "0"

            Do
                p = p + 1
                Form8.ComboBox5.Items.Add("neharu" + p)

            Loop Until p = TextBox13.Text

            Form8.ComboBox5.SelectedIndex = 0



            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader

            myreader = cmd.ExecuteReader
            myreader.Read()
            Form8.TextBox11.Text = myreader("ID")
            Form8.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If i = 1 And CheckBox4.Checked Then
            Form9.Show()
            Me.Hide()
            Dim p As String = "0"

            Do
                p = p + 1
                Form9.ComboBox5.Items.Add("shirt" + p)

            Loop Until p = TextBox14.Text

            Form9.ComboBox5.SelectedIndex = 0



            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form9.TextBox11.Text = myreader("ID")
            Form9.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)

        End If

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If i = 1 And CheckBox6.Checked Then
            Form11.Show()
            Me.Hide()

            Dim p As String = "0"

            Do
                p = p + 1
                Form11.ComboBox7.Items.Add("shirt_pant" + p)

            Loop Until p = TextBox15.Text

            Form11.ComboBox7.SelectedIndex = 0
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form11.TextBox11.Text = myreader("ID")
            Form11.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)



        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If i = 1 And CheckBox7.Checked Then
            Form12.Show()
            Me.Hide()
            Dim p As String = "0"

            Do

                p = p + 1
                Form12.ComboBox7.Items.Add("Neharu_wizar" + p)

            Loop Until p = TextBox16.Text

            Form12.ComboBox7.SelectedIndex = 0

            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form12.TextBox11.Text = myreader("ID")
            Form12.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)

        End If

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs)
        price.Show()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If CheckBox1.Checked Then

            TextBox26.Text = Val(TextBox34.Text) * Val(TextBox1.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If CheckBox2.Checked Then

            TextBox25.Text = Val(TextBox33.Text) * Val(TextBox5.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)


        End If
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        If CheckBox5.Checked Then

            TextBox24.Text = Val(TextBox32.Text) * Val(TextBox12.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        If CheckBox3.Checked Then

            TextBox23.Text = Val(TextBox31.Text) * Val(TextBox13.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        If CheckBox4.Checked Then

            TextBox22.Text = Val(TextBox30.Text) * Val(TextBox14.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        If CheckBox6.Checked Then

            TextBox21.Text = Val(TextBox29.Text) * Val(TextBox15.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        If CheckBox7.Checked Then

            TextBox20.Text = Val(TextBox28.Text) * Val(TextBox16.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If CheckBox9.Checked Then


            TextBox19.Text = Val(TextBox27.Text) * Val(TextBox17.Text)
            TextBox6.Text = Val(TextBox26.Text) + Val(TextBox25.Text) + Val(TextBox24.Text) + Val(TextBox23.Text) + Val(TextBox22.Text) + Val(TextBox21.Text) + Val(TextBox20.Text) + Val(TextBox19.Text)
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.TextLength < 10 And IsNumeric(TextBox3.Text) Then

            Label5.Visible = True


        Else
            Label5.Visible = False

        End If

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        If i = 1 And CheckBox9.Checked Then
            kurta.Show()
            Me.Hide()
            Dim p As String = "0"

            Do
                p = p + 1
                kurta.ComboBox4.Items.Add("Kurta_pant" + p)

            Loop Until p = TextBox17.Text

            kurta.ComboBox4.SelectedIndex = 0

            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select *from Table1 where ID =" & TextBox9.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox9.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            kurta.TextBox11.Text = myreader("ID")
            kurta.TextBox12.Text = myreader("name")

            conn.Close()
        Else
            MsgBox("Please save The record and Then try to take Measurements", MsgBoxStyle.OkOnly)

        End If

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TextBox8.Text = Val(TextBox6.Text) - Val(TextBox7.Text)
    End Sub

    Private Sub Form18_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.TextBox34.Text = myreader("shirt")
            Me.TextBox33.Text = myreader("pant")
            Me.TextBox32.Text = myreader("wizar")
            Me.TextBox31.Text = myreader("neharu_shirt")
            Me.TextBox30.Text = myreader("3_button_shirt")
            Me.TextBox29.Text = myreader("shirt_and_pant")
            Me.TextBox28.Text = myreader("neharu_wizar")
            Me.TextBox27.Text = myreader("kurta_pant")
            c17.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try












    End Sub

End Class
