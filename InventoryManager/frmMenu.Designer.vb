<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenu))
        Me.panelShow = New System.Windows.Forms.Panel()
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDashboard = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExit = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnInventory = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEmployeeList = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSettings = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnTransactions = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAccounts = New Bunifu.Framework.UI.BunifuImageButton()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.panelShow.SuspendLayout()
        CType(Me.btnDashboard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInventory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(666, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Accounts"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(385, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Inventory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(518, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Transactions"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(946, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 18)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Settings"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1100, 163)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Exit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Dashboard"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(803, 163)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Employees"
        '
        'btnDashboard
        '
        Me.btnDashboard.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboard.Image = Global.InventoryManager.My.Resources.Resources.speedometer
        Me.btnDashboard.ImageActive = Nothing
        Me.btnDashboard.Location = New System.Drawing.Point(234, 57)
        Me.btnDashboard.Name = "btnDashboard"
        Me.btnDashboard.Size = New System.Drawing.Size(100, 100)
        Me.btnDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnDashboard.TabIndex = 7
        Me.btnDashboard.TabStop = False
        Me.btnDashboard.Zoom = 10
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.Image = Global.InventoryManager.My.Resources.Resources.logout_1_
        Me.btnExit.ImageActive = Nothing
        Me.btnExit.Location = New System.Drawing.Point(1063, 57)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 100)
        Me.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExit.TabIndex = 3
        Me.btnExit.TabStop = False
        Me.btnExit.Zoom = 10
        '
        'btnInventory
        '
        Me.btnInventory.BackColor = System.Drawing.Color.Transparent
        Me.btnInventory.Image = Global.InventoryManager.My.Resources.Resources.inventory_1_
        Me.btnInventory.ImageActive = Nothing
        Me.btnInventory.Location = New System.Drawing.Point(374, 57)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(100, 100)
        Me.btnInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.TabStop = False
        Me.btnInventory.Zoom = 10
        '
        'btnEmployeeList
        '
        Me.btnEmployeeList.BackColor = System.Drawing.Color.Transparent
        Me.btnEmployeeList.Image = Global.InventoryManager.My.Resources.Resources.employees
        Me.btnEmployeeList.ImageActive = Nothing
        Me.btnEmployeeList.Location = New System.Drawing.Point(796, 57)
        Me.btnEmployeeList.Name = "btnEmployeeList"
        Me.btnEmployeeList.Size = New System.Drawing.Size(100, 100)
        Me.btnEmployeeList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnEmployeeList.TabIndex = 1
        Me.btnEmployeeList.TabStop = False
        Me.btnEmployeeList.Zoom = 10
        '
        'btnSettings
        '
        Me.btnSettings.BackColor = System.Drawing.Color.Transparent
        Me.btnSettings.Image = Global.InventoryManager.My.Resources.Resources.settings
        Me.btnSettings.ImageActive = Nothing
        Me.btnSettings.Location = New System.Drawing.Point(930, 57)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(100, 100)
        Me.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSettings.TabIndex = 1
        Me.btnSettings.TabStop = False
        Me.btnSettings.Zoom = 10
        '
        'btnTransactions
        '
        Me.btnTransactions.BackColor = System.Drawing.Color.Transparent
        Me.btnTransactions.Image = Global.InventoryManager.My.Resources.Resources.transactionsIcon
        Me.btnTransactions.ImageActive = Nothing
        Me.btnTransactions.Location = New System.Drawing.Point(515, 57)
        Me.btnTransactions.Name = "btnTransactions"
        Me.btnTransactions.Size = New System.Drawing.Size(100, 100)
        Me.btnTransactions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnTransactions.TabIndex = 1
        Me.btnTransactions.TabStop = False
        Me.btnTransactions.Zoom = 10
        '
        'btnAccounts
        '
        Me.btnAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnAccounts.Image = Global.InventoryManager.My.Resources.Resources.accountsIcon
        Me.btnAccounts.ImageActive = Nothing
        Me.btnAccounts.Location = New System.Drawing.Point(657, 57)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(100, 100)
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
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDashboard)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelShow)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnEmployeeList)
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDashboard As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btnEmployeeList As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label6 As Label
End Class
