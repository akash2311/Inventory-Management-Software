<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.ordertyetxt = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dlt_btn = New System.Windows.Forms.Button()
        Me.place_btn = New System.Windows.Forms.Button()
        Me.salepricetxt = New System.Windows.Forms.TextBox()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryManagementDataSet = New Inventory_Management.InventoryManagementDataSet()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Productname_txt = New System.Windows.Forms.ComboBox()
        Me.purchasepricetxt = New System.Windows.Forms.TextBox()
        Me.quantitytxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.home5_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Search_btn = New System.Windows.Forms.Button()
        Me.Searchorder_btn = New System.Windows.Forms.TextBox()
        Me.date_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OrdersTableAdapter = New Inventory_Management.InventoryManagementDataSetTableAdapters.OrdersTableAdapter()
        Me.Product_MasterTableAdapter = New Inventory_Management.InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'refresh_btn
        '
        Me.refresh_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.refresh_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.refresh_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refresh_btn.ForeColor = System.Drawing.Color.Turquoise
        Me.refresh_btn.Location = New System.Drawing.Point(277, 382)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(144, 39)
        Me.refresh_btn.TabIndex = 82
        Me.refresh_btn.Text = "REFRESH"
        Me.refresh_btn.UseVisualStyleBackColor = False
        '
        'ordertyetxt
        '
        Me.ordertyetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ordertyetxt.FormattingEnabled = True
        Me.ordertyetxt.Items.AddRange(New Object() {"Purchase", "Sale"})
        Me.ordertyetxt.Location = New System.Drawing.Point(152, 333)
        Me.ordertyetxt.Name = "ordertyetxt"
        Me.ordertyetxt.Size = New System.Drawing.Size(232, 33)
        Me.ordertyetxt.TabIndex = 81
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label7.Location = New System.Drawing.Point(23, 340)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 20)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Type :"
        '
        'dlt_btn
        '
        Me.dlt_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.dlt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dlt_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlt_btn.ForeColor = System.Drawing.Color.Turquoise
        Me.dlt_btn.Location = New System.Drawing.Point(152, 382)
        Me.dlt_btn.Name = "dlt_btn"
        Me.dlt_btn.Size = New System.Drawing.Size(119, 39)
        Me.dlt_btn.TabIndex = 79
        Me.dlt_btn.Text = "DELETE"
        Me.dlt_btn.UseVisualStyleBackColor = False
        '
        'place_btn
        '
        Me.place_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.place_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.place_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.place_btn.ForeColor = System.Drawing.Color.Turquoise
        Me.place_btn.Location = New System.Drawing.Point(27, 382)
        Me.place_btn.Name = "place_btn"
        Me.place_btn.Size = New System.Drawing.Size(119, 39)
        Me.place_btn.TabIndex = 78
        Me.place_btn.Text = "PLACE"
        Me.place_btn.UseVisualStyleBackColor = False
        '
        'salepricetxt
        '
        Me.salepricetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductMasterBindingSource, "SalePrice", True))
        Me.salepricetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salepricetxt.Location = New System.Drawing.Point(152, 292)
        Me.salepricetxt.Name = "salepricetxt"
        Me.salepricetxt.Size = New System.Drawing.Size(232, 31)
        Me.salepricetxt.TabIndex = 77
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(23, 300)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Sale Price :"
        '
        'Productname_txt
        '
        Me.Productname_txt.DataSource = Me.ProductMasterBindingSource
        Me.Productname_txt.DisplayMember = "Product"
        Me.Productname_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Productname_txt.FormattingEnabled = True
        Me.Productname_txt.Location = New System.Drawing.Point(152, 165)
        Me.Productname_txt.Name = "Productname_txt"
        Me.Productname_txt.Size = New System.Drawing.Size(232, 33)
        Me.Productname_txt.TabIndex = 75
        '
        'purchasepricetxt
        '
        Me.purchasepricetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductMasterBindingSource, "PurchasePrice", True))
        Me.purchasepricetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purchasepricetxt.Location = New System.Drawing.Point(152, 250)
        Me.purchasepricetxt.Name = "purchasepricetxt"
        Me.purchasepricetxt.Size = New System.Drawing.Size(232, 31)
        Me.purchasepricetxt.TabIndex = 74
        '
        'quantitytxt
        '
        Me.quantitytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitytxt.Location = New System.Drawing.Point(152, 208)
        Me.quantitytxt.Name = "quantitytxt"
        Me.quantitytxt.Size = New System.Drawing.Size(232, 31)
        Me.quantitytxt.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(23, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Purchase Price :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(23, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(23, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Product :"
        '
        'home5_btn
        '
        Me.home5_btn.BackColor = System.Drawing.Color.ForestGreen
        Me.home5_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home5_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home5_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home5_btn.Location = New System.Drawing.Point(16, 21)
        Me.home5_btn.Name = "home5_btn"
        Me.home5_btn.Size = New System.Drawing.Size(77, 28)
        Me.home5_btn.TabIndex = 69
        Me.home5_btn.Text = "HOME"
        Me.home5_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(345, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 37)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "ORDER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(829, 69)
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Search_btn)
        Me.GroupBox2.Controls.Add(Me.Searchorder_btn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(466, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 350)
        Me.GroupBox2.TabIndex = 83
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Orders"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PurchasePriceDataGridViewTextBoxColumn, Me.SalePriceDataGridViewTextBoxColumn, Me.OrderTypeDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.OrdersBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
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
        Me.IDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 45
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
        'OrderTypeDataGridViewTextBoxColumn
        '
        Me.OrderTypeDataGridViewTextBoxColumn.DataPropertyName = "OrderType"
        Me.OrderTypeDataGridViewTextBoxColumn.HeaderText = "OrderType"
        Me.OrderTypeDataGridViewTextBoxColumn.Name = "OrderTypeDataGridViewTextBoxColumn"
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "Orders"
        Me.OrdersBindingSource.DataSource = Me.InventoryManagementDataSet
        '
        'Search_btn
        '
        Me.Search_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.Search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Search_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search_btn.ForeColor = System.Drawing.Color.Turquoise
        Me.Search_btn.Location = New System.Drawing.Point(220, 33)
        Me.Search_btn.Name = "Search_btn"
        Me.Search_btn.Size = New System.Drawing.Size(120, 32)
        Me.Search_btn.TabIndex = 5
        Me.Search_btn.Text = "Search"
        Me.Search_btn.UseVisualStyleBackColor = False
        '
        'Searchorder_btn
        '
        Me.Searchorder_btn.Location = New System.Drawing.Point(14, 34)
        Me.Searchorder_btn.Name = "Searchorder_btn"
        Me.Searchorder_btn.Size = New System.Drawing.Size(193, 31)
        Me.Searchorder_btn.TabIndex = 0
        '
        'date_txt
        '
        Me.date_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.date_txt.Location = New System.Drawing.Point(152, 123)
        Me.date_txt.Name = "date_txt"
        Me.date_txt.Size = New System.Drawing.Size(232, 31)
        Me.date_txt.TabIndex = 85
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(23, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Date :"
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'Product_MasterTableAdapter
        '
        Me.Product_MasterTableAdapter.ClearBeforeFill = True
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(829, 450)
        Me.Controls.Add(Me.date_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.ordertyetxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dlt_btn)
        Me.Controls.Add(Me.place_btn)
        Me.Controls.Add(Me.salepricetxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Productname_txt)
        Me.Controls.Add(Me.purchasepricetxt)
        Me.Controls.Add(Me.quantitytxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.home5_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "order"
        Me.Text = "order"
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents refresh_btn As Button
    Friend WithEvents ordertyetxt As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dlt_btn As Button
    Friend WithEvents place_btn As Button
    Friend WithEvents salepricetxt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Productname_txt As ComboBox
    Friend WithEvents purchasepricetxt As TextBox
    Friend WithEvents quantitytxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents home5_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Search_btn As Button
    Friend WithEvents Searchorder_btn As TextBox
    Friend WithEvents date_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents InventoryManagementDataSet As InventoryManagementDataSet
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As InventoryManagementDataSetTableAdapters.OrdersTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrderTypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents Product_MasterTableAdapter As InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter
End Class
