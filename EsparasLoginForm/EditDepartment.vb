Imports MySql.Data.MySqlClient

Public Class EditDepartment
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call Connect2DB()
        With Me
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader

            strSQL = "Select deptID, deptName from department where deptID = '" _
                    & .TextSearch.Text & "'"
            'MsgBox(strSQL)
            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            If myreader.HasRows Then
                While myreader.Read()
                    .textDeptID.Text = myreader.GetString(0)
                    .textDeptName.Text = myreader.GetString(1)
                End While
            Else
                MsgBox("Department ID does not exist!")
            End If
            Call Disconnect2DB()
        End With
    End Sub
End Class