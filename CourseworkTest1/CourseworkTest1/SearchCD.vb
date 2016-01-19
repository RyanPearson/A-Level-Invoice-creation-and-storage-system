Imports MySql.Data.MySqlClient
Public Class frmSearchCD
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim Temp_Customer_ID, Forename, Surname, ALine1, ALine2, ALine3, Postcode, DateSearch As String
    Dim Selected As Boolean = False

    Private Sub frmSearchCD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Public Sub CreateSQLCommand()
        If lblDate.Text = "<Date>" Then
            DateSearch = ""
        Else
            DateSearch = "Date = '" & lblDate.Text & "' AND "
        End If
        If txtPostcode.Text = "" Then
            Postcode = ""
        Else
            Postcode = "Postcode = '" & txtPostcode.Text & "' AND "
        End If
        If txtALine3.Text = "" Then
            ALine3 = ""
        Else
            ALine3 = "ALine3 = '" & txtALine3.Text & "' AND "
        End If
        If txtALine2.Text = "" Then
            ALine2 = ""
        Else
            ALine2 = "ALine2 = '" & txtALine2.Text & "' AND "
        End If
        If txtALine1.Text = "" Then
            ALine1 = ""
        Else

            ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
        End If
        If txtSurname.Text = "" Then
            Surname = ""
        Else
            Surname = "Surname = '" & txtSurname.Text & "' AND "
        End If
        If txtForename.Text = "" Then
            Forename = ""
        Else
            Forename = "Forename = '" & txtForename.Text & "' AND "
        End If
        'This sub creates the Select statement based upon what information has been entered by the user.
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim SQLCommand As String
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable

        CreateSQLCommand()
        'This calls the sub routine which determines what the select statement should search by.
        If Forename + Surname + ALine1 + ALine2 + ALine3 + Postcode + DateSearch = "" Then
            MessageBox.Show("Please enter some details before searching.", _
                    "Enter Details", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'If the user has not entered any customer details or selected a date then this message box is displayed and the rest of this sub is not executed.
            Exit Sub
        End If

        SQLCommand = "SELECT customer.customer_ID, Forename, Surname, Invoice_ID, invoice.Vehicle_ID, Registration_Number, Date FROM customer, invoice, vehicle WHERE " & Forename & "" & Surname & "" & ALine1 & "" & ALine2 & "" & ALine3 & "" & Postcode & "" & DateSearch & "invoice.Customer_ID = Customer.Customer_ID AND vehicle.Vehicle_ID = invoice.Vehicle_ID"
        SQLSelect(SQLCommand)
        'This tests to see if the details entered returns any invoices.
        If Temp_Customer_ID = "" Then
            MessageBox.Show("This customer does not have any invoices saved on the database for this date. Please check that the information has been entered correctly.", _
                                   "Customer does not have any invoices on this date.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'If it does not return any invoices then this message is displayed and the rest of the sub is not executed.
            Exit Sub
        Else
            Try
                Adapter = New MySqlDataAdapter(SQLCommand, Con)
                Table = New DataTable
                Adapter.Fill(Table)
                dgvSearch.DataSource = Table
                dgvSearch.Columns(1).Visible = False
                dgvSearch.Columns(4).Visible = False
                dgvSearch.Columns(5).Visible = False
                'If the statement returns any invoices then the customer name, reg no, and date of all the invoices are displayed in a datagridview.
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
            Temp_Customer_ID = SQLdr("Customer_ID")
        End While
        SQLdr.Close()
        'This sub is used to test if the select statement retunrs any invoices.
    End Sub

    Private Sub dgvSearch_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellContentClick
        If e.ColumnIndex <> 0 Or e.RowIndex = dgvSearch.RowCount - 1 Then
            Exit Sub
            'This ensures that the code below is only ran if the buton column is pressed.
        End If
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader
        Dim SQLCommand As String
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable
        Dim Invoice_ID, Customer_ID, Vehicle_ID, SQLSelectStatement As String
        Dim Part_ID, Part_Name, Quantity, Unit_Price, Total_Price, Description, Additional_Info As String
        Dim Count As Integer
        Customer_ID = dgvSearch.Rows(e.RowIndex).Cells(1).Value
        Invoice_ID = dgvSearch.Rows(e.RowIndex).Cells(4).Value
        Vehicle_ID = dgvSearch.Rows(e.RowIndex).Cells(5).Value
        SQLSelectStatement = "SELECT * FROM Customer, Invoice, Vehicle WHERE customer.customer_ID = '" & Customer_ID & "' AND invoice_ID = '" & Invoice_ID & "' AND vehicle.vehicle_ID  = '" & Vehicle_ID & "'"
        'This satement selects all the information regarding the invoice which was selected byt the user.
        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLSelectStatement
        SQLdr = SQLCmd.ExecuteReader
        frmCreateInv.Show()
        'This opens a blank create invoice form
        While SQLdr.Read
            With frmCreateInv
                .lblCustomer_ID.Text = SQLdr("Customer_ID")
                .lblTitle.Text = SQLdr("Title")
                .lblForename.Text = SQLdr("Forename")
                .lblSurname.Text = SQLdr("Surname")
                .lblALine1.Text = SQLdr("ALine1")
                .lblALine2.Text = SQLdr("ALine2")
                .lblALine3.Text = SQLdr("ALine3")
                .lblPostcode.Text = SQLdr("Postcode")
                .lblContact_Mobile.Text = SQLdr("Contact_Mobile")
                .lblContact_Home.Text = SQLdr("Contact_Home")
                .lblContact_EMail.Text = SQLdr("Contact_EMail")
                .lblDate.Text = SQLdr("Date")
                .lblVehicle_ID.Text = SQLdr("Vehicle_ID")
                .lblMake.Text = SQLdr("Make")
                .lblModel.Text = SQLdr("Model")
                .lblRegistration_Number.Text = SQLdr("Registration_Number")
                .txtMileage.Text = SQLdr("Mileage")
                .txtDescription.Text = SQLdr("Description")
                .txtLabour_Total.Text = SQLdr("Labour_Total")
                .txtParts_Total.Text = SQLdr("Parts_Total")
                .txtPreVAT_Total.Text = SQLdr("Pre_VAT_Total")
                .txtVAT_Total.Text = SQLdr("VAT_Total")
                .txtInvoice_Total.Text = SQLdr("Invoice_Total")
                .lblInvoice_ID.Text = SQLdr("Invoice_ID")
                .lblSaved.Text = "1"
                .lblTotalsGen.Text = "1"
                'This exports all the details of the invoice to the form. It also sets the saved state to 1 and the totals generated to 1
            End With
        End While
        SQLdr.Close()

        SQLCommand = "SELECT invoice_component.Part_ID, Part_Name, Quantity, Unit_Price, Total_Price, Description, Additional_Info FROM invoice_component, Part WHERE Invoice_ID = '" & Invoice_ID & "' AND part.Part_ID = invoice_component.Part_ID"
        'This selects all the parts used in the selected invoice.
        Try
            Adapter = New MySqlDataAdapter(SQLCommand, Con)
            Table = New DataTable
            Adapter.Fill(Table)
            dgvPart.DataSource = Table
            'This fills a datagridview with all the parts used in the invoice selected
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Count = 0
        'This sets the count to start at the first row
        Do Until Count = dgvPart.RowCount
            Part_ID = dgvPart.Rows(Count).Cells(0).Value
            Part_Name = dgvPart.Rows(Count).Cells(1).Value
            Quantity = dgvPart.Rows(Count).Cells(2).Value
            Unit_Price = dgvPart.Rows(Count).Cells(3).Value
            Total_Price = dgvPart.Rows(Count).Cells(4).Value
            Description = dgvPart.Rows(Count).Cells(5).Value
            Additional_Info = dgvPart.Rows(Count).Cells(6).Value
            frmCreateInv.dgvPart.Rows.Add("", "" & Part_ID & "", "" & Part_Name & "", "" & Quantity & "", "" & Unit_Price & "", "" & Total_Price & "", "" & Description & "", "" & Additional_Info & "")
            'This adds the row which has been retrieved from the invoice_component to the parts used datagridview in the create invoice form
            Count = Count + 1
            'This increments count by 1 and moves to the next row
        Loop
        Selected = True
        'Sets selected to true so that when this form is closed, the search form is not opened.
        Me.Close()
    End Sub

    Private Sub btnDate_Click(sender As System.Object, e As System.EventArgs) Handles btnDate.Click
        lblDate.Text = CStr(Me.mcDate.SelectionRange.Start)
        'This set sthe value of lblDate to the date which has been selected by the user.
    End Sub

    Private Sub frmSearchCD_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        If Selected = False Then
            'If the selected boolean is false then when the form is closed by pressing the x button or the back button then the search form is opened.
            frmSearch.Show()
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'When the back button is pressed the form is closed and because selected is still false the search form is opened.
    End Sub
End Class