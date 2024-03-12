Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Establish a connection to the database
            Using con As New SqlConnection("Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                con.Open()  ' Open the connection

                ' Query to retrieve distinct source airport names
                Dim sourceQuery As String = "SELECT DISTINCT SourceStation FROM Train"
                Dim sourceAdapter As New SqlDataAdapter(sourceQuery, con)
                Dim sourceTable As New DataTable()
                sourceAdapter.Fill(sourceTable)

                ' Query to retrieve distinct destination airport names
                Dim destinationQuery As String = "SELECT DISTINCT DestinationStation FROM Train"
                Dim destinationAdapter As New SqlDataAdapter(destinationQuery, con)
                Dim destinationTable As New DataTable()
                destinationAdapter.Fill(destinationTable)

                ' Set the DataSource and DisplayMember for ComboBox1
                ComboBox1.DataSource = sourceTable
                ComboBox1.DisplayMember = "SourceStation"
                ComboBox1.Text = "Select Source"

                ' Set the DataSource and DisplayMember for ComboBox2
                ComboBox2.DataSource = destinationTable
                ComboBox2.DisplayMember = "DestinationStation"
                ComboBox2.Text = "Select Destination"

            End Using ' Connection automatically closed here
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim source As String = ComboBox1.Text
        Dim destination As String = ComboBox2.Text
        Dim selectedDate As Date = DateTimePicker1.Value.Date
        ' Check if the selected date is in the past
        If selectedDate < DateTime.Today Then
            MessageBox.Show("Please select a present or future date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        ' Launch Form5 and pass user selections as arguments
        Dim frm5 As New Form5(source, destination, selectedDate)
        frm5.Show()
        Me.Hide()
    End Sub
End Class