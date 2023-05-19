Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = Val(TextBox1.Text)
        Dim Pn As Integer = 0
        Dim n1 As Integer = n
        Dim sum As Integer = 0
        Dim count As Integer = 0
        Dim str As String = ""

        While n > 0

            Pn = Pn * 10 + (n Mod 10)
            sum += n Mod 10
            count += 1
            n /= 10

        End While

        str = "Sum of digits= " + sum.ToString() + " | " +
            "Number of digits= " + count.ToString() + " | "

        If n1 = Pn Then
            MessageBox.Show(str + "Number is Palindrom")
        Else
            MessageBox.Show(str + "Number is Not Palindrom")
        End If

        TextBox1.Clear()

    End Sub
End Class