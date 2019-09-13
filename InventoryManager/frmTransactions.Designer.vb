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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustomer = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.cboServiceAvailed = New MetroFramework.Controls.MetroComboBox()
        Me.btnCancelTransaction = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEmployeeAssigned = New MetroFramework.Controls.MetroComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboNails = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cboBody = New MaterialSkin.Controls.MaterialCheckBox()
        Me.cboHair = New MaterialSkin.Controls.MaterialCheckBox()
        Me.txtRemarks = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbTransDetails = New System.Windows.Forms.GroupBox()
        Me.btnSaveTransaction = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbTransDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvTransactionsList
        '
        Me.dgvTransactionsList.AllowUserToAddRows = False
        Me.dgvTransactionsList.AllowUserToDeleteRows = False
        Me.dgvTransactionsList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTransactionsList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactionsList.BackgroundColor = System.Drawing.Color.Gainsboro
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
        Me.dgvTransactionsList.Size = New System.Drawing.Size(442, 450)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Customer Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 139)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Service Availed:"
        '
        'txtCustomer
        '
        Me.txtCustomer.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtCustomer.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomer.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtCustomer.BorderThickness = 3
        Me.txtCustomer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCustomer.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCustomer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCustomer.isPassword = False
        Me.txtCustomer.Location = New System.Drawing.Point(156, 45)
        Me.txtCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(309, 31)
        Me.txtCustomer.TabIndex = 28
        Me.txtCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cboServiceAvailed
        '
        Me.cboServiceAvailed.ItemHeight = 23
        Me.cboServiceAvailed.Location = New System.Drawing.Point(160, 132)
        Me.cboServiceAvailed.Name = "cboServiceAvailed"
        Me.cboServiceAvailed.Size = New System.Drawing.Size(305, 29)
        Me.cboServiceAvailed.TabIndex = 43
        Me.cboServiceAvailed.UseSelectable = True
        '
        'btnCancelTransaction
        '
        Me.btnCancelTransaction.AutoSize = True
        Me.btnCancelTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelTransaction.Depth = 0
        Me.btnCancelTransaction.Location = New System.Drawing.Point(246, 408)
        Me.btnCancelTransaction.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelTransaction.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelTransaction.Name = "btnCancelTransaction"
        Me.btnCancelTransaction.Primary = False
        Me.btnCancelTransaction.Size = New System.Drawing.Size(64, 36)
        Me.btnCancelTransaction.TabIndex = 44
        Me.btnCancelTransaction.Text = "CANCEL"
        Me.btnCancelTransaction.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Employee Assigned:"
        '
        'cboEmployeeAssigned
        '
        Me.cboEmployeeAssigned.ItemHeight = 23
        Me.cboEmployeeAssigned.Location = New System.Drawing.Point(160, 167)
        Me.cboEmployeeAssigned.Name = "cboEmployeeAssigned"
        Me.cboEmployeeAssigned.Size = New System.Drawing.Size(305, 29)
        Me.cboEmployeeAssigned.TabIndex = 47
        Me.cboEmployeeAssigned.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Service Type:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboNails)
        Me.GroupBox1.Controls.Add(Me.cboBody)
        Me.GroupBox1.Controls.Add(Me.cboHair)
        Me.GroupBox1.Location = New System.Drawing.Point(160, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(305, 47)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        '
        'cboNails
        '
        Me.cboNails.AutoSize = True
        Me.cboNails.Depth = 0
        Me.cboNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboNails.Location = New System.Drawing.Point(188, 12)
        Me.cboNails.Margin = New System.Windows.Forms.Padding(0)
        Me.cboNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboNails.Name = "cboNails"
        Me.cboNails.Ripple = True
        Me.cboNails.Size = New System.Drawing.Size(68, 30)
        Me.cboNails.TabIndex = 51
        Me.cboNails.Text = "NAILS"
        Me.cboNails.UseVisualStyleBackColor = True
        '
        'cboBody
        '
        Me.cboBody.AutoSize = True
        Me.cboBody.Depth = 0
        Me.cboBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboBody.Location = New System.Drawing.Point(38, 12)
        Me.cboBody.Margin = New System.Windows.Forms.Padding(0)
        Me.cboBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboBody.Name = "cboBody"
        Me.cboBody.Ripple = True
        Me.cboBody.Size = New System.Drawing.Size(65, 30)
        Me.cboBody.TabIndex = 49
        Me.cboBody.Text = "BODY"
        Me.cboBody.UseVisualStyleBackColor = True
        '
        'cboHair
        '
        Me.cboHair.AutoSize = True
        Me.cboHair.Depth = 0
        Me.cboHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.cboHair.Location = New System.Drawing.Point(115, 12)
        Me.cboHair.Margin = New System.Windows.Forms.Padding(0)
        Me.cboHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.cboHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.cboHair.Name = "cboHair"
        Me.cboHair.Ripple = True
        Me.cboHair.Size = New System.Drawing.Size(61, 30)
        Me.cboHair.TabIndex = 50
        Me.cboHair.Text = "HAIR"
        Me.cboHair.UseVisualStyleBackColor = True
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtRemarks.Location = New System.Drawing.Point(160, 216)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(305, 134)
        Me.txtRemarks.TabIndex = 53
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Additional Remarks:"
        '
        'gbTransDetails
        '
        Me.gbTransDetails.AutoSize = True
        Me.gbTransDetails.Controls.Add(Me.Label2)
        Me.gbTransDetails.Controls.Add(Me.txtRemarks)
        Me.gbTransDetails.Controls.Add(Me.GroupBox1)
        Me.gbTransDetails.Controls.Add(Me.Label5)
        Me.gbTransDetails.Controls.Add(Me.cboEmployeeAssigned)
        Me.gbTransDetails.Controls.Add(Me.Label1)
        Me.gbTransDetails.Controls.Add(Me.btnCancelTransaction)
        Me.gbTransDetails.Controls.Add(Me.btnSaveTransaction)
        Me.gbTransDetails.Controls.Add(Me.cboServiceAvailed)
        Me.gbTransDetails.Controls.Add(Me.txtCustomer)
        Me.gbTransDetails.Controls.Add(Me.Label9)
        Me.gbTransDetails.Controls.Add(Me.Label3)
        Me.gbTransDetails.Enabled = False
        Me.gbTransDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTransDetails.Location = New System.Drawing.Point(460, 51)
        Me.gbTransDetails.Name = "gbTransDetails"
        Me.gbTransDetails.Size = New System.Drawing.Size(473, 469)
        Me.gbTransDetails.TabIndex = 30
        Me.gbTransDetails.TabStop = False
        Me.gbTransDetails.Text = "Transaction Details"
        '
        'btnSaveTransaction
        '
        Me.btnSaveTransaction.AutoSize = True
        Me.btnSaveTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveTransaction.Depth = 0
        Me.btnSaveTransaction.Location = New System.Drawing.Point(192, 408)
        Me.btnSaveTransaction.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveTransaction.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveTransaction.Name = "btnSaveTransaction"
        Me.btnSaveTransaction.Primary = False
        Me.btnSaveTransaction.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveTransaction.TabIndex = 45
        Me.btnSaveTransaction.Text = "SAVE"
        Me.btnSaveTransaction.UseVisualStyleBackColor = True
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.gbTransDetails)
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTransDetails.ResumeLayout(False)
        Me.gbTransDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExportUsers As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvTransactionsList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnVoidTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpTransactionDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCustomer As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents cboServiceAvailed As MetroFramework.Controls.MetroComboBox
    Friend WithEvents btnCancelTransaction As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label1 As Label
    Friend WithEvents cboEmployeeAssigned As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboNails As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cboBody As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents cboHair As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents txtRemarks As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents gbTransDetails As GroupBox
    Friend WithEvents btnSaveTransaction As MaterialSkin.Controls.MaterialFlatButton
End Class
