<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBilling))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbEmployees = New System.Windows.Forms.ToolStripButton()
        Me.tsbContact = New System.Windows.Forms.ToolStripButton()
        Me.tsbReports = New System.Windows.Forms.ToolStripButton()
        Me.cmbEmpSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbClientSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbMatterSelect = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbBillingStatus = New System.Windows.Forms.ComboBox()
        Me.txtBilledHours = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBilledAmount = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillingDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEmployees, Me.tsbContact, Me.tsbReports})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 27)
        Me.ToolStrip1.TabIndex = 37
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'tsbContact
        '
        Me.tsbContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbContact.Image = CType(resources.GetObject("tsbContact.Image"), System.Drawing.Image)
        Me.tsbContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbContact.Name = "tsbContact"
        Me.tsbContact.Size = New System.Drawing.Size(64, 24)
        Me.tsbContact.Text = "Contact"
        '
        'tsbReports
        '
        Me.tsbReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbReports.Image = CType(resources.GetObject("tsbReports.Image"), System.Drawing.Image)
        Me.tsbReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReports.Name = "tsbReports"
        Me.tsbReports.Size = New System.Drawing.Size(63, 24)
        Me.tsbReports.Text = "Insights"
        '
        'cmbEmpSelect
        '
        Me.cmbEmpSelect.FormattingEnabled = True
        Me.cmbEmpSelect.Location = New System.Drawing.Point(13, 33)
        Me.cmbEmpSelect.Name = "cmbEmpSelect"
        Me.cmbEmpSelect.Size = New System.Drawing.Size(196, 24)
        Me.cmbEmpSelect.TabIndex = 38
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbEmpSelect)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 82)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select employee"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbClientSelect)
        Me.GroupBox2.Location = New System.Drawing.Point(30, 143)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(254, 82)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Client"
        '
        'cmbClientSelect
        '
        Me.cmbClientSelect.Enabled = False
        Me.cmbClientSelect.FormattingEnabled = True
        Me.cmbClientSelect.Location = New System.Drawing.Point(13, 33)
        Me.cmbClientSelect.Name = "cmbClientSelect"
        Me.cmbClientSelect.Size = New System.Drawing.Size(196, 24)
        Me.cmbClientSelect.TabIndex = 38
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbMatterSelect)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 244)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(254, 82)
        Me.GroupBox3.TabIndex = 41
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Select Matter"
        '
        'cmbMatterSelect
        '
        Me.cmbMatterSelect.Enabled = False
        Me.cmbMatterSelect.FormattingEnabled = True
        Me.cmbMatterSelect.Location = New System.Drawing.Point(13, 33)
        Me.cmbMatterSelect.Name = "cmbMatterSelect"
        Me.cmbMatterSelect.Size = New System.Drawing.Size(196, 24)
        Me.cmbMatterSelect.TabIndex = 38
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnInsert)
        Me.GroupBox4.Controls.Add(Me.btnReset)
        Me.GroupBox4.Controls.Add(Me.cmbBillingStatus)
        Me.GroupBox4.Controls.Add(Me.txtBilledHours)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.txtBilledAmount)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtBillingDate)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(308, 42)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(460, 411)
        Me.GroupBox4.TabIndex = 42
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Billing Detail"
        '
        'btnInsert
        '
        Me.btnInsert.Enabled = False
        Me.btnInsert.Location = New System.Drawing.Point(306, 234)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(82, 24)
        Me.btnInsert.TabIndex = 14
        Me.btnInsert.Text = "&Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(180, 234)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(82, 24)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cmbBillingStatus
        '
        Me.cmbBillingStatus.Enabled = False
        Me.cmbBillingStatus.FormattingEnabled = True
        Me.cmbBillingStatus.Items.AddRange(New Object() {"BILLED", "PAID", "HOLD"})
        Me.cmbBillingStatus.Location = New System.Drawing.Point(150, 164)
        Me.cmbBillingStatus.Name = "cmbBillingStatus"
        Me.cmbBillingStatus.Size = New System.Drawing.Size(238, 24)
        Me.cmbBillingStatus.TabIndex = 12
        '
        'txtBilledHours
        '
        Me.txtBilledHours.Enabled = False
        Me.txtBilledHours.Location = New System.Drawing.Point(150, 121)
        Me.txtBilledHours.Mask = "00000"
        Me.txtBilledHours.Name = "txtBilledHours"
        Me.txtBilledHours.Size = New System.Drawing.Size(238, 22)
        Me.txtBilledHours.TabIndex = 11
        Me.txtBilledHours.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Billing Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Billed Hours"
        '
        'txtBilledAmount
        '
        Me.txtBilledAmount.Enabled = False
        Me.txtBilledAmount.Location = New System.Drawing.Point(150, 76)
        Me.txtBilledAmount.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtBilledAmount.Mask = "$999999"
        Me.txtBilledAmount.Name = "txtBilledAmount"
        Me.txtBilledAmount.Size = New System.Drawing.Size(238, 22)
        Me.txtBilledAmount.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Billed Amount"
        '
        'txtBillingDate
        '
        Me.txtBillingDate.CustomFormat = "mm/dd/yyyy"
        Me.txtBillingDate.Enabled = False
        Me.txtBillingDate.Location = New System.Drawing.Point(150, 33)
        Me.txtBillingDate.Name = "txtBillingDate"
        Me.txtBillingDate.Size = New System.Drawing.Size(238, 22)
        Me.txtBillingDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Billing Date"
        '
        'frmBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 476)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmBilling"
        Me.Text = "Billing Form"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbEmployees As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbContact As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbReports As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbEmpSelect As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbClientSelect As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMatterSelect As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBillingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBilledAmount As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbBillingStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtBilledHours As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
