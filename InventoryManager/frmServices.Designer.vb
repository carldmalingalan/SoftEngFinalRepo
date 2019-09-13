<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServices))
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblInactiveCount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.lblActiveCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvServiceList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnExportServices = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateService = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCreateService = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.gbServiceDetails = New System.Windows.Forms.GroupBox()
        Me.switchServiceStatus = New Bunifu.Framework.UI.BunifuSwitch()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboNails = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cboHair = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cboBody = New MaterialSkin.Controls.MaterialCheckBox()
        Me.btnCancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtServiceDetails = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtServiceName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbServiceDetails.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BunifuCards2.Location = New System.Drawing.Point(163, 14)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(151, 98)
        Me.BunifuCards2.TabIndex = 14
        '
        'lblInactiveCount
        '
        Me.lblInactiveCount.AutoSize = True
        Me.lblInactiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInactiveCount.Location = New System.Drawing.Point(37, 21)
        Me.lblInactiveCount.Name = "lblInactiveCount"
        Me.lblInactiveCount.Size = New System.Drawing.Size(71, 39)
        Me.lblInactiveCount.TabIndex = 7
        Me.lblInactiveCount.Text = "999"
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
        Me.BunifuCards1.Size = New System.Drawing.Size(145, 98)
        Me.BunifuCards1.TabIndex = 13
        '
        'lblActiveCount
        '
        Me.lblActiveCount.AutoSize = True
        Me.lblActiveCount.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActiveCount.Location = New System.Drawing.Point(34, 21)
        Me.lblActiveCount.Name = "lblActiveCount"
        Me.lblActiveCount.Size = New System.Drawing.Size(71, 39)
        Me.lblActiveCount.TabIndex = 6
        Me.lblActiveCount.Text = "999"
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
        'dgvServiceList
        '
        Me.dgvServiceList.AllowUserToAddRows = False
        Me.dgvServiceList.AllowUserToDeleteRows = False
        Me.dgvServiceList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvServiceList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiceList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvServiceList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServiceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServiceList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServiceList.DoubleBuffered = True
        Me.dgvServiceList.EnableHeadersVisualStyles = False
        Me.dgvServiceList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvServiceList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvServiceList.Location = New System.Drawing.Point(12, 148)
        Me.dgvServiceList.MultiSelect = False
        Me.dgvServiceList.Name = "dgvServiceList"
        Me.dgvServiceList.ReadOnly = True
        Me.dgvServiceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvServiceList.RowHeadersVisible = False
        Me.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceList.Size = New System.Drawing.Size(512, 345)
        Me.dgvServiceList.TabIndex = 9
        '
        'btnExportServices
        '
        Me.btnExportServices.Activecolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportServices.BorderRadius = 7
        Me.btnExportServices.ButtonText = "Export List"
        Me.btnExportServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportServices.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportServices.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportServices.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnExportServices.Iconimage_right = Nothing
        Me.btnExportServices.Iconimage_right_Selected = Nothing
        Me.btnExportServices.Iconimage_Selected = Nothing
        Me.btnExportServices.IconMarginLeft = 0
        Me.btnExportServices.IconMarginRight = 0
        Me.btnExportServices.IconRightVisible = True
        Me.btnExportServices.IconRightZoom = 0R
        Me.btnExportServices.IconVisible = True
        Me.btnExportServices.IconZoom = 90.0R
        Me.btnExportServices.IsTab = False
        Me.btnExportServices.Location = New System.Drawing.Point(951, 282)
        Me.btnExportServices.Name = "btnExportServices"
        Me.btnExportServices.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportServices.selected = False
        Me.btnExportServices.Size = New System.Drawing.Size(191, 48)
        Me.btnExportServices.TabIndex = 15
        Me.btnExportServices.Text = "Export List"
        Me.btnExportServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportServices.Textcolor = System.Drawing.Color.White
        Me.btnExportServices.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateService
        '
        Me.btnUpdateService.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateService.BorderRadius = 7
        Me.btnUpdateService.ButtonText = "Update Service"
        Me.btnUpdateService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateService.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateService.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateService.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateService.Iconimage_right = Nothing
        Me.btnUpdateService.Iconimage_right_Selected = Nothing
        Me.btnUpdateService.Iconimage_Selected = Nothing
        Me.btnUpdateService.IconMarginLeft = 0
        Me.btnUpdateService.IconMarginRight = 0
        Me.btnUpdateService.IconRightVisible = True
        Me.btnUpdateService.IconRightZoom = 0R
        Me.btnUpdateService.IconVisible = True
        Me.btnUpdateService.IconZoom = 90.0R
        Me.btnUpdateService.IsTab = False
        Me.btnUpdateService.Location = New System.Drawing.Point(951, 228)
        Me.btnUpdateService.Name = "btnUpdateService"
        Me.btnUpdateService.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateService.selected = False
        Me.btnUpdateService.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateService.TabIndex = 12
        Me.btnUpdateService.Text = "Update Service"
        Me.btnUpdateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateService.Textcolor = System.Drawing.Color.White
        Me.btnUpdateService.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCreateService
        '
        Me.btnCreateService.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateService.BorderRadius = 7
        Me.btnCreateService.ButtonText = "Add Service"
        Me.btnCreateService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateService.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateService.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateService.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnCreateService.Iconimage_right = Nothing
        Me.btnCreateService.Iconimage_right_Selected = Nothing
        Me.btnCreateService.Iconimage_Selected = Nothing
        Me.btnCreateService.IconMarginLeft = 0
        Me.btnCreateService.IconMarginRight = 0
        Me.btnCreateService.IconRightVisible = True
        Me.btnCreateService.IconRightZoom = 0R
        Me.btnCreateService.IconVisible = True
        Me.btnCreateService.IconZoom = 90.0R
        Me.btnCreateService.IsTab = False
        Me.btnCreateService.Location = New System.Drawing.Point(951, 174)
        Me.btnCreateService.Name = "btnCreateService"
        Me.btnCreateService.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateService.selected = False
        Me.btnCreateService.Size = New System.Drawing.Size(191, 48)
        Me.btnCreateService.TabIndex = 10
        Me.btnCreateService.Text = "Add Service"
        Me.btnCreateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateService.Textcolor = System.Drawing.Color.White
        Me.btnCreateService.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'gbServiceDetails
        '
        Me.gbServiceDetails.Controls.Add(Me.switchServiceStatus)
        Me.gbServiceDetails.Controls.Add(Me.Label11)
        Me.gbServiceDetails.Controls.Add(Me.cboNails)
        Me.gbServiceDetails.Controls.Add(Me.cboHair)
        Me.gbServiceDetails.Controls.Add(Me.cboBody)
        Me.gbServiceDetails.Controls.Add(Me.btnCancel)
        Me.gbServiceDetails.Controls.Add(Me.btnSave)
        Me.gbServiceDetails.Controls.Add(Me.txtServiceDetails)
        Me.gbServiceDetails.Controls.Add(Me.txtServiceName)
        Me.gbServiceDetails.Controls.Add(Me.Label9)
        Me.gbServiceDetails.Controls.Add(Me.Label5)
        Me.gbServiceDetails.Controls.Add(Me.Label3)
        Me.gbServiceDetails.Enabled = False
        Me.gbServiceDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbServiceDetails.Location = New System.Drawing.Point(530, 148)
        Me.gbServiceDetails.Name = "gbServiceDetails"
        Me.gbServiceDetails.Size = New System.Drawing.Size(415, 266)
        Me.gbServiceDetails.TabIndex = 29
        Me.gbServiceDetails.TabStop = False
        Me.gbServiceDetails.Text = "Service Details"
        '
        'switchServiceStatus
        '
        Me.switchServiceStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.switchServiceStatus.BorderRadius = 0
        Me.switchServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchServiceStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.switchServiceStatus.Location = New System.Drawing.Point(133, 144)
        Me.switchServiceStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.switchServiceStatus.Name = "switchServiceStatus"
        Me.switchServiceStatus.Oncolor = System.Drawing.Color.SeaGreen
        Me.switchServiceStatus.Onoffcolor = System.Drawing.Color.DarkGray
        Me.switchServiceStatus.Size = New System.Drawing.Size(51, 19)
        Me.switchServiceStatus.TabIndex = 40
        Me.switchServiceStatus.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.switchServiceStatus.Value = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 146)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Status:"
        '
        'cboNails
        '
        Me.cboNails.AutoSize = True
        Me.cboNails.Depth = 0
        Me.cboNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboNails.Location = New System.Drawing.Point(281, 66)
        Me.cboNails.Margin = New System.Windows.Forms.Padding(0)
        Me.cboNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboNails.Name = "cboNails"
        Me.cboNails.Ripple = True
        Me.cboNails.Size = New System.Drawing.Size(68, 30)
        Me.cboNails.TabIndex = 37
        Me.cboNails.Text = "NAILS"
        Me.cboNails.UseVisualStyleBackColor = True
        '
        'cboHair
        '
        Me.cboHair.AutoSize = True
        Me.cboHair.Depth = 0
        Me.cboHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboHair.Location = New System.Drawing.Point(208, 66)
        Me.cboHair.Margin = New System.Windows.Forms.Padding(0)
        Me.cboHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboHair.Name = "cboHair"
        Me.cboHair.Ripple = True
        Me.cboHair.Size = New System.Drawing.Size(61, 30)
        Me.cboHair.TabIndex = 36
        Me.cboHair.Text = "HAIR"
        Me.cboHair.UseVisualStyleBackColor = True
        '
        'cboBody
        '
        Me.cboBody.AutoSize = True
        Me.cboBody.Depth = 0
        Me.cboBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboBody.Location = New System.Drawing.Point(131, 66)
        Me.cboBody.Margin = New System.Windows.Forms.Padding(0)
        Me.cboBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboBody.Name = "cboBody"
        Me.cboBody.Ripple = True
        Me.cboBody.Size = New System.Drawing.Size(65, 30)
        Me.cboBody.TabIndex = 35
        Me.cboBody.Text = "BODY"
        Me.cboBody.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(210, 208)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = False
        Me.btnCancel.Size = New System.Drawing.Size(64, 36)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(156, 208)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = False
        Me.btnSave.Size = New System.Drawing.Size(46, 36)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtServiceDetails
        '
        Me.txtServiceDetails.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtServiceDetails.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceDetails.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtServiceDetails.BorderThickness = 3
        Me.txtServiceDetails.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServiceDetails.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceDetails.isPassword = False
        Me.txtServiceDetails.Location = New System.Drawing.Point(133, 101)
        Me.txtServiceDetails.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServiceDetails.Name = "txtServiceDetails"
        Me.txtServiceDetails.Size = New System.Drawing.Size(247, 31)
        Me.txtServiceDetails.TabIndex = 30
        Me.txtServiceDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtServiceName
        '
        Me.txtServiceName.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtServiceName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceName.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtServiceName.BorderThickness = 3
        Me.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceName.isPassword = False
        Me.txtServiceName.Location = New System.Drawing.Point(133, 23)
        Me.txtServiceName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(247, 31)
        Me.txtServiceName.TabIndex = 28
        Me.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Service Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Service Type:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Name:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.gbServiceDetails)
        Me.Controls.Add(Me.btnExportServices)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.btnUpdateService)
        Me.Controls.Add(Me.btnCreateService)
        Me.Controls.Add(Me.dgvServiceList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServices"
        Me.Text = "frmServices"
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbServiceDetails.ResumeLayout(False)
        Me.gbServiceDetails.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportServices As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblInactiveCount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblActiveCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnUpdateService As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCreateService As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvServiceList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents gbServiceDetails As GroupBox
    Friend WithEvents switchServiceStatus As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label11 As Label
    Friend WithEvents cboNails As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cboHair As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cboBody As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtServiceDetails As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtServiceName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
