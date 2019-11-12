<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryItemLogs
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvItemLogs = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblItemID = New System.Windows.Forms.Label()
        Me.lblItemName = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblAdded = New System.Windows.Forms.Label()
        Me.dtpDate = New MetroFramework.Controls.MetroDateTime()
        CType(Me.dgvItemLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemLogs
        '
        Me.dgvItemLogs.AllowUserToAddRows = False
        Me.dgvItemLogs.AllowUserToDeleteRows = False
        Me.dgvItemLogs.AllowUserToResizeRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemLogs.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvItemLogs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemLogs.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemLogs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemLogs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemLogs.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvItemLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemLogs.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgvItemLogs.DoubleBuffered = True
        Me.dgvItemLogs.EnableHeadersVisualStyles = False
        Me.dgvItemLogs.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemLogs.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemLogs.Location = New System.Drawing.Point(8, 180)
        Me.dgvItemLogs.MultiSelect = False
        Me.dgvItemLogs.Name = "dgvItemLogs"
        Me.dgvItemLogs.ReadOnly = True
        Me.dgvItemLogs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemLogs.RowHeadersVisible = False
        Me.dgvItemLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemLogs.Size = New System.Drawing.Size(740, 421)
        Me.dgvItemLogs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Item ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Current Quantity:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Added By:"
        '
        'lblItemID
        '
        Me.lblItemID.AutoSize = True
        Me.lblItemID.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemID.Location = New System.Drawing.Point(138, 71)
        Me.lblItemID.Name = "lblItemID"
        Me.lblItemID.Size = New System.Drawing.Size(53, 17)
        Me.lblItemID.TabIndex = 10
        Me.lblItemID.Text = "Item ID:"
        '
        'lblItemName
        '
        Me.lblItemName.AutoSize = True
        Me.lblItemName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemName.Location = New System.Drawing.Point(138, 88)
        Me.lblItemName.Name = "lblItemName"
        Me.lblItemName.Size = New System.Drawing.Size(77, 17)
        Me.lblItemName.TabIndex = 11
        Me.lblItemName.Text = "Item Name:"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.Location = New System.Drawing.Point(138, 105)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(106, 17)
        Me.lblQuantity.TabIndex = 11
        Me.lblQuantity.Text = "Current Quantity"
        '
        'lblAdded
        '
        Me.lblAdded.AutoSize = True
        Me.lblAdded.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAdded.Location = New System.Drawing.Point(474, 71)
        Me.lblAdded.Name = "lblAdded"
        Me.lblAdded.Size = New System.Drawing.Size(63, 17)
        Me.lblAdded.TabIndex = 12
        Me.lblAdded.Text = "lblAdded"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(513, 145)
        Me.dtpDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(235, 29)
        Me.dtpDate.TabIndex = 13
        '
        'frmInventoryItemLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 614)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblAdded)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblItemName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblItemID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvItemLogs)
        Me.MaximizeBox = False
        Me.Name = "frmInventoryItemLogs"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Item Inventory Logs"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dgvItemLogs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvItemLogs As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblItemID As Label
    Friend WithEvents lblItemName As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblAdded As Label
    Friend WithEvents dtpDate As MetroFramework.Controls.MetroDateTime
End Class
