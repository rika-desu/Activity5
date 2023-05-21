Imports System.Windows

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textCourseID = New System.Windows.Forms.TextBox()
        Me.textStudID = New System.Windows.Forms.TextBox()
        Me.textDateEnrolled = New System.Windows.Forms.TextBox()
        Me.textYearLevel = New System.Windows.Forms.TextBox()
        Me.textStudAge = New System.Windows.Forms.TextBox()
        Me.textStudName = New System.Windows.Forms.TextBox()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.UpdateBT = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddBT = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.adminDashboard = New System.Windows.Forms.Label()
        Me.DeleteBT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'textCourseID
        '
        Me.textCourseID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textCourseID.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textCourseID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textCourseID.Location = New System.Drawing.Point(328, 393)
        Me.textCourseID.Name = "textCourseID"
        Me.textCourseID.Size = New System.Drawing.Size(320, 30)
        Me.textCourseID.TabIndex = 35
        '
        'textStudID
        '
        Me.textStudID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textStudID.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textStudID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textStudID.Location = New System.Drawing.Point(328, 179)
        Me.textStudID.Name = "textStudID"
        Me.textStudID.Size = New System.Drawing.Size(320, 30)
        Me.textStudID.TabIndex = 31
        '
        'textDateEnrolled
        '
        Me.textDateEnrolled.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textDateEnrolled.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textDateEnrolled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textDateEnrolled.Location = New System.Drawing.Point(328, 308)
        Me.textDateEnrolled.Name = "textDateEnrolled"
        Me.textDateEnrolled.Size = New System.Drawing.Size(320, 30)
        Me.textDateEnrolled.TabIndex = 28
        '
        'textYearLevel
        '
        Me.textYearLevel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textYearLevel.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textYearLevel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textYearLevel.Location = New System.Drawing.Point(328, 350)
        Me.textYearLevel.Name = "textYearLevel"
        Me.textYearLevel.Size = New System.Drawing.Size(320, 30)
        Me.textYearLevel.TabIndex = 26
        '
        'textStudAge
        '
        Me.textStudAge.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textStudAge.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textStudAge.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textStudAge.Location = New System.Drawing.Point(328, 265)
        Me.textStudAge.Name = "textStudAge"
        Me.textStudAge.Size = New System.Drawing.Size(320, 30)
        Me.textStudAge.TabIndex = 23
        '
        'textStudName
        '
        Me.textStudName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textStudName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textStudName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textStudName.Location = New System.Drawing.Point(328, 222)
        Me.textStudName.Name = "textStudName"
        Me.textStudName.Size = New System.Drawing.Size(320, 30)
        Me.textStudName.TabIndex = 22
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextSearch.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextSearch.Location = New System.Drawing.Point(553, 117)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(173, 30)
        Me.TextSearch.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label8.Location = New System.Drawing.Point(178, 357)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 23)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Year Level"
        '
        'UpdateBT
        '
        Me.UpdateBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdateBT.BackColor = System.Drawing.Color.Gainsboro
        Me.UpdateBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UpdateBT.Location = New System.Drawing.Point(442, 458)
        Me.UpdateBT.Name = "UpdateBT"
        Me.UpdateBT.Size = New System.Drawing.Size(91, 34)
        Me.UpdateBT.TabIndex = 33
        Me.UpdateBT.Text = "Update"
        Me.UpdateBT.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label7.Location = New System.Drawing.Point(178, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 23)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Student ID"
        '
        'AddBT
        '
        Me.AddBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddBT.BackColor = System.Drawing.Color.Gainsboro
        Me.AddBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.AddBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddBT.Location = New System.Drawing.Point(328, 458)
        Me.AddBT.Name = "AddBT"
        Me.AddBT.Size = New System.Drawing.Size(91, 34)
        Me.AddBT.TabIndex = 30
        Me.AddBT.Text = "Add"
        Me.AddBT.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label6.Location = New System.Drawing.Point(178, 396)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 23)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Course ID"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label5.Location = New System.Drawing.Point(178, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Date Enrolled"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label4.Location = New System.Drawing.Point(178, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Age"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(178, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 23)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Student Name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(161, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edit Student"
        '
        'LogoutBT
        '
        Me.LogoutBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LogoutBT.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LogoutBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.LogoutBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogoutBT.Location = New System.Drawing.Point(694, 17)
        Me.LogoutBT.Name = "LogoutBT"
        Me.LogoutBT.Size = New System.Drawing.Size(75, 30)
        Me.LogoutBT.TabIndex = 1
        Me.LogoutBT.Text = "Logout"
        Me.LogoutBT.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnSearch.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSearch.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(737, 115)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 34)
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'adminDashboard
        '
        Me.adminDashboard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.adminDashboard.AutoSize = True
        Me.adminDashboard.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.adminDashboard.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.adminDashboard.Location = New System.Drawing.Point(20, 24)
        Me.adminDashboard.Name = "adminDashboard"
        Me.adminDashboard.Size = New System.Drawing.Size(121, 19)
        Me.adminDashboard.TabIndex = 0
        Me.adminDashboard.Text = "Admin Dashboard"
        '
        'DeleteBT
        '
        Me.DeleteBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DeleteBT.BackColor = System.Drawing.Color.Gainsboro
        Me.DeleteBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DeleteBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DeleteBT.Location = New System.Drawing.Point(557, 458)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(91, 34)
        Me.DeleteBT.TabIndex = 34
        Me.DeleteBT.Text = "Delete"
        Me.DeleteBT.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LogoutBT)
        Me.Panel1.Controls.Add(Me.adminDashboard)
        Me.Panel1.Location = New System.Drawing.Point(42, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 60)
        Me.Panel1.TabIndex = 19
        '
        'EditStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.UpdateBT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddBT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.textCourseID)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.textStudID)
        Me.Controls.Add(Me.textDateEnrolled)
        Me.Controls.Add(Me.textYearLevel)
        Me.Controls.Add(Me.textStudAge)
        Me.Controls.Add(Me.textStudName)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label8 As Label
    Friend WithEvents UpdateBT As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents AddBT As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LogoutBT As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents adminDashboard As Label
    Friend WithEvents DeleteBT As Button
    Friend WithEvents Panel1 As Panel

    Private Sub adminDashboard_Click(sender As Object, e As EventArgs) Handles adminDashboard.Click
        Me.Close()
        adminDashboard.Show()
    End Sub

    Friend WithEvents TextSearch As TextBox
    Friend WithEvents textCourseID As TextBox
    Friend WithEvents textStudID As TextBox
    Friend WithEvents textDateEnrolled As TextBox
    Friend WithEvents textYearLevel As TextBox
    Friend WithEvents textStudAge As TextBox
    Friend WithEvents textStudName As TextBox
End Class
