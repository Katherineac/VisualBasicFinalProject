Imports System.Data.SqlClient

Public Class GridOne
    Public stopWatch As Stopwatch = stopWatch.StartNew()
    Private Sub GridOne_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridOne()
        For r As Integer = 0 To 14
            For c As Integer = 0 To 14
                If Me.dgvGridOne.Rows(r).Cells(c).Value = "0" Then
                    Me.dgvGridOne.Rows(r).Cells(c).Style.BackColor = Color.Black
                End If
            Next
        Next
        For i As Integer = 0 To 1000 - 1
            Threading.Thread.Sleep(1)
        Next
        Timer1.Start()
        txt8.Text = "Q"
        txt11.Text = "X"
        txt20.Text = "J"
    End Sub
    Public Sub LoadGridOne()
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(14) {New DataColumn("c1", GetType(String)), New DataColumn("c2", GetType(String)), New DataColumn("c3", GetType(String)), New DataColumn("c4", GetType(String)), New DataColumn("c5", GetType(String)), New DataColumn("c6", GetType(String)), New DataColumn("c7", GetType(String)), New DataColumn("c8", GetType(String)), New DataColumn("c9", GetType(String)), New DataColumn("c10", GetType(String)), New DataColumn("c11", GetType(String)), New DataColumn("c12", GetType(String)), New DataColumn("c13", GetType(String)), New DataColumn("c14", GetType(String)), New DataColumn("c15", GetType(String))})
        dt.Rows.Add("3", "6", "6", "3", "22", "19", "0", "3", "6", "18", "16", "5", "22", "6", "1")
        dt.Rows.Add("24", "0", "18", "0", "10", "0", "0", "0", "18", "0", "23", "0", "19", "0", "16")
        dt.Rows.Add("24", "18", "16", "21", "4", "19", "0", "10", "22", "7", "3", "7", "6", "4", "18")
        dt.Rows.Add("4", "0", "12", "0", "3", "0", "2", "0", "13", "0", "14", "0", "4", "0", "9")
        dt.Rows.Add("5", "12", "2", "4", "0", "3", "14", "16", "16", "24", "0", "9", "19", "4", "4")
        dt.Rows.Add("6", "0", "14", "0", "4", "0", "16", "0", "19", "0", "25", "0", "10", "0", "18")
        dt.Rows.Add("4", "14", "4", "5", "6", "18", "16", "6", "16", "19", "22", "5", "0", "0", "0")
        dt.Rows.Add("10", "0", "10", "0", "15", "0", "10", "0", "17", "0", "10", "0", "24", "0", "7")
        dt.Rows.Add("0", "0", "0", "17", "22", "7", "6", "18", "4", "3", "6", "17", "4", "19", "6")
        dt.Rows.Add("19", "0", "5", "0", "5", "0", "15", "0", "6", "0", "15", "0", "7", "0", "3")
        dt.Rows.Add("3", "25", "16", "14", "0", "24", "22", "4", "18", "1", "0", "7", "6", "3", "6")
        dt.Rows.Add("23", "0", "12", "0", "10", "0", "18", "0", "1", "0", "5", "0", "22", "0", "12")
        dt.Rows.Add("3", "23", "23", "14", "3", "12", "7", "4", "0", "2", "4", "3", "26", "4", "18")
        dt.Rows.Add("14", "0", "16", "0", "12", "0", "6", "0", "0", "0", "10", "0", "3", "0", "4")
        dt.Rows.Add("17", "3", "19", "1", "25", "3", "1", "7", "0", "21", "4", "3", "14", "4", "10")

        Me.dgvGridOne.DataSource = dt


    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        Dim userInput As String = txt1.Text
        Dim rows As Integer() = {0, 10, 11, 14, 14}
        Dim cols As Integer() = {14, 9, 8, 3, 6}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub


    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        Dim userInput As String = txt2.Text
        Dim rows As Integer() = {3, 4, 12}
        Dim cols As Integer() = {6, 2, 9}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles txt3.TextChanged
        Dim userInput As String = txt3.Text
        Dim rows As Integer() = {0, 0, 0, 2, 3, 4, 8, 9, 10, 10, 12, 12, 12, 13, 14, 14, 14}
        Dim cols As Integer() = {0, 3, 7, 10, 4, 5, 9, 14, 0, 13, 0, 4, 11, 12, 1, 5, 11}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles txt4.TextChanged
        Dim userInput As String = txt4.Text
        Dim rows As Integer() = {2, 2, 3, 3, 4, 4, 4, 5, 6, 6, 8, 8, 10, 12, 12, 12, 13, 14, 14}
        Dim cols As Integer() = {4, 13, 0, 12, 3, 13, 14, 4, 0, 2, 8, 12, 7, 7, 10, 13, 14, 10, 13}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged
        Dim userInput As String = txt5.Text
        Dim rows As Integer() = {0, 4, 6, 6, 9, 9, 11}
        Dim cols As Integer() = {11, 0, 3, 11, 2, 4, 10}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt6_TextChanged(sender As Object, e As EventArgs) Handles txt6.TextChanged
        Dim userInput As String = txt6.Text
        Dim rows As Integer() = {0, 0, 0, 0, 2, 5, 6, 6, 8, 8, 8, 9, 10, 10, 13}
        Dim cols As Integer() = {1, 2, 8, 13, 12, 0, 4, 7, 6, 10, 14, 8, 12, 14, 6}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt7_TextChanged(sender As Object, e As EventArgs) Handles txt7.TextChanged
        Dim userInput As String = txt7.Text
        Dim rows As Integer() = {2, 2, 7, 8, 9, 10, 12, 14}
        Dim cols As Integer() = {9, 11, 14, 5, 12, 11, 6, 7}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt8_TextChanged(sender As Object, e As EventArgs) Handles txt8.TextChanged
        txt8.Text = "Q"
    End Sub

    Private Sub txt9_TextChanged(sender As Object, e As EventArgs) Handles txt9.TextChanged
        Dim userInput As String = txt9.Text
        Dim rows As Integer() = {3, 4}
        Dim cols As Integer() = {14, 11}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged
        Dim userInput As String = txt10.Text
        Dim rows As Integer() = {1, 2, 5, 7, 7, 7, 7, 11, 13, 14}
        Dim cols As Integer() = {4, 7, 12, 0, 2, 6, 10, 4, 10, 14}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt11_TextChanged(sender As Object, e As EventArgs) Handles txt11.TextChanged
        txt11.Text = "X"
    End Sub

    Private Sub txt12_TextChanged(sender As Object, e As EventArgs) Handles txt12.TextChanged
        Dim userInput As String = txt12.Text
        Dim rows As Integer() = {3, 4, 11, 11, 12, 13}
        Dim cols As Integer() = {2, 1, 2, 14, 5, 4}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt13_TextChanged(sender As Object, e As EventArgs) Handles txt13.TextChanged
        Dim userInput As String = txt13.Text
        Me.dgvGridOne.Rows(3).Cells(8).Value = userInput
    End Sub

    Private Sub txt14_TextChanged(sender As Object, e As EventArgs) Handles txt14.TextChanged
        Dim userInput As String = txt14.Text
        Dim rows As Integer() = {3, 4, 5, 6, 10, 12, 13, 14}
        Dim cols As Integer() = {10, 6, 2, 1, 3, 3, 0, 12}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt15_TextChanged(sender As Object, e As EventArgs) Handles txt15.TextChanged
        Dim userInput As String = txt15.Text
        Dim rows As Integer() = {7, 9, 9}
        Dim cols As Integer() = {4, 6, 10}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt16_TextChanged(sender As Object, e As EventArgs) Handles txt16.TextChanged
        Dim userInput As String = txt16.Text
        Dim rows As Integer() = {0, 1, 2, 4, 4, 5, 6, 6, 10, 13}
        Dim cols As Integer() = {10, 14, 2, 7, 8, 6, 6, 8, 2, 2}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt17_TextChanged(sender As Object, e As EventArgs) Handles txt17.TextChanged
        Dim userInput As String = txt17.Text
        Dim rows As Integer() = {7, 8, 8, 14}
        Dim cols As Integer() = {8, 3, 11, 0}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt18_TextChanged(sender As Object, e As EventArgs) Handles txt18.TextChanged
        Dim userInput As String = txt18.Text
        Dim rows As Integer() = {0, 1, 1, 2, 2, 5, 6, 8, 10, 11, 12}
        Dim cols As Integer() = {9, 2, 8, 1, 14, 14, 5, 7, 8, 6, 14}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt19_TextChanged(sender As Object, e As EventArgs) Handles txt19.TextChanged
        Dim userInput As String = txt19.Text
        Dim rows As Integer() = {0, 1, 2, 4, 5, 6, 8, 9, 14}
        Dim cols As Integer() = {5, 12, 5, 12, 8, 9, 13, 0, 2}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt20_TextChanged(sender As Object, e As EventArgs) Handles txt20.TextChanged
        txt20.Text = "J"
    End Sub

    Private Sub txt21_TextChanged(sender As Object, e As EventArgs) Handles txt21.TextChanged
        Dim userInput As String = txt21.Text
        Dim rows As Integer() = {2, 14}
        Dim cols As Integer() = {3, 9}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt22_TextChanged(sender As Object, e As EventArgs) Handles txt22.TextChanged
        Dim userInput As String = txt22.Text
        Dim rows As Integer() = {0, 0, 2, 6, 8, 10, 11}
        Dim cols As Integer() = {4, 12, 8, 10, 4, 6, 12}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt23_TextChanged(sender As Object, e As EventArgs) Handles txt23.TextChanged
        Dim userInput As String = txt23.Text
        Dim rows As Integer() = {1, 11, 12, 12}
        Dim cols As Integer() = {10, 0, 1, 2}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt24_TextChanged(sender As Object, e As EventArgs) Handles txt24.TextChanged
        Dim userInput As String = txt24.Text
        Dim rows As Integer() = {1, 2, 4, 7, 10}
        Dim cols As Integer() = {0, 0, 9, 12, 5}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt25_TextChanged(sender As Object, e As EventArgs) Handles txt25.TextChanged
        Dim userInput As String = txt25.Text
        Dim rows As Integer() = {5, 10, 14}
        Dim cols As Integer() = {10, 1, 4}
        For r As Integer = 0 To rows.Length - 1
            Me.dgvGridOne.Rows(rows(r)).Cells(cols(r)).Value = userInput
        Next
    End Sub

    Private Sub txt26_TextChanged(sender As Object, e As EventArgs) Handles txt26.TextChanged
        Dim userInput As String = txt26.Text
        Me.dgvGridOne.Rows(12).Cells(12).Value = userInput
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        stopWatch.Stop()
        Me.Close()
        lblTimerVal.Text = 0
        stopWatch.Reset()
        Dim frmStartScreen As New StartScreen()
        frmStartScreen.ShowDialog()
    End Sub

    Private Sub dgvGridOne_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridOne.CellContentClick
        Dim GridFill As New FinishedArrays()
        Dim currentValue As String
        Dim x As Integer
        Dim y As Integer
        currentValue = Me.dgvGridOne.CurrentCell.Value
        x = Me.dgvGridOne.CurrentCellAddress.X
        y = Me.dgvGridOne.CurrentCellAddress.Y

        If GridFill.FinishedArrayOne(y, x) = currentValue Then
            Me.dgvGridOne.Rows(y).Cells(x).Style.BackColor = Color.LawnGreen
            If GridFill.FinishedArrayOne(y, x) = 0 Then
                Me.dgvGridOne.Rows(y).Cells(x).Style.BackColor = Color.Black
            End If
        Else
            Me.dgvGridOne.Rows(y).Cells(x).Style.BackColor = Color.Tomato
        End If
    End Sub


    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
            Dim frmHighScoreSubmit As New SubmitGridOne()
            Dim counter As Integer = 0
            Dim txtValues As Array = {"Y", "B", "A", "E", "C", "T", "S", "Q", "K", "D", "X", "U", "G", "L", "H", "O", "M", "R", "N", "J", "Z", "I", "P", "F", "W", "V"}
            If txt1.Text = txtValues(0) Then
                counter = counter + 1
            End If
            If txt2.Text = txtValues(1) Then
                counter = counter + 1
            End If
            If txt3.Text = txtValues(2) Then
                counter = counter + 1
            End If
            If txt4.Text = txtValues(3) Then
                counter = counter + 1
            End If
            If txt5.Text = txtValues(4) Then
                counter = counter + 1
            End If
            If txt6.Text = txtValues(5) Then
                counter = counter + 1
            End If
            If txt7.Text = txtValues(6) Then
                counter = counter + 1
            End If
            If txt8.Text = txtValues(7) Then
                counter = counter + 1
            End If
            If txt9.Text = txtValues(8) Then
                counter = counter + 1
            End If
            If txt10.Text = txtValues(9) Then
                counter = counter + 1
            End If
            If txt11.Text = txtValues(10) Then
                counter = counter + 1
            End If
            If txt12.Text = txtValues(11) Then
                counter = counter + 1
            End If
            If txt13.Text = txtValues(12) Then
                counter = counter + 1
            End If
            If txt14.Text = txtValues(13) Then
                counter = counter + 1
            End If
            If txt15.Text = txtValues(14) Then
                counter = counter + 1
            End If
            If txt16.Text = txtValues(15) Then
                counter = counter + 1
            End If
            If txt17.Text = txtValues(16) Then
                counter = counter + 1
            End If
            If txt18.Text = txtValues(17) Then
                counter = counter + 1
            End If
            If txt19.Text = txtValues(18) Then
                counter = counter + 1
            End If
            If txt20.Text = txtValues(19) Then
                counter = counter + 1
            End If
            If txt21.Text = txtValues(20) Then
                counter = counter + 1
            End If
            If txt22.Text = txtValues(21) Then
                counter = counter + 1
            End If
            If txt23.Text = txtValues(22) Then
                counter = counter + 1
            End If
            If txt24.Text = txtValues(23) Then
                counter = counter + 1
            End If
            If txt25.Text = txtValues(24) Then
                counter = counter + 1
            End If
            If txt26.Text = txtValues(25) Then
                counter = counter + 1
            End If
            If counter = 26 Then
                MessageBox.Show("Congrats! Game Completed")
                stopWatch.Stop()
                Timer1.Stop()
                frmHighScoreSubmit.ShowDialog()
            Else
                MessageBox.Show("You need to finish the game first.")
            End If
    End Sub
    Public Function GetTimeValue() As String
        Dim ts As Long = stopWatch.Elapsed.TotalMilliseconds
        Dim elapsedTime As String = ts.ToString
        Return elapsedTime
    End Function

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        Dim getHint As New HintFunction()
        getHint.GetHintOne()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimerVal.Text = Val(lblTimerVal.Text) + 1
    End Sub

End Class