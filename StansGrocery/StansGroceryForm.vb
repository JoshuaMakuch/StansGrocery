'Joshua Makuch
'RCET 0265
'Spring 2023
'Stan's Grocery
'https://github.com/JoshuaMakuch/StansGrocery

Option Strict On
Option Explicit On

Public Class StansGroceryForm

    'When the user closes the main form, it closes the program and main form
    Private Sub StansGroceryForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SplashScreenForm.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

End Class
