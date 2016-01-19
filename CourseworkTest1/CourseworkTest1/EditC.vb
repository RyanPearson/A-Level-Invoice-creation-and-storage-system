Imports MySql.Data.MySqlClient
Public Class frmEditC
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim SQLStatement As String

    Private Sub frmEditC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        If txtForename.Text = "" Or txtSurname.Text = "" Or txtALine1.Text = "" Or txtPostcode.Text = "" Or cmbTitle.SelectedItem = "" Then
            'If any of the mandatory fields are left blank then this message is displayed and the record is not updated.
            MessageBox.Show("One or more of the required fields have not been filled. Please ensure that all fields marked with a * has an entry before attempting to save.", _
                "Un-completed fields", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        SQLStatement =
    "UPDATE customer SET Title = '" & cmbTitle.SelectedItem & "', Forename = '" & txtForename.Text & "', Surname = '" & txtSurname.Text & "', ALine1 = '" & txtALine1.Text & "', ALine2 = '" & txtALine2.Text & "', ALine3 = '" & txtALine3.Text & "', Postcode = '" & txtPostcode.Text & "', Contact_Mobile = '" & txtContact_Mobile.Text & "', Contact_Home = '" & txtContact_Home.Text & "', Contact_Email = '" & txtContact_EMail.Text & "' WHERE Customer_ID = '" & lblCustomer_ID.Text & "'"
        SQLCommand(SQLStatement)
        'This updates the customer record with the new information which has been entered by the user.
        MessageBox.Show("The customer details have been succesfully changed.", _
        "Customer Saved", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
        'This message alerts the user to the fact that the customer record has been updated.
        Me.Close()
    End Sub

    Public Sub SQLCommand(ByRef SQLStatement As String)
        Dim Cmd As MySqlCommand = New MySqlCommand

        With Cmd
            .CommandText = SQLStatement
            .CommandType = CommandType.Text
            .Connection = Con
            .ExecuteNonQuery()
        End With
        'This sub is used to execute the update statement
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Dim Response As DialogResult = MessageBox.Show("Are you sure you want exit this menu without saving?", "Exit menu?", _
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        'When the back button is pressed, this message is displayed.
        If (Response = DialogResult.Yes) Then
            Me.Close()
            'If the user presses yes then the form is closed.
        End If
    End Sub

    Private Sub frmEditC_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        frmSettings.Show()
        'When the form is closed, the settings form is shown.
    End Sub
End Class