<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form7))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        RichTextBox1 = New RichTextBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(903, 650)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.BlanchedAlmond
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(288, 110)
        Label1.Name = "Label1"
        Label1.Size = New Size(304, 45)
        Label1.TabIndex = 1
        Label1.Text = "Your Ticket Details"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.Moccasin
        RichTextBox1.BorderStyle = BorderStyle.None
        RichTextBox1.Font = New Font("Segoe Print", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(160, 178)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(577, 324)
        RichTextBox1.TabIndex = 9
        RichTextBox1.Text = ""
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.BlanchedAlmond
        Label2.Font = New Font("Harlow Solid Italic", 11F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(330, 505)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 28)
        Label2.TabIndex = 10
        Label2.Text = "Have a Safe Journey"
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 653)
        Controls.Add(Label2)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form7"
        Text = "Form7"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
End Class
