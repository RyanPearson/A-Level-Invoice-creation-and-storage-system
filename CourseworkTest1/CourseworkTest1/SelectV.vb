Imports MySql.Data.MySqlClient
Public Class frmSelectV
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim Customer_ID, Temp_Vehicle_ID As String
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'This closes the select vehicle form and returns the user to the create invoice form.
    End Sub

    Private Sub frmSelectV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim SQLCommand As String
        Dim Adapter As MySqlDataAdapter
        Dim VehicleTable As DataTable

        Con.ConnectionString = Connectionstring

        Try
            Con.Open()
        Catch ex As Exception
            MessageBox.Show("Unable to connect to the Database. Please ensure that Wamp Server has been started.", _
                "Unable to connect to Database", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            frmMenu.Close()
            Me.Close()
        End Try
        'This tries to open the connection to the server using a try catch method.
        'on exception (when it cannot connect) the form will display a message box and close the program.

        Customer_ID = frmCreateInv.lblCustomer_ID.Text
        'This sets the customer_ID to the customer_ID of the customer previously selected in the create invoice form
        SQLCommand = "SELECT vehicle.Vehicle_ID, Make, Model, Registration_Number from vehicle, cust_owns WHERE vehicle.Vehicle_ID = cust_owns.Vehicle_ID AND cust_owns.Customer_ID = '" & Customer_ID & "'"
        SQLSelect(SQLCommand)
        'This tests to see if the customer selected owns any vehicles.
        If Temp_Vehicle_ID = "" Then
            MessageBox.Show("This Customer does not own any Vehicles. Please create a new Vehicle record for this Customer in the 'Create New Vehicle' menu.", _
                            "Please create a new Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'If hte selected customer does not have and recorded vehicles then this message is displayed and the form is closed.
            Me.Close()
        Else
            'If the customer does have recorded vehicles then all of their vehicles will be displayed in a datagridview
            Try
                Adapter = New MySqlDataAdapter(SQLCommand, Con)
                VehicleTable = New DataTable
                Adapter.Fill(VehicleTable)
                dgvSelectV.DataSource = VehicleTable
                dgvSelectV.Columns(1).Visible = False
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Public Sub SQLSelect(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Temp_Vehicle_ID = SQLdr("Vehicle_ID")
        End While
        SQLdr.Close()
        'This cub is used to test to see if the user has any recorded vehicles.
    End Sub

    Private Sub dgvSelectV_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSelectV.CellContentClick
        If e.ColumnIndex <> 0 Or e.RowIndex = dgvSelectV.RowCount - 1 Then
            Exit Sub
            'This ensures that the code below is only ran if the buton column is pressed.
        End If

        With frmCreateInv
            .lblVehicle_ID.Text = dgvSelectV.Rows(e.RowIndex).Cells(1).Value
            .lblMake.Text = dgvSelectV.Rows(e.RowIndex).Cells(2).Value
            .lblModel.Text = dgvSelectV.Rows(e.RowIndex).Cells(3).Value
            .lblRegistration_Number.Text = dgvSelectV.Rows(e.RowIndex).Cells(4).Value
        End With
        'This exports all the details of the selected vehicle to the creat invoice form.
        Me.Close()
        'The user is then sent to the create invoice form and this form is closed.
    End Sub
End Class