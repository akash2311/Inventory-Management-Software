<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.deletebtn = New System.Windows.Forms.Button()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryManagementDataSet = New Inventory_Management.InventoryManagementDataSet()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.searchproduct_txt = New System.Windows.Forms.TextBox()
        Me.saleprice_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.purchaseprice_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.product_text = New System.Windows.Forms.TextBox()
        Me.qty_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.home3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Product_MasterTableAdapter = New Inventory_Management.InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'deletebtn
        '
        Me.deletebtn.BackColor = System.Drawing.Color.DarkCyan
        Me.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletebtn.ForeColor = System.Drawing.Color.Turquoise
        Me.deletebtn.Location = New System.Drawing.Point(70, 379)
        Me.deletebtn.Name = "deletebtn"
        Me.deletebtn.Size = New System.Drawing.Size(119, 39)
        Me.deletebtn.TabIndex = 69
        Me.deletebtn.Text = "DELETE"
        Me.deletebtn.UseVisualStyleBackColor = False
        '
        'updatebtn
        '
        Me.updatebtn.BackColor = System.Drawing.Color.DarkCyan
        Me.updatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updatebtn.ForeColor = System.Drawing.Color.Turquoise
        Me.updatebtn.Location = New System.Drawing.Point(223, 327)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(119, 39)
        Me.updatebtn.TabIndex = 68
        Me.updatebtn.Text = "UPDATE"
        Me.updatebtn.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Turquoise
        Me.addbtn.Location = New System.Drawing.Point(70, 327)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(119, 39)
        Me.addbtn.TabIndex = 67
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.searchproduct_txt)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(450, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 350)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Product"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PurchasePriceDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.ProductMasterBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView2.Location = New System.Drawing.Point(10, 87)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(329, 247)
        Me.DataGridView2.TabIndex = 6
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'ProductDataGridViewTextBoxColumn
        '
        Me.ProductDataGridViewTextBoxColumn.DataPropertyName = "Product"
        Me.ProductDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.ProductDataGridViewTextBoxColumn.Name = "ProductDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PurchasePriceDataGridViewTextBoxColumn
        '
        Me.PurchasePriceDataGridViewTextBoxColumn.DataPropertyName = "PurchasePrice"
        Me.PurchasePriceDataGridViewTextBoxColumn.HeaderText = "PurchasePrice"
        Me.PurchasePriceDataGridViewTextBoxColumn.Name = "PurchasePriceDataGridViewTextBoxColumn"
        '
        'SalePriceDataGridViewTextBoxColumn
        '
        Me.SalePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice"
        Me.SalePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice"
        Me.SalePriceDataGridViewTextBoxColumn.Name = "SalePriceDataGridViewTextBoxColumn"
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "Product Master"
        Me.ProductMasterBindingSource.DataSource = Me.InventoryManagementDataSet
        '
        'InventoryManagementDataSet
        '
        Me.InventoryManagementDataSet.DataSetName = "InventoryManagementDataSet"
        Me.InventoryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DarkCyan
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.Turquoise
        Me.Button8.Location = New System.Drawing.Point(220, 33)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(120, 32)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'searchproduct_txt
        '
        Me.searchproduct_txt.Location = New System.Drawing.Point(14, 34)
        Me.searchproduct_txt.Name = "searchproduct_txt"
        Me.searchproduct_txt.Size = New System.Drawing.Size(193, 31)
        Me.searchproduct_txt.TabIndex = 0
        '
        'saleprice_txt
        '
        Me.saleprice_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saleprice_txt.Location = New System.Drawing.Point(155, 256)
        Me.saleprice_txt.Name = "saleprice_txt"
        Me.saleprice_txt.Size = New System.Drawing.Size(232, 31)
        Me.saleprice_txt.TabIndex = 65
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(11, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Sale Price :"
        '
        'purchaseprice_txt
        '
        Me.purchaseprice_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchaseprice_txt.Location = New System.Drawing.Point(155, 210)
        Me.purchaseprice_txt.Name = "purchaseprice_txt"
        Me.purchaseprice_txt.Size = New System.Drawing.Size(232, 31)
        Me.purchaseprice_txt.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(11, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Purchase Price :"
        '
        'product_text
        '
        Me.product_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.product_text.Location = New System.Drawing.Point(155, 121)
        Me.product_text.Name = "product_text"
        Me.product_text.Size = New System.Drawing.Size(232, 31)
        Me.product_text.TabIndex = 61
        '
        'qty_txt
        '
        Me.qty_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qty_txt.Location = New System.Drawing.Point(155, 165)
        Me.qty_txt.Name = "qty_txt"
        Me.qty_txt.Size = New System.Drawing.Size(232, 31)
        Me.qty_txt.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(11, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(11, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Product :"
        '
        'home3
        '
        Me.home3.BackColor = System.Drawing.Color.ForestGreen
        Me.home3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home3.Location = New System.Drawing.Point(15, 20)
        Me.home3.Name = "home3"
        Me.home3.Size = New System.Drawing.Size(75, 28)
        Me.home3.TabIndex = 57
        Me.home3.Text = "HOME"
        Me.home3.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(254, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 37)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "PRODUCT MASTER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox1.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(827, 69)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'Product_MasterTableAdapter
        '
        Me.Product_MasterTableAdapter.ClearBeforeFill = True
        '
        'refreshbtn
        '
        Me.refreshbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.refreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refreshbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshbtn.ForeColor = System.Drawing.Color.Turquoise
        Me.refreshbtn.Location = New System.Drawing.Point(223, 379)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(119, 39)
        Me.refreshbtn.TabIndex = 70
        Me.refreshbtn.Text = "REFRESH"
        Me.refreshbtn.UseVisualStyleBackColor = False
        '
        'ProductMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(825, 457)
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.deletebtn)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.saleprice_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.purchaseprice_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.product_text)
        Me.Controls.Add(Me.qty_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.home3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ProductMaster"
        Me.Text = "ProductMaster"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents deletebtn As Button
    Friend WithEvents updatebtn As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents searchproduct_txt As TextBox
    Friend WithEvents saleprice_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents purchaseprice_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents product_text As TextBox
    Friend WithEvents qty_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents home3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InventoryManagementDataSet As InventoryManagementDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents Product_MasterTableAdapter As InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents refreshbtn As Button
End Class
