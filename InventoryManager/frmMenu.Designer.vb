<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.panelShow = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.lblAccounts = New System.Windows.Forms.Label()
        Me.lblInventory = New System.Windows.Forms.Label()
        Me.lblTransactions = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.lblExit = New System.Windows.Forms.Label()
        Me.lblDashboard = New System.Windows.Forms.Label()
        Me.lblEmployees = New System.Windows.Forms.Label()
        Me.lblServices = New System.Windows.Forms.Label()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnInventory = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEmployeeList = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnServices = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTransactions = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAccounts = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.panelShow.SuspendLayout()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAccounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelShow
        '
        Me.panelShow.Controls.Add(Me.panelMenu)
        Me.panelShow.Location = New System.Drawing.Point(23, 190)
        Me.panelShow.Name = "panelShow"
        Me.panelShow.Size = New System.Drawing.Size(1154, 507)
        Me.panelShow.TabIndex = 5
        '
        'panelMenu
        '
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(1154, 507)
        Me.panelMenu.TabIndex = 0
        '
        'lblAccounts
        '
        Me.lblAccounts.AutoSize = True
        Me.lblAccounts.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccounts.Location = New System.Drawing.Point(229, 146)
        Me.lblAccounts.Name = "lblAccounts"
        Me.lblAccounts.Size = New System.Drawing.Size(77, 18)
        Me.lblAccounts.TabIndex = 6
        Me.lblAccounts.Text = "Accounts"
        '
        'lblInventory
        '
        Me.lblInventory.AutoSize = True
        Me.lblInventory.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInventory.Location = New System.Drawing.Point(555, 146)
        Me.lblInventory.Name = "lblInventory"
        Me.lblInventory.Size = New System.Drawing.Size(76, 18)
        Me.lblInventory.TabIndex = 6
        Me.lblInventory.Text = "Inventory"
        '
        'lblTransactions
        '
        Me.lblTransactions.AutoSize = True
        Me.lblTransactions.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTransactions.Location = New System.Drawing.Point(652, 146)
        Me.lblTransactions.Name = "lblTransactions"
        Me.lblTransactions.Size = New System.Drawing.Size(97, 18)
        Me.lblTransactions.TabIndex = 6
        Me.lblTransactions.Text = "Transactions"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(879, 148)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(63, 18)
        Me.lblSettings.TabIndex = 6
        Me.lblSettings.Text = "Settings"
        '
        'lblExit
        '
        Me.lblExit.AutoSize = True
        Me.lblExit.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExit.Location = New System.Drawing.Point(998, 148)
        Me.lblExit.Name = "lblExit"
        Me.lblExit.Size = New System.Drawing.Size(32, 18)
        Me.lblExit.TabIndex = 6
        Me.lblExit.Text = "Exit"
        '
        'lblDashboard
        '
        Me.lblDashboard.AutoSize = True
        Me.lblDashboard.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDashboard.Location = New System.Drawing.Point(333, 148)
        Me.lblDashboard.Name = "lblDashboard"
        Me.lblDashboard.Size = New System.Drawing.Size(89, 18)
        Me.lblDashboard.TabIndex = 8
        Me.lblDashboard.Text = "Dashboard"
        '
        'lblEmployees
        '
        Me.lblEmployees.AutoSize = True
        Me.lblEmployees.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployees.Location = New System.Drawing.Point(441, 146)
        Me.lblEmployees.Name = "lblEmployees"
        Me.lblEmployees.Size = New System.Drawing.Size(89, 18)
        Me.lblEmployees.TabIndex = 6
        Me.lblEmployees.Text = "Employees"
        '
        'lblServices
        '
        Me.lblServices.AutoSize = True
        Me.lblServices.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServices.Location = New System.Drawing.Point(770, 146)
        Me.lblServices.Name = "lblServices"
        Me.lblServices.Size = New System.Drawing.Size(69, 18)
        Me.lblServices.TabIndex = 6
        Me.lblServices.Text = "Services"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnDashboard.Image = Global.InventoryManager.My.Resources.Resources.speedometer
        Me.btnDashboard.ImageActive = Nothing
        Me.btnDashboard.Location = New System.Drawing.Point(332, 55)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(90, 90)
        Me.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnExit.Image = Global.InventoryManager.My.Resources.Resources.logout_1_
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(967, 55)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 90)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 3
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnInventory.Image = Global.InventoryManager.My.Resources.Resources.inventory_1_
        Me.btnInventory.ImageActive = Nothing
        Me.btnInventory.Location = New System.Drawing.Point(548, 55)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(90, 90)
        Me.btnInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.TabStop = False
        Me.btnInventory.Zoom = 10
        '
        'btnEmployeeList
        '
        Me.btnEmployeeList.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployeeList.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnEmployeeList.Image = Global.InventoryManager.My.Resources.Resources.employees
        Me.btnEmployeeList.ImageActive = Nothing
        Me.btnEmployeeList.Location = New System.Drawing.Point(440, 55)
        Me.btnEmployeeList.Name = "btnEmployeeList"
        Me.btnEmployeeList.Size = New System.Drawing.Size(90, 90)
        Me.btnEmployeeList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEmployeeList.TabIndex = 1
        Me.btnEmployeeList.TabStop = False
        Me.btnEmployeeList.Zoom = 10
        '
        'btnServices
        '
        Me.btnServices.BackColor = System.Drawing.Color.Transparent
        Me.btnServices.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnServices.Image = Global.InventoryManager.My.Resources.Resources.customer
        Me.btnServices.ImageActive = Nothing
        Me.btnServices.Location = New System.Drawing.Point(761, 55)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(90, 90)
        Me.btnServices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnServices.TabIndex = 1
        Me.btnServices.TabStop = False
        Me.btnServices.Zoom = 10
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnSettings.Image = Global.InventoryManager.My.Resources.Resources.settings
        Me.btnSettings.ImageActive = Nothing
        Me.btnSettings.Location = New System.Drawing.Point(865, 55)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(90, 90)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.TabStop = False
        Me.btnSettings.Zoom = 10
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.Transparent
        Me.btnTransactions.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnTransactions.Image = Global.InventoryManager.My.Resources.Resources.transactionsIcon
        Me.btnTransactions.ImageActive = Nothing
        Me.btnTransactions.Location = New System.Drawing.Point(654, 55)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(90, 90)
        Me.btnTransactions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTransactions.TabIndex = 1
        Me.btnTransactions.TabStop = False
        Me.btnTransactions.Zoom = 10
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnAccounts.ErrorImage = Global.InventoryManager.My.Resources.Resources.locked
        Me.btnAccounts.Image = Global.InventoryManager.My.Resources.Resources.accountsIcon
        Me.btnAccounts.ImageActive = Nothing
        Me.btnAccounts.Location = New System.Drawing.Point(224, 55)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(90, 90)
        Me.btnAccounts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAccounts.TabIndex = 0
        Me.btnAccounts.TabStop = False
        Me.btnAccounts.Zoom = 10
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.InventoryManager.My.Resources.Resources.J_A_LOGO_SALON
        Me.pbLogo.Location = New System.Drawing.Point(23, 46)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(169, 155)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 720)
        Me.Controls.Add(Me.lblDashboard)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.lblEmployees)
        Me.Controls.Add(Me.lblServices)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblExit)
        Me.Controls.Add(Me.lblTransactions)
        Me.Controls.Add(Me.lblInventory)
        Me.Controls.Add(Me.lblAccounts)
        Me.Controls.Add(Me.panelShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnEmployeeList)
        Me.Controls.Add(Me.btnServices)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnTransactions)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.pbLogo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMenu"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "J and A Inventory Manager"
        Me.panelShow.ResumeLayout(False)
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInventory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnSettings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAccounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAccounts As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnTransactions As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnInventory As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSettings As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExit As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents panelShow As Panel
    Friend WithEvents lblAccounts As Label
    Friend WithEvents lblInventory As Label
    Friend WithEvents lblTransactions As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents lblExit As Label
    Friend WithEvents lblDashboard As Label
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnEmployeeList As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblEmployees As Label
    Friend WithEvents btnServices As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblServices As Label
End Class
