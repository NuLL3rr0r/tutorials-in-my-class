Public Class frmPassword

    Dim CurrentPw As String = "asd"

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If CurrentPw = txtCurrent.Text Then
            If txtPw.Text = txtConfirm.Text Then
                MessageBox.Show("رمز عبور با موفقیت جایگزین شد")
            Else
                MessageBox.Show("رمز عبور را تائید نمائید")
            End If
        Else
            MessageBox.Show("لطفا رمز عبور فعلی را وارد نمائید")
        End If
    End Sub
End Class