Imports MySql.Data.MySqlClient
Public Class frmCreateV
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Customer_ID, Vehicle_ID As String
    Dim Con As New MySqlConnection
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        If txtMake.Text <> "" Or txtModel.Text <> "" Or txtRegistration_Number.Text <> "" Then
            'This tests to see if any of the feilds have been completed. If they have been edited, then this message is displayed.
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want exit this menu without saving?", "Exit menu?", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (Response = DialogResult.Yes) Then
                Me.Close()
                'if the user presses yes then the form is closed
            End If
        Else
            Me.Close()
            'if all the feilds are empty then the form will close without the message being displayed.
        End If
    End Sub

    Private Sub frmCreateV_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
    End Sub

    Public Sub SQLCommand(ByRef SQLStatement As String)
        Dim Cmd As MySqlCommand = New MySqlCommand

        With Cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = Con
            .ExecuteNonQuery()
        End With
        'This sub is used to execute all SQLStatements apart from SELECT statements
    End Sub

    Public Sub SQLSelect(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Vehicle_ID = SQLdr("Vehicle_ID")
        End While
        SQLdr.Close()
        'This sub is used to return a single value from a SELECT statement
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SQLStatement, SQLStatementSelect As String
        Customer_ID = frmCreateInv.lblCustomer_ID.Text

        If txtMake.Text = "" Or txtModel.Text = "" Or txtRegistration_Number.Text = "" Then
            'This test to see if any of the fields have been left blank. If any of them are blank then this message is displayed.
            MessageBox.Show("You must fill out all the Information before you can create a new vehicle.", _
                            "Please fill out all Info", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        Else
            SQLStatementSelect = "SELECT vehicle.Vehicle_ID from vehicle, cust_owns WHERE vehicle.Vehicle_ID = cust_owns.Vehicle_ID AND cust_owns.Customer_ID = '" & Customer_ID & "' AND Make = '" & txtMake.Text & "' AND Model = '" & txtModel.Text & "' AND Registration_Number = '" & txtRegistration_Number.Text & "'"
            SQLSelect(SQLStatementSelect)
            'This tests to see if the customer selected already has a vehicle with the same details already saved to the database.
            If Vehicle_ID = "" Then
                'If the vehicle does not already exist under the customer then this code is ran.
                SQLStatement =
                    "INSERT INTO vehicle(Make, Model, Registration_Number) VALUES('" & txtMake.Text & "', '" & txtModel.Text & "', '" & txtRegistration_Number.Text & "')"
                SQLCommand(SQLStatement)
                'This creates the new record in the vehicle table
                SQLStatementSelect = "SELECT Vehicle_ID FROM Vehicle WHERE Make = '" & txtMake.Text & "' AND Model = '" & txtModel.Text & "' AND Registration_Number = '" & txtRegistration_Number.Text & "'"
                SQLSelect(SQLStatementSelect)
                'This returns the new vehicle_ID that was jsut created.
                SQLStatement = "INSERT INTO cust_owns(Customer_ID, Vehicle_ID) VALUES ('" & Customer_ID & "', '" & Vehicle_ID & "')"
                SQLCommand(SQLStatement)
                'This creates the link between the customer and the vehicle
                MessageBox.Show("The new vehicle has been created and linked to the customer " & lblOwnerName.Text & ".", _
                                            "Vehicle created.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                'This displays a message box telling the user that the vehicle has been created.
                With frmCreateInv
                    .lblMake.Text = txtMake.Text
                    .lblModel.Text = txtModel.Text
                    .lblRegistration_Number.Text = txtRegistration_Number.Text
                    .lblVehicle_ID.Text = Vehicle_ID
                End With
                'This exports the vehicle details to the create invoice form
                Me.Close()
            Else
                MessageBox.Show("This Vehicle is already saved under this customer. Please select the Vehicle from the 'Select Vehicle' menu.", _
            "Customer already owns this Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                'If the customer already has a vehicle linked to them with the same details then this message is displayed and the record is not created.
                Exit Sub
            End If
        End If


    End Sub
End Class