<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateAccount))
        Me.txtFirstname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtLastname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdoInventory = New MaterialSkin.Controls.MaterialRadioButton()
        Me.groupBoxRole = New System.Windows.Forms.GroupBox()
        Me.rdoAdministrator = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoTransactions = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnCreateAccount = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.groupBoxRole.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtFirstname
        '
        Me.txtFirstname.Depth = 0
        Me.txtFirstname.Hint = "Firstname"
        Me.txtFirstname.Location = New System.Drawing.Point(85, 105)
        Me.txtFirstname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.SelectedText = ""
        Me.txtFirstname.SelectionLength = 0
        Me.txtFirstname.SelectionStart = 0
        Me.txtFirstname.Size = New System.Drawing.Size(305, 23)
        Me.txtFirstname.TabIndex = 0
        Me.txtFirstname.TabStop = False
        Me.txtFirstname.UseSystemPasswordChar = False
        '
        'txtLastname
        '
        Me.txtLastname.Depth = 0
        Me.txtLastname.Hint = "Lastname"
        Me.txtLastname.Location = New System.Drawing.Point(85, 134)
        Me.txtLastname.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.SelectedText = ""
        Me.txtLastname.SelectionLength = 0
        Me.txtLastname.SelectionStart = 0
        Me.txtLastname.Size = New System.Drawing.Size(305, 23)
        Me.txtLastname.TabIndex = 1
        Me.txtLastname.TabStop = False
        Me.txtLastname.UseSystemPasswordChar = False
        '
        'txtUsername
        '
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Username"
        Me.txtUsername.Location = New System.Drawing.Point(85, 163)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(305, 23)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TabStop = False
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'rdoInventory
        '
        Me.rdoInventory.AutoSize = True
        Me.rdoInventory.Depth = 0
        Me.rdoInventory.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoInventory.Location = New System.Drawing.Point(19, 21)
        Me.rdoInventory.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoInventory.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoInventory.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoInventory.Name = "rdoInventory"
        Me.rdoInventory.Ripple = True
        Me.rdoInventory.Size = New System.Drawing.Size(120, 30)
        Me.rdoInventory.TabIndex = 1
        Me.rdoInventory.TabStop = True
        Me.rdoInventory.Text = "Inventory Staff"
        Me.rdoInventory.UseVisualStyleBackColor = True
        '
        'groupBoxRole
        '
        Me.groupBoxRole.Controls.Add(Me.rdoAdministrator)
        Me.groupBoxRole.Controls.Add(Me.rdoTransactions)
        Me.groupBoxRole.Controls.Add(Me.rdoInventory)
        Me.groupBoxRole.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxRole.Location = New System.Drawing.Point(138, 195)
        Me.groupBoxRole.Name = "groupBoxRole"
        Me.groupBoxRole.Size = New System.Drawing.Size(183, 119)
        Me.groupBoxRole.TabIndex = 2
        Me.groupBoxRole.TabStop = False
        Me.groupBoxRole.Text = "Role"
        '
        'rdoAdministrator
        '
        Me.rdoAdministrator.AutoSize = True
        Me.rdoAdministrator.Depth = 0
        Me.rdoAdministrator.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoAdministrator.Location = New System.Drawing.Point(19, 81)
        Me.rdoAdministrator.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoAdministrator.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoAdministrator.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoAdministrator.Name = "rdoAdministrator"
        Me.rdoAdministrator.Ripple = True
        Me.rdoAdministrator.Size = New System.Drawing.Size(114, 30)
        Me.rdoAdministrator.TabIndex = 4
        Me.rdoAdministrator.TabStop = True
        Me.rdoAdministrator.Text = "Administrator"
        Me.rdoAdministrator.UseVisualStyleBackColor = True
        '
        'rdoTransactions
        '
        Me.rdoTransactions.AutoSize = True
        Me.rdoTransactions.Depth = 0
        Me.rdoTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoTransactions.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoTransactions.Location = New System.Drawing.Point(19, 51)
        Me.rdoTransactions.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoTransactions.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoTransactions.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoTransactions.Name = "rdoTransactions"
        Me.rdoTransactions.Ripple = True
        Me.rdoTransactions.Size = New System.Drawing.Size(143, 30)
        Me.rdoTransactions.TabIndex = 3
        Me.rdoTransactions.TabStop = True
        Me.rdoTransactions.Text = "Transactions Staff"
        Me.rdoTransactions.UseCompatibleTextRendering = True
        Me.rdoTransactions.UseVisualStyleBackColor = True
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.AutoSize = True
        Me.btnCreateAccount.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCreateAccount.Depth = 0
        Me.btnCreateAccount.Location = New System.Drawing.Point(210, 351)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCreateAccount.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Primary = False
        Me.btnCreateAccount.Size = New System.Drawing.Size(46, 36)
        Me.btnCreateAccount.TabIndex = 5
        Me.btnCreateAccount.TabStop = False
        Me.btnCreateAccount.Text = "SAVE"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(476, 462)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.groupBoxRole)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCreateAccount"
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

    Friend WithEvents txtFirstname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtLastname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdoInventory As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents groupBoxRole As GroupBox
    Friend WithEvents rdoAdministrator As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoTransactions As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnCreateAccount As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
