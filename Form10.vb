Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer = Val(TextBox1.Text)
        Dim fact As Integer = 1

        For i As Integer = n To 1 Step -1

            fact = fact * i

        Next

        Label2.Visible = True
        Label2.Text = fact

    End Sub
End Class