<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class flighttbl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(flighttbl))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button2 = New Button()
        Button1 = New Button()
        Label7 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label10 = New Label()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        Button3 = New Button()
        ComboBox3 = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(153, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 3
        Label1.Text = "ETIHAD AIRLINE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(135, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(204, 25)
        Label2.TabIndex = 4
        Label2.Text = "Record New Flights"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(12, 111)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 19)
        Label3.TabIndex = 5
        Label3.Text = "Flight Code"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(12, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(62, 19)
        Label5.TabIndex = 7
        Label5.Text = "Source"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(12, 200)
        Label6.Name = "Label6"
        Label6.Size = New Size(93, 19)
        Label6.TabIndex = 8
        Label6.Text = "Destination"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Dubai", "London", "Cape Town", "New York", "Nairobi"})
        ComboBox1.Location = New Point(130, 151)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(161, 24)
        ComboBox1.TabIndex = 9
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Dubai", "London", "Cape Town", "New York", "Nairobi"})
        ComboBox2.Location = New Point(130, 195)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(161, 24)
        ComboBox2.TabIndex = 10
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Navy
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = Color.Transparent
        Button2.Location = New Point(135, 314)
        Button2.Name = "Button2"
        Button2.Size = New Size(83, 40)
        Button2.TabIndex = 14
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(12, 314)
        Button1.Name = "Button1"
        Button1.Size = New Size(101, 40)
        Button1.TabIndex = 13
        Button1.Text = "Record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Navy
        Label7.Location = New Point(12, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(111, 19)
        Label7.TabIndex = 16
        Label7.Text = "Take Off Date"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Font = New Font("Century Gothic", 8.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DateTimePicker1.Location = New Point(130, 239)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(161, 21)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(733, -2)
        Label10.Name = "Label10"
        Label10.Size = New Size(26, 25)
        Label10.TabIndex = 37
        Label10.Text = "X"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.GridLines = True
        ListView1.Location = New Point(371, 43)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(388, 176)
        ListView1.TabIndex = 38
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Flight Code"
        ColumnHeader1.Width = 100
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Source"
        ColumnHeader2.Width = 100
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Destination"
        ColumnHeader3.Width = 100
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Take off Date"
        ColumnHeader4.Width = 100
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(557, 220)
        Button3.Name = "Button3"
        Button3.Size = New Size(202, 40)
        Button3.TabIndex = 39
        Button3.Text = "Show Records"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"F001", "F002", "F003", "F004"})
        ComboBox3.Location = New Point(130, 106)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(161, 24)
        ComboBox3.TabIndex = 40
        ' 
        ' flighttbl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(760, 440)
        Controls.Add(ComboBox3)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Controls.Add(Label10)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label7)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "flighttbl"
        StartPosition = FormStartPosition.CenterScreen
        Text = "flighttbl"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents ComboBox3 As ComboBox
End Class
