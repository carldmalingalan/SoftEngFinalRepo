<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransactionManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionManager))
        Me.gbTransDetails = New System.Windows.Forms.GroupBox()
        Me.txtServices = New System.Windows.Forms.TextBox()
        Me.btnChecklistBox = New System.Windows.Forms.Button()
        Me.clbServices = New System.Windows.Forms.CheckedListBox()
        Me.txtCustomerNumber = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustLastname = New System.Windows.Forms.TextBox()
        Me.txtCustMiddlename = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustFirstname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRemarks = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.cboEmployeeAssigned = New MetroFramework.Controls.MetroComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelTransaction = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnSaveTransaction = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExistingCustomer = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnNewCustomer = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.gbTransDetails.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTransDetails
        '
        Me.gbTransDetails.AutoSize = True
        Me.gbTransDetails.Controls.Add(Me.txtServices)
        Me.gbTransDetails.Controls.Add(Me.btnChecklistBox)
        Me.gbTransDetails.Controls.Add(Me.clbServices)
        Me.gbTransDetails.Controls.Add(Me.txtCustomerNumber)
        Me.gbTransDetails.Controls.Add(Me.Label7)
        Me.gbTransDetails.Controls.Add(Me.txtCustLastname)
        Me.gbTransDetails.Controls.Add(Me.txtCustMiddlename)
        Me.gbTransDetails.Controls.Add(Me.Label6)
        Me.gbTransDetails.Controls.Add(Me.Label4)
        Me.gbTransDetails.Controls.Add(Me.txtCustFirstname)
        Me.gbTransDetails.Controls.Add(Me.Label2)
        Me.gbTransDetails.Controls.Add(Me.txtRemarks)
        Me.gbTransDetails.Controls.Add(Me.cboEmployeeAssigned)
        Me.gbTransDetails.Controls.Add(Me.Label1)
        Me.gbTransDetails.Controls.Add(Me.btnCancelTransaction)
        Me.gbTransDetails.Controls.Add(Me.btnSaveTransaction)
        Me.gbTransDetails.Controls.Add(Me.Label9)
        Me.gbTransDetails.Controls.Add(Me.Label3)
        Me.gbTransDetails.Enabled = False
        Me.gbTransDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTransDetails.Location = New System.Drawing.Point(8, 77)
        Me.gbTransDetails.Name = "gbTransDetails"
        Me.gbTransDetails.Size = New System.Drawing.Size(470, 340)
        Me.gbTransDetails.TabIndex = 31
        Me.gbTransDetails.TabStop = False
        Me.gbTransDetails.Text = "Details"
        '
        'txtServices
        '
        Me.txtServices.Location = New System.Drawing.Point(159, 132)
        Me.txtServices.Name = "txtServices"
        Me.txtServices.ReadOnly = True
        Me.txtServices.Size = New System.Drawing.Size(258, 23)
        Me.txtServices.TabIndex = 64
        Me.txtServices.Text = "Services"
        '
        'btnChecklistBox
        '
        Me.btnChecklistBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChecklistBox.Image = Global.InventoryManager.My.Resources.Resources.drop_down_arrow_1_
        Me.btnChecklistBox.Location = New System.Drawing.Point(417, 132)
        Me.btnChecklistBox.Name = "btnChecklistBox"
        Me.btnChecklistBox.Size = New System.Drawing.Size(27, 23)
        Me.btnChecklistBox.TabIndex = 63
        Me.btnChecklistBox.UseVisualStyleBackColor = True
        '
        'clbServices
        '
        Me.clbServices.CheckOnClick = True
        Me.clbServices.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbServices.FormattingEnabled = True
        Me.clbServices.Location = New System.Drawing.Point(161, 150)
        Me.clbServices.Name = "clbServices"
        Me.clbServices.Size = New System.Drawing.Size(258, 94)
        Me.clbServices.TabIndex = 38
        Me.clbServices.Visible = False
        '
        'txtCustomerNumber
        '
        Me.txtCustomerNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustomerNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCustomerNumber.Enabled = False
        Me.txtCustomerNumber.Location = New System.Drawing.Point(159, 29)
        Me.txtCustomerNumber.Name = "txtCustomerNumber"
        Me.txtCustomerNumber.Size = New System.Drawing.Size(96, 23)
        Me.txtCustomerNumber.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Customer ID:"
        '
        'txtCustLastname
        '
        Me.txtCustLastname.Location = New System.Drawing.Point(159, 66)
        Me.txtCustLastname.Name = "txtCustLastname"
        Me.txtCustLastname.Size = New System.Drawing.Size(285, 23)
        Me.txtCustLastname.TabIndex = 59
        '
        'txtCustMiddlename
        '
        Me.txtCustMiddlename.Location = New System.Drawing.Point(415, 100)
        Me.txtCustMiddlename.MaxLength = 1
        Me.txtCustMiddlename.Name = "txtCustMiddlename"
        Me.txtCustMiddlename.Size = New System.Drawing.Size(29, 23)
        Me.txtCustMiddlename.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(381, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "M.I.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Lastname:"
        '
        'txtCustFirstname
        '
        Me.txtCustFirstname.Location = New System.Drawing.Point(159, 100)
        Me.txtCustFirstname.Name = "txtCustFirstname"
        Me.txtCustFirstname.Size = New System.Drawing.Size(165, 23)
        Me.txtCustFirstname.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 16)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Additional Remarks:"
        '
        'txtRemarks
        '
        Me.txtRemarks.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtRemarks.Location = New System.Drawing.Point(159, 199)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(285, 71)
        Me.txtRemarks.TabIndex = 53
        '
        'cboEmployeeAssigned
        '
        Me.cboEmployeeAssigned.ItemHeight = 23
        Me.cboEmployeeAssigned.Location = New System.Drawing.Point(159, 164)
        Me.cboEmployeeAssigned.Name = "cboEmployeeAssigned"
        Me.cboEmployeeAssigned.Size = New System.Drawing.Size(285, 29)
        Me.cboEmployeeAssigned.TabIndex = 47
        Me.cboEmployeeAssigned.UseSelectable = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Employee Assigned:"
        '
        'btnCancelTransaction
        '
        Me.btnCancelTransaction.AutoSize = True
        Me.btnCancelTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancelTransaction.Depth = 0
        Me.btnCancelTransaction.Location = New System.Drawing.Point(250, 279)
        Me.btnCancelTransaction.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancelTransaction.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancelTransaction.Name = "btnCancelTransaction"
        Me.btnCancelTransaction.Primary = False
        Me.btnCancelTransaction.Size = New System.Drawing.Size(64, 36)
        Me.btnCancelTransaction.TabIndex = 44
        Me.btnCancelTransaction.Text = "CANCEL"
        Me.btnCancelTransaction.UseVisualStyleBackColor = True
        '
        'btnSaveTransaction
        '
        Me.btnSaveTransaction.AutoSize = True
        Me.btnSaveTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveTransaction.Depth = 0
        Me.btnSaveTransaction.Location = New System.Drawing.Point(196, 279)
        Me.btnSaveTransaction.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveTransaction.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveTransaction.Name = "btnSaveTransaction"
        Me.btnSaveTransaction.Primary = False
        Me.btnSaveTransaction.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveTransaction.TabIndex = 45
        Me.btnSaveTransaction.Text = "Save"
        Me.btnSaveTransaction.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Service Availed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Firstname:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(484, 29)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(438, 388)
        Me.Panel1.TabIndex = 38
        '
        'btnExistingCustomer
        '
        Me.btnExistingCustomer.ActiveBorderThickness = 1
        Me.btnExistingCustomer.ActiveCornerRadius = 20
        Me.btnExistingCustomer.ActiveFillColor = System.Drawing.Color.Teal
        Me.btnExistingCustomer.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExistingCustomer.ActiveLineColor = System.Drawing.Color.Teal
        Me.btnExistingCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExistingCustomer.BackgroundImage = CType(resources.GetObject("btnExistingCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnExistingCustomer.ButtonText = "Existing"
        Me.btnExistingCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExistingCustomer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExistingCustomer.ForeColor = System.Drawing.Color.Teal
        Me.btnExistingCustomer.IdleBorderThickness = 1
        Me.btnExistingCustomer.IdleCornerRadius = 20
        Me.btnExistingCustomer.IdleFillColor = System.Drawing.Color.White
        Me.btnExistingCustomer.IdleForecolor = System.Drawing.Color.Teal
        Me.btnExistingCustomer.IdleLineColor = System.Drawing.Color.Teal
        Me.btnExistingCustomer.Location = New System.Drawing.Point(258, 14)
        Me.btnExistingCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnExistingCustomer.Name = "btnExistingCustomer"
        Me.btnExistingCustomer.Size = New System.Drawing.Size(129, 55)
        Me.btnExistingCustomer.TabIndex = 32
        Me.btnExistingCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNewCustomer
        '
        Me.btnNewCustomer.ActiveBorderThickness = 1
        Me.btnNewCustomer.ActiveCornerRadius = 20
        Me.btnNewCustomer.ActiveFillColor = System.Drawing.Color.SeaGreen
        Me.btnNewCustomer.ActiveForecolor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNewCustomer.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btnNewCustomer.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewCustomer.BackgroundImage = CType(resources.GetObject("btnNewCustomer.BackgroundImage"), System.Drawing.Image)
        Me.btnNewCustomer.ButtonText = "New"
        Me.btnNewCustomer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewCustomer.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewCustomer.ForeColor = System.Drawing.Color.SeaGreen
        Me.btnNewCustomer.IdleBorderThickness = 1
        Me.btnNewCustomer.IdleCornerRadius = 20
        Me.btnNewCustomer.IdleFillColor = System.Drawing.Color.White
        Me.btnNewCustomer.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btnNewCustomer.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btnNewCustomer.Location = New System.Drawing.Point(119, 14)
        Me.btnNewCustomer.Margin = New System.Windows.Forms.Padding(5)
        Me.btnNewCustomer.Name = "btnNewCustomer"
        Me.btnNewCustomer.Size = New System.Drawing.Size(129, 55)
        Me.btnNewCustomer.TabIndex = 32
        Me.btnNewCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmTransactionManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 423)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExistingCustomer)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.gbTransDetails)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransactionManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.gbTransDetails.ResumeLayout(False)
        Me.gbTransDetails.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbTransDetails As GroupBox
    Friend WithEvents txtCustFirstname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRemarks As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents cboEmployeeAssigned As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCancelTransaction As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSaveTransaction As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCustLastname As TextBox
    Friend WithEvents txtCustMiddlename As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnNewCustomer As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents btnExistingCustomer As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents txtCustomerNumber As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents clbServices As CheckedListBox
    Friend WithEvents txtServices As TextBox
    Friend WithEvents btnChecklistBox As Button
    Friend WithEvents Panel1 As Panel
End Class
