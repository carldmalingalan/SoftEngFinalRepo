<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.chartEmployeeTransactions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartCategories = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.dtpDateFrom = New MetroFramework.Controls.MetroDateTime()
        Me.dtpDateTO = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalTransactions = New System.Windows.Forms.Label()
        Me.lblTopService = New System.Windows.Forms.Label()
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BunifuCards1.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartEmployeeTransactions
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartEmployeeTransactions.ChartAreas.Add(ChartArea1)
        Me.chartEmployeeTransactions.Location = New System.Drawing.Point(12, 154)
        Me.chartEmployeeTransactions.Name = "chartEmployeeTransactions"
        Me.chartEmployeeTransactions.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Yellow, System.Drawing.Color.Lime, System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer)), System.Drawing.Color.Silver}
        Series1.ChartArea = "ChartArea1"
        Series1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.IsXValueIndexed = True
        Series1.LegendText = "Employee Name"
        Series1.Name = "Series1"
        Series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright
        Series1.ShadowColor = System.Drawing.Color.Silver
        Series1.YValuesPerPoint = 2
        Me.chartEmployeeTransactions.Series.Add(Series1)
        Me.chartEmployeeTransactions.Size = New System.Drawing.Size(1113, 369)
        Me.chartEmployeeTransactions.TabIndex = 0
        Me.chartEmployeeTransactions.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Employee Service Count"
        Title1.Text = "Employee Transactions Count"
        Title1.ToolTip = "Employee Transactions Count"
        Me.chartEmployeeTransactions.Titles.Add(Title1)
        '
        'chartCategories
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartCategories.ChartAreas.Add(ChartArea2)
        Legend1.Name = "Legend1"
        Me.chartCategories.Legends.Add(Legend1)
        Me.chartCategories.Location = New System.Drawing.Point(12, 529)
        Me.chartCategories.Name = "chartCategories"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.CustomProperties = "PieDrawingStyle=SoftEdge, PieLabelStyle=Outside"
        Series2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartCategories.Series.Add(Series2)
        Me.chartCategories.Size = New System.Drawing.Size(1113, 370)
        Me.chartCategories.TabIndex = 2
        Me.chartCategories.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Service Category"
        Title2.Text = "Service Category"
        Title2.ToolTip = "Service Category"
        Me.chartCategories.Titles.Add(Title2)
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(12, 12)
        Me.dtpDateFrom.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(232, 29)
        Me.dtpDateFrom.TabIndex = 3
        '
        'dtpDateTO
        '
        Me.dtpDateTO.Location = New System.Drawing.Point(270, 12)
        Me.dtpDateTO.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateTO.Name = "dtpDateTO"
        Me.dtpDateTO.Size = New System.Drawing.Size(232, 29)
        Me.dtpDateTO.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(250, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "-"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Pink
        Me.BunifuCards1.Controls.Add(Me.lblTotalTransactions)
        Me.BunifuCards1.Controls.Add(Me.Label3)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 47)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(202, 84)
        Me.BunifuCards1.TabIndex = 6
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Pink
        Me.BunifuCards2.Controls.Add(Me.lblTopService)
        Me.BunifuCards2.Controls.Add(Me.Label2)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(220, 47)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(199, 84)
        Me.BunifuCards2.TabIndex = 6
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.search
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(508, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(29, 29)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 22
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 23)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Top Service"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Total Transactions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalTransactions
        '
        Me.lblTotalTransactions.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTransactions.Location = New System.Drawing.Point(3, 8)
        Me.lblTotalTransactions.Name = "lblTotalTransactions"
        Me.lblTotalTransactions.Size = New System.Drawing.Size(193, 45)
        Me.lblTotalTransactions.TabIndex = 24
        Me.lblTotalTransactions.Text = "0"
        Me.lblTotalTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTopService
        '
        Me.lblTopService.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTopService.Location = New System.Drawing.Point(3, 8)
        Me.lblTopService.Name = "lblTopService"
        Me.lblTopService.Size = New System.Drawing.Size(193, 45)
        Me.lblTopService.TabIndex = 24
        Me.lblTopService.Text = "0"
        Me.lblTopService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.BunifuCards2)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpDateTO)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.chartCategories)
        Me.Controls.Add(Me.chartEmployeeTransactions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chartEmployeeTransactions As DataVisualization.Charting.Chart
    Friend WithEvents chartCategories As DataVisualization.Charting.Chart
    Friend WithEvents dtpDateFrom As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpDateTO As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalTransactions As Label
    Friend WithEvents lblTopService As Label
End Class
