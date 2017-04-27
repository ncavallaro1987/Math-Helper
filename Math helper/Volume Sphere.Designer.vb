<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Volume_Sphere
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
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VolumeTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1492, 46)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "To calculate the volume of a sphere, multiply (4/3) by pi (~3.14) by the radius c" &
    "ubed."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Radius:"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.Location = New System.Drawing.Point(243, 245)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(318, 38)
        Me.RadiusTextBox.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 343)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 32)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Volume:"
        '
        'VolumeTextBox
        '
        Me.VolumeTextBox.Location = New System.Drawing.Point(243, 343)
        Me.VolumeTextBox.Name = "VolumeTextBox"
        Me.VolumeTextBox.ReadOnly = True
        Me.VolumeTextBox.Size = New System.Drawing.Size(318, 38)
        Me.VolumeTextBox.TabIndex = 21
        Me.VolumeTextBox.TabStop = False
        '
        'Volume_Sphere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.VolumeTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RadiusTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Volume_Sphere"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.RadiusTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.VolumeTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents VolumeTextBox As TextBox
End Class
