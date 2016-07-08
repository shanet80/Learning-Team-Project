Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmBilling
    'full path to mdf
    Dim path As String = Environment.CurrentDirectory
    Dim strSQLdbMDF As String = path + "\LTB_CRM_DB.mdf"
    'setup data connection
    Dim sqlCNString As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""" + strSQLdbMDF + """;Integrated Security=True;Connect Timeout=30")
    'keep track of row selected
    Dim intCurRow As Integer = -1
    'keep track of the current selected employee, matter, etc.
    Dim intSelectedEmployeeID As Integer = Nothing
    Dim intSelectedClientID As Integer = Nothing
    Dim intSelectedMatter As Integer = Nothing
    'dictionary of employees and id's, etc.
    Dim dictEmployees As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim dictClients As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    Dim dictMatters As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)


    Private Sub frmBilling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterForm()
        FillEmployeeFromDB()
    End Sub

    Public Sub FillEmployeeFromDB()
        'connect to the employee_table and pull a list to populate the dropdown
        Try
            dictEmployees.Clear()
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            sqlCNString.Open()
            Dim sqlcmd1 As New SqlCommand("SELECT first_name + ' ' + last_name as Employee, Employee_Id AS 'EmployeeID' FROM Employee_Table", sqlCNString)
            Dim sqlReader As SqlDataReader = sqlcmd1.ExecuteReader(CommandBehavior.CloseConnection)
            While sqlReader.Read()
                dictEmployees.Add(sqlReader("Employee").ToString, sqlReader("EmployeeID"))
            End While
            sqlReader.Close()
            sqlCNString.Close()
            cmbEmpSelect.Items.Clear()
            cmbEmpSelect.Items.AddRange(dictEmployees.Keys.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
        End Try
    End Sub

    Public Sub FillClientFromDB()
        'connect to the client_table and pull a list to populate the dropdown
        Try
            dictClients.Clear()
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            sqlCNString.Open()
            Dim sqlcmd1 As New SqlCommand("Select first_name + ' ' + last_name AS Client, client_id from Client_Table", sqlCNString)
            Dim sqlReader As SqlDataReader = sqlcmd1.ExecuteReader(CommandBehavior.CloseConnection)
            While sqlReader.Read()
                dictClients.Add(sqlReader("Client").ToString, sqlReader("client_id"))
            End While
            sqlReader.Close()
            sqlCNString.Close()
            cmbClientSelect.Items.Clear()
            cmbClientSelect.Items.AddRange(dictClients.Keys.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
        End Try
    End Sub


    Public Sub FillMatterFromDB()
        'connect to the matters table and pull a list to populate the dropdown
        Try
            dictMatters.Clear()
            cmbMatterSelect.Text = Nothing
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            sqlCNString.Open()
            Dim sqlcmd1 As New SqlCommand("SELECT Matter_title, matter_id AS 'MatterID' FROM matters_table where (Matter_Closed_Date > GETDATE() or Matter_Closed_Date is null) and client_id=" + intSelectedClientID.ToString, sqlCNString)
            Dim sqlReader As SqlDataReader = sqlcmd1.ExecuteReader(CommandBehavior.CloseConnection)
            While sqlReader.Read()
                dictMatters.Add(sqlReader("matter_title").ToString, sqlReader("MatterID"))
            End While
            sqlReader.Close()
            sqlCNString.Close()
            cmbMatterSelect.Items.Clear()
            cmbMatterSelect.Items.AddRange(dictMatters.Keys.ToArray)
        Catch ex As System.Exception
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
        End Try
    End Sub

    Private Sub CenterForm()
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
    End Sub


    Private Sub tsbEmployees_Click(sender As Object, e As EventArgs) Handles tsbEmployees.Click
        Dim employeeForm As frmEmployees
        employeeForm = New frmEmployees
        employeeForm.Show()
        Me.Hide()
    End Sub


    Private Sub tsbReports_Click(sender As Object, e As EventArgs) Handles tsbReports.Click
        Dim reportForm As frmReports
        reportForm = New frmReports
        reportForm.Show()
        Me.Hide()
    End Sub

    Private Sub tsbContact_Click(sender As Object, e As EventArgs) Handles tsbContact.Click
        Dim contactForm As frmContact
        contactForm = New frmContact
        contactForm.Show()
        Me.Hide()
    End Sub

    Private Sub cmbEmpSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpSelect.SelectedIndexChanged
        'get employee id so we can use it to insert the billing record
        If dictEmployees.ContainsKey(cmbEmpSelect.Text.ToString) Then
            intSelectedEmployeeID = dictEmployees.Item(cmbEmpSelect.Text.ToString)
            cmbClientSelect.Enabled = True
            FillClientFromDB()
        End If
    End Sub

    Private Sub cmbClientSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientSelect.SelectedIndexChanged
        'get client id
        If dictClients.ContainsKey(cmbClientSelect.Text.ToString) Then
            intSelectedClientID = dictClients.Item(cmbClientSelect.Text.ToString)
            cmbMatterSelect.Enabled = True
            FillMatterFromDB()
        End If
    End Sub
    Private Sub cmbMatterSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMatterSelect.SelectedIndexChanged
        If dictMatters.ContainsKey(cmbMatterSelect.Text.ToString) Then
            intSelectedMatter = dictMatters.Item(cmbMatterSelect.Text.ToString)
        End If
        If cmbMatterSelect.Text <> String.Empty Then
            txtBilledAmount.Enabled = True
            txtBilledHours.Enabled = True
            txtBillingDate.Enabled = True
            cmbBillingStatus.Enabled = True
        Else
            txtBilledAmount.Enabled = False
            txtBilledHours.Enabled = False
            txtBillingDate.Enabled = False
            cmbBillingStatus.Enabled = False
            btnInsert.Enabled = False
        End If
    End Sub


    Private Sub txtBillingDate_ValueChanged(sender As Object, e As EventArgs) Handles txtBillingDate.ValueChanged
        If (txtBillingDate.Text <> String.Empty) And (txtBilledAmount.Text <> String.Empty) And (txtBilledHours.Text <> String.Empty) And (cmbBillingStatus.Text <> String.Empty) Then
            btnInsert.Enabled = True
        End If
    End Sub

    Private Sub txtBilledAmount_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBilledAmount.MaskInputRejected
        If (txtBillingDate.Text <> String.Empty) And (txtBilledAmount.Text <> String.Empty) And (txtBilledHours.Text <> String.Empty) And (cmbBillingStatus.Text <> String.Empty) Then
            btnInsert.Enabled = True
        End If
    End Sub

    Private Sub txtBilledHours_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles txtBilledHours.MaskInputRejected
        If (txtBillingDate.Text <> String.Empty) And (txtBilledAmount.Text <> String.Empty) And (txtBilledHours.Text <> String.Empty) And (cmbBillingStatus.Text <> String.Empty) Then
            btnInsert.Enabled = True
        End If
    End Sub

    Private Sub cmbBillingStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBillingStatus.SelectedIndexChanged
        If (txtBillingDate.Text <> String.Empty) And (txtBilledAmount.Text <> String.Empty) And (txtBilledHours.Text <> String.Empty) And (cmbBillingStatus.Text <> String.Empty) Then
            btnInsert.Enabled = True
        End If
    End Sub

    Private Sub resetForm()
        txtBilledAmount.Text = String.Empty
        txtBilledHours.Text = String.Empty
        txtBillingDate.Text = String.Empty
        cmbBillingStatus.Text = String.Empty
        cmbMatterSelect.Text = String.Empty
        cmbClientSelect.Text = String.Empty
        cmbEmpSelect.Text = String.Empty
        txtBilledAmount.Enabled = False
        txtBilledHours.Enabled = False
        txtBillingDate.Enabled = False
        cmbBillingStatus.Enabled = False
        btnInsert.Enabled = False
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetForm()
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            'Saves a new record
            Dim matterid As String = intSelectedMatter.ToString
            Dim billingdate As String = txtBillingDate.Value.ToString
            Dim billingamount As String = fnRegExReplace(txtBilledAmount.Text.ToString, "", "(\$)|(\,)")
            Dim billedhours As String = txtBilledHours.Text.ToString
            Dim billingstatus As String = cmbBillingStatus.Text.ToString
            Dim cmd As New System.Data.SqlClient.SqlCommand
            cmd.CommandType = System.Data.CommandType.Text
            cmd.CommandText = "INSERT matters_billing_table (matter_id, billing_date, billing_amount, billing_hours, billing_status, employee_id) VALUES (" + matterid + ",'" + billingdate + "'," + billingamount + "," + billedhours + ",'" + billingstatus + "'," + intSelectedEmployeeID.ToString + ")"
            cmd.Connection = sqlCNString
            sqlCNString.Open()
            cmd.ExecuteNonQuery()
            sqlCNString.Close()
            Dim strmsg As String = "Date " + billingdate + vbCrLf + "Billed " + txtBilledAmount.Text.ToString + vbCrLf + "Hours " + billedhours + vbCrLf + "Status " + billingstatus
            MessageBox.Show(strmsg, "Record Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            If sqlCNString.State <> ConnectionState.Closed Then
                sqlCNString.Close()
            End If
            MessageBox.Show(ex.Message, "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Function fnRegExReplace(strInput As String, strReplacement As String, strRegExPattern As String)
        Dim RegEx As New Regex(strRegExPattern)
        Dim Result As String = RegEx.Replace(strInput, strReplacement)
        Return Result
    End Function

End Class