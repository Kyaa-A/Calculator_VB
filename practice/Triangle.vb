Public Class Triangle
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
        ' Placeholder for Button21 functionality
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
        ' Show the Calculator (home) form
        Dim calculatorForm As New Calculator()
        calculatorForm.Show()
        Me.Hide() ' Hide the current form (Circle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Edge 1 (a) Input
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Edge 2 (b) Input
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ' Edge 3 (c) Input
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Output will be displayed here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Calculate Area for solving area of Triangle

        ' Declare variables to store the lengths of the edges
        Dim a As Double
        Dim b As Double
        Dim c As Double

        ' Try to parse the input from TextBox1, TextBox2, and TextBox3
        If Double.TryParse(TextBox1.Text, a) AndAlso Double.TryParse(TextBox2.Text, b) AndAlso Double.TryParse(TextBox3.Text, c) Then
            ' Check if the edges form a valid triangle
            If a + b > c AndAlso a + c > b AndAlso b + c > a Then
                ' Calculate the semi-perimeter (s)
                Dim s As Double = (a + b + c) / 2

                ' Calculate the area using Heron's Formula
                Dim area As Double = Math.Sqrt(s * (s - a) * (s - b) * (s - c))

                ' Display the result in Label4
                Label4.Text = area.ToString("F2") ' Format to 2 decimal places
            Else
                ' Handle invalid triangle edges
                Label4.Text = "Invalid triangle. The sum of any two edges must be greater than the third."
            End If
        Else
            ' Handle invalid input
            Label4.Text = "Invalid input"
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        ' Placeholder for Label5 functionality
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Placeholder for Label2 functionality
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Placeholder for Label1 functionality
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Placeholder for Label3 functionality
    End Sub



End Class