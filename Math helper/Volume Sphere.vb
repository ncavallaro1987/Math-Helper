Imports System.ComponentModel
Public Class Volume_Sphere
    Dim ErrorProvider1 As New ErrorProvider

    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear all text boxes
        RadiusTextBox.Text = ""
        VolumeTextBox.Text = ""
        FormulaTextBox.Text = ""
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        Dim RadiusDouble, VolumeDouble As Double
        Const PIDouble As Double = 3.14159265

        Try
            'set radius value
            RadiusDouble = Double.Parse(RadiusTextBox.Text)

            'calculate volume
            VolumeDouble = (4 / 3) * PIDouble * (RadiusDouble ^ 3)

            'populate volume text box
            VolumeTextBox.Text = VolumeDouble.ToString()

            'display the formula
            FormulaTextBox.Text = "(4/3) * " & PIDouble & " * ( " & RadiusDouble & " ^ 3) = " & VolumeDouble
        Catch ex As Exception
            'clear active errors
            ErrorProvider1.SetError(RadiusTextBox, "radius must be a numeric value")
            RadiusTextBox.Focus()
        End Try

    End Sub
    Private Sub Volume_Sphere_Load(sender As Object, e As EventArgs) Handles Me.Load
        'show the picture
        PictureBox1.Image = My.Resources.volume_sphere
    End Sub
    Private Sub RadiusTextBox_Validating(sender As Object, e As CancelEventArgs) Handles RadiusTextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(RadiusTextBox, "")

        'check for empty string
        If RadiusTextBox.Text = "" Then
            ErrorProvider1.SetError(RadiusTextBox, "Required Field")
            e.Cancel = True
        End If
    End Sub
    Private Sub Volume_Sphere_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'dont let validation prevent closing
        e.Cancel = False
    End Sub
End Class