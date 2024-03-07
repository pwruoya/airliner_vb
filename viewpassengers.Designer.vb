<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewpassengers
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
        Label2 = New Label()
        Label1 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        Label7 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        TextBox5 = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        Label4 = New Label()
        Button3 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(270, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 25)
        Label2.TabIndex = 31
        Label2.Text = "View Passengers "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(279, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 30
        Label1.Text = "ETIHAD AIRLINE"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(475, 116)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(161, 23)
        TextBox4.TabIndex = 41
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(129, 114)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(161, 23)
        TextBox3.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Navy
        Label7.Location = New Point(311, 115)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 19)
        Label7.TabIndex = 39
        Label7.Text = "Passenger Address"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(475, 76)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(161, 23)
        TextBox2.TabIndex = 38
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(129, 74)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(161, 23)
        TextBox1.TabIndex = 37
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(10, 114)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 19)
        Label6.TabIndex = 36
        Label6.Text = "Passenger No"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(311, 75)
        Label5.Name = "Label5"
        Label5.Size = New Size(146, 19)
        Label5.TabIndex = 35
        Label5.Text = "Passsenger Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(10, 73)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 19)
        Label3.TabIndex = 34
        Label3.Text = "Passenger Id"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(381, 200)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(161, 23)
        TextBox5.TabIndex = 47
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.Navy
        Label9.Location = New Point(270, 199)
        Label9.Name = "Label9"
        Label9.Size = New Size(84, 19)
        Label9.TabIndex = 46
        Label9.Text = "Phone No"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.Navy
        Label8.Location = New Point(327, 162)
        Label8.Name = "Label8"
        Label8.Size = New Size(68, 19)
        Label8.TabIndex = 45
        Label8.Text = "Gender"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Other"})
        ComboBox2.Location = New Point(475, 162)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(161, 24)
        ComboBox2.TabIndex = 44
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Kenyan", "American", "Ugandan", "British", "French"})
        ComboBox1.Location = New Point(129, 157)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(161, 24)
        ComboBox1.TabIndex = 43
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(10, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(92, 19)
        Label4.TabIndex = 42
        Label4.Text = "Nationality"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(512, 238)
        Button3.Name = "Button3"
        Button3.Size = New Size(83, 40)
        Button3.TabIndex = 51
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Navy
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.ForeColor = Color.Transparent
        Button4.Location = New Point(258, 238)
        Button4.Name = "Button4"
        Button4.Size = New Size(83, 40)
        Button4.TabIndex = 50
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(394, 238)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 40)
        Button2.TabIndex = 49
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(103, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 40)
        Button1.TabIndex = 48
        Button1.Text = "Show"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        ListView1.GridLines = True
        ListView1.Location = New Point(32, 284)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(704, 163)
        ListView1.TabIndex = 52
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Passenger Id"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Passenger Name"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Passenger No"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Passenger Address"
        ColumnHeader4.Width = 100
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Nationality"
        ColumnHeader5.Width = 100
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ColumnHeader6.Width = 100
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Phone No"
        ColumnHeader7.Width = 100
        ' 
        ' viewpassengers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(788, 450)
        Controls.Add(ListView1)
        Controls.Add(Button3)
        Controls.Add(Button4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label4)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(Label7)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "viewpassengers"
        StartPosition = FormStartPosition.CenterScreen
        Text = "viewpassengers"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
End Class
