Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As Integer = Val(TextBox1.Text)
        Dim str As String = ""

        For i As Integer = 1 To 10 Step 1

            str = str + (n * i).ToString() + "  "

        Next

        Label2.Visible = True
        Label2.Text = str

    End Sub
End Class