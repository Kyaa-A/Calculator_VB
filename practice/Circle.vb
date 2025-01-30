Public Class Circle

    ' Declare a variable to hold the radius
    Private radius As Double
    Private area As Double

    Private Sub Circle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Answer Will Be Displayed Here (initialize as empty on load)
        Output.Text = ""
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        ' Show the Calculator (home) form
        Dim calculatorForm As New Calculator()
        calculatorForm.Show()
        Me.Hide() ' Hide the current form (Circle)
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        ' This button can be used for any other function if needed.
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
        Dim squareForm As New Square()
        squareForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        ' Open Trapezoid Window Form
        Dim trapezoidForm As New Trapezoid()
        trapezoidForm.Show()
        Me.Hide() ' Hide the current form instead of closing it
    End Sub

    Private Sub Input_TextChanged(sender As Object, e As EventArgs) Handles Input.TextChanged
        ' When input changes, reset the output to empty
        Output.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Button for Calculation: Calculate the area of the circle when clicked
        Try
            ' Get the radius from the input field and parse it to a double
            radius = Double.Parse(Input.Text)

            ' Calculate the area of the circle (Area = π * r^2)
            area = Math.PI * Math.Pow(radius, 2)

            ' Display the result in the Output TextBox
            Output.Text = area.ToString("F2") ' Display with 2 decimal places
        Catch ex As Exception
            ' If there is an error (e.g., invalid input), show an error message
            Output.Text = "Invalid input. Please enter a valid number."
        End Try
    End Sub

    Private Sub Output_Click(sender As Object, e As EventArgs) Handles Output.Click

    End Sub
End Class
