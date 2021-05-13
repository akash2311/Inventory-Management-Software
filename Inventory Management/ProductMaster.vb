Imports System.Data.OleDb

Public Class ProductMaster
    Dim provider As String
    Dim connection As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection


    Private Sub ProductMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Product_Master' table. You can move, or remove it, as needed.
        Me.Product_MasterTableAdapter.Fill(Me.InventoryManagementDataSet.Product_Master)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\akash\OneDrive\Documents\InventoryManagement.accdb"
        connection = provider
        myconnection.ConnectionString = connection
    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        myconnection.Open()
        command = "INSERT INTO [Product Master]([Product],[Quantity],[PurchasePrice],[SalePrice]) VALUES (?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Product", CType(product_text.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(qty_txt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PuchasePrice", CType(purchaseprice_txt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("SalePrice", CType(saleprice_txt.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data has been added to the Product Master.")
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myconnection.Close()
    End Sub

    Private Sub refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Dim rcmd As New OleDbDataAdapter
        Dim dt As New DataTable
        myconnection.Open()
        command = "SELECT * FROM [Product Master]"
        rcmd = New OleDbDataAdapter(command, myconnection)
        rcmd.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Visible = True
        myconnection.Close()
    End Sub

    Private Sub home3_Click(sender As Object, e As EventArgs) Handles home3.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ProductMasterBindingSource.Filter = "(Product LIKE'" & searchproduct_txt.Text & "')"
        If ProductMasterBindingSource.Count <> 0 Then
            With DataGridView2
                .DataSource = ProductMasterBindingSource
            End With
        End If
    End Sub
End Class