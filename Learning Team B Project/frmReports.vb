Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class frmReports
    'full path to mdf
    Dim path As String = Environment.CurrentDirectory
    Dim strSQLdbMDF As String = path + "\LTB_CRM_DB.mdf"
    'setup data connection
    Dim sqlCNString As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + strSQLdbMDF + """;Integrated Security=True;Connect Timeout=30")
    Dim sql As String

    Private Sub tsbContacts_Click(sender As Object, e As EventArgs) Handles tsbContacts.Click
        Dim contactForm As frmContact
        contactForm = New frmContact
        contactForm.Show()
        Me.Hide()
    End Sub

    Private Sub tsbEmployees_Click(sender As Object, e As EventArgs) Handles tsbEmployees.Click
        Dim employeeForm As frmEmployees
        employeeForm = New frmEmployees
        employeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub tsbBilling_Click(sender As Object, e As EventArgs) Handles tsbBilling.Click
        Dim billingForm As frmBilling
        billingForm = New frmBilling
        billingForm.Show()
        Me.Hide()
    End Sub

    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
    End Sub


    Private Sub lstBoxReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxReports.SelectedIndexChanged
        'Open case list
        If lstBoxReports.SelectedIndex = 0 Then
            Sql = "select m.matter_id as 'matter number', c.First_Name + ' ' + c.Last_Name as 'client name', m.Matter_Open_Date as 'matter open date' from Matters_Table m, client_table c where m.Client_ID = c.Client_ID and (m.Matter_Closed_Date > GETDATE() or m.Matter_Closed_Date is null)"
            dgvLoad("Opencases", sql)
        End If
        'Closed case list
        If lstBoxReports.SelectedIndex = 1 Then
            sql = "select m.matter_id as 'matter number', c.First_Name + ' ' + c.Last_Name as 'client name', m.Matter_Open_Date as 'matter close date' from Matters_Table m, client_table c where m.Client_ID = c.Client_ID and (m.Matter_Closed_Date < GETDATE())"
            dgvLoad("Closedcases", sql)
        End If
        'Highest billing employee
        If lstBoxReports.SelectedIndex = 2 Then
            sql = "select e.first_name + ' ' + e.last_name as 'Employee name','$' + convert(varchar(50),convert(money,sum(mbt.billing_amount))) as 'Total Billed' from Matters_Table m, matters_billing_table mbt, employee_table e where m.matter_id=mbt.matter_id and mbt.employee_id=e.employee_id group by e.first_name + ' ' + e.last_name order by convert(money,sum(mbt.billing_amount)) desc"
            dgvLoad("HighestBilling", sql)
        End If
        'Lowest billing employee
        If lstBoxReports.SelectedIndex = 3 Then
            sql = "select e.first_name + ' ' + e.last_name as 'Employee name','$' + convert(varchar(50),convert(money,sum(mbt.billing_amount))) as 'Total Billed' from Matters_Table m join matters_billing_table mbt on m.matter_id=mbt.matter_id right outer join employee_table e on mbt.employee_id=e.employee_id group by e.first_name + ' ' + e.last_name order by convert(money,sum(mbt.billing_amount)) asc, e.first_name + ' ' + e.last_name"
            dgvLoad("LowestBilling", sql)
        End If
        'Top customers (case volume)
        If lstBoxReports.SelectedIndex = 4 Then
            sql = "select sum(mt.matter_id) as 'number of cases', co.company_name, ct.first_name + ' ' + ct.last_name from Client_Table ct inner join Company_Table co on ct.Client_ID=co.Client_ID left outer join matters_table mt on mt.client_id=ct.client_id group by co.company_name, ct.first_name + ' ' + ct.last_name having count(mt.matter_id)>0"
            dgvLoad("TopCustomers", sql)
        End If
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
            dgvReports.DataSource = sqlDataTable
            'dgvReports.Columns("employee id").Visible = False
            dgvReports.RowsDefaultCellStyle.BackColor = Color.LightSkyBlue
            dgvReports.AlternatingRowsDefaultCellStyle.BackColor = Color.LightYellow
        Catch ex As Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvReports_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReports.CellContentClick

    End Sub
    Private Sub CenterForm()
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
    End Sub
End Class
