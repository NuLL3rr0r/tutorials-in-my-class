Public Class frmPw
    Public pw As String = "asd"
    Public valid As Boolean = False

    Private Sub txtPw_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPw.TextChanged
        If (txtPw.Text = pw) Then
            valid = True
            Me.Close()
        End If
    End Sub

    Private Sub frmPw_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If valid = False Then
            Environment.Exit(0)
        End If
    End Sub
End Class