﻿Imports System.Data.SqlClient
Imports Microsoft.Data.SqlClient
Public Class Form2
    Dim constr As String = "Data Source=LAPTOP-E1R3N0US\SQLEXPRESS;Initial Catalog=train;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"
    Dim adapter As New SqlDataAdapter
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Application.Exit()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As New SqlConnection(constr)
                con.Open()
                Dim sql As String = "SELECT * FROM adminlogin WHERE username=@username AND password=@password"
                Dim cmd As New SqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", TextBox1.Text)
                cmd.Parameters.AddWithValue("@password", TextBox2.Text)
                adapter = New SqlDataAdapter(cmd)
                Dim ds As New DataSet
                adapter.Fill(ds)
                If ds.Tables(0).Rows.Count > 0 Then
                    MessageBox.Show("Admin successfully logged in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                    Dim trainSelectionForm As New Form8()
                    trainSelectionForm.Show()
                Else
                    MessageBox.Show("Username or password invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBox1.Text = ""
                    TextBox2.Text = ""
                    TextBox1.Focus()
                End If
                con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class