<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAccounts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccounts))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvUserList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnAddEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnExportUsers = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnDeactivateAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCreateAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.IndianRed
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 0
        '
        'dgvUserList
        '
        Me.dgvUserList.AllowUserToAddRows = False
        Me.dgvUserList.AllowUserToDeleteRows = False
        Me.dgvUserList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvUserList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvUserList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUserList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvUserList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvUserList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvUserList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvUserList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvUserList.DoubleBuffered = True
        Me.dgvUserList.EnableHeadersVisualStyles = False
        Me.dgvUserList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvUserList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvUserList.Location = New System.Drawing.Point(12, 120)
        Me.dgvUserList.MultiSelect = False
        Me.dgvUserList.Name = "dgvUserList"
        Me.dgvUserList.ReadOnly = True
        Me.dgvUserList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvUserList.RowHeadersVisible = False
        Me.dgvUserList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUserList.Size = New System.Drawing.Size(933, 375)
        Me.dgvUserList.TabIndex = 1
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
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 16)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(145, 98)
        Me.BunifuCards1.TabIndex = 4
        '
        'lblActiveCount
        '
        Me.lblActiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCount.Location = New System.Drawing.Point(25, 21)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(92, 39)
        Me.lblActiveCount.TabIndex = 6
        Me.lblActiveCount.Text = "999"
        Me.lblActiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ACTIVE USERS"
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
        Me.BunifuCards2.Location = New System.Drawing.Point(163, 16)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(151, 98)
        Me.BunifuCards2.TabIndex = 6
        '
        'lblInactiveCount
        '
        Me.lblInactiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiveCount.Location = New System.Drawing.Point(20, 21)
        Me.lblInactiveCount.Name = "lblInactiveCount"
        Me.lblInactiveCount.Size = New System.Drawing.Size(106, 39)
        Me.lblInactiveCount.TabIndex = 7
        Me.lblInactiveCount.Text = "999"
        Me.lblInactiveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "INACTIVE USERS"
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
        Me.txtSearch.Location = New System.Drawing.Point(667, 80)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 33)
        Me.txtSearch.TabIndex = 9
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(911, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 10
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAddEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEmployee.BorderRadius = 7
        Me.btnAddEmployee.ButtonText = "Password Reset"
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddEmployee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddEmployee.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_6_
        Me.btnAddEmployee.Iconimage_right = Nothing
        Me.btnAddEmployee.Iconimage_right_Selected = Nothing
        Me.btnAddEmployee.Iconimage_Selected = Nothing
        Me.btnAddEmployee.IconMarginLeft = 0
        Me.btnAddEmployee.IconMarginRight = 0
        Me.btnAddEmployee.IconRightVisible = True
        Me.btnAddEmployee.IconRightZoom = 0R
        Me.btnAddEmployee.IconVisible = True
        Me.btnAddEmployee.IconZoom = 90.0R
        Me.btnAddEmployee.IsTab = False
        Me.btnAddEmployee.Location = New System.Drawing.Point(951, 338)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btnAddEmployee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddEmployee.selected = False
        Me.btnAddEmployee.Size = New System.Drawing.Size(191, 48)
        Me.btnAddEmployee.TabIndex = 8
        Me.btnAddEmployee.Text = "Password Reset"
        Me.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmployee.Textcolor = System.Drawing.Color.White
        Me.btnAddEmployee.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btnExportUsers.Location = New System.Drawing.Point(951, 392)
        Me.btnExportUsers.Name = "btnExportUsers"
        Me.btnExportUsers.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportUsers.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportUsers.selected = False
        Me.btnExportUsers.Size = New System.Drawing.Size(191, 48)
        Me.btnExportUsers.TabIndex = 7
        Me.btnExportUsers.Text = "Export List"
        Me.btnExportUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportUsers.Textcolor = System.Drawing.Color.White
        Me.btnExportUsers.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnDeactivateAccount
        '
        Me.btnDeactivateAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeactivateAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDeactivateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeactivateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDeactivateAccount.BorderRadius = 7
        Me.btnDeactivateAccount.ButtonText = "Deactivate Account"
        Me.btnDeactivateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeactivateAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btnDeactivateAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDeactivateAccount.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_4_
        Me.btnDeactivateAccount.Iconimage_right = Nothing
        Me.btnDeactivateAccount.Iconimage_right_Selected = Nothing
        Me.btnDeactivateAccount.Iconimage_Selected = Nothing
        Me.btnDeactivateAccount.IconMarginLeft = 0
        Me.btnDeactivateAccount.IconMarginRight = 0
        Me.btnDeactivateAccount.IconRightVisible = True
        Me.btnDeactivateAccount.IconRightZoom = 0R
        Me.btnDeactivateAccount.IconVisible = True
        Me.btnDeactivateAccount.IconZoom = 90.0R
        Me.btnDeactivateAccount.IsTab = False
        Me.btnDeactivateAccount.Location = New System.Drawing.Point(951, 284)
        Me.btnDeactivateAccount.Name = "btnDeactivateAccount"
        Me.btnDeactivateAccount.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeactivateAccount.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDeactivateAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDeactivateAccount.selected = False
        Me.btnDeactivateAccount.Size = New System.Drawing.Size(191, 48)
        Me.btnDeactivateAccount.TabIndex = 3
        Me.btnDeactivateAccount.Text = "Deactivate Account"
        Me.btnDeactivateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeactivateAccount.Textcolor = System.Drawing.Color.White
        Me.btnDeactivateAccount.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateAccount
        '
        Me.btnUpdateAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateAccount.BorderRadius = 7
        Me.btnUpdateAccount.ButtonText = "Update Account"
        Me.btnUpdateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateAccount.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateAccount.Iconimage_right = Nothing
        Me.btnUpdateAccount.Iconimage_right_Selected = Nothing
        Me.btnUpdateAccount.Iconimage_Selected = Nothing
        Me.btnUpdateAccount.IconMarginLeft = 0
        Me.btnUpdateAccount.IconMarginRight = 0
        Me.btnUpdateAccount.IconRightVisible = True
        Me.btnUpdateAccount.IconRightZoom = 0R
        Me.btnUpdateAccount.IconVisible = True
        Me.btnUpdateAccount.IconZoom = 90.0R
        Me.btnUpdateAccount.IsTab = False
        Me.btnUpdateAccount.Location = New System.Drawing.Point(951, 230)
        Me.btnUpdateAccount.Name = "btnUpdateAccount"
        Me.btnUpdateAccount.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateAccount.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateAccount.selected = False
        Me.btnUpdateAccount.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateAccount.TabIndex = 3
        Me.btnUpdateAccount.Text = "Update Account"
        Me.btnUpdateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateAccount.Textcolor = System.Drawing.Color.White
        Me.btnUpdateAccount.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateAccount.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateAccount.BorderRadius = 7
        Me.btnCreateAccount.ButtonText = "Create Account"
        Me.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnCreateAccount.Iconimage_right = Nothing
        Me.btnCreateAccount.Iconimage_right_Selected = Nothing
        Me.btnCreateAccount.Iconimage_Selected = Nothing
        Me.btnCreateAccount.IconMarginLeft = 0
        Me.btnCreateAccount.IconMarginRight = 0
        Me.btnCreateAccount.IconRightVisible = True
        Me.btnCreateAccount.IconRightZoom = 0R
        Me.btnCreateAccount.IconVisible = True
        Me.btnCreateAccount.IconZoom = 90.0R
        Me.btnCreateAccount.IsTab = False
        Me.btnCreateAccount.Location = New System.Drawing.Point(951, 176)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateAccount.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateAccount.selected = False
        Me.btnCreateAccount.Size = New System.Drawing.Size(191, 48)
        Me.btnCreateAccount.TabIndex = 2
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateAccount.Textcolor = System.Drawing.Color.White
        Me.btnCreateAccount.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnExportUsers)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnDeactivateAccount)
        Me.Controls.Add(Me.btnUpdateAccount)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.dgvUserList)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAccounts"
        CType(Me.dgvUserList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgvUserList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnCreateAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnDeactivateAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnExportUsers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnSearch As Button
End Class
