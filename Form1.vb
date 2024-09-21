Imports System.Data.OleDb
Public Class Form1
    Dim connectionstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "swanand" And TextBox3.Text = "2003" Then
            Me.Hide()
            Form2.Show()
            TextBox3.Clear()
            TextBox2.Clear()

        ElseIf TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox(" Please input a username and password")

        ElseIf TextBox2.Text <> "swanand" Or TextBox3.Text <> "2003" Then
            MsgBox("Invalid Username and Password")
            TextBox3.Clear()
            TextBox2.Clear()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_KeyDown(sender As Object, e As KeyEventArgs) Handles Button1.KeyDown

    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub


    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.TextBox3.Focus()

        Else
            Exit Sub
        End If
    End Sub
End Class
