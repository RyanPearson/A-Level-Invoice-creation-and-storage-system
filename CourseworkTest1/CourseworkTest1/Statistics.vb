Imports MySql.Data.MySqlClient
Public Class frmStatistics
    Dim Connectionstring As String = "server=localhost;user id=root;password=;database=acmotorsdb"
    'This sets the connection string to the server which will host the database
    Dim Con As New MySqlConnection
    Dim Part_ID, Vehicle_ID As Integer
    Dim Make As String
    Dim First, Last, PivotValue, LeftPointer, RightPointer, Left1, Right1, Pivot, FirstValue As Integer

    Private Sub Statistics_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
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

    Public Sub InvoiceTotal()
        Dim DateNow As Date = FormatDateTime(Date.Now, DateFormat.ShortDate)
        Dim DateThen As Date = DateNow.AddMonths(-1)
        Dim Start As Date = DateThen
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable
        Dim Row As Integer = 0
        Dim TotalInvoices As Integer = 0
        Dim SQLStatementSelect As String
        Dim Total As Decimal = 0
        Do
            SQLStatementSelect = "SELECT Invoice_Total, Date FROM Invoice WHERE Date = '" & CStr(Start) & "'"
            'This selects all the invoices which were created on a certain date. As it loops, it will retrieve all the invoices which have been created over the past month.
            Try
                Adapter = New MySqlDataAdapter(SQLStatementSelect, Con)
                Table = New DataTable
                Adapter.Fill(Table)
                dgvHidden.DataSource = Table
                'This fills the data grid view with the totals of each every invoice that was created on that date
            Catch ex As Exception
                MsgBox(ex.ToString)
                'This message box will only appear if it cannot connect to the database. This will only happen if the server is canceled whilst the system is running.
            End Try
            If dgvHidden.RowCount <> 0 Then
                'If the data grid view has anything in it then this will be ran
                Row = 0
                Do Until Row = dgvHidden.RowCount
                    Total = Total + dgvHidden.Rows(Row).Cells(0).Value
                    'This loops round adding all of the totals together
                    TotalInvoices = TotalInvoices + 1
                    'This counts how many invoices there have been during the last month
                    Row = Row + 1
                    'This moves to the next row. It will loop until it has reached the last row.
                Loop
                Do Until dgvHidden.RowCount = 0
                    dgvHidden.Rows.Remove(dgvHidden.Rows(0))
                    'This deletes the top row and loops until they have all been deleted
                Loop
            End If
            Start = Start.AddDays(+1)
            'This moves to the next day and will loop until it has searched for everyday in the last month.
        Loop Until Start = DateNow.AddDays(1)
        If TotalInvoices = 0 Then
            'If the searches have not retrieved any invoices then this message will be displayed
            MessageBox.Show("There are currently no invoices saved on the database. You must create at least one invoice for this to work.", _
"Change Date?", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Exit Sub
        End If
        txtTotal.Text = FormatCurrency(Total, 2)
        'Displays the total of all the invoice totals added together.
        txtTotalInvs.Text = TotalInvoices
        'This displays the total number of invoices this month.
        txtAvgIT.Text = "" & FormatCurrency((Total / TotalInvoices), 2) & ""
        'This calculates the average invoice total by dividing the total of all the invoices by how many invoices there were.
    End Sub

    Public Sub LabourTotal()
        Dim DateNow As Date = FormatDateTime(Date.Now, DateFormat.ShortDate)
        Dim DateThen As Date = DateNow.AddMonths(-1)
        Dim Start As Date = DateThen
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable
        Dim Row As Integer = 0
        Dim TotalInvoices As Integer = 0
        Dim SQLStatementSelect As String
        Dim Total As Decimal = 0
        Do
            SQLStatementSelect = "SELECT Labour_Total, Date FROM Invoice WHERE Date = '" & CStr(Start) & "'"
            'This selects the Labour totals of all the invoices on that date.
            Try
                Adapter = New MySqlDataAdapter(SQLStatementSelect, Con)
                Table = New DataTable
                Adapter.Fill(Table)
                dgvHidden.DataSource = Table
                'This fills the table with the results from the above query.
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            If dgvHidden.RowCount <> 0 Then
                'If the query retrieves any invoices then this code is ran
                Row = 0
                'Sets the loop to start at the first row.
                Do Until Row = dgvHidden.RowCount
                    Total = Total + dgvHidden.Rows(Row).Cells(0).Value
                    'This adds up all the labor totals that are retrieved from the above query.
                    TotalInvoices = TotalInvoices + 1
                    'This counts the number invoices that have been retrieved.
                    Row = Row + 1
                    'This moves to the next row.
                Loop
                'This will loop until all of the invoices retrieved have been counted.
                Do Until dgvHidden.RowCount = 0
                    dgvHidden.Rows.Remove(dgvHidden.Rows(0))
                Loop
                'This deletes the contents of the table, ready for the next date.
            End If
            Start = Start.AddDays(+1)
            'This increments the date y 1 day.
        Loop Until Start = DateNow.AddDays(1)
        'This will loop until every day for the past month has been searched.
        If TotalInvoices = 0 Then
            'If there has not been any invoices over the last month, this code will be ran. There is no message box displayed as the previous sub will show the message box.
            Exit Sub
        End If
        txtAvgLC.Text = "" & FormatCurrency(Total / TotalInvoices) & ""
        'This displays the average labour total in the relevant text box
    End Sub

    Public Sub MostCommonPart()
        Dim Adapter As MySqlDataAdapter
        Dim Table As DataTable
        Dim SQLStatementSelect As String
        Dim Count As Integer = 1
        Dim Row As Integer = 0
        Dim Row2 As Integer = 0
        Do
            SQLStatementSelect = "SELECT Part_Name, Quantity, invoice_component.Part_ID FROM part, invoice_component WHERE invoice_component.part_ID = part.part_ID AND Invoice_ID = '" & Count & "'"
            'This query selects all the parts used in that invoice
            SQLSelectPart(SQLStatementSelect)
            'This calls the sub called SQLSelectPart. It is used to see if there are any parts stored under the current Invoice_ID. If it does not return any values then it means that the loop has reached the last invoice.
            Try
                Adapter = New MySqlDataAdapter(SQLStatementSelect, Con)
                Table = New DataTable
                Adapter.Fill(Table)
                dgvHidden.DataSource = Table
                'This fills the table with all the parts and relative quantities that were stored under the current invoice.
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Row = 0
            Do Until Row = dgvHidden.RowCount
                'This loops between all the rows in the list of parts retrieved.
                Row2 = 0
                Do Until Row2 = dgvHidden2.RowCount + 1
                    'This loops between all the rows in the tally table. 
                    If dgvHidden2.Rows(Row2).Cells(0).Value Is Nothing Then
                        'If the tally table is empty then it creates the first line in the tally table and sets the tally to the quantity stored with that part.
                        dgvHidden2.Rows.Add("" & dgvHidden.Rows(Row).Cells(0).Value & "", "" & dgvHidden.Rows(Row).Cells(1).Value & "")
                        Exit Do
                    End If
                    'If the tally has already been started, then it will loop through the tally table finding the same part in the list. If it finds the same part then it will add the quantity saved with it to the tally associated with that part. If it reaches the last line and it has not yet found the same part in the tally table then a new row is added for that part with the tally set as the same as the quantity for that part.
                    If dgvHidden.Rows(Row).Cells(0).Value = dgvHidden2.Rows(Row2).Cells(0).Value Then
                        dgvHidden2.Rows(Row2).Cells(1).Value = CInt(dgvHidden2.Rows(Row2).Cells(1).Value + dgvHidden.Rows(Row).Cells(1).Value)
                        Exit Do
                    ElseIf Row2 = dgvHidden2.RowCount And dgvHidden.Rows(Row).Cells(0).Value <> dgvHidden2.Rows(Row2).Cells(0).Value Then
                        dgvHidden2.Rows.Add("" & dgvHidden.Rows(Row).Cells(0).Value & "", "" & dgvHidden.Rows(Row).Cells(1).Value & "")
                        Exit Do
                    End If
                    Row2 = Row2 + 1
                Loop
                Row = Row + 1
            Loop
            Do Until dgvHidden.RowCount = 0
                dgvHidden.Rows.Remove(dgvHidden.Rows(0))
            Loop
            'This deletes the contents of the first table, ready for the next invoice.
            Count = Count + 1
            'This increments count by 1 and in turn moves to the next invoice.
        Loop Until Part_ID = Nothing
        'This will loop until it has completed the last invoice created

        If dgvHidden2.RowCount = 0 Then
            'If the search does not retrive any invoices then this code will be ran.
            Exit Sub
        End If

        dgvHidden2.Sort(dgvHidden2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'This sorts the contents off the tally table in ascending order with relation to the tally column. It uses a method called sort compare.
        txtMostPU.Text = dgvHidden2.Rows(0).Cells(0).Value
        'This sets the text box for the most common part to the top part in the tally table.
        Do Until dgvHidden2.RowCount = 1
            dgvHidden2.Rows.Remove(dgvHidden2.Rows(0))
            'This deletes the contents of the tally chart, ready for the next sub routine. 
        Loop

    End Sub

    Public Sub MostCommonCar()
        Dim SQLStatementSelect As String
        Dim Count As Integer = 1
        Dim Row2 As Integer
        Do
            SQLStatementSelect = "SELECT Make, vehicle.Vehicle_ID FROM Vehicle, Invoice WHERE vehicle.Vehicle_ID = invoice.Vehicle_ID AND Invoice_ID = '" & Count & "'"
            SQLSelectCar(SQLStatementSelect)
            'This selects the vehicle used in the invoice with that invoice_ID
            Row2 = 0
            'This sets the loop to start at the top row of the tally table
            Do Until Row2 = dgvHidden2.RowCount + 1
                'This will loop until it has reached the last row of the tally table
                If dgvHidden2.Rows(Row2).Cells(0).Value Is Nothing Then
                    dgvHidden2.Rows.Add("" & Make & "", "1")
                    'If the tally table is empty then it creates the first line in the tally table and sets the tally to 1 with that make.
                    'It will then exit this loop and carry on to the next invoice.
                    Exit Do
                End If

                If Make = dgvHidden2.Rows(Row2).Cells(0).Value Then
                    'If the tally has alrady been started and the loop finds a match, it will then add 1 to that tally and move to the next invoice.
                    dgvHidden2.Rows(Row2).Cells(1).Value = CInt(dgvHidden2.Rows(Row2).Cells(1).Value + 1)
                    Exit Do
                ElseIf Row2 = dgvHidden2.RowCount And Make <> dgvHidden2.Rows(Row2).Cells(0).Value Then
                    dgvHidden2.Rows.Add("" & Make & "", "1")
                    'If the loop reaches the last row and has not found a match then it will start a new line with a tally of one. The system will then move on to the next invoice.
                    Exit Do
                End If
                Row2 = Row2 + 1
                'This increments row2 by 1 to move to the next row of the tally table
            Loop
            Count = Count + 1
            'This increments count by 1 to move on to the next invoice
            'This will loop until it has reached and completed the last invoice
        Loop Until Vehicle_ID = Nothing

        If dgvHidden2.RowCount = 0 Then
            Exit Sub
            'If the search does not retrive any invoices then this code will be ran.
        End If

        dgvHidden2.Sort(dgvHidden2.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
        'This sorts the contents off the tally table in ascending order with relation to the tally column. It uses a method called sort compare.
        txtMostCC.Text = dgvHidden2.Rows(0).Cells(0).Value
        'This sets the text box for the most common car make to the top car make in the tally table.
        Do Until dgvHidden2.RowCount = 1
            dgvHidden2.Rows.Remove(dgvHidden2.Rows(0))
            'This deletes the contents of the tally chart, ready for the next sub routine. 
        Loop

    End Sub

    Public Sub SQLSelectPart(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader

        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader
        While SQLdr.Read
            'This code will only be ran if the query returns a value
            Part_ID = SQLdr("Part_ID")
            SQLdr.Close()
            Exit Sub
        End While
        'This code will only be ran if the query does not return any values.
        SQLdr.Close()
        Part_ID = Nothing
        'This is used to determine whether or not the loop has reached the last invoice
    End Sub

    Public Sub SQLSelectCar(ByRef SQLStatementSelect As String)
        Dim SQLCmd As New MySqlCommand
        Dim SQLdr As MySqlDataReader
        SQLCmd.Connection = Con
        SQLCmd.CommandText = SQLStatementSelect
        SQLdr = SQLCmd.ExecuteReader
        While SQLdr.Read
            'This code will only be ran if the query returns a value
            Vehicle_ID = SQLdr("Vehicle_ID")
            Make = SQLdr("Make")
            SQLdr.Close()
            Exit Sub
        End While
        'This code will only be ran if the query does not return any values.
        SQLdr.Close()
        Vehicle_ID = Nothing
        Make = Nothing
        'This is used to determine whether or not the loop has reached the last invoice
    End Sub

    Private Sub btnGenerate_Click(sender As System.Object, e As System.EventArgs) Handles btnGenerate.Click
        InvoiceTotal()
        LabourTotal()
        MostCommonPart()
        MostCommonCar()
        'When the generate button is pressed, these sub routines are ran which will calulate their own averages
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'This closes the statistics form and will return the user to the menu form
    End Sub

    Private Sub Statistics_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        frmMenu.Show()
        'If the user closes the form by either pressing the back button of the x button they will be returned to the menu form.
    End Sub

    Private Sub dgvHidden2_SortCompare(sender As Object, e As System.Windows.Forms.DataGridViewSortCompareEventArgs) Handles dgvHidden2.SortCompare
        Dim intval1, intval2 As Integer
        'This sorts the contents of a table by comparing values of neighbouring values repeatedly until it is in the correct order.

        If Not Integer.TryParse(e.CellValue1.ToString, intval1) Then Return
        If Not Integer.TryParse(e.CellValue2.ToString, intval2) Then Return

        If intval1 = intval2 Then
            e.SortResult = 0
        ElseIf intval1 > intval2 Then
            e.SortResult = -1
        Else
            e.SortResult = 1
        End If
        e.Handled = True

    End Sub
End Class