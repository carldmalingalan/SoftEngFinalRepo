﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemCheckout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemCheckout))
        Me.txtSearchname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvSearchItem = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemsForCheckOut = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvSearchItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtSearchname.Location = New System.Drawing.Point(226, 12)
        Me.txtSearchname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchname.Name = "txtSearchname"
        Me.txtSearchname.Size = New System.Drawing.Size(160, 33)
        Me.txtSearchname.TabIndex = 41
        Me.txtSearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvSearchItem
        '
        Me.dgvSearchItem.AllowUserToAddRows = False
        Me.dgvSearchItem.AllowUserToDeleteRows = False
        Me.dgvSearchItem.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchItem.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchItem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.ItemName, Me.Quantity, Me.ItemsForCheckOut})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearchItem.DoubleBuffered = True
        Me.dgvSearchItem.EnableHeadersVisualStyles = False
        Me.dgvSearchItem.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvSearchItem.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvSearchItem.Location = New System.Drawing.Point(12, 57)
        Me.dgvSearchItem.MultiSelect = False
        Me.dgvSearchItem.Name = "dgvSearchItem"
        Me.dgvSearchItem.ReadOnly = True
        Me.dgvSearchItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchItem.RowHeadersVisible = False
        Me.dgvSearchItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchItem.Size = New System.Drawing.Size(414, 453)
        Me.dgvSearchItem.TabIndex = 43
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(393, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 42
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'ItemID
        '
        Me.ItemID.HeaderText = "Item ID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'ItemsForCheckOut
        '
        Me.ItemsForCheckOut.HeaderText = "Items Checkout"
        Me.ItemsForCheckOut.Name = "ItemsForCheckOut"
        Me.ItemsForCheckOut.ReadOnly = True
        '
        'frmItemCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(438, 526)
        Me.Controls.Add(Me.txtSearchname)
        Me.Controls.Add(Me.dgvSearchItem)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmItemCheckout"
        Me.Text = "frmItemCheckout"
        CType(Me.dgvSearchItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtSearchname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvSearchItem As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Button
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents ItemsForCheckOut As DataGridViewTextBoxColumn
End Class
