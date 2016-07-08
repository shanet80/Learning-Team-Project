'Imports System.IO
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmEmployees
    'full path to mdf
    Dim path As String = Environment.CurrentDirectory
    Dim strSQLdbMDF As String = path + "\LTB_CRM_DB.mdf"
    'setup data connection
    Dim sqlCNString As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + strSQLdbMDF + """;Integrated Security=True;Connect Timeout=30")
    Dim strEmpQuery As String = "SELECT e.Employee_Id AS ""Employee ID"", e.First_Name AS ""First Name"", e.Last_Name AS ""Last Name"", j.Title_Description AS ""Job Title"", e.middle_name, e.prefix, e.suffix, e.soc_sec_num, e.employee_salary FROM Employee_Table e, Job_Titles_Table j WHERE j.Job_ID=e.Job_Id"
    'keep track of row selected
    Dim intCurRow As Integer = -1
    'keep track of the current selected employee
    Dim intSelectedEmployeeID As Integer = Nothing
    'keep track of secret delete availability
    Dim boolDelOk As Boolean = True
    'dictionary of job title ids and descriptions
    Dim dictJobTitle As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Private Sub frmEmployees_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillJobTitlefromDB()
        dgvLoad("Employees", strEmpQuery)
    End Sub
    Private Sub dgvLoad(strDataTable As String, strQuery As String)
        Dim sqlDataAdapter As New SqlDataAdapter
        Dim sqlDataSet As New DataSet
        sqlDataAdapter.SelectCommand = New SqlCommand
        sqlDataAdapter.SelectCommand.Connection = sqlCNString
        sqlDataAdapter.SelectCommand.CommandText = strQuery
        Try
            sqlDataAdapter.Fill(sqlDataSet)
            Dim sqlDataTable As New DataTable(strDataTable)
            sqlDataAdapter.Fill(sqlDataTable)
            dgvEmployees.DataSource = sqlDataTable
            dgvEmployees.Columns("middle_name").Visible = False
            dgvEmployees.Columns("prefix").Visible = False
            dgvEmployees.Columns("suffix").Visible = False
            dgvEmployees.Columns("soc_sec_num").Visible = False
            dgvEmployees.Columns("employee_salary").Visible = False
            dgvEmployees.Columns("employee id").Visible = False
            dgvEmployees.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            dgvEmployees.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvEmployees_CurrentCellChanged(sender As Object, e As EventArgs) Handles dgvEmployees.CurrentCellChanged
        GetCurrentRow()
    End Sub
    Private Sub GetCurrentRow()
        Try
            If IsNothing(dgvEmployees.CurrentRow) = False Then
                If intCurRow <> dgvEmployees.CurrentRow.Index Then
                    'grab the employee ID and load the form with additional data for editing
                    intSelectedEmployeeID = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("Employee ID").Value
                    frmLoad(intSelectedEmployeeID)
                    'Set the current row to variable so we can check on next click to avoid running DB query again
                    intCurRow = dgvEmployees.CurrentRow.Index
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub frmLoad(intEmpID As Integer)
        Try
            CenterForm()
            txtEmpID.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("Employee ID").Value.ToString
            txtFirstName.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("First Name").Value.ToString
            txtMidName.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("middle_name").Value.ToString
            txtLastName.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("Last Name").Value.ToString
            cmboxPrefix.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("prefix").Value.ToString
            cmboxSuffix.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("suffix").Value.ToString
            Dim ssn As String = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("soc_sec_num").Value.ToString
            ssn = ssn.Substring(0, 3) & "-" & ssn.Substring(3, 2) & "-" & ssn.Substring(5)
            txtJobTitle.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("Job Title").Value.ToString
            txtSalary.Text = dgvEmployees.Rows(dgvEmployees.CurrentRow.Index).Cells("employee_salary").Value.ToString
            txtSSN.Text = ssn
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub dgvEmployees_Sorted(sender As Object, e As EventArgs) Handles dgvEmployees.Sorted
        GetCurrentRow()
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        Try
            'Saves a new record
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT Employee_Table (Job_Id, First_Name, Middle_Name, Last_Name, Prefix, Suffix, Soc_Sec_Num, Employee_Salary) VALUES (" + dictJobTitle.Item(txtJobTitle.Text).ToString + ",'" + txtFirstName.Text + "','" + txtMidName.Text + "','" + txtLastName.Text + "','" + cmboxPrefix.Text + "','" + cmboxSuffix.Text + "','" + Replace(txtSSN.Text, "-", "") + "'," + fnRegExReplace(txtSalary.Text.ToString, "", "(\$)|(\,)") + ")"
            cmd.Connection = sqlCNString
            'MsgBox(cmd.CommandText)
            sqlCNString.Open()
            cmd.ExecuteNonQuery()
            sqlCNString.Close()
            'load the data grid after a save
            dgvLoad("Employees", strEmpQuery)
        Catch ex As Exception
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        'Updates an existing (selected) record
        Try
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "UPDATE Employee_Table set first_name='" + txtFirstName.Text + "', middle_name='" + txtMidName.Text + "',last_name='" + txtLastName.Text + "', prefix='" + cmboxPrefix.Text + "', suffix='" + cmboxSuffix.Text + "', soc_sec_num='" + Replace(txtSSN.Text, "-", "") + "'," + "employee_salary=" + fnRegExReplace(txtSalary.Text.ToString, "", "(\$)|(\,)") + ", job_id=" + dictJobTitle.Item(txtJobTitle.Text).ToString + " where employee_id=" + txtEmpID.Text.ToString
            'MsgBox(cmd.CommandText + vbCrLf + vbCrLf + fnRegExReplace(txtSalary.Text.ToString, "", "(\$)|(\,)"))
            cmd.Connection = sqlCNString

            sqlCNString.Open()
            cmd.ExecuteNonQuery()
            sqlCNString.Close()

            'load the data grid after a save
            dgvLoad("Employees", strEmpQuery)
        Catch ex As Exception
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If (boolDelOk = True AndAlso My.Computer.Keyboard.AltKeyDown = True AndAlso My.Computer.Keyboard.CtrlKeyDown = True AndAlso My.Computer.Keyboard.ShiftKeyDown) Then
                boolDelOk = False
                Dim strDelMsg As String
                strDelMsg = "Do you want to delete this record?" + vbCrLf + vbCrLf + "Employee ID: " + txtEmpID.Text.ToString + vbCrLf + "Employee Name: " + txtFirstName.Text.ToString + " " + txtLastName.Text.ToString

                Dim resDelEmp As Integer = MessageBox.Show(strDelMsg, "Secret Delete Option", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If resDelEmp = vbYes Then
                    'delete the record
                    Dim cmd As New System.Data.SqlClient.SqlCommand
                    cmd.CommandType = System.Data.CommandType.Text
                    cmd.CommandText = "DELETE FROM Employee_Table WHERE Employee_ID=" + txtEmpID.Text.ToString
                    cmd.Connection = sqlCNString
                    sqlCNString.Open()
                    cmd.ExecuteNonQuery()
                    sqlCNString.Close()
                    'load the data grid after a save
                    dgvLoad("Employees", strEmpQuery)
                    boolDelOk = True
                ElseIf resDelEmp = vbNo Then
                    'do nothing
                    boolDelOk = True
                End If
            End If
        Catch ex As Exception
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Public Sub FillJobTitlefromDB()
        'connect to the job_titles_table and pull a list to populate the dropdown
        Dim sqlJobTitles As New SqlCommand("SELECT title_description,job_id from job_titles_table order by title_description asc", sqlCNString) '<--or ("SELECT fname FROM users", conn)
        Try
            sqlCNString.Open()
            Dim sqlReader As SqlDataReader = sqlJobTitles.ExecuteReader(CommandBehavior.CloseConnection)
            While sqlReader.Read()
                dictJobTitle.Add(sqlReader("title_description").ToString, sqlReader("job_id"))
            End While
            sqlReader.Close()
            sqlCNString.Close()
            txtJobTitle.Items.Clear()
            txtJobTitle.Items.AddRange(dictJobTitle.Keys.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub txtJobTitle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtJobTitle.SelectedIndexChanged

    End Sub
    Public Function fnRegExReplace(strInput As String, strReplacement As String, strRegExPattern As String)
        Dim RegEx As New Regex(strRegExPattern)
        Dim Result As String = RegEx.Replace(strInput, strReplacement)
        Return Result
    End Function

    Private Sub tsbReports_Click(sender As Object, e As EventArgs) Handles tsbReports.Click
        Dim reportForm As frmReports
        reportForm = New frmReports()
        reportForm.Show()
        Me.Hide()
    End Sub

    Private Sub tsbContacts_Click(sender As Object, e As EventArgs) Handles tsbContacts.Click
        Dim contactForm As frmContact
        contactForm = New frmContact()
        contactForm.Show()
        Me.Hide()
    End Sub

    Private Sub tsbBilling_Click(sender As Object, e As EventArgs) Handles tsbBilling.Click
        Dim billingForm As frmBilling
        billingForm = New frmBilling
        billingForm.Show()
        Me.Hide()
    End Sub
    Private Sub CenterForm()
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
    End Sub

End Class
