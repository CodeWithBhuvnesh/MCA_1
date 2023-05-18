Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Val(TextBox1.Text) > Val(TextBox2.Text) Then
            MessageBox.Show("Value 1 is greater")
        Else
            MessageBox.Show("Value 2 is greater")
        End If

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub
End Class