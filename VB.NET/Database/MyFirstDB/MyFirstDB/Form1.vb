Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Public idFind As String = String.Empty

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ocb As New OleDbCommandBuilder(oda)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            ocb.QuotePrefix = "["
            ocb.QuoteSuffix = "]"
            oda.Fill(ds, tbl)

            Dim found As Boolean = False

            While (drr.Read())
                If drr("id").ToString() = txtID.Text Then
                    found = True
                    Exit While
                End If
            End While

            If (found = False) Then
                dt = ds.Tables(tbl)
                dr = dt.NewRow()
                dr("id") = txtID.Text
                dr("name") = txtName.Text
                dr("job") = txtJob.Text
                dt.Rows.Add(dr)

                oda.InsertCommand = ocb.GetInsertCommand()

                If oda.Update(ds, tbl) = 1 Then
                    ds.AcceptChanges()
                Else
                    ds.RejectChanges()
                End If

                MessageBox.Show("Record Added")
            Else
                MessageBox.Show("Record Already Exist")
            End If

            drr.Close()
            cmd.Dispose()
            drr = Nothing
            cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        dt.Dispose()
        ds.Dispose()
        ocb.Dispose()
        oda.Dispose()
        cnn.Dispose()

        dr = Nothing
        dt = Nothing
        ds = Nothing
        ocb = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ds As New DataSet
        Dim dt As New DataTable

        Try
            cnn.Open()

            oda.Fill(ds, tbl)

            dt = ds.Tables(tbl)
            dt.Columns(0).ColumnName = "ردیف"
            dt.Columns(1).ColumnName = "نام"
            dt.Columns(2).ColumnName = "شغل"
            dgv.DataSource = dt
            dgv.AutoResizeColumns()
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        dt.Dispose()
        ds.Dispose()
        oda.Dispose()
        cnn.Dispose()

        dt = Nothing
        ds = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ds As New DataSet

        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            oda.Fill(ds, tbl)

            Dim found As Boolean = False

            While (drr.Read())
                If drr("id").ToString() = txtSearch.Text Then
                    idFind = drr("id").ToString().Trim()
                    txtEditID.Text = drr("id").ToString().Trim()
                    txtEditName.Text = drr("name").ToString().Trim()
                    txtEditJob.Text = drr("job").ToString().Trim()
                    found = True
                    Exit While
                End If
            End While

            If found = False Then
                MessageBox.Show("Not Found")
            End If

            drr.Close()
            cmd.Dispose()
            drr = Nothing
            cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        ds.Dispose()
        oda.Dispose()
        cnn.Dispose()

        ds = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub

    Private Sub btnSearchByName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByName.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            oda.Fill(ds, tbl)

            Dim found As Boolean = False

            dt.Columns.Add("ردیف")
            dt.Columns.Add("نام")
            dt.Columns.Add("شغل")

            While (drr.Read())
                If drr("name").ToString().ToLower().IndexOf(txtSearchByName.Text.ToLower()) > -1 Then
                    dr = dt.NewRow()
                    dr(0) = drr(0)
                    dr(1) = drr(1)
                    dr(2) = drr(2)
                    dt.Rows.Add(dr)
                    found = True
                End If
            End While

            If found = True Then
                dt.AcceptChanges()
                dgv.DataSource = dt
                dgv.AutoResizeColumns()
            Else
                MessageBox.Show("Not Found")
            End If

            drr.Close()
            cmd.Dispose()
            drr = Nothing
            cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        dt.Dispose()
        ds.Dispose()
        oda.Dispose()
        cnn.Dispose()

        dr = Nothing
        dt = Nothing
        ds = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub

    Private Sub btnErase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnErase.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ocb As New OleDbCommandBuilder(oda)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            ocb.QuotePrefix = "["
            ocb.QuoteSuffix = "]"
            oda.Fill(ds, tbl)

            Dim found As Boolean = False

            Dim id As Integer = -1

            While (drr.Read())
                id += 1
                If drr("id").ToString() = idFind Then
                    dt = ds.Tables(tbl)
                    dr = dt.Rows(id)
                    dr.Delete()

                    oda.DeleteCommand = ocb.GetDeleteCommand()

                    If oda.Update(ds, tbl) = 1 Then
                        ds.AcceptChanges()
                    Else
                        ds.RejectChanges()
                    End If

                    MessageBox.Show("Record Deleted")
                    Exit While
                End If
            End While

            drr.Close()
            cmd.Dispose()
            drr = Nothing
            cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        dt.Dispose()
        ds.Dispose()
        ocb.Dispose()
        oda.Dispose()
        cnn.Dispose()

        dr = Nothing
        dt = Nothing
        ds = Nothing
        ocb = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim fileDb As String = "master.mdb"
        Dim dBpw As String = "asd"
        Dim tbl As String = "person"

        Dim path As String = Environment.CurrentDirectory

        If (path.EndsWith("\") = False) Then
            path += "\"
        End If

        fileDb = String.Concat(path, fileDb)

        Dim cnnStr As String = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Jet OLEDB:Database Password={1};", fileDb, dBpw)
        Dim sqlStr As String = String.Format("SELECT * FROM {0}", tbl)

        Dim cnn As New OleDbConnection(cnnStr)
        Dim oda As New OleDbDataAdapter(sqlStr, cnn)
        Dim ocb As New OleDbCommandBuilder(oda)
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim dr As DataRow

        Try
            cnn.Open()
            Dim cmd As New OleDbCommand(sqlStr, cnn)
            Dim drr As OleDbDataReader = cmd.ExecuteReader()

            ocb.QuotePrefix = "["
            ocb.QuoteSuffix = "]"
            oda.Fill(ds, tbl)

            Dim found As Boolean = False

            If (txtEditID.Text <> idFind) Then
                While (drr.Read())
                    If drr("id").ToString() = txtEditID.Text Then
                        found = True
                        Exit While
                    End If
                End While
            End If

            If (found = True) Then
                MessageBox.Show("Duplicate Error")
            Else
                dt = ds.Tables(tbl)
                For i As Integer = 0 To dt.Rows.Count
                    dr = dt.Rows(i)
                    If dr("id").ToString() = idFind Then
                        dr.BeginEdit()
                        dr("id") = txtEditID.Text
                        dr("name") = txtEditName.Text
                        dr("job") = txtEditJob.Text
                        dr.EndEdit()

                        oda.UpdateCommand = ocb.GetUpdateCommand()

                        If oda.Update(ds, tbl) = 1 Then
                            ds.AcceptChanges()
                        Else
                            ds.RejectChanges()
                        End If

                        MessageBox.Show("Record Edited")
                        Exit For
                    End If
                Next
            End If

            drr.Close()
            cmd.Dispose()
            drr = Nothing
            cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " + ex.Message)
        End Try
        sqlStr = Nothing

        cnn.Close()

        dt.Dispose()
        ds.Dispose()
        ocb.Dispose()
        oda.Dispose()
        cnn.Dispose()

        dr = Nothing
        dt = Nothing
        ds = Nothing
        ocb = Nothing
        oda = Nothing
        cnn = Nothing
    End Sub
End Class
