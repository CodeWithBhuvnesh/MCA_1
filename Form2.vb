Public Class Form2


    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        TextBox3.Clear()
        TextBox3.Text = (TextBox1.Text) + Val(TextBox2.Text)

    End Sub

    Private Sub MinBtn_Click(sender As Object, e As EventArgs) Handles MinBtn.Click
        TextBox3.Clear()
        TextBox3.Text = (TextBox1.Text) - Val(TextBox2.Text)
    End Sub

    Private Sub MulBtn_Click(sender As Object, e As EventArgs) Handles MulBtn.Click
        TextBox3.Clear()
        TextBox3.Text = (TextBox1.Text) * Val(TextBox2.Text)
    End Sub

    Private Sub DivBtn_Click(sender As Object, e As EventArgs) Handles DivBtn.Click
        TextBox3.Clear()
        TextBox3.Text = (TextBox1.Text) / Val(TextBox2.Text)
    End Sub
End Class