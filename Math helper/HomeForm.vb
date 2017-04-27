' Programmer:   Nick Cavallaro
' Program:      Math Helper
' Folder:       Projects
' Form:         HomeForm
' Purpose:      Project will perform various algebraic and geometric calculations. Home form allows navigation to
'               different calculations
Public Class HomeForm
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Hide calculate button and formula text box

        CalulateButton.Visible = False
        FormulaLabel.Visible = False
        FormulaTextBox.Visible = False

    End Sub
    Private Sub QuadraticRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QuadraticRadioButton.CheckedChanged
        ' reset the quadratic group box radio buttons
        QuadraticFormRadioButton.Checked = False
        QuadraticEquationRadioButton.Checked = False

        ' show and hide the quadratic group box
        If QuadraticRadioButton.Checked Then
            QuadraticsGroupBox.Visible = True
        Else
            QuadraticsGroupBox.Visible = False
        End If
    End Sub
    Private Sub VolumeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VolumeRadioButton.CheckedChanged
        ' reset volume group box radio buttons
        VolumePyramidConeRadioButton.Checked = False
        VolumeCylinderRadioButton.Checked = False
        VolumeSphereRadioButton.Checked = False

        'show and hide the volume group box
        If VolumeRadioButton.Checked Then
            VolumeGroupBox.Visible = True
        Else
            VolumeGroupBox.Visible = False
        End If
    End Sub
    Private Sub AreaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AreaRadioButton.CheckedChanged
        ' reset the area radio buttons
        AreaCircleRadioButton.Checked = False
        AreaTriangleRadioButton.Checked = False
        AreaRectangleRadioButton.Checked = False

        'show and hide the area group box
        If AreaRadioButton.Checked Then
            AreaGroupBox.Visible = True
        Else
            AreaGroupBox.Visible = False
        End If
    End Sub
    Private Sub DistanceRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DistanceRadioButton.CheckedChanged
        ' reset the distance radio buttons
        DistanceCalculateRadioButton.Checked = False

        'show and hide the distance group box
        If DistanceRadioButton.Checked Then
            DistanceGroupBox.Visible = True
        Else
            DistanceGroupBox.Visible = False
        End If
    End Sub
    Private Sub LineRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LineRadioButton.CheckedChanged
        ' reset lines radio buttons
        LinesCalculateRadioButton.Checked = False

        'show and hide the lines group box
        If LineRadioButton.Checked Then
            LinesGroupBox.Visible = True
        Else
            LinesGroupBox.Visible = False
        End If
    End Sub
    Private Sub LaunchButton_Click(sender As Object, e As EventArgs) Handles LaunchButton.Click
        ' Navigate to selected mathematical function
        If QuadraticRadioButton.Checked And QuadraticEquationRadioButton.Checked Then
            Quadratic_Equation.Show()
        ElseIf QuadraticRadioButton.Checked And QuadraticFormRadioButton.Checked Then
            Quadratic_Form.Show()
        ElseIf VolumeRadioButton.Checked And VolumeCylinderRadioButton.Checked Then
            Volume_Cylinder.Show()
        ElseIf VolumeRadioButton.Checked And VolumeSphereRadioButton.Checked Then
            Volume_Sphere.Show()
        ElseIf VolumeRadioButton.Checked And VolumePyramidConeRadioButton.Checked Then
            Volume_3_Pyramid.Show()
        ElseIf AreaRadioButton.Checked And AreaCircleRadioButton.Checked Then
            Area_Circle.Show()
        ElseIf AreaRadioButton.Checked And AreaTriangleRadioButton.Checked Then
            Area_Triangle.Show()
        ElseIf AreaRadioButton.Checked And AreaRectangleRadioButton.Checked Then
            Area_Rectangle.Show()
        ElseIf DistanceRadioButton.Checked And DistanceCalculateRadioButton.Checked Then
            Distance_Convert.Show()
        ElseIf LineRadioButton.Checked And LinesCalculateRadioButton.Checked Then
            Line_Calculate.Show()
        Else MessageBox.Show("Please select the area in which you need help.", "Missing information")
        End If
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        MyBase.ClearButton_Click(sender, e)
        'clear all radio buttons
        QuadraticRadioButton.Checked = True
        QuadraticRadioButton.Checked = False
    End Sub
    Private Sub AreaCircleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AreaCircleRadioButton.CheckedChanged
        ' show or hide the picture

        If AreaCircleRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.area_of_circle
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub AreaTriangleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AreaTriangleRadioButton.CheckedChanged
        'show or hide the picture

        If AreaTriangleRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.area_of_triangle
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub AreaRectangleRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AreaRectangleRadioButton.CheckedChanged
        ' show or hide the area rectangle picture

        If AreaRectangleRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.area_of_rectangle
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub DistanceCalculateRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles DistanceCalculateRadioButton.CheckedChanged
        'show and hide the picture box
        If DistanceCalculateRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.conversion
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub LinesCalculateRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles LinesCalculateRadioButton.CheckedChanged
        'show and hide the graphic

        If LinesCalculateRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.lines
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub QuadraticEquationRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QuadraticEquationRadioButton.CheckedChanged
        'show or hide the picturebox
        If QuadraticEquationRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.quadratic_formula
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub VolumePyramidConeRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VolumePyramidConeRadioButton.CheckedChanged
        'show or hide the picture box

        If VolumePyramidConeRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.volume_pyramids
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub VolumeCylinderRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VolumeCylinderRadioButton.CheckedChanged
        'show or hide the picture

        If VolumeCylinderRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.volume_prisms
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub VolumeSphereRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VolumeSphereRadioButton.CheckedChanged
        'show or hide the picture
        If VolumeSphereRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.volume_sphere
        Else
            PictureBox1.Visible = False
        End If
    End Sub

    Private Sub QuadraticFormRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles QuadraticFormRadioButton.CheckedChanged
        'show and hide the picture
        If QuadraticFormRadioButton.Checked Then
            PictureBox1.Visible = True
            PictureBox1.Image = My.Resources.coming_soon
        Else
            PictureBox1.Visible = False
        End If
    End Sub
End Class