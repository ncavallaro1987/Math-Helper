<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Me.CategoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.LineRadioButton = New System.Windows.Forms.RadioButton()
        Me.DistanceRadioButton = New System.Windows.Forms.RadioButton()
        Me.AreaRadioButton = New System.Windows.Forms.RadioButton()
        Me.VolumeRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuadraticRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuadraticsGroupBox = New System.Windows.Forms.GroupBox()
        Me.QuadraticFormRadioButton = New System.Windows.Forms.RadioButton()
        Me.QuadraticEquationRadioButton = New System.Windows.Forms.RadioButton()
        Me.LinesGroupBox = New System.Windows.Forms.GroupBox()
        Me.LinesCalculateRadioButton = New System.Windows.Forms.RadioButton()
        Me.VolumePyramidConeRadioButton = New System.Windows.Forms.RadioButton()
        Me.VolumeSphereRadioButton = New System.Windows.Forms.RadioButton()
        Me.VolumeCylinderRadioButton = New System.Windows.Forms.RadioButton()
        Me.AreaGroupBox = New System.Windows.Forms.GroupBox()
        Me.AreaCircleRadioButton = New System.Windows.Forms.RadioButton()
        Me.AreaTriangleRadioButton = New System.Windows.Forms.RadioButton()
        Me.AreaRectangleRadioButton = New System.Windows.Forms.RadioButton()
        Me.VolumeGroupBox = New System.Windows.Forms.GroupBox()
        Me.LaunchButton = New System.Windows.Forms.Button()
        Me.DistanceGroupBox = New System.Windows.Forms.GroupBox()
        Me.DistanceCalculateRadioButton = New System.Windows.Forms.RadioButton()
        Me.CategoryGroupBox.SuspendLayout()
        Me.QuadraticsGroupBox.SuspendLayout()
        Me.LinesGroupBox.SuspendLayout()
        Me.AreaGroupBox.SuspendLayout()
        Me.VolumeGroupBox.SuspendLayout()
        Me.DistanceGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1014, 69)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Welcome to Cavallaro's Math Helper."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1325, 69)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Please select a category that you need help with."
        '
        'CategoryGroupBox
        '
        Me.CategoryGroupBox.Controls.Add(Me.LineRadioButton)
        Me.CategoryGroupBox.Controls.Add(Me.DistanceRadioButton)
        Me.CategoryGroupBox.Controls.Add(Me.AreaRadioButton)
        Me.CategoryGroupBox.Controls.Add(Me.VolumeRadioButton)
        Me.CategoryGroupBox.Controls.Add(Me.QuadraticRadioButton)
        Me.CategoryGroupBox.Location = New System.Drawing.Point(87, 253)
        Me.CategoryGroupBox.Name = "CategoryGroupBox"
        Me.CategoryGroupBox.Size = New System.Drawing.Size(245, 330)
        Me.CategoryGroupBox.TabIndex = 8
        Me.CategoryGroupBox.TabStop = False
        Me.CategoryGroupBox.Text = "Category"
        '
        'LineRadioButton
        '
        Me.LineRadioButton.AutoSize = True
        Me.LineRadioButton.Location = New System.Drawing.Point(25, 263)
        Me.LineRadioButton.Name = "LineRadioButton"
        Me.LineRadioButton.Size = New System.Drawing.Size(121, 36)
        Me.LineRadioButton.TabIndex = 4
        Me.LineRadioButton.TabStop = True
        Me.LineRadioButton.Text = "Lines"
        Me.LineRadioButton.UseVisualStyleBackColor = True
        '
        'DistanceRadioButton
        '
        Me.DistanceRadioButton.AutoSize = True
        Me.DistanceRadioButton.Location = New System.Drawing.Point(25, 209)
        Me.DistanceRadioButton.Name = "DistanceRadioButton"
        Me.DistanceRadioButton.Size = New System.Drawing.Size(163, 36)
        Me.DistanceRadioButton.TabIndex = 3
        Me.DistanceRadioButton.TabStop = True
        Me.DistanceRadioButton.Text = "Distance"
        Me.DistanceRadioButton.UseVisualStyleBackColor = True
        '
        'AreaRadioButton
        '
        Me.AreaRadioButton.AutoSize = True
        Me.AreaRadioButton.Location = New System.Drawing.Point(25, 155)
        Me.AreaRadioButton.Name = "AreaRadioButton"
        Me.AreaRadioButton.Size = New System.Drawing.Size(112, 36)
        Me.AreaRadioButton.TabIndex = 2
        Me.AreaRadioButton.TabStop = True
        Me.AreaRadioButton.Text = "Area"
        Me.AreaRadioButton.UseVisualStyleBackColor = True
        '
        'VolumeRadioButton
        '
        Me.VolumeRadioButton.AutoSize = True
        Me.VolumeRadioButton.Location = New System.Drawing.Point(25, 101)
        Me.VolumeRadioButton.Name = "VolumeRadioButton"
        Me.VolumeRadioButton.Size = New System.Drawing.Size(149, 36)
        Me.VolumeRadioButton.TabIndex = 1
        Me.VolumeRadioButton.TabStop = True
        Me.VolumeRadioButton.Text = "Volume"
        Me.VolumeRadioButton.UseVisualStyleBackColor = True
        '
        'QuadraticRadioButton
        '
        Me.QuadraticRadioButton.AutoSize = True
        Me.QuadraticRadioButton.Location = New System.Drawing.Point(25, 47)
        Me.QuadraticRadioButton.Name = "QuadraticRadioButton"
        Me.QuadraticRadioButton.Size = New System.Drawing.Size(176, 36)
        Me.QuadraticRadioButton.TabIndex = 0
        Me.QuadraticRadioButton.TabStop = True
        Me.QuadraticRadioButton.Text = "Quadratic"
        Me.QuadraticRadioButton.UseVisualStyleBackColor = True
        '
        'QuadraticsGroupBox
        '
        Me.QuadraticsGroupBox.Controls.Add(Me.QuadraticFormRadioButton)
        Me.QuadraticsGroupBox.Controls.Add(Me.QuadraticEquationRadioButton)
        Me.QuadraticsGroupBox.Location = New System.Drawing.Point(416, 253)
        Me.QuadraticsGroupBox.Name = "QuadraticsGroupBox"
        Me.QuadraticsGroupBox.Size = New System.Drawing.Size(409, 191)
        Me.QuadraticsGroupBox.TabIndex = 9
        Me.QuadraticsGroupBox.TabStop = False
        Me.QuadraticsGroupBox.Text = "Quadratics"
        Me.QuadraticsGroupBox.Visible = False
        '
        'QuadraticFormRadioButton
        '
        Me.QuadraticFormRadioButton.AutoSize = True
        Me.QuadraticFormRadioButton.Location = New System.Drawing.Point(19, 111)
        Me.QuadraticFormRadioButton.Name = "QuadraticFormRadioButton"
        Me.QuadraticFormRadioButton.Size = New System.Drawing.Size(369, 36)
        Me.QuadraticFormRadioButton.TabIndex = 2
        Me.QuadraticFormRadioButton.TabStop = True
        Me.QuadraticFormRadioButton.Text = "Quadratic Form Equation"
        Me.QuadraticFormRadioButton.UseVisualStyleBackColor = True
        '
        'QuadraticEquationRadioButton
        '
        Me.QuadraticEquationRadioButton.AutoSize = True
        Me.QuadraticEquationRadioButton.Location = New System.Drawing.Point(20, 47)
        Me.QuadraticEquationRadioButton.Name = "QuadraticEquationRadioButton"
        Me.QuadraticEquationRadioButton.Size = New System.Drawing.Size(297, 36)
        Me.QuadraticEquationRadioButton.TabIndex = 1
        Me.QuadraticEquationRadioButton.TabStop = True
        Me.QuadraticEquationRadioButton.Text = "Quadratic Equation"
        Me.QuadraticEquationRadioButton.UseVisualStyleBackColor = True
        '
        'LinesGroupBox
        '
        Me.LinesGroupBox.Controls.Add(Me.LinesCalculateRadioButton)
        Me.LinesGroupBox.Location = New System.Drawing.Point(416, 253)
        Me.LinesGroupBox.Name = "LinesGroupBox"
        Me.LinesGroupBox.Size = New System.Drawing.Size(251, 116)
        Me.LinesGroupBox.TabIndex = 12
        Me.LinesGroupBox.TabStop = False
        Me.LinesGroupBox.Text = "Lines"
        Me.LinesGroupBox.Visible = False
        '
        'LinesCalculateRadioButton
        '
        Me.LinesCalculateRadioButton.AutoSize = True
        Me.LinesCalculateRadioButton.Location = New System.Drawing.Point(25, 32)
        Me.LinesCalculateRadioButton.Name = "LinesCalculateRadioButton"
        Me.LinesCalculateRadioButton.Size = New System.Drawing.Size(172, 36)
        Me.LinesCalculateRadioButton.TabIndex = 7
        Me.LinesCalculateRadioButton.TabStop = True
        Me.LinesCalculateRadioButton.Text = "Calculate"
        Me.LinesCalculateRadioButton.UseVisualStyleBackColor = True
        '
        'VolumePyramidConeRadioButton
        '
        Me.VolumePyramidConeRadioButton.AutoSize = True
        Me.VolumePyramidConeRadioButton.Location = New System.Drawing.Point(14, 144)
        Me.VolumePyramidConeRadioButton.Name = "VolumePyramidConeRadioButton"
        Me.VolumePyramidConeRadioButton.Size = New System.Drawing.Size(246, 36)
        Me.VolumePyramidConeRadioButton.TabIndex = 6
        Me.VolumePyramidConeRadioButton.TabStop = True
        Me.VolumePyramidConeRadioButton.Text = "Pyramid / Cone"
        Me.VolumePyramidConeRadioButton.UseVisualStyleBackColor = True
        '
        'VolumeSphereRadioButton
        '
        Me.VolumeSphereRadioButton.AutoSize = True
        Me.VolumeSphereRadioButton.Location = New System.Drawing.Point(14, 96)
        Me.VolumeSphereRadioButton.Name = "VolumeSphereRadioButton"
        Me.VolumeSphereRadioButton.Size = New System.Drawing.Size(144, 36)
        Me.VolumeSphereRadioButton.TabIndex = 5
        Me.VolumeSphereRadioButton.TabStop = True
        Me.VolumeSphereRadioButton.Text = "Sphere"
        Me.VolumeSphereRadioButton.UseVisualStyleBackColor = True
        '
        'VolumeCylinderRadioButton
        '
        Me.VolumeCylinderRadioButton.AutoSize = True
        Me.VolumeCylinderRadioButton.Location = New System.Drawing.Point(14, 48)
        Me.VolumeCylinderRadioButton.Name = "VolumeCylinderRadioButton"
        Me.VolumeCylinderRadioButton.Size = New System.Drawing.Size(251, 36)
        Me.VolumeCylinderRadioButton.TabIndex = 4
        Me.VolumeCylinderRadioButton.TabStop = True
        Me.VolumeCylinderRadioButton.Text = "Cylinder / Prism"
        Me.VolumeCylinderRadioButton.UseVisualStyleBackColor = True
        '
        'AreaGroupBox
        '
        Me.AreaGroupBox.Controls.Add(Me.AreaCircleRadioButton)
        Me.AreaGroupBox.Controls.Add(Me.AreaTriangleRadioButton)
        Me.AreaGroupBox.Controls.Add(Me.AreaRectangleRadioButton)
        Me.AreaGroupBox.Location = New System.Drawing.Point(404, 248)
        Me.AreaGroupBox.Name = "AreaGroupBox"
        Me.AreaGroupBox.Size = New System.Drawing.Size(305, 255)
        Me.AreaGroupBox.TabIndex = 11
        Me.AreaGroupBox.TabStop = False
        Me.AreaGroupBox.Text = "Area"
        Me.AreaGroupBox.Visible = False
        '
        'AreaCircleRadioButton
        '
        Me.AreaCircleRadioButton.AutoSize = True
        Me.AreaCircleRadioButton.Location = New System.Drawing.Point(18, 54)
        Me.AreaCircleRadioButton.Name = "AreaCircleRadioButton"
        Me.AreaCircleRadioButton.Size = New System.Drawing.Size(125, 36)
        Me.AreaCircleRadioButton.TabIndex = 5
        Me.AreaCircleRadioButton.TabStop = True
        Me.AreaCircleRadioButton.Text = "Circle"
        Me.AreaCircleRadioButton.UseVisualStyleBackColor = True
        '
        'AreaTriangleRadioButton
        '
        Me.AreaTriangleRadioButton.AutoSize = True
        Me.AreaTriangleRadioButton.Location = New System.Drawing.Point(18, 110)
        Me.AreaTriangleRadioButton.Name = "AreaTriangleRadioButton"
        Me.AreaTriangleRadioButton.Size = New System.Drawing.Size(156, 36)
        Me.AreaTriangleRadioButton.TabIndex = 4
        Me.AreaTriangleRadioButton.TabStop = True
        Me.AreaTriangleRadioButton.Text = "Triangle"
        Me.AreaTriangleRadioButton.UseVisualStyleBackColor = True
        '
        'AreaRectangleRadioButton
        '
        Me.AreaRectangleRadioButton.AutoSize = True
        Me.AreaRectangleRadioButton.Location = New System.Drawing.Point(18, 166)
        Me.AreaRectangleRadioButton.Name = "AreaRectangleRadioButton"
        Me.AreaRectangleRadioButton.Size = New System.Drawing.Size(181, 36)
        Me.AreaRectangleRadioButton.TabIndex = 3
        Me.AreaRectangleRadioButton.TabStop = True
        Me.AreaRectangleRadioButton.Text = "Rectangle"
        Me.AreaRectangleRadioButton.UseVisualStyleBackColor = True
        '
        'VolumeGroupBox
        '
        Me.VolumeGroupBox.Controls.Add(Me.VolumePyramidConeRadioButton)
        Me.VolumeGroupBox.Controls.Add(Me.VolumeCylinderRadioButton)
        Me.VolumeGroupBox.Controls.Add(Me.VolumeSphereRadioButton)
        Me.VolumeGroupBox.Location = New System.Drawing.Point(404, 253)
        Me.VolumeGroupBox.Name = "VolumeGroupBox"
        Me.VolumeGroupBox.Size = New System.Drawing.Size(287, 206)
        Me.VolumeGroupBox.TabIndex = 7
        Me.VolumeGroupBox.TabStop = False
        Me.VolumeGroupBox.Text = "Volumes"
        Me.VolumeGroupBox.Visible = False
        '
        'LaunchButton
        '
        Me.LaunchButton.Location = New System.Drawing.Point(293, 712)
        Me.LaunchButton.Name = "LaunchButton"
        Me.LaunchButton.Size = New System.Drawing.Size(185, 78)
        Me.LaunchButton.TabIndex = 13
        Me.LaunchButton.Text = "Launch"
        Me.LaunchButton.UseVisualStyleBackColor = True
        '
        'DistanceGroupBox
        '
        Me.DistanceGroupBox.Controls.Add(Me.DistanceCalculateRadioButton)
        Me.DistanceGroupBox.Location = New System.Drawing.Point(413, 253)
        Me.DistanceGroupBox.Name = "DistanceGroupBox"
        Me.DistanceGroupBox.Size = New System.Drawing.Size(200, 100)
        Me.DistanceGroupBox.TabIndex = 8
        Me.DistanceGroupBox.TabStop = False
        Me.DistanceGroupBox.Text = "Distance"
        Me.DistanceGroupBox.Visible = False
        '
        'DistanceCalculateRadioButton
        '
        Me.DistanceCalculateRadioButton.AutoSize = True
        Me.DistanceCalculateRadioButton.Location = New System.Drawing.Point(10, 32)
        Me.DistanceCalculateRadioButton.Name = "DistanceCalculateRadioButton"
        Me.DistanceCalculateRadioButton.Size = New System.Drawing.Size(151, 36)
        Me.DistanceCalculateRadioButton.TabIndex = 4
        Me.DistanceCalculateRadioButton.TabStop = True
        Me.DistanceCalculateRadioButton.Text = "Convert"
        Me.DistanceCalculateRadioButton.UseVisualStyleBackColor = True
        '
        'HomeForm
        '
        Me.AcceptButton = Me.LaunchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1672, 1053)
        Me.Controls.Add(Me.VolumeGroupBox)
        Me.Controls.Add(Me.DistanceGroupBox)
        Me.Controls.Add(Me.AreaGroupBox)
        Me.Controls.Add(Me.LaunchButton)
        Me.Controls.Add(Me.LinesGroupBox)
        Me.Controls.Add(Me.QuadraticsGroupBox)
        Me.Controls.Add(Me.CategoryGroupBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HomeForm"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CategoryGroupBox, 0)
        Me.Controls.SetChildIndex(Me.QuadraticsGroupBox, 0)
        Me.Controls.SetChildIndex(Me.LinesGroupBox, 0)
        Me.Controls.SetChildIndex(Me.LaunchButton, 0)
        Me.Controls.SetChildIndex(Me.AreaGroupBox, 0)
        Me.Controls.SetChildIndex(Me.DistanceGroupBox, 0)
        Me.Controls.SetChildIndex(Me.VolumeGroupBox, 0)
        Me.CategoryGroupBox.ResumeLayout(False)
        Me.CategoryGroupBox.PerformLayout()
        Me.QuadraticsGroupBox.ResumeLayout(False)
        Me.QuadraticsGroupBox.PerformLayout()
        Me.LinesGroupBox.ResumeLayout(False)
        Me.LinesGroupBox.PerformLayout()
        Me.AreaGroupBox.ResumeLayout(False)
        Me.AreaGroupBox.PerformLayout()
        Me.VolumeGroupBox.ResumeLayout(False)
        Me.VolumeGroupBox.PerformLayout()
        Me.DistanceGroupBox.ResumeLayout(False)
        Me.DistanceGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CategoryGroupBox As GroupBox
    Friend WithEvents VolumeRadioButton As RadioButton
    Friend WithEvents QuadraticRadioButton As RadioButton
    Friend WithEvents LineRadioButton As RadioButton
    Friend WithEvents DistanceRadioButton As RadioButton
    Friend WithEvents AreaRadioButton As RadioButton
    Friend WithEvents QuadraticsGroupBox As GroupBox
    Friend WithEvents QuadraticFormRadioButton As RadioButton
    Friend WithEvents QuadraticEquationRadioButton As RadioButton
    Friend WithEvents VolumePyramidConeRadioButton As RadioButton
    Friend WithEvents VolumeSphereRadioButton As RadioButton
    Friend WithEvents VolumeCylinderRadioButton As RadioButton
    Friend WithEvents AreaGroupBox As GroupBox
    Friend WithEvents AreaCircleRadioButton As RadioButton
    Friend WithEvents AreaTriangleRadioButton As RadioButton
    Friend WithEvents AreaRectangleRadioButton As RadioButton
    Friend WithEvents LinesGroupBox As GroupBox
    Friend WithEvents LinesCalculateRadioButton As RadioButton
    Friend WithEvents LaunchButton As Button
    Friend WithEvents DistanceGroupBox As GroupBox
    Friend WithEvents DistanceCalculateRadioButton As RadioButton
    Friend WithEvents VolumeGroupBox As GroupBox
End Class
