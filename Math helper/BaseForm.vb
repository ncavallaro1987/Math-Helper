' Programmer:   Nick Cavallaro
' Program:      Math Helper
' Folder:       Projects
' Form:         BaseForm
' Purpose:      Project will perform various algebraic and geometric calculations. Base form provides
'               visual inheritance for other forms in the project as well as holding module level variables
Imports System.ComponentModel
Public Class BaseForm
    'Declare module level variables
    ' none


    Public Overridable Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click, ClearToolStripMenuItem.Click
        'allow inherited classes to override this method
    End Sub

    Public Overridable Sub CalulateButton_Click(sender As Object, e As EventArgs) Handles CalulateButton.Click, CalculateToolStripMenuItem.Click
        'allow inherited classes to override
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click, ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub QuadraitEquationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadraitEquationToolStripMenuItem.Click
        Quadratic_Equation.Show()
    End Sub

    Private Sub QuadraticFormEquationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuadraticFormEquationToolStripMenuItem.Click
        Quadratic_Form.Show()
    End Sub

    Private Sub CylindarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CylindarToolStripMenuItem.Click
        Volume_Cylinder.Show()
    End Sub

    Private Sub SphereToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SphereToolStripMenuItem.Click
        Volume_Sphere.Show()
    End Sub

    Private Sub ConeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConeToolStripMenuItem.Click
        Volume_3_Pyramid.Show()
    End Sub

    Private Sub CircleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CircleToolStripMenuItem.Click
        Area_Circle.Show()
    End Sub

    Private Sub TriangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TriangleToolStripMenuItem.Click
        Area_Triangle.Show()
    End Sub

    Private Sub RectangleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RectangleToolStripMenuItem.Click
        Area_Triangle.Show()
    End Sub

    Private Sub ConvertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConvertToolStripMenuItem.Click
        Distance_Convert.Show()
    End Sub

    Private Sub CalculateLineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateLineToolStripMenuItem.Click
        Line_Calculate.Show()
    End Sub
End Class
