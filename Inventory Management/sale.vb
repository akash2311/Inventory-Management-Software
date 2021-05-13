Imports System.Data.OleDb

Public Class sale

    Dim provider As String
    Dim connection As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection


    Private Sub sale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Product_Master' table. You can move, or remove it, as needed.
        Me.Product_MasterTableAdapter.Fill(Me.InventoryManagementDataSet.Product_Master)

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\akash\OneDrive\Documents\InventoryManagement.accdb"
        connection = provider
        myconnection.ConnectionString = connection

        Dim rcmd As New OleDbDataAdapter
        Dim dt As New DataTable
        myconnection.Open()


        Command = "SELECT * FROM [Product Master]"
        rcmd = New OleDbDataAdapter(Command, myconnection)
        rcmd.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Visible = True
        myconnection.Close()

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click
        myconnection.Open()
        command = "INSERT INTO [SalePurchase]([Product],[Quantity],[SalePrice],[Type],[TransactionDate]) VALUES (?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(Command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Product", CType(producttxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(qtytxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("SalePrice", CType(ratetxt.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("OrderType", CType("Sale", String)))
        cmd.Parameters.Add(New OleDbParameter("TransactionDate", CType(datetxt.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data has been added to the Order list")
            cmd.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        myconnection.Close()
    End Sub

    Private Sub home1_Click(sender As Object, e As EventArgs) Handles home1.Click
        Me.Close()
        home.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class