Public Class frmWelcome
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblWelcome.Left = lblWelcome.Left - 5
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        'MsgBox("Oke")
        MessageBox.Show("Oke")
        'Me.Close()

    End Sub
End Class
