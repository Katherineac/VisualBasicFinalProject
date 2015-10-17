Public Class HintFunction

    Dim getRandomHint As New Random()

    Public Sub GetHintOne()
        Dim hintOne As Array = {"Y", "B", "A", "E", "C", "T", "S", "Q", "K", "D", "X", "U", "G", "L", "H", "O", "M", "R", "N", "J", "Z", "I", "P", "F", "W", "V"}
        Dim hintOneIndex As Integer = getRandomHint.Next(hintOne.Length)
        Dim currentHintOne As String = hintOne(hintOneIndex)
        Dim hintNumberOne As Integer = hintOneIndex + 1
        MessageBox.Show("The letter for #" + hintNumberOne.ToString + " is " + currentHintOne)
    End Sub
    Public Sub StartingHint()
        Dim hintOne As Array = {"Y", "B", "A", "E", "C", "T", "S", "Q", "K", "D", "X", "U", "G", "L", "H", "O", "M", "R", "N", "J", "Z", "I", "P", "F", "W", "V"}
        Dim hintOneIndex As Integer = getRandomHint.Next(hintOne.Length)
        Dim currentHintOne As String = hintOne(hintOneIndex)
        Dim hintNumberOne As Integer = hintOneIndex + 1
        If hintNumberOne = 1 Then
            GridOne.txt1.Text = currentHintOne
            GridOne.dgvGridOne.Rows(0).Cells(14).Value = currentHintOne
        ElseIf hintNumberOne = 2 Then
            GridOne.txt2.Text = currentHintOne
        ElseIf hintNumberOne = 3 Then
            GridOne.txt3.Text = currentHintOne
        ElseIf hintNumberOne = 4 Then
            GridOne.txt4.Text = currentHintOne
        ElseIf hintNumberOne = 5 Then
            GridOne.txt5.Text = currentHintOne
        ElseIf hintNumberOne = 6 Then
            GridOne.txt6.Text = currentHintOne
        ElseIf hintNumberOne = 7 Then
            GridOne.txt7.Text = currentHintOne
        ElseIf hintNumberOne = 8 Then
            GridOne.txt8.Text = currentHintOne
        ElseIf hintNumberOne = 9 Then
            GridOne.txt9.Text = currentHintOne
        ElseIf hintNumberOne = 10 Then
            GridOne.txt10.Text = currentHintOne
        ElseIf hintNumberOne = 11 Then
            GridOne.txt11.Text = currentHintOne
        ElseIf hintNumberOne = 12 Then
            GridOne.txt12.Text = currentHintOne
        ElseIf hintNumberOne = 13 Then
            GridOne.txt13.Text = currentHintOne
        ElseIf hintNumberOne = 14 Then
            GridOne.txt14.Text = currentHintOne
        ElseIf hintNumberOne = 15 Then
            GridOne.txt15.Text = currentHintOne
        ElseIf hintNumberOne = 16 Then
            GridOne.txt16.Text = currentHintOne
        ElseIf hintNumberOne = 17 Then
            GridOne.txt17.Text = currentHintOne
        ElseIf hintNumberOne = 18 Then
            GridOne.txt18.Text = currentHintOne
        ElseIf hintNumberOne = 19 Then
            GridOne.txt19.Text = currentHintOne
        ElseIf hintNumberOne = 20 Then
            GridOne.txt20.Text = currentHintOne
        ElseIf hintNumberOne = 21 Then
            GridOne.txt21.Text = currentHintOne
        ElseIf hintNumberOne = 22 Then
            GridOne.txt22.Text = currentHintOne
        ElseIf hintNumberOne = 23 Then
            GridOne.txt23.Text = currentHintOne
        ElseIf hintNumberOne = 24 Then
            GridOne.txt24.Text = currentHintOne
        ElseIf hintNumberOne = 25 Then
            GridOne.txt25.Text = currentHintOne
        ElseIf hintNumberOne = 26 Then
            GridOne.txt26.Text = currentHintOne
        End If
    End Sub
    Public Sub GetHintTwo()
        Dim hintTwo As Array = {"K", "N", "R", "T", "U", "J", "M", "I", "E", "Y", "X", "W", "S", "D", "O", "C", "Q", "B", "Z", "A", "H", "P", "G", "V", "L", "F"}
        Dim hintTwoIndex As Integer = getRandomHint.Next(hintTwo.Length)
        Dim currentHintTwo As String = hintTwo(hintTwoIndex)
        Dim hintNumberTwo As Integer = hintTwoIndex + 1
        MessageBox.Show("The letter for #" + hintNumberTwo.ToString + " is " + currentHintTwo)
    End Sub

End Class
