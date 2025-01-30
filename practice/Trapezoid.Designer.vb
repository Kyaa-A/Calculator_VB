<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trapezoid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        Button24 = New Button()
        Button23 = New Button()
        Button22 = New Button()
        Button21 = New Button()
        Button20 = New Button()
        Button19 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(268, 251)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 1
        TextBox1.Text = "tRAPEZOID"
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.FromArgb(CByte(55), CByte(63), CByte(93))
        Button24.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button24.ForeColor = SystemColors.ControlLightLight
        Button24.Location = New Point(27, 446)
        Button24.Name = "Button24"
        Button24.Size = New Size(174, 57)
        Button24.TabIndex = 31
        Button24.Text = "Trapezoid"
        Button24.UseVisualStyleBackColor = False
        ' 
        ' Button23
        ' 
        Button23.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button23.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button23.ForeColor = SystemColors.ControlLightLight
        Button23.Location = New Point(27, 371)
        Button23.Name = "Button23"
        Button23.Size = New Size(174, 57)
        Button23.TabIndex = 30
        Button23.Text = "Square"
        Button23.UseVisualStyleBackColor = False
        ' 
        ' Button22
        ' 
        Button22.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button22.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button22.ForeColor = SystemColors.ControlLightLight
        Button22.Location = New Point(27, 289)
        Button22.Name = "Button22"
        Button22.Size = New Size(174, 59)
        Button22.TabIndex = 29
        Button22.Text = "Circle"
        Button22.UseVisualStyleBackColor = False
        ' 
        ' Button21
        ' 
        Button21.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button21.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button21.ForeColor = SystemColors.ControlLightLight
        Button21.Location = New Point(27, 206)
        Button21.Name = "Button21"
        Button21.Size = New Size(174, 59)
        Button21.TabIndex = 28
        Button21.Text = "Triangle"
        Button21.UseVisualStyleBackColor = False
        ' 
        ' Button20
        ' 
        Button20.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button20.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button20.ForeColor = SystemColors.ControlLightLight
        Button20.Location = New Point(27, 124)
        Button20.Name = "Button20"
        Button20.Size = New Size(174, 60)
        Button20.TabIndex = 27
        Button20.Text = "Rectangle"
        Button20.UseVisualStyleBackColor = False
        ' 
        ' Button19
        ' 
        Button19.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button19.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button19.ForeColor = SystemColors.ControlLightLight
        Button19.Location = New Point(27, 28)
        Button19.Name = "Button19"
        Button19.Size = New Size(174, 60)
        Button19.TabIndex = 26
        Button19.Text = "Basic Calculator"
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Trapezoid
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 528)
        Controls.Add(Button24)
        Controls.Add(Button23)
        Controls.Add(Button22)
        Controls.Add(Button21)
        Controls.Add(Button20)
        Controls.Add(Button19)
        Controls.Add(TextBox1)
        Name = "Trapezoid"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Trapezoid"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
End Class
