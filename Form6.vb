Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a As Integer = Val(Interaction.InputBox("Value of A ", DefaultResponse:="0"))
        Dim b As Integer = Val(Interaction.InputBox("Value of B ", DefaultResponse:="0"))
        Dim c As Integer = Val(Interaction.InputBox("Value of C ", DefaultResponse:="0"))

        If a > b And a > c Then
            MessageBox.Show("A is greater")
        ElseIf b > c Then
            MessageBox.Show("B is greater")
        Else
            MessageBox.Show("C is greater")
        End If

        Application.Exit()


    End Sub
End Class