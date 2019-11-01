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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactionManager))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbTransDetails = New System.Windows.Forms.GroupBox()
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
        Me.cboServiceAvailed = New MetroFramework.Controls.MetroComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExistingCustomer = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.btnNewCustomer = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.lblResultCount = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearchname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvSearchList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.gbTransDetails.SuspendLayout()
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbTransDetails
        '
        Me.gbTransDetails.AutoSize = True
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
        Me.gbTransDetails.Controls.Add(Me.cboServiceAvailed)
        Me.gbTransDetails.Controls.Add(Me.Label9)
        Me.gbTransDetails.Controls.Add(Me.Label3)
        Me.gbTransDetails.Enabled = False
        Me.gbTransDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTransDetails.Location = New System.Drawing.Point(8, 77)
        Me.gbTransDetails.Name = "gbTransDetails"
        Me.gbTransDetails.Size = New System.Drawing.Size(479, 340)
        Me.gbTransDetails.TabIndex = 31
        Me.gbTransDetails.TabStop = False
        Me.gbTransDetails.Text = "Transaction Details"
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
        Me.txtCustLastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustLastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCustLastname.Location = New System.Drawing.Point(159, 66)
        Me.txtCustLastname.Name = "txtCustLastname"
        Me.txtCustLastname.Size = New System.Drawing.Size(305, 23)
        Me.txtCustLastname.TabIndex = 59
        '
        'txtCustMiddlename
        '
        Me.txtCustMiddlename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustMiddlename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCustMiddlename.Location = New System.Drawing.Point(413, 100)
        Me.txtCustMiddlename.MaxLength = 1
        Me.txtCustMiddlename.Name = "txtCustMiddlename"
        Me.txtCustMiddlename.Size = New System.Drawing.Size(51, 23)
        Me.txtCustMiddlename.TabIndex = 58
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 103)
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
        Me.txtCustFirstname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtCustFirstname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtCustFirstname.Location = New System.Drawing.Point(159, 100)
        Me.txtCustFirstname.Name = "txtCustFirstname"
        Me.txtCustFirstname.Size = New System.Drawing.Size(206, 23)
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
        Me.txtRemarks.Size = New System.Drawing.Size(305, 71)
        Me.txtRemarks.TabIndex = 53
        '
        'cboEmployeeAssigned
        '
        Me.cboEmployeeAssigned.ItemHeight = 23
        Me.cboEmployeeAssigned.Location = New System.Drawing.Point(159, 164)
        Me.cboEmployeeAssigned.Name = "cboEmployeeAssigned"
        Me.cboEmployeeAssigned.Size = New System.Drawing.Size(305, 29)
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
        Me.btnCancelTransaction.Location = New System.Drawing.Point(238, 279)
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
        Me.btnSaveTransaction.Location = New System.Drawing.Point(184, 279)
        Me.btnSaveTransaction.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveTransaction.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveTransaction.Name = "btnSaveTransaction"
        Me.btnSaveTransaction.Primary = False
        Me.btnSaveTransaction.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveTransaction.TabIndex = 45
        Me.btnSaveTransaction.Text = "Save"
        Me.btnSaveTransaction.UseVisualStyleBackColor = True
        '
        'cboServiceAvailed
        '
        Me.cboServiceAvailed.ItemHeight = 23
        Me.cboServiceAvailed.Location = New System.Drawing.Point(159, 129)
        Me.cboServiceAvailed.Name = "cboServiceAvailed"
        Me.cboServiceAvailed.Size = New System.Drawing.Size(305, 29)
        Me.cboServiceAvailed.TabIndex = 43
        Me.cboServiceAvailed.UseSelectable = True
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
        'lblResultCount
        '
        Me.lblResultCount.AutoSize = True
        Me.lblResultCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultCount.Location = New System.Drawing.Point(494, 65)
        Me.lblResultCount.Name = "lblResultCount"
        Me.lblResultCount.Size = New System.Drawing.Size(0, 17)
        Me.lblResultCount.TabIndex = 36
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(883, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearchname
        '
        Me.txtSearchname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchname.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchname.HintText = "Search Name"
        Me.txtSearchname.isPassword = False
        Me.txtSearchname.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchname.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineThickness = 3
        Me.txtSearchname.Location = New System.Drawing.Point(716, 47)
        Me.txtSearchname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchname.Name = "txtSearchname"
        Me.txtSearchname.Size = New System.Drawing.Size(160, 33)
        Me.txtSearchname.TabIndex = 33
        Me.txtSearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvSearchList
        '
        Me.dgvSearchList.AllowUserToAddRows = False
        Me.dgvSearchList.AllowUserToDeleteRows = False
        Me.dgvSearchList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvSearchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSearchList.DoubleBuffered = True
        Me.dgvSearchList.EnableHeadersVisualStyles = False
        Me.dgvSearchList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvSearchList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvSearchList.Location = New System.Drawing.Point(493, 85)
        Me.dgvSearchList.MultiSelect = False
        Me.dgvSearchList.Name = "dgvSearchList"
        Me.dgvSearchList.ReadOnly = True
        Me.dgvSearchList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchList.RowHeadersVisible = False
        Me.dgvSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchList.Size = New System.Drawing.Size(479, 332)
        Me.dgvSearchList.TabIndex = 37
        '
        'frmTransactionManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 427)
        Me.Controls.Add(Me.dgvSearchList)
        Me.Controls.Add(Me.lblResultCount)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearchname)
        Me.Controls.Add(Me.btnExistingCustomer)
        Me.Controls.Add(Me.btnNewCustomer)
        Me.Controls.Add(Me.gbTransDetails)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmTransactionManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.TopMost = True
        Me.gbTransDetails.ResumeLayout(False)
        Me.gbTransDetails.PerformLayout()
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cboServiceAvailed As MetroFramework.Controls.MetroComboBox
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
    Friend WithEvents lblResultCount As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearchname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvSearchList As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
