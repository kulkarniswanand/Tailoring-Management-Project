Imports System.Data.OleDb
Public Class Form6
    Dim connstring As String
    Dim con As String
    Dim command, command2, command3, command4, command5, command6, command7, command8 As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("PLEASE ENTER ID FOR DELETE ACCOUNT", MsgBoxStyle.DefaultButton2)
        End If

        Dim result As DialogResult = MsgBox("Do you really want to delete a record", MsgBoxStyle.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
            connstring = con
            myconnection.ConnectionString = connstring
            myconnection.Open()
            command = " delete *from Table1 where [ID]= " & TextBox1.Text & ""
            command2 = "delete *from Table2 where [ID]= " & TextBox1.Text & ""
            command3 = "delete *from Table3 where [ID]= " & TextBox1.Text & ""
            command4 = "delete *from Table4 where [ID]= " & TextBox1.Text & ""
            command5 = "delete *from Table5 where [ID]= " & TextBox1.Text & ""
            command6 = "delete *from Table6 where [ID]= " & TextBox1.Text & ""
            command7 = "delete *from Table8 where [ID]= " & TextBox1.Text & ""
            command8 = "delete *from Table9 where [ID]= " & TextBox1.Text & ""

            Dim cmc As OleDbCommand = New OleDbCommand(command, myconnection)

            Dim cmi1 As OleDbCommand = New OleDbCommand(command2, myconnection)
            Dim cmi2 As OleDbCommand = New OleDbCommand(command3, myconnection)
            Dim cmi3 As OleDbCommand = New OleDbCommand(command4, myconnection)
            Dim cmi4 As OleDbCommand = New OleDbCommand(command5, myconnection)
            Dim cmi5 As OleDbCommand = New OleDbCommand(command6, myconnection)
            Dim cmi6 As OleDbCommand = New OleDbCommand(command7, myconnection)
            Dim cmi7 As OleDbCommand = New OleDbCommand(command8, myconnection)
            MsgBox("Record delete successfully")
            Try
                cmc.ExecuteNonQuery()
                cmc.Dispose()
                cmi1.ExecuteNonQuery()
                cmi1.Dispose()
                cmi2.ExecuteNonQuery()
                cmi2.Dispose()
                cmi3.ExecuteNonQuery()
                cmi3.Dispose()
                cmi4.ExecuteNonQuery()
                cmi4.Dispose()
                cmi5.ExecuteNonQuery()
                cmi5.Dispose()
                cmi6.ExecuteNonQuery()
                cmi6.Dispose()
                cmi7.ExecuteNonQuery()
                cmi7.Dispose()
               
                myconnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            TextBox1.Clear()
        Else
            Me.Refresh()
        End If

        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmp As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c1)
        Dim da As New OleDbDataAdapter(cmp)

        Dim ds As New DataSet
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

        Me.DataGridView1.DataSource = ds
        Me.DataGridView1.DataMember = "ID"
        Me.DataGridView1.DataMember = "name"
        Me.DataGridView1.DataMember = "midname"
        Me.DataGridView1.DataMember = "surname"
        Me.DataGridView1.DataMember = "address"
        Me.DataGridView1.DataMember = "contact_no"
        Me.DataGridView1.DataMember = "date"
        Me.DataGridView1.DataMember = "dilevery_date"
        Me.DataGridView1.DataMember = "total_cost"
        Me.DataGridView1.DataMember = "advance"



        c1.Close()




    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmp As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain from table1 where name=" & TextBox2.Text & "", c1)
        Dim da As New OleDbDataAdapter(cmp)
        cmp.Parameters.Add("@name", OleDbType.LongVarChar).Value = TextBox2.Text
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

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
      
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button3_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If


    End Sub

  
   

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox2.MouseClick
        TextBox2.Clear()


    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmp As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain from table1 where [contact_no] LIKE " & TextBox4.Text & "", c1)
        Dim da As New OleDbDataAdapter(cmp)
        cmp.Parameters.Add("@contact_no", OleDbType.LongVarChar).Value = TextBox4.Text
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

    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button5_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub TextBox4_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox4.MouseClick
        TextBox4.Clear()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
      
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class