Imports System.Data.SqlClient

Public Class SubmitGridOne
    Private Sub SubmitGridOne_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim TimeValue As New GridOne()
        lblScore.Text = TimeValue.GetTimeValue()
        GridOne.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim connectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\SecondEditCodewords\Codewords\Codewords\Codewords\HighScores.mdf;Integrated Security=True"
        Dim dbConnection As New SqlConnection(connectionString)
        dbConnection.Open()
        Dim sqlString As String = "INSERT INTO GridOneScores (name, time) VALUES (@Name, @Time)"
        Dim insertCommand As New SqlCommand(sqlString, dbConnection)
        insertCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = txtName.Text
        insertCommand.Parameters.Add("@Time", SqlDbType.Int).Value = lblScore.Text
        insertCommand.ExecuteNonQuery()
        dbConnection.Close()
        dbConnection.Dispose()
        MessageBox.Show("Your record has been added.")
    End Sub
End Class