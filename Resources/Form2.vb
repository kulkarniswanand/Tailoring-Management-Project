

Imports System.Data.OleDb
Public Class Form2
    Dim connstring As String
    Dim con As String
    Dim command, command2 As String
    Dim c6 As OleDbConnection = New OleDbConnection
    Dim c17 As OleDbConnection = New OleDbConnection
    Dim myreader As OleDbDataReader
    Dim dp As OleDbDataReader

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Form3.Show()
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select ID from table1 where ID =(select max(ID) from table1)"



            Dim cmd As New OleDbCommand(cm, conn)


            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            myreader.Read()
            Form3.TextBox9.Text = myreader("ID")
            Form3.TextBox9.Text = Form3.TextBox9.Text + 1

            conn.Close()

        Catch ex As InvalidOperationException


            Form3.Show()
            Form3.TextBox9.Text = 1

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c1)
        Dim da As New OleDbDataAdapter(cmd)

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



        Form5.DataGridView1.DataSource = ds
        Form5.DataGridView1.DataMember = "ID"
        Form5.DataGridView1.DataMember = "name"
        Form5.DataGridView1.DataMember = "midname"
        Form5.DataGridView1.DataMember = "surname"
        Form5.DataGridView1.DataMember = "address"
        Form5.DataGridView1.DataMember = "contact_no"
        Form5.DataGridView1.DataMember = "date"
        Form5.DataGridView1.DataMember = "dilevery_date"
        Form5.DataGridView1.DataMember = "total_cost"
        Form5.DataGridView1.DataMember = "advance"

        c1.Close()



    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form6.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form6.DataGridView1.DataSource = ds
        Form6.DataGridView1.DataMember = "ID"
        Form6.DataGridView1.DataMember = "name"
        Form6.DataGridView1.DataMember = "midname"
        Form6.DataGridView1.DataMember = "surname"
        Form6.DataGridView1.DataMember = "address"
        Form6.DataGridView1.DataMember = "contact_no"
        Form6.DataGridView1.DataMember = "date"
        Form6.DataGridView1.DataMember = "dilevery_date"
        Form6.DataGridView1.DataMember = "total_cost"
        Form6.DataGridView1.DataMember = "advance"

       

        c1.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        price.Show()

        con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb"
            connstring = con
            c17.ConnectionString = connstring
            c17.Open()
            command = " select * from [Table10] "

            Dim cmm As OleDbCommand = New OleDbCommand(command, c17)

            Dim myreader As OleDbDataReader
            myreader = cmm.ExecuteReader
            myreader.Read()
            price.TextBox1.Text = myreader("shirt")
            price.TextBox2.Text = myreader("pant")
            price.TextBox3.Text = myreader("wizar")
            price.TextBox4.Text = myreader("neharu_shirt")
            price.TextBox5.Text = myreader("3_button_shirt")
            price.TextBox6.Text = myreader("shirt_and_pant")
            price.TextBox7.Text = myreader("neharu_wizar")
            price.TextBox8.Text = myreader("kurta_pant")





        c17.Close()



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Height = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Screen.PrimaryScreen.Bounds.Width * 0.6



        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Label2.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1 where [status] = '1'"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Label4.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim conn As New OleDbConnection
            conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
            conn.Open()
            Dim cm As String
            cm = " select count(*) from table1 where [icom] = '1'"



            Dim cmd As New OleDbCommand(cm, conn)



            Dim myreader = Convert.ToString(cmd.ExecuteScalar)
            Label6.Text = myreader

            conn.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


      
    End Sub


    

    
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form16.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form16.DataGridView1.DataSource = ds
        Form16.DataGridView1.DataMember = "ID"
        Form16.DataGridView1.DataMember = "name"
        Form16.DataGridView1.DataMember = "midname"
        Form16.DataGridView1.DataMember = "surname"
        Form16.DataGridView1.DataMember = "address"
        Form16.DataGridView1.DataMember = "contact_no"
        Form16.DataGridView1.DataMember = "date"
        Form16.DataGridView1.DataMember = "dilevery_date"
        Form16.DataGridView1.DataMember = "total_cost"
        Form16.DataGridView1.DataMember = "advance"


        c1.Close()

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Form15.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1 where [status] = '1'", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form15.DataGridView1.DataSource = ds
        Form15.DataGridView1.DataMember = "ID"
        Form15.DataGridView1.DataMember = "name"
        Form15.DataGridView1.DataMember = "midname"
        Form15.DataGridView1.DataMember = "surname"
        Form15.DataGridView1.DataMember = "address"
        Form15.DataGridView1.DataMember = "contact_no"
        Form15.DataGridView1.DataMember = "date"
        Form15.DataGridView1.DataMember = "dilevery_date"
        Form15.DataGridView1.DataMember = "total_cost"
        Form15.DataGridView1.DataMember = "advance"


        c1.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Form15.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1 where [icom] = '1'", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form15.DataGridView1.DataSource = ds
        Form15.DataGridView1.DataMember = "ID"
        Form15.DataGridView1.DataMember = "name"
        Form15.DataGridView1.DataMember = "midname"
        Form15.DataGridView1.DataMember = "surname"
        Form15.DataGridView1.DataMember = "address"
        Form15.DataGridView1.DataMember = "contact_no"
        Form15.DataGridView1.DataMember = "date"
        Form15.DataGridView1.DataMember = "dilevery_date"
        Form15.DataGridView1.DataMember = "total_cost"
        Form15.DataGridView1.DataMember = "advance"


        c1.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged_1(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub Label9_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form13.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c1)
        Dim da As New OleDbDataAdapter(cmd)

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



        Form13.DataGridView1.DataSource = ds
        Form13.DataGridView1.DataMember = "ID"
        Form13.DataGridView1.DataMember = "name"
        Form13.DataGridView1.DataMember = "midname"
        Form13.DataGridView1.DataMember = "surname"
        Form13.DataGridView1.DataMember = "address"
        Form13.DataGridView1.DataMember = "contact_no"
        Form13.DataGridView1.DataMember = "date"
        Form13.DataGridView1.DataMember = "dilevery_date"
        Form13.DataGridView1.DataMember = "total_cost"
        Form13.DataGridView1.DataMember = "advance"

        c1.Close()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        print.Show()
        Dim c25 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c25.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1", c25)
        Dim da As New OleDbDataAdapter(cmd)

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

        print.DataGridView1.DataSource = ds
        print.DataGridView1.DataMember = "ID"
        print.DataGridView1.DataMember = "name"
        print.DataGridView1.DataMember = "midname"
        print.DataGridView1.DataMember = "surname"
        print.DataGridView1.DataMember = "address"
        print.DataGridView1.DataMember = "contact_no"
        print.DataGridView1.DataMember = "date"
        print.DataGridView1.DataMember = "dilevery_date"
        print.DataGridView1.DataMember = "total_cost"
        print.DataGridView1.DataMember = "advance"


        c25.Close()
    End Sub

    Private Sub Button7_Click_2(sender As Object, e As EventArgs) Handles Button7.Click
        Form7.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From [Table1] where [dilevery_date] LIKE   '" & MonthCalendar1.TodayDate & "'", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form7.DataGridView1.DataSource = ds
        Form7.DataGridView1.DataMember = "ID"
        Form7.DataGridView1.DataMember = "name"


        Form7.DataGridView1.DataMember = "midname"
        Form7.DataGridView1.DataMember = "surname"
        Form7.DataGridView1.DataMember = "address"
        Form7.DataGridView1.DataMember = "contact_no"
        Form7.DataGridView1.DataMember = "date"
        Form7.DataGridView1.DataMember = "dilevery_date"
        Form7.DataGridView1.DataMember = "total_cost"
        Form7.DataGridView1.DataMember = "advance"


        c1.Close()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form15.Show()
        Dim c1 As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kulka\OneDrive\Documents\tailor.accdb")
        c1.Open()
        Dim cmd As New OleDbCommand("Select ID,name,midname,surname,address,contact_no,date,dilevery_date,total_cost,advance,remain From Table1 ", c1)
        Dim da As New OleDbDataAdapter(cmd)

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

        Form15.DataGridView1.DataSource = ds
        Form15.DataGridView1.DataMember = "ID"
        Form15.DataGridView1.DataMember = "name"
        Form15.DataGridView1.DataMember = "midname"
        Form15.DataGridView1.DataMember = "surname"
        Form15.DataGridView1.DataMember = "address"
        Form15.DataGridView1.DataMember = "contact_no"
        Form15.DataGridView1.DataMember = "date"
        Form15.DataGridView1.DataMember = "dilevery_date"
        Form15.DataGridView1.DataMember = "total_cost"
        Form15.DataGridView1.DataMember = "advance"


        c1.Close()

    End Sub
End Class