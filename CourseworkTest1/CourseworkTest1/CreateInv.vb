Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop
Public Class frmCreateInv
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim Parts_Total, Pre_VAT_Total, VAT_Total, Invoice_Total, Temp_Unit_Price, Temp_Total_Unit_Price, VAT_Percentage As Decimal
    Dim SQLStatement, SQLStatementSelect, Invoice_ID, Temp_Additional_Info As String
    Dim Temp_Order_Sequence_Number, Temp_Part_ID, Temp_Quantity As Integer
    Private Sub frmCreateInv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnMainMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMainMenu.Click
        frmMenu.Show()
        Me.Close()
        'On press, this button closes the current screen and displays the main menu
    End Sub

    Private Sub btnSearchC_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchC.Click
        If lblInvoice_ID.Text = "<Invoice_ID>" And lblVehicle_ID.Text = "<Vehicle_ID>" Then
            frmSearchFC.Show()
            Exit Sub
        ElseIf lblInvoice_ID.Text = "<Invoice_ID>" And lblVehicle_ID.Text <> "<Vehicle_ID>" Then
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want to change the customer?", _
"Change Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Response = DialogResult.No Then
                Exit Sub
            End If
        ElseIf lblInvoice_ID.Text <> "<Invoice_ID>" Or lblSaved.Text = "1" Then
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want to change the customer?", _
"Change Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Response = DialogResult.No Then
                Exit Sub
            End If
        End If
        lblCustomer_ID.Text = "<Customer_ID>"
        lblVehicle_ID.Text = "<Vehicle_ID>"
        lblInvoice_ID.Text = "<Invoice_ID>"
        lblSaved.Text = "0"
        lblTitle.Text = "<Title>"
        lblForename.Text = "<Forename>"
        lblSurname.Text = "<Surname>"
        lblALine1.Text = "<ALine1>"
        lblALine2.Text = "<ALine2>"
        lblALine3.Text = "<ALine3>"
        lblPostcode.Text = "<Postcode>"
        lblContact_Mobile.Text = "<Mobile No>"
        lblContact_Home.Text = "<Home No>"
        lblContact_EMail.Text = "<E-Mail>"
        lblMake.Text = "<Make>"
        lblModel.Text = "<Model>"
        lblRegistration_Number.Text = "<Reg No>"
        txtMileage.Text = ""
        frmSearchFC.Show()
    End Sub

    Private Sub btnSelectV_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectV.Click
        If lblCustomer_ID.Text = "<Customer_ID>" Or lblCustomer_ID.Text = "" Then
            MessageBox.Show("A Customer must be selected before you can select a Vehicle.", "Please select a Customer", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        Else
            frmSelectV.Show()
            frmSelectV.lblOwner.Text = ("" & lblTitle.Text + " " + lblForename.Text + " " + lblSurname.Text & "")
        End If
        'This checks that a customer has been selected before the user opens the select vehicle form.
        'When the select vehicle form opens it will display the customers name.
    End Sub

    Private Sub btnCreateC_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateC.Click
        If lblInvoice_ID.Text = "<Invoice_ID>" And lblVehicle_ID.Text = "<Vehicle_ID>" Then
            frmCreateC.Show()
            Exit Sub
        ElseIf lblInvoice_ID.Text = "<Invoice_ID>" And lblVehicle_ID.Text <> "<Vehicle_ID>" Then
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want to change the customer?", _
"Change Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Response = DialogResult.No Then
                Exit Sub
            End If
        ElseIf lblInvoice_ID.Text <> "<Invoice_ID>" Or lblSaved.Text = "1" Then
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want to change the customer?", _
"Change Customer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If Response = DialogResult.No Then
                Exit Sub
            End If
        End If
        lblCustomer_ID.Text = "<Customer_ID>"
        lblVehicle_ID.Text = "<Vehicle_ID>"
        lblInvoice_ID.Text = "<Invoice_ID>"
        lblSaved.Text = "0"
        lblTitle.Text = "<Title>"
        lblForename.Text = "<Forename>"
        lblSurname.Text = "<Surname>"
        lblALine1.Text = "<ALine1>"
        lblALine2.Text = "<ALine2>"
        lblALine3.Text = "<ALine3>"
        lblPostcode.Text = "<Postcode>"
        lblContact_Mobile.Text = "<Mobile No>"
        lblContact_Home.Text = "<Home No>"
        lblContact_EMail.Text = "<E-Mail>"
        lblMake.Text = "<Make>"
        lblModel.Text = "<Model>"
        lblRegistration_Number.Text = "<Reg No>"
        txtMileage.Text = ""
        frmCreateC.Show()
        'This opens the Create Customer form.
    End Sub

    Private Sub btnCreateV_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateV.Click
        If lblCustomer_ID.Text = "<Customer_ID>" Or lblCustomer_ID.Text = "" Then
            MessageBox.Show("A Customer must be selected before you can create a new Vehicle.", "Please select a Customer", _
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        Else
            frmCreateV.Show()
                frmCreateV.lblOwnerName.Text = ("" & lblTitle.Text + " " + lblForename.Text + " " + lblSurname.Text & "")
        End If
        'This checks to see if the user has specified a customer before the create vehicle form is opened.
        'When the create vehicle form is opened the customer name is displayed at the top of the screen.
    End Sub

    Private Sub btnParts_Click(sender As System.Object, e As System.EventArgs) Handles btnParts.Click
        frmAddParts.Show()
        'This button will display the Add Parts form.
    End Sub

    Private Sub dgvPart_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPart.CellContentClick
        If e.ColumnIndex = 0 Or e.RowIndex <> dgvPart.RowCount - 1 Then
            'This checks to see if the cell clicked was in the first column and not the last row.
            'This is because, pressing the button on the last row would create the situation where it is trying to delete a row which does not exist.
            Dim response As DialogResult = MessageBox.Show("Are you sure you want to delete this row?", "Delete row?", _
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'displays a message box asking the user if they want to delete the row they have clicked on, just incase they acidentally pressed the button.
            If (response = DialogResult.Yes) Then
                dgvPart.Rows.Remove(dgvPart.Rows(e.RowIndex))
                'When the user presses 'Yes' the row is deleted.
                lblTotalsGen.Text = "0"
                'This sets the totals generated state to 0, forcing the user to re calculate the totals before they save
            Else
                Exit Sub
                'when the user presses 'No', the sub will end.
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        Dim Count As Integer = 0
        If dgvPart.RowCount = 0 Then
            MessageBox.Show("There are no parts in the Parts Used table. Please add the parts using the 'Add Parts' screen.", "No parts in the parts used table", _
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'This checks to see if there are any parts in the Parts used table. If there is not then this message will be displayed.
        End If
        If txtDescription.Text <> "This will be filled out based upon what parts have been selected." Then
            'Checks to see if the job desscription has been generated before and just needs updating as the user may have added more parts.
            Dim response As DialogResult = MessageBox.Show("Are you sure you want to generate the job description again?", "Generate Job Description?", _
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            If (response = DialogResult.No) Then
                Exit Sub
            End If
            'This displays a message box asking the user if they want to generate the job description again.
        End If
        'When an invoice is returned via the Search forms in the main menu, dgvParts2 is used instead of dgvParts.
        'This is necessary because of some issues when filling a datagridview with a specified number of columnns.
        'This checks which datagridview is being used.
        Do Until Count = dgvPart.RowCount
            If Count = 0 Then
                txtDescription.Text = "" & dgvPart.Rows(Count).Cells(6).Value & ""
                'When the row being read is the first row then the text in txtDescription is equal to the value stored in row 0 column 6.
            Else
                txtDescription.Text = "" & txtDescription.Text & "" + " " + "" & dgvPart.Rows(Count).Cells(6).Value & ""
                'When the row being read is anything but the first row the text is the previous text plus the value in that row column 6.
            End If
            Count = Count + 1
            'Increments count by 1 to read the next row.
        Loop
        'This loops until count is equal to the number of rows in dgvPart so that every row is read.

    End Sub

    Private Sub btnDate_Click(sender As System.Object, e As System.EventArgs) Handles btnDate.Click
        If dtpDate.Value > Now Then
            MessageBox.Show("You cannot create an invoice for a future job. Please select the correct date.", _
    "Incorrect Date", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'This checks to see if the user is trying to specify a date in the future, as you cannot create a invoice for a future job.
        Else
            If lblSaved.Text = "1" Or lblDate.Text <> "<Date>" Then
                Dim Response As DialogResult = MessageBox.Show("Are you sure you want to change the date? Doing this will create a new invoice.", _
"Change Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                If Response = DialogResult.No Then
                    Exit Sub
                End If
                lblSaved.Text = "0"
                lblInvoice_ID.Text = "<Invoice_ID>"
            End If
            lblDate.Text = FormatDateTime(dtpDate.Value, DateFormat.ShortDate)
            'If the date chosen is not in the future then lblDate displays the date the user has chosen, so that the user can see easily 
            'if they have made a mistake
        End If
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim Count As Integer = 0
        If lblCustomer_ID.Text = "<Customer_ID>" Then
            MessageBox.Show("You must select a Customer before you can save the Invoice.", _
"Customer Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a customer has been selected by refering to lblCustomer_ID.
        End If
        If lblVehicle_ID.Text = "<Vehicle_ID>" Then
            MessageBox.Show("You must select a Vehicle before you can save the Invoice.", _
"Vehicle Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a vehicle has been selected by refering to lblVehicle_ID.
        End If
        If txtMileage.Text <> "" Then
            'As Mileage is not a neccesity, this is only ran if the contents of the textbox have been changed.
            Try
                Dim test As Integer = CInt(txtMileage.Text) + 1
                'Tests to see if the value entered is numerical
            Catch ex As Exception
                MessageBox.Show("You must use a numerical value for the mileage before you can save. This fields does not need to be filled in.", _
"Vehicle mileage is not a number.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
                'If it is not then this message is displayed and the user cannot save the invoice.
            End Try
        End If
        If lblDate.Text = "<Date>" Then
            MessageBox.Show("You must select a Date before you can save the Invoice.", _
"Date Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a Date has been selected by refering to lblDate.
        End If
        If txtDescription.Text = "" Or txtDescription.Text = "This will be filled out based upon what parts have been selected." Then
            MessageBox.Show("You must change the job description before you can save the Invoice. You can do this by pressing the 'Generate Job Description' button or by changing it manually.", _
"Date Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        If lblTotalsGen.Text = "0" Then
            MessageBox.Show("You cannot save the invoice until the Totals have been generated. Please press the 'Generate Totals' button before saving the Invoice.", _
"Totals Have Not Been Generated", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if the totals have been generated.
            'I would have used a boolean but they cannot be changed from another form.
        End If
        SQLStatementSelect = "SELECT Invoice_ID FROM Invoice Where Customer_ID = '" & lblCustomer_ID.Text & "' AND Vehicle_ID = '" & lblVehicle_ID.Text & "' AND Date = '" & lblDate.Text & "'"
        SQLSelect(SQLStatementSelect)
        'This finds out if the Invoice has been created before

        If lblSaved.Text = "1" And lblInvoice_ID.Text <> "<Invoice_ID>" Then
            'If the invoice was saved already, lblsaved would equal 1 and lblInvoice_ID would have a value
            Dim Response As DialogResult = MessageBox.Show("Are you sure you would like to overwrite the previous invoice?", _
"Overwrite Invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'This checks to see if the user would like to overwrite the invoice they have previously saved.
            If Response = DialogResult.No Then
                Exit Sub
            End If

            SQLStatement = "UPDATE invoice SET Customer_ID = '" & lblCustomer_ID.Text & "', Vehicle_ID = '" & lblVehicle_ID.Text & "', Mileage = '" & txtMileage.Text & "', Date = '" & lblDate.Text & "', Description = '" & txtDescription.Text & "', Parts_Total = '" & txtParts_Total.Text & "', Labour_Total = '" & txtLabour_Total.Text & "', Pre_VAT_Total = '" & txtPreVAT_Total.Text & "', VAT_Total = '" & txtVAT_Total.Text & "', Invoice_Total = '" & txtInvoice_Total.Text & "' WHERE Invoice_ID = '" & Invoice_ID & "'"
            SQLCommand(SQLStatement)
            'This updates the changes to the invoice details to the Invoice table in the Database
            SQLStatement = "DELETE FROM invoice_component WHERE Invoice_ID = '" & Invoice_ID & "'"
            SQLCommand(SQLStatement)
            'This deletes all the Parts used assosiated with this invoice and then the loop below adds their replacements to the
            'Invoice_Component table
            Do Until Count = dgvPart.RowCount
                'This checks to see which datagridview to use
                Temp_Order_Sequence_Number = Count + 1
                Temp_Part_ID = dgvPart.Rows(Count).Cells(1).Value
                Temp_Quantity = dgvPart.Rows(Count).Cells(3).Value
                Temp_Unit_Price = dgvPart.Rows(Count).Cells(4).Value
                Temp_Total_Unit_Price = dgvPart.Rows(Count).Cells(5).Value
                Temp_Additional_Info = dgvPart.Rows(Count).Cells(7).Value

                SQLStatement = "INSERT INTO Invoice_Component(Order_Sequence_No, Invoice_ID, Part_ID, Quantity, Unit_Price, Total_Price, Additional_Info) VALUES('" & Temp_Order_Sequence_Number & "', '" & Invoice_ID & "', '" & Temp_Part_ID & "', '" & Temp_Quantity & "', '" & Temp_Unit_Price & "', '" & Temp_Total_Unit_Price & "', '" & Temp_Additional_Info & "')"
                SQLCommand(SQLStatement)
                'This inserts the record to the Invoice_component table  for that row
                Count = Count + 1
            Loop
            Exit Sub
        End If

        If lblSaved.Text = "0" And lblInvoice_ID.Text <> "<Invoice_ID>" Then
            MessageBox.Show("An Invoice already exists with this customer, vehicle and date. Please use the 'Search' menu from the Main Menu.", _
"Invoice already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'If the user is trying to create an invoice for a customer and vehicle on a date already used a message box will 
            'be displayed saying that the invoice already exists and the user should use the search option on the main menu
        End If

        'If the user has completed all the fields and the invoice is being saved for the first time on a date not already used with this customer
        'and vehicle then this section will be ran.
        SQLStatement = "INSERT INTO Invoice(Customer_ID, Vehicle_ID, Date, Mileage, Description, Labour_Total, Parts_Total, Pre_VAT_Total, VAT_Total, Invoice_Total, VAT_Percentage) VALUES('" & lblCustomer_ID.Text & "', '" & lblVehicle_ID.Text & "', '" & lblDate.Text & "', '" & txtMileage.Text & "', '" & txtDescription.Text & "', '" & txtLabour_Total.Text & "', '" & txtParts_Total.Text & "', '" & txtPreVAT_Total.Text & "', '" & txtVAT_Total.Text & "', '" & txtInvoice_Total.Text & "', '" & My.Settings.VAT & "')"
        SQLCommand(SQLStatement)
        'This inserts a new record to the invoice table with all the information stored in the create invoice form.
        SQLStatementSelect = "SELECT Invoice_ID FROM Invoice Where Customer_ID = '" & lblCustomer_ID.Text & "' AND Vehicle_ID = '" & lblVehicle_ID.Text & "' AND Date = '" & lblDate.Text & "' AND Mileage = '" & txtMileage.Text & "' AND Description = '" & txtDescription.Text & "' AND Labour_Total = '" & txtLabour_Total.Text & "' AND Parts_Total = '" & txtParts_Total.Text & "' AND Pre_VAT_Total = '" & txtPreVAT_Total.Text & "' AND VAT_Total = '" & txtVAT_Total.Text & "' AND Invoice_Total = '" & txtInvoice_Total.Text & "'"
        SQLSelect(SQLStatementSelect)
        'This returns the Invoice_ID for the new record
        Do Until Count = dgvPart.RowCount
            'This loops and creates a record in the Invoice_Component table in the database 
            Temp_Order_Sequence_Number = Count + 1
            Temp_Part_ID = dgvPart.Rows(Count).Cells(1).Value
            Temp_Quantity = dgvPart.Rows(Count).Cells(3).Value
            Temp_Unit_Price = dgvPart.Rows(Count).Cells(4).Value
            Temp_Total_Unit_Price = dgvPart.Rows(Count).Cells(5).Value
            Temp_Additional_Info = dgvPart.Rows(Count).Cells(7).Value
            SQLStatement = "INSERT INTO Invoice_Component(Order_Sequence_No, Invoice_ID, Part_ID, Quantity, Unit_Price, Total_Price, Additional_Info) VALUES('" & Temp_Order_Sequence_Number & "', '" & Invoice_ID & "', '" & Temp_Part_ID & "', '" & Temp_Quantity & "', '" & Temp_Unit_Price & "', '" & Temp_Total_Unit_Price & "', '" & Temp_Additional_Info & "')"
            SQLCommand(SQLStatement)
            Count = Count + 1
        Loop
        lblSaved.Text = "1"
        'This changes the saved state to 1, meaning that if the user tries to save again, the invoice is overwritten by the new one.
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
            Invoice_ID = SQLdr("Invoice_ID")
            lblInvoice_ID.Text = SQLdr("Invoice_ID")
        End While
        SQLdr.Close()
        'This sub is used to return a single value from a SELECT statement
    End Sub

    Public Sub frmCreateInv_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
        'When the form closes the main menu form in loaded
    End Sub

    Private Sub btnTotals_Click(sender As System.Object, e As System.EventArgs) Handles btnTotals.Click
        Dim Count As Integer = 0
        Dim test As Decimal
        If dgvPart.RowCount = 0 Then
            MessageBox.Show("There are no parts in the 'Parts Used' table. Please add the parts used in the 'Add Parts' menu", _
    "No Parts Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'This checks to see if there are any parts in the parts used 
        ElseIf txtLabour_Total.Text = "" Then
            MessageBox.Show("The 'Labour' field in the 'Totals' section has not been filled. Please enter the total cost of the labour for this job.", _
    "Labour Field Incomplete", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'This checks to see if the labour cost field has a value
        Else
            Try
                test = txtLabour_Total.Text + 1
            Catch ex As Exception
                MessageBox.Show("You can only enter a number into the 'Labour' field. Please replace the current contents with a number.", _
    "Labour Field Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
            End Try
            'This try, catch tests to see if the value in the Labour Cost field is a number value
            Parts_Total = 0
            'This resets the Parts_Total as 0 so that the values for the various totals do not keep stacking up
            Do Until Count = dgvPart.RowCount
                Parts_Total = Parts_Total + Val(dgvPart.Rows(Count).Cells(5).Value)
                Count = Count + 1
            Loop
            'This loops, adding together the cost of each part multiplied by the quantity
            txtParts_Total.Text = Format(Parts_Total, "0.00")
            txtPreVAT_Total.Text = Format(CDec(txtLabour_Total.Text) + CDec(Parts_Total), "0.00")
            If lblSaved.Text = "0" Then
                VAT_Percentage = My.Settings.VAT
                'If the invoice has not already been saved to the database then the VAT_Percentage is the current value of VAT stored in a text file
            ElseIf lblSaved.Text = "1" Then
                'If the invoice has already been saved, then the VAT_Percentage for this invoice is retrieved from the invoice table in the database
                Dim SQLCmd As New MySqlCommand
                Dim SQLdr As MySqlDataReader
                Dim SQLStatementSelect As String = "SELECT VAT_Percentage FROM invoice WHERE Invoice_ID = '" & lblInvoice_ID.Text & "'"
                SQLCmd.Connection = Con
                SQLCmd.CommandText = SQLStatementSelect
                SQLdr = SQLCmd.ExecuteReader

                While SQLdr.Read
                    VAT_Percentage = SQLdr("VAT_Percentage")
                End While
                SQLdr.Close()

            End If
            txtVAT_Total.Text = Format(CDec(txtPreVAT_Total.Text) * VAT_Percentage, "0.00")
            txtInvoice_Total.Text = Format(CDec(txtPreVAT_Total.Text) + CDec(txtVAT_Total.Text), "0.00")
            lblTotalsGen.Text = "1"
            'This sets the totalsgen state to 1
        End If
    End Sub

    Private Sub btnPrint_Click(sender As System.Object, e As System.EventArgs) Handles btnPrint.Click
        Dim Count As Integer = 0
        If lblCustomer_ID.Text = "<Customer_ID>" Then
            MessageBox.Show("You must select a Customer before you can save the Invoice.", _
"Customer Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a customer has been selected by refering to lblCustomer_ID.
        End If
        If lblVehicle_ID.Text = "<Vehicle_ID>" Then
            MessageBox.Show("You must select a Vehicle before you can save the Invoice.", _
"Vehicle Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a vehicle has been selected by refering to lblVehicle_ID.
        End If
        If txtMileage.Text <> "" Then
            'As Mileage is not a neccesity, this is only ran if the contents of the textbox have been changed.
            Try
                Dim test As Integer = CInt(txtMileage.Text) + 1
                'Tests to see if the value entered is numerical
            Catch ex As Exception
                MessageBox.Show("You must use a numerical value for the mileage before you can save. This fields does not need to be filled in.", _
"Vehicle mileage is not a number.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
                'If it is not then this message is displayed and the user cannot save the invoice.
            End Try
        End If
        If lblDate.Text = "<Date>" Then
            MessageBox.Show("You must select a Date before you can save the Invoice.", _
"Date Has Not Been Selected", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if a Date has been selected by refering to lblDate.
        End If
        If lblTotalsGen.Text = "0" Then
            MessageBox.Show("You cannot save the invoice until the Totals have been generated. Please press the 'Generate Totals' button before saving the Invoice.", _
"Totals Have Not Been Generated", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'Checks to see if the totals have been generated.
            'I would have used a boolean but they cannot be changed from another form.
        End If
        SQLStatementSelect = "SELECT Invoice_ID FROM Invoice Where Customer_ID = '" & lblCustomer_ID.Text & "' AND Vehicle_ID = '" & lblVehicle_ID.Text & "' AND Date = '" & lblDate.Text & "'"
        SQLSelect(SQLStatementSelect)
        'This finds out if the Invoice has been created before

        If lblSaved.Text = "1" And lblInvoice_ID.Text <> "<Invoice_ID>" Then
            'If the invoice was saved already, lblsaved would equal 1 and lblInvoice_ID would have a value
            Dim Response As DialogResult = MessageBox.Show("Are you sure you would like to overwrite the previous invoice?", _
"Overwrite Invoice?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'This checks to see if the user would like to overwrite the invoice they have previously saved.
            If Response = DialogResult.No Then
                Exit Sub
            End If

            SQLStatement = "UPDATE invoice SET Customer_ID = '" & lblCustomer_ID.Text & "', Vehicle_ID = '" & lblVehicle_ID.Text & "', Mileage = '" & txtMileage.Text & "', Date = '" & lblDate.Text & "', Description = '" & txtDescription.Text & "', Parts_Total = '" & txtParts_Total.Text & "', Labour_Total = '" & txtLabour_Total.Text & "', Pre_VAT_Total = '" & txtPreVAT_Total.Text & "', VAT_Total = '" & txtVAT_Total.Text & "', Invoice_Total = '" & txtInvoice_Total.Text & "' WHERE Invoice_ID = '" & Invoice_ID & "'"
            SQLCommand(SQLStatement)
            'This updates the changes to the invoice details to the Invoice table in the Database
            SQLStatement = "DELETE FROM invoice_component WHERE Invoice_ID = '" & Invoice_ID & "'"
            SQLCommand(SQLStatement)
            'This deletes all the Parts used assosiated with this invoice and then the loop below adds their replacements to the
            'Invoice_Component table
            Do Until Count = dgvPart.RowCount
                'This checks to see which datagridview to use
                Temp_Order_Sequence_Number = Count + 1
                Temp_Part_ID = dgvPart.Rows(Count).Cells(1).Value
                Temp_Quantity = dgvPart.Rows(Count).Cells(3).Value
                Temp_Unit_Price = dgvPart.Rows(Count).Cells(4).Value
                Temp_Total_Unit_Price = dgvPart.Rows(Count).Cells(5).Value
                Temp_Additional_Info = dgvPart.Rows(Count).Cells(7).Value

                SQLStatement = "INSERT INTO Invoice_Component(Order_Sequence_No, Invoice_ID, Part_ID, Quantity, Unit_Price, Total_Price, Additional_Info) VALUES('" & Temp_Order_Sequence_Number & "', '" & Invoice_ID & "', '" & Temp_Part_ID & "', '" & Temp_Quantity & "', '" & Temp_Unit_Price & "', '" & Temp_Total_Unit_Price & "', '" & Temp_Additional_Info & "')"
                SQLCommand(SQLStatement)
                'This inserts the record to the Invoice_component table  for that row
                Count = Count + 1
            Loop
            Print()
            'This calls the Print() sub which generates a word document and fills in all the information into a word file.
            Exit Sub
        End If

        If lblSaved.Text = "0" And lblInvoice_ID.Text <> "<Invoice_ID>" Then
            MessageBox.Show("An Invoice already exists with this customer, vehicle and date. Please use the 'Search' menu from the Main Menu.", _
"Invoice already exists.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'If the user is trying to create an invoice for a customer and vehicle on a date already used a message box will 
            'be displayed saying that the invoice already exists and the user should use the search option on the main menu
        End If

        'If the user has completed all the fields and the invoice is being saved for the first time on a date not already used with this customer
        'and vehicle then this section will be ran.
        SQLStatement = "INSERT INTO Invoice(Customer_ID, Vehicle_ID, Date, Mileage, Description, Labour_Total, Parts_Total, Pre_VAT_Total, VAT_Total, Invoice_Total, VAT_Percentage) VALUES('" & lblCustomer_ID.Text & "', '" & lblVehicle_ID.Text & "', '" & lblDate.Text & "', '" & txtMileage.Text & "', '" & txtDescription.Text & "', '" & txtLabour_Total.Text & "', '" & txtParts_Total.Text & "', '" & txtPreVAT_Total.Text & "', '" & txtVAT_Total.Text & "', '" & txtInvoice_Total.Text & "', '" & My.Settings.VAT & "')"
        SQLCommand(SQLStatement)
        'This inserts a new record to the invoice table with all the information stored in the create invoice form.
        SQLStatementSelect = "SELECT Invoice_ID FROM Invoice Where Customer_ID = '" & lblCustomer_ID.Text & "' AND Vehicle_ID = '" & lblVehicle_ID.Text & "' AND Date = '" & lblDate.Text & "' AND Mileage = '" & txtMileage.Text & "' AND Description = '" & txtDescription.Text & "' AND Labour_Total = '" & txtLabour_Total.Text & "' AND Parts_Total = '" & txtParts_Total.Text & "' AND Pre_VAT_Total = '" & txtPreVAT_Total.Text & "' AND VAT_Total = '" & txtVAT_Total.Text & "' AND Invoice_Total = '" & txtInvoice_Total.Text & "'"
        SQLSelect(SQLStatementSelect)
        'This returns the Invoice_ID for the new record
        Do Until Count = dgvPart.RowCount
            'This loops and creates a record in the Invoice_Component table in the database 
            Temp_Order_Sequence_Number = Count + 1
            Temp_Part_ID = dgvPart.Rows(Count).Cells(1).Value
            Temp_Quantity = dgvPart.Rows(Count).Cells(3).Value
            Temp_Unit_Price = dgvPart.Rows(Count).Cells(4).Value
            Temp_Total_Unit_Price = dgvPart.Rows(Count).Cells(5).Value
            Temp_Additional_Info = dgvPart.Rows(Count).Cells(7).Value
            SQLStatement = "INSERT INTO Invoice_Component(Order_Sequence_No, Invoice_ID, Part_ID, Quantity, Unit_Price, Total_Price, Additional_Info) VALUES('" & Temp_Order_Sequence_Number & "', '" & Invoice_ID & "', '" & Temp_Part_ID & "', '" & Temp_Quantity & "', '" & Temp_Unit_Price & "', '" & Temp_Total_Unit_Price & "', '" & Temp_Additional_Info & "')"
            SQLCommand(SQLStatement)
            Count = Count + 1
        Loop
        Print()
        'This calls the Print() sub which generates a word document and fills in all the information into a word file.
        lblSaved.Text = "1"
        'This changes the saved state to 1, meaning that if the user tries to save again, the invoice is overwritten by the new one.
    End Sub

    Public Sub Print()

        Dim oWord As Word.Application
        Dim oDoc As Word.Document
        Dim oTable As Word.Table
        Dim oPara1, oPara2, oPara3, oPara4, oPara5, oPara6, oPara7, oPara8, oPara9, oPara10, oPara11, oPara12, oPara13, oPara14, oPara15, _
            oPara16, oPara17, oPara18, oPara19, oPara20 As Word.Paragraph

        oWord = CreateObject("Word.Application")
        oWord.Visible = True
        oDoc = oWord.Documents.Add
        'This starts microsoft word

        oPara1 = oDoc.Content.Paragraphs.Add
        'This adds a new line
        oPara1.Range.Text = "AC MOTORS"
        'This specifies the text that will appear on the line
        oPara1.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        'This aligns the text to the right
        oPara1.Range.Font.Size = 15
        'This sets the font size to 15
        oPara1.Range.Font.Bold = True
        'This sets the font to bold
        oPara1.Format.SpaceAfter = 1
        'This means that the gap between this line and the next will be 1
        oPara1.Range.InsertParagraphAfter()
        'This sets up the next line to be created on the next line

        oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara2.Range.Text = "Vehicle Maintenance"
        oPara2.Format.SpaceAfter = 1
        oPara2.Range.InsertParagraphAfter()

        oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara3.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara3.Range.Text = "UNIT 4 BEECH LANE,"
        oPara3.Range.Font.Size = 11
        oPara3.Range.Font.Bold = True
        oPara3.Format.SpaceAfter = 1
        oPara3.Range.InsertParagraphAfter()

        oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara4.Range.Text = "MILE CROSS LANE,"
        oPara4.Format.SpaceAfter = 1
        oPara4.Range.InsertParagraphAfter()

        oPara5 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara5.Range.Text = "NORWICH, NR6 6RN"
        oPara5.Format.SpaceAfter = 1
        oPara5.Range.InsertParagraphAfter()

        oPara6 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara6.Range.Text = "Tel: Fax: 01603 404325"
        oPara6.Format.SpaceAfter = 1
        oPara6.Range.InsertParagraphAfter()

        oPara7 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara7.Range.Text = "E-mail: ady@ace-products.com"
        oPara7.Format.SpaceAfter = 1
        oPara7.Range.InsertParagraphAfter()

        oPara8 = oDoc.Content.Paragraphs.Add
        oPara8.Range.Text = "Customer       " & lblTitle.Text & " " & lblForename.Text & " " & lblSurname.Text & ""
        oPara8.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara8.Range.Font.Size = 11
        oPara8.Format.SpaceAfter = 1
        oPara8.Range.InsertParagraphAfter()

        oPara9 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara9.Range.Text = "Address          " & lblALine1.Text & ""
        oPara9.Format.SpaceAfter = 1
        oPara9.Range.InsertParagraphAfter()

        If lblALine2.Text <> "<ALine2>" Or lblALine2.Text <> "" Then
            oPara10 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara10.Range.Text = "                         " & lblALine2.Text & ""
            oPara10.Format.SpaceAfter = 1
            oPara10.Range.InsertParagraphAfter()
        End If
        If lblALine3.Text <> "<ALine3>" And lblALine3.Text <> "" Then
            oPara11 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara11.Range.Text = "                         " & lblALine3.Text & ""
            oPara11.Format.SpaceAfter = 1
            oPara11.Range.InsertParagraphAfter()
        End If
        oPara12 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara12.Range.Text = "Postcode        " & lblPostcode.Text & ""
        oPara12.Format.SpaceAfter = 10
        oPara12.Range.InsertParagraphAfter()
        If lblContact_Mobile.Text <> "<Mobile No>" And lblContact_Mobile.Text <> "" Then
            oPara13 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara13.Range.Text = "Mobile No      " & lblContact_Mobile.Text & ""
            oPara13.Format.SpaceAfter = 1
            oPara13.Range.InsertParagraphAfter()
        End If
        If lblContact_Home.Text <> "<Home No>" And lblContact_Home.Text <> "" Then
            oPara14 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara14.Range.Text = "Home No        " & lblContact_Home.Text & ""
            oPara14.Format.SpaceAfter = 1
            oPara14.Range.InsertParagraphAfter()
        End If
        If lblContact_EMail.Text <> "<E-Mail>" And lblContact_EMail.Text <> "" Then
            oPara14 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
            oPara14.Range.Text = "E-mail              " & lblContact_EMail.Text & ""
            oPara14.Format.SpaceAfter = 10
            oPara14.Range.InsertParagraphAfter()
        End If
        oPara15 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara15.Range.Text = "Vehicle            " & lblMake.Text & " " & lblModel.Text & ""
        oPara15.Format.SpaceAfter = 1
        oPara15.Range.InsertParagraphAfter()

        oPara16 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara16.Range.Text = "Registration   " & lblRegistration_Number.Text & ""
        oPara16.Format.SpaceAfter = 1
        oPara16.Range.InsertParagraphAfter()

        oPara17 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        oPara17.Range.Text = "Mileage           " & txtMileage.Text & ""
        oPara17.Format.SpaceAfter = 10
        oPara17.Range.InsertParagraphAfter()

        oPara18 = oDoc.Content.Paragraphs.Add
        oPara18.Range.Text = "Service Provided"
        oPara18.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter
        oPara18.Format.SpaceAfter = 1
        oPara18.Range.InsertParagraphAfter()

        oPara18 = oDoc.Content.Paragraphs.Add
        oPara18.Range.Text = "" & lblDate.Text & ""
        oPara18.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara18.Format.SpaceAfter = 1
        oPara18.Range.InsertParagraphAfter()

        oPara19 = oDoc.Content.Paragraphs.Add
        oPara19.Range.Text = "" & txtDescription.Text & ""
        oPara19.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft
        oPara19.Format.SpaceAfter = 10
        oPara19.Range.InsertParagraphAfter()

        Dim r, c As Integer
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, dgvPart.RowCount + 1, 5)
        'This inserts the table at the end of the document so far and sets the number of rows to 1 larger than the rowcount of dgvPart and number of columns to 5
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        'This adds 6 spaces after the table
        oTable.Cell(1, 1).Range.Text = "Part Supplied"
        'This sets the value of cell 1, 1 of the table to Part Supplied
        oTable.Cell(1, 2).Range.Text = "Additional Info"
        oTable.Cell(1, 3).Range.Text = "Quantity"
        oTable.Cell(1, 4).Range.Text = "Cost Each"
        oTable.Cell(1, 5).Range.Text = "Total"
        For r = 1 To dgvPart.RowCount + 1
            'This loops from to 1 to the last row
            For c = 1 To 5
                'This loops for every cell on that row
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderBottom)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                    'This sets the border type for the bottom of the cell to a black solid line 25 pt thick
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderTop)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderLeft)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderRight)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
            Next
        Next
        r = 2
        'This sets the next loop to start on row 2 because row 1 has the column headers
        Do Until r = dgvPart.RowCount + 2
            'This will loop from row to row until the last row is done
            oTable.Cell(r, 1).Range.Text = dgvPart.Rows(r - 2).Cells(2).Value
            'Sets the value of the 1st cell in that row to the part name stored in the datagridview
            oTable.Cell(r, 2).Range.Text = dgvPart.Rows(r - 2).Cells(7).Value
            oTable.Cell(r, 3).Range.Text = dgvPart.Rows(r - 2).Cells(3).Value
            oTable.Cell(r, 4).Range.Text = "" & FormatCurrency(dgvPart.Rows(r - 2).Cells(4).Value, 2) & ""
            oTable.Cell(r, 5).Range.Text = "" & FormatCurrency(dgvPart.Rows(r - 2).Cells(5).Value, 2) & ""
            r = r + 1
            'increments the row by 1
        Loop

        oTable.Rows(1).Range.Font.Bold = True

        oPara20 = oDoc.Content.Paragraphs.Add
        oPara20.Range.Text = ""
        oPara20.Format.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight
        oPara20.Format.SpaceAfter = 4
        oPara20.Range.InsertParagraphAfter()

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        oTable.Range.ParagraphFormat.SpaceAfter = 6
        oTable.Cell(1, 1).Range.Text = "Sub Total"
        oTable.Cell(1, 2).Range.Text = "" & FormatCurrency(txtParts_Total.Text, 2) & ""
        oTable.Cell(2, 1).Range.Text = "Labour"
        oTable.Cell(2, 2).Range.Text = "" & FormatCurrency(txtLabour_Total.Text, 2) & ""
        oTable.Cell(3, 1).Range.Text = "Pre VAT"
        oTable.Cell(3, 2).Range.Text = "" & FormatCurrency(txtPreVAT_Total.Text, 2) & ""
        oTable.Cell(4, 1).Range.Text = "VAT"
        oTable.Cell(4, 2).Range.Text = "" & FormatCurrency(txtVAT_Total.Text, 2) & ""
        oTable.Cell(5, 1).Range.Text = "Total"
        oTable.Cell(5, 2).Range.Text = "" & FormatCurrency(txtInvoice_Total.Text, 2) & ""
        oTable.Columns.Item(1).Width = oWord.InchesToPoints(1)
        oTable.Columns.Item(2).Width = oWord.InchesToPoints(1)
        For r = 1 To 5
            For c = 1 To 2
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderBottom)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderTop)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderLeft)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
                With oTable.Cell(r, c).Borders(Word.WdBorderType.wdBorderRight)
                    .LineStyle = Word.WdLineStyle.wdLineStyleSingle
                    .LineWidth = Word.WdLineWidth.wdLineWidth025pt
                    .Color = Word.WdColor.wdColorBlack
                End With
            Next
        Next
    End Sub
End Class