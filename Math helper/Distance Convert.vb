Imports System.ComponentModel
Public Class Distance_Convert
    Dim ErrorProvider1 As New ErrorProvider
    Dim MultiplierDouble(,) As Double = {{1, 0.0833333, 0.0277778, 0.00001578, 25.4, 2.54, 0.0254, 0.0000254},
                                           {12, 1, 0.333333, 0.000189394, 304.8, 30.48, 0.3048, 0.0003048},
                                           {36, 3, 1, 0.000568182, 914.4, 91.44, 0.9144, 0.0009144},
                                           {63360, 5280, 1760, 1, 1609340, 160934, 1609.34, 1.60934},
                                           {0.0393701, 0.00328084, 0.00109361, 0.000000621371, 1, 0.1, 0.001, 0.000001},
                                           {0.393701, 0.0328084, 0.0109361, 0.00000621371, 10, 1, 0.01, 0.00001},
                                           {39.3701, 3.28084, 1.09361, 0.000621371, 1000, 100, 1, 0.001},
                                           {39370.1, 3280.84, 1093.61, 0.621371, 1000000, 100000, 1000, 1}}
    Dim StartDouble, EndDouble As Double

    Private Sub Distance_Convert_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Image = My.Resources.conversion
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        'clear any errors
        ErrorProvider1.SetError(StartDistanceTextBox, "")

        Try
            StartDouble = Double.Parse(StartDistanceTextBox.Text)
            EndDouble = StartDouble * MultiplierDouble(ConvertFromComboBox.SelectedIndex, ConvertToComboBox.SelectedIndex)
            MultiplierTextBox.Text = MultiplierDouble(ConvertFromComboBox.SelectedIndex, ConvertToComboBox.SelectedIndex).ToString()
            EndDistanceTextBox.Text = EndDouble.ToString() & " " & ConvertToComboBox.Text
            FormulaTextBox.Text = StartDouble & " * " & MultiplierDouble(ConvertFromComboBox.SelectedIndex, ConvertToComboBox.SelectedIndex) & " = " & EndDouble
        Catch ex As Exception
            ErrorProvider1.SetError(StartDistanceTextBox, "Must be numeric")
        End Try
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear all text boxes
        StartDistanceTextBox.Text = ""
        EndDistanceTextBox.Text = ""
        ConvertFromComboBox.SelectedIndex = -1
        ConvertToComboBox.SelectedIndex = -1
        FormulaTextBox.Text = ""
        MultiplierTextBox.Text = ""
    End Sub

    Private Sub StartDistanceTextBox_Validating(sender As Object, e As CancelEventArgs) Handles StartDistanceTextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(StartDistanceTextBox, "")

        'check for empty string
        If StartDistanceTextBox.Text = "" Then
            ErrorProvider1.SetError(StartDistanceTextBox, "Required field")
            e.Cancel = True
        End If
    End Sub

    Private Sub ConvertFromComboBox_Validating(sender As Object, e As CancelEventArgs) Handles ConvertFromComboBox.Validating
        'clear active errors
        ErrorProvider1.SetError(ConvertFromComboBox, "")

        ' Check for empty box
        If ConvertFromComboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ConvertFromComboBox, "Required field")
            e.Cancel = True
        End If
    End Sub

    Private Sub ConvertToComboBox_Validating(sender As Object, e As CancelEventArgs) Handles ConvertToComboBox.Validating
        'clear active errors
        ErrorProvider1.SetError(ConvertToComboBox, "")

        'check for no selection
        If ConvertToComboBox.SelectedIndex = -1 Then
            ErrorProvider1.SetError(ConvertToComboBox, "Required field")
            e.Cancel = True
        End If
    End Sub

    Private Sub Distance_Convert_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' dont allow validation to prevent closing
        e.Cancel = False
    End Sub

End Class