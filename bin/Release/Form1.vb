Imports System.Data.OleDb
Public Class Form1
    Dim connectionstring As String
    Dim con As String
    Dim command As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "ranjeet" And TextBox3.Text = "22021986" Then
            Me.Hide()
            Form2.Show()
            TextBox3.Clear()
            TextBox2.Clear()

        ElseIf TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox(" Please input a username and password")

        ElseIf TextBox2.Text <> "ranjeet" Or TextBox3.Text <> "22021986" Then
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
End Class
