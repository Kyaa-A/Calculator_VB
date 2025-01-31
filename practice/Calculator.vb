Public Class Calculator
    'bro
    Dim firstOperand As Double
    Dim secondOperand As Double
    Dim [operator] As String
    Dim isOperatorClicked As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Clear()
        TextBox2.Clear()
        firstOperand = 0
        secondOperand = 0
        [operator] = ""
        isOperatorClicked = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        'For "="
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            secondOperand = Double.Parse(TextBox1.Text)
            Dim result As Double = 0

            Select Case [operator]
                Case "+"
                    result = firstOperand + secondOperand
                Case "-"
                    result = firstOperand - secondOperand
                Case "*"
                    result = firstOperand * secondOperand
                Case "/"
                    If secondOperand <> 0 Then
                        result = firstOperand / secondOperand
                    Else
                        MessageBox.Show("Cannot divide by zero!")
                        Return
                    End If
            End Select

            TextBox2.Text = TextBox2.Text + TextBox1.Text + " = " + result.ToString()
            TextBox1.Text = result.ToString()
            isOperatorClicked = False
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        'For "+"
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            firstOperand = Double.Parse(TextBox1.Text)
            [operator] = "+"
            TextBox2.Text = TextBox1.Text + " + "
            TextBox1.Clear()
            isOperatorClicked = True
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'For "-"
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            firstOperand = Double.Parse(TextBox1.Text)
            [operator] = "-"
            TextBox2.Text = TextBox1.Text + " - "
            TextBox1.Clear()
            isOperatorClicked = True
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'For "*"
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            firstOperand = Double.Parse(TextBox1.Text)
            [operator] = "*"
            TextBox2.Text = TextBox1.Text + " * "
            TextBox1.Clear()
            isOperatorClicked = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'For "/"
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            firstOperand = Double.Parse(TextBox1.Text)
            [operator] = "/"
            TextBox2.Text = TextBox1.Text + " / "
            TextBox1.Clear()
            isOperatorClicked = True
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'For "."
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text = TextBox1.Text + "."
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Try
            ' Use ProcessStartInfo to open the URL in the default browser
            Dim psi As New ProcessStartInfo("https://github.com/Kyaa-A")
            psi.UseShellExecute = True
            Process.Start(psi)
        Catch ex As Exception
            ' Handle any errors
            MessageBox.Show("Error opening URL: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Calculator_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ' Open Circle Window Form
        Dim circleForm As New Circle()
        circleForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ' Open Rectangle Window Form
        Dim rectangleForm As New Rectangle()
        rectangleForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        ' Open Triangle Window Form
        Dim triangleForm As New Triangle()
        triangleForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        ' Open Square Window Form
        Dim squareForm As New Ellipse()
        squareForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ' Open Trapezoid Window Form
        Dim trapezoidForm As New Trapezoid()
        trapezoidForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        'Update Done
    End Sub
End Class