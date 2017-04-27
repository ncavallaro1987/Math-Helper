Imports System.ComponentModel
Public Class Volume_3_Pyramid
    Dim ErrorProvider1 As New ErrorProvider
    Private Sub Volume_3_Pyramid_Load(sender As Object, e As EventArgs) Handles Me.Load
        'display the picture
        PictureBox1.Image = My.Resources.volume_pyramids
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear all text boxes
        BaseAreaTextBox.Text = ""
        HeightTextBox.Text = ""
        VolumeTextBox.Text = ""
        FormulaTextBox.Text = ""

    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        Dim BaseAreaDouble, HeightDouble, VolumeDouble As Double

        Try
            'set value of base area
            BaseAreaDouble = Double.Parse(BaseAreaTextBox.Text)
            Try
                'set value of height
                HeightDouble = Double.Parse(HeightTextBox.Text)

                'set value of volume
                VolumeDouble = (BaseAreaDouble * HeightDouble) / 3

                'populate volume text box
                VolumeTextBox.Text = VolumeDouble.ToString()

                'populate formula text box
                FormulaTextBox.Text = "( " & BaseAreaDouble & " * " & HeightDouble & " ) / 3  =  " & VolumeDouble
            Catch ex As Exception
                'clear previous error
                ErrorProvider1.SetError(HeightTextBox, "")

                'height is non numeric
                ErrorProvider1.SetError(HeightTextBox, "Height must be a numeric value")
            End Try
        Catch ex As Exception
            'clear previous error
            ErrorProvider1.SetError(BaseAreaTextBox, "")

            'base is non numeric
            ErrorProvider1.SetError(BaseAreaTextBox, "Base area must be a numeric value")
        End Try
    End Sub
    Private Sub TriangleAreaButton_Click(sender As Object, e As EventArgs) Handles TriangleAreaButton.Click
        Area_Triangle.Show()
        Area_Triangle.Focus()
    End Sub
    Private Sub BaseAreaTextBox_Validating(sender As Object, e As CancelEventArgs) Handles BaseAreaTextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(BaseAreaTextBox, "")

        'check for empty string
        If BaseAreaTextBox.Text = "" Then
            ErrorProvider1.SetError(BaseAreaTextBox, "Required field")
            e.Cancel = True
        End If
    End Sub
    Private Sub HeightTextBox_Validating(sender As Object, e As CancelEventArgs) Handles HeightTextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(HeightTextBox, "")

        'check for empty string
        If HeightTextBox.Text = "" Then
            ErrorProvider1.SetError(HeightTextBox, "Required field")
            e.Cancel = True
        End If
    End Sub
    Private Sub Volume_3_Pyramid_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'dont allow validation to prevent closing
        e.Cancel = False

    End Sub
    Private Sub CircleButton_Click(sender As Object, e As EventArgs) Handles CircleButton.Click
        Area_Circle.Show()
        Area_Circle.Focus()
    End Sub
    Private Sub RectangleButton_Click(sender As Object, e As EventArgs) Handles RectangleButton.Click
        Area_Rectangle.Show()
        Area_Rectangle.Focus()
    End Sub
End Class