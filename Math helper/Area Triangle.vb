Imports System.ComponentModel
Public Class Area_Triangle
    Dim ErrorProvider1 As New ErrorProvider
    Private Sub Area_Triangle_Load(sender As Object, e As EventArgs) Handles Me.Load
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.area_of_triangle
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        'calculate the area of a triangle
        Dim HeightDouble, BaseDouble, AreaDouble As Double

        'clear previous errors
        ErrorProvider1.SetError(BaseTextBox, "")

        Try
            BaseDouble = Double.Parse(BaseTextBox.Text)
            Try
                HeightDouble = Double.Parse(HeightTextBox.Text)
                AreaDouble = (HeightDouble * BaseDouble) / 2
                AreaTextBox.Text = AreaDouble.ToString
                FormulaTextBox.Text = "(" & HeightDouble & " * " & BaseDouble & ")/2 =" & AreaDouble
            Catch ex As Exception
                ErrorProvider1.SetError(HeightTextBox, "Height must be a numeric value")
                HeightTextBox.Focus()
            End Try
        Catch ex As Exception
            ErrorProvider1.SetError(BaseTextBox, "Base must be a numeric value")
            BaseTextBox.Focus()
        End Try

    End Sub
    Private Sub BaseTextBox_Validating(sender As Object, e As CancelEventArgs) Handles BaseTextBox.Validating
        'clear any previous errors
        ErrorProvider1.SetError(BaseTextBox, "")

        'check for empty strings
        If BaseTextBox.Text = "" Then
            ErrorProvider1.SetError(BaseTextBox, "Required field")
            BaseTextBox.Focus()
            e.Cancel = True
        End If
    End Sub
    Private Sub HeightTextBox_Validating(sender As Object, e As CancelEventArgs) Handles HeightTextBox.Validating
        'clear any previous error
        ErrorProvider1.SetError(HeightTextBox, "")

        ' Check for empty string
        If HeightTextBox.Text = "" Then
            ErrorProvider1.SetError(HeightTextBox, "Required field")
            e.Cancel = True
        End If
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear errors
        ErrorProvider1.SetError(BaseTextBox, "")

        'clear fields
        BaseTextBox.Text = ""
        HeightTextBox.Text = ""
        AreaTextBox.Text = ""
        FormulaTextBox.Text = ""
    End Sub
    Private Sub Area_Triangle_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' prevent validation from preventing cllose

        e.Cancel = False
    End Sub
    Private Sub BaseTextBox_TextChanged(sender As Object, e As EventArgs) Handles BaseTextBox.TextChanged
        'show the value of b live updating

        BaseLabel.Text = "b = " & BaseTextBox.Text
    End Sub
    Private Sub HeightTextBox_TextChanged(sender As Object, e As EventArgs) Handles HeightTextBox.TextChanged
        'show the value of h live updating

        HeightLabel.Text = "h = " & HeightTextBox.Text
    End Sub
End Class