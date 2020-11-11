Imports System.Data.Odbc
Public Class Laporan
    'FORM LOAD
    Private Sub Laporan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Lbuku()
        Lpengguna()
        Lpeminjaman()
        Lpengembalian()
    End Sub
    'SUB BUKU
    Sub Lbuku()
        ds = New DataSet()
        query = "SELECT * FROM tbbuku "
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelBUKU.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'SUB PENGGUNA
    Sub Lpengguna()
        ds = New DataSet()
        query = "SELECT * FROM tbpengguna"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelPENGGUNA.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'SUB PEMINJAMAN
    Sub Lpeminjaman()
        ds = New DataSet()
        query = "SELECT * FROM tbpeminjaman"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelPEMINJAMAN.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    'SUB PENGEMBALIAN
    Sub Lpengembalian()
        ds = New DataSet()
        query = "SELECT * FROM tbpengembalian"
        da = New OdbcDataAdapter(query, con)
        Try
            da.Fill(ds)
            TabelPENGEMBALIAN.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show("Error : " + ex.Message, "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Lbuku()
        Lpengguna()
        Lpeminjaman()
        Lpengembalian()
    End Sub

    Private Sub ButtonBUKU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonBUKU.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)
        With ExcelSheet
            For i = 1 To Me.TabelBUKU.RowCount
                .cells(i, 1) = Me.TabelBUKU.Rows(i - 1).Cells(0).Value
                For j = 1 To TabelBUKU.Columns.Count - 1
                    .cells(i, j + 1) = TabelBUKU.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub ButtonPENGGUNA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPENGGUNA.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)
        With ExcelSheet
            For i = 1 To Me.TabelPENGGUNA.RowCount
                .cells(i, 1) = Me.TabelPENGGUNA.Rows(i - 1).Cells(0).Value
                For j = 1 To TabelPENGGUNA.Columns.Count - 1
                    .cells(i, j + 1) = TabelPENGGUNA.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub ButtonPEMINJAMAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPEMINJAMAN.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)
        With ExcelSheet
            For i = 1 To Me.TabelPEMINJAMAN.RowCount
                .cells(i, 1) = Me.TabelPEMINJAMAN.Rows(i - 1).Cells(0).Value
                For j = 1 To TabelPEMINJAMAN.Columns.Count - 1
                    .cells(i, j + 1) = TabelPEMINJAMAN.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub

    Private Sub ButtonPENGEMBALIAN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPENGEMBALIAN.Click
        Dim ExcelApp As Object, ExcelBook As Object
        Dim ExcelSheet As Object
        Dim i As Integer
        Dim j As Integer
        ExcelApp = CreateObject("Excel.Application")
        ExcelBook = ExcelApp.WorkBooks.Add
        ExcelSheet = ExcelBook.WorkSheets(1)
        With ExcelSheet
            For i = 1 To Me.TabelPENGEMBALIAN.RowCount
                .cells(i, 1) = Me.TabelPENGEMBALIAN.Rows(i - 1).Cells(0).Value
                For j = 1 To TabelPENGEMBALIAN.Columns.Count - 1
                    .cells(i, j + 1) = TabelPENGEMBALIAN.Rows(i - 1).Cells(j).Value
                Next
            Next
        End With
        ExcelApp.Visible = True
        ExcelSheet = Nothing
        ExcelBook = Nothing
        ExcelApp = Nothing
    End Sub
End Class