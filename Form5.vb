
Imports System.Data.OleDb
Public Class Form5
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim i As Integer = 0


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
      





    End Sub

  
   

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)




    End Sub
   
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmp As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain from table1 where [name] LIKE " & TextBox3.Text & "", c1)
        Dim da As New OleDbDataAdapter(cmp)
        cmp.Parameters.Add("@name", OleDbType.VarChar).Value = TextBox3.Text
        Dim ds As New DataSet
        Try
            da.Fill(ds, "ID")
            da.Fill(ds, "name")
            da.Fill(ds, "midname")
            da.Fill(ds, "surname")
            da.Fill(ds, "address")
            da.Fill(ds, "contact_no")
            da.Fill(ds, "date")
            da.Fill(ds, "dilevery_date")
            da.Fill(ds, "total_cost")
            da.Fill(ds, "advance")


            Me.DataGridView2.DataSource = ds
            Me.DataGridView2.DataMember = "ID"
            Me.DataGridView2.DataMember = "name"
            Me.DataGridView2.DataMember = "midname"
            Me.DataGridView2.DataMember = "surname"
            Me.DataGridView2.DataMember = "address"
            Me.DataGridView2.DataMember = "contact_no"
            Me.DataGridView2.DataMember = "date"
            Me.DataGridView2.DataMember = "dilevery_date"
            Me.DataGridView2.DataMember = "total_cost"
            Me.DataGridView2.DataMember = "advance"

            c1.Close()

        Catch ex As Exception





        End Try
        TextBox3.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        details.Show()
        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select  *from Table1 where ID =" & TextBox1.Text & ""



            Dim cmd As New OleDbCommand(cm, conn)
            cmd.Parameters.Add("@ID", OleDbType.Integer).Value = TextBox1.Text

            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            details.TextBox9.Text = myreader("ID")
            details.TextBox2.Text = myreader("name")
            details.TextBox10.Text = myreader("midname")
            details.TextBox11.Text = myreader("surname")
            details.TextBox4.Text = myreader("address")
            details.TextBox3.Text = myreader("contact_no")
            details.DateTimePicker1.Text = myreader("date")
            details.DateTimePicker2.Text = myreader("dilevery_date")

            details.TextBox6.Text = myreader("total_cost")
            details.TextBox7.Text = myreader("advance")
            details.TextBox8.Text = myreader("remain")
            details.CheckBox1.CheckState = myreader("shirt")
            details.CheckBox2.CheckState = myreader("pant")
            details.CheckBox5.CheckState = myreader("wizar")
            details.CheckBox3.CheckState = myreader("neharu")
            details.CheckBox4.CheckState = myreader("3_button")
            details.CheckBox6.CheckState = myreader("shirt_pant")
            details.CheckBox7.CheckState = myreader("ne_wi")
            details.CheckBox9.CheckState = myreader("kurta_pant")
            details.TextBox1.Text = myreader("shirt_q")
            details.TextBox5.Text = myreader("pant_q")
            details.TextBox12.Text = myreader("wizar_q")
            details.TextBox13.Text = myreader("neharu_q")
            details.TextBox14.Text = myreader("3_button_q")
            details.TextBox15.Text = myreader("shirt_pant_q")
            details.TextBox16.Text = myreader("ne_wi_q")
            details.TextBox17.Text = myreader("kurta_pant_q")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        TextBox1.Clear()
    End Sub

    Private Sub TextBox3_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox3.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button4_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox3_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox3.MouseClick
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub


  

    

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmp As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain from table1 where contact_no LIKE " & Me.TextBox2.Text & "", c1)
        Dim da As New OleDbDataAdapter(cmp)
        cmp.Parameters.Add("@contact_no", OleDbType.LongVarChar).Value = Me.TextBox2.Text
        Dim ds As New DataSet
        Try
            da.Fill(ds, "ID")
            da.Fill(ds, "name")
            da.Fill(ds, "midname")
            da.Fill(ds, "surname")
            da.Fill(ds, "address")
            da.Fill(ds, "contact_no")
            da.Fill(ds, "date")
            da.Fill(ds, "dilevery_date")
            da.Fill(ds, "total_cost")
            da.Fill(ds, "advance")


            Me.DataGridView2.DataSource = ds
            Me.DataGridView2.DataMember = "ID"
            Me.DataGridView2.DataMember = "name"
            Me.DataGridView2.DataMember = "midname"
            Me.DataGridView2.DataMember = "surname"
            Me.DataGridView2.DataMember = "address"
            Me.DataGridView2.DataMember = "contact_no"
            Me.DataGridView2.DataMember = "date"
            Me.DataGridView2.DataMember = "dilevery_date"
            Me.DataGridView2.DataMember = "total_cost"
            Me.DataGridView2.DataMember = "advance"
            c1.Close()

        Catch ex As Exception
            MsgBox(ex.Message)




        End Try
        TextBox2.Clear()
    End Sub

    Private Sub TextBox2_KeyDown1(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button2_Click_2(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

   
End Class