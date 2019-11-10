<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmShowCheckoutlist
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShowCheckoutlist))
        Me.dgvItemForCheckOut = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtSearchname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvSearchItem = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnSearch = New System.Windows.Forms.Button()
        CType(Me.dgvItemForCheckOut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearchItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemForCheckOut
        '
        Me.dgvItemForCheckOut.AllowUserToAddRows = False
        Me.dgvItemForCheckOut.AllowUserToDeleteRows = False
        Me.dgvItemForCheckOut.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemForCheckOut.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemForCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemForCheckOut.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemForCheckOut.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemForCheckOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemForCheckOut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemForCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemForCheckOut.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemForCheckOut.DoubleBuffered = True
        Me.dgvItemForCheckOut.EnableHeadersVisualStyles = False
        Me.dgvItemForCheckOut.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemForCheckOut.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemForCheckOut.Location = New System.Drawing.Point(475, 75)
        Me.dgvItemForCheckOut.MultiSelect = False
        Me.dgvItemForCheckOut.Name = "dgvItemForCheckOut"
        Me.dgvItemForCheckOut.ReadOnly = True
        Me.dgvItemForCheckOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemForCheckOut.RowHeadersVisible = False
        Me.dgvItemForCheckOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemForCheckOut.Size = New System.Drawing.Size(429, 399)
        Me.dgvItemForCheckOut.TabIndex = 44
        '
        'btnRemove
        '
        Me.btnRemove.Activecolor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemove.BorderRadius = 7
        Me.btnRemove.ButtonText = "Remove"
        Me.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRemove.DisabledColor = System.Drawing.Color.Gray
        Me.btnRemove.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRemove.Iconimage = Global.InventoryManager.My.Resources.Resources.Trash
        Me.btnRemove.Iconimage_right = Nothing
        Me.btnRemove.Iconimage_right_Selected = Nothing
        Me.btnRemove.Iconimage_Selected = Nothing
        Me.btnRemove.IconMarginLeft = 0
        Me.btnRemove.IconMarginRight = 0
        Me.btnRemove.IconRightVisible = True
        Me.btnRemove.IconRightZoom = 0R
        Me.btnRemove.IconVisible = True
        Me.btnRemove.IconZoom = 90.0R
        Me.btnRemove.IsTab = False
        Me.btnRemove.Location = New System.Drawing.Point(714, 480)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRemove.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRemove.selected = False
        Me.btnRemove.Size = New System.Drawing.Size(119, 48)
        Me.btnRemove.TabIndex = 45
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRemove.Textcolor = System.Drawing.Color.White
        Me.btnRemove.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 7
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = Global.InventoryManager.My.Resources.Resources.save
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 90.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(589, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(119, 48)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.White
        Me.btnSave.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtSearchname
        '
        Me.txtSearchname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchname.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchname.HintText = "Search Item"
        Me.txtSearchname.isPassword = False
        Me.txtSearchname.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchname.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineThickness = 3
        Me.txtSearchname.Location = New System.Drawing.Point(36, 36)
        Me.txtSearchname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchname.Name = "txtSearchname"
        Me.txtSearchname.Size = New System.Drawing.Size(160, 33)
        Me.txtSearchname.TabIndex = 47
        Me.txtSearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvSearchItem
        '
        Me.dgvSearchItem.AllowUserToAddRows = False
        Me.dgvSearchItem.AllowUserToDeleteRows = False
        Me.dgvSearchItem.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSearchItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchItem.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSearchItem.DoubleBuffered = True
        Me.dgvSearchItem.EnableHeadersVisualStyles = False
        Me.dgvSearchItem.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvSearchItem.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvSearchItem.Location = New System.Drawing.Point(23, 75)
        Me.dgvSearchItem.MultiSelect = False
        Me.dgvSearchItem.Name = "dgvSearchItem"
        Me.dgvSearchItem.ReadOnly = True
        Me.dgvSearchItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchItem.RowHeadersVisible = False
        Me.dgvSearchItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchItem.Size = New System.Drawing.Size(435, 398)
        Me.dgvSearchItem.TabIndex = 49
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(203, 36)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 48
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'frmShowCheckoutlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 537)
        Me.Controls.Add(Me.txtSearchname)
        Me.Controls.Add(Me.dgvSearchItem)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvItemForCheckOut)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmShowCheckoutlist"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Items Checked Out"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dgvItemForCheckOut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearchItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvItemForCheckOut As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearchname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvSearchItem As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Button
End Class
