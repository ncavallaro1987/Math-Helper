Imports System.ComponentModel
Public Class Area_Rectangle
    Dim ErrorProvider1 As New ErrorProvider
    Private Sub Area_Rectangle_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.area_of_rectangle
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear any errors and text boxes

        ErrorProvider1.SetError(LengthTextBox, "")
        LengthTextBox.Text = ""
        WidthTextBox.Text = ""
        FormulaTextBox.Text = ""
        AreaTextBox.Text = ""
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        Dim LengthDouble, WidthDouble, AreaDouble As Double
        ' clear previous errors
        ErrorProvider1.SetError(LengthTextBox, "")

        'convert data from text boxes and calculate area
        Try
            LengthDouble = Double.Parse(LengthTextBox.Text)
            Try
                WidthDouble = Double.Parse(WidthTextBox.Text)
                AreaDouble = LengthDouble * WidthDouble
                AreaTextBox.Text = AreaDouble.ToString()
                FormulaTextBox.Text = LengthDouble & " * " & WidthDouble & " = " & AreaDouble
            Catch ex As Exception
                ErrorProvider1.SetError(WidthTextBox, "Width must be numeric.")
                WidthTextBox.Focus()
            End Try
        Catch ex As Exception
            ErrorProvider1.SetError(LengthTextBox, "Length must be numeric.")
            LengthTextBox.Focus()
        End Try
    End Sub

    Private Sub LengthTextBox_TextChanged(sender As Object, e As EventArgs) Handles LengthTextBox.TextChanged
        ' display the value of "l" live updating

        LengthLabel.Text = "l = " & LengthTextBox.Text
    End Sub

    Private Sub WidthTextBox_TextChanged(sender As Object, e As EventArgs) Handles WidthTextBox.TextChanged
        'display the value of "w" live update

        WidthLabel.Text = "w = " & WidthTextBox.Text
    End Sub

    Private Sub WidthTextBox_Validating(sender As Object, e As CancelEventArgs) Handles WidthTextBox.Validating

        'clear previous errors
        ErrorProvider1.SetError(WidthTextBox, "")
        'check for empty string
        If WidthTextBox.Text = "" Then
            ErrorProvider1.SetError(WidthTextBox, "Required Field")
            e.Cancel = True
        End If
    End Sub

    Private Sub LengthTextBox_Validating(sender As Object, e As CancelEventArgs) Handles LengthTextBox.Validating
        'clear previous errors
        ErrorProvider1.SetError(LengthTextBox, "")

        'check for empty string
        If LengthTextBox.Text = "" Then
            ErrorProvider1.SetError(LengthTextBox, "Required field")
            e.Cancel = True
        End If
    End Sub

    Private Sub Area_Rectangle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' dont let validation prevent form closing
        e.Cancel = False
    End Sub
End Class