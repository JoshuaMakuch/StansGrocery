'Joshua Makuch
'RCET 0265
'Spring 2023
'Stan's Grocery
'https://github.com/JoshuaMakuch/StansGrocery

Option Strict On
Option Explicit On

Public Class StansGroceryForm

    'Creats a raw data array containing any data when written to
    Dim rawDataArray() As String
    'Creates a proccessed (food) data array whose row count is the size of the raw data array with three total columns (food, location, and descrption) when written to
    Dim food(0, 2) As String
    'This stores an array with a listbox after the search button is clicked for use in filtering
    Dim searchArrayStorage As String()

    'Form Events---------------------------------------------------------------------------------------------------------------------------------------------------------------

    'On form load
    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Finds a new file based on what the user selects
        FindNewFileToolStripMenuItem_Click(sender, e)

    End Sub

    'When the user closes the main form, it closes the program and main form
    Private Sub StansGroceryForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed, ExitToolStripMenuItem1.Click, ExitToolStripMenuItem.Click
        SplashScreenForm.Close()
    End Sub

    'When the user presses the exit button
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        SplashScreenForm.Close()
    End Sub

    'About Tool Strip Menu Button
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Me.Hide()
        AboutForm.Show()
    End Sub

    'This is what happens when the user uses the find new file button in the menu strip
    Private Sub FindNewFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindNewFileToolStripMenuItem.Click

        'This ensures the user cant crash the program
        EnableEverything(False)

        Dim fileFound As Boolean = False

        Do Until fileFound
            'Opens the file dialog so the user can choose the data file
            If OpenFileDialog.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
                Try
                    rawDataArray = Split(My.Computer.FileSystem.ReadAllText(OpenFileDialog.FileName), vbCrLf)
                    ReDim food(rawDataArray.Length - 1, 2)
                    EnableEverything(True)
                    fileFound = True
                Catch ex As Exception
                    If MessageBox.Show("File Not Found, do you want to try again?", "Try Again?", MessageBoxButtons.YesNo) = DialogResult.No Then
                        SplashScreenForm.Close()
                        Me.Close()
                        Exit Sub
                    End If
                End Try
            Else
                If MessageBox.Show("File Not Found, do you want to try again?", "Try Again?", MessageBoxButtons.YesNo) = DialogResult.No Then
                    SplashScreenForm.Close()
                    Me.Close()
                    Exit Sub
                End If
            End If
        Loop

        FillListBox()

    End Sub

    'This is what happens when the search function is pressed
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click, SearchToolStripMenuItem.Click, SearchToolStripMenuItem1.Click

        'Clears the current list box to fit new data
        DisplayListBox.Items.Clear()

        'Iterate through all possible options
        For i As Integer = 0 To rawDataArray.Length - 1

            'If the search character is in the data then add item, also compare method "text" is not case sensitive
            If InStr(1, food(i, 0), SearchTextBox.Text, CompareMethod.Text) > 0 Then

                DisplayListBox.Items.Add(food(i, 0))

            End If

        Next

        'This sorts the list box alphabetically
        DisplayListBox.Sorted = True

        'This stores search result into an array for use in filtering
        searchArrayStorage = DisplayListBox.Items.OfType(Of String).ToArray

        'This sets aisle button to be true
        AisleRadioButton.Checked = True
        AisleRadioButton_Click(sender, e)

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

    'When the user presses the aisle radio button
    Private Sub AisleRadioButton_Click(sender As Object, e As EventArgs) Handles AisleRadioButton.Click

        'Clears all items in a combo box except the "View All" Option
        FilterComboBox.Items.Clear()
        FilterComboBox.Items.Add("View All")

        For i As Integer = 0 To DisplayListBox.Items.Count - 1 'For each item in the list box
            For n As Integer = 0 To rawDataArray.Length - 1 'For each item in the whole data set
                'When the item is found in the food array and the fitler type isnt already in the filter combo box item list, then add the filter option to the combo box list
                If food(n, 0) Is DisplayListBox.Items(i) And Not FilterComboBox.Items.Contains(food(n, 1)) Then
                    FilterComboBox.Items.Add(food(n, 1))
                End If
            Next
        Next
        FilterComboBox.Refresh()
    End Sub

    'When the user presses the category radio button
    Private Sub CategoryRadioButton_Click(sender As Object, e As EventArgs) Handles CategoryRadioButton.Click

        'Clears all items in a combo box except the "View All" Option
        FilterComboBox.Items.Clear()
        FilterComboBox.Items.Add("View All")


        For i As Integer = 0 To DisplayListBox.Items.Count - 1 'For each item in the list box
            For n As Integer = 0 To rawDataArray.Length - 1 'For each item in the whole data set
                'When the item is found in the food array and the fitler type isnt already in the filter combo box item list, then add the filter option to the combo box list
                If food(n, 0) Is DisplayListBox.Items(i) And Not FilterComboBox.Items.Contains(food(n, 2)) Then
                    FilterComboBox.Items.Add(food(n, 2))
                End If
            Next
        Next
        FilterComboBox.Refresh()
    End Sub

    'When the user chooses a filter combo box item and commits to it
    Private Sub FilterComboBox_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles FilterComboBox.SelectionChangeCommitted

        'Clears the list box of items to be able to store new values
        DisplayListBox.Items.Clear()

        'The reason the conversion to string is needed is because in order to find the selected filter combo box text, you must find the selected index and find the item
        'matching said index (.selected text doesnt work, it acts like a que and pulls the old selected text rather than the newest one).
        If CStr(FilterComboBox.Items(FilterComboBox.SelectedIndex)) = "View All" Then 'If View all is selected, then refill the list box with the search array storage
            DisplayListBox.Items.AddRange(searchArrayStorage) 'Adds the entire array of search array storage
        Else 'If not view all then only display list box items who have matched the aisle/category
            For i As Integer = 0 To searchArrayStorage.Length - 1 'For each item in the original stored array
                For n As Integer = 0 To rawDataArray.Length - 1 'For each item in the total raw data array
                    If food(n, 0) = searchArrayStorage(i) And food(n, 1) = CStr(FilterComboBox.Items(FilterComboBox.SelectedIndex)) Then
                        DisplayListBox.Items.Add(searchArrayStorage(i)) 'Add the item if it's aisle matches the new combo box filter
                    ElseIf food(n, 0) = searchArrayStorage(i) And food(n, 2) = CStr(FilterComboBox.Items(FilterComboBox.SelectedIndex)) Then
                        DisplayListBox.Items.Add(searchArrayStorage(i)) 'Add the item if it's category matches the new combo box filter
                    End If
                Next
            Next
        End If

        DisplayListBox.Sorted = True 'Sort alphabetically

    End Sub


    'Custom Subs---------------------------------------------------------------------------------------------------------------------------------------------------------------

    'This enables or disables all controls to prevent user-induced control errors
    Sub EnableEverything(enableEverything As Boolean)

        SearchGroupBox.Enabled = enableEverything
        FilterGroupBox.Enabled = enableEverything
        MainMenuStrip.Enabled = enableEverything
        ContextMenuStrip1.Enabled = enableEverything

    End Sub

    'This fills the list box with the original data set
    Sub FillListBox()

        'This clears the list box and sets radio button
        DisplayListBox.Items.Clear()

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

        'This sorts the list box by alphabetical
        DisplayListBox.Sorted = True

    End Sub

End Class
