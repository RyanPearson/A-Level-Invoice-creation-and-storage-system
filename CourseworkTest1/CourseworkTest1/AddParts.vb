Imports MySql.Data.MySqlClient
Public Class frmAddParts
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    Dim SQLCommand, SQLPriceCommand, PartSelected As String
    Dim Temp_Part_Name, Temp_Price As String
    Dim Temp_Low_Price, Temp_High_Price As Decimal
    Dim Con As New MySqlConnection
    Dim Adapter As MySqlDataAdapter
    Dim PartTable As DataTable
    Dim Part_ID, Part_Name, Part_Quantity, Unit_Cost, Total_Price, Additional_Information, Description, SQLPartDesc As String
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub frmAddParts_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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
        SQLCommand = "SELECT * FROM Part"
        SQLSelect(SQLCommand)
        'This selects all the Parts in the Part table
        If Temp_Part_Name = "" Then
            MessageBox.Show("There aren't any parts stored in the database. Please add the part through the 'Add Part' option in the 'Settings' menu.", _
    "No Part In Database", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'This message box will appear if the statement does not return any parts
            Me.Close()
            Exit Sub
        End If
        Adapter = New MySqlDataAdapter(SQLCommand, Con)
        PartTable = New DataTable
        Adapter.Fill(PartTable)
        Part.DataSource = PartTable
        'This sets the datasource for part to all the results of the search
        Part.DisplayMember = ("Part_Name")
        'This means that the user will only see the part names
        Part.ValueMember = ("Part_ID")
        'This means that when the user selects a part from the comboboxColumn, the part_id will be the value instead of returning hte part name

    End Sub

    Private Sub dgvAddParts_CellEndEdit(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAddParts.CellEndEdit
        If e.ColumnIndex = 2 Then
            'This sub will only have any use when the column which has been edited in the datagridview
            If dgvAddParts.Rows(e.RowIndex).Cells(0).Value Is Nothing Then
                MessageBox.Show("You must select the part for this row before you can state the unit cost.", "Please select the part used", _
                MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                'If the user has finished editing the row and has not entered a value then this messagebox will open
                Exit Sub
            Else
                PartSelected = dgvAddParts.Rows(e.RowIndex).Cells(0).Value
                SQLPriceCommand = ("SELECT Part_Name, Low_Price, High_Price, Description FROM Part WHERE Part_ID = '" & PartSelected & "'")
                SQLSelect(SQLPriceCommand)
                'This selects the Lowest price and highest price for the part the user has selected 
                Temp_Price = dgvAddParts.Rows(e.RowIndex).Cells(2).Value
                If Temp_Price >= Temp_Low_Price And Temp_Price <= Temp_High_Price Or Temp_Price = "" Then
                    'This tests to see if the value for the unit price the user has entered is between the pre-determined price range
                    'If the value is between the range then nothing happens
                    Exit Sub
                Else
                    MessageBox.Show("The Cost Per Unit of " & Temp_Part_Name & " should be between £" & Temp_Low_Price & " and £" & Temp_High_Price _
                                    & ". Please check the value you have entered.", "Please check value for unit cost.", MessageBoxButtons.OK, MessageBoxIcon.Error, _
                                    MessageBoxDefaultButton.Button2)
                    'If the value is not between the range then a message is displayed alerting the user of this.
                    'However, this does not stop the user from using the value that they have entered.
                    'This is by design as i dont not want to restrict the user from entering a correct value but instead alert them to the fact that it is an abnormal price.
                End If
            End If
        End If
    End Sub

    Public Sub SQLSelect(ByRef SQLPriceCommand As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLPriceCommand
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Temp_Part_Name = SQLdr("Part_Name")
            Temp_Low_Price = SQLdr("Low_Price")
            Temp_High_Price = SQLdr("High_Price")
        End While
        SQLdr.Close()
        'This sub is re-used throughot many of the forms. This one is used in the sub above and is used for validation of the entered unit cost

    End Sub

    Public Sub SQLPartAndDesc(ByRef SQLPartDesc As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLPartDesc
        SQLdr = SQLCmd.ExecuteReader

        While SQLdr.Read
            Part_Name = SQLdr("Part_Name")
            Description = SQLdr("Description")
        End While
        SQLdr.Close()
        'This is used to retrieve the description for sending the parts used to the create inv form
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        Dim Count As Integer = 0
        Dim Test As Decimal
        Do
            If CStr(dgvAddParts.Rows(Count).Cells(0).Value) Is Nothing Or CStr(dgvAddParts.Rows(Count).Cells(0).Value) = " " Or _
                CStr(dgvAddParts.Rows(Count).Cells(1).Value) Is Nothing Or CStr(dgvAddParts.Rows(Count).Cells(1).Value) = " " Or _
                CStr(dgvAddParts.Rows(Count).Cells(2).Value) Is Nothing Or CStr(dgvAddParts.Rows(Count).Cells(2).Value) = " " Then
                MessageBox.Show("You must fill out all of the information before you can save. (You are not required to fill out the 'Additional Info' column.)", _
                                "Please complete all information", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
                'This checks every necessary cell in this row to see if they are empty. If any of them are empty a message box will 
            End If
            Try
                Test = dgvAddParts.Rows(Count).Cells(2).Value + 1
            Catch ex As Exception
                MessageBox.Show("You can only enter a number into the 'Unit Cost' field. Please replace the current contents with a number.", _
    "Unit Cost Field Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
            End Try
            'This try catch tests to see if the value the user has entered into the unit cost field is numerical.
            Try
                Test = dgvAddParts.Rows(Count).Cells(1).Value + 1
            Catch ex As Exception
                MessageBox.Show("You can only enter a number into the 'Quantity' field. Please replace the current contents with a number.", _
    "Quantity Field Incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
                Exit Sub
            End Try
            'This try catch tests to see if the value the user has entered into the quantity field is numerical.
            Count = Count + 1
            'increments Count by 1
        Loop Until dgvAddParts.Rows(Val(Count)).Cells(0).Value Is Nothing And dgvAddParts.Rows(Val(Count)).Cells(1).Value Is Nothing _
            And dgvAddParts.Rows(Val(Count)).Cells(2).Value Is Nothing
        'This will loop until it has reached the last row in the datagridview
        Count = 0
        'Resets count to 0, ready for the next loop
        Do
            Part_ID = dgvAddParts.Rows(Val(Count)).Cells(0).Value
            Part_Quantity = dgvAddParts.Rows(Val(Count)).Cells(1).Value
            Unit_Cost = dgvAddParts.Rows(Val(Count)).Cells(2).Value
            Total_Price = Part_Quantity * Unit_Cost
            Additional_Information = dgvAddParts.Rows(Val(Count)).Cells(3).Value
            SQLPartDesc = ("SELECT Part_Name, Description FROM Part WHERE Part_ID = '" & Part_ID & "'")
            SQLPartAndDesc(SQLPartDesc)
            'This queries the database to find the part_name and the description for that part
            frmCreateInv.dgvPart.Rows.Add("", "" & Part_ID & "", "" & Part_Name & "", "" & Part_Quantity & "", "" & Unit_Cost & "", "" & Total_Price & "", "" & Description & "", "" & Additional_Information & "")
            'This adds the row to the createinv form
            Count = Count + 1
            'Increments count by 1
        Loop Until dgvAddParts.Rows(Val(Count)).Cells(0).Value Is Nothing
        'This loops until it has reached the last row.
        frmCreateInv.lblTotalsGen.Text = "0"
        'This sets the Totals generated state to "0" so the user is forced to re calculate the totals before they save
        Me.Close()
    End Sub
End Class