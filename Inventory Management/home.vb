Imports System.Data.OleDb

Public Class home


    Dim provider As String
    Dim connection As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim rcmd2 As New OleDbDataAdapter
    Dim dt2 As New DataTable


    Private Sub orderBtn_Click(sender As Object, e As EventArgs) Handles orderBtn.Click
        order.Show()
    End Sub

    Private Sub suplierBtn_Click(sender As Object, e As EventArgs) Handles suplierBtn.Click
        suplier.Show()
    End Sub

    Private Sub productmasterBtn_Click(sender As Object, e As EventArgs) Handles productmasterBtn.Click
        ProductMaster.Show()
    End Sub

    Private Sub purchaseBtn_Click(sender As Object, e As EventArgs) Handles purchaseBtn.Click
        Purchase.Show()
    End Sub

    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.Product_Master' table. You can move, or remove it, as needed.
        Me.Product_MasterTableAdapter.Fill(Me.InventoryManagementDataSet.Product_Master)
        'TODO: This line of code loads data into the 'InventoryManagementDataSet.SalePurchase' table. You can move, or remove it, as needed.
        Me.SalePurchaseTableAdapter.Fill(Me.InventoryManagementDataSet.SalePurchase)

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\akash\OneDrive\Documents\InventoryManagement.accdb"
        connection = provider
        myconnection.ConnectionString = connection

    End Sub

    Private Sub saleBtn_Click(sender As Object, e As EventArgs) Handles saleBtn.Click
        sale.Show()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        If allbtn.Checked = True Then
            Dim rcmd As New OleDbDataAdapter
            Dim dt As New DataTable
            myconnection.Open()
            command = "SELECT * FROM [SalePurchase]"
            rcmd = New OleDbDataAdapter(command, myconnection)
            rcmd.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            DataGridView1.Visible = True
            myconnection.Close()
        End If
        If purchaseradiobtn.Checked = True Then
            myconnection.Open()
            Dim rcmd As New OleDbDataAdapter
            Dim dt As New DataTable
            command = "SELECT * FROM [SalePurchase]"
            rcmd = New OleDbDataAdapter(command, myconnection)
            rcmd.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            DataGridView1.Visible = True
            myconnection.Close()
        End If
        If saleradiobtn.Checked = True Then
            myconnection.Open()
            Dim rcmd As New OleDbDataAdapter
            Dim dt As New DataTable
            command = "SELECT * FROM [SalePurchase]"
            rcmd = New OleDbDataAdapter(command, myconnection)
            rcmd.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
            DataGridView1.Visible = True
            myconnection.Close()
        End If
    End Sub

    Private Sub refresh2btn_Click(sender As Object, e As EventArgs) Handles refresh2btn.Click
        Dim rcmd3 As New OleDbDataAdapter
        Dim dt3 As New DataTable
        myconnection.Open()
        command = "SELECT * FROM [Product Master]"
        rcmd3 = New OleDbDataAdapter(command, myconnection)
        rcmd3.Fill(dt3)
        DataGridView2.DataSource = dt3.DefaultView
        DataGridView2.Visible = True
        myconnection.Close()
    End Sub

    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

End Class