Imports System.Data.SqlClient
Imports Codewords.GridOneHSDataSet

Public Class HighScores


    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'HighScoresDataSet.GridTwoScores' table. You can move, or remove it, as needed.
        Me.GridTwoScoresTableAdapter.Fill(Me.HighScoresDataSet.GridTwoScores)
        'TODO: This line of code loads data into the 'GridOneHSDataSet.GridOneScores' table. You can move, or remove it, as needed.
        Me.GridOneScoresTableAdapter.Fill(Me.GridOneHSDataSet.GridOneScores)

        dgvGridOneHighScores.Sort(ColTimeGridOne, System.ComponentModel.ListSortDirection.Ascending)
        dgvGridTwoHighScores.Sort(ColTimeGridTwo, System.ComponentModel.ListSortDirection.Ascending)

        NumberAllRowsGridOne()
        NumberAllRowsGridTwo()
    End Sub

    Private Sub NumberAllRowsGridOne()
        ' Add row headers.
        For i As Integer = 0 To dgvGridOneHighScores.Rows.Count - 1
            Dim numbered As Integer
            numbered = i + 1
            dgvGridOneHighScores.Rows(i).HeaderCell.Value = numbered.ToString()
        Next i
    End Sub
    Private Sub NumberAllRowsGridTwo()
        ' Add row headers.
        For i As Integer = 0 To dgvGridTwoHighScores.Rows.Count - 1
            Dim numbered As Integer
            numbered = i + 1
            dgvGridTwoHighScores.Rows(i).HeaderCell.Value = numbered.ToString()
        Next i
    End Sub

End Class