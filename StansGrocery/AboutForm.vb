'Joshua Makuch
'RCET 0265
'Spring 2023
'Stan's Grocery
'https://github.com/JoshuaMakuch/StansGrocery

Option Strict On
Option Explicit On

Public Class AboutForm

    'Closes the about form and re-opens the main form
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click

        StansGroceryForm.Show()
        Me.Hide()

    End Sub

    'Closes the about form and re-opens the main form in case the user doesn't use the exit button
    Private Sub AboutForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        StansGroceryForm.Show()
        Me.Hide()

    End Sub

End Class