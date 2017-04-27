<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Area_Triangle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BaseTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.BaseLabel = New System.Windows.Forms.Label()
        Me.HeightLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(295, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1005, 103)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "To find the area of a triangle multiply the base (b) by the height (h), then mult" &
    "iply the result by one half."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(167, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Base:"
        '
        'BaseTextBox
        '
        Me.BaseTextBox.Location = New System.Drawing.Point(275, 248)
        Me.BaseTextBox.Name = "BaseTextBox"
        Me.BaseTextBox.Size = New System.Drawing.Size(361, 38)
        Me.BaseTextBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 338)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Height:"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(275, 338)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(361, 38)
        Me.HeightTextBox.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(172, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(275, 519)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.ReadOnly = True
        Me.AreaTextBox.Size = New System.Drawing.Size(361, 38)
        Me.AreaTextBox.TabIndex = 11
        Me.AreaTextBox.TabStop = False
        '
        'BaseLabel
        '
        Me.BaseLabel.AutoSize = True
        Me.BaseLabel.Location = New System.Drawing.Point(108, 788)
        Me.BaseLabel.Name = "BaseLabel"
        Me.BaseLabel.Size = New System.Drawing.Size(47, 32)
        Me.BaseLabel.TabIndex = 14
        Me.BaseLabel.Text = "b="
        '
        'HeightLabel
        '
        Me.HeightLabel.AutoSize = True
        Me.HeightLabel.Location = New System.Drawing.Point(108, 837)
        Me.HeightLabel.Name = "HeightLabel"
        Me.HeightLabel.Size = New System.Drawing.Size(47, 32)
        Me.HeightLabel.TabIndex = 15
        Me.HeightLabel.Text = "h="
        '
        'Area_Triangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.HeightLabel)
        Me.Controls.Add(Me.BaseLabel)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BaseTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Area_Triangle"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.BaseTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.HeightTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.AreaTextBox, 0)
        Me.Controls.SetChildIndex(Me.BaseLabel, 0)
        Me.Controls.SetChildIndex(Me.HeightLabel, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BaseTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents BaseLabel As Label
    Friend WithEvents HeightLabel As Label
End Class
