<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCustomer))
        Me.txtSearchname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.dgvSearchList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.lblResultCount = New System.Windows.Forms.Label()
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchname
        '
        Me.txtSearchname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchname.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchname.HintText = "Search Name"
        Me.txtSearchname.isPassword = False
        Me.txtSearchname.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchname.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineThickness = 3
        Me.txtSearchname.Location = New System.Drawing.Point(236, 25)
        Me.txtSearchname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchname.Name = "txtSearchname"
        Me.txtSearchname.Size = New System.Drawing.Size(206, 33)
        Me.txtSearchname.TabIndex = 0
        Me.txtSearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(449, 25)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'dgvSearchList
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchList.DoubleBuffered = True
        Me.dgvSearchList.EnableHeadersVisualStyles = False
        Me.dgvSearchList.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvSearchList.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.dgvSearchList.Location = New System.Drawing.Point(12, 64)
        Me.dgvSearchList.Name = "dgvSearchList"
        Me.dgvSearchList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchList.Size = New System.Drawing.Size(464, 237)
        Me.dgvSearchList.TabIndex = 12
        '
        'lblResultCount
        '
        Me.lblResultCount.AutoSize = True
        Me.lblResultCount.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultCount.Location = New System.Drawing.Point(9, 43)
        Me.lblResultCount.Name = "lblResultCount"
        Me.lblResultCount.Size = New System.Drawing.Size(0, 17)
        Me.lblResultCount.TabIndex = 13
        '
        'frmSearchCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(488, 309)
        Me.Controls.Add(Me.lblResultCount)
        Me.Controls.Add(Me.dgvSearchList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvSearchList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents lblResultCount As Label
End Class
