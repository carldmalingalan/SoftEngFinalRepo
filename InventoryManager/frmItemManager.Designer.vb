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
        Me.MaterialSingleLineTextField1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
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
        Me.groupBoxRole.Location = New System.Drawing.Point(67, 209)
        Me.groupBoxRole.Name = "groupBoxRole"
        Me.groupBoxRole.Size = New System.Drawing.Size(200, 92)
        Me.groupBoxRole.TabIndex = 5
        Me.groupBoxRole.TabStop = False
        Me.groupBoxRole.Text = "Item Label"
        '
        'rdoFace
        '
        Me.rdoFace.AutoSize = True
        Me.rdoFace.Depth = 0
        Me.rdoFace.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoFace.Location = New System.Drawing.Point(19, 51)
        Me.rdoFace.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoFace.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoFace.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoFace.Name = "rdoFace"
        Me.rdoFace.Ripple = True
        Me.rdoFace.Size = New System.Drawing.Size(62, 30)
        Me.rdoFace.TabIndex = 5
        Me.rdoFace.TabStop = True
        Me.rdoFace.Text = "FACE"
        Me.rdoFace.UseVisualStyleBackColor = True
        '
        'rdoNails
        '
        Me.rdoNails.AutoSize = True
        Me.rdoNails.Depth = 0
        Me.rdoNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoNails.Location = New System.Drawing.Point(102, 51)
        Me.rdoNails.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoNails.Name = "rdoNails"
        Me.rdoNails.Ripple = True
        Me.rdoNails.Size = New System.Drawing.Size(67, 30)
        Me.rdoNails.TabIndex = 4
        Me.rdoNails.TabStop = True
        Me.rdoNails.Text = "NAILS"
        Me.rdoNails.UseVisualStyleBackColor = True
        '
        'rdoBody
        '
        Me.rdoBody.AutoSize = True
        Me.rdoBody.Depth = 0
        Me.rdoBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoBody.Location = New System.Drawing.Point(102, 21)
        Me.rdoBody.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoBody.Name = "rdoBody"
        Me.rdoBody.Ripple = True
        Me.rdoBody.Size = New System.Drawing.Size(64, 30)
        Me.rdoBody.TabIndex = 3
        Me.rdoBody.TabStop = True
        Me.rdoBody.Text = "BODY"
        Me.rdoBody.UseCompatibleTextRendering = True
        Me.rdoBody.UseVisualStyleBackColor = True
        '
        'rdoHair
        '
        Me.rdoHair.AutoSize = True
        Me.rdoHair.Depth = 0
        Me.rdoHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoHair.Location = New System.Drawing.Point(19, 21)
        Me.rdoHair.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoHair.Name = "rdoHair"
        Me.rdoHair.Ripple = True
        Me.rdoHair.Size = New System.Drawing.Size(60, 30)
        Me.rdoHair.TabIndex = 1
        Me.rdoHair.TabStop = True
        Me.rdoHair.Text = "HAIR"
        Me.rdoHair.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Depth = 0
        Me.txtDescription.Hint = "Item Description"
        Me.txtDescription.Location = New System.Drawing.Point(18, 121)
        Me.txtDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(305, 23)
        Me.txtDescription.TabIndex = 6
        Me.txtDescription.TabStop = False
        Me.txtDescription.UseSystemPasswordChar = False
        '
        'txtItemQuantity
        '
        Me.txtItemQuantity.Depth = 0
        Me.txtItemQuantity.Hint = "Item Quantity"
        Me.txtItemQuantity.Location = New System.Drawing.Point(18, 92)
        Me.txtItemQuantity.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemQuantity.Name = "txtItemQuantity"
        Me.txtItemQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemQuantity.SelectedText = ""
        Me.txtItemQuantity.SelectionLength = 0
        Me.txtItemQuantity.SelectionStart = 0
        Me.txtItemQuantity.Size = New System.Drawing.Size(145, 23)
        Me.txtItemQuantity.TabIndex = 4
        Me.txtItemQuantity.TabStop = False
        Me.txtItemQuantity.UseSystemPasswordChar = False
        '
        'txtItemName
        '
        Me.txtItemName.Depth = 0
        Me.txtItemName.Hint = "Item Name"
        Me.txtItemName.Location = New System.Drawing.Point(18, 63)
        Me.txtItemName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemName.SelectedText = ""
        Me.txtItemName.SelectionLength = 0
        Me.txtItemName.SelectionStart = 0
        Me.txtItemName.Size = New System.Drawing.Size(305, 23)
        Me.txtItemName.TabIndex = 3
        Me.txtItemName.TabStop = False
        Me.txtItemName.UseSystemPasswordChar = False
        '
        'btnSaveItem
        '
        Me.btnSaveItem.AutoSize = True
        Me.btnSaveItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveItem.Depth = 0
        Me.btnSaveItem.Location = New System.Drawing.Point(150, 321)
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
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Expiration Date"
        '
        'checkboxExpirationNA
        '
        Me.checkboxExpirationNA.AutoSize = True
        Me.checkboxExpirationNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkboxExpirationNA.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkboxExpirationNA.Location = New System.Drawing.Point(256, 154)
        Me.checkboxExpirationNA.Name = "checkboxExpirationNA"
        Me.checkboxExpirationNA.Size = New System.Drawing.Size(43, 21)
        Me.checkboxExpirationNA.TabIndex = 10
        Me.checkboxExpirationNA.Text = "NA"
        Me.checkboxExpirationNA.UseVisualStyleBackColor = True
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(139, 150)
        Me.dtpExpirationDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpExpirationDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(111, 29)
        Me.dtpExpirationDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpExpirationDate.TabIndex = 18
        Me.dtpExpirationDate.UseCustomBackColor = True
        Me.dtpExpirationDate.UseCustomForeColor = True
        Me.dtpExpirationDate.UseStyleColors = True
        '
        'MaterialSingleLineTextField1
        '
        Me.MaterialSingleLineTextField1.Depth = 0
        Me.MaterialSingleLineTextField1.Hint = "Critical Point"
        Me.MaterialSingleLineTextField1.Location = New System.Drawing.Point(169, 92)
        Me.MaterialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialSingleLineTextField1.Name = "MaterialSingleLineTextField1"
        Me.MaterialSingleLineTextField1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MaterialSingleLineTextField1.SelectedText = ""
        Me.MaterialSingleLineTextField1.SelectionLength = 0
        Me.MaterialSingleLineTextField1.SelectionStart = 0
        Me.MaterialSingleLineTextField1.Size = New System.Drawing.Size(154, 23)
        Me.MaterialSingleLineTextField1.TabIndex = 19
        Me.MaterialSingleLineTextField1.TabStop = False
        Me.MaterialSingleLineTextField1.UseSystemPasswordChar = False
        '
        'frmItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 381)
        Me.Controls.Add(Me.MaterialSingleLineTextField1)
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
    Friend WithEvents MaterialSingleLineTextField1 As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
