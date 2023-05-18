Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Esum As Integer = 0
        Dim Osum As Integer = 0
        Dim start As Integer = Val(TextBox1.Text)
        Dim ending As Integer = Val(TextBox2.Text)

        While start <= ending
            If start Mod 2 = 0 Then
                Esum += start
            Else
                Osum += start
            End If

            start += 1

        End While
        TextBox3.Text = Esum
        TextBox4.Text = Osum

    End Sub
End Class