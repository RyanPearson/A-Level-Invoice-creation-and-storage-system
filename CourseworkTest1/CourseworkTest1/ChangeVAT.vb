Public Class frmChangeVAT
    Dim fileReader As String
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim Test As Decimal
        Try
            Test = txtVAT.Text + 1
            'This tests to see if the user has entered a numerical value for the new VAT percentage.
        Catch ex As Exception
            MessageBox.Show("The value you have entered into the VAT field must be numerical before you can save.", _
                "VAT must be numerical", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            'If it is not numerical then the new value is not saveda and this message box is displayed.
            Exit Sub
        End Try
        My.Settings.VAT = txtVAT.Text / 100
        'This writes the new value to the VAT setting
        lblVAT.Text = "" & CDec(My.Settings.VAT) * 100 & "%"
        'This displays the new value on lblVAT. This acts as a visual reference for the user so they can see that the new value has been saved.
    End Sub

    Private Sub frmChangeVAT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblVAT.Text = "" & CDec(My.Settings.VAT) * 100 & "%"
        'This displays the current value of VAT for the user to see.
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        Me.Close()
        'When this button is pressed VATChanged will be falst so the settings menu will be displayed
    End Sub

    Private Sub frmChangeVAT_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        frmSettings.Show()
        'When the user closes the form, either by pressing the back button on the x button. When this form closes the settings menu is opened again.
    End Sub
End Class