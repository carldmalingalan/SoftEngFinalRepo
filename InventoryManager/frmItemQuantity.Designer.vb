<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemQuantity))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSaveItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTxn = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblCateg = New System.Windows.Forms.Label()
        Me.txtQuantityOut = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Item Name"
        '
        'btnSaveItem
        '
        Me.btnSaveItem.AutoSize = True
        Me.btnSaveItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveItem.Depth = 0
        Me.btnSaveItem.Location = New System.Drawing.Point(249, 215)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Primary = False
        Me.btnSaveItem.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveItem.TabIndex = 25
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "SAVE"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Transaction Number#"
        '
        'lblTxn
        '
        Me.lblTxn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTxn.Location = New System.Drawing.Point(194, 63)
        Me.lblTxn.Name = "lblTxn"
        Me.lblTxn.Size = New System.Drawing.Size(330, 17)
        Me.lblTxn.TabIndex = 31
        Me.lblTxn.Text = "txn"
        Me.lblTxn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(194, 83)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(330, 17)
        Me.lblName.TabIndex = 32
        Me.lblName.Text = "name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Quantity"
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(194, 123)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(330, 17)
        Me.lblDesc.TabIndex = 37
        Me.lblDesc.Text = "desc"
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.Location = New System.Drawing.Point(194, 103)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(330, 17)
        Me.lblQty.TabIndex = 36
        Me.lblQty.Text = "qty"
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 20)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Category"
        '
        'lblCateg
        '
        Me.lblCateg.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCateg.Location = New System.Drawing.Point(194, 144)
        Me.lblCateg.Name = "lblCateg"
        Me.lblCateg.Size = New System.Drawing.Size(330, 17)
        Me.lblCateg.TabIndex = 38
        Me.lblCateg.Text = "categ"
        Me.lblCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtQuantityOut
        '
        Me.txtQuantityOut.Depth = 0
        Me.txtQuantityOut.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityOut.Hint = ""
        Me.txtQuantityOut.Location = New System.Drawing.Point(197, 164)
        Me.txtQuantityOut.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQuantityOut.Name = "txtQuantityOut"
        Me.txtQuantityOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantityOut.SelectedText = ""
        Me.txtQuantityOut.SelectionLength = 0
        Me.txtQuantityOut.SelectionStart = 0
        Me.txtQuantityOut.Size = New System.Drawing.Size(83, 23)
        Me.txtQuantityOut.TabIndex = 40
        Me.txtQuantityOut.UseSystemPasswordChar = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 164)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Quantity Used"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmItemQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 277)
        Me.Controls.Add(Me.txtQuantityOut)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblCateg)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblQty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblTxn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItemQuantity"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Item Checkout"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSaveItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTxn As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblDesc As Label
    Friend WithEvents lblQty As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblCateg As Label
    Friend WithEvents txtQuantityOut As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
