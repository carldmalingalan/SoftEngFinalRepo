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
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dtpDateTo = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportPdf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnVoidTransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddTransactions = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dtpTransactionDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransactionDate.Location = New System.Drawing.Point(12, 16)
        Me.dtpTransactionDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpTransactionDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(113, 29)
        Me.dtpTransactionDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpTransactionDate.TabIndex = 17
        Me.dtpTransactionDate.UseCustomBackColor = True
        Me.dtpTransactionDate.UseCustomForeColor = True
        Me.dtpTransactionDate.UseStyleColors = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(154, 16)
        Me.dtpDateTo.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpDateTo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(113, 29)
        Me.dtpDateTo.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpDateTo.TabIndex = 17
        Me.dtpDateTo.UseCustomBackColor = True
        Me.dtpDateTo.UseCustomForeColor = True
        Me.dtpDateTo.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "-"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.search
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(273, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(29, 29)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'btnExportPdf
        '
        Me.btnExportPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportPdf.BackColor = System.Drawing.Color.Transparent
        Me.btnExportPdf.Image = Global.InventoryManager.My.Resources.Resources.pdf
        Me.btnExportPdf.ImageActive = Nothing
        Me.btnExportPdf.Location = New System.Drawing.Point(1047, 128)
        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Size = New System.Drawing.Size(46, 48)
        Me.btnExportPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportPdf.TabIndex = 19
        Me.btnExportPdf.TabStop = False
        Me.btnExportPdf.Zoom = 10
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Image = Global.InventoryManager.My.Resources.Resources.excel
        Me.btnExportExcel.ImageActive = Nothing
        Me.btnExportExcel.Location = New System.Drawing.Point(995, 128)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(46, 48)
        Me.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportExcel.TabIndex = 18
        Me.btnExportExcel.TabStop = False
        Me.btnExportExcel.Zoom = 10
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
        Me.btnVoidTransaction.Location = New System.Drawing.Point(951, 236)
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
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExportPdf)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.btnVoidTransaction)
        Me.Controls.Add(Me.btnAddTransactions)
        Me.Controls.Add(Me.dgvTransactionsList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransactions"
        Me.Text = "frmTransactions"
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvTransactionsList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVoidTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpTransactionDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnExportPdf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExportExcel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents dtpDateTo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
End Class
