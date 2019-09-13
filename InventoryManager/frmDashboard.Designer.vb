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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDashboard))
        Me.chartEmployeeTransactions = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.chartCategories = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartEmployeeTransactions
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartEmployeeTransactions.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartEmployeeTransactions.Legends.Add(Legend1)
        Me.chartEmployeeTransactions.Location = New System.Drawing.Point(12, 104)
        Me.chartEmployeeTransactions.Name = "chartEmployeeTransactions"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Funnel
        Series1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsXValueIndexed = True
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.ShadowColor = System.Drawing.Color.Silver
        Me.chartEmployeeTransactions.Series.Add(Series1)
        Me.chartEmployeeTransactions.Size = New System.Drawing.Size(734, 391)
        Me.chartEmployeeTransactions.TabIndex = 0
        Me.chartEmployeeTransactions.Text = "Chart1"
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.White
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Tomato
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(12, 12)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(146, 86)
        Me.BunifuCards1.TabIndex = 1
        '
        'chartCategories
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartCategories.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartCategories.Legends.Add(Legend2)
        Me.chartCategories.Location = New System.Drawing.Point(750, 104)
        Me.chartCategories.Name = "chartCategories"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.chartCategories.Series.Add(Series2)
        Me.chartCategories.Size = New System.Drawing.Size(392, 391)
        Me.chartCategories.TabIndex = 2
        Me.chartCategories.Text = "Chart2"
        '
        'frmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.chartCategories)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.chartEmployeeTransactions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDashboard"
        Me.Text = "frmDashboard"
        CType(Me.chartEmployeeTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartEmployeeTransactions As DataVisualization.Charting.Chart
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents chartCategories As DataVisualization.Charting.Chart
End Class
