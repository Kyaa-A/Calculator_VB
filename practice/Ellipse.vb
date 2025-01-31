Public Class Ellipse
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ' Show the Calculator (home) form
        Dim calculatorForm As New Calculator()
        calculatorForm.Show()
        Me.Hide() ' Hide the current form (Circle)
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
        ' Placeholder for Button23 functionality
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ' Open Trapezoid Window Form
        Dim trapezoidForm As New Trapezoid()
        trapezoidForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Input Semi-major Axes (a)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Input Semi-minor Axes (b)
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Output will show here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Calculate Area for solving area of Ellipse

        ' Declare variables to store semi-major axis (a) and semi-minor axis (b)
        Dim a As Double
        Dim b As Double

        ' Try to parse the input from TextBox1 and TextBox2
        If Double.TryParse(TextBox1.Text, a) AndAlso Double.TryParse(TextBox2.Text, b) Then
            ' Check if a and b are positive
            If a > 0 AndAlso b > 0 Then
                ' Calculate the area using the formula: Area = π * a * b
                Dim area As Double = Math.PI * a * b

                ' Display the result in Label4
                Label4.Text = area.ToString("F2") ' Format to 2 decimal places
            Else
                ' Handle non-positive input
                Label4.Text = "Must be positive numbers."
            End If
        Else
            ' Handle invalid input
            Label4.Text = "Invalid input"
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Ellipse_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub


End Class