' Codeword Puzzle
' Created by Katherine Cater on 9/26/2015
' Last Modified: 10/10/2015


Public Class StartScreen

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim random As New Random()
        Dim frmGridOne As New GridOne()
        Dim frmGridTwo As New GridTwo()
        Dim RandomGrid As Array = {frmGridOne, frmGridTwo}
        Dim chosenGrid = random.Next(RandomGrid.Length)

        If chosenGrid = 0 Then
            frmGridOne.ShowDialog()
        ElseIf chosenGrid = 1 Then
            frmGridTwo.ShowDialog()
        End If
    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click
        Dim frmHighScores As New HighScores()
        frmHighScores.ShowDialog()
    End Sub

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim frmGridOne As New GridOne()
        Dim frmGridTwo As New GridTwo()
        If frmGridOne.Visible = True Then
            frmGridOne.Close()
        End If
        If frmGridTwo.Visible = True Then
            frmGridTwo.Close()
        End If
    End Sub
End Class
