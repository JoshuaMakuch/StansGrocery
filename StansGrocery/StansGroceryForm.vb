Option Strict On
Option Explicit On
'Joshua Makuch
'RCET 0265
'Spring 2023
'Stan's Grocery
'https://github.com/JoshuaMakuch/StansGrocery

Public Class StansGroceryForm

    'Creats a raw data array containing all data split up by any carriage line feeds
    Dim rawDataArray() As String = Split(My.Resources.Grocery, vbCrLf)
    'Creates a proccessed (food) data array whose row count is the size of the raw data array with three total columns (food, location, and descrption)
    Dim food(rawDataArray.Length - 1, 2) As String

    'On form load
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'This will be used to split each raw data array line
        Dim temp() As String

        'This will begin processing the raw data and storing everything in the food array
        For i As Integer = 0 To rawDataArray.Length - 1

            'Removes quotations from the raw data array and temporarlily stores data using a comma as a delimeter
            rawDataArray(i) = rawDataArray(i).Replace("""", "")
            temp = Split(rawDataArray(i), ",")

            'In the event the item name, location, And category get mixed per line, this Is used to specifically ensure the correct data Is placed in the correct array slot
            For n As Integer = 0 To temp.Length - 1

                If temp(n).Contains("$$ITM") Then

                    temp(n) = temp(n).Replace("$$ITM", "") 'item name is stored in array column 0
                    If temp(n) = "" Then
                        temp(n) = "N/A"
                    End If
                    food(i, 0) = temp(n)

                ElseIf temp(n).Contains("##LOC") Then

                    temp(n) = temp(n).Replace("##LOC", "") 'item location is stored in array column 1
                    If temp(n) = "" Then
                        temp(n) = "N/A"
                    End If
                    food(i, 1) = temp(n)

                ElseIf temp(n).Contains("%%CAT") Then

                    temp(n) = temp(n).Replace("%%CAT", "") 'item category is stored in array column 2
                    If temp(n) = "" Then
                        temp(n) = "N/A"
                    End If
                    food(i, 2) = temp(n)

                Else 'Item is filled with empties rather than nulls in the event the category or location doesnt exist

                    food(i, 0) = "N/A"
                    food(i, 1) = "N/A"
                    food(i, 2) = "N/A"

                End If

            Next

            'This displays all items on startup
            DisplayListBox.Items.Add(food(i, 0))

        Next
    End Sub

    'When the user closes the main form, it closes the program and main form
    Private Sub StansGroceryForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed, ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        SplashScreenForm.Close()
    End Sub

    'About Tool Strip Menu Button
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    'This is what happens when the user selects a list box item
    Private Sub DisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DisplayListBox.SelectedIndexChanged

        'Stores the choosen item when picked and informs the user on the item's whereabouts
        Dim listChoosenStr As String = DisplayListBox.Text

        'Searches the food list for that specific food item and displays the known data on it
        For i As Integer = 0 To rawDataArray.Length - 1

            If listChoosenStr = food(i, 0) Then

                DisplayTextBox.Text = $"You will find '{food(i, 0)}' on aisle '{food(i, 1)}' with the '{food(i, 2)}'."

            End If

        Next
    End Sub

End Class
