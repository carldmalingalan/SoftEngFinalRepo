<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Me.dgvTransactionsList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpTransactionDate = New MetroFramework.Controls.MetroDateTime()
        Me.btnExportUsers = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnVoidTransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddTransactions = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateTransactions = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTransactionsList
        '
        Me.dgvTransactionsList.AllowUserToAddRows = False
        Me.dgvTransactionsList.AllowUserToDeleteRows = False
        Me.dgvTransactionsList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTransactionsList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactionsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactionsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactionsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactionsList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTransactionsList.DoubleBuffered = True
        Me.dgvTransactionsList.EnableHeadersVisualStyles = False
        Me.dgvTransactionsList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvTransactionsList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvTransactionsList.Location = New System.Drawing.Point(12, 51)
        Me.dgvTransactionsList.MultiSelect = False
        Me.dgvTransactionsList.Name = "dgvTransactionsList"
        Me.dgvTransactionsList.ReadOnly = True
        Me.dgvTransactionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactionsList.RowHeadersVisible = False
        Me.dgvTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactionsList.Size = New System.Drawing.Size(933, 450)
        Me.dgvTransactionsList.TabIndex = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 9
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.Location = New System.Drawing.Point(12, 16)
        Me.dtpTransactionDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpTransactionDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(252, 29)
        Me.dtpTransactionDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpTransactionDate.TabIndex = 17
        Me.dtpTransactionDate.UseCustomBackColor = True
        Me.dtpTransactionDate.UseCustomForeColor = True
        Me.dtpTransactionDate.UseStyleColors = True
        '
        'btnExportUsers
        '
        Me.btnExportUsers.Activecolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportUsers.BorderRadius = 7
        Me.btnExportUsers.ButtonText = "Export List"
        Me.btnExportUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportUsers.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportUsers.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportUsers.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnExportUsers.Iconimage_right = Nothing
        Me.btnExportUsers.Iconimage_right_Selected = Nothing
        Me.btnExportUsers.Iconimage_Selected = Nothing
        Me.btnExportUsers.IconMarginLeft = 0
        Me.btnExportUsers.IconMarginRight = 0
        Me.btnExportUsers.IconRightVisible = True
        Me.btnExportUsers.IconRightZoom = 0R
        Me.btnExportUsers.IconVisible = True
        Me.btnExportUsers.IconZoom = 90.0R
        Me.btnExportUsers.IsTab = False
        Me.btnExportUsers.Location = New System.Drawing.Point(951, 344)
        Me.btnExportUsers.Name = "btnExportUsers"
        Me.btnExportUsers.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportUsers.selected = False
        Me.btnExportUsers.Size = New System.Drawing.Size(191, 48)
        Me.btnExportUsers.TabIndex = 16
        Me.btnExportUsers.Text = "Export List"
        Me.btnExportUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportUsers.Textcolor = System.Drawing.Color.White
        Me.btnExportUsers.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnVoidTransaction
        '
        Me.btnVoidTransaction.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVoidTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVoidTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVoidTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVoidTransaction.BorderRadius = 7
        Me.btnVoidTransaction.ButtonText = "Void Transaction"
        Me.btnVoidTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVoidTransaction.DisabledColor = System.Drawing.Color.Gray
        Me.btnVoidTransaction.Iconcolor = System.Drawing.Color.Transparent
        Me.btnVoidTransaction.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_4_
        Me.btnVoidTransaction.Iconimage_right = Nothing
        Me.btnVoidTransaction.Iconimage_right_Selected = Nothing
        Me.btnVoidTransaction.Iconimage_Selected = Nothing
        Me.btnVoidTransaction.IconMarginLeft = 0
        Me.btnVoidTransaction.IconMarginRight = 0
        Me.btnVoidTransaction.IconRightVisible = True
        Me.btnVoidTransaction.IconRightZoom = 0R
        Me.btnVoidTransaction.IconVisible = True
        Me.btnVoidTransaction.IconZoom = 90.0R
        Me.btnVoidTransaction.IsTab = False
        Me.btnVoidTransaction.Location = New System.Drawing.Point(951, 290)
        Me.btnVoidTransaction.Name = "btnVoidTransaction"
        Me.btnVoidTransaction.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVoidTransaction.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVoidTransaction.OnHoverTextColor = System.Drawing.Color.White
        Me.btnVoidTransaction.selected = False
        Me.btnVoidTransaction.Size = New System.Drawing.Size(191, 48)
        Me.btnVoidTransaction.TabIndex = 12
        Me.btnVoidTransaction.Text = "Void Transaction"
        Me.btnVoidTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVoidTransaction.Textcolor = System.Drawing.Color.White
        Me.btnVoidTransaction.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddTransactions
        '
        Me.btnAddTransactions.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTransactions.BorderRadius = 7
        Me.btnAddTransactions.ButtonText = "Create Transaction"
        Me.btnAddTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTransactions.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddTransactions.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddTransactions.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddTransactions.Iconimage_right = Nothing
        Me.btnAddTransactions.Iconimage_right_Selected = Nothing
        Me.btnAddTransactions.Iconimage_Selected = Nothing
        Me.btnAddTransactions.IconMarginLeft = 0
        Me.btnAddTransactions.IconMarginRight = 0
        Me.btnAddTransactions.IconRightVisible = True
        Me.btnAddTransactions.IconRightZoom = 0R
        Me.btnAddTransactions.IconVisible = True
        Me.btnAddTransactions.IconZoom = 90.0R
        Me.btnAddTransactions.IsTab = False
        Me.btnAddTransactions.Location = New System.Drawing.Point(951, 182)
        Me.btnAddTransactions.Name = "btnAddTransactions"
        Me.btnAddTransactions.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddTransactions.selected = False
        Me.btnAddTransactions.Size = New System.Drawing.Size(191, 48)
        Me.btnAddTransactions.TabIndex = 11
        Me.btnAddTransactions.Text = "Create Transaction"
        Me.btnAddTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTransactions.Textcolor = System.Drawing.Color.White
        Me.btnAddTransactions.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateTransactions
        '
        Me.btnUpdateTransactions.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateTransactions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateTransactions.BorderRadius = 7
        Me.btnUpdateTransactions.ButtonText = "Update Transaction"
        Me.btnUpdateTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateTransactions.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateTransactions.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateTransactions.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateTransactions.Iconimage_right = Nothing
        Me.btnUpdateTransactions.Iconimage_right_Selected = Nothing
        Me.btnUpdateTransactions.Iconimage_Selected = Nothing
        Me.btnUpdateTransactions.IconMarginLeft = 0
        Me.btnUpdateTransactions.IconMarginRight = 0
        Me.btnUpdateTransactions.IconRightVisible = True
        Me.btnUpdateTransactions.IconRightZoom = 0R
        Me.btnUpdateTransactions.IconVisible = True
        Me.btnUpdateTransactions.IconZoom = 90.0R
        Me.btnUpdateTransactions.IsTab = False
        Me.btnUpdateTransactions.Location = New System.Drawing.Point(951, 236)
        Me.btnUpdateTransactions.Name = "btnUpdateTransactions"
        Me.btnUpdateTransactions.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateTransactions.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateTransactions.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateTransactions.selected = False
        Me.btnUpdateTransactions.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateTransactions.TabIndex = 13
        Me.btnUpdateTransactions.Text = "Update Transaction"
        Me.btnUpdateTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateTransactions.Textcolor = System.Drawing.Color.White
        Me.btnUpdateTransactions.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.btnExportUsers)
        Me.Controls.Add(Me.btnVoidTransaction)
        Me.Controls.Add(Me.btnAddTransactions)
        Me.Controls.Add(Me.btnUpdateTransactions)
        Me.Controls.Add(Me.dgvTransactionsList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransactions"
        Me.Text = "frmTransactions"
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExportUsers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvTransactionsList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVoidTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpTransactionDate As MetroFramework.Controls.MetroDateTime
End Class
