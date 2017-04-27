Imports System.ComponentModel
Public Class Quadratic_Equation
    Dim ErrorProvider1 As New ErrorProvider
    Private Sub Quadratic_Equation_Load(sender As Object, e As EventArgs) Handles Me.Load
        'set graphic
        PictureBox1.Image = My.Resources.quadratic_formula

        'hide numerator and denominator labels
        NumeratorLabel.Visible = False
        DivisionLineLabel.Visible = False
        DenominatorLabel.Visible = False
        ImaginaryExplainLabel.Visible = False
    End Sub
    Public Overrides Sub ClearButton_Click(sender As Object, e As EventArgs)
        'clear all text boxes and hide all labels
        ValueATextBox.Text = ""
        ValueBTextBox.Text = ""
        ValueCTextBox.Text = ""
        Solution1TextBox.Text = ""
        Solution2TextBox.Text = ""
        FormulaTextBox.Text = ""
        NumeratorLabel.Visible = False
        DivisionLineLabel.Visible = False
        DenominatorLabel.Visible = False
        ImaginaryExplainLabel.Visible = False
    End Sub
    Public Overrides Sub CalulateButton_Click(sender As Object, e As EventArgs)
        Dim ValueADouble, ValueBDouble, ValueCDouble, Solution1Double, Solution2Double, DiscriminantDouble,
            DivisorDouble, DiscriminantDoubleTest As Double

        Try
            'set value of a to value entered in text box "a"
            ValueADouble = Double.Parse(ValueATextBox.Text)
            Try
                'Set value of b to value entered in text box "b"
                ValueBDouble = Double.Parse(ValueBTextBox.Text)
                Try
                    'set value of c to value entered in text box "c"
                    ValueCDouble = Double.Parse(ValueCTextBox.Text)

                    'calculate discriminant
                    DiscriminantDoubleTest = ((ValueBDouble ^ 2) - 4 * ValueADouble * ValueCDouble)
                    If DiscriminantDoubleTest >= 0 Then
                        'if discriminant test calculates positive, assign as discriminant
                        DiscriminantDouble = DiscriminantDoubleTest
                    Else
                        'if discriminant test calculates negative, multiply by negative 1
                        DiscriminantDouble = DiscriminantDoubleTest * -1
                    End If

                    'calculate divisor
                    DivisorDouble = (2 * ValueADouble)

                    'calculate solution 1
                    Solution1Double = ((-ValueBDouble) + (DiscriminantDouble ^ (1 / 2))) / DivisorDouble

                    'calculate solution 2
                    Solution2Double = ((-ValueBDouble) - (DiscriminantDouble ^ (1 / 2))) / DivisorDouble

                    'display solutions
                    If DiscriminantDoubleTest >= 0 Then
                        'if discriminant calculated as positive, print solutions in text box
                        Solution1TextBox.Text = Solution1Double.ToString()
                        Solution2TextBox.Text = Solution2Double.ToString()
                    Else
                        'if discriminant calculated as negative, print solutions and "i" (imaginary) to text box
                        Solution1TextBox.Text = Solution1Double & " i"
                        Solution2TextBox.Text = Solution2Double & " i"
                    End If

                    'show the numerator and denominator
                    NumeratorLabel.Visible = True
                    DivisionLineLabel.Visible = True
                    DenominatorLabel.Visible = True
                    If DiscriminantDoubleTest >= 0 Then
                        'if discriminant calculated as positive, print equation in numerator text box
                        NumeratorLabel.Text = -ValueBDouble & " ± √ " & DiscriminantDouble
                    Else
                        'if discriminant calculated as negative, print equation in numerator text box with "i" (imaginary) appended
                        NumeratorLabel.Text = -ValueBDouble & " ± √ " & DiscriminantDouble & " i"
                    End If
                    DenominatorLabel.Text = DivisorDouble.ToString()

                    'show or hide the imaginary explain label
                    If DiscriminantDoubleTest >= 0 Then
                        'if discriminant calculated as positive, hide the explanation of imaginary numbers
                        ImaginaryExplainLabel.Visible = False
                    Else
                        'if discriminant calculated as negative, show the explanation of imaginary numbers
                        ImaginaryExplainLabel.Visible = True

                    End If
                    'display quadratic equation with given values in place of variables
                    FormulaTextBox.Text = "( " & -ValueBDouble & " ± √ [ " & ValueBDouble & "^2] - [4 * " &
                        ValueADouble & " * " & ValueCDouble & "]) / 2 * " & ValueADouble

                Catch ex As Exception
                    'clear active errors
                    ErrorProvider1.SetError(ValueCTextBox, "")
                    'unable to parse textbox C
                    ErrorProvider1.SetError(ValueCTextBox, "c must be a numeric value.")
                End Try
            Catch ex As Exception
                'clear active errors
                ErrorProvider1.SetError(ValueBTextBox, "")
                'unable to parse textbox b
                ErrorProvider1.SetError(ValueBTextBox, "b must be anumeric value")
            End Try
        Catch ex As Exception
            'clear active errors
            ErrorProvider1.SetError(ValueATextBox, "")
            'unable to parse textbox a
            ErrorProvider1.SetError(ValueATextBox, "a must be a numeric value")
        End Try
    End Sub
    Private Sub ValueATextBox_Validating(sender As Object, e As CancelEventArgs) Handles ValueATextBox.Validating
        'clear existing errors
        ErrorProvider1.SetError(ValueATextBox, "")

        'check for empty string
        If ValueATextBox.Text = "" Then
            ErrorProvider1.SetError(ValueATextBox, "Required Field")
            e.Cancel = True
        End If
    End Sub
    Private Sub ValueBTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ValueBTextBox.Validating
        'clear existing errors
        ErrorProvider1.SetError(ValueBTextBox, "")

        'check for empty string
        If ValueBTextBox.Text = "" Then
            ErrorProvider1.SetError(ValueBTextBox, "Required Field")
            e.Cancel = True
        End If
    End Sub
    Private Sub ValueCTextBox_Validating(sender As Object, e As CancelEventArgs) Handles ValueCTextBox.Validating
        'clear existing errors
        ErrorProvider1.SetError(ValueCTextBox, "")

        'check for empty string
        If ValueCTextBox.Text = "" Then
            ErrorProvider1.SetError(ValueCTextBox, "Required Field")
            e.Cancel = True
        End If
    End Sub
    Private Sub Quadratic_Equation_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'dont allow validation to prevent closing
        e.Cancel = False
    End Sub


End Class