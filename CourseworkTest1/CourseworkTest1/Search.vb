Public Class frmSearch
    Dim Opened As Boolean = False
    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        Me.Close()
        'this closes the search form and because the opened boolean is still false, the menu form is opened.
    End Sub

    Private Sub btnSearchCD_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchCD.Click
        frmSearchCD.Show()
        Opened = True
        Me.Close()
        'This opens the search by customer and data from and closes the search form. The menu form is not opened because the opened boolean is set to true.
    End Sub

    Private Sub frmSearch_Close(sender As System.Object, e As System.EventArgs) Handles MyBase.FormClosing
        If Opened = False Then
            frmMenu.Show()
            'This will only be ran if the form was closed by either pressing the x button or the main menu button.
        End If
    End Sub

    Private Sub btnSearchVD_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchVD.Click
        frmSearchVD.Show()
        Opened = True
        Me.Close()
        'This opens the search by vehicle and data from and closes the search form. The menu form is not opened because the opened boolean is set to true.
    End Sub
End Class