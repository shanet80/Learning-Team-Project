<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReports))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbContacts = New System.Windows.Forms.ToolStripButton()
        Me.tsbEmployees = New System.Windows.Forms.ToolStripButton()
        Me.tsbBilling = New System.Windows.Forms.ToolStripButton()
        Me.lstBoxReports = New System.Windows.Forms.ListBox()
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbContacts, Me.tsbEmployees, Me.tsbBilling})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 27)
        Me.ToolStrip1.TabIndex = 8
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbContacts
        '
        Me.tsbContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbContacts.Image = CType(resources.GetObject("tsbContacts.Image"), System.Drawing.Image)
        Me.tsbContacts.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContacts.Name = "tsbContacts"
        Me.tsbContacts.Size = New System.Drawing.Size(70, 24)
        Me.tsbContacts.Text = "Contacts"
        '
        'tsbEmployees
        '
        Me.tsbEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEmployees.Image = CType(resources.GetObject("tsbEmployees.Image"), System.Drawing.Image)
        Me.tsbEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEmployees.Name = "tsbEmployees"
        Me.tsbEmployees.Size = New System.Drawing.Size(85, 24)
        Me.tsbEmployees.Text = "Employees"
        '
        'tsbBilling
        '
        Me.tsbBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBilling.Image = CType(resources.GetObject("tsbBilling.Image"), System.Drawing.Image)
        Me.tsbBilling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBilling.Name = "tsbBilling"
        Me.tsbBilling.Size = New System.Drawing.Size(55, 24)
        Me.tsbBilling.Text = "Billing"
        '
        'lstBoxReports
        '
        Me.lstBoxReports.FormattingEnabled = True
        Me.lstBoxReports.ItemHeight = 16
        Me.lstBoxReports.Items.AddRange(New Object() {"Open case list", "Closed case list", "Highest billing employees", "Lowest billing employees", "Top customers (case volume)"})
        Me.lstBoxReports.Location = New System.Drawing.Point(13, 31)
        Me.lstBoxReports.Name = "lstBoxReports"
        Me.lstBoxReports.Size = New System.Drawing.Size(214, 436)
        Me.lstBoxReports.TabIndex = 9
        '
        'dgvReports
        '
        Me.dgvReports.AllowUserToAddRows = False
        Me.dgvReports.AllowUserToDeleteRows = False
        Me.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(234, 31)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.RowTemplate.Height = 24
        Me.dgvReports.Size = New System.Drawing.Size(551, 436)
        Me.dgvReports.TabIndex = 10
        '
        'frmReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 476)
        Me.Controls.Add(Me.dgvReports)
        Me.Controls.Add(Me.lstBoxReports)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmReports"
        Me.Text = "LTB Insights"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbContacts As ToolStripButton
    Friend WithEvents tsbEmployees As ToolStripButton
    Friend WithEvents tsbBilling As ToolStripButton
    Friend WithEvents lstBoxReports As System.Windows.Forms.ListBox
    Friend WithEvents dgvReports As System.Windows.Forms.DataGridView
End Class
