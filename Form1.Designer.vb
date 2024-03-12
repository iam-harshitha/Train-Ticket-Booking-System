<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        Button4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(1, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1150, 704)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(469, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(217, 54)
        Label1.TabIndex = 1
        Label1.Text = "WELCOME"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(203, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(703, 54)
        Label2.TabIndex = 2
        Label2.Text = "TRAIN TICKET BOOKING PLATFORM"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Green
        Button1.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(124, 224)
        Button1.Name = "Button1"
        Button1.Size = New Size(150, 50)
        Button1.TabIndex = 3
        Button1.Text = "ADMIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Green
        Button2.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(822, 224)
        Button2.Name = "Button2"
        Button2.Size = New Size(223, 50)
        Button2.TabIndex = 4
        Button2.Text = "USER LOGIN"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Green
        Button3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(397, 224)
        Button3.Name = "Button3"
        Button3.Size = New Size(322, 50)
        Button3.TabIndex = 5
        Button3.Text = "USER REGISTRATION"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ScrollBar
        Label3.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(358, 314)
        Label3.Name = "Label3"
        Label3.Size = New Size(161, 38)
        Label3.TabIndex = 6
        Label3.Text = "User Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ScrollBar
        Label4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(358, 428)
        Label4.Name = "Label4"
        Label4.Size = New Size(139, 38)
        Label4.TabIndex = 7
        Label4.Text = "Password"
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.YellowGreen
        Button4.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(463, 526)
        Button4.Name = "Button4"
        Button4.Size = New Size(223, 50)
        Button4.TabIndex = 8
        Button4.Text = "REGISTER"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(616, 318)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 34)
        TextBox1.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        TextBox2.Location = New Point(616, 428)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 34)
        TextBox2.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1154, 698)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Button4)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox

End Class
