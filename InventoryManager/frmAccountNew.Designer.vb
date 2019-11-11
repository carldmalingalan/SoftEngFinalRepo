<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccountNew
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccountNew))
        Me.txtFirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtLastname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUsername = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.rdoAdministrator = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoInventory = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoTransactions = New MaterialSkin.Controls.MaterialRadioButton()
        Me.groupBoxRole = New System.Windows.Forms.GroupBox()
        Me.btnSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupBoxRole.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtFirstname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtFirstname.BorderThickness = 3
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstname.isPassword = False
        Me.txtFirstname.Location = New System.Drawing.Point(124, 103)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(278, 34)
        Me.txtFirstname.TabIndex = 1
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtLastname
        '
        Me.txtLastname.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtLastname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastname.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtLastname.BorderThickness = 3
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastname.isPassword = False
        Me.txtLastname.Location = New System.Drawing.Point(124, 61)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(278, 34)
        Me.txtLastname.TabIndex = 0
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUsername
        '
        Me.txtUsername.BorderColorFocused = System.Drawing.Color.Blue
        Me.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.txtUsername.BorderThickness = 3
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUsername.isPassword = False
        Me.txtUsername.Location = New System.Drawing.Point(124, 145)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(278, 34)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(22, 112)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(76, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "Firstname"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(23, 69)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(75, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Lastname"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(22, 150)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(77, 19)
        Me.MaterialLabel5.TabIndex = 7
        Me.MaterialLabel5.Text = "Username"
        '
        'rdoAdministrator
        '
        Me.rdoAdministrator.AutoSize = True
        Me.rdoAdministrator.Depth = 0
        Me.rdoAdministrator.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoAdministrator.Location = New System.Drawing.Point(25, 33)
        Me.rdoAdministrator.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoAdministrator.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoAdministrator.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoAdministrator.Name = "rdoAdministrator"
        Me.rdoAdministrator.Ripple = True
        Me.rdoAdministrator.Size = New System.Drawing.Size(137, 30)
        Me.rdoAdministrator.TabIndex = 8
        Me.rdoAdministrator.TabStop = True
        Me.rdoAdministrator.Text = "ADMINISTRATOR"
        Me.rdoAdministrator.UseVisualStyleBackColor = True
        '
        'rdoInventory
        '
        Me.rdoInventory.AutoSize = True
        Me.rdoInventory.Depth = 0
        Me.rdoInventory.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoInventory.Location = New System.Drawing.Point(241, 33)
        Me.rdoInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoInventory.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoInventory.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoInventory.Name = "rdoInventory"
        Me.rdoInventory.Ripple = True
        Me.rdoInventory.Size = New System.Drawing.Size(104, 30)
        Me.rdoInventory.TabIndex = 8
        Me.rdoInventory.TabStop = True
        Me.rdoInventory.Text = "INVENTORY"
        Me.rdoInventory.UseVisualStyleBackColor = True
        '
        'rdoTransactions
        '
        Me.rdoTransactions.AutoSize = True
        Me.rdoTransactions.Depth = 0
        Me.rdoTransactions.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoTransactions.Location = New System.Drawing.Point(117, 80)
        Me.rdoTransactions.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoTransactions.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoTransactions.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoTransactions.Name = "rdoTransactions"
        Me.rdoTransactions.Ripple = True
        Me.rdoTransactions.Size = New System.Drawing.Size(131, 30)
        Me.rdoTransactions.TabIndex = 8
        Me.rdoTransactions.TabStop = True
        Me.rdoTransactions.Text = "TRANSACTIONS"
        Me.rdoTransactions.UseVisualStyleBackColor = True
        '
        'groupBoxRole
        '
        Me.groupBoxRole.Controls.Add(Me.rdoTransactions)
        Me.groupBoxRole.Controls.Add(Me.rdoAdministrator)
        Me.groupBoxRole.Controls.Add(Me.rdoInventory)
        Me.groupBoxRole.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.groupBoxRole.Location = New System.Drawing.Point(27, 202)
        Me.groupBoxRole.Name = "groupBoxRole"
        Me.groupBoxRole.Size = New System.Drawing.Size(375, 137)
        Me.groupBoxRole.TabIndex = 9
        Me.groupBoxRole.TabStop = False
        Me.groupBoxRole.Text = "Role"
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(196, 364)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = False
        Me.btnSave.Size = New System.Drawing.Size(46, 36)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmAccountNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 423)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.groupBoxRole)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAccountNew"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Account Manager"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.groupBoxRole.ResumeLayout(False)
        Me.groupBoxRole.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtLastname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUsername As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents rdoAdministrator As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoInventory As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoTransactions As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents groupBoxRole As GroupBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
