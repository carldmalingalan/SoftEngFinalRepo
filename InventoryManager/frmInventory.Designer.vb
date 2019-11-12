<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.cardCritStock = New Bunifu.Framework.UI.BunifuCards()
        Me.lblCritCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cardInStock = New Bunifu.Framework.UI.BunifuCards()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvItemList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.cardOutofStock = New Bunifu.Framework.UI.BunifuCards()
        Me.lblOutofstock = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdateItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cardExpiringItem = New Bunifu.Framework.UI.BunifuCards()
        Me.lblExpiring = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExportPdf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cardCritStock.SuspendLayout()
        Me.cardInStock.SuspendLayout()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cardOutofStock.SuspendLayout()
        Me.cardExpiringItem.SuspendLayout()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cardCritStock
        '
        Me.cardCritStock.BackColor = System.Drawing.Color.White
        Me.cardCritStock.BorderRadius = 5
        Me.cardCritStock.BottomSahddow = True
        Me.cardCritStock.color = System.Drawing.Color.Orange
        Me.cardCritStock.Controls.Add(Me.lblCritCount)
        Me.cardCritStock.Controls.Add(Me.Label2)
        Me.cardCritStock.LeftSahddow = False
        Me.cardCritStock.Location = New System.Drawing.Point(134, 16)
        Me.cardCritStock.Name = "cardCritStock"
        Me.cardCritStock.RightSahddow = True
        Me.cardCritStock.ShadowDepth = 20
        Me.cardCritStock.Size = New System.Drawing.Size(152, 76)
        Me.cardCritStock.TabIndex = 13
        '
        'lblCritCount
        '
        Me.lblCritCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCritCount.Location = New System.Drawing.Point(6, 9)
        Me.lblCritCount.Name = "lblCritCount"
        Me.lblCritCount.Size = New System.Drawing.Size(143, 39)
        Me.lblCritCount.TabIndex = 7
        Me.lblCritCount.Text = "999"
        Me.lblCritCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CRITICAL-POINT ITEMS"
        '
        'cardInStock
        '
        Me.cardInStock.BackColor = System.Drawing.Color.White
        Me.cardInStock.BorderRadius = 5
        Me.cardInStock.BottomSahddow = True
        Me.cardInStock.color = System.Drawing.Color.Green
        Me.cardInStock.Controls.Add(Me.lblActiveCount)
        Me.cardInStock.Controls.Add(Me.Label1)
        Me.cardInStock.LeftSahddow = False
        Me.cardInStock.Location = New System.Drawing.Point(12, 16)
        Me.cardInStock.Name = "cardInStock"
        Me.cardInStock.RightSahddow = True
        Me.cardInStock.ShadowDepth = 20
        Me.cardInStock.Size = New System.Drawing.Size(116, 76)
        Me.cardInStock.TabIndex = 12
        '
        'lblActiveCount
        '
        Me.lblActiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCount.Location = New System.Drawing.Point(6, 9)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(105, 39)
        Me.lblActiveCount.TabIndex = 6
        Me.lblActiveCount.Text = "999"
        Me.lblActiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ITEMS IN STOCK"
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToDeleteRows = False
        Me.dgvItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemList.DoubleBuffered = True
        Me.dgvItemList.EnableHeadersVisualStyles = False
        Me.dgvItemList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemList.Location = New System.Drawing.Point(12, 121)
        Me.dgvItemList.MultiSelect = False
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(933, 372)
        Me.dgvItemList.TabIndex = 8
        '
        'cardOutofStock
        '
        Me.cardOutofStock.BackColor = System.Drawing.Color.White
        Me.cardOutofStock.BorderRadius = 5
        Me.cardOutofStock.BottomSahddow = True
        Me.cardOutofStock.color = System.Drawing.Color.Red
        Me.cardOutofStock.Controls.Add(Me.lblOutofstock)
        Me.cardOutofStock.Controls.Add(Me.Label4)
        Me.cardOutofStock.LeftSahddow = False
        Me.cardOutofStock.Location = New System.Drawing.Point(292, 16)
        Me.cardOutofStock.Name = "cardOutofStock"
        Me.cardOutofStock.RightSahddow = True
        Me.cardOutofStock.ShadowDepth = 20
        Me.cardOutofStock.Size = New System.Drawing.Size(144, 76)
        Me.cardOutofStock.TabIndex = 14
        '
        'lblOutofstock
        '
        Me.lblOutofstock.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutofstock.Location = New System.Drawing.Point(6, 11)
        Me.lblOutofstock.Name = "lblOutofstock"
        Me.lblOutofstock.Size = New System.Drawing.Size(135, 39)
        Me.lblOutofstock.TabIndex = 7
        Me.lblOutofstock.Text = "999"
        Me.lblOutofstock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "OUT OF STOCK ITEMS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 19
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Silver
        Me.txtSearch.HintText = "Search"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(669, 81)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 33)
        Me.txtSearch.TabIndex = 31
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(912, 82)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateItem.BorderRadius = 7
        Me.btnUpdateItem.ButtonText = "Update Item"
        Me.btnUpdateItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateItem.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateItem.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateItem.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateItem.Iconimage_right = Nothing
        Me.btnUpdateItem.Iconimage_right_Selected = Nothing
        Me.btnUpdateItem.Iconimage_Selected = Nothing
        Me.btnUpdateItem.IconMarginLeft = 0
        Me.btnUpdateItem.IconMarginRight = 0
        Me.btnUpdateItem.IconRightVisible = True
        Me.btnUpdateItem.IconRightZoom = 0R
        Me.btnUpdateItem.IconVisible = True
        Me.btnUpdateItem.IconZoom = 90.0R
        Me.btnUpdateItem.IsTab = False
        Me.btnUpdateItem.Location = New System.Drawing.Point(951, 228)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateItem.selected = False
        Me.btnUpdateItem.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateItem.TabIndex = 11
        Me.btnUpdateItem.Text = "Update Item"
        Me.btnUpdateItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateItem.Textcolor = System.Drawing.Color.White
        Me.btnUpdateItem.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddItem
        '
        Me.btnAddItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddItem.BorderRadius = 7
        Me.btnAddItem.ButtonText = "Add Item"
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddItem.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddItem.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddItem.Iconimage_right = Nothing
        Me.btnAddItem.Iconimage_right_Selected = Nothing
        Me.btnAddItem.Iconimage_Selected = Nothing
        Me.btnAddItem.IconMarginLeft = 0
        Me.btnAddItem.IconMarginRight = 0
        Me.btnAddItem.IconRightVisible = True
        Me.btnAddItem.IconRightZoom = 0R
        Me.btnAddItem.IconVisible = True
        Me.btnAddItem.IconZoom = 90.0R
        Me.btnAddItem.IsTab = False
        Me.btnAddItem.Location = New System.Drawing.Point(951, 174)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddItem.selected = False
        Me.btnAddItem.Size = New System.Drawing.Size(191, 48)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Textcolor = System.Drawing.Color.White
        Me.btnAddItem.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cardExpiringItem
        '
        Me.cardExpiringItem.BackColor = System.Drawing.Color.White
        Me.cardExpiringItem.BorderRadius = 5
        Me.cardExpiringItem.BottomSahddow = True
        Me.cardExpiringItem.color = System.Drawing.Color.Teal
        Me.cardExpiringItem.Controls.Add(Me.lblExpiring)
        Me.cardExpiringItem.Controls.Add(Me.Label6)
        Me.cardExpiringItem.LeftSahddow = False
        Me.cardExpiringItem.Location = New System.Drawing.Point(442, 16)
        Me.cardExpiringItem.Name = "cardExpiringItem"
        Me.cardExpiringItem.RightSahddow = True
        Me.cardExpiringItem.ShadowDepth = 20
        Me.cardExpiringItem.Size = New System.Drawing.Size(114, 76)
        Me.cardExpiringItem.TabIndex = 15
        Me.cardExpiringItem.Visible = False
        '
        'lblExpiring
        '
        Me.lblExpiring.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpiring.Location = New System.Drawing.Point(3, 11)
        Me.lblExpiring.Name = "lblExpiring"
        Me.lblExpiring.Size = New System.Drawing.Size(108, 39)
        Me.lblExpiring.TabIndex = 7
        Me.lblExpiring.Text = "999"
        Me.lblExpiring.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "EXPIRING ITEMS"
        '
        'btnExportPdf
        '
        Me.btnExportPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportPdf.BackColor = System.Drawing.Color.Transparent
        Me.btnExportPdf.Image = Global.InventoryManager.My.Resources.Resources.pdf
        Me.btnExportPdf.ImageActive = Nothing
        Me.btnExportPdf.Location = New System.Drawing.Point(1052, 120)
        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Size = New System.Drawing.Size(46, 48)
        Me.btnExportPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportPdf.TabIndex = 34
        Me.btnExportPdf.TabStop = False
        Me.btnExportPdf.Zoom = 10
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Image = Global.InventoryManager.My.Resources.Resources.excel
        Me.btnExportExcel.ImageActive = Nothing
        Me.btnExportExcel.Location = New System.Drawing.Point(1000, 120)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(46, 48)
        Me.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportExcel.TabIndex = 33
        Me.btnExportExcel.TabStop = False
        Me.btnExportExcel.Zoom = 10
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnExportPdf)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.cardExpiringItem)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cardOutofStock)
        Me.Controls.Add(Me.cardCritStock)
        Me.Controls.Add(Me.cardInStock)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventory"
        Me.cardCritStock.ResumeLayout(False)
        Me.cardCritStock.PerformLayout()
        Me.cardInStock.ResumeLayout(False)
        Me.cardInStock.PerformLayout()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cardOutofStock.ResumeLayout(False)
        Me.cardOutofStock.PerformLayout()
        Me.cardExpiringItem.ResumeLayout(False)
        Me.cardExpiringItem.PerformLayout()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cardCritStock As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblCritCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cardInStock As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvItemList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents cardOutofStock As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblOutofstock As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents cardExpiringItem As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblExpiring As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExportPdf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExportExcel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
