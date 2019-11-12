<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountLogs
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountLogs))
        Me.dgvLogs = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.dtpDate = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLogs
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLogs.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLogs.DoubleBuffered = True
        Me.dgvLogs.EnableHeadersVisualStyles = False
        Me.dgvLogs.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvLogs.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvLogs.Location = New System.Drawing.Point(23, 145)
        Me.dgvLogs.Name = "dgvLogs"
        Me.dgvLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLogs.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLogs.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLogs.Size = New System.Drawing.Size(458, 403)
        Me.dgvLogs.TabIndex = 0
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(23, 110)
        Me.dtpDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(235, 29)
        Me.dtpDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Account Name:"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(137, 60)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(44, 17)
        Me.lblname.TabIndex = 2
        Me.lblname.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "AccountID:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(137, 81)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(20, 17)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "ID"
        '
        'frmAccountLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 571)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.dgvLogs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccountLogs"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Account Logs"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dgvLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLogs As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dtpDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents lblname As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblId As Label
End Class
