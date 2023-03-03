Public Class Form1
    Private Sub btnXacnhan_Click(sender As Object, e As EventArgs) Handles btnXacnhan.Click
        If RadioButton1.Checked = True Then
            MsgBox("Bạn đã chọn: " & RadioButton1.Text)
        End If
        If RadioButton2.Checked = True Then
            MsgBox("Bạn đã chọn: " & RadioButton2.Text)
        End If
        If RadioButton3.Checked = True Then
            MsgBox("Bạn đã chọn: " & RadioButton3.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Đã chọn chưa ta ??")
    End Sub
End Class
