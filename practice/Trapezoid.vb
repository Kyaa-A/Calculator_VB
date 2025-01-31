Public Class Trapezoid
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
        ' Placeholder for Button24 functionality
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ' Show the Calculator (home) form
        Dim calculatorForm As New Calculator()
        calculatorForm.Show()
        Me.Hide() ' Hide the current form (Circle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        ' Base 1 input
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        ' Base 2 input
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        ' Height input
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        ' Output will be displayed here
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Calculate Area for solving area of Trapezoid

        ' Declare variables to store Base1, Base2, and Height
        Dim base1 As Double
        Dim base2 As Double
        Dim height As Double

        ' Try to parse the input from TextBox1, TextBox2, and TextBox3
        If Double.TryParse(TextBox1.Text, base1) AndAlso Double.TryParse(TextBox2.Text, base2) AndAlso Double.TryParse(TextBox3.Text, height) Then
            ' Check if Base1, Base2, and Height are positive
            If base1 > 0 AndAlso base2 > 0 AndAlso height > 0 Then
                ' Calculate the area using the formula: Area = ½ × (Base1 + Base2) × Height
                Dim area As Double = 0.5 * (base1 + base2) * height

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

    Private Sub Label5_Click_1(sender As Object, e As EventArgs) Handles Label5.Click
        ' Placeholder for Label5 functionality
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        ' Placeholder for Label3 functionality
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click
        ' Placeholder for Label2 functionality
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        ' Placeholder for Label1 functionality
    End Sub
End Class