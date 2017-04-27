<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BaseForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadraticToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadraitEquationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuadraticFormEquationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CylindarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SphereToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AreaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CircleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TriangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RectangleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DistanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConvertToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateLineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalulateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.FormulaTextBox = New System.Windows.Forms.TextBox()
        Me.FormulaLabel = New System.Windows.Forms.Label()
        Me.ProgrammerLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1681, 49)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EquationsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(75, 45)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'EquationsToolStripMenuItem
        '
        Me.EquationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuadraticToolStripMenuItem, Me.VolumeToolStripMenuItem, Me.AreaToolStripMenuItem, Me.DistanceToolStripMenuItem, Me.LineToolStripMenuItem})
        Me.EquationsToolStripMenuItem.Name = "EquationsToolStripMenuItem"
        Me.EquationsToolStripMenuItem.Size = New System.Drawing.Size(263, 46)
        Me.EquationsToolStripMenuItem.Text = "&Equations"
        '
        'QuadraticToolStripMenuItem
        '
        Me.QuadraticToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuadraitEquationToolStripMenuItem, Me.QuadraticFormEquationToolStripMenuItem})
        Me.QuadraticToolStripMenuItem.Name = "QuadraticToolStripMenuItem"
        Me.QuadraticToolStripMenuItem.Size = New System.Drawing.Size(262, 46)
        Me.QuadraticToolStripMenuItem.Text = "&Quadratic"
        '
        'QuadraitEquationToolStripMenuItem
        '
        Me.QuadraitEquationToolStripMenuItem.Name = "QuadraitEquationToolStripMenuItem"
        Me.QuadraitEquationToolStripMenuItem.Size = New System.Drawing.Size(464, 46)
        Me.QuadraitEquationToolStripMenuItem.Text = "Quadrait &Equation"
        '
        'QuadraticFormEquationToolStripMenuItem
        '
        Me.QuadraticFormEquationToolStripMenuItem.Name = "QuadraticFormEquationToolStripMenuItem"
        Me.QuadraticFormEquationToolStripMenuItem.Size = New System.Drawing.Size(464, 46)
        Me.QuadraticFormEquationToolStripMenuItem.Text = "Quadratic &Form Equation"
        '
        'VolumeToolStripMenuItem
        '
        Me.VolumeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CylindarToolStripMenuItem, Me.SphereToolStripMenuItem, Me.ConeToolStripMenuItem})
        Me.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem"
        Me.VolumeToolStripMenuItem.Size = New System.Drawing.Size(262, 46)
        Me.VolumeToolStripMenuItem.Text = "&Volume"
        '
        'CylindarToolStripMenuItem
        '
        Me.CylindarToolStripMenuItem.Name = "CylindarToolStripMenuItem"
        Me.CylindarToolStripMenuItem.Size = New System.Drawing.Size(343, 46)
        Me.CylindarToolStripMenuItem.Text = "C&ylinder / Prism"
        '
        'SphereToolStripMenuItem
        '
        Me.SphereToolStripMenuItem.Name = "SphereToolStripMenuItem"
        Me.SphereToolStripMenuItem.Size = New System.Drawing.Size(343, 46)
        Me.SphereToolStripMenuItem.Text = "&Sphere"
        '
        'ConeToolStripMenuItem
        '
        Me.ConeToolStripMenuItem.Name = "ConeToolStripMenuItem"
        Me.ConeToolStripMenuItem.Size = New System.Drawing.Size(343, 46)
        Me.ConeToolStripMenuItem.Text = "&Cone / pyramid"
        '
        'AreaToolStripMenuItem
        '
        Me.AreaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CircleToolStripMenuItem, Me.TriangleToolStripMenuItem, Me.RectangleToolStripMenuItem})
        Me.AreaToolStripMenuItem.Name = "AreaToolStripMenuItem"
        Me.AreaToolStripMenuItem.Size = New System.Drawing.Size(262, 46)
        Me.AreaToolStripMenuItem.Text = "&Area"
        '
        'CircleToolStripMenuItem
        '
        Me.CircleToolStripMenuItem.Name = "CircleToolStripMenuItem"
        Me.CircleToolStripMenuItem.Size = New System.Drawing.Size(263, 46)
        Me.CircleToolStripMenuItem.Text = "&Circle"
        '
        'TriangleToolStripMenuItem
        '
        Me.TriangleToolStripMenuItem.Name = "TriangleToolStripMenuItem"
        Me.TriangleToolStripMenuItem.Size = New System.Drawing.Size(263, 46)
        Me.TriangleToolStripMenuItem.Text = "&Triangle"
        '
        'RectangleToolStripMenuItem
        '
        Me.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem"
        Me.RectangleToolStripMenuItem.Size = New System.Drawing.Size(263, 46)
        Me.RectangleToolStripMenuItem.Text = "&Rectangle"
        '
        'DistanceToolStripMenuItem
        '
        Me.DistanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConvertToolStripMenuItem})
        Me.DistanceToolStripMenuItem.Name = "DistanceToolStripMenuItem"
        Me.DistanceToolStripMenuItem.Size = New System.Drawing.Size(262, 46)
        Me.DistanceToolStripMenuItem.Text = "&Distance"
        '
        'ConvertToolStripMenuItem
        '
        Me.ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem"
        Me.ConvertToolStripMenuItem.Size = New System.Drawing.Size(237, 46)
        Me.ConvertToolStripMenuItem.Text = "&Convert"
        '
        'LineToolStripMenuItem
        '
        Me.LineToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateLineToolStripMenuItem})
        Me.LineToolStripMenuItem.Name = "LineToolStripMenuItem"
        Me.LineToolStripMenuItem.Size = New System.Drawing.Size(262, 46)
        Me.LineToolStripMenuItem.Text = "&Line"
        '
        'CalculateLineToolStripMenuItem
        '
        Me.CalculateLineToolStripMenuItem.Name = "CalculateLineToolStripMenuItem"
        Me.CalculateLineToolStripMenuItem.Size = New System.Drawing.Size(315, 46)
        Me.CalculateLineToolStripMenuItem.Text = "&Calculate Line"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(260, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(263, 46)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculateToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(80, 45)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'CalculateToolStripMenuItem
        '
        Me.CalculateToolStripMenuItem.Name = "CalculateToolStripMenuItem"
        Me.CalculateToolStripMenuItem.Size = New System.Drawing.Size(253, 46)
        Me.CalculateToolStripMenuItem.Text = "C&alculate"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(253, 46)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(92, 45)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(215, 46)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'CalulateButton
        '
        Me.CalulateButton.Location = New System.Drawing.Point(1007, 972)
        Me.CalulateButton.Name = "CalulateButton"
        Me.CalulateButton.Size = New System.Drawing.Size(185, 78)
        Me.CalulateButton.TabIndex = 1
        Me.CalulateButton.Text = "&Calculate"
        Me.CalulateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(1242, 972)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(185, 78)
        Me.ClearButton.TabIndex = 2
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.CausesValidation = False
        Me.ExitButton.Location = New System.Drawing.Point(1477, 972)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(185, 78)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'FormulaTextBox
        '
        Me.FormulaTextBox.Location = New System.Drawing.Point(114, 944)
        Me.FormulaTextBox.Name = "FormulaTextBox"
        Me.FormulaTextBox.ReadOnly = True
        Me.FormulaTextBox.Size = New System.Drawing.Size(515, 38)
        Me.FormulaTextBox.TabIndex = 15
        Me.FormulaTextBox.TabStop = False
        '
        'FormulaLabel
        '
        Me.FormulaLabel.AutoSize = True
        Me.FormulaLabel.Location = New System.Drawing.Point(108, 893)
        Me.FormulaLabel.Name = "FormulaLabel"
        Me.FormulaLabel.Size = New System.Drawing.Size(119, 32)
        Me.FormulaLabel.TabIndex = 14
        Me.FormulaLabel.Text = "Formula"
        '
        'ProgrammerLabel
        '
        Me.ProgrammerLabel.AutoSize = True
        Me.ProgrammerLabel.Location = New System.Drawing.Point(1249, 60)
        Me.ProgrammerLabel.Name = "ProgrammerLabel"
        Me.ProgrammerLabel.Size = New System.Drawing.Size(420, 32)
        Me.ProgrammerLabel.TabIndex = 16
        Me.ProgrammerLabel.Text = "Programmed by:  Nick Cavallaro"
        '
        'PictureBox1
        '
        Me.PictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.InitialImage = Global.Math_helper.My.Resources.Resources.area_of_triangle
        Me.PictureBox1.Location = New System.Drawing.Point(855, 211)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(794, 691)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'BaseForm
        '
        Me.AcceptButton = Me.CalulateButton
        Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1681, 1074)
        Me.Controls.Add(Me.ProgrammerLabel)
        Me.Controls.Add(Me.FormulaTextBox)
        Me.Controls.Add(Me.FormulaLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalulateButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "BaseForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cavallaro's Math Helper"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadraticToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VolumeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AreaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DistanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CalculateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalulateButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents QuadraitEquationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuadraticFormEquationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CylindarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SphereToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CircleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TriangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RectangleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConvertToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculateLineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormulaTextBox As TextBox
    Friend WithEvents FormulaLabel As Label
    Friend WithEvents ProgrammerLabel As Label
End Class
