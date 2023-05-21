<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditDepartment
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
        Me.textDeptID = New System.Windows.Forms.TextBox()
        Me.textDeptName = New System.Windows.Forms.TextBox()
        Me.TextSearch = New System.Windows.Forms.TextBox()
        Me.UpdateBT = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AddBT = New System.Windows.Forms.Button()
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
        'textDeptID
        '
        Me.textDeptID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textDeptID.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textDeptID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textDeptID.Location = New System.Drawing.Point(324, 232)
        Me.textDeptID.Name = "textDeptID"
        Me.textDeptID.Size = New System.Drawing.Size(320, 30)
        Me.textDeptID.TabIndex = 41
        '
        'textDeptName
        '
        Me.textDeptName.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.textDeptName.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textDeptName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textDeptName.Location = New System.Drawing.Point(324, 292)
        Me.textDeptName.Name = "textDeptName"
        Me.textDeptName.Size = New System.Drawing.Size(320, 30)
        Me.textDeptName.TabIndex = 38
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextSearch.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TextSearch.Location = New System.Drawing.Point(549, 119)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Size = New System.Drawing.Size(173, 30)
        Me.TextSearch.TabIndex = 37
        '
        'UpdateBT
        '
        Me.UpdateBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.UpdateBT.BackColor = System.Drawing.Color.Gainsboro
        Me.UpdateBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UpdateBT.Location = New System.Drawing.Point(438, 358)
        Me.UpdateBT.Name = "UpdateBT"
        Me.UpdateBT.Size = New System.Drawing.Size(91, 34)
        Me.UpdateBT.TabIndex = 43
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
        Me.Label7.Location = New System.Drawing.Point(163, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 23)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Department ID"
        '
        'AddBT
        '
        Me.AddBT.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AddBT.BackColor = System.Drawing.Color.Gainsboro
        Me.AddBT.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, System.Drawing.FontStyle.Bold)
        Me.AddBT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddBT.Location = New System.Drawing.Point(324, 358)
        Me.AddBT.Name = "AddBT"
        Me.AddBT.Size = New System.Drawing.Size(91, 34)
        Me.AddBT.TabIndex = 40
        Me.AddBT.Text = "Add"
        Me.AddBT.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(163, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 23)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "Department Name"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(161, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Edit Department"
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
        Me.btnSearch.Location = New System.Drawing.Point(733, 117)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(91, 34)
        Me.btnSearch.TabIndex = 36
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
        Me.DeleteBT.Location = New System.Drawing.Point(553, 358)
        Me.DeleteBT.Name = "DeleteBT"
        Me.DeleteBT.Size = New System.Drawing.Size(91, 34)
        Me.DeleteBT.TabIndex = 44
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
        Me.Panel1.Location = New System.Drawing.Point(34, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 60)
        Me.Panel1.TabIndex = 35
        '
        'EditDepartment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.UpdateBT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.AddBT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textDeptID)
        Me.Controls.Add(Me.textDeptName)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.DeleteBT)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditDepartment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditDepartment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateBT As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents AddBT As Button
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

    Friend WithEvents textDeptID As TextBox
    Friend WithEvents textDeptName As TextBox
    Friend WithEvents TextSearch As TextBox
End Class
