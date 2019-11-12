<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemManager))
        Me.groupBoxRole = New System.Windows.Forms.GroupBox()
        Me.rdoFace = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoNails = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoBody = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoHair = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtDescription = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtItemQuantity = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtItemName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnSaveItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.checkboxExpirationNA = New System.Windows.Forms.CheckBox()
        Me.dtpExpirationDate = New MetroFramework.Controls.MetroDateTime()
        Me.txtCriticalPoint = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbCritPointNA = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.groupBoxRole.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxRole
        '
        Me.groupBoxRole.Controls.Add(Me.rdoFace)
        Me.groupBoxRole.Controls.Add(Me.rdoNails)
        Me.groupBoxRole.Controls.Add(Me.rdoBody)
        Me.groupBoxRole.Controls.Add(Me.rdoHair)
        Me.groupBoxRole.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxRole.Location = New System.Drawing.Point(28, 214)
        Me.groupBoxRole.Name = "groupBoxRole"
        Me.groupBoxRole.Size = New System.Drawing.Size(330, 62)
        Me.groupBoxRole.TabIndex = 5
        Me.groupBoxRole.TabStop = False
        Me.groupBoxRole.Text = "Classification"
        '
        'rdoFace
        '
        Me.rdoFace.AutoSize = True
        Me.rdoFace.Depth = 0
        Me.rdoFace.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoFace.Location = New System.Drawing.Point(115, 21)
        Me.rdoFace.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoFace.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoFace.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoFace.Name = "rdoFace"
        Me.rdoFace.Ripple = True
        Me.rdoFace.Size = New System.Drawing.Size(58, 30)
        Me.rdoFace.TabIndex = 5
        Me.rdoFace.TabStop = True
        Me.rdoFace.Text = "Face"
        Me.rdoFace.UseVisualStyleBackColor = True
        '
        'rdoNails
        '
        Me.rdoNails.AutoSize = True
        Me.rdoNails.Depth = 0
        Me.rdoNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoNails.Location = New System.Drawing.Point(255, 21)
        Me.rdoNails.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoNails.Name = "rdoNails"
        Me.rdoNails.Ripple = True
        Me.rdoNails.Size = New System.Drawing.Size(60, 30)
        Me.rdoNails.TabIndex = 4
        Me.rdoNails.TabStop = True
        Me.rdoNails.Text = "Nails"
        Me.rdoNails.UseVisualStyleBackColor = True
        '
        'rdoBody
        '
        Me.rdoBody.AutoSize = True
        Me.rdoBody.Depth = 0
        Me.rdoBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoBody.Location = New System.Drawing.Point(37, 21)
        Me.rdoBody.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoBody.Name = "rdoBody"
        Me.rdoBody.Ripple = True
        Me.rdoBody.Size = New System.Drawing.Size(60, 30)
        Me.rdoBody.TabIndex = 3
        Me.rdoBody.TabStop = True
        Me.rdoBody.Text = "Body"
        Me.rdoBody.UseCompatibleTextRendering = True
        Me.rdoBody.UseVisualStyleBackColor = True
        '
        'rdoHair
        '
        Me.rdoHair.AutoSize = True
        Me.rdoHair.Depth = 0
        Me.rdoHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoHair.Location = New System.Drawing.Point(188, 21)
        Me.rdoHair.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoHair.Name = "rdoHair"
        Me.rdoHair.Ripple = True
        Me.rdoHair.Size = New System.Drawing.Size(54, 30)
        Me.rdoHair.TabIndex = 1
        Me.rdoHair.TabStop = True
        Me.rdoHair.Text = "Hair"
        Me.rdoHair.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Depth = 0
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDescription.Hint = "Item Description"
        Me.txtDescription.Location = New System.Drawing.Point(94, 150)
        Me.txtDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(295, 23)
        Me.txtDescription.TabIndex = 6
        Me.txtDescription.TabStop = False
        Me.txtDescription.UseSystemPasswordChar = False
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Depth = 0
        Me.txtItemQuantity.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtItemQuantity.Hint = "Item Quantity"
        Me.txtItemQuantity.Location = New System.Drawing.Point(94, 92)
        Me.txtItemQuantity.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemQuantity.SelectedText = ""
        Me.txtItemQuantity.SelectionLength = 0
        Me.txtItemQuantity.SelectionStart = 0
        Me.txtItemQuantity.Size = New System.Drawing.Size(97, 23)
        Me.txtItemQuantity.TabIndex = 4
        Me.txtItemQuantity.TabStop = False
        Me.txtItemQuantity.UseSystemPasswordChar = False
        '
        'txtItemName
        '
        Me.txtItemName.Depth = 0
        Me.txtItemName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtItemName.Hint = "Item Name"
        Me.txtItemName.Location = New System.Drawing.Point(94, 63)
        Me.txtItemName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.SelectionLength = 0
        Me.txtItemName.SelectionStart = 0
        Me.txtItemName.Size = New System.Drawing.Size(295, 23)
        Me.txtItemName.TabIndex = 3
        Me.txtItemName.TabStop = False
        Me.txtItemName.UseSystemPasswordChar = False
        '
        'btnSaveItem
        '
        Me.btnSaveItem.AutoSize = True
        Me.btnSaveItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveItem.Depth = 0
        Me.btnSaveItem.Location = New System.Drawing.Point(184, 285)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Primary = False
        Me.btnSaveItem.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveItem.TabIndex = 7
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "SAVE"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(0, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Expiration Date"
        Me.Label1.Visible = False
        '
        'checkboxExpirationNA
        '
        Me.checkboxExpirationNA.AutoSize = True
        Me.checkboxExpirationNA.Checked = True
        Me.checkboxExpirationNA.CheckState = System.Windows.Forms.CheckState.Checked
        Me.checkboxExpirationNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkboxExpirationNA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxExpirationNA.Location = New System.Drawing.Point(230, 183)
        Me.checkboxExpirationNA.Name = "checkboxExpirationNA"
        Me.checkboxExpirationNA.Size = New System.Drawing.Size(43, 21)
        Me.checkboxExpirationNA.TabIndex = 10
        Me.checkboxExpirationNA.Text = "NA"
        Me.checkboxExpirationNA.UseVisualStyleBackColor = True
        Me.checkboxExpirationNA.Visible = False
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(113, 179)
        Me.dtpExpirationDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpExpirationDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(111, 29)
        Me.dtpExpirationDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpExpirationDate.TabIndex = 18
        Me.dtpExpirationDate.UseCustomBackColor = True
        Me.dtpExpirationDate.UseCustomForeColor = True
        Me.dtpExpirationDate.UseStyleColors = True
        Me.dtpExpirationDate.Visible = False
        '
        'txtCriticalPoint
        '
        Me.txtCriticalPoint.Depth = 0
        Me.txtCriticalPoint.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCriticalPoint.Hint = "Critical Point"
        Me.txtCriticalPoint.Location = New System.Drawing.Point(94, 122)
        Me.txtCriticalPoint.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCriticalPoint.Name = "txtCriticalPoint"
        Me.txtCriticalPoint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCriticalPoint.SelectedText = ""
        Me.txtCriticalPoint.SelectionLength = 0
        Me.txtCriticalPoint.SelectionStart = 0
        Me.txtCriticalPoint.Size = New System.Drawing.Size(97, 23)
        Me.txtCriticalPoint.TabIndex = 19
        Me.txtCriticalPoint.TabStop = False
        Me.txtCriticalPoint.UseSystemPasswordChar = False
        '
        'cbCritPointNA
        '
        Me.cbCritPointNA.AutoSize = True
        Me.cbCritPointNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbCritPointNA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCritPointNA.Location = New System.Drawing.Point(197, 124)
        Me.cbCritPointNA.Name = "cbCritPointNA"
        Me.cbCritPointNA.Size = New System.Drawing.Size(43, 21)
        Me.cbCritPointNA.TabIndex = 20
        Me.cbCritPointNA.Text = "NA"
        Me.cbCritPointNA.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(40, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(25, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Quantity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(0, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Critical Point"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(8, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Description"
        '
        'frmItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 331)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbCritPointNA)
        Me.Controls.Add(Me.txtCriticalPoint)
        Me.Controls.Add(Me.dtpExpirationDate)
        Me.Controls.Add(Me.checkboxExpirationNA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Controls.Add(Me.groupBoxRole)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtItemQuantity)
        Me.Controls.Add(Me.txtItemName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItemManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Item Manager"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.groupBoxRole.ResumeLayout(False)
        Me.groupBoxRole.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBoxRole As GroupBox
    Friend WithEvents rdoNails As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoBody As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoHair As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtDescription As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtItemQuantity As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtItemName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnSaveItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents checkboxExpirationNA As CheckBox
    Friend WithEvents rdoFace As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents dtpExpirationDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtCriticalPoint As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbCritPointNA As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
