Imports MySql.Data.MySqlClient
Public Class frmCreatePart
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    Dim Con As New MySqlConnection
    Dim Part_ID, SQLStatement, SQLSelectStatement As String
    Private Sub frmAddPart_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        'This is used to save the part to the database.
    End Sub

    Public Sub SQLSelect(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Part_ID = SQLdr("Part_ID")
        End While
        SQLdr.Close()
        'This is used to select the Part_ID from the database.
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim test As Decimal
        If txtPart_Name.Text = "" Or txtDecription.Text = "Please use only a few sentences at maximum and do not use the enter key." Or txtDecription.Text = "" Or txtLow_Price.Text = "" Or txtHigh_Price.Text = "" Then
            MessageBox.Show("Not all of the fields have been filled out. Please make sure all of the information have been completed.", _
      "Un-completed fields", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
            'This test to see if any of the fields have been left blank. If any of them have then this message is displayed.
        End If

        Try
            test = CDec(txtLow_Price.Text) - 1
        Catch ex As Exception
            MessageBox.Show("The value you have entered into the Lowest Price field has to be numerical before you can save this part.", _
"Numeric value expected.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End Try
        'This tests to see if the value in txtLow_Price is numerical. If it is not then this message is displayed

        Try
            test = CDec(txtHigh_Price.Text) - 1
        Catch ex As Exception
            MessageBox.Show("The value you have entered into the Highest Price field has to be numerical before you can save this part.", _
"Numeric value expected.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End Try
        'This tests to see if the value in txtHigh_Price is numerical. If it is not then this message is displayed

        If CDec(txtHigh_Price.Text) <= CDec(txtLow_Price.Text) Then
            MessageBox.Show("The value you have entered into the Highest Price field cannot be less than or equal to the value in the Lowest Price field. This must be corrected before you can save this part.", _
"Numeric value expected.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        'This test to see if the value of txtHigh_Price was less than or equal to the value of txtLow_price. If this is the case then this message is displayed.
        SQLSelectStatement = "SELECT Part_ID from part WHERE Part_Name = '" & txtPart_Name.Text & "'"
        SQLSelect(SQLSelectStatement)
        'This tests to see if a part with the same name exists on the database.
        If Part_ID <> "" Then
            'If the search returns a part_id then this message is displayed and the part is not saved.
            MessageBox.Show("This part already exists on the database. You cannot create the same part twice.", _
"Part Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        'If the search does not return a part_id then it is saved to the database
        SQLStatement = "INSERT INTO part(Part_Name, Description, Low_Price, High_Price) VALUES('" & txtPart_Name.Text & "', '" & txtDecription.Text & "', '" & txtLow_Price.Text & "', '" & txtHigh_Price.Text & "')"
        SQLCommand(SQLStatement)
        'This saves the part to the database.

        Dim Response As DialogResult = MessageBox.Show("The new part has been created. Would you like to create another part?", _
"Create New Part?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        'This asks the user if they would like to create another part. This is just there so that when they are entering a lot of new parts,
        'they wont have to keep re opening the form.
        If Response = DialogResult.Yes Then
            txtPart_Name.Text = ""
            txtLow_Price.Text = ""
            txtHigh_Price.Text = ""
            txtDecription.Text = "Please use only a few sentences at maximum and do not use the enter key."
            Part_ID = ""
            SQLStatement = ""
            SQLSelectStatement = ""
            'this resets all the fields to what they were originally.
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Dim Response As DialogResult = MessageBox.Show("Are you sure you want to exit this menu without saving?", _
"Exit Menu?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If Response = DialogResult.Yes Then
            Me.Close()
        End If
        'This asks the user if they want to exit the form without saving. If they answer yes then the form is closed
    End Sub

    Private Sub frmAddPart_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        frmSettings.Show()
        'When the form is closed then settings form is loaded.
    End Sub
End Class