Imports MySql.Data.MySqlClient

Public Class EditSubject
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call Connect2DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select subjectID, subjectName, instructorID from subject where subjectID = '" _
                    & .TextSearch.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .textSubjectID.Text = myreader.GetString(0)
                    .textSubjectName.Text = myreader.GetString(1)
                    .textInstructorID.Text = myreader.GetString(2)
                End While
            Else
                MsgBox("Subject ID does not exist!")
            End If
            Call Disconnect2DB()
        End With
    End Sub
End Class