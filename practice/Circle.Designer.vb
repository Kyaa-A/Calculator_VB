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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Circle))
        Button24 = New Button()
        Button23 = New Button()
        Button22 = New Button()
        Button21 = New Button()
        Button20 = New Button()
        Button19 = New Button()
        Label1 = New Label()
        Input = New TextBox()
        Label2 = New Label()
        Output = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(25, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(103, 28)
        Label1.TabIndex = 33
        Label1.Text = "Radius (r)"
        ' 
        ' Input
        ' 
        Input.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Input.Location = New Point(134, 29)
        Input.Multiline = True
        Input.Name = "Input"
        Input.Size = New Size(156, 33)
        Input.TabIndex = 34
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.White
        Label2.Location = New Point(46, 65)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 28)
        Label2.TabIndex = 35
        Label2.Text = "Result: "
        ' 
        ' Output
        ' 
        Output.AutoSize = True
        Output.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Output.ForeColor = Color.White
        Output.Location = New Point(134, 65)
        Output.Name = "Output"
        Output.Size = New Size(0, 28)
        Output.TabIndex = 36
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(228), CByte(203), CByte(195))
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.FromArgb(CByte(55), CByte(63), CByte(93))
        Button1.Location = New Point(359, 402)
        Button1.Name = "Button1"
        Button1.Size = New Size(145, 46)
        Button1.TabIndex = 37
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(100), CByte(116), CByte(154))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Input)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Output)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(280, 259)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(308, 125)
        Panel2.TabIndex = 38
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(347, 63)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(181, 175)
        PictureBox1.TabIndex = 39
        PictureBox1.TabStop = False
        ' 
        ' Circle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(55), CByte(63), CByte(93))
        ClientSize = New Size(661, 528)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        Controls.Add(Button1)
        Controls.Add(Button24)
        Controls.Add(Button23)
        Controls.Add(Button22)
        Controls.Add(Button21)
        Controls.Add(Button20)
        Controls.Add(Button19)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Name = "Circle"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Circle"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button24 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button21 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Input As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Output As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
