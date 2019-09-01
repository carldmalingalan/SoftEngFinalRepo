<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPasswordChange
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPasswordChange))
        Me.txtPassword1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPassword2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblAccountID = New System.Windows.Forms.Label()
        Me.lblRole = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnUpdatePassword = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPassword1
        '
        Me.txtPassword1.Depth = 0
        Me.txtPassword1.Hint = "Type New Password"
        Me.txtPassword1.Location = New System.Drawing.Point(120, 231)
        Me.txtPassword1.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword1.SelectedText = ""
        Me.txtPassword1.SelectionLength = 0
        Me.txtPassword1.SelectionStart = 0
        Me.txtPassword1.Size = New System.Drawing.Size(202, 23)
        Me.txtPassword1.TabIndex = 0
        Me.txtPassword1.TabStop = False
        Me.txtPassword1.UseSystemPasswordChar = True
        '
        'txtPassword2
        '
        Me.txtPassword2.Depth = 0
        Me.txtPassword2.Hint = "Repeat New Password"
        Me.txtPassword2.Location = New System.Drawing.Point(120, 260)
        Me.txtPassword2.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword2.SelectedText = ""
        Me.txtPassword2.SelectionLength = 0
        Me.txtPassword2.SelectionStart = 0
        Me.txtPassword2.Size = New System.Drawing.Size(202, 23)
        Me.txtPassword2.TabIndex = 1
        Me.txtPassword2.TabStop = False
        Me.txtPassword2.UseSystemPasswordChar = True
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pbLogo.Image = Global.InventoryManager.My.Resources.Resources.J_A_LOGO_SALON
        Me.pbLogo.Location = New System.Drawing.Point(23, 63)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(155, 148)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(184, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Role:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(184, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "AccountID:"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(270, 177)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(75, 17)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "Username:"
        '
        'lblAccountID
        '
        Me.lblAccountID.AutoSize = True
        Me.lblAccountID.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountID.Location = New System.Drawing.Point(270, 151)
        Me.lblAccountID.Name = "lblAccountID"
        Me.lblAccountID.Size = New System.Drawing.Size(80, 17)
        Me.lblAccountID.TabIndex = 11
        Me.lblAccountID.Text = "AccountID:"
        '
        'lblRole
        '
        Me.lblRole.AutoSize = True
        Me.lblRole.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRole.Location = New System.Drawing.Point(270, 127)
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(40, 17)
        Me.lblRole.TabIndex = 10
        Me.lblRole.Text = "Role:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(270, 102)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(52, 17)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Name:"
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdatePassword.AutoSize = True
        Me.btnUpdatePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdatePassword.Depth = 0
        Me.btnUpdatePassword.Location = New System.Drawing.Point(176, 292)
        Me.btnUpdatePassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdatePassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Primary = False
        Me.btnUpdatePassword.Size = New System.Drawing.Size(64, 36)
        Me.btnUpdatePassword.TabIndex = 13
        Me.btnUpdatePassword.Text = "Update"
        Me.btnUpdatePassword.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 357)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblAccountID)
        Me.Controls.Add(Me.lblRole)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbLogo)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.txtPassword1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPasswordChange"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "J and A Inventory Manager"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPassword1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPassword2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblAccountID As Label
    Friend WithEvents lblRole As Label
    Friend WithEvents lblName As Label
    Friend WithEvents btnUpdatePassword As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
