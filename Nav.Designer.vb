<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nav
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nav))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Label10 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Red
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.Control
        Button1.Location = New Point(41, 384)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 44)
        Button1.TabIndex = 0
        Button1.Text = "Flights"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.Control
        Button2.Location = New Point(174, 384)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 44)
        Button2.TabIndex = 1
        Button2.Text = "Passengers"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Red
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.Control
        Button3.Location = New Point(356, 384)
        Button3.Name = "Button3"
        Button3.Size = New Size(75, 44)
        Button3.TabIndex = 2
        Button3.Text = "Ticket"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Red
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.Control
        Button4.Location = New Point(488, 384)
        Button4.Name = "Button4"
        Button4.Size = New Size(143, 44)
        Button4.TabIndex = 3
        Button4.Text = "Cancel Ticket"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = Color.Red
        Label10.Location = New Point(773, -3)
        Label10.Name = "Label10"
        Label10.Size = New Size(26, 25)
        Label10.TabIndex = 37
        Label10.Text = "X"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Red
        Label1.Location = New Point(298, -3)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 25)
        Label1.TabIndex = 38
        Label1.Text = "ETIHAD AIRLINE"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(298, 51)
        Label2.Name = "Label2"
        Label2.Size = New Size(163, 25)
        Label2.TabIndex = 39
        Label2.Text = "Navigation Bar"
        ' 
        ' Nav
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(760, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label10)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Name = "Nav"
        Text = "Nav"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
