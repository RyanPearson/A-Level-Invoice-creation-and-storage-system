Public Class frmSettings
    Dim Opened As Boolean = False
    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'This closes the settings form and will open the menu form
    End Sub

    Private Sub frmSettings_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        If Opened = False Then
            'If the settings form has been closed by pressing the back button or the x button then this code will be ran
            frmMenu.Show()
            'This opens the menu form
        End If
    End Sub

    Private Sub btnChangeVAT_Click(sender As System.Object, e As System.EventArgs) Handles btnChangeVAT.Click
        frmChangeVAT.Show()
        Opened = True
        Me.Close()
        'This opens the change VAT form and closes the current form. the menu form is not opened because the opened state is set to true before the form is closed.
    End Sub

    Private Sub btnAddPart_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPart.Click
        frmCreatePart.Show()
        Opened = True
        Me.Close()
        'This opens the Create Part form and closes the current form. the menu form is not opened because the opened state is set to true before the form is closed.
    End Sub

    Private Sub btnEditC_Click(sender As System.Object, e As System.EventArgs) Handles btnEditC.Click
        frmSearchFC.Show()
        frmSearchFC.lblEditCustomer.Text = "1"
        Opened = True
        Me.Close()
        'This opens the Search for customer form and closes the current form. the menu form is not opened because the opened state is set to true before the form is closed.
        'It will also set lblEditCustomer in the Search of customer form to 1, causing the selected customer to be sent to the edit customer form.
    End Sub
End Class