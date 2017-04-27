<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Area_Rectangle
    Inherits Math_helper.BaseForm

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WidthTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LengthLabel = New System.Windows.Forms.Label()
        Me.WidthLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(132, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Length:"
        '
        'LengthTextBox
        '
        Me.LengthTextBox.Location = New System.Drawing.Point(249, 303)
        Me.LengthTextBox.Name = "LengthTextBox"
        Me.LengthTextBox.Size = New System.Drawing.Size(404, 38)
        Me.LengthTextBox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(147, 394)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 32)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Width:"
        '
        'WidthTextBox
        '
        Me.WidthTextBox.Location = New System.Drawing.Point(249, 394)
        Me.WidthTextBox.Name = "WidthTextBox"
        Me.WidthTextBox.Size = New System.Drawing.Size(404, 38)
        Me.WidthTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(1349, 46)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "To calculate the area of a rectangle, multiple the Length (l) by the width (w)."
        '
        'LengthLabel
        '
        Me.LengthLabel.AutoSize = True
        Me.LengthLabel.Location = New System.Drawing.Point(108, 788)
        Me.LengthLabel.Name = "LengthLabel"
        Me.LengthLabel.Size = New System.Drawing.Size(52, 32)
        Me.LengthLabel.TabIndex = 10
        Me.LengthLabel.Text = "l = "
        '
        'WidthLabel
        '
        Me.WidthLabel.AutoSize = True
        Me.WidthLabel.Location = New System.Drawing.Point(108, 854)
        Me.WidthLabel.Name = "WidthLabel"
        Me.WidthLabel.Size = New System.Drawing.Size(65, 32)
        Me.WidthLabel.TabIndex = 11
        Me.WidthLabel.Text = "w = "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(160, 506)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 32)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(249, 500)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.ReadOnly = True
        Me.AreaTextBox.Size = New System.Drawing.Size(404, 38)
        Me.AreaTextBox.TabIndex = 17
        Me.AreaTextBox.TabStop = False
        '
        'Area_Rectangle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WidthLabel)
        Me.Controls.Add(Me.LengthLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.WidthTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LengthTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Area_Rectangle"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LengthTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.WidthTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.LengthLabel, 0)
        Me.Controls.SetChildIndex(Me.WidthLabel, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.AreaTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LengthTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents WidthTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LengthLabel As Label
    Friend WithEvents WidthLabel As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AreaTextBox As TextBox
End Class
