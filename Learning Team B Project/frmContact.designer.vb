<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContact))
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim PrefixLabel As System.Windows.Forms.Label
        Dim SuffixLabel As System.Windows.Forms.Label
        Dim Client_AddressLabel As System.Windows.Forms.Label
        Dim Client_Address2Label As System.Windows.Forms.Label
        Dim Client_StateLabel As System.Windows.Forms.Label
        Dim Client_CityLabel As System.Windows.Forms.Label
        Dim Client_Zip_CodeLabel As System.Windows.Forms.Label
        Dim Client_PhoneLabel As System.Windows.Forms.Label
        Dim Client_ExtensionLabel As System.Windows.Forms.Label
        Dim Client_FaxLabel As System.Windows.Forms.Label
        Dim Client_EmailLabel As System.Windows.Forms.Label
        Dim Client_MobileLabel As System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbEmployees = New System.Windows.Forms.ToolStripButton()
        Me.tsbBilling = New System.Windows.Forms.ToolStripButton()
        Me.tsbReports = New System.Windows.Forms.ToolStripButton()
        Me.LTB_CRM_EmployeeList = New Learning_Team_B_Project.LTB_CRM_EmployeeList()
        Me.Employee_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Employee_TableTableAdapter = New Learning_Team_B_Project.LTB_CRM_EmployeeListTableAdapters.Employee_TableTableAdapter()
        Me.TableAdapterManager = New Learning_Team_B_Project.LTB_CRM_EmployeeListTableAdapters.TableAdapterManager()
        Me.LTB_CRM_DBDataSet = New Learning_Team_B_Project.LTB_CRM_DBDataSet()
        Me.Client_TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_TableTableAdapter = New Learning_Team_B_Project.LTB_CRM_DBDataSetTableAdapters.Client_TableTableAdapter()
        Me.TableAdapterManager1 = New Learning_Team_B_Project.LTB_CRM_DBDataSetTableAdapters.TableAdapterManager()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PrefixTextBox = New System.Windows.Forms.TextBox()
        Me.SuffixTextBox = New System.Windows.Forms.TextBox()
        Me.Client_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Client_Address2TextBox = New System.Windows.Forms.TextBox()
        Me.Client_StateTextBox = New System.Windows.Forms.TextBox()
        Me.Client_CityTextBox = New System.Windows.Forms.TextBox()
        Me.Client_Zip_CodeTextBox = New System.Windows.Forms.TextBox()
        Me.Client_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.Client_ExtensionTextBox = New System.Windows.Forms.TextBox()
        Me.Client_FaxTextBox = New System.Windows.Forms.TextBox()
        Me.Client_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.Client_MobileTextBox = New System.Windows.Forms.TextBox()
        Me.Client_TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        PrefixLabel = New System.Windows.Forms.Label()
        SuffixLabel = New System.Windows.Forms.Label()
        Client_AddressLabel = New System.Windows.Forms.Label()
        Client_Address2Label = New System.Windows.Forms.Label()
        Client_StateLabel = New System.Windows.Forms.Label()
        Client_CityLabel = New System.Windows.Forms.Label()
        Client_Zip_CodeLabel = New System.Windows.Forms.Label()
        Client_PhoneLabel = New System.Windows.Forms.Label()
        Client_ExtensionLabel = New System.Windows.Forms.Label()
        Client_FaxLabel = New System.Windows.Forms.Label()
        Client_EmailLabel = New System.Windows.Forms.Label()
        Client_MobileLabel = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.LTB_CRM_EmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Employee_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTB_CRM_DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbEmployees, Me.tsbBilling, Me.tsbReports})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(502, 25)
        Me.ToolStrip1.TabIndex = 36
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbEmployees
        '
        Me.tsbEmployees.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbEmployees.Image = CType(resources.GetObject("tsbEmployees.Image"), System.Drawing.Image)
        Me.tsbEmployees.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEmployees.Name = "tsbEmployees"
        Me.tsbEmployees.Size = New System.Drawing.Size(68, 22)
        Me.tsbEmployees.Text = "Employees"
        '
        'tsbBilling
        '
        Me.tsbBilling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbBilling.Image = CType(resources.GetObject("tsbBilling.Image"), System.Drawing.Image)
        Me.tsbBilling.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbBilling.Name = "tsbBilling"
        Me.tsbBilling.Size = New System.Drawing.Size(44, 22)
        Me.tsbBilling.Text = "Billing"
        '
        'tsbReports
        '
        Me.tsbReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbReports.Image = CType(resources.GetObject("tsbReports.Image"), System.Drawing.Image)
        Me.tsbReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbReports.Name = "tsbReports"
        Me.tsbReports.Size = New System.Drawing.Size(52, 22)
        Me.tsbReports.Text = "Insights"
        '
        'LTB_CRM_EmployeeList
        '
        Me.LTB_CRM_EmployeeList.DataSetName = "LTB_CRM_EmployeeList"
        Me.LTB_CRM_EmployeeList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Employee_TableBindingSource
        '
        Me.Employee_TableBindingSource.DataMember = "Employee_Table"
        Me.Employee_TableBindingSource.DataSource = Me.LTB_CRM_EmployeeList
        '
        'Employee_TableTableAdapter
        '
        Me.Employee_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Employee_TableTableAdapter = Me.Employee_TableTableAdapter
        Me.TableAdapterManager.Job_Titles_TableTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Learning_Team_B_Project.LTB_CRM_EmployeeListTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LTB_CRM_DBDataSet
        '
        Me.LTB_CRM_DBDataSet.DataSetName = "LTB_CRM_DBDataSet"
        Me.LTB_CRM_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Client_TableBindingSource
        '
        Me.Client_TableBindingSource.DataMember = "Client_Table"
        Me.Client_TableBindingSource.DataSource = Me.LTB_CRM_DBDataSet
        '
        'Client_TableTableAdapter
        '
        Me.Client_TableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Client_TableTableAdapter = Me.Client_TableTableAdapter
        Me.TableAdapterManager1.UpdateOrder = Learning_Team_B_Project.LTB_CRM_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Location = New System.Drawing.Point(37, 71)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(60, 13)
        First_NameLabel.TabIndex = 37
        First_NameLabel.Text = "First Name:"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "First_Name", True))
        Me.First_NameTextBox.Location = New System.Drawing.Point(103, 68)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.First_NameTextBox.TabIndex = 38
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Location = New System.Drawing.Point(36, 97)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(61, 13)
        Last_NameLabel.TabIndex = 38
        Last_NameLabel.Text = "Last Name:"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Last_Name", True))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(103, 94)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Last_NameTextBox.TabIndex = 39
        '
        'PrefixLabel
        '
        PrefixLabel.AutoSize = True
        PrefixLabel.Location = New System.Drawing.Point(61, 123)
        PrefixLabel.Name = "PrefixLabel"
        PrefixLabel.Size = New System.Drawing.Size(36, 13)
        PrefixLabel.TabIndex = 39
        PrefixLabel.Text = "Prefix:"
        '
        'PrefixTextBox
        '
        Me.PrefixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Prefix", True))
        Me.PrefixTextBox.Location = New System.Drawing.Point(103, 120)
        Me.PrefixTextBox.Name = "PrefixTextBox"
        Me.PrefixTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PrefixTextBox.TabIndex = 40
        '
        'SuffixLabel
        '
        SuffixLabel.AutoSize = True
        SuffixLabel.Location = New System.Drawing.Point(61, 149)
        SuffixLabel.Name = "SuffixLabel"
        SuffixLabel.Size = New System.Drawing.Size(36, 13)
        SuffixLabel.TabIndex = 40
        SuffixLabel.Text = "Suffix:"
        '
        'SuffixTextBox
        '
        Me.SuffixTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Suffix", True))
        Me.SuffixTextBox.Location = New System.Drawing.Point(103, 146)
        Me.SuffixTextBox.Name = "SuffixTextBox"
        Me.SuffixTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SuffixTextBox.TabIndex = 41
        '
        'Client_AddressLabel
        '
        Client_AddressLabel.AutoSize = True
        Client_AddressLabel.Location = New System.Drawing.Point(226, 71)
        Client_AddressLabel.Name = "Client_AddressLabel"
        Client_AddressLabel.Size = New System.Drawing.Size(77, 13)
        Client_AddressLabel.TabIndex = 41
        Client_AddressLabel.Text = "Client Address:"
        '
        'Client_AddressTextBox
        '
        Me.Client_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Address", True))
        Me.Client_AddressTextBox.Location = New System.Drawing.Point(309, 68)
        Me.Client_AddressTextBox.Name = "Client_AddressTextBox"
        Me.Client_AddressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_AddressTextBox.TabIndex = 42
        '
        'Client_Address2Label
        '
        Client_Address2Label.AutoSize = True
        Client_Address2Label.Location = New System.Drawing.Point(220, 97)
        Client_Address2Label.Name = "Client_Address2Label"
        Client_Address2Label.Size = New System.Drawing.Size(83, 13)
        Client_Address2Label.TabIndex = 42
        Client_Address2Label.Text = "Client Address2:"
        '
        'Client_Address2TextBox
        '
        Me.Client_Address2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Address2", True))
        Me.Client_Address2TextBox.Location = New System.Drawing.Point(309, 94)
        Me.Client_Address2TextBox.Name = "Client_Address2TextBox"
        Me.Client_Address2TextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_Address2TextBox.TabIndex = 43
        '
        'Client_StateLabel
        '
        Client_StateLabel.AutoSize = True
        Client_StateLabel.Location = New System.Drawing.Point(239, 149)
        Client_StateLabel.Name = "Client_StateLabel"
        Client_StateLabel.Size = New System.Drawing.Size(64, 13)
        Client_StateLabel.TabIndex = 43
        Client_StateLabel.Text = "Client State:"
        '
        'Client_StateTextBox
        '
        Me.Client_StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_State", True))
        Me.Client_StateTextBox.Location = New System.Drawing.Point(309, 146)
        Me.Client_StateTextBox.Name = "Client_StateTextBox"
        Me.Client_StateTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_StateTextBox.TabIndex = 44
        '
        'Client_CityLabel
        '
        Client_CityLabel.AutoSize = True
        Client_CityLabel.Location = New System.Drawing.Point(247, 123)
        Client_CityLabel.Name = "Client_CityLabel"
        Client_CityLabel.Size = New System.Drawing.Size(56, 13)
        Client_CityLabel.TabIndex = 44
        Client_CityLabel.Text = "Client City:"
        '
        'Client_CityTextBox
        '
        Me.Client_CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_City", True))
        Me.Client_CityTextBox.Location = New System.Drawing.Point(309, 120)
        Me.Client_CityTextBox.Name = "Client_CityTextBox"
        Me.Client_CityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_CityTextBox.TabIndex = 45
        '
        'Client_Zip_CodeLabel
        '
        Client_Zip_CodeLabel.AutoSize = True
        Client_Zip_CodeLabel.Location = New System.Drawing.Point(221, 175)
        Client_Zip_CodeLabel.Name = "Client_Zip_CodeLabel"
        Client_Zip_CodeLabel.Size = New System.Drawing.Size(82, 13)
        Client_Zip_CodeLabel.TabIndex = 45
        Client_Zip_CodeLabel.Text = "Client Zip Code:"
        '
        'Client_Zip_CodeTextBox
        '
        Me.Client_Zip_CodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Zip_Code", True))
        Me.Client_Zip_CodeTextBox.Location = New System.Drawing.Point(309, 172)
        Me.Client_Zip_CodeTextBox.Name = "Client_Zip_CodeTextBox"
        Me.Client_Zip_CodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_Zip_CodeTextBox.TabIndex = 46
        '
        'Client_PhoneLabel
        '
        Client_PhoneLabel.AutoSize = True
        Client_PhoneLabel.Location = New System.Drawing.Point(27, 175)
        Client_PhoneLabel.Name = "Client_PhoneLabel"
        Client_PhoneLabel.Size = New System.Drawing.Size(70, 13)
        Client_PhoneLabel.TabIndex = 46
        Client_PhoneLabel.Text = "Client Phone:"
        '
        'Client_PhoneTextBox
        '
        Me.Client_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Phone", True))
        Me.Client_PhoneTextBox.Location = New System.Drawing.Point(103, 172)
        Me.Client_PhoneTextBox.Name = "Client_PhoneTextBox"
        Me.Client_PhoneTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_PhoneTextBox.TabIndex = 47
        '
        'Client_ExtensionLabel
        '
        Client_ExtensionLabel.AutoSize = True
        Client_ExtensionLabel.Location = New System.Drawing.Point(12, 201)
        Client_ExtensionLabel.Name = "Client_ExtensionLabel"
        Client_ExtensionLabel.Size = New System.Drawing.Size(85, 13)
        Client_ExtensionLabel.TabIndex = 47
        Client_ExtensionLabel.Text = "Client Extension:"
        '
        'Client_ExtensionTextBox
        '
        Me.Client_ExtensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Extension", True))
        Me.Client_ExtensionTextBox.Location = New System.Drawing.Point(103, 198)
        Me.Client_ExtensionTextBox.Name = "Client_ExtensionTextBox"
        Me.Client_ExtensionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_ExtensionTextBox.TabIndex = 48
        '
        'Client_FaxLabel
        '
        Client_FaxLabel.AutoSize = True
        Client_FaxLabel.Location = New System.Drawing.Point(247, 227)
        Client_FaxLabel.Name = "Client_FaxLabel"
        Client_FaxLabel.Size = New System.Drawing.Size(56, 13)
        Client_FaxLabel.TabIndex = 48
        Client_FaxLabel.Text = "Client Fax:"
        '
        'Client_FaxTextBox
        '
        Me.Client_FaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Fax", True))
        Me.Client_FaxTextBox.Location = New System.Drawing.Point(309, 224)
        Me.Client_FaxTextBox.Name = "Client_FaxTextBox"
        Me.Client_FaxTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_FaxTextBox.TabIndex = 49
        '
        'Client_EmailLabel
        '
        Client_EmailLabel.AutoSize = True
        Client_EmailLabel.Location = New System.Drawing.Point(239, 201)
        Client_EmailLabel.Name = "Client_EmailLabel"
        Client_EmailLabel.Size = New System.Drawing.Size(64, 13)
        Client_EmailLabel.TabIndex = 49
        Client_EmailLabel.Text = "Client Email:"
        '
        'Client_EmailTextBox
        '
        Me.Client_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Email", True))
        Me.Client_EmailTextBox.Location = New System.Drawing.Point(309, 198)
        Me.Client_EmailTextBox.Name = "Client_EmailTextBox"
        Me.Client_EmailTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_EmailTextBox.TabIndex = 50
        '
        'Client_MobileLabel
        '
        Client_MobileLabel.AutoSize = True
        Client_MobileLabel.Location = New System.Drawing.Point(27, 227)
        Client_MobileLabel.Name = "Client_MobileLabel"
        Client_MobileLabel.Size = New System.Drawing.Size(70, 13)
        Client_MobileLabel.TabIndex = 50
        Client_MobileLabel.Text = "Client Mobile:"
        '
        'Client_MobileTextBox
        '
        Me.Client_MobileTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_TableBindingSource, "Client_Mobile", True))
        Me.Client_MobileTextBox.Location = New System.Drawing.Point(103, 224)
        Me.Client_MobileTextBox.Name = "Client_MobileTextBox"
        Me.Client_MobileTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Client_MobileTextBox.TabIndex = 51
        '
        'Client_TableDataGridView
        '
        Me.Client_TableDataGridView.AutoGenerateColumns = False
        Me.Client_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Client_TableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.Client_TableDataGridView.DataSource = Me.Client_TableBindingSource
        Me.Client_TableDataGridView.Location = New System.Drawing.Point(30, 269)
        Me.Client_TableDataGridView.Name = "Client_TableDataGridView"
        Me.Client_TableDataGridView.Size = New System.Drawing.Size(439, 220)
        Me.Client_TableDataGridView.TabIndex = 51
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Client_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Client_ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "First_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First_Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Last_Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last_Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Prefix"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prefix"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Suffix"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Suffix"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Client_Address"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Client_Address"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Client_Address2"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Client_Address2"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Client_State"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Client_State"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Client_Zip_Code"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Client_Zip_Code"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Client_Phone"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Client_Phone"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Client_Extension"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Client_Extension"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Client_Mobile"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Client_Mobile"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Client_Fax"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Client_Fax"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Client_Email"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Client_Email"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Client_City"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Client_City"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 25)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(502, 25)
        Me.BindingNavigator1.TabIndex = 52
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'frmContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 533)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Client_TableDataGridView)
        Me.Controls.Add(Client_MobileLabel)
        Me.Controls.Add(Me.Client_MobileTextBox)
        Me.Controls.Add(Client_EmailLabel)
        Me.Controls.Add(Me.Client_EmailTextBox)
        Me.Controls.Add(Client_FaxLabel)
        Me.Controls.Add(Me.Client_FaxTextBox)
        Me.Controls.Add(Client_ExtensionLabel)
        Me.Controls.Add(Me.Client_ExtensionTextBox)
        Me.Controls.Add(Client_PhoneLabel)
        Me.Controls.Add(Me.Client_PhoneTextBox)
        Me.Controls.Add(Client_Zip_CodeLabel)
        Me.Controls.Add(Me.Client_Zip_CodeTextBox)
        Me.Controls.Add(Client_CityLabel)
        Me.Controls.Add(Me.Client_CityTextBox)
        Me.Controls.Add(Client_StateLabel)
        Me.Controls.Add(Me.Client_StateTextBox)
        Me.Controls.Add(Client_Address2Label)
        Me.Controls.Add(Me.Client_Address2TextBox)
        Me.Controls.Add(Client_AddressLabel)
        Me.Controls.Add(Me.Client_AddressTextBox)
        Me.Controls.Add(SuffixLabel)
        Me.Controls.Add(Me.SuffixTextBox)
        Me.Controls.Add(PrefixLabel)
        Me.Controls.Add(Me.PrefixTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmContact"
        Me.Text = "New Contact Form"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.LTB_CRM_EmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Employee_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTB_CRM_DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbEmployees As ToolStripButton
    Friend WithEvents tsbBilling As ToolStripButton
    Friend WithEvents tsbReports As ToolStripButton
    Friend WithEvents LTB_CRM_EmployeeList As LTB_CRM_EmployeeList
    Friend WithEvents Employee_TableBindingSource As BindingSource
    Friend WithEvents Employee_TableTableAdapter As LTB_CRM_EmployeeListTableAdapters.Employee_TableTableAdapter
    Friend WithEvents TableAdapterManager As LTB_CRM_EmployeeListTableAdapters.TableAdapterManager
    Friend WithEvents LTB_CRM_DBDataSet As LTB_CRM_DBDataSet
    Friend WithEvents Client_TableBindingSource As BindingSource
    Friend WithEvents Client_TableTableAdapter As LTB_CRM_DBDataSetTableAdapters.Client_TableTableAdapter
    Friend WithEvents TableAdapterManager1 As LTB_CRM_DBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents PrefixTextBox As TextBox
    Friend WithEvents SuffixTextBox As TextBox
    Friend WithEvents Client_AddressTextBox As TextBox
    Friend WithEvents Client_Address2TextBox As TextBox
    Friend WithEvents Client_StateTextBox As TextBox
    Friend WithEvents Client_CityTextBox As TextBox
    Friend WithEvents Client_Zip_CodeTextBox As TextBox
    Friend WithEvents Client_PhoneTextBox As TextBox
    Friend WithEvents Client_ExtensionTextBox As TextBox
    Friend WithEvents Client_FaxTextBox As TextBox
    Friend WithEvents Client_EmailTextBox As TextBox
    Friend WithEvents Client_MobileTextBox As TextBox
    Friend WithEvents Client_TableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
End Class
