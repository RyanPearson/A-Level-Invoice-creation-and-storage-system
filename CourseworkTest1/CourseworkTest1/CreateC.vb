Imports MySql.Data.MySqlClient
Public Class frmCreateC
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    Dim Con As New MySqlConnection
    Dim Customer_ID As String

    Public Sub frmCreateC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim SQLStatement, SQLStatementSelect As String
        If cmbTitle.SelectedItem = "" Or txtForename.Text = "" Or txtSurname.Text = "" Or txtALine1.Text = "" Or txtPostcode.Text = "" Then
            MessageBox.Show("One or more of the required fields have not been filled. Please ensure that all fields marked with a * has an entry before attempting to save.", _
                "Un-completed fields", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'This checks to see if all the fields which have been marked as not null in the databse have values.
        Else
            SQLStatementSelect = "SELECT Customer_ID FROM Customer WHERE Title = '" & cmbTitle.SelectedItem & "' AND Forename = '" & txtForename.Text & "' AND Surname = '" & txtSurname.Text & "' AND ALine1 = '" & txtALine1.Text & "'"
            SQLSelect(SQLStatementSelect)
            'This searches the database for a customer with the same title, name and first line of the address to prevent duplicate records being created.
            If Customer_ID = "" Then
                'If the search does not return any customers then the customer is saved to the database
                SQLStatement =
                    "INSERT INTO customer(Title, Forename, Surname, ALine1, ALine2, ALine3, Postcode, Contact_Mobile, Contact_Home, Contact_EMail) VALUES('" & cmbTitle.SelectedItem & "', '" & txtForename.Text & "', '" & txtSurname.Text & "', '" & txtALine1.Text & "', '" & txtALine2.Text & "', '" & txtALine3.Text & "', '" & txtPostcode.Text & "', '" & txtContact_Mobile.Text & "', '" & txtContact_Home.Text & "', '" & txtContact_EMail.Text & "')"
                SQLCommand(SQLStatement)
                'This saves the customer to the database
                SQLStatementSelect = "SELECT Customer_ID FROM Customer WHERE Title = '" & cmbTitle.SelectedItem & "' AND Forename = '" & txtForename.Text & "' AND Surname = '" & txtSurname.Text & "' AND ALine1 = '" & txtALine1.Text & "' AND ALine2 = '" & txtALine2.Text & "' AND ALine3 = '" & txtALine3.Text & "' AND Postcode = '" & txtPostcode.Text & "' AND Contact_Mobile = '" & txtContact_Mobile.Text & "' AND Contact_Home = '" & txtContact_Home.Text & "' AND Contact_EMail = '" & txtContact_EMail.Text & "'"
                SQLSelect(SQLStatementSelect)
                'This returns the customer_id of hte new customer for use in the create inv form.
                MessageBox.Show("New customer has been saved.", _
                "Customer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                'This displays a message telling the user that the customer has been saved.
                With frmCreateInv
                    .lblTitle.Text = cmbTitle.SelectedItem
                    .lblForename.Text = txtForename.Text
                    .lblSurname.Text = txtSurname.Text
                    .lblALine1.Text = txtALine1.Text
                    .lblALine2.Text = txtALine2.Text
                    .lblALine3.Text = txtALine3.Text
                    .lblPostcode.Text = txtPostcode.Text
                    .lblContact_Mobile.Text = txtContact_Mobile.Text
                    .lblContact_Home.Text = txtContact_Home.Text
                    .lblContact_EMail.Text = txtContact_EMail.Text
                    .lblCustomer_ID.Text = Customer_ID
                End With
                'This returns the new information to the create invoice form.
                Me.Close()
            Else
                MessageBox.Show("Sorry, this Customer is already stored on the Database. Please select this Customer from the 'Search For Customer' menu.", _
                                "Customer Exists", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                'This alerts the user to the fact that the customer they are trying to create already exists and does not save the customer to the database.
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        If cmbTitle.SelectedItem <> "" Or txtForename.Text <> "" Or txtSurname.Text <> "" Or txtALine1.Text <> "" Or txtALine2.Text <> "" _
    Or txtALine3.Text <> "" Or txtPostcode.Text <> "" Or txtContact_Mobile.Text <> "" Or txtContact_Home.Text <> "" Or txtContact_EMail.Text <> "" Then
            'This checks to see if the user has started to create a new customer but has not saved.
            Dim Response As DialogResult = MessageBox.Show("Are you sure you want exit this menu without saving?", "Exit menu?", _
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
            'This asks to user if they would like to close the form without saving
            If (Response = DialogResult.Yes) Then
                'If they press yes then the form is closed
                Me.Close()
            Else
                'if they press no then the form is left open
                Exit Sub
            End If
        Else
            'If all the fields are blank then the form is closed without a message box being displayed.
            Me.Close()
        End If
    End Sub

    Public Sub SQLCommand(ByRef SQLStatement As String)
        Dim Cmd As MySqlCommand = New MySqlCommand

        With Cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = Con
            .ExecuteNonQuery()

        End With
        'This is used to save the customer to the database
    End Sub

    Public Sub SQLSelect(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Customer_ID = SQLdr("Customer_ID")
        End While
        SQLdr.Close()
        'This is used to return the customer_id.
    End Sub
End Class