<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancellation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cancellation))
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        Button3 = New Button()
        Button1 = New Button()
        TextBox1 = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4, ColumnHeader5, ColumnHeader6, ColumnHeader7})
        ListView1.GridLines = True
        ListView1.Location = New Point(346, 68)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(425, 199)
        ListView1.TabIndex = 39
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 40
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Name"
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "PNO"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Address"
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "Nationality"
        ColumnHeader5.Width = 70
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "Gender"
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "Phone No"
        ColumnHeader7.Width = 80
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Navy
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Button3.ForeColor = Color.Transparent
        Button3.Location = New Point(486, 265)
        Button3.Name = "Button3"
        Button3.Size = New Size(171, 40)
        Button3.TabIndex = 40
        Button3.Text = "Show Records"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Navy
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold)
        Button1.ForeColor = Color.Transparent
        Button1.Location = New Point(584, 405)
        Button1.Name = "Button1"
        Button1.Size = New Size(171, 40)
        Button1.TabIndex = 41
        Button1.Text = "Delete Record"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(154, 235)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 43
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 32)
        Label1.TabIndex = 44
        Label1.Text = "Enter  id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(301, -2)
        Label2.Name = "Label2"
        Label2.Size = New Size(165, 25)
        Label2.TabIndex = 45
        Label2.Text = "ETIHAD AIRLINE"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.Red
        Label3.Location = New Point(262, 23)
        Label3.Name = "Label3"
        Label3.Size = New Size(265, 25)
        Label3.TabIndex = 46
        Label3.Text = "Delete Passender Record"
        ' 
        ' cancellation
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 475)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        Controls.Add(Button3)
        Controls.Add(ListView1)
        Name = "cancellation"
        Text = "cancellation"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
