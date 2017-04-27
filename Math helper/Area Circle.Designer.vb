<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Area_Circle
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadiusTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadiusLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(44, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(1403, 46)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "To calculate the area of a circle, multiply Pi (~3.14) times the radius (r) squar" &
    "ed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(242, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Radius:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(591, 32)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "The radius is equal to one half of the diameter"
        '
        'RadiusTextBox
        '
        Me.RadiusTextBox.Location = New System.Drawing.Point(371, 302)
        Me.RadiusTextBox.Name = "RadiusTextBox"
        Me.RadiusTextBox.Size = New System.Drawing.Size(316, 38)
        Me.RadiusTextBox.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 32)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Area:"
        '
        'AreaTextBox
        '
        Me.AreaTextBox.Location = New System.Drawing.Point(371, 415)
        Me.AreaTextBox.Name = "AreaTextBox"
        Me.AreaTextBox.ReadOnly = True
        Me.AreaTextBox.Size = New System.Drawing.Size(316, 38)
        Me.AreaTextBox.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(108, 788)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 32)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Pi = 3.14159265..."
        '
        'RadiusLabel
        '
        Me.RadiusLabel.AutoSize = True
        Me.RadiusLabel.Location = New System.Drawing.Point(108, 844)
        Me.RadiusLabel.Name = "RadiusLabel"
        Me.RadiusLabel.Size = New System.Drawing.Size(54, 32)
        Me.RadiusLabel.TabIndex = 14
        Me.RadiusLabel.Text = "r = "
        '
        'Area_Circle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.RadiusLabel)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AreaTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.RadiusTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Area_Circle"
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.RadiusTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.AreaTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.RadiusLabel, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents RadiusTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AreaTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents RadiusLabel As Label
End Class
