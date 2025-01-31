Public Class Rectangle
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ' Open Circle Window Form
        Dim circleForm As New Circle()
        circleForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        ' Placeholder for Button20 functionality
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
        ' Show the Calculator (home) form
        Dim calculatorForm As New Calculator()
        calculatorForm.Show()
        Me.Hide() ' Hide the current form (Circle)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Placeholder for Label1 functionality
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Placeholder for Label2 functionality
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Length Input
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Width Input
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Output will be displayed here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Button for calculating the area of a rectangle

        ' Declare variables to store length and width
        Dim length As Double
        Dim width As Double

        ' Try to parse the input from TextBox1 and TextBox2
        If Double.TryParse(TextBox1.Text, length) AndAlso Double.TryParse(TextBox2.Text, width) Then
            ' Check if length and width are positive
            If length > 0 AndAlso width > 0 Then
                ' Calculate the area
                Dim area As Double = length * width

                ' Display the result in Label4
                Label4.Text = area.ToString()
            Else
                ' Handle non-positive input
                Label4.Text = "Must be positive numbers."
            End If
        Else
            ' Handle invalid input
            Label4.Text = "Invalid input"
        End If
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Rectangle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class