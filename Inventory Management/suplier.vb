Imports System.Data.OleDb

Public Class suplier
    Dim provider As String
    Dim connection As String
    Dim scommand As String
    Dim mysconnection As OleDbConnection = New OleDbConnection


    Private Sub suplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Supplier' table. You can move, or remove it, as needed.
        Me.SupplierTableAdapter.Fill(Me.InventoryManagementDataSet.Supplier)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\akash\OneDrive\Documents\InventoryManagement.accdb"
        connection = provider
        mysconnection.ConnectionString = connection
    End Sub

    Private Sub addsuplier_btn_Click(sender As Object, e As EventArgs) Handles addsuplier_btn.Click
        mysconnection.Open()
        scommand = "INSERT INTO [Supplier]([Product],[SuplierName],[ContactNo],[Address]) VALUES (?,?,?,?)"
        Dim scmd As OleDbCommand = New OleDbCommand(scommand, mysconnection)
        scmd.Parameters.Add(New OleDbParameter("Product", CType(Prodcust_txt.Text, String)))
        scmd.Parameters.Add(New OleDbParameter("SuplierName", CType(Supliername_txt.Text, String)))
        scmd.Parameters.Add(New OleDbParameter("ContactNo", CType(contactno_txt.Text, String)))
        scmd.Parameters.Add(New OleDbParameter("Address", CType(address_txt.Text, String)))
        Try
            scmd.ExecuteNonQuery()
            MessageBox.Show("Data has been added to the Suplier list")
            scmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        mysconnection.Close()
    End Sub

    Private Sub srefreshbtn_Click(sender As Object, e As EventArgs) Handles srefreshbtn.Click
        Dim srcmd As New OleDbDataAdapter
        Dim sdt As New DataTable
        mysconnection.Open()
        scommand = "SELECT * FROM Supplier"
        srcmd = New OleDbDataAdapter(scommand, mysconnection)
        srcmd.Fill(sdt)
        SDataGridView2.DataSource = sdt.DefaultView
        SDataGridView2.Visible = True
        mysconnection.Close()
    End Sub

    Private Sub home4_Click(sender As Object, e As EventArgs) Handles home4.Click
        home.Show()
        Me.Close()
    End Sub
End Class