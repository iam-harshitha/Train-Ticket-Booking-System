Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form8
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView when the form loads
        LoadTrain()
    End Sub

    Private Sub LoadTrain()
        ' Connect to the database and fetch train data
        Dim connectionString As String = "Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Trust Server Certificate=True"
        Dim query As String = "SELECT * FROM [dbo].[Train]"

        Using connection As New SqlConnection(connectionString)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                ' Bind data to DataGridView
                DataGridView1.DataSource = dataTable
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Add new train record
        Dim con As New SqlConnection("Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Trust Server Certificate=True")
        Dim cmd As SqlCommand = New SqlCommand("
            INSERT INTO [dbo].[Train] ([TrainNo], [SourceStation], [DestinationStation], [DepartureTime], [ArrivalTime], [TrainName])
            VALUES ('" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "', '" + TextBox6.Text + "')", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data inserted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

        ' Reload data in DataGridView
        LoadTrain()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Delete train record
        Dim con As New SqlConnection("Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Trust Server Certificate=True")
        Dim cmd = New SqlCommand("
            DELETE FROM [dbo].[Train] WHERE [TrainNo] = '" + TextBox1.Text + "'", con)
        con.Open
        cmd.ExecuteNonQuery
        MessageBox.Show("Data deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close

        ' Reload data in DataGridView
        LoadTrain
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Update train record
        Dim con As New SqlConnection("Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Trust Server Certificate=True")
        Dim cmd As SqlCommand = New SqlCommand("
            UPDATE [dbo].[Train] SET [TrainNo] = '" + TextBox1.Text + "', [SourceStation] = '" + TextBox2.Text + "', [DestinationStation] = '" + TextBox3.Text + "', [DepartureTime] = '" + TextBox4.Text + "', [ArrivalTime] = '" + TextBox5.Text + "', [TrainName] = '" + TextBox6.Text + "'
            WHERE [TrainNo] = '" + TextBox1.Text + "'", con)
        con.Open()
        cmd.ExecuteNonQuery()
        MessageBox.Show("Data updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()

        ' Reload data in DataGridView
        LoadTrain()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Application.Exit()
    End Sub
    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub
End Class
