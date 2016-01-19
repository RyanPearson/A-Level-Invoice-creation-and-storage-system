Public Class frmMenu
    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        frmCreateInv.Show()
        Me.Hide()
        'This opens the createinvoice form and hides the menu form
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        frmSearch.Show()
        Me.Hide()
        'This opens the search form and hides the menu form
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        'When the exit button is pressed then the menu form is closed, ending the program.
    End Sub

    Private Sub btnSettings_Click(sender As System.Object, e As System.EventArgs) Handles btnSettings.Click
        frmSettings.Show()
        Me.Hide()
        'This opens the settings form and hides the menu form.
    End Sub

    Private Sub btnStats_Click(sender As System.Object, e As System.EventArgs) Handles btnStats.Click
        frmStatistics.Show()
        Me.Hide()
        'This opens the statistics form and hides the menu form.
    End Sub
End Class
