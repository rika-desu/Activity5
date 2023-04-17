<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUpload
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
        Me.ButtonUpload = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonUpload
        '
        Me.ButtonUpload.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonUpload.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ButtonUpload.Location = New System.Drawing.Point(312, 400)
        Me.ButtonUpload.Name = "ButtonUpload"
        Me.ButtonUpload.Size = New System.Drawing.Size(95, 38)
        Me.ButtonUpload.TabIndex = 1
        Me.ButtonUpload.Text = "UPLOAD"
        Me.ButtonUpload.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(94, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(696, 308)
        Me.DataGridView1.TabIndex = 2
        '
        'ButtonExit
        '
        Me.ButtonExit.BackColor = System.Drawing.Color.Gainsboro
        Me.ButtonExit.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExit.Location = New System.Drawing.Point(463, 400)
        Me.ButtonExit.Name = "ButtonExit"
        Me.ButtonExit.Size = New System.Drawing.Size(95, 38)
        Me.ButtonExit.TabIndex = 3
        Me.ButtonExit.Text = "EXIT"
        Me.ButtonExit.UseVisualStyleBackColor = False
        '
        'formUpload
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(874, 532)
        Me.Controls.Add(Me.ButtonExit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ButtonUpload)
        Me.Name = "formUpload"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formUpload"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonUpload As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonExit As Button
End Class
