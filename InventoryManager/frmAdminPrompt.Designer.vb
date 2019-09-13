<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminPrompt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdminPrompt))
        Me.pbLogo = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtUsername = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnContinue = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnCancel = New MaterialSkin.Controls.MaterialFlatButton()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbLogo
        '
        Me.pbLogo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbLogo.BackColor = System.Drawing.Color.Transparent
        Me.pbLogo.Image = Global.InventoryManager.My.Resources.Resources.J_A_LOGO_SALON
        Me.pbLogo.Location = New System.Drawing.Point(121, -11)
        Me.pbLogo.Name = "pbLogo"
        Me.pbLogo.Size = New System.Drawing.Size(200, 183)
        Me.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbLogo.TabIndex = 4
        Me.pbLogo.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.btnContinue)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Location = New System.Drawing.Point(121, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 139)
        Me.Panel1.TabIndex = 8
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsername.Depth = 0
        Me.txtUsername.Hint = "Username"
        Me.txtUsername.Location = New System.Drawing.Point(25, 11)
        Me.txtUsername.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.SelectedText = ""
        Me.txtUsername.SelectionLength = 0
        Me.txtUsername.SelectionStart = 0
        Me.txtUsername.Size = New System.Drawing.Size(152, 23)
        Me.txtUsername.TabIndex = 2
        Me.txtUsername.TabStop = False
        Me.txtUsername.UseSystemPasswordChar = False
        '
        'btnContinue
        '
        Me.btnContinue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnContinue.AutoSize = True
        Me.btnContinue.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnContinue.Depth = 0
        Me.btnContinue.Location = New System.Drawing.Point(26, 90)
        Me.btnContinue.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnContinue.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Primary = False
        Me.btnContinue.Size = New System.Drawing.Size(79, 36)
        Me.btnContinue.TabIndex = 6
        Me.btnContinue.Text = "CONTINUE"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = "Password"
        Me.txtPassword.Location = New System.Drawing.Point(25, 40)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(152, 23)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.TabStop = False
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoSize = True
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(108, 90)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = False
        Me.btnCancel.Size = New System.Drawing.Size(64, 36)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmAdminPrompt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 320)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pbLogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAdminPrompt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "J & A Inventory Manager"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbLogo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtUsername As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnContinue As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
