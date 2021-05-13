<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class suplier
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SDataGridView2 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SuplierNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryManagementDataSet = New Inventory_Management.InventoryManagementDataSet()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.srefreshbtn = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.addsuplier_btn = New System.Windows.Forms.Button()
        Me.address_txt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.contactno_txt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Prodcust_txt = New System.Windows.Forms.TextBox()
        Me.Supliername_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.home4 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SupplierTableAdapter = New Inventory_Management.InventoryManagementDataSetTableAdapters.SupplierTableAdapter()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SDataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.SDataGridView2)
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(462, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 324)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supliers"
        '
        'SDataGridView2
        '
        Me.SDataGridView2.AllowUserToOrderColumns = True
        Me.SDataGridView2.AutoGenerateColumns = False
        Me.SDataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.SDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SDataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ProductDataGridViewTextBoxColumn, Me.SuplierNameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.SDataGridView2.DataSource = Me.SupplierBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InfoText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.SDataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.SDataGridView2.Location = New System.Drawing.Point(10, 87)
        Me.SDataGridView2.Name = "SDataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuBar
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.SDataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.SDataGridView2.Size = New System.Drawing.Size(329, 220)
        Me.SDataGridView2.TabIndex = 6
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
        'SuplierNameDataGridViewTextBoxColumn
        '
        Me.SuplierNameDataGridViewTextBoxColumn.DataPropertyName = "SuplierName"
        Me.SuplierNameDataGridViewTextBoxColumn.HeaderText = "SuplierName"
        Me.SuplierNameDataGridViewTextBoxColumn.Name = "SuplierNameDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'SupplierBindingSource
        '
        Me.SupplierBindingSource.DataMember = "Supplier"
        Me.SupplierBindingSource.DataSource = Me.InventoryManagementDataSet
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
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(14, 34)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(193, 31)
        Me.TextBox5.TabIndex = 0
        '
        'srefreshbtn
        '
        Me.srefreshbtn.BackColor = System.Drawing.Color.DarkCyan
        Me.srefreshbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.srefreshbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.srefreshbtn.ForeColor = System.Drawing.Color.Turquoise
        Me.srefreshbtn.Location = New System.Drawing.Point(285, 317)
        Me.srefreshbtn.Name = "srefreshbtn"
        Me.srefreshbtn.Size = New System.Drawing.Size(135, 39)
        Me.srefreshbtn.TabIndex = 76
        Me.srefreshbtn.Text = "REFRESH"
        Me.srefreshbtn.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DarkCyan
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Turquoise
        Me.Button3.Location = New System.Drawing.Point(159, 317)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(119, 39)
        Me.Button3.TabIndex = 75
        Me.Button3.Text = "DELETE"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'addsuplier_btn
        '
        Me.addsuplier_btn.BackColor = System.Drawing.Color.DarkCyan
        Me.addsuplier_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addsuplier_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addsuplier_btn.ForeColor = System.Drawing.Color.Turquoise
        Me.addsuplier_btn.Location = New System.Drawing.Point(33, 317)
        Me.addsuplier_btn.Name = "addsuplier_btn"
        Me.addsuplier_btn.Size = New System.Drawing.Size(119, 39)
        Me.addsuplier_btn.TabIndex = 74
        Me.addsuplier_btn.Text = "ADD"
        Me.addsuplier_btn.UseVisualStyleBackColor = False
        '
        'address_txt
        '
        Me.address_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_txt.Location = New System.Drawing.Point(173, 242)
        Me.address_txt.Name = "address_txt"
        Me.address_txt.Size = New System.Drawing.Size(232, 31)
        Me.address_txt.TabIndex = 73
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(29, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Address :"
        '
        'contactno_txt
        '
        Me.contactno_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactno_txt.Location = New System.Drawing.Point(173, 196)
        Me.contactno_txt.Name = "contactno_txt"
        Me.contactno_txt.Size = New System.Drawing.Size(232, 31)
        Me.contactno_txt.TabIndex = 71
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(29, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Contact no :"
        '
        'Prodcust_txt
        '
        Me.Prodcust_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prodcust_txt.Location = New System.Drawing.Point(173, 107)
        Me.Prodcust_txt.Name = "Prodcust_txt"
        Me.Prodcust_txt.Size = New System.Drawing.Size(232, 31)
        Me.Prodcust_txt.TabIndex = 69
        '
        'Supliername_txt
        '
        Me.Supliername_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supliername_txt.Location = New System.Drawing.Point(173, 151)
        Me.Supliername_txt.Name = "Supliername_txt"
        Me.Supliername_txt.Size = New System.Drawing.Size(232, 31)
        Me.Supliername_txt.TabIndex = 68
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(29, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Suplier :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(29, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Product :"
        '
        'home4
        '
        Me.home4.BackColor = System.Drawing.Color.ForestGreen
        Me.home4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home4.Location = New System.Drawing.Point(17, 21)
        Me.home4.Name = "home4"
        Me.home4.Size = New System.Drawing.Size(75, 28)
        Me.home4.TabIndex = 65
        Me.home4.Text = "HOME"
        Me.home4.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkCyan
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkTurquoise
        Me.Label1.Location = New System.Drawing.Point(317, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 37)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "SUPLIERS"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkCyan
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(827, 69)
        Me.PictureBox1.TabIndex = 63
        Me.PictureBox1.TabStop = False
        '
        'SupplierTableAdapter
        '
        Me.SupplierTableAdapter.ClearBeforeFill = True
        '
        'suplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(826, 421)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.srefreshbtn)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.addsuplier_btn)
        Me.Controls.Add(Me.address_txt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.contactno_txt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Prodcust_txt)
        Me.Controls.Add(Me.Supliername_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.home4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "suplier"
        Me.Text = "suplier"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SDataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SupplierBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryManagementDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SDataGridView2 As DataGridView
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents srefreshbtn As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents addsuplier_btn As Button
    Friend WithEvents address_txt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents contactno_txt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Prodcust_txt As TextBox
    Friend WithEvents Supliername_txt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents home4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InventoryManagementDataSet As InventoryManagementDataSet
    Friend WithEvents SupplierBindingSource As BindingSource
    Friend WithEvents SupplierTableAdapter As InventoryManagementDataSetTableAdapters.SupplierTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SuplierNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
