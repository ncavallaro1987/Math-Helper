
Imports System.ComponentModel
Public Class Area_Circle
    Dim ErrorProvider1 As New ErrorProvider

    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        RadiusTextBox.Clear()
        AreaTextBox.Clear()
        FormulaTextBox.Clear()
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        ' calculate the area of the circle
        Const PIDouble As Double = 3.14159265
        Dim RadiusDouble, AreaDouble As Double

        ' clear any active errors
        ErrorProvider1.SetError(RadiusTextBox, "")

        Try
            RadiusDouble = Double.Parse(RadiusTextBox.Text)
            AreaDouble = PiDouble * (RadiusDouble ^ 2)
            AreaTextBox.Text = AreaDouble.ToString
            FormulaTextBox.Text = PiDouble & " * (" & RadiusDouble & " ^ 2) = " & AreaDouble
        Catch
            ErrorProvider1.SetError(RadiusTextBox, "Must be a numeric value")
            MessageBox.Show("must be numeric", "invalid data")
        End Try

    End Sub

    Private Sub Area_Circle_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.area_of_circle
    End Sub

    Private Sub RadiusTextBox_Validating(sender As Object, e As CancelEventArgs) Handles RadiusTextBox.Validating
        'clear previous error
        ErrorProvider1.SetError(RadiusTextBox, "")

        'check for empty string
        If RadiusTextBox.Text = "" Then
            'cancel the event
            e.Cancel = True
            RadiusTextBox.Focus()
            ErrorProvider1.SetError(RadiusTextBox, "Required field")
        End If
    End Sub

    Private Sub Area_Circle_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'do not allow validation to prevent form closing

        e.Cancel = False
    End Sub

    Private Sub RadiusTextBox_TextChanged(sender As Object, e As EventArgs) Handles RadiusTextBox.TextChanged
        ' update radius label with live value
        RadiusLabel.Text = "r = " & RadiusTextBox.Text
    End Sub
End Class