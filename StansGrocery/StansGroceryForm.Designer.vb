<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StansGroceryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SearchGroupBox = New System.Windows.Forms.GroupBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.FilterGroupBox = New System.Windows.Forms.GroupBox()
        Me.FilterComboBoxLabel = New System.Windows.Forms.Label()
        Me.FilterComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryRadioButton = New System.Windows.Forms.RadioButton()
        Me.AisleRadioButton = New System.Windows.Forms.RadioButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.DisplayListBoxLabel = New System.Windows.Forms.Label()
        Me.ItemInformationLabel = New System.Windows.Forms.Label()
        Me.DisplayTextBox = New System.Windows.Forms.TextBox()
        Me.MainMenuStrip.SuspendLayout()
        Me.SearchGroupBox.SuspendLayout()
        Me.FilterGroupBox.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenuStrip
        '
        Me.MainMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MainMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MainMenuStrip.Name = "MainMenuStrip"
        Me.MainMenuStrip.Size = New System.Drawing.Size(870, 28)
        Me.MainMenuStrip.TabIndex = 0
        Me.MainMenuStrip.Text = "MainMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(136, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SearchGroupBox
        '
        Me.SearchGroupBox.Controls.Add(Me.SearchButton)
        Me.SearchGroupBox.Controls.Add(Me.SearchLabel)
        Me.SearchGroupBox.Controls.Add(Me.SearchTextBox)
        Me.SearchGroupBox.Location = New System.Drawing.Point(11, 31)
        Me.SearchGroupBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SearchGroupBox.Name = "SearchGroupBox"
        Me.SearchGroupBox.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SearchGroupBox.Size = New System.Drawing.Size(477, 89)
        Me.SearchGroupBox.TabIndex = 2
        Me.SearchGroupBox.TabStop = False
        Me.SearchGroupBox.Text = "Search"
        Me.ToolTip1.SetToolTip(Me.SearchGroupBox, "Searchs the file and pulls up anything matching the search box value")
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(328, 22)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(119, 51)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "&Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Location = New System.Drawing.Point(9, 37)
        Me.SearchLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(53, 20)
        Me.SearchLabel.TabIndex = 3
        Me.SearchLabel.Text = "Search"
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Location = New System.Drawing.Point(66, 33)
        Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(234, 27)
        Me.SearchTextBox.TabIndex = 2
        '
        'FilterGroupBox
        '
        Me.FilterGroupBox.Controls.Add(Me.FilterComboBoxLabel)
        Me.FilterGroupBox.Controls.Add(Me.FilterComboBox)
        Me.FilterGroupBox.Controls.Add(Me.CategoryRadioButton)
        Me.FilterGroupBox.Controls.Add(Me.AisleRadioButton)
        Me.FilterGroupBox.Location = New System.Drawing.Point(493, 31)
        Me.FilterGroupBox.Name = "FilterGroupBox"
        Me.FilterGroupBox.Size = New System.Drawing.Size(360, 89)
        Me.FilterGroupBox.TabIndex = 3
        Me.FilterGroupBox.TabStop = False
        Me.FilterGroupBox.Text = "Filter"
        '
        'FilterComboBoxLabel
        '
        Me.FilterComboBoxLabel.AutoSize = True
        Me.FilterComboBoxLabel.Location = New System.Drawing.Point(172, 33)
        Me.FilterComboBoxLabel.Name = "FilterComboBoxLabel"
        Me.FilterComboBoxLabel.Size = New System.Drawing.Size(124, 20)
        Me.FilterComboBoxLabel.TabIndex = 7
        Me.FilterComboBoxLabel.Text = "Filter Combo Box"
        '
        'FilterComboBox
        '
        Me.FilterComboBox.FormattingEnabled = True
        Me.FilterComboBox.Location = New System.Drawing.Point(172, 55)
        Me.FilterComboBox.Name = "FilterComboBox"
        Me.FilterComboBox.Size = New System.Drawing.Size(165, 28)
        Me.FilterComboBox.TabIndex = 6
        '
        'CategoryRadioButton
        '
        Me.CategoryRadioButton.AutoSize = True
        Me.CategoryRadioButton.Location = New System.Drawing.Point(6, 59)
        Me.CategoryRadioButton.Name = "CategoryRadioButton"
        Me.CategoryRadioButton.Size = New System.Drawing.Size(147, 24)
        Me.CategoryRadioButton.TabIndex = 5
        Me.CategoryRadioButton.Text = "Filter By Category"
        Me.CategoryRadioButton.UseVisualStyleBackColor = True
        '
        'AisleRadioButton
        '
        Me.AisleRadioButton.AutoSize = True
        Me.AisleRadioButton.Checked = True
        Me.AisleRadioButton.Location = New System.Drawing.Point(6, 29)
        Me.AisleRadioButton.Name = "AisleRadioButton"
        Me.AisleRadioButton.Size = New System.Drawing.Size(119, 24)
        Me.AisleRadioButton.TabIndex = 4
        Me.AisleRadioButton.TabStop = True
        Me.AisleRadioButton.Text = "Filter By Aisle"
        Me.AisleRadioButton.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 52)
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(122, 24)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 20
        Me.DisplayListBox.Location = New System.Drawing.Point(11, 151)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(842, 224)
        Me.DisplayListBox.TabIndex = 4
        '
        'DisplayListBoxLabel
        '
        Me.DisplayListBoxLabel.AutoSize = True
        Me.DisplayListBoxLabel.Location = New System.Drawing.Point(11, 128)
        Me.DisplayListBoxLabel.Name = "DisplayListBoxLabel"
        Me.DisplayListBoxLabel.Size = New System.Drawing.Size(191, 20)
        Me.DisplayListBoxLabel.TabIndex = 5
        Me.DisplayListBoxLabel.Text = "Items Matching Description"
        '
        'ItemInformationLabel
        '
        Me.ItemInformationLabel.AutoSize = True
        Me.ItemInformationLabel.Location = New System.Drawing.Point(12, 387)
        Me.ItemInformationLabel.Name = "ItemInformationLabel"
        Me.ItemInformationLabel.Size = New System.Drawing.Size(121, 20)
        Me.ItemInformationLabel.TabIndex = 7
        Me.ItemInformationLabel.Text = "Item Information"
        '
        'DisplayTextBox
        '
        Me.DisplayTextBox.Location = New System.Drawing.Point(12, 410)
        Me.DisplayTextBox.Name = "DisplayTextBox"
        Me.DisplayTextBox.Size = New System.Drawing.Size(841, 27)
        Me.DisplayTextBox.TabIndex = 6
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 469)
        Me.Controls.Add(Me.ItemInformationLabel)
        Me.Controls.Add(Me.DisplayTextBox)
        Me.Controls.Add(Me.DisplayListBoxLabel)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.FilterGroupBox)
        Me.Controls.Add(Me.SearchGroupBox)
        Me.Controls.Add(Me.MainMenuStrip)
        Me.Name = "StansGroceryForm"
        Me.Text = "StansGroceryForm"
        Me.MainMenuStrip.ResumeLayout(False)
        Me.MainMenuStrip.PerformLayout()
        Me.SearchGroupBox.ResumeLayout(False)
        Me.SearchGroupBox.PerformLayout()
        Me.FilterGroupBox.ResumeLayout(False)
        Me.FilterGroupBox.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MainMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SearchGroupBox As GroupBox
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchTextBox As TextBox
    Friend WithEvents FilterGroupBox As GroupBox
    Friend WithEvents FilterComboBoxLabel As Label
    Friend WithEvents FilterComboBox As ComboBox
    Friend WithEvents CategoryRadioButton As RadioButton
    Friend WithEvents AisleRadioButton As RadioButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SearchToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents DisplayListBoxLabel As Label
    Friend WithEvents ItemInformationLabel As Label
    Friend WithEvents DisplayTextBox As TextBox
End Class
