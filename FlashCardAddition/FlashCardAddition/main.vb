Public Class main
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (txtMax.Text = "" Or txtMin.Text = "") Then
            MessageBox.Show("why.... just.... why.....")
            Return
        End If
        If (CInt(txtMax.Text) < CInt(txtMin.Text)) Then
            Dim gs As New gameScreen(CInt(txtMax.Text), CInt(txtMin.Text))
            gs.Show()
        Else
            Dim gs As New gameScreen(CInt(txtMin.Text), CInt(txtMax.Text))
            gs.Show()
        End If

    End Sub

End Class
