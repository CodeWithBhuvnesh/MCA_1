Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer = Val(TextBox1.Text)
        Dim n0 As Integer = 0
        Dim n1 As Integer = 1
        Dim i As Integer = 1
        Dim n2 As Integer
        Dim str As String = n0.ToString() + " " + n1.ToString()


        While i <= n

            n2 = n0 + n1
            str = str + " " + n2.ToString()
            n0 = n1
            n1 = n2
            i = i + 1

        End While

        Label2.Text = str


    End Sub
End Class