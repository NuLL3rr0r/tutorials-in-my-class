Imports System.IO
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.SqlClient



Public Class Form1
    Dim dbPw As String = "123" 'string.Empty
    Dim dbFile As String = "std.mdb"

    Dim appPath As String
    Dim cnnStr As String


    Dim id4Edit As String = String.Empty

    Dim dtMaster As New DataTable


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        appPath = Environment.CurrentDirectory

        'Get the path separator char in OS, example: win-> C:\App\   Other OS -> C:/App/
        Dim sepChar As String = Path.DirectorySeparatorChar.ToString()

        'C:\App is an Example
        'in some OSes looked like C:\App and Some C:\App\
        'C:\App\std.mdb   path += "std.mdb"   path += "\std.mdb" 
        If Not appPath.EndsWith(sepChar) Then
            appPath = appPath + sepChar
        End If
        'output C:\App\


        dbFile = String.Concat(appPath, dbFile)  'dbFile = path + dbFile
        'output C:\App\std.mdb


        cnnStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1}", dbFile, dbPw)

        dgvStudents.RightToLeft = RightToLeft.Yes
        dgvStudents.ReadOnly = True
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)
            Dim oda As New OleDbDataAdapter(sqlStr, cnn)
            Dim ocb As New OleDbCommandBuilder(oda)

            cnn.Open()


            'must appear after cnn.open
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()


            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow

            Dim duplicate As Boolean = False

            While drr.Read()
                If drr("id").ToString().Trim() = txtIDAdd.Text.Trim() Then
                    duplicate = True
                    Exit While
                End If
            End While

            If Not duplicate Then
                ocb.QuotePrefix = "["
                ocb.QuoteSuffix = "]"
                oda.Fill(ds, tbl)


                dt = ds.Tables(tbl)
                dr = dt.NewRow()

                'dr(0) = txtIDAdd.Text.Trim()
                'dr(1) = txtNameAdd.Text.Trim()
                'dr(2) = txtMarkAdd.Text.Trim()
                dr("id") = txtIDAdd.Text.Trim()
                dr("studentname") = txtNameAdd.Text.Trim()
                dr("mark") = Convert.ToByte(txtMarkAdd.Text.Trim())
                dt.Rows.Add(dr)


                oda.InsertCommand = ocb.GetInsertCommand()


                If oda.Update(ds, tbl) = 1 Then
                    ds.AcceptChanges()
                    MessageBox.Show("Added")
                Else
                    ds.RejectChanges()
                    MessageBox.Show("Rejected")
                End If
            Else
                MessageBox.Show("Already Exist")
            End If


            drr.Close()
            cnn.Close()

            dt.Dispose()
            ds.Dispose()
            drr.Dispose()
            cmd.Dispose()
            ocb.Dispose()
            oda.Dispose()
            cnn.Dispose()

            dt = Nothing
            ds = Nothing
            drr = Nothing
            cmd = Nothing
            ocb = Nothing
            oda = Nothing
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)
            Dim oda As New OleDbDataAdapter(sqlStr, cnn)
            Dim ocb As New OleDbCommandBuilder(oda)

            cnn.Open()

            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow


            ocb.QuotePrefix = "["
            ocb.QuoteSuffix = "]"
            oda.Fill(ds, tbl)

            dt = ds.Tables(tbl)

            Dim found As Boolean = False

            For i As Integer = 0 To dt.Rows.Count - 1
                dr = dt.Rows(i)
                If (dr("id").ToString().Trim() = txtIDSearch.Text.Trim()) Then
                    found = True
                    dr.Delete()

                    oda.DeleteCommand = ocb.GetDeleteCommand()

                    If oda.Update(ds, tbl) = 1 Then
                        ds.AcceptChanges()
                        MessageBox.Show("Erased")
                    Else
                        ds.RejectChanges()
                        MessageBox.Show("Rejected")
                    End If

                    Exit For
                End If
            Next

            If Not found Then
                MessageBox.Show("Not Found!!")
            End If


            cnn.Close()

            dt.Dispose()
            ds.Dispose()
            ocb.Dispose()
            oda.Dispose()
            cnn.Dispose()

            dt = Nothing
            ds = Nothing
            ocb = Nothing
            oda = Nothing
            cnn = Nothing

        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub btnSearchID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchID.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)

            cnn.Open()

            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            Dim found As Boolean = False

            While drr.Read()
                If drr("id").ToString().Trim() = txtIDSearch.Text.Trim() Then
                    id4Edit = drr("id").ToString().Trim()
                    found = True

                    txtIDEdit.Text = drr("id").ToString().Trim()
                    txtNameEdit.Text = drr("studentname").ToString().Trim()
                    txtMarkEdit.Text = drr("mark").ToString().Trim()

                    txtIDEdit.SelectAll()
                    txtIDEdit.Focus()
                    Exit While
                End If
            End While

            If Not found Then
                MessageBox.Show("Not Found!!")
            End If

            drr.Close()
            cnn.Close()

            drr.Dispose()
            cmd.Dispose()
            cnn.Dispose()

            drr = Nothing
            cmd = Nothing
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)
            Dim oda As New OleDbDataAdapter(sqlStr, cnn)
            Dim ocb As New OleDbCommandBuilder(oda)

            cnn.Open()


            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()


            Dim ds As New DataSet
            Dim dt As New DataTable
            Dim dr As DataRow


            ocb.QuotePrefix = "["
            ocb.QuoteSuffix = "]"
            oda.Fill(ds, tbl)


            Dim found As Boolean = False


            If txtIDEdit.Text.Trim() <> id4Edit.Trim() Then
                While drr.Read()
                    If drr("id").ToString().Trim() = txtIDEdit.Text.Trim() Then
                        found = True
                        Exit While
                    End If
                End While
            End If


            If Not found Then
                dt = ds.Tables(tbl)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dr = dt.Rows(i)
                    If dr("id").ToString().Trim() = id4Edit.Trim() Then
                        dr.BeginEdit()

                        dr("id") = txtIDEdit.Text.Trim()
                        dr("studentname") = txtNameEdit.Text.Trim()
                        dr("mark") = txtMarkEdit.Text.Trim()

                        dr.EndEdit()

                        oda.UpdateCommand = ocb.GetUpdateCommand()

                        If oda.Update(ds, tbl) = 1 Then
                            ds.AcceptChanges()
                            MessageBox.Show("Updated!!")
                        Else
                            ds.RejectChanges()
                            MessageBox.Show("Rejected")
                        End If

                        Exit For
                    End If
                Next
            Else
                MessageBox.Show("Duplicate Error")
            End If

            drr.Close()
            cnn.Close()

            dt.Dispose()
            ds.Dispose()
            drr.Dispose()
            cmd.Dispose()
            ocb.Dispose()
            oda.Dispose()
            cnn.Dispose()

            dt = Nothing
            ds = Nothing
            drr = Nothing
            cmd = Nothing
            ocb = Nothing
            oda = Nothing
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)
            Dim oda As New OleDbDataAdapter(sqlStr, cnn)

            cnn.Open()

            Dim ds As New DataSet
            Dim dt As New DataTable

            oda.Fill(ds, tbl)


            dt = ds.Tables(tbl)
            dt.Columns(0).ColumnName = "شماره دانشجوئي"
            dt.Columns(1).ColumnName = "نام"
            dt.Columns(2).ColumnName = "نمره"

            dtMaster = dt

            dgvStudents.DataSource = dt

            dgvStudents.Columns(0).Width = 150
            dgvStudents.Columns(1).Width = 150
            dgvStudents.Columns(2).Width = 150

            cnn.Close()

            dt.Dispose()
            ds.Dispose()
            oda.Dispose()
            cnn.Dispose()

            dt = Nothing
            ds = Nothing
            oda = Nothing
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub btnSearchName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchName.Click
        Dim tbl As String = "students"
        Dim sqlStr As String = String.Concat("SELECT * FROM ", tbl)

        Try
            Dim cnn As New OleDbConnection(cnnStr)
   
            cnn.Open()

            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            Dim dt As New DataTable
            Dim dr As DataRow


            dt.Columns.Add("شماره دانشجوئي", Type.GetType("System.String"))
            dt.Columns.Add("نام", Type.GetType("System.String"))
            dt.Columns.Add("نمره", Type.GetType("System.Byte"))


            Dim found As Boolean = False

            While drr.Read()
                If drr("studentname").ToString().Trim().ToLower().Contains(txtNameSearch.Text.Trim().ToLower()) Then
                    found = True

                    dr = dt.NewRow()
                    dr(0) = drr("id").ToString().Trim()
                    dr(1) = drr("studentname").ToString().Trim()
                    dr(2) = drr("mark").ToString().Trim()
                    dt.Rows.Add(dr)
                End If
            End While

            If found Then
                dtMaster = dt
                dgvStudents.DataSource = dt

                dgvStudents.Columns(0).Width = 150
                dgvStudents.Columns(1).Width = 150
                dgvStudents.Columns(2).Width = 150
            Else
                MessageBox.Show("Not Found!!")
            End If

            cnn.Close()
            drr.Close()

            cmd.Dispose()
            drr.Dispose()
            cnn.Dispose()

            cmd = Nothing
            drr = Nothing
            cnn = Nothing
        Catch ex As Exception
            MessageBox.Show("Error :  " + ex.Message)
        End Try
    End Sub

    Private Sub txtSearchRealTime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearchRealTime.TextChanged
        Dim phrase As String = txtSearchRealTime.Text.Trim().ToLower()
        If phrase <> String.Empty Then
            Dim dt As DataTable = dtMaster.Clone()
            For i As Integer = 0 To dtMaster.Rows.Count - 1
                'dr = dt.Rows(i);
                'If dr(1).ToString().Trim().ToLower().Contains(phrase) Then
                If dtMaster.Rows(i)(1).ToString().Trim().ToLower().Contains(phrase) Then
                    Dim row() As Object = dtMaster.Rows(i).ItemArray
                    dt.Rows.Add(row)
                End If
            Next
            dgvStudents.DataSource = dt
        Else
            dgvStudents.DataSource = dtMaster
        End If
    End Sub

    Private Sub dgvStudents_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvStudents.CurrentCellChanged
        Try
            id4Edit = dgvStudents.CurrentRow.Cells(0).Value.ToString().Trim()
            txtIDSearch.Text = id4Edit.Trim()
            txtIDEdit.Text = id4Edit.Trim()
            txtNameEdit.Text = dgvStudents.CurrentRow.Cells(1).Value.ToString().Trim()
            txtMarkEdit.Text = dgvStudents.CurrentRow.Cells(2).Value.ToString().Trim()
        Catch
        End Try
    End Sub

    Private Sub chkNewRow_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNewRow.CheckedChanged
        Dim chk As CheckBox = sender
        dgvStudents.AllowUserToAddRows = chk.Checked
    End Sub
End Class
