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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvItemList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemQuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemClassificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblInventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JandADataSet3 = New InventoryManager.JandADataSet3()
        Me.btnExportItemList = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TblInventoryTableAdapter = New InventoryManager.JandADataSet3TableAdapters.tblInventoryTableAdapter()
        Me.BunifuCards3 = New Bunifu.Framework.UI.BunifuCards()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JandADataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards3.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.IndianRed
        Me.BunifuCards2.Controls.Add(Me.lblInactiveCount)
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(193, 14)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(175, 131)
        Me.BunifuCards2.TabIndex = 13
        '
        'lblInactiveCount
        '
        Me.lblInactiveCount.AutoSize = True
        Me.lblInactiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiveCount.Location = New System.Drawing.Point(54, 44)
        Me.lblInactiveCount.Name = "lblInactiveCount"
        Me.lblInactiveCount.Size = New System.Drawing.Size(71, 39)
        Me.lblInactiveCount.TabIndex = 7
        Me.lblInactiveCount.Text = "999"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CRITICALLY STOCK ITEMS"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.IndianRed
        Me.BunifuCards1.Controls.Add(Me.lblActiveCount)
        Me.BunifuCards1.Controls.Add(Me.Label1)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 14)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(175, 131)
        Me.BunifuCards1.TabIndex = 12
        '
        'lblActiveCount
        '
        Me.lblActiveCount.AutoSize = True
        Me.lblActiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCount.Location = New System.Drawing.Point(52, 44)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(71, 39)
        Me.lblActiveCount.TabIndex = 6
        Me.lblActiveCount.Text = "999"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 103)
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
        Me.dgvItemList.AutoGenerateColumns = False
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemList.BackgroundColor = System.Drawing.Color.Gainsboro
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
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemNameDataGridViewTextBoxColumn, Me.ItemQuantityDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.ItemClassificationDataGridViewTextBoxColumn})
        Me.dgvItemList.DataSource = Me.TblInventoryBindingSource
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
        Me.dgvItemList.Location = New System.Drawing.Point(12, 148)
        Me.dgvItemList.MultiSelect = False
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(933, 345)
        Me.dgvItemList.TabIndex = 8
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "ItemName"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemQuantityDataGridViewTextBoxColumn
        '
        Me.ItemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity"
        Me.ItemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity"
        Me.ItemQuantityDataGridViewTextBoxColumn.Name = "ItemQuantityDataGridViewTextBoxColumn"
        Me.ItemQuantityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        Me.ItemDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemClassificationDataGridViewTextBoxColumn
        '
        Me.ItemClassificationDataGridViewTextBoxColumn.DataPropertyName = "ItemClassification"
        Me.ItemClassificationDataGridViewTextBoxColumn.HeaderText = "ItemClassification"
        Me.ItemClassificationDataGridViewTextBoxColumn.Name = "ItemClassificationDataGridViewTextBoxColumn"
        Me.ItemClassificationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TblInventoryBindingSource
        '
        Me.TblInventoryBindingSource.DataMember = "tblInventory"
        Me.TblInventoryBindingSource.DataSource = Me.JandADataSet3
        '
        'JandADataSet3
        '
        Me.JandADataSet3.DataSetName = "JandADataSet3"
        Me.JandADataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExportItemList
        '
        Me.btnExportItemList.Activecolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportItemList.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportItemList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportItemList.BorderRadius = 7
        Me.btnExportItemList.ButtonText = "Export List"
        Me.btnExportItemList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportItemList.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportItemList.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportItemList.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnExportItemList.Iconimage_right = Nothing
        Me.btnExportItemList.Iconimage_right_Selected = Nothing
        Me.btnExportItemList.Iconimage_Selected = Nothing
        Me.btnExportItemList.IconMarginLeft = 0
        Me.btnExportItemList.IconMarginRight = 0
        Me.btnExportItemList.IconRightVisible = True
        Me.btnExportItemList.IconRightZoom = 0R
        Me.btnExportItemList.IconVisible = True
        Me.btnExportItemList.IconZoom = 90.0R
        Me.btnExportItemList.IsTab = False
        Me.btnExportItemList.Location = New System.Drawing.Point(951, 282)
        Me.btnExportItemList.Name = "btnExportItemList"
        Me.btnExportItemList.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportItemList.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportItemList.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportItemList.selected = False
        Me.btnExportItemList.Size = New System.Drawing.Size(191, 48)
        Me.btnExportItemList.TabIndex = 14
        Me.btnExportItemList.Text = "Export List"
        Me.btnExportItemList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportItemList.Textcolor = System.Drawing.Color.White
        Me.btnExportItemList.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
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
        'TblInventoryTableAdapter
        '
        Me.TblInventoryTableAdapter.ClearBeforeFill = True
        '
        'BunifuCards3
        '
        Me.BunifuCards3.BackColor = System.Drawing.Color.White
        Me.BunifuCards3.BorderRadius = 5
        Me.BunifuCards3.BottomSahddow = True
        Me.BunifuCards3.color = System.Drawing.Color.IndianRed
        Me.BunifuCards3.Controls.Add(Me.Label3)
        Me.BunifuCards3.Controls.Add(Me.Label4)
        Me.BunifuCards3.LeftSahddow = False
        Me.BunifuCards3.Location = New System.Drawing.Point(374, 14)
        Me.BunifuCards3.Name = "BunifuCards3"
        Me.BunifuCards3.RightSahddow = True
        Me.BunifuCards3.ShadowDepth = 20
        Me.BunifuCards3.Size = New System.Drawing.Size(175, 131)
        Me.BunifuCards3.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 39)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "999"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "OUT OF STOCK ITEMS"
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.BunifuCards3)
        Me.Controls.Add(Me.btnExportItemList)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventory"
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JandADataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards3.ResumeLayout(False)
        Me.BunifuCards3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExportItemList As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvItemList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents JandADataSet3 As JandADataSet3
    Friend WithEvents TblInventoryBindingSource As BindingSource
    Friend WithEvents TblInventoryTableAdapter As JandADataSet3TableAdapters.tblInventoryTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemQuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemClassificationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCards3 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
