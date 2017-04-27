<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Volume_3_Pyramid
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
        Me.TriangleAreaButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BaseAreaTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.VolumeTextBox = New System.Windows.Forms.TextBox()
        Me.CircleButton = New System.Windows.Forms.Button()
        Me.RectangleButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1526, 32)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "To find the area of a pyramid or cone, multiply the area of the base by the heigh" &
    "t of the pyramid or cone, then divide by 3."
        '
        'TriangleAreaButton
        '
        Me.TriangleAreaButton.Location = New System.Drawing.Point(1072, 146)
        Me.TriangleAreaButton.Name = "TriangleAreaButton"
        Me.TriangleAreaButton.Size = New System.Drawing.Size(192, 82)
        Me.TriangleAreaButton.TabIndex = 18
        Me.TriangleAreaButton.Text = "Triangle Area"
        Me.TriangleAreaButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(63, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(738, 32)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "To find the area of the base, click one of these button  --->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(202, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 32)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Area of Base:"
        '
        'BaseAreaTextBox
        '
        Me.BaseAreaTextBox.Location = New System.Drawing.Point(409, 308)
        Me.BaseAreaTextBox.Name = "BaseAreaTextBox"
        Me.BaseAreaTextBox.Size = New System.Drawing.Size(342, 38)
        Me.BaseAreaTextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 408)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(346, 32)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Height of pyramid or cone:"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(409, 402)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(342, 38)
        Me.HeightTextBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 568)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(360, 32)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Volume of pyramid or cone:"
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.Location = New System.Drawing.Point(409, 568)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.ReadOnly = True
        Me.VolumeTextBox.Size = New System.Drawing.Size(342, 38)
        Me.VolumeTextBox.TabIndex = 25
        Me.VolumeTextBox.TabStop = False
        '
        'CircleButton
        '
        Me.CircleButton.Location = New System.Drawing.Point(844, 146)
        Me.CircleButton.Name = "CircleButton"
        Me.CircleButton.Size = New System.Drawing.Size(192, 82)
        Me.CircleButton.TabIndex = 26
        Me.CircleButton.Text = "Circle Area"
        Me.CircleButton.UseVisualStyleBackColor = True
        '
        'RectangleButton
        '
        Me.RectangleButton.Location = New System.Drawing.Point(1300, 146)
        Me.RectangleButton.Name = "RectangleButton"
        Me.RectangleButton.Size = New System.Drawing.Size(192, 82)
        Me.RectangleButton.TabIndex = 27
        Me.RectangleButton.Text = "Rectangle Area"
        Me.RectangleButton.UseVisualStyleBackColor = True
        '
        'Volume_3_Pyramid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.RectangleButton)
        Me.Controls.Add(Me.CircleButton)
        Me.Controls.Add(Me.VolumeTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HeightTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BaseAreaTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TriangleAreaButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Volume_3_Pyramid"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TriangleAreaButton, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.BaseAreaTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.HeightTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.VolumeTextBox, 0)
        Me.Controls.SetChildIndex(Me.CircleButton, 0)
        Me.Controls.SetChildIndex(Me.RectangleButton, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TriangleAreaButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BaseAreaTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents HeightTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents VolumeTextBox As TextBox
    Friend WithEvents CircleButton As Button
    Friend WithEvents RectangleButton As Button
End Class
