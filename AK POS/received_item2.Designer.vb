﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class received_item2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblheader = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbranches = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCategoryListItem = New System.Windows.Forms.ComboBox()
        Me.btnSearchListItem = New System.Windows.Forms.Button()
        Me.txtboxListItemSearch = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblListItemCount = New System.Windows.Forms.Label()
        Me.dgvListItem = New System.Windows.Forms.DataGridView()
        Me.itemcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSelectedItemCount = New System.Windows.Forms.Label()
        Me.dgvSelectedItem = New System.Windows.Forms.DataGridView()
        Me.itemcodee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemnamee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.updatequantity = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.deletequantity = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtboxSelectedItem = New System.Windows.Forms.TextBox()
        Me.btnselected = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtboxpath = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnbrowse = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.panelSAP = New System.Windows.Forms.Panel()
        Me.chckSAP = New System.Windows.Forms.CheckBox()
        Me.lblsapdoc = New System.Windows.Forms.Label()
        Me.checkfollowup = New System.Windows.Forms.CheckBox()
        Me.lblSAPClose = New System.Windows.Forms.Label()
        Me.txtsap = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtremarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.btnconvin = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvListItem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvSelectedItem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelSAP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lblheader)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1344, 31)
        Me.Panel3.TabIndex = 35
        '
        'lblheader
        '
        Me.lblheader.AutoSize = True
        Me.lblheader.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblheader.ForeColor = System.Drawing.Color.White
        Me.lblheader.Location = New System.Drawing.Point(2, 5)
        Me.lblheader.Name = "lblheader"
        Me.lblheader.Size = New System.Drawing.Size(162, 22)
        Me.lblheader.TabIndex = 33
        Me.lblheader.Text = "RECEIVED ITEM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(67, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 22)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Received from:"
        '
        'cmbranches
        '
        Me.cmbranches.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbranches.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbranches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbranches.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbranches.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbranches.ForeColor = System.Drawing.Color.White
        Me.cmbranches.FormattingEnabled = True
        Me.cmbranches.Location = New System.Drawing.Point(215, 88)
        Me.cmbranches.Name = "cmbranches"
        Me.cmbranches.Size = New System.Drawing.Size(247, 26)
        Me.cmbranches.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(1083, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Category:"
        '
        'cmbCategoryListItem
        '
        Me.cmbCategoryListItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCategoryListItem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.cmbCategoryListItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbCategoryListItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategoryListItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbCategoryListItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCategoryListItem.ForeColor = System.Drawing.Color.White
        Me.cmbCategoryListItem.FormattingEnabled = True
        Me.cmbCategoryListItem.Location = New System.Drawing.Point(1160, 55)
        Me.cmbCategoryListItem.Name = "cmbCategoryListItem"
        Me.cmbCategoryListItem.Size = New System.Drawing.Size(139, 26)
        Me.cmbCategoryListItem.TabIndex = 43
        '
        'btnSearchListItem
        '
        Me.btnSearchListItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearchListItem.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnSearchListItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearchListItem.FlatAppearance.BorderSize = 0
        Me.btnSearchListItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchListItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchListItem.ForeColor = System.Drawing.Color.White
        Me.btnSearchListItem.Location = New System.Drawing.Point(1224, 87)
        Me.btnSearchListItem.Name = "btnSearchListItem"
        Me.btnSearchListItem.Size = New System.Drawing.Size(75, 25)
        Me.btnSearchListItem.TabIndex = 42
        Me.btnSearchListItem.Text = "Search"
        Me.btnSearchListItem.UseVisualStyleBackColor = False
        '
        'txtboxListItemSearch
        '
        Me.txtboxListItemSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtboxListItemSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtboxListItemSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtboxListItemSearch.BackColor = System.Drawing.Color.White
        Me.txtboxListItemSearch.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxListItemSearch.ForeColor = System.Drawing.Color.Black
        Me.txtboxListItemSearch.Location = New System.Drawing.Point(1022, 87)
        Me.txtboxListItemSearch.Name = "txtboxListItemSearch"
        Me.txtboxListItemSearch.Size = New System.Drawing.Size(203, 25)
        Me.txtboxListItemSearch.TabIndex = 41
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblListItemCount)
        Me.Panel1.Location = New System.Drawing.Point(71, 114)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1230, 23)
        Me.Panel1.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(3, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "LIST OF ITEMS:"
        '
        'lblListItemCount
        '
        Me.lblListItemCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblListItemCount.AutoSize = True
        Me.lblListItemCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListItemCount.ForeColor = System.Drawing.Color.White
        Me.lblListItemCount.Location = New System.Drawing.Point(108, 4)
        Me.lblListItemCount.Name = "lblListItemCount"
        Me.lblListItemCount.Size = New System.Drawing.Size(15, 15)
        Me.lblListItemCount.TabIndex = 16
        Me.lblListItemCount.Text = "0"
        '
        'dgvListItem
        '
        Me.dgvListItem.AllowUserToAddRows = False
        Me.dgvListItem.AllowUserToResizeRows = False
        Me.dgvListItem.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvListItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvListItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvListItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvListItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(28, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListItem.ColumnHeadersHeight = 40
        Me.dgvListItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemcode, Me.itemname, Me.category, Me.Column2})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListItem.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListItem.EnableHeadersVisualStyles = False
        Me.dgvListItem.GridColor = System.Drawing.Color.White
        Me.dgvListItem.Location = New System.Drawing.Point(71, 136)
        Me.dgvListItem.Name = "dgvListItem"
        Me.dgvListItem.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListItem.RowHeadersVisible = False
        Me.dgvListItem.RowHeadersWidth = 50
        Me.dgvListItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListItem.Size = New System.Drawing.Size(1230, 154)
        Me.dgvListItem.TabIndex = 45
        '
        'itemcode
        '
        Me.itemcode.HeaderText = "Item Code"
        Me.itemcode.Name = "itemcode"
        Me.itemcode.ReadOnly = True
        Me.itemcode.Visible = False
        '
        'itemname
        '
        Me.itemname.HeaderText = "Item"
        Me.itemname.Name = "itemname"
        Me.itemname.ReadOnly = True
        '
        'category
        '
        Me.category.HeaderText = "Category"
        Me.category.Name = "category"
        Me.category.ReadOnly = True
        '
        'Column2
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Column2.HeaderText = "Add Quantity"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.Text = "Add"
        Me.Column2.ToolTipText = "Add Quantity"
        Me.Column2.UseColumnTextForButtonValue = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblSelectedItemCount)
        Me.Panel2.Location = New System.Drawing.Point(71, 360)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1230, 25)
        Me.Panel2.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "SELECTED ITEMS:"
        '
        'lblSelectedItemCount
        '
        Me.lblSelectedItemCount.AutoSize = True
        Me.lblSelectedItemCount.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedItemCount.ForeColor = System.Drawing.Color.White
        Me.lblSelectedItemCount.Location = New System.Drawing.Point(129, 4)
        Me.lblSelectedItemCount.Name = "lblSelectedItemCount"
        Me.lblSelectedItemCount.Size = New System.Drawing.Size(15, 15)
        Me.lblSelectedItemCount.TabIndex = 18
        Me.lblSelectedItemCount.Text = "0"
        '
        'dgvSelectedItem
        '
        Me.dgvSelectedItem.AllowUserToAddRows = False
        Me.dgvSelectedItem.AllowUserToResizeRows = False
        Me.dgvSelectedItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSelectedItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSelectedItem.BackgroundColor = System.Drawing.Color.White
        Me.dgvSelectedItem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvSelectedItem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvSelectedItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(28, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItem.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvSelectedItem.ColumnHeadersHeight = 40
        Me.dgvSelectedItem.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemcodee, Me.itemnamee, Me.categoryy, Me.quantityy, Me.updatequantity, Me.deletequantity})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSelectedItem.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSelectedItem.EnableHeadersVisualStyles = False
        Me.dgvSelectedItem.GridColor = System.Drawing.Color.White
        Me.dgvSelectedItem.Location = New System.Drawing.Point(71, 384)
        Me.dgvSelectedItem.Name = "dgvSelectedItem"
        Me.dgvSelectedItem.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedItem.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvSelectedItem.RowHeadersVisible = False
        Me.dgvSelectedItem.RowHeadersWidth = 50
        Me.dgvSelectedItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelectedItem.Size = New System.Drawing.Size(1230, 186)
        Me.dgvSelectedItem.TabIndex = 47
        '
        'itemcodee
        '
        Me.itemcodee.HeaderText = "Item Code"
        Me.itemcodee.Name = "itemcodee"
        Me.itemcodee.ReadOnly = True
        '
        'itemnamee
        '
        Me.itemnamee.HeaderText = "Item"
        Me.itemnamee.Name = "itemnamee"
        Me.itemnamee.ReadOnly = True
        '
        'categoryy
        '
        Me.categoryy.HeaderText = "Category"
        Me.categoryy.Name = "categoryy"
        Me.categoryy.ReadOnly = True
        '
        'quantityy
        '
        Me.quantityy.HeaderText = "Quantity"
        Me.quantityy.Name = "quantityy"
        Me.quantityy.ReadOnly = True
        '
        'updatequantity
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        Me.updatequantity.DefaultCellStyle = DataGridViewCellStyle6
        Me.updatequantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.updatequantity.HeaderText = "Edit Quantity"
        Me.updatequantity.Name = "updatequantity"
        Me.updatequantity.ReadOnly = True
        Me.updatequantity.Text = "Edit"
        Me.updatequantity.ToolTipText = "Edit Quantity"
        Me.updatequantity.UseColumnTextForButtonValue = True
        '
        'deletequantity
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        Me.deletequantity.DefaultCellStyle = DataGridViewCellStyle7
        Me.deletequantity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletequantity.HeaderText = "Remove Item"
        Me.deletequantity.Name = "deletequantity"
        Me.deletequantity.ReadOnly = True
        Me.deletequantity.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.deletequantity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.deletequantity.Text = "Remove"
        Me.deletequantity.ToolTipText = "Remove Item"
        Me.deletequantity.UseColumnTextForButtonValue = True
        '
        'txtboxSelectedItem
        '
        Me.txtboxSelectedItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtboxSelectedItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtboxSelectedItem.BackColor = System.Drawing.Color.White
        Me.txtboxSelectedItem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxSelectedItem.ForeColor = System.Drawing.Color.Black
        Me.txtboxSelectedItem.Location = New System.Drawing.Point(71, 334)
        Me.txtboxSelectedItem.Name = "txtboxSelectedItem"
        Me.txtboxSelectedItem.ShortcutsEnabled = False
        Me.txtboxSelectedItem.Size = New System.Drawing.Size(203, 25)
        Me.txtboxSelectedItem.TabIndex = 49
        '
        'btnselected
        '
        Me.btnselected.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnselected.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnselected.FlatAppearance.BorderSize = 0
        Me.btnselected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnselected.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselected.ForeColor = System.Drawing.Color.White
        Me.btnselected.Location = New System.Drawing.Point(273, 334)
        Me.btnselected.Name = "btnselected"
        Me.btnselected.Size = New System.Drawing.Size(75, 25)
        Me.btnselected.TabIndex = 50
        Me.btnselected.Text = "Search"
        Me.btnselected.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.AK_POS.My.Resources.Resources.not_available
        Me.PictureBox1.Location = New System.Drawing.Point(302, 576)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(124, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'txtboxpath
        '
        Me.txtboxpath.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtboxpath.BackColor = System.Drawing.Color.White
        Me.txtboxpath.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxpath.Cursor = System.Windows.Forms.Cursors.Hand
        Me.txtboxpath.ForeColor = System.Drawing.Color.DimGray
        Me.txtboxpath.Location = New System.Drawing.Point(483, 603)
        Me.txtboxpath.Name = "txtboxpath"
        Me.txtboxpath.ReadOnly = True
        Me.txtboxpath.Size = New System.Drawing.Size(229, 13)
        Me.txtboxpath.TabIndex = 53
        Me.txtboxpath.Text = "N/A"
        Me.txtboxpath.Visible = False
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DimGray
        Me.Label15.Location = New System.Drawing.Point(431, 600)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 17)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "Path:"
        Me.Label15.Visible = False
        '
        'btnbrowse
        '
        Me.btnbrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnbrowse.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnbrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbrowse.FlatAppearance.BorderSize = 0
        Me.btnbrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbrowse.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbrowse.ForeColor = System.Drawing.Color.White
        Me.btnbrowse.Location = New System.Drawing.Point(434, 625)
        Me.btnbrowse.Name = "btnbrowse"
        Me.btnbrowse.Size = New System.Drawing.Size(75, 22)
        Me.btnbrowse.TabIndex = 51
        Me.btnbrowse.Text = "Browse"
        Me.btnbrowse.UseVisualStyleBackColor = False
        Me.btnbrowse.Visible = False
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSubmit.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(1152, 584)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(147, 47)
        Me.btnSubmit.TabIndex = 55
        Me.btnSubmit.Text = "SUBMIT"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'panelSAP
        '
        Me.panelSAP.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.panelSAP.BackColor = System.Drawing.SystemColors.HotTrack
        Me.panelSAP.Controls.Add(Me.chckSAP)
        Me.panelSAP.Controls.Add(Me.lblsapdoc)
        Me.panelSAP.Controls.Add(Me.checkfollowup)
        Me.panelSAP.Controls.Add(Me.lblSAPClose)
        Me.panelSAP.Controls.Add(Me.txtsap)
        Me.panelSAP.Controls.Add(Me.Label4)
        Me.panelSAP.Controls.Add(Me.txtremarks)
        Me.panelSAP.Controls.Add(Me.Label11)
        Me.panelSAP.Controls.Add(Me.btnProceed)
        Me.panelSAP.Location = New System.Drawing.Point(495, 218)
        Me.panelSAP.Name = "panelSAP"
        Me.panelSAP.Size = New System.Drawing.Size(371, 267)
        Me.panelSAP.TabIndex = 56
        Me.panelSAP.Visible = False
        '
        'chckSAP
        '
        Me.chckSAP.AutoSize = True
        Me.chckSAP.Checked = True
        Me.chckSAP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chckSAP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chckSAP.ForeColor = System.Drawing.Color.White
        Me.chckSAP.Location = New System.Drawing.Point(246, 22)
        Me.chckSAP.Name = "chckSAP"
        Me.chckSAP.Size = New System.Drawing.Size(82, 20)
        Me.chckSAP.TabIndex = 18
        Me.chckSAP.Text = "Add SAP"
        Me.chckSAP.UseVisualStyleBackColor = True
        Me.chckSAP.Visible = False
        '
        'lblsapdoc
        '
        Me.lblsapdoc.AutoSize = True
        Me.lblsapdoc.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsapdoc.ForeColor = System.Drawing.Color.White
        Me.lblsapdoc.Location = New System.Drawing.Point(175, 21)
        Me.lblsapdoc.Name = "lblsapdoc"
        Me.lblsapdoc.Size = New System.Drawing.Size(41, 18)
        Me.lblsapdoc.TabIndex = 17
        Me.lblsapdoc.Text = "N/A:"
        '
        'checkfollowup
        '
        Me.checkfollowup.AutoSize = True
        Me.checkfollowup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkfollowup.ForeColor = System.Drawing.Color.White
        Me.checkfollowup.Location = New System.Drawing.Point(246, 48)
        Me.checkfollowup.Name = "checkfollowup"
        Me.checkfollowup.Size = New System.Drawing.Size(86, 20)
        Me.checkfollowup.TabIndex = 16
        Me.checkfollowup.Text = "To Follow"
        Me.checkfollowup.UseVisualStyleBackColor = True
        '
        'lblSAPClose
        '
        Me.lblSAPClose.AutoSize = True
        Me.lblSAPClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSAPClose.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSAPClose.ForeColor = System.Drawing.Color.White
        Me.lblSAPClose.Location = New System.Drawing.Point(345, 1)
        Me.lblSAPClose.Name = "lblSAPClose"
        Me.lblSAPClose.Size = New System.Drawing.Size(23, 24)
        Me.lblSAPClose.TabIndex = 6
        Me.lblSAPClose.Text = "X"
        '
        'txtsap
        '
        Me.txtsap.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsap.Location = New System.Drawing.Point(39, 44)
        Me.txtsap.MaxLength = 6
        Me.txtsap.Name = "txtsap"
        Me.txtsap.ShortcutsEnabled = False
        Me.txtsap.Size = New System.Drawing.Size(201, 29)
        Me.txtsap.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(36, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SAP Document:"
        '
        'txtremarks
        '
        Me.txtremarks.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtremarks.Location = New System.Drawing.Point(39, 105)
        Me.txtremarks.Multiline = True
        Me.txtremarks.Name = "txtremarks"
        Me.txtremarks.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtremarks.ShortcutsEnabled = False
        Me.txtremarks.Size = New System.Drawing.Size(289, 90)
        Me.txtremarks.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(36, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 18)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Remarks"
        '
        'btnProceed
        '
        Me.btnProceed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnProceed.BackColor = System.Drawing.Color.ForestGreen
        Me.btnProceed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProceed.FlatAppearance.BorderSize = 0
        Me.btnProceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProceed.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProceed.ForeColor = System.Drawing.Color.White
        Me.btnProceed.Location = New System.Drawing.Point(199, 210)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(129, 31)
        Me.btnProceed.TabIndex = 0
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = False
        '
        'btnconvin
        '
        Me.btnconvin.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnconvin.BackColor = System.Drawing.Color.ForestGreen
        Me.btnconvin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnconvin.FlatAppearance.BorderSize = 0
        Me.btnconvin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnconvin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconvin.ForeColor = System.Drawing.Color.White
        Me.btnconvin.Location = New System.Drawing.Point(71, 584)
        Me.btnconvin.Name = "btnconvin"
        Me.btnconvin.Size = New System.Drawing.Size(225, 47)
        Me.btnconvin.TabIndex = 57
        Me.btnconvin.Text = "Goto Conversion In"
        Me.btnconvin.UseVisualStyleBackColor = False
        '
        'received_item2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1344, 701)
        Me.Controls.Add(Me.btnconvin)
        Me.Controls.Add(Me.panelSAP)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtboxpath)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnbrowse)
        Me.Controls.Add(Me.txtboxSelectedItem)
        Me.Controls.Add(Me.btnselected)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgvSelectedItem)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dgvListItem)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbCategoryListItem)
        Me.Controls.Add(Me.btnSearchListItem)
        Me.Controls.Add(Me.txtboxListItemSearch)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbranches)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "received_item2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "received_item2"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvListItem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvSelectedItem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelSAP.ResumeLayout(False)
        Me.panelSAP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Public WithEvents lblheader As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbranches As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategoryListItem As ComboBox
    Friend WithEvents btnSearchListItem As Button
    Friend WithEvents txtboxListItemSearch As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblListItemCount As Label
    Friend WithEvents dgvListItem As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSelectedItemCount As Label
    Friend WithEvents txtboxSelectedItem As TextBox
    Friend WithEvents btnselected As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtboxpath As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents btnbrowse As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents itemcode As DataGridViewTextBoxColumn
    Friend WithEvents itemname As DataGridViewTextBoxColumn
    Friend WithEvents category As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewButtonColumn
    Public WithEvents dgvSelectedItem As DataGridView
    Friend WithEvents itemcodee As DataGridViewTextBoxColumn
    Friend WithEvents itemnamee As DataGridViewTextBoxColumn
    Friend WithEvents categoryy As DataGridViewTextBoxColumn
    Friend WithEvents quantityy As DataGridViewTextBoxColumn
    Friend WithEvents updatequantity As DataGridViewButtonColumn
    Friend WithEvents deletequantity As DataGridViewButtonColumn
    Friend WithEvents panelSAP As Panel
    Friend WithEvents chckSAP As CheckBox
    Friend WithEvents lblsapdoc As Label
    Friend WithEvents checkfollowup As CheckBox
    Friend WithEvents lblSAPClose As Label
    Friend WithEvents txtsap As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtremarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents btnconvin As Button
End Class
