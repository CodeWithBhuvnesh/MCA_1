Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        Dim b As Integer

        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        a = a + b
        b = a - b
        a = a - b

        TextBox1.Text = a
        TextBox2.Text = b



    End Sub
End Class