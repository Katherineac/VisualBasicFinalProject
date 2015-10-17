Public Class GridOne

    Private Sub PlayScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        For c As Integer = 0 To 15
            For r As Integer = 0 To 15
                Dim label = New Label()
                label.Text = "Label"
                TableLayoutPanel1.Controls.Add(label, c, r)
            Next
        Next

        Me.TableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
    End Sub

End Class