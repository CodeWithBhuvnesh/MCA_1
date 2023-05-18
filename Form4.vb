Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim y As Integer = Val(TextBox1.Text)

        If (y Mod 4 = 0 And y Mod 100 <> 0) Or
            y Mod 400 = 0 Then

            MessageBox.Show("Leap Year")
            TextBox1.Clear()

        Else
            MessageBox.Show("Non Leap Year")
            TextBox1.Clear()

        End If




    End Sub
End Class