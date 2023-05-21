<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewStudent
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogoutBT = New System.Windows.Forms.Button()
        Me.adminDashboard = New System.Windows.Forms.Label()
        Me.DGstudent = New System.Windows.Forms.DataGridView()
        Me.PrintBTN = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGstudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LogoutBT)
        Me.Panel1.Controls.Add(Me.adminDashboard)
        Me.Panel1.Location = New System.Drawing.Point(42, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 60)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(161, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "View Student"
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
        'DGstudent
        '
        Me.DGstudent.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGstudent.Location = New System.Drawing.Point(42, 111)
        Me.DGstudent.Name = "DGstudent"
        Me.DGstudent.RowHeadersWidth = 51
        Me.DGstudent.RowTemplate.Height = 24
        Me.DGstudent.Size = New System.Drawing.Size(790, 316)
        Me.DGstudent.TabIndex = 22
        '
        'PrintBTN
        '
        Me.PrintBTN.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PrintBTN.Font = New System.Drawing.Font("Yu Gothic UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintBTN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PrintBTN.Location = New System.Drawing.Point(391, 448)
        Me.PrintBTN.Name = "PrintBTN"
        Me.PrintBTN.Size = New System.Drawing.Size(100, 38)
        Me.PrintBTN.TabIndex = 23
        Me.PrintBTN.Text = "PRINT"
        Me.PrintBTN.UseVisualStyleBackColor = False
        '
        'ViewStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.PrintBTN)
        Me.Controls.Add(Me.DGstudent)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ViewStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGstudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LogoutBT As Button
    Friend WithEvents adminDashboard As Label
    Friend WithEvents DGstudent As DataGridView
    Friend WithEvents PrintBTN As Button
End Class
