<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportOfStockCard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CrystalReportViewer3 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SuspendLayout()
        '
        'CrystalReportViewer3
        '
        Me.CrystalReportViewer3.ActiveViewIndex = -1
        Me.CrystalReportViewer3.AutoSize = True
        Me.CrystalReportViewer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer3.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer3.Name = "CrystalReportViewer3"
        Me.CrystalReportViewer3.SelectionFormula = ""
        Me.CrystalReportViewer3.Size = New System.Drawing.Size(284, 264)
        Me.CrystalReportViewer3.TabIndex = 0
        Me.CrystalReportViewer3.ViewTimeSelectionFormula = ""
        '
        'ReportOfStockCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 264)
        Me.Controls.Add(Me.CrystalReportViewer3)
        Me.Name = "ReportOfStockCard"
        Me.Text = "Report Of StockCard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer3 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
