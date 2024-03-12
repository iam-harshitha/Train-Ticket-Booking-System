<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        Button2 = New Button()
        TextBox4 = New TextBox()
        Button3 = New Button()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        GroupBox1 = New GroupBox()
        Button5 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, -19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1887, 950)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Thistle
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(403, 45)
        Label1.TabIndex = 1
        Label1.Text = "MANAGE TRAIN DETAILS"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(823, 71)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(838, 557)
        DataGridView1.TabIndex = 2
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Khaki
        Button4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(1601, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(132, 43)
        Button4.TabIndex = 6
        Button4.Text = "LOGOUT"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(29, 55)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 30)
        Label2.TabIndex = 0
        Label2.Text = "TrainNo"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(29, 125)
        Label3.Name = "Label3"
        Label3.Size = New Size(162, 30)
        Label3.TabIndex = 1
        Label3.Text = "Source Station"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(29, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(211, 30)
        Label4.TabIndex = 2
        Label4.Text = "Destination Station"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ControlText
        Label5.Location = New Point(29, 274)
        Label5.Name = "Label5"
        Label5.Size = New Size(177, 30)
        Label5.TabIndex = 3
        Label5.Text = "Departure Time"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(29, 358)
        Label6.Name = "Label6"
        Label6.Size = New Size(139, 30)
        Label6.TabIndex = 4
        Label6.Text = "Arrival Time"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(29, 435)
        Label7.Name = "Label7"
        Label7.Size = New Size(131, 30)
        Label7.TabIndex = 5
        Label7.Text = "Train Name"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(299, 56)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 34)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(299, 123)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 34)
        TextBox2.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Violet
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(577, 73)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 43)
        Button1.TabIndex = 3
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox3.Location = New Point(299, 201)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 34)
        TextBox3.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Violet
        Button2.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(577, 283)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 43)
        Button2.TabIndex = 4
        Button2.Text = "UPDATE"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox4.Location = New Point(299, 272)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(150, 34)
        TextBox4.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Violet
        Button3.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(577, 175)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 43)
        Button3.TabIndex = 5
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox5.Location = New Point(299, 358)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(150, 34)
        TextBox5.TabIndex = 10
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox6.Location = New Point(299, 435)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(150, 34)
        TextBox6.TabIndex = 11
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Button5)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(Button3)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 71)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(789, 536)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Edit the details"
        ' 
        ' Button5
        ' 
        Button5.BackColor = Color.Violet
        Button5.Font = New Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.Location = New Point(577, 385)
        Button5.Name = "Button5"
        Button5.Size = New Size(132, 43)
        Button5.TabIndex = 8
        Button5.Text = "CLEAR"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1745, 642)
        Controls.Add(GroupBox1)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form8"
        Text = "Form8"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button5 As Button


End Class
