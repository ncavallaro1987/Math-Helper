<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Distance_Convert
    Inherits Math_helper.BaseForm

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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConvertFromComboBox = New System.Windows.Forms.ComboBox()
        Me.ConvertToComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MultiplierTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StartDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EndDistanceTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 32)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Convert from:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(456, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Convert to:"
        '
        'ConvertFromComboBox
        '
        Me.ConvertFromComboBox.FormattingEnabled = True
        Me.ConvertFromComboBox.Items.AddRange(New Object() {"Inches", "Feet", "Yards", "Miles", "Millimeters", "Centimeters", "Meters", "Kilometers"})
        Me.ConvertFromComboBox.Location = New System.Drawing.Point(51, 304)
        Me.ConvertFromComboBox.Name = "ConvertFromComboBox"
        Me.ConvertFromComboBox.Size = New System.Drawing.Size(326, 39)
        Me.ConvertFromComboBox.TabIndex = 19
        '
        'ConvertToComboBox
        '
        Me.ConvertToComboBox.FormattingEnabled = True
        Me.ConvertToComboBox.Items.AddRange(New Object() {"Inches", "Feet", "Yards", "Miles", "Millimeters", "Centimeters", "Meters", "Kilometers"})
        Me.ConvertToComboBox.Location = New System.Drawing.Point(462, 304)
        Me.ConvertToComboBox.Name = "ConvertToComboBox"
        Me.ConvertToComboBox.Size = New System.Drawing.Size(326, 39)
        Me.ConvertToComboBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(108, 827)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 32)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Multiplier:"
        '
        'MultiplierTextBox
        '
        Me.MultiplierTextBox.Location = New System.Drawing.Point(253, 827)
        Me.MultiplierTextBox.Name = "MultiplierTextBox"
        Me.MultiplierTextBox.ReadOnly = True
        Me.MultiplierTextBox.Size = New System.Drawing.Size(331, 38)
        Me.MultiplierTextBox.TabIndex = 22
        Me.MultiplierTextBox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(265, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Distance to convert:"
        '
        'StartDistanceTextBox
        '
        Me.StartDistanceTextBox.Location = New System.Drawing.Point(51, 147)
        Me.StartDistanceTextBox.Name = "StartDistanceTextBox"
        Me.StartDistanceTextBox.Size = New System.Drawing.Size(485, 38)
        Me.StartDistanceTextBox.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 432)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 32)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Distance after conversion:"
        '
        'EndDistanceTextBox
        '
        Me.EndDistanceTextBox.Location = New System.Drawing.Point(51, 487)
        Me.EndDistanceTextBox.Name = "EndDistanceTextBox"
        Me.EndDistanceTextBox.ReadOnly = True
        Me.EndDistanceTextBox.Size = New System.Drawing.Size(485, 38)
        Me.EndDistanceTextBox.TabIndex = 26
        '
        'Distance_Convert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.EndDistanceTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.StartDistanceTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MultiplierTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ConvertToComboBox)
        Me.Controls.Add(Me.ConvertFromComboBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Distance_Convert"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ConvertFromComboBox, 0)
        Me.Controls.SetChildIndex(Me.ConvertToComboBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.MultiplierTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.StartDistanceTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.EndDistanceTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConvertFromComboBox As ComboBox
    Friend WithEvents ConvertToComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MultiplierTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StartDistanceTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents EndDistanceTextBox As TextBox
End Class
