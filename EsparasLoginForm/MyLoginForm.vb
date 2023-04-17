Imports MySql.Data.MySqlClient
Public Class MyLoginForm
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            password_text.UseSystemPasswordChar = False
        Else
            password_text.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        With Me
            Call Connect2DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select * from users where username = '" _
                & .username_text.Text & "' and password = md5('" _
                & .password_text.Text & "')"

            mycmd.CommandText = strSQL
            mycmd.Connection = myconn

            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                .Hide()
                AdminDashboard.Show()
            Else
                MessageBox.Show("Invalid username or password!")
            End If
            Call Disconnect2DB()
        End With
    End Sub

End Class