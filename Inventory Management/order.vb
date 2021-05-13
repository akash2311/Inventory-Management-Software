Imports System.Data.OleDb

Public Class order

    Dim provider As String
    Dim connection As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Product_Master' table. You can move, or remove it, as needed.
        Me.Product_MasterTableAdapter.Fill(Me.InventoryManagementDataSet.Product_Master)
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Orders' table. You can move, or remove it, as needed.
        Me.OrdersTableAdapter.Fill(Me.InventoryManagementDataSet.Orders)
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\akash\OneDrive\Documents\InventoryManagement.accdb"
        connection = provider
        myconnection.ConnectionString = connection
    End Sub

    Private Sub place_btn_Click(sender As Object, e As EventArgs) Handles place_btn.Click

        myconnection.Open()
        command = "INSERT INTO [Orders]([Product],[Quantity],[PurchasePrice],[SalePrice],[OrderType]) VALUES (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Product", CType(Productname_txt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(quantitytxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("PuchasePrice", CType(purchasepricetxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("SalePrice", CType(salepricetxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("OrderType", CType(ordertyetxt.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data has been added to the Order list")
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myconnection.Close()
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        Dim rcmd As New OleDbDataAdapter
        Dim dt As New DataTable
        myconnection.Open()
        command = "SELECT * FROM Orders"
        rcmd = New OleDbDataAdapter(command, myconnection)
        rcmd.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Visible = True
        myconnection.Close()
    End Sub

    Private Sub home5_btn_Click(sender As Object, e As EventArgs) Handles home5_btn.Click
        home.Show()
        Me.Close()
    End Sub

    Private Sub Search_btn_Click(sender As Object, e As EventArgs) Handles Search_btn.Click
        myconnection.Open()
        Dim srchcmd As New OleDbDataAdapter
        Dim sdt As New DataTable
        command = "SELECT * FROM Orders WHERE Product =" & Searchorder_btn.Text & ""
        srchcmd = New OleDbDataAdapter(command, myconnection)
        srchcmd.Fill(sdt)
        DataGridView2.DataSource = sdt.DefaultView
        myconnection.Close()

    End Sub

    Private Sub dlt_btn_Click(sender As Object, e As EventArgs) Handles dlt_btn.Click
        myconnection.Open()
        command = "DELETE FROM Orders WHERE Product =" & Searchorder_btn.Text & ""
        Dim dltcmd = New OleDbCommand(command, myconnection)
        Try
            dltcmd.ExecuteNonQuery()
            dltcmd.Dispose()
            myconnection.Close()
            Searchorder_btn.Clear()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class