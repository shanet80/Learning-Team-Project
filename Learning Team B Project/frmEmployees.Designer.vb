<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployees
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployees))
        Me.lblFName = New System.Windows.Forms.Label()
        Me.lblMName = New System.Windows.Forms.Label()
        Me.lblLName = New System.Windows.Forms.Label()
        Me.lblPrefix = New System.Windows.Forms.Label()
        Me.lblSuffix = New System.Windows.Forms.Label()
        Me.lblSSN = New System.Windows.Forms.Label()
        Me.lblJobTitle = New System.Windows.Forms.Label()
        Me.lblEmployeeID = New System.Windows.Forms.Label()
        Me.cmboxPrefix = New System.Windows.Forms.ComboBox()
        Me.cmboxSuffix = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtMidName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSaveNew = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.txtSSN = New System.Windows.Forms.MaskedTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtJobTitle = New System.Windows.Forms.ComboBox()
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.MaskedTextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbContacts = New System.Windows.Forms.ToolStripButton()
        Me.tsbBilling = New System.Windows.Forms.ToolStripButton()
        Me.tsbReports = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Location = New System.Drawing.Point(481, 106)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(76, 17)
        Me.lblFName.TabIndex = 0
        Me.lblFName.Text = "First Name"
        '
        'lblMName
        '
        Me.lblMName.AutoSize = True
        Me.lblMName.Location = New System.Drawing.Point(467, 142)
        Me.lblMName.Name = "lblMName"
        Me.lblMName.Size = New System.Drawing.Size(90, 17)
        Me.lblMName.TabIndex = 1
        Me.lblMName.Text = "Middle Name"
        '
        'lblLName
        '
        Me.lblLName.AutoSize = True
        Me.lblLName.Location = New System.Drawing.Point(481, 175)
        Me.lblLName.Name = "lblLName"
        Me.lblLName.Size = New System.Drawing.Size(76, 17)
        Me.lblLName.TabIndex = 2
        Me.lblLName.Text = "Last Name"
        '
        'lblPrefix
        '
        Me.lblPrefix.AutoSize = True
        Me.lblPrefix.Location = New System.Drawing.Point(515, 73)
        Me.lblPrefix.Name = "lblPrefix"
        Me.lblPrefix.Size = New System.Drawing.Size(43, 17)
        Me.lblPrefix.TabIndex = 3
        Me.lblPrefix.Text = "Prefix"
        '
        'lblSuffix
        '
        Me.lblSuffix.AutoSize = True
        Me.lblSuffix.Location = New System.Drawing.Point(515, 210)
        Me.lblSuffix.Name = "lblSuffix"
        Me.lblSuffix.Size = New System.Drawing.Size(42, 17)
        Me.lblSuffix.TabIndex = 4
        Me.lblSuffix.Text = "Suffix"
        '
        'lblSSN
        '
        Me.lblSSN.AutoSize = True
        Me.lblSSN.Location = New System.Drawing.Point(521, 245)
        Me.lblSSN.Name = "lblSSN"
        Me.lblSSN.Size = New System.Drawing.Size(36, 17)
        Me.lblSSN.TabIndex = 5
        Me.lblSSN.Text = "SSN"
        '
        'lblJobTitle
        '
        Me.lblJobTitle.AutoSize = True
        Me.lblJobTitle.Location = New System.Drawing.Point(495, 283)
        Me.lblJobTitle.Name = "lblJobTitle"
        Me.lblJobTitle.Size = New System.Drawing.Size(62, 17)
        Me.lblJobTitle.TabIndex = 6
        Me.lblJobTitle.Text = "Job Title"
        '
        'lblEmployeeID
        '
        Me.lblEmployeeID.AutoSize = True
        Me.lblEmployeeID.Location = New System.Drawing.Point(469, 359)
        Me.lblEmployeeID.Name = "lblEmployeeID"
        Me.lblEmployeeID.Size = New System.Drawing.Size(87, 17)
        Me.lblEmployeeID.TabIndex = 7
        Me.lblEmployeeID.Text = "Employee ID"
        '
        'cmboxPrefix
        '
        Me.cmboxPrefix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxPrefix.FormattingEnabled = True
        Me.cmboxPrefix.Items.AddRange(New Object() {"", "Mr.", "Mrs.", "Ms.", "Miss"})
        Me.cmboxPrefix.Location = New System.Drawing.Point(563, 69)
        Me.cmboxPrefix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmboxPrefix.Name = "cmboxPrefix"
        Me.cmboxPrefix.Size = New System.Drawing.Size(219, 24)
        Me.cmboxPrefix.TabIndex = 0
        '
        'cmboxSuffix
        '
        Me.cmboxSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxSuffix.FormattingEnabled = True
        Me.cmboxSuffix.ItemHeight = 16
        Me.cmboxSuffix.Items.AddRange(New Object() {"", "Jr.", "Sr.", "I", "II", "III", "IV", "V"})
        Me.cmboxSuffix.Location = New System.Drawing.Point(563, 203)
        Me.cmboxSuffix.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmboxSuffix.Name = "cmboxSuffix"
        Me.cmboxSuffix.Size = New System.Drawing.Size(219, 24)
        Me.cmboxSuffix.TabIndex = 4
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(563, 103)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(219, 22)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "First Name"
        '
        'txtMidName
        '
        Me.txtMidName.Location = New System.Drawing.Point(563, 138)
        Me.txtMidName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMidName.Name = "txtMidName"
        Me.txtMidName.Size = New System.Drawing.Size(219, 22)
        Me.txtMidName.TabIndex = 2
        Me.txtMidName.Text = "Middle Name"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(563, 171)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(219, 22)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "Last Name"
        '
        'txtEmpID
        '
        Me.txtEmpID.Enabled = False
        Me.txtEmpID.Location = New System.Drawing.Point(563, 357)
        Me.txtEmpID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(219, 22)
        Me.txtEmpID.TabIndex = 8
        Me.txtEmpID.Text = "Pulls from database"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(517, 405)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(95, 30)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "&Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSaveNew
        '
        Me.btnSaveNew.Location = New System.Drawing.Point(675, 405)
        Me.btnSaveNew.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveNew.Name = "btnSaveNew"
        Me.btnSaveNew.Size = New System.Drawing.Size(107, 30)
        Me.btnSaveNew.TabIndex = 10
        Me.btnSaveNew.Text = "&Save New"
        Me.btnSaveNew.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.AllowUserToAddRows = False
        Me.dgvEmployees.AllowUserToDeleteRows = False
        Me.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(21, 58)
        Me.dgvEmployees.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.ReadOnly = True
        Me.dgvEmployees.RowTemplate.Height = 24
        Me.dgvEmployees.Size = New System.Drawing.Size(433, 393)
        Me.dgvEmployees.TabIndex = 0
        '
        'txtSSN
        '
        Me.txtSSN.Location = New System.Drawing.Point(563, 240)
        Me.txtSSN.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSSN.Mask = "000-00-0000"
        Me.txtSSN.Name = "txtSSN"
        Me.txtSSN.Size = New System.Drawing.Size(219, 22)
        Me.txtSSN.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'txtJobTitle
        '
        Me.txtJobTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtJobTitle.FormattingEnabled = True
        Me.txtJobTitle.Location = New System.Drawing.Point(563, 283)
        Me.txtJobTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtJobTitle.Name = "txtJobTitle"
        Me.txtJobTitle.Size = New System.Drawing.Size(219, 24)
        Me.txtJobTitle.TabIndex = 6
        '
        'lblSalary
        '
        Me.lblSalary.AutoSize = True
        Me.lblSalary.Location = New System.Drawing.Point(481, 325)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(48, 17)
        Me.lblSalary.TabIndex = 13
        Me.lblSalary.Text = "Salary"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(563, 319)
        Me.txtSalary.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSalary.Mask = "$999999"
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.txtSalary.Size = New System.Drawing.Size(219, 22)
        Me.txtSalary.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbContacts, Me.tsbBilling, Me.tsbReports})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(797, 27)
        Me.ToolStrip1.TabIndex = 15
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
        'tsbBilling
        '
        Me.tsbBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBilling.Image = CType(resources.GetObject("tsbBilling.Image"), System.Drawing.Image)
        Me.tsbBilling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBilling.Name = "tsbBilling"
        Me.tsbBilling.Size = New System.Drawing.Size(55, 24)
        Me.tsbBilling.Text = "Billing"
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
        'frmEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(797, 476)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblSalary)
        Me.Controls.Add(Me.txtJobTitle)
        Me.Controls.Add(Me.txtSSN)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnSaveNew)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtEmpID)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtMidName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.cmboxSuffix)
        Me.Controls.Add(Me.cmboxPrefix)
        Me.Controls.Add(Me.lblEmployeeID)
        Me.Controls.Add(Me.lblJobTitle)
        Me.Controls.Add(Me.lblSSN)
        Me.Controls.Add(Me.lblSuffix)
        Me.Controls.Add(Me.lblPrefix)
        Me.Controls.Add(Me.lblLName)
        Me.Controls.Add(Me.lblMName)
        Me.Controls.Add(Me.lblFName)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmEmployees"
        Me.Text = "Employee Information"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFName As System.Windows.Forms.Label
    Friend WithEvents lblMName As System.Windows.Forms.Label
    Friend WithEvents lblLName As System.Windows.Forms.Label
    Friend WithEvents lblPrefix As System.Windows.Forms.Label
    Friend WithEvents lblSuffix As System.Windows.Forms.Label
    Friend WithEvents lblSSN As System.Windows.Forms.Label
    Friend WithEvents lblJobTitle As System.Windows.Forms.Label
    Friend WithEvents lblEmployeeID As System.Windows.Forms.Label
    Friend WithEvents cmboxPrefix As System.Windows.Forms.ComboBox
    Friend WithEvents cmboxSuffix As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtMidName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSaveNew As System.Windows.Forms.Button
    Friend WithEvents dgvEmployees As System.Windows.Forms.DataGridView
    Friend WithEvents txtSSN As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txtJobTitle As System.Windows.Forms.ComboBox
    Friend WithEvents lblSalary As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbContacts As ToolStripButton
    Friend WithEvents tsbBilling As ToolStripButton
    Friend WithEvents tsbReports As ToolStripButton
End Class
