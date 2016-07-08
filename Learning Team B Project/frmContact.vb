Public Class frmContact


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

    Private Sub tsbReports_Click(sender As Object, e As EventArgs) Handles tsbReports.Click
        Dim reportForm As frmReports
        reportForm = New frmReports
        reportForm.Show()
        Me.Hide()
    End Sub
    Private Sub CenterForm()
        Dim X As Integer = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
        Dim Y As Integer = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New System.Drawing.Point(X, Y)
    End Sub

    Private Sub frmContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Client_TableTableAdapter.Fill(Me.LTB_CRM_DBDataSet.Client_Table)
            'TODO: This line of code loads data into the 'LTB_CRM_EmployeeList.Employee_Table' table. You can move, or remove it, as needed.
            Me.Employee_TableTableAdapter.Fill(Me.LTB_CRM_EmployeeList.Employee_Table)
            CenterForm()
        Catch ex As Exception

        End Try 'TODO: This line of code loads data into the 'LTB_CRM_DBDataSet.Client_Table' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Employee_TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Employee_TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LTB_CRM_EmployeeList)

    End Sub
End Class
