Imports MSBabaei
Imports System.IO


Public Class frmMain

    Public appPath As String = Environment.CurrentDirectory
    Public dbFile As String = "home.mdb"
    Public dtFile As String = "MSBabaei.dll"

    Public Function NumFormater(ByVal str As Integer) As String
        Dim str2 As String = str.ToString()
        If (str < 10) Then
            str2 = "0" + str.ToString()
        End If
        Return str2
    End Function

    Public Function chkFile(ByVal filePath As String, ByVal fileName As String) As Boolean
        If (File.Exists(filePath)) Then
            Return True
        Else
            MessageBox.Show(String.Format("فايل {0} وجود ندارد", fileName))
            Return False
        End If
    End Function

    Private Sub tmrDate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrDate.Tick
        Try

            lblPersian.Text = DateProvider.ToPersian()
            lblGregorian.Text = DateProvider.ToGregorian()
            Dim dt As New Date()
            lblTime.Text = String.Format("{0}:{1}:{2}", NumFormater(dt.Now.Hour), NumFormater(dt.Now.Minute), NumFormater(dt.Now.Second))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim found As Boolean = True
        If (appPath.EndsWith("\") = False) Then
            appPath += "\"
        End If
        dbFile = appPath + dbFile
        dtFile = appPath + dtFile

        found = chkFile(dbFile, "پايگاه داده ها")
        found = found And chkFile(dtFile, "تاريخ")
        If found = False Then
            Environment.Exit(0)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Environment.Exit(0)
    End Sub

    Private Sub btnAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        Dim frm As New frmAbout()
        frm.ShowDialog()
    End Sub

    Private Sub frmMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim frm As New frmPw
        frm.ShowDialog()
    End Sub

    Private Sub btnProtect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProtect.Click
        Dim frm As New frmPw
        frm.ShowDialog()
    End Sub

    Private Sub btnPw_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPw.Click
        Dim frm As New frmPassword
        frm.ShowDialog()
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        Dim frm As New frmBackup()
        frm.ShowDialog()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim frm As New frmUpdate()
        frm.ShowDialog()
    End Sub

    Private Sub btnBase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBase.Click
        Dim frm As New frmBase()
        frm.ShowDialog()
    End Sub

    Private Sub btnLand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLand.Click
        Dim frm As New frmLands()
        frm.Show()
    End Sub
End Class
