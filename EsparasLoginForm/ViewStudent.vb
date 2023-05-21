Imports MySql.Data.MySqlClient

Public Class ViewStudent
    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        Me.Close()
        adminDashboard.Show()
    End Sub

    Public sqlColumns As String = "studentID as Student_ID, studentName as Student_Name, age as Age, date_enrolled as Date_Enrolled, yearLevel as Year_Level, courseID as Course_ID"

    Private Sub Load_Data_to_Grid(ByVal strsql As String)
        Dim myreader As MySqlDataReader
        Dim mycommand As New MySqlCommand
        Dim mydataAdapter As New MySqlDataAdapter
        Dim mydatatable As New DataTable

        Connect2DB()
        With Me
            Try
                mycommand.Connection = myconn
                mycommand.CommandText = strsql
                myreader = mycommand.ExecuteReader
                mydatatable = New DataTable

                myreader.Close()
                mydataAdapter.SelectCommand = mycommand

                mydataAdapter.Fill(mydatatable)
                DGstudent.AutoSize = False
                .DGstudent.Refresh()
                .DGstudent.EndEdit()
                .DGstudent.DataSource = mydatatable
                .DGstudent.ReadOnly = True
                .DGstudent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            Catch ex As MySqlException
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error on SQL query")
            End Try
            myreader = Nothing
            mycommand = Nothing
            Disconnect2DB()
        End With
    End Sub

    Private Sub ViewSubject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Load_Data_to_Grid("select " & Me.sqlColumns & " from student")
    End Sub

    Private Sub PrintBTN_Click(sender As Object, e As EventArgs) Handles PrintBTN.Click
        Call importToExcel(Me.DGstudent, "samplereport.xlsx")
    End Sub
End Class