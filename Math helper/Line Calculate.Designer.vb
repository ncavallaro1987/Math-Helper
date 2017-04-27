<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Line_Calculate
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.X1TextBox = New System.Windows.Forms.TextBox()
        Me.Y1TextBox = New System.Windows.Forms.TextBox()
        Me.X2TextBox = New System.Windows.Forms.TextBox()
        Me.Y2TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SegmentLengthTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MidpointTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LengthFormulaTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 44)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 388)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 44)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "X"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 248)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 44)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Y"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(329, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 44)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Y"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(142, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 25)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(366, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(142, 407)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 25)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(366, 407)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "2"
        '
        'X1TextBox
        '
        Me.X1TextBox.Location = New System.Drawing.Point(171, 254)
        Me.X1TextBox.Name = "X1TextBox"
        Me.X1TextBox.Size = New System.Drawing.Size(122, 38)
        Me.X1TextBox.TabIndex = 25
        '
        'Y1TextBox
        '
        Me.Y1TextBox.Location = New System.Drawing.Point(395, 254)
        Me.Y1TextBox.Name = "Y1TextBox"
        Me.Y1TextBox.Size = New System.Drawing.Size(122, 38)
        Me.Y1TextBox.TabIndex = 26
        '
        'X2TextBox
        '
        Me.X2TextBox.Location = New System.Drawing.Point(171, 394)
        Me.X2TextBox.Name = "X2TextBox"
        Me.X2TextBox.Size = New System.Drawing.Size(122, 38)
        Me.X2TextBox.TabIndex = 27
        '
        'Y2TextBox
        '
        Me.Y2TextBox.Location = New System.Drawing.Point(395, 394)
        Me.Y2TextBox.Name = "Y2TextBox"
        Me.Y2TextBox.Size = New System.Drawing.Size(122, 38)
        Me.Y2TextBox.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(86, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1340, 39)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "The length of a line segment is found by taking the square root of ((x2-x1)^2 + (" &
    "y2-y1)^2)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 158)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(848, 39)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "The midpoint of a line segment is ((x1+x2)/2, (y1+y2)/2)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 499)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(223, 32)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Segment length:"
        '
        'SegmentLengthTextBox
        '
        Me.SegmentLengthTextBox.Location = New System.Drawing.Point(252, 493)
        Me.SegmentLengthTextBox.Name = "SegmentLengthTextBox"
        Me.SegmentLengthTextBox.ReadOnly = True
        Me.SegmentLengthTextBox.Size = New System.Drawing.Size(310, 38)
        Me.SegmentLengthTextBox.TabIndex = 32
        Me.SegmentLengthTextBox.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(114, 571)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 32)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Midpoint:"
        '
        'MidpointTextBox
        '
        Me.MidpointTextBox.Location = New System.Drawing.Point(252, 571)
        Me.MidpointTextBox.Name = "MidpointTextBox"
        Me.MidpointTextBox.ReadOnly = True
        Me.MidpointTextBox.Size = New System.Drawing.Size(310, 38)
        Me.MidpointTextBox.TabIndex = 34
        Me.MidpointTextBox.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(108, 767)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(205, 32)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Length formula"
        '
        'LengthFormulaTextBox
        '
        Me.LengthFormulaTextBox.Location = New System.Drawing.Point(114, 813)
        Me.LengthFormulaTextBox.Name = "LengthFormulaTextBox"
        Me.LengthFormulaTextBox.ReadOnly = True
        Me.LengthFormulaTextBox.Size = New System.Drawing.Size(514, 38)
        Me.LengthFormulaTextBox.TabIndex = 36
        Me.LengthFormulaTextBox.TabStop = False
        '
        'Line_Calculate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 1053)
        Me.Controls.Add(Me.LengthFormulaTextBox)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.MidpointTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.SegmentLengthTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Y2TextBox)
        Me.Controls.Add(Me.X2TextBox)
        Me.Controls.Add(Me.Y1TextBox)
        Me.Controls.Add(Me.X1TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Line_Calculate"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.X1TextBox, 0)
        Me.Controls.SetChildIndex(Me.Y1TextBox, 0)
        Me.Controls.SetChildIndex(Me.X2TextBox, 0)
        Me.Controls.SetChildIndex(Me.Y2TextBox, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.SegmentLengthTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.MidpointTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.LengthFormulaTextBox, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents X1TextBox As TextBox
    Friend WithEvents Y1TextBox As TextBox
    Friend WithEvents X2TextBox As TextBox
    Friend WithEvents Y2TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SegmentLengthTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents MidpointTextBox As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LengthFormulaTextBox As TextBox
End Class
