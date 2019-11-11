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
        Me.TblSecretQuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.JandA2DataSet = New InventoryManager.JandA2DataSet()
        Me.txtPassword1 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPassword2 = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.TblSecretQuestionTableAdapter = New InventoryManager.JandA2DataSetTableAdapters.tblSecretQuestionTableAdapter()
        Me.cboSecretQuestion = New MetroFramework.Controls.MetroComboBox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtAnswer = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSecretQuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JandA2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btnUpdatePassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUpdatePassword.AutoSize = True
        Me.btnUpdatePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdatePassword.Depth = 0
        Me.btnUpdatePassword.Location = New System.Drawing.Point(200, 389)
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
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'TblSecretQuestionBindingSource
        '
        Me.TblSecretQuestionBindingSource.DataMember = "tblSecretQuestion"
        Me.TblSecretQuestionBindingSource.DataSource = Me.JandA2DataSet
        '
        'JandA2DataSet
        '
        Me.JandA2DataSet.DataSetName = "JandA2DataSet"
        Me.JandA2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPassword1
        '
        Me.txtPassword1.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtPassword1.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword1.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtPassword1.BorderThickness = 3
        Me.txtPassword1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword1.isPassword = True
        Me.txtPassword1.Location = New System.Drawing.Point(122, 223)
        Me.txtPassword1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(303, 33)
        Me.txtPassword1.TabIndex = 19
        Me.txtPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPassword2
        '
        Me.txtPassword2.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtPassword2.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword2.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtPassword2.BorderThickness = 3
        Me.txtPassword2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPassword2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassword2.isPassword = True
        Me.txtPassword2.Location = New System.Drawing.Point(122, 264)
        Me.txtPassword2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(303, 33)
        Me.txtPassword2.TabIndex = 20
        Me.txtPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(6, 232)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(64, 17)
        Me.BunifuCustomLabel3.TabIndex = 18
        Me.BunifuCustomLabel3.Text = "Password"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(6, 273)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(109, 17)
        Me.BunifuCustomLabel4.TabIndex = 21
        Me.BunifuCustomLabel4.Text = "Repeat Password"
        '
        'TblSecretQuestionTableAdapter
        '
        Me.TblSecretQuestionTableAdapter.ClearBeforeFill = True
        '
        'cboSecretQuestion
        '
        Me.cboSecretQuestion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblSecretQuestionBindingSource, "QuestionID", True))
        Me.cboSecretQuestion.DataSource = Me.TblSecretQuestionBindingSource
        Me.cboSecretQuestion.DisplayMember = "Question"
        Me.cboSecretQuestion.FormattingEnabled = True
        Me.cboSecretQuestion.ItemHeight = 23
        Me.cboSecretQuestion.Location = New System.Drawing.Point(122, 304)
        Me.cboSecretQuestion.Name = "cboSecretQuestion"
        Me.cboSecretQuestion.Size = New System.Drawing.Size(303, 29)
        Me.cboSecretQuestion.TabIndex = 16
        Me.cboSecretQuestion.UseSelectable = True
        Me.cboSecretQuestion.ValueMember = "QuestionID"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(6, 350)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(50, 17)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "Answer"
        '
        'txtAnswer
        '
        Me.txtAnswer.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtAnswer.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAnswer.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtAnswer.BorderThickness = 3
        Me.txtAnswer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAnswer.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAnswer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAnswer.isPassword = False
        Me.txtAnswer.Location = New System.Drawing.Point(122, 340)
        Me.txtAnswer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(303, 33)
        Me.txtAnswer.TabIndex = 17
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(6, 312)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(100, 17)
        Me.BunifuCustomLabel1.TabIndex = 14
        Me.BunifuCustomLabel1.Text = "Secret Question"
        '
        'frmPasswordChange
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 451)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.BunifuCustomLabel4)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.txtPassword2)
        Me.Controls.Add(Me.cboSecretQuestion)
        Me.Controls.Add(Me.txtPassword1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPasswordChange"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "J and A Inventory Manager"
        CType(Me.pbLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSecretQuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JandA2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPassword2 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPassword1 As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents JandA2DataSet As JandA2DataSet
    Friend WithEvents TblSecretQuestionBindingSource As BindingSource
    Friend WithEvents TblSecretQuestionTableAdapter As JandA2DataSetTableAdapters.tblSecretQuestionTableAdapter
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtAnswer As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboSecretQuestion As MetroFramework.Controls.MetroComboBox
End Class
