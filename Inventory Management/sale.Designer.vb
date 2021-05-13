<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sale
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
        Me.producttxt = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.addbtn = New System.Windows.Forms.Button()
        Me.ratetxt = New System.Windows.Forms.TextBox()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryManagementDataSet = New Inventory_Management.InventoryManagementDataSet()
        Me.qtytxt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.home1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PurchasePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalePriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Product_MasterTableAdapter = New Inventory_Management.InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter()
        Me.datetxt = New System.Windows.Forms.TextBox()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'producttxt
        '
        Me.producttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.producttxt.FormattingEnabled = True
        Me.producttxt.Items.AddRange(New Object() {"A4 Paper", "A3 Paper", "A4 classmate Notebook", "A3 Classmate Notebook", "Classmate Rough Notebook", "Rough Classmate Notebook(Thin)", "Forte Ball pen", "Forte gel Pen", "Project File", "Calculator", "VSSUT Brand Notebook"})
        Me.producttxt.Location = New System.Drawing.Point(119, 145)
        Me.producttxt.Name = "producttxt"
        Me.producttxt.Size = New System.Drawing.Size(232, 33)
        Me.producttxt.TabIndex = 54
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Turquoise
        Me.Button3.Location = New System.Drawing.Point(217, 334)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 39)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "CANCEL"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'addbtn
        '
        Me.addbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Turquoise
        Me.addbtn.Location = New System.Drawing.Point(55, 334)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.Size = New System.Drawing.Size(119, 39)
        Me.addbtn.TabIndex = 52
        Me.addbtn.Text = "ADD"
        Me.addbtn.UseVisualStyleBackColor = False
        '
        'ratetxt
        '
        Me.ratetxt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductMasterBindingSource, "SalePrice", True))
        Me.ratetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ratetxt.Location = New System.Drawing.Point(119, 231)
        Me.ratetxt.Name = "ratetxt"
        Me.ratetxt.Size = New System.Drawing.Size(232, 31)
        Me.ratetxt.TabIndex = 50
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
        'qtytxt
        '
        Me.qtytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtytxt.Location = New System.Drawing.Point(119, 189)
        Me.qtytxt.Name = "qtytxt"
        Me.qtytxt.Size = New System.Drawing.Size(232, 31)
        Me.qtytxt.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(29, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 20)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Rate :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(29, 194)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Quantity :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(29, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Product :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(29, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Date :"
        '
        'home1
        '
        Me.home1.BackColor = System.Drawing.Color.ForestGreen
        Me.home1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home1.Location = New System.Drawing.Point(17, 21)
        Me.home1.Name = "home1"
        Me.home1.Size = New System.Drawing.Size(75, 28)
        Me.home1.TabIndex = 44
        Me.home1.Text = "HOME"
        Me.home1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(349, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 37)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "SALE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(436, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 350)
        Me.GroupBox2.TabIndex = 55
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
        Me.DataGridView2.Location = New System.Drawing.Point(11, 86)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(329, 247)
        Me.DataGridView2.TabIndex = 7
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
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(14, 34)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(193, 31)
        Me.TextBox4.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(827, 69)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'Product_MasterTableAdapter
        '
        Me.Product_MasterTableAdapter.ClearBeforeFill = True
        '
        'datetxt
        '
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(119, 104)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(232, 31)
        Me.datetxt.TabIndex = 56
        '
        'sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(826, 443)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.producttxt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.addbtn)
        Me.Controls.Add(Me.ratetxt)
        Me.Controls.Add(Me.qtytxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.home1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "sale"
        Me.Text = "sale"
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents producttxt As ComboBox
    Friend WithEvents Button3 As Button
    Friend WithEvents addbtn As Button
    Friend WithEvents ratetxt As TextBox
    Friend WithEvents qtytxt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents home1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents InventoryManagementDataSet As InventoryManagementDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents Product_MasterTableAdapter As InventoryManagementDataSetTableAdapters.Product_MasterTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PurchasePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalePriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents datetxt As TextBox
End Class
