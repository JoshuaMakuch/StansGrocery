<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutForm))
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AboutLabel2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(604, 338)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(184, 100)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(28, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 207)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'AboutLabel2
        '
        Me.AboutLabel2.AutoSize = True
        Me.AboutLabel2.Location = New System.Drawing.Point(28, 319)
        Me.AboutLabel2.Name = "AboutLabel2"
        Me.AboutLabel2.Size = New System.Drawing.Size(423, 60)
        Me.AboutLabel2.TabIndex = 3
        Me.AboutLabel2.Text = "**THE USER CAN SWITCH WHICH TEXT FILE TO PULL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "THE DATA FROM USING THE TOP MENU S" &
    "TRIP > Find New File" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'AboutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.AboutLabel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ExitButton)
        Me.Name = "AboutForm"
        Me.Text = "AboutForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AboutLabel2 As Label
End Class
