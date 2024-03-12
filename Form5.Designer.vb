<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        DataGridView1 = New DataGridView()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        RichTextBox1 = New RichTextBox()
        Button2 = New Button()
        Button3 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(689, 48)
        Label1.TabIndex = 1
        Label1.Text = "CHOOSE FROM THE AVAILABLE TRAINS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-10, 1)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1326, 1104)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.MediumAquamarine
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(26, 131)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1000, 93)
        DataGridView1.TabIndex = 3
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(26, 268)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(231, 40)
        ComboBox1.TabIndex = 4
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(328, 268)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(231, 40)
        ComboBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(630, 268)
        Button1.Name = "Button1"
        Button1.Size = New Size(156, 48)
        Button1.TabIndex = 6
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Khaki
        Label2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(26, 354)
        Label2.Name = "Label2"
        Label2.Size = New Size(369, 38)
        Label2.TabIndex = 7
        Label2.Text = "Summary Of Your Booking"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Moccasin
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(26, 411)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(467, 300)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightGreen
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(1048, 568)
        Button2.Name = "Button2"
        Button2.Size = New Size(156, 48)
        Button2.TabIndex = 10
        Button2.Text = "Proceed"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Gold
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(1048, 28)
        Button3.Name = "Button3"
        Button3.Size = New Size(156, 48)
        Button3.TabIndex = 11
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1204, 732)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form5"
        Text = "Form5"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button

End Class
