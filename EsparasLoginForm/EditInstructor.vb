Imports MySql.Data.MySqlClient

Public Class EditInstructor
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call Connect2DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select instructorID, instructorName from instructor where instructorID = '" _
                    & .TextSearch.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .textInstructorID.Text = myreader.GetString(0)
                    .textInstructorName.Text = myreader.GetString(1)
                End While
            Else
                MsgBox("Instructor ID does not exist!")
            End If
            Call Disconnect2DB()
        End With
    End Sub
End Class