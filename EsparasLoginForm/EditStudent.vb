Imports MySql.Data.MySqlClient

Public Class EditStudent
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call Connect2DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select studentID, studentName, age, date_enrolled, yearLevel, courseID from student where studentID = '" _
                    & .TextSearch.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .textStudID.Text = myreader.GetString(0)
                    .textStudName.Text = myreader.GetString(1)
                    .textStudAge.Text = myreader.GetString(2)
                    .textDateEnrolled.Text = myreader.GetString(3)
                    .textYearLevel.Text = myreader.GetString(4)
                    .textCourseID.Text = myreader.GetString(5)
                End While
            Else
                MsgBox("Student ID does not exist!")
            End If
            Call Disconnect2DB()
        End With
    End Sub
End Class