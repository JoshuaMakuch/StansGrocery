'Joshua Makuch
'RCET 0265
'Spring 2023
'Stan's Grocery Splash Screen
'https://github.com/JoshuaMakuch/StansGrocery

Option Strict On
Option Explicit On

Public NotInheritable Class SplashScreenForm
    Dim elapsedTime As Integer
    'Hides the splash screen when the user clicks on it
    Private Sub SplashScreenForm_Click(sender As Object, e As EventArgs) Handles Me.Click
        StansGroceryForm.Show()
        Me.Hide()
        SplashTimer.Enabled = False
    End Sub

    'This will automatically go from the splash screen to the main form after some time and changes the progress bar
    Private Sub SplashTimer_Tick(sender As Object, e As EventArgs) Handles SplashTimer.Tick
        SplashProgressBar.Increment(5)
        'This ensures the progress bar actually reaches the maximum value as if the 
        'if statement uses the value of the progress bar, it switches to the main form
        'too early
        If elapsedTime > 600 Then
            StansGroceryForm.Show()
            Me.Hide()
            SplashTimer.Enabled = False
        End If
        elapsedTime += 25
    End Sub

    'Ensures the splash screen timer is activated on load
    Private Sub SplashScreenForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        SplashTimer.Enabled = True
    End Sub

End Class