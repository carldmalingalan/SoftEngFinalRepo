<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.chartEmployeeTransactions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartCategories = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartEmployeeTransactions
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartEmployeeTransactions.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartEmployeeTransactions.Legends.Add(Legend1)
        Me.chartEmployeeTransactions.Location = New System.Drawing.Point(12, 47)
        Me.chartEmployeeTransactions.Name = "chartEmployeeTransactions"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
        Series1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series2"
        Series1.ShadowColor = System.Drawing.Color.Silver
        Me.chartEmployeeTransactions.Series.Add(Series1)
        Me.chartEmployeeTransactions.Size = New System.Drawing.Size(573, 297)
        Me.chartEmployeeTransactions.TabIndex = 0
        Me.chartEmployeeTransactions.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Employee Transactions Count"
        Title1.Text = "Employee Transactions Count"
        Title1.ToolTip = "Employee Transactions Count"
        Me.chartEmployeeTransactions.Titles.Add(Title1)
        '
        'chartCategories
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartCategories.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartCategories.Legends.Add(Legend2)
        Me.chartCategories.Location = New System.Drawing.Point(591, 47)
        Me.chartCategories.Name = "chartCategories"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.IsValueShownAsLabel = True
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartCategories.Series.Add(Series2)
        Me.chartCategories.Size = New System.Drawing.Size(551, 297)
        Me.chartCategories.TabIndex = 2
        Me.chartCategories.Text = "Chart2"
        Title2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.Name = "Service Category"
        Title2.Text = "Service Category"
        Title2.ToolTip = "Service Category"
        Me.chartCategories.Titles.Add(Title2)
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(12, 12)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
        Me.MetroDateTime1.TabIndex = 3
        '
        'Chart1
        '
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(12, 350)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series3.IsValueShownAsLabel = True
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(551, 297)
        Me.Chart1.TabIndex = 4
        Me.Chart1.Text = "Chart2"
        Title3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.Name = "Service Category"
        Title3.Text = "Service Category"
        Title3.ToolTip = "Service Category"
        Me.Chart1.Titles.Add(Title3)
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.MetroDateTime1)
        Me.Controls.Add(Me.chartCategories)
        Me.Controls.Add(Me.chartEmployeeTransactions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartEmployeeTransactions As DataVisualization.Charting.Chart
    Friend WithEvents chartCategories As DataVisualization.Charting.Chart
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
