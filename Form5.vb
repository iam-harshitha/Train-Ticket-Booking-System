Imports System.Data.SqlClient
Imports System.Windows.Forms.AxHost
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Data.SqlClient

Public Class Form5
    Private sourceStation As String
    Private destinationStation As String
    Private totalFare As Decimal
    Private departureTime As DateTime ' Declare departureTime at the class level
    Private arrivalTime As DateTime
    Private selectedDate As Date
    Public Sub New(source As String, destination As String, dateSelected As Date)
        InitializeComponent()
        sourceStation = source
        destinationStation = destination
        selectedDate = dateSelected

        ' Debugging code
        MessageBox.Show($"Source: {sourceStation}, Destination: {destinationStation}, Selected Date: {selectedDate} ")
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Visible = False
        RichTextBox1.Visible = False
        Button2.Visible = False
        Try
            ' Establish a connection to the database
            Using con As New SqlConnection("Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Encrypt=True;Trust Server Certificate=True")
                con.Open()  ' Open the connection

                ' Construct the SQL query to retrieve available trains
                Dim query As String = "SELECT TrainNo, SourceStation, DestinationStation, DepartureTime, ArrivalTime, TrainName FROM Train WHERE SourceStation = @source AND DestinationStation = @destination"

                ' Create and execute the command with parameters
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@source", sourceStation)
                    command.Parameters.AddWithValue("@destination", destinationStation)

                    ' Create a data adapter to fill a DataTable
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    If dataTable.Rows.Count > 0 Then
                        MessageBox.Show("Data loaded successfully.")
                    Else
                        MessageBox.Show("No data found for the selected stations.")
                    End If

                    ' Populate the DataGridView with the retrieved train information
                    DataGridView1.DataSource = dataTable
                End Using ' Connection automatically closed here

                ' Populate ComboBox1 with class options
                Dim classes As New List(Of String) From {"General", "Sleeper", "AC"}
                ComboBox1.DataSource = classes
                ComboBox1.SelectedIndex = 0 ' Set default selection
                ComboBox1.Text = "Select the Class"

                ' Populate ComboBox2 with seat options
                Dim seats As New List(Of String) From {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"} ' Example seat options
                ComboBox2.DataSource = seats
                ComboBox2.SelectedIndex = 0 ' Set default selection
                ComboBox2.Text = "Select Number of Seats"
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ' Get the selected class and number of seats
            Dim selectedClass = ComboBox1.SelectedItem.ToString
            Dim numberOfSeats = Convert.ToInt32(ComboBox2.SelectedItem.ToString)

            ' Define fare based on selected class
            Dim fare As Decimal = 0
            Select Case selectedClass
                Case "General"
                    fare = 100
                Case "Sleeper"
                    fare = 300
                Case "AC"
                    fare = 500
            End Select

            ' Calculate the total fare
            totalFare = fare * numberOfSeats

            ' Extract ArrivalTime and DepartureTime from the selected row in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Extract the values from the DataGridView row
                Dim arrivalTime As String = selectedRow.Cells("ArrivalTime").Value.ToString()
                Dim departureTime As String = selectedRow.Cells("DepartureTime").Value.ToString()

                ' Construct a summary string including arrival and departure times
                Dim summary = $"Source Station: {sourceStation}" & vbCrLf &
                          $"Destination Station: {destinationStation}" & vbCrLf &
                          $"Date: {Form4.DateTimePicker1.Value.ToShortDateString}" & vbCrLf &
                          $"Departure Time: {departureTime}" & vbCrLf &
                          $"Arrival Time: {arrivalTime}" & vbCrLf &
                          $"Number of Seats: {numberOfSeats}" & vbCrLf &
                          $"Class: {selectedClass}" & vbCrLf &
                          $"Total Fare: {totalFare:C}"

                ' Display the summary in the TextBox
                RichTextBox1.Text = summary
                Label2.Visible = True
                RichTextBox1.Visible = True
                Button2.Visible = True
            Else
                MessageBox.Show("Please select a row in the DataGridView.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("An error occurred while calculating the fare: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Create a new instance of Form6
        Dim form6Instance As New Form6(totalFare)
        form6Instance.Show()
        ' Show Form6
        ' Hide the current form (Form5)
        Dim form7Instance As New Form7(RichTextBox1.Text)
        ' Hide the current form (Form5)
        Me.Hide()
    End Sub
    Public ReadOnly Property SummaryText As String
        Get
            Return RichTextBox1.Text
        End Get
    End Property
End Class
