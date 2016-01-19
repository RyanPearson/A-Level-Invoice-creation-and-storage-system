Imports MySql.Data.MySqlClient
Public Class frmSearchFC
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim Temp_Customer_ID, Forename, Surname, ALine1, ALine2, ALine3, Postcode As String
    Dim Selected As Boolean = False

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'This closes the search for customer form. when this happens the user will be returned to the form the came from
    End Sub

    Private Sub frmSearchFC_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

        If txtPostcode.Text = "" Then
            Postcode = ""
            If txtALine3.Text = "" Then
                ALine3 = ""
                If txtALine2.Text = "" Then
                    ALine2 = ""
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "'"
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "'"
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                        ALine1 = "ALine1 = '" & txtALine1.Text & "'"
                    End If
                Else
                    ALine2 = "ALine2 = '" & txtALine2.Text & "'"
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                    End If
                End If
            Else
                ALine3 = "ALine3 = '" & txtALine3.Text & "'"
                If txtALine2.Text = "" Then
                    ALine2 = ""
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                Else
                    ALine2 = "ALine2 = '" & txtALine2.Text & "' AND "
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                End If
            End If
        Else
            If txtALine3.Text = "" Then
                ALine3 = ""
                If txtALine2.Text = "" Then
                    ALine2 = ""
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                Else
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                    ALine2 = "ALine2 = '" & txtALine2.Text & "' AND "
                End If
            Else
                If txtALine2.Text = "" Then
                    ALine2 = ""
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                Else
                    ALine2 = "ALine2 = '" & txtALine2.Text & "' AND "
                    If txtALine1.Text = "" Then
                        ALine1 = ""
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    Else
                        ALine1 = "ALine1 = '" & txtALine1.Text & "' AND "
                        If txtSurname.Text = "" Then
                            Surname = ""
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        Else
                            Surname = "Surname = '" & txtSurname.Text & "' AND "
                            If txtForename.Text = "" Then
                                Forename = ""
                            Else
                                Forename = "Forename = '" & txtForename.Text & "' AND "
                            End If
                        End If
                    End If
                End If
                ALine3 = "ALine3 = '" & txtALine3.Text & "' AND "
            End If
            Postcode = "Postcode = '" & txtPostcode.Text & "'"
        End If
        'This sub creates the Select statement based upon what information has been entered by the user.
        'This is a lot more complicated than the search by customer and date form because the combinationg may end up ending with an 'AND' and this would cause the system to crash.
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Dim SQLCommand As String
        CreateSQLCommand()
        'This calls the sub routine which determines what the select statement should search by.
        If Forename + Surname + ALine1 + ALine2 + ALine3 + Postcode = "" Then
            SQLCommand = "SELECT * FROM customer"
            Filldgv(SQLCommand)
            'If the user does not enter any search criteria then this statement is ran. This will select all the customers in the database.
        Else
            SQLCommand = "SELECT * FROM customer WHERE " & Forename & " " & Surname & " " & ALine1 & " " & ALine2 & " " & ALine3 & " " & Postcode & ""
            SQLSelect(SQLCommand)
            'If the user does enter some search criteria then the select statement will be constructed to fit the criteria.
            'the statement is then ran to test to see if the customer exists on the database
            If Temp_Customer_ID = "" Then
                MessageBox.Show("This Customer may not exist on the database. Please check that the information has been entered correctly. If the information has been entered correctly then please proceed to the 'Create New Customer' menu.", _
                                    "Customer may not exist", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                'If the customer does not exist this message will be displayed.
                    Exit Sub
            Else
                Filldgv(SQLCommand)
                'If the customer does exist then the filldgv sub will be ran which will fill the datagridview with all the customers which match the entered search criteria
            End If
        End If
    End Sub

    Public Sub Filldgv(ByRef SQLCommand As String)
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable
        Try
            Adapter = New MySqlDataAdapter(SQLCommand, Con)
            Table = New DataTable
            Adapter.Fill(Table)
            dgvSearch.DataSource = Table
            dgvSearch.Columns(1).Visible = False
            dgvSearch.Columns(2).Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        'This sub fills the datagridview with all the customers which match the select statement
    End Sub

    Public Sub SQLSelect(ByRef SQLCommand As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLCommand
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Temp_Customer_ID = SQLdr("Customer_ID")
        End While
        SQLdr.Close()
        'This sub is used to test to see if the detatials entered will return any customers.
    End Sub

    Private Sub dgvSearch_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSearch.CellContentClick

        If e.ColumnIndex <> 0 Or e.RowIndex = dgvSearch.RowCount - 1 Then
            Exit Sub
            'This ensures that the code below is only ran if the buton column is pressed.
        End If
        If lblEditCustomer.Text = "1" Then
            'If the user reached this screen from the settings menu then lblEditCustomer will equal 1
            frmEditC.Show()
            'This opens a blanks Edit customer form
            With frmEditC
                .lblCustomer_ID.Text = dgvSearch.Rows(e.RowIndex).Cells(1).Value
                .cmbTitle.SelectedItem = dgvSearch.Rows(e.RowIndex).Cells(2).Value
                .txtForename.Text = dgvSearch.Rows(e.RowIndex).Cells(3).Value
                .txtSurname.Text = dgvSearch.Rows(e.RowIndex).Cells(4).Value
                .txtALine1.Text = dgvSearch.Rows(e.RowIndex).Cells(5).Value
                .txtALine2.Text = dgvSearch.Rows(e.RowIndex).Cells(6).Value
                .txtALine3.Text = dgvSearch.Rows(e.RowIndex).Cells(7).Value
                .txtPostcode.Text = dgvSearch.Rows(e.RowIndex).Cells(8).Value
                .txtContact_Mobile.Text = dgvSearch.Rows(e.RowIndex).Cells(9).Value
                .txtContact_Home.Text = dgvSearch.Rows(e.RowIndex).Cells(10).Value
                .txtContact_EMail.Text = dgvSearch.Rows(e.RowIndex).Cells(11).Value
                'This exports all the details of the selected customer to the edit customer form.
            End With
            Selected = True
            'This sets selected to true, meaning that when the search for customer form is closed, the settings form will not be opened
            Me.Close()
            Exit Sub
        End If
        'If the user reached this form from the create invoice form then this code will be ran
        With frmCreateInv
            .lblCustomer_ID.Text = dgvSearch.Rows(e.RowIndex).Cells(1).Value
            .lblTitle.Text = dgvSearch.Rows(e.RowIndex).Cells(2).Value
            .lblForename.Text = dgvSearch.Rows(e.RowIndex).Cells(3).Value
            .lblSurname.Text = dgvSearch.Rows(e.RowIndex).Cells(4).Value
            .lblALine1.Text = dgvSearch.Rows(e.RowIndex).Cells(5).Value
            .lblALine2.Text = dgvSearch.Rows(e.RowIndex).Cells(6).Value
            .lblALine3.Text = dgvSearch.Rows(e.RowIndex).Cells(7).Value
            .lblPostcode.Text = dgvSearch.Rows(e.RowIndex).Cells(8).Value
            .lblContact_Mobile.Text = dgvSearch.Rows(e.RowIndex).Cells(9).Value
            .lblContact_Home.Text = dgvSearch.Rows(e.RowIndex).Cells(10).Value
            .lblContact_EMail.Text = dgvSearch.Rows(e.RowIndex).Cells(11).Value
            'This exports the customer details to the create invoice form.
        End With
        Me.Close()

    End Sub

    Private Sub frmSearchFC_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        If lblEditCustomer.Text = "1" And Selected = False Then
            'If the user reached this form from the settings form and the form is not being closed due to selecting a customer then this code is ran.
            frmSettings.Show()
            'The user is retrned to the settings form.
        End If
    End Sub
End Class