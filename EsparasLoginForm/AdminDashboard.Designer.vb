Imports MySql.Data.MySqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminDashboard
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ViewSubjectBT = New System.Windows.Forms.Button()
        Me.EditSubjectBT = New System.Windows.Forms.Button()
        Me.ViewDepartmentBT = New System.Windows.Forms.Button()
        Me.ViewInstructorBT = New System.Windows.Forms.Button()
        Me.ViewStudentBT = New System.Windows.Forms.Button()
        Me.EditDepartmentBT = New System.Windows.Forms.Button()
        Me.EditStudentBT = New System.Windows.Forms.Button()
        Me.EditInstructorBT = New System.Windows.Forms.Button()
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonBackUp = New System.Windows.Forms.Button()
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(207, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INDEPENDENT UNIVERSITY"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(207, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student Management System"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(271, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(1, 2, 1, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 432)
        Me.Panel3.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = Global.EsparasLoginForm.My.Resources.Resources.LOGO
        Me.PictureBox1.Location = New System.Drawing.Point(152, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 26.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(138, 79)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 53)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "IU"
        '
        'ViewSubjectBT
        '
        Me.ViewSubjectBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewSubjectBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewSubjectBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ViewSubjectBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewSubjectBT.Location = New System.Drawing.Point(32, 293)
        Me.ViewSubjectBT.Name = "ViewSubjectBT"
        Me.ViewSubjectBT.Size = New System.Drawing.Size(160, 35)
        Me.ViewSubjectBT.TabIndex = 5
        Me.ViewSubjectBT.Text = "VIEW SUBJECT"
        Me.ViewSubjectBT.UseVisualStyleBackColor = False
        '
        'EditSubjectBT
        '
        Me.EditSubjectBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditSubjectBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditSubjectBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.EditSubjectBT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EditSubjectBT.Location = New System.Drawing.Point(32, 255)
        Me.EditSubjectBT.Name = "EditSubjectBT"
        Me.EditSubjectBT.Size = New System.Drawing.Size(160, 35)
        Me.EditSubjectBT.TabIndex = 4
        Me.EditSubjectBT.Text = "EDIT SUBJECT"
        Me.EditSubjectBT.UseVisualStyleBackColor = False
        '
        'ViewDepartmentBT
        '
        Me.ViewDepartmentBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewDepartmentBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewDepartmentBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ViewDepartmentBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewDepartmentBT.Location = New System.Drawing.Point(32, 211)
        Me.ViewDepartmentBT.Name = "ViewDepartmentBT"
        Me.ViewDepartmentBT.Size = New System.Drawing.Size(160, 35)
        Me.ViewDepartmentBT.TabIndex = 4
        Me.ViewDepartmentBT.Text = "VIEW DEPARTMENT"
        Me.ViewDepartmentBT.UseVisualStyleBackColor = False
        '
        'ViewInstructorBT
        '
        Me.ViewInstructorBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewInstructorBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewInstructorBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ViewInstructorBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewInstructorBT.Location = New System.Drawing.Point(32, 130)
        Me.ViewInstructorBT.Name = "ViewInstructorBT"
        Me.ViewInstructorBT.Size = New System.Drawing.Size(160, 35)
        Me.ViewInstructorBT.TabIndex = 3
        Me.ViewInstructorBT.Text = "VIEW INSTRUCTOR"
        Me.ViewInstructorBT.UseVisualStyleBackColor = False
        '
        'ViewStudentBT
        '
        Me.ViewStudentBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ViewStudentBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ViewStudentBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ViewStudentBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewStudentBT.Location = New System.Drawing.Point(32, 48)
        Me.ViewStudentBT.Name = "ViewStudentBT"
        Me.ViewStudentBT.Size = New System.Drawing.Size(160, 35)
        Me.ViewStudentBT.TabIndex = 2
        Me.ViewStudentBT.Text = "VIEW STUDENT"
        Me.ViewStudentBT.UseVisualStyleBackColor = False
        '
        'EditDepartmentBT
        '
        Me.EditDepartmentBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditDepartmentBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditDepartmentBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.EditDepartmentBT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EditDepartmentBT.Location = New System.Drawing.Point(32, 174)
        Me.EditDepartmentBT.Name = "EditDepartmentBT"
        Me.EditDepartmentBT.Size = New System.Drawing.Size(160, 35)
        Me.EditDepartmentBT.TabIndex = 3
        Me.EditDepartmentBT.Text = "EDIT DEPARTMENT"
        Me.EditDepartmentBT.UseVisualStyleBackColor = False
        '
        'EditStudentBT
        '
        Me.EditStudentBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditStudentBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditStudentBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.EditStudentBT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EditStudentBT.Location = New System.Drawing.Point(32, 10)
        Me.EditStudentBT.Name = "EditStudentBT"
        Me.EditStudentBT.Size = New System.Drawing.Size(160, 35)
        Me.EditStudentBT.TabIndex = 1
        Me.EditStudentBT.Text = "EDIT STUDENT"
        Me.EditStudentBT.UseVisualStyleBackColor = False
        '
        'EditInstructorBT
        '
        Me.EditInstructorBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EditInstructorBT.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditInstructorBT.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.EditInstructorBT.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.EditInstructorBT.Location = New System.Drawing.Point(32, 92)
        Me.EditInstructorBT.Name = "EditInstructorBT"
        Me.EditInstructorBT.Size = New System.Drawing.Size(160, 35)
        Me.EditInstructorBT.TabIndex = 2
        Me.EditInstructorBT.Text = "EDIT INSTRUCTOR"
        Me.EditInstructorBT.UseVisualStyleBackColor = False
        '
        'LogoutBT
        '
        Me.LogoutBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoutBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogoutBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LogoutBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBT.Location = New System.Drawing.Point(692, 10)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(75, 30)
        Me.LogoutBT.TabIndex = 1
        Me.LogoutBT.Text = "Logout"
        Me.LogoutBT.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(18, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Dashboard"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.ButtonBackUp)
        Me.Panel2.Controls.Add(Me.ButtonUpload)
        Me.Panel2.Controls.Add(Me.ViewSubjectBT)
        Me.Panel2.Controls.Add(Me.EditSubjectBT)
        Me.Panel2.Controls.Add(Me.ViewDepartmentBT)
        Me.Panel2.Controls.Add(Me.ViewInstructorBT)
        Me.Panel2.Controls.Add(Me.ViewStudentBT)
        Me.Panel2.Controls.Add(Me.EditDepartmentBT)
        Me.Panel2.Controls.Add(Me.EditStudentBT)
        Me.Panel2.Controls.Add(Me.EditInstructorBT)
        Me.Panel2.Location = New System.Drawing.Point(42, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 431)
        Me.Panel2.TabIndex = 8
        '
        'ButtonBackUp
        '
        Me.ButtonBackUp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonBackUp.BackColor = System.Drawing.Color.MidnightBlue
        Me.ButtonBackUp.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonBackUp.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonBackUp.Location = New System.Drawing.Point(32, 382)
        Me.ButtonBackUp.Name = "ButtonBackUp"
        Me.ButtonBackUp.Size = New System.Drawing.Size(160, 35)
        Me.ButtonBackUp.TabIndex = 7
        Me.ButtonBackUp.Text = "BACKUP"
        Me.ButtonBackUp.UseVisualStyleBackColor = False
        '
        'ButtonUpload
        '
        Me.ButtonUpload.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonUpload.BackColor = System.Drawing.Color.MidnightBlue
        Me.ButtonUpload.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.ButtonUpload.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ButtonUpload.Location = New System.Drawing.Point(32, 341)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(160, 35)
        Me.ButtonUpload.TabIndex = 6
        Me.ButtonUpload.Text = "UPLOAD"
        Me.ButtonUpload.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.LogoutBT)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(42, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 47)
        Me.Panel1.TabIndex = 7
        '
        'AdminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Gainsboro
        Me.Name = "AdminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents ViewSubjectBT As Button
    Friend WithEvents EditSubjectBT As Button
    Friend WithEvents ViewDepartmentBT As Button
    Friend WithEvents ViewInstructorBT As Button
    Friend WithEvents ViewStudentBT As Button
    Friend WithEvents EditDepartmentBT As Button
    Friend WithEvents EditStudentBT As Button
    Friend WithEvents EditInstructorBT As Button
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents ButtonBackUp As Button
    Friend WithEvents LogoutBT As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel

    Private Sub EditStudentBT_Click(sender As Object, e As EventArgs) Handles EditStudentBT.Click
        EditStudent.Show()
    End Sub

    Private Sub EditInstructorBT_Click(sender As Object, e As EventArgs) Handles EditInstructorBT.Click
        EditInstructor.Show()
    End Sub

    Private Sub EditDepartmentBT_Click(sender As Object, e As EventArgs) Handles EditDepartmentBT.Click
        EditDepartment.Show()
    End Sub

    Private Sub EditSubjectBT_Click(sender As Object, e As EventArgs) Handles EditSubjectBT.Click
        EditSubject.Show()
    End Sub

    Private Sub ButtonUpload_Click(sender As Object, e As EventArgs) Handles ButtonUpload.Click
        formUpload.Show()
    End Sub

    Private Sub ButtonBackup_Click(sender As Object, e As EventArgs) Handles ButtonBackUp.Click
        Dim backup As New SaveFileDialog
        backup.InitialDirectory = "C:\"
        backup.Title = "Database Backup"
        backup.CheckFileExists = False
        backup.CheckPathExists = False
        backup.DefaultExt = "sql"
        backup.Filter = "sql files (*.sql)|*.sql|All files (*.*)|*.*"
        backup.RestoreDirectory = True

        If backup.ShowDialog = Windows.Forms.DialogResult.OK Then
            Call Connect2DB()
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = myconn
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportToFile(backup.FileName)
            myconn.Close()
            MessageBox.Show("Database Successfully Backup!", "BACKUP", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf backup.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Return
        End If

    End Sub

End Class