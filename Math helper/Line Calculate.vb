Imports System.ComponentModel
Public Class Line_Calculate
    Dim ErrorProvider1 As New ErrorProvider

    Private Sub Line_Calculate_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'dont allow validation to prevent closing
        e.Cancel = False
    End Sub

    Private Sub Line_Calculate_Load(sender As Object, e As EventArgs) Handles Me.Load
        'show the picture
        PictureBox1.Image = My.Resources.lines

        'rename the formula label
        FormulaLabel.Text = "Midpoint formula:"
    End Sub
    Private Sub X1TextBox_Validating(sender As Object, e As CancelEventArgs) Handles X1TextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(X1TextBox, "")

        'check for empty string
        If X1TextBox.Text = "" Then
            ErrorProvider1.SetError(X1TextBox, "Required field.")
            e.Cancel = True
        End If
    End Sub
    Private Sub X2TextBox_Validating(sender As Object, e As CancelEventArgs) Handles X2TextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(X2TextBox, "")

        'check for empty string
        If X2TextBox.Text = "" Then
            ErrorProvider1.SetError(X2TextBox, "Required field.")
            e.Cancel = True
        End If
    End Sub
    Private Sub Y1TextBox_Validating(sender As Object, e As CancelEventArgs) Handles Y1TextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(Y1TextBox, "")

        'check for empty string
        If Y1TextBox.Text = "" Then
            ErrorProvider1.SetError(Y1TextBox, "Required field.")
            e.Cancel = True
        End If
    End Sub
    Private Sub Y2TextBox_Validating(sender As Object, e As CancelEventArgs) Handles Y2TextBox.Validating
        'clear active errors
        ErrorProvider1.SetError(Y2TextBox, "")

        'check for empty string
        If Y2TextBox.Text = "" Then
            ErrorProvider1.SetError(Y2TextBox, "Required field.")
            e.Cancel = True
        End If
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        Dim X1Double, X2Double, Y1Double, Y2Double, MidpointXDouble, MidpointYDouble, LengthDouble As Double

        Try
            X1Double = Double.Parse(X1TextBox.Text)
            Try
                Y1Double = Double.Parse(Y1TextBox.Text)
                Try
                    X2Double = Double.Parse(X2TextBox.Text)
                    Try
                        Y2Double = Double.Parse(Y2TextBox.Text)
                        MidpointXDouble = (X1Double + X2Double) / 2
                        MidpointYDouble = (Y1Double + Y2Double) / 2
                        LengthDouble = ((X2Double - X1Double) ^ 2 + (Y2Double - Y1Double) ^ 2) ^ (1 / 2)
                        SegmentLengthTextBox.Text = LengthDouble.ToString()
                        MidpointTextBox.Text = "(" & MidpointXDouble & ", " & MidpointYDouble & ")"
                        FormulaTextBox.Text = "( [" & X1Double & " + " & X2Double & "] / 2, [" & Y1Double & " + " &
                            Y2Double & "] / 2)"
                        LengthFormulaTextBox.Text = "( [" & X2Double & " - " & X1Double & "]^2 + [" & Y2Double &
                            " - " & Y1Double & "]^2) ^(1/2)"
                    Catch ex As Exception
                        'clear active errors
                        ErrorProvider1.SetError(Y2TextBox, "")

                        'catch non numeric Y2
                        ErrorProvider1.SetError(Y2TextBox, "Y2 must be numeric")
                        Y2TextBox.Focus()
                    End Try
                Catch ex As Exception
                    'clear active errors
                    ErrorProvider1.SetError(X2TextBox, "")

                    'catch non numeric X2
                    ErrorProvider1.SetError(X2TextBox, "X2 must be numeric")
                    X2TextBox.Focus()
                End Try
            Catch ex As Exception
                'clear active errors
                ErrorProvider1.SetError(Y1TextBox, "")

                'catch non numeric Y12
                ErrorProvider1.SetError(Y1TextBox, "Y1 must be numeric")
                Y1TextBox.Focus()
            End Try
        Catch ex As Exception
            'clear active errors
            ErrorProvider1.SetError(X1TextBox, "")

            'catch non numeric X1
            ErrorProvider1.SetError(X1TextBox, "X1 must be numeric")
            X1TextBox.Focus()
        End Try
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        X1TextBox.Text = ""
        Y1TextBox.Text = ""
        X2TextBox.Text = ""
        Y2TextBox.Text = ""
        FormulaTextBox.Text = ""
        LengthFormulaTextBox.Text = ""
        SegmentLengthTextBox.Text = ""
        MidpointTextBox.Text = ""
    End Sub
End Class