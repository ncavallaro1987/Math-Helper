<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quadratic_Equation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quadratic_Equation))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ValueATextBox = New System.Windows.Forms.TextBox()
        Me.ValueBTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ValueCTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Solution1TextBox = New System.Windows.Forms.TextBox()
        Me.Solution2TextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumeratorLabel = New System.Windows.Forms.Label()
        Me.DivisionLineLabel = New System.Windows.Forms.Label()
        Me.DenominatorLabel = New System.Windows.Forms.Label()
        Me.ImaginaryExplainLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(244, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(973, 46)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Quadratic equations take  the form   aX^2 + bX + c = y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 32)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "a:"
        '
        'ValueATextBox
        '
        Me.ValueATextBox.Location = New System.Drawing.Point(92, 257)
        Me.ValueATextBox.Name = "ValueATextBox"
        Me.ValueATextBox.Size = New System.Drawing.Size(109, 38)
        Me.ValueATextBox.TabIndex = 19
        '
        'ValueBTextBox
        '
        Me.ValueBTextBox.Location = New System.Drawing.Point(316, 257)
        Me.ValueBTextBox.Name = "ValueBTextBox"
        Me.ValueBTextBox.Size = New System.Drawing.Size(109, 38)
        Me.ValueBTextBox.TabIndex = 21
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 32)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "b:"
        '
        'ValueCTextBox
        '
        Me.ValueCTextBox.Location = New System.Drawing.Point(540, 257)
        Me.ValueCTextBox.Name = "ValueCTextBox"
        Me.ValueCTextBox.Size = New System.Drawing.Size(109, 38)
        Me.ValueCTextBox.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(495, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 32)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "c:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(83, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1284, 78)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Quadratic equations form a parabola. This module will determine the X-intercepts " &
    "of that parabola (points where Y=0) by using the Quadratic formula  {(-b ± √[b^2" &
    " - 4ac])/2a}"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(86, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 32)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Solution 1:"
        '
        'Solution1TextBox
        '
        Me.Solution1TextBox.Location = New System.Drawing.Point(252, 394)
        Me.Solution1TextBox.Name = "Solution1TextBox"
        Me.Solution1TextBox.ReadOnly = True
        Me.Solution1TextBox.Size = New System.Drawing.Size(314, 38)
        Me.Solution1TextBox.TabIndex = 26
        Me.Solution1TextBox.TabStop = False
        '
        'Solution2TextBox
        '
        Me.Solution2TextBox.Location = New System.Drawing.Point(252, 475)
        Me.Solution2TextBox.Name = "Solution2TextBox"
        Me.Solution2TextBox.ReadOnly = True
        Me.Solution2TextBox.Size = New System.Drawing.Size(314, 38)
        Me.Solution2TextBox.TabIndex = 28
        Me.Solution2TextBox.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(86, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 32)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Solution 2:"
        '
        'NumeratorLabel
        '
        Me.NumeratorLabel.AutoSize = True
        Me.NumeratorLabel.Location = New System.Drawing.Point(120, 700)
        Me.NumeratorLabel.Name = "NumeratorLabel"
        Me.NumeratorLabel.Size = New System.Drawing.Size(31, 32)
        Me.NumeratorLabel.TabIndex = 29
        Me.NumeratorLabel.Text = "n"
        '
        'DivisionLineLabel
        '
        Me.DivisionLineLabel.AutoSize = True
        Me.DivisionLineLabel.Location = New System.Drawing.Point(120, 732)
        Me.DivisionLineLabel.Name = "DivisionLineLabel"
        Me.DivisionLineLabel.Size = New System.Drawing.Size(210, 32)
        Me.DivisionLineLabel.TabIndex = 30
        Me.DivisionLineLabel.Text = "_____________"
        '
        'DenominatorLabel
        '
        Me.DenominatorLabel.AutoSize = True
        Me.DenominatorLabel.Location = New System.Drawing.Point(120, 794)
        Me.DenominatorLabel.Name = "DenominatorLabel"
        Me.DenominatorLabel.Size = New System.Drawing.Size(31, 32)
        Me.DenominatorLabel.TabIndex = 31
        Me.DenominatorLabel.Text = "d"
        '
        'ImaginaryExplainLabel
        '
        Me.ImaginaryExplainLabel.Location = New System.Drawing.Point(16, 544)
        Me.ImaginaryExplainLabel.Name = "ImaginaryExplainLabel"
        Me.ImaginaryExplainLabel.Size = New System.Drawing.Size(833, 143)
        Me.ImaginaryExplainLabel.TabIndex = 32
        Me.ImaginaryExplainLabel.Text = resources.GetString("ImaginaryExplainLabel.Text")
        Me.ImaginaryExplainLabel.Visible = False
        '
        'Quadratic_Equation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1750, 1067)
        Me.Controls.Add(Me.ImaginaryExplainLabel)
        Me.Controls.Add(Me.DenominatorLabel)
        Me.Controls.Add(Me.DivisionLineLabel)
        Me.Controls.Add(Me.NumeratorLabel)
        Me.Controls.Add(Me.Solution2TextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Solution1TextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ValueCTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ValueBTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ValueATextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Quadratic_Equation"
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ValueATextBox, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.ValueBTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ValueCTextBox, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Solution1TextBox, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Solution2TextBox, 0)
        Me.Controls.SetChildIndex(Me.NumeratorLabel, 0)
        Me.Controls.SetChildIndex(Me.DivisionLineLabel, 0)
        Me.Controls.SetChildIndex(Me.DenominatorLabel, 0)
        Me.Controls.SetChildIndex(Me.ImaginaryExplainLabel, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ValueATextBox As TextBox
    Friend WithEvents ValueBTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ValueCTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Solution1TextBox As TextBox
    Friend WithEvents Solution2TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NumeratorLabel As Label
    Friend WithEvents DivisionLineLabel As Label
    Friend WithEvents DenominatorLabel As Label
    Friend WithEvents ImaginaryExplainLabel As Label
End Class
