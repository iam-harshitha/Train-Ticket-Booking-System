<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        SqlCommandBuilder1 = New Microsoft.Data.SqlClient.SqlCommandBuilder()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Button2 = New Button()
        Button1 = New Button()
        TextBox6 = New TextBox()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 32)
        Label1.TabIndex = 1
        Label1.Text = "Card Holder Name*"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.Thistle
        GroupBox1.Controls.Add(Button2)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(TextBox6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1173, 564)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Payment"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightSalmon
        Button2.Location = New Point(564, 434)
        Button2.Name = "Button2"
        Button2.Size = New Size(127, 49)
        Button2.TabIndex = 14
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightGreen
        Button1.Location = New Point(852, 434)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 49)
        Button1.TabIndex = 13
        Button1.Text = "Submit"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(812, 284)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(260, 39)
        TextBox6.TabIndex = 12
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(812, 178)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(260, 39)
        TextBox5.TabIndex = 11
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(812, 72)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(260, 39)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(74, 444)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(260, 39)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(74, 284)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(260, 39)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(74, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(260, 39)
        TextBox1.TabIndex = 7
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(619, 284)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 32)
        Label6.TabIndex = 6
        Label6.Text = "CVV*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(584, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(127, 32)
        Label5.TabIndex = 5
        Label5.Text = "Total Cost"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(584, 72)
        Label4.Name = "Label4"
        Label4.Size = New Size(134, 32)
        Label4.TabIndex = 4
        Label4.Text = "Phone no*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(74, 369)
        Label3.Name = "Label3"
        Label3.Size = New Size(157, 32)
        Label3.TabIndex = 3
        Label3.Text = "Expiry Date*"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(179, 32)
        Label2.TabIndex = 2
        Label2.Text = "Card Number*"
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(1199, 588)
        Controls.Add(GroupBox1)
        Name = "Form6"
        Text = "Form6"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents SqlCommandBuilder1 As Microsoft.Data.SqlClient.SqlCommandBuilder
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
