' Codeword GUI with changing form
' Created by Katherine Cater on 9/26/2015
' Last Modified: 9/28/2015
' Notes: The tablepanellayout is not completed. It currently just says label whereas when
' I add in the rest of the code it will show the Codeword grid instead. 
' I wanted to add it in to show how I'm going to change my GUI once the user presses start.
' Also because feedback on this idea would be helpful. 
' Added a second form using the video in Lesson 5 in order to simplify the GUI.
'TODO: Add timer that starts when PlayScreen is loaded. 


Public Class StartScreen

    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Dim frmPlayScreen As New GridOne()

        frmPlayScreen.ShowDialog()

    End Sub

    Private Sub btnHighScores_Click(sender As Object, e As EventArgs) Handles btnHighScores.Click

        Dim frmHighScores As New HighScores()

        frmHighScores.ShowDialog()

    End Sub
End Class
