Public Class GridTwo
    Public stopWatch As Stopwatch = stopWatch.StartNew()

    Private Sub GridTwo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGridTwo()
        For r As Integer = 0 To 14
            For c As Integer = 0 To 14
                If Me.dgvGridTwo.Rows(r).Cells(c).Value = "0" Then
                    Me.dgvGridTwo.Rows(r).Cells(c).Style.BackColor = Color.Black
                End If
            Next
        Next
        For i As Integer = 0 To 1000 - 1
            Threading.Thread.Sleep(1)
        Next
        Timer1.Start()
        txt1.Text = "K"
        txt11.Text = "X"
        txt12.Text = "W"
        txt17.Text = "Q"
    End Sub

    Public Sub LoadGridTwo()
        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(14) {New DataColumn("c1", GetType(String)), New DataColumn("c2", GetType(String)), New DataColumn("c3", GetType(String)), New DataColumn("c4", GetType(String)), New DataColumn("c5", GetType(String)), New DataColumn("c6", GetType(String)), New DataColumn("c7", GetType(String)), New DataColumn("c8", GetType(String)), New DataColumn("c9", GetType(String)), New DataColumn("c10", GetType(String)), New DataColumn("c11", GetType(String)), New DataColumn("c12", GetType(String)), New DataColumn("c13", GetType(String)), New DataColumn("c14", GetType(String)), New DataColumn("c15", GetType(String))})
        dt.Rows.Add("18", "9", "20", "3", "20", "18", "25", "9", "0", "14", "6", "8", "2", "2", "13")
        dt.Rows.Add("8", "0", "14", "0", "25", "0", "9", "0", "0", "0", "9", "0", "15", "0", "9")
        dt.Rows.Add("13", "8", "7", "5", "25", "20", "4", "9", "0", "4", "20", "2", "2", "8", "16")
        dt.Rows.Add("4", "0", "8", "0", "10", "0", "4", "0", "5", "0", "25", "0", "20", "0", "5")
        dt.Rows.Add("3", "5", "3", "20", "25", "2", "9", "13", "13", "0", "15", "3", "14", "9", "3")
        dt.Rows.Add("15", "0", "9", "0", "0", "0", "3", "0", "9", "0", "5", "0", "5", "0", "8")
        dt.Rows.Add("0", "0", "0", "19", "9", "5", "13", "0", "14", "8", "13", "22", "25", "20", "4")
        dt.Rows.Add("18", "0", "13", "0", "7", "0", "0", "0", "0", "0", "25", "0", "4", "0", "10")
        dt.Rows.Add("20", "5", "4", "15", "18", "5", "13", "0", "14", "20", "10", "13", "0", "0", "0")
        dt.Rows.Add("23", "0", "3", "0", "3", "0", "20", "0", "8", "0", "0", "0", "16", "0", "7")
        dt.Rows.Add("22", "25", "20", "4", "15", "0", "26", "20", "13", "16", "8", "2", "20", "4", "9")
        dt.Rows.Add("8", "0", "23", "0", "8", "0", "9", "0", "4", "0", "24", "0", "25", "0", "4")
        dt.Rows.Add("22", "20", "23", "15", "14", "20", "0", "24", "20", "22", "15", "3", "8", "19", "9")
        dt.Rows.Add("9", "0", "25", "0", "9", "0", "0", "0", "8", "0", "3", "0", "22", "0", "15")
        dt.Rows.Add("3", "8", "10", "20", "14", "21", "0", "5", "2", "16", "22", "21", "8", "9", "3")

        Me.dgvGridTwo.DataSource = dt
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged
        txt1.Text = "K"
    End Sub


    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        Dim userInput As String = txt1.Text
        Me.dgvGridTwo.Rows(0).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(0).Cells(13).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(8).Value = userInput
    End Sub

    Private Sub txt3_TextChanged(sender As Object, e As EventArgs) Handles txt3.TextChanged
        Dim userInput As String = txt3.Text
        Me.dgvGridTwo.Rows(0).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(14).Value = userInput
    End Sub

    Private Sub txt4_TextChanged(sender As Object, e As EventArgs) Handles txt4.TextChanged
        Dim userInput As String = txt4.Text
        Me.dgvGridTwo.Rows(2).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(9).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(13).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(14).Value = userInput
    End Sub

    Private Sub txt5_TextChanged(sender As Object, e As EventArgs) Handles txt5.TextChanged
        Dim userInput As String = txt5.Text
        Me.dgvGridTwo.Rows(2).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(7).Value = userInput
    End Sub

    Private Sub txt6_TextChanged(sender As Object, e As EventArgs) Handles txt6.TextChanged
        Dim userInput As String = txt6.Text
        Me.dgvGridTwo.Rows(0).Cells(10).Value = userInput
    End Sub

    Private Sub txt7_TextChanged(sender As Object, e As EventArgs) Handles txt7.TextChanged
        Dim userInput As String = txt7.Text
        Me.dgvGridTwo.Rows(2).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(14).Value = userInput
    End Sub

    Private Sub txt8_TextChanged(sender As Object, e As EventArgs) Handles txt8.TextChanged
        Dim userInput As String = txt9.Text
        Me.dgvGridTwo.Rows(0).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(13).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(9).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(1).Value = userInput
    End Sub

    Private Sub txt9_TextChanged(sender As Object, e As EventArgs) Handles txt9.TextChanged
        Dim userInput As String = txt9.Text
        Me.dgvGridTwo.Rows(0).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(0).Cells(7).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(7).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(13).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(13).Value = userInput
    End Sub

    Private Sub txt10_TextChanged(sender As Object, e As EventArgs) Handles txt10.TextChanged
        Dim userInput As String = txt10.Text
        Me.dgvGridTwo.Rows(3).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(10).Value = userInput
    End Sub

    Private Sub txt11_TextChanged(sender As Object, e As EventArgs) Handles txt11.TextChanged
        txt11.Text = "X"
    End Sub

    Private Sub txt12_TextChanged(sender As Object, e As EventArgs) Handles txt12.TextChanged
        txt12.Text = "W"
    End Sub

    Private Sub txt13_TextChanged(sender As Object, e As EventArgs) Handles txt13.TextChanged
        Dim userInput As String = txt13.Text
        Me.dgvGridTwo.Rows(0).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(7).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(8).Value = userInput
    End Sub

    Private Sub txt14_TextChanged(sender As Object, e As EventArgs) Handles txt14.TextChanged
        Dim userInput As String = txt14.Text
        Me.dgvGridTwo.Rows(0).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(4).Value = userInput
    End Sub

    Private Sub txt15_TextChanged(sender As Object, e As EventArgs) Handles txt15.TextChanged
        Dim userInput As String = txt15.Text
        Me.dgvGridTwo.Rows(1).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(5).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(14).Value = userInput
    End Sub

    Private Sub txt16_TextChanged(sender As Object, e As EventArgs) Handles txt16.TextChanged
        Dim userInput As String = txt16.Text
        Me.dgvGridTwo.Rows(2).Cells(14).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(9).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(9).Value = userInput
    End Sub

    Private Sub txt17_TextChanged(sender As Object, e As EventArgs) Handles txt17.TextChanged
        txt17.Text = "Q"
    End Sub

    Private Sub txt18_TextChanged(sender As Object, e As EventArgs) Handles txt18.TextChanged
        Dim userInput As String = txt18.Text
        Me.dgvGridTwo.Rows(0).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(0).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(4).Value = userInput
    End Sub

    Private Sub txt19_TextChanged(sender As Object, e As EventArgs) Handles txt19.TextChanged
        Dim userInput As String = txt19.Text
        Me.dgvGridTwo.Rows(6).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(13).Value = userInput
    End Sub

    Private Sub txt20_TextChanged(sender As Object, e As EventArgs) Handles txt20.TextChanged
        Dim userInput As String = txt9.Text
        Me.dgvGridTwo.Rows(0).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(0).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(3).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(13).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(8).Cells(9).Value = userInput
        Me.dgvGridTwo.Rows(9).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(7).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(8).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(3).Value = userInput
    End Sub

    Private Sub txt21_TextChanged(sender As Object, e As EventArgs) Handles txt21.TextChanged
        Dim userInput As String = txt21.Text
        Me.dgvGridTwo.Rows(14).Cells(5).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(12).Value = userInput
    End Sub

    Private Sub txt22_TextChanged(sender As Object, e As EventArgs) Handles txt22.TextChanged
        Dim userInput As String = txt22.Text
        Me.dgvGridTwo.Rows(6).Cells(11).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(9).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(14).Cells(11).Value = userInput
    End Sub

    Private Sub txt23_TextChanged(sender As Object, e As EventArgs) Handles txt23.TextChanged
        Dim userInput As String = txt23.Text
        Me.dgvGridTwo.Rows(9).Cells(0).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(2).Value = userInput
        Me.dgvGridTwo.Rows(12).Cells(2).Value = userInput
    End Sub

    Private Sub txt24_TextChanged(sender As Object, e As EventArgs) Handles txt24.TextChanged
        Dim userInput As String = txt24.Text
        Me.dgvGridTwo.Rows(11).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(7).Value = userInput
    End Sub

    Private Sub txt25_TextChanged(sender As Object, e As EventArgs) Handles txt25.TextChanged
        Dim userInput As String = txt25.Text
        Me.dgvGridTwo.Rows(0).Cells(6).Value = userInput
        Me.dgvGridTwo.Rows(1).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(2).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(3).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(4).Cells(4).Value = userInput
        Me.dgvGridTwo.Rows(6).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(7).Cells(10).Value = userInput
        Me.dgvGridTwo.Rows(10).Cells(1).Value = userInput
        Me.dgvGridTwo.Rows(11).Cells(12).Value = userInput
        Me.dgvGridTwo.Rows(13).Cells(2).Value = userInput
    End Sub

    Private Sub txt26_TextChanged(sender As Object, e As EventArgs) Handles txt26.TextChanged
        Dim userInput As String = txt26.Text
        Me.dgvGridTwo.Rows(10).Cells(6).Value = userInput
    End Sub

    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        stopWatch.Stop()
        Me.Close()
        lblTimerVal.Text = 0
        stopWatch.Reset()
        Dim frmStartScreen As New StartScreen()
        frmStartScreen.ShowDialog()
    End Sub

    Private Sub dgvGridTwo_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGridTwo.CellContentClick
        Dim GridFill As New FinishedArrays()
        Dim currentValue As String
        Dim x As Integer
        Dim y As Integer
        currentValue = Me.dgvGridTwo.CurrentCell.Value
        x = Me.dgvGridTwo.CurrentCellAddress.X
        y = Me.dgvGridTwo.CurrentCellAddress.Y

        If GridFill.FinishedArrayTwo(y, x) = currentValue Then
            Me.dgvGridTwo.Rows(y).Cells(x).Style.BackColor = Color.LawnGreen
            If GridFill.FinishedArrayTwo(y, x) = 0 Then
                Me.dgvGridTwo.Rows(y).Cells(x).Style.BackColor = Color.Black
            End If
        Else
            Me.dgvGridTwo.Rows(y).Cells(x).Style.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub btnFinish_Click(sender As Object, e As EventArgs) Handles btnFinish.Click
        Try
            Dim frmHighScoreSubmit As New SubmitGridTwo()
            Dim counter As Integer = 0
            Dim txtValues As Array = {"K", "N", "R", "T", "U", "J", "M", "I", "E", "Y", "X", "W", "S", "D", "O", "C", "Q", "B", "Z", "A", "H", "P", "G", "V", "L", "F"}
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
            End If
        Catch ex As Exception
            MessageBox.Show("You need to finish the game first")
        End Try
    End Sub

    Public Function GetTimeValue() As Integer
        Dim ts As Long = stopWatch.Elapsed.TotalMilliseconds
        Dim elapsedTime As String = ts.ToString
        Return elapsedTime
    End Function

    Private Sub btnHint_Click(sender As Object, e As EventArgs) Handles btnHint.Click
        Dim getHint As New HintFunction()
        getHint.GetHintTwo()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimerVal.Text = Val(lblTimerVal.Text) + 1
    End Sub

End Class