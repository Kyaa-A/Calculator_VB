<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Circle
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
        Button24 = New Button()
        Button23 = New Button()
        Button22 = New Button()
        Button21 = New Button()
        Button20 = New Button()
        Button19 = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Input = New TextBox()
        Label2 = New Label()
        Output = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button24
        ' 
        Button24.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Button24.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button24.ForeColor = SystemColors.ControlLightLight
        Button24.Location = New Point(25, 445)
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
        Button23.Location = New Point(25, 371)
        Button23.Name = "Button23"
        Button23.Size = New Size(174, 57)
        Button23.TabIndex = 30
        Button23.Text = "Ellipse"
        Button23.UseVisualStyleBackColor = False
        ' 
        ' Button22
        ' 
        Button22.BackColor = Color.FromArgb(CByte(55), CByte(63), CByte(93))
        Button22.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Button22.ForeColor = SystemColors.ControlLightLight
        Button22.Location = New Point(25, 289)
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
        Button21.Location = New Point(25, 205)
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
        Button20.Location = New Point(25, 124)
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
        Button19.Location = New Point(25, 28)
        Button19.Name = "Button19"
        Button19.Size = New Size(174, 60)
        Button19.TabIndex = 26
        Button19.Text = "Basic Calculator"
        Button19.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(337, 85)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(193, 155)
        Panel1.TabIndex = 32
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(297, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 33
        Label1.Text = "Radius (r)"
        ' 
        ' Input
        ' 
        Input.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Input.Location = New Point(406, 281)
        Input.Multiline = True
        Input.Name = "Input"
        Input.Size = New Size(156, 33)
        Input.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(318, 317)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 28)
        Label2.TabIndex = 35
        Label2.Text = "Result: "
        ' 
        ' Output
        ' 
        Output.AutoSize = True
        Output.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Output.Location = New Point(406, 317)
        Output.Name = "Output"
        Output.Size = New Size(127, 28)
        Output.TabIndex = 36
        Output.Text = "answer here"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(375, 371)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 37
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Circle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(661, 528)
        Controls.Add(Button1)
        Controls.Add(Output)
        Controls.Add(Label2)
        Controls.Add(Input)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Button24)
        Controls.Add(Button23)
        Controls.Add(Button22)
        Controls.Add(Button21)
        Controls.Add(Button20)
        Controls.Add(Button19)
        Name = "Circle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Circle"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Input As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Output As Label
    Friend WithEvents Button1 As Button
End Class
