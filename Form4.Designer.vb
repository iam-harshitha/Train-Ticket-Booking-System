<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Label2 = New Label()
        DateTimePicker1 = New DateTimePicker()
        SqlCommand1 = New Microsoft.Data.SqlClient.SqlCommand()
        Label3 = New Label()
        Label4 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-27, -192)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1027, 817)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.NavajoWhite
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(57, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(346, 45)
        Label1.TabIndex = 1
        Label1.Text = "SEARCH YOUR TRAIN"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.BackColor = Color.DarkSalmon
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(57, 254)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 2
        ComboBox1.Text = "Source"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.BackColor = Color.DarkSalmon
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(325, 254)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(182, 33)
        ComboBox2.TabIndex = 3
        ComboBox2.Text = "Destination"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.SteelBlue
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(71, 391)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 38)
        Label2.TabIndex = 4
        Label2.Text = "DATE"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(325, 382)
        DateTimePicker1.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        DateTimePicker1.MinDate = New Date(2024, 3, 1, 0, 0, 0, 0)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 37)
        DateTimePicker1.TabIndex = 5
        ' 
        ' SqlCommand1
        ' 
        SqlCommand1.CommandTimeout = 30
        SqlCommand1.EnableOptimizedParameterBinding = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.DarkSalmon
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(57, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 38)
        Label3.TabIndex = 8
        Label3.Text = "FROM"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.DarkSalmon
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(359, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(53, 38)
        Label4.TabIndex = 9
        Label4.Text = "TO"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(336, 491)
        Button1.Name = "Button1"
        Button1.Size = New Size(155, 45)
        Button1.TabIndex = 10
        Button1.Text = "SEARCH"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(71, 490)
        Button2.Name = "Button2"
        Button2.Size = New Size(112, 46)
        Button2.TabIndex = 11
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1004, 620)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form4"
        Text = "Form4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents SqlCommand1 As Microsoft.Data.SqlClient.SqlCommand
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
