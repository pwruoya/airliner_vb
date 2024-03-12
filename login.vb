Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class login
    'Dim MySqlConnection As New MySqlConnection("host=127.001;user=root;database=airlinebookingsystem;")
    'Dim cm As MySqlCommand
    'Dim adp As MySqlDataAdapter
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Try
        'cm = New MySqlCommand("insert into login values('" & TextBox1.Text & "','" & TextBox2.Text & "')", MySqlConnection)
        'cm.ExecuteNonQuery()
        'MsgBox("Data sent Successfully")
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        Dim name, password As String
        name = TextBox1.Text
        password = TextBox2.Text
        If name <> "" AndAlso password <> "" Then
            ' Both fields are filled, proceed with login logic
            If name = "admin" AndAlso password = "admin" Then
                ' Admin credentials are correct, proceed with login
                MessageBox.Show("Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Hide() ' Hide the login form
                Nav.Show() ' Show the Ticket form or the main application form
            Else
                ' Invalid credentials, show error message
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Optionally clear the password field
                ' password.Textbox1.Text = ""
                ' Optionally set focus back to the password field
                'password.Focus()
            End If
        Else
            ' Display an error message if any field is empty
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        'MySqlConnection.Open()
        'MessageBox.Show("successful connected")
        'Catch ex As Exception
        'MessageBox.Show(ex.Message)
        'End Try
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class