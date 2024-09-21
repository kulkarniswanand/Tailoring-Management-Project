Imports System.Data.OleDb
Public Class details
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 1
    Dim result As DialogResult
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

   
    
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form5.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If CheckBox1.CheckState = 1 Then
            shirt.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                shirt.ComboBox5.Items.Add("shirt" + p)

            Loop Until p = TextBox1.Text


        End If
        shirt.TextBox11.Text = Me.TextBox9.Text
        shirt.TextBox12.Text = Me.TextBox2.Text
        shirt.ComboBox5.SelectedIndex = 0

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If CheckBox2.CheckState = 1 Then
            pant2.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                pant2.ComboBox5.Items.Add("pant" + p)

            Loop Until p = TextBox5.Text


        End If
        pant2.TextBox11.Text = Me.TextBox9.Text
        pant2.TextBox12.Text = Me.TextBox2.Text
        pant2.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If CheckBox5.CheckState = 1 Then
            wizar.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                wizar.ComboBox5.Items.Add("wizar" + p)

            Loop Until p = TextBox12.Text


        End If
        wizar.TextBox11.Text = Me.TextBox9.Text
        wizar.TextBox12.Text = Me.TextBox2.Text
        wizar.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If CheckBox3.CheckState = 1 Then
            neharu.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                neharu.ComboBox5.Items.Add("neharu" + p)

            Loop Until p = TextBox13.Text


        End If
        neharu.TextBox11.Text = Me.TextBox9.Text
        neharu.TextBox12.Text = Me.TextBox2.Text
        neharu.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If CheckBox4.CheckState = 1 Then
            _3_botton.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                _3_botton.ComboBox5.Items.Add("shirt" + p)

            Loop Until p = TextBox14.Text


        End If
        _3_botton.TextBox11.Text = Me.TextBox9.Text
        _3_botton.TextBox12.Text = Me.TextBox2.Text
        _3_botton.ComboBox5.SelectedIndex = 0
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox6.CheckState = 1 Then
            shirt_pant.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                shirt_pant.ComboBox7.Items.Add("shirt_pant" + p)

            Loop Until p = TextBox15.Text



        End If
        shirt_pant.TextBox11.Text = Me.TextBox9.Text
        shirt_pant.TextBox12.Text = Me.TextBox2.Text
        shirt_pant.ComboBox7.SelectedIndex = 0

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If CheckBox7.CheckState = 1 Then
            neharu_wizar.Show()
            Dim p As String = "0"

            Do
                p = p + 1
                neharu_wizar.ComboBox7.Items.Add("neharu_wizar" + p)

            Loop Until p = TextBox16.Text


        End If
        neharu_wizar.TextBox11.Text = Me.TextBox9.Text
        neharu_wizar.TextBox12.Text = Me.TextBox2.Text
        neharu_wizar.ComboBox7.SelectedIndex = 0
    End Sub

    Private Sub details_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If CheckBox9.CheckState = 1 Then
            kurta2.Show()
            Dim p As String = "0"

            Do





                p = p + 1
                kurta2.ComboBox4.Items.Add("kurta_pant" + p)

            Loop Until p = TextBox17.Text


        End If
        kurta2.TextBox11.Text = Me.TextBox9.Text
        kurta2.TextBox12.Text = Me.TextBox2.Text
        kurta2.ComboBox4.SelectedIndex = 0
    End Sub
End Class