Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblThongDiep.Text = "DO YOU LOVE ME ???"
        btnClose.Visible = False
        btnNoLeft.Visible = False
    End Sub

    Private Sub btnNoLeft_MouseMove(sender As Object, e As MouseEventArgs) Handles btnNoLeft.MouseMove
        btnNoLeft.Visible = False
        btnNoRight.Visible = True
    End Sub

    Private Sub btnNoRight_MouseMove(sender As Object, e As MouseEventArgs) Handles btnNoRight.MouseMove
        btnNoLeft.Visible = True
        btnNoRight.Visible = False
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        lblThongDiep.Text = "I LOVE YOU"
        btnClose.Visible = True
        btnYes.Visible = False
        btnNoRight.Visible = False
        btnNoLeft.Visible = False
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class
