<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewtransactions
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Labelinvoice = New System.Windows.Forms.Label()
        Me.TextBoxinvoice = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePickerreceived = New System.Windows.Forms.DateTimePicker()
        Me.Buttoncompleted = New System.Windows.Forms.Button()
        Me.Buttonedit = New System.Windows.Forms.Button()
        Me.TextBoxreceivedby = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Labelstatus = New System.Windows.Forms.Label()
        Me.TextBoxcontactno = New System.Windows.Forms.TextBox()
        Me.Labelcontactno = New System.Windows.Forms.Label()
        Me.TextBoxtransactempname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxcustadrs = New System.Windows.Forms.TextBox()
        Me.ComboBoxtransacttype = New System.Windows.Forms.ComboBox()
        Me.TextBoxcustname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTotalamount = New System.Windows.Forms.Label()
        Me.DataGridViewcompletedorders = New System.Windows.Forms.DataGridView()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductpriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SproccompletedordersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalprojectDataSet17 = New WindowsApp1.finalprojectDataSet17()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FinalprojectDataSet15 = New WindowsApp1.finalprojectDataSet15()
        Me.SproccompletedordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sproc_completedordersTableAdapter = New WindowsApp1.finalprojectDataSet15TableAdapters.sproc_completedordersTableAdapter()
        Me.FinalprojectDataSet16 = New WindowsApp1.finalprojectDataSet16()
        Me.SproccompletedordersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sproc_completedordersTableAdapter1 = New WindowsApp1.finalprojectDataSet16TableAdapters.sproc_completedordersTableAdapter()
        Me.Sproc_completedordersTableAdapter2 = New WindowsApp1.finalprojectDataSet17TableAdapters.sproc_completedordersTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridViewcompletedorders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SproccompletedordersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalprojectDataSet17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalprojectDataSet15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SproccompletedordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalprojectDataSet16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SproccompletedordersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.Labelinvoice)
        Me.GroupBox1.Controls.Add(Me.TextBoxinvoice)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerreceived)
        Me.GroupBox1.Controls.Add(Me.Buttoncompleted)
        Me.GroupBox1.Controls.Add(Me.Buttonedit)
        Me.GroupBox1.Controls.Add(Me.TextBoxreceivedby)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Labelstatus)
        Me.GroupBox1.Controls.Add(Me.TextBoxcontactno)
        Me.GroupBox1.Controls.Add(Me.Labelcontactno)
        Me.GroupBox1.Controls.Add(Me.TextBoxtransactempname)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBoxcustadrs)
        Me.GroupBox1.Controls.Add(Me.ComboBoxtransacttype)
        Me.GroupBox1.Controls.Add(Me.TextBoxcustname)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelTotalamount)
        Me.GroupBox1.Controls.Add(Me.DataGridViewcompletedorders)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(550, 616)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Invoice"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Blue
        Me.LinkLabel1.Location = New System.Drawing.Point(270, 600)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(44, 13)
        Me.LinkLabel1.TabIndex = 27
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Refresh"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Black
        '
        'Labelinvoice
        '
        Me.Labelinvoice.AutoSize = True
        Me.Labelinvoice.Cursor = System.Windows.Forms.Cursors.Default
        Me.Labelinvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelinvoice.Location = New System.Drawing.Point(319, 18)
        Me.Labelinvoice.Name = "Labelinvoice"
        Me.Labelinvoice.Size = New System.Drawing.Size(78, 15)
        Me.Labelinvoice.TabIndex = 25
        Me.Labelinvoice.Text = "Invoice No:"
        '
        'TextBoxinvoice
        '
        Me.TextBoxinvoice.Enabled = False
        Me.TextBoxinvoice.Location = New System.Drawing.Point(413, 13)
        Me.TextBoxinvoice.Name = "TextBoxinvoice"
        Me.TextBoxinvoice.Size = New System.Drawing.Size(121, 20)
        Me.TextBoxinvoice.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(19, 582)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Date Received:"
        '
        'DateTimePickerreceived
        '
        Me.DateTimePickerreceived.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePickerreceived.Enabled = False
        Me.DateTimePickerreceived.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerreceived.Location = New System.Drawing.Point(121, 576)
        Me.DateTimePickerreceived.Name = "DateTimePickerreceived"
        Me.DateTimePickerreceived.Size = New System.Drawing.Size(193, 20)
        Me.DateTimePickerreceived.TabIndex = 22
        Me.DateTimePickerreceived.Value = New Date(2018, 10, 12, 21, 27, 0, 0)
        '
        'Buttoncompleted
        '
        Me.Buttoncompleted.BackColor = System.Drawing.Color.Transparent
        Me.Buttoncompleted.Enabled = False
        Me.Buttoncompleted.FlatAppearance.BorderSize = 0
        Me.Buttoncompleted.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Buttoncompleted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttoncompleted.Location = New System.Drawing.Point(423, 571)
        Me.Buttoncompleted.Name = "Buttoncompleted"
        Me.Buttoncompleted.Size = New System.Drawing.Size(75, 23)
        Me.Buttoncompleted.TabIndex = 21
        Me.Buttoncompleted.Text = "Complete"
        Me.Buttoncompleted.UseVisualStyleBackColor = False
        '
        'Buttonedit
        '
        Me.Buttonedit.BackColor = System.Drawing.Color.Transparent
        Me.Buttonedit.Enabled = False
        Me.Buttonedit.FlatAppearance.BorderSize = 0
        Me.Buttonedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buttonedit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonedit.Location = New System.Drawing.Point(-10, 14)
        Me.Buttonedit.Name = "Buttonedit"
        Me.Buttonedit.Size = New System.Drawing.Size(75, 23)
        Me.Buttonedit.TabIndex = 20
        Me.Buttonedit.Text = "Edit"
        Me.Buttonedit.UseVisualStyleBackColor = False
        Me.Buttonedit.Visible = False
        '
        'TextBoxreceivedby
        '
        Me.TextBoxreceivedby.Enabled = False
        Me.TextBoxreceivedby.Location = New System.Drawing.Point(121, 547)
        Me.TextBoxreceivedby.Name = "TextBoxreceivedby"
        Me.TextBoxreceivedby.Size = New System.Drawing.Size(193, 20)
        Me.TextBoxreceivedby.TabIndex = 19
        Me.TextBoxreceivedby.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 550)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Received by :"
        Me.Label7.Visible = False
        '
        'Labelstatus
        '
        Me.Labelstatus.AutoSize = True
        Me.Labelstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelstatus.Location = New System.Drawing.Point(366, 576)
        Me.Labelstatus.Name = "Labelstatus"
        Me.Labelstatus.Size = New System.Drawing.Size(51, 13)
        Me.Labelstatus.TabIndex = 16
        Me.Labelstatus.Text = "Status :"
        '
        'TextBoxcontactno
        '
        Me.TextBoxcontactno.Enabled = False
        Me.TextBoxcontactno.Location = New System.Drawing.Point(101, 107)
        Me.TextBoxcontactno.Name = "TextBoxcontactno"
        Me.TextBoxcontactno.Size = New System.Drawing.Size(203, 20)
        Me.TextBoxcontactno.TabIndex = 15
        '
        'Labelcontactno
        '
        Me.Labelcontactno.AutoSize = True
        Me.Labelcontactno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcontactno.Location = New System.Drawing.Point(18, 113)
        Me.Labelcontactno.Name = "Labelcontactno"
        Me.Labelcontactno.Size = New System.Drawing.Size(77, 13)
        Me.Labelcontactno.TabIndex = 14
        Me.Labelcontactno.Text = "Contact no :"
        '
        'TextBoxtransactempname
        '
        Me.TextBoxtransactempname.Enabled = False
        Me.TextBoxtransactempname.Location = New System.Drawing.Point(86, 45)
        Me.TextBoxtransactempname.Name = "TextBoxtransactempname"
        Me.TextBoxtransactempname.Size = New System.Drawing.Size(185, 20)
        Me.TextBoxtransactempname.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(288, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Transaction Type:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(351, 79)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(178, 20)
        Me.DateTimePicker1.TabIndex = 8
        Me.DateTimePicker1.Value = New Date(2018, 10, 12, 21, 27, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(19, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Sold by:"
        '
        'TextBoxcustadrs
        '
        Me.TextBoxcustadrs.Enabled = False
        Me.TextBoxcustadrs.Location = New System.Drawing.Point(86, 133)
        Me.TextBoxcustadrs.Name = "TextBoxcustadrs"
        Me.TextBoxcustadrs.Size = New System.Drawing.Size(443, 20)
        Me.TextBoxcustadrs.TabIndex = 7
        '
        'ComboBoxtransacttype
        '
        Me.ComboBoxtransacttype.Enabled = False
        Me.ComboBoxtransacttype.FormattingEnabled = True
        Me.ComboBoxtransacttype.Items.AddRange(New Object() {"Delivery", "Pick up", "Walk-in"})
        Me.ComboBoxtransacttype.Location = New System.Drawing.Point(413, 48)
        Me.ComboBoxtransacttype.Name = "ComboBoxtransacttype"
        Me.ComboBoxtransacttype.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxtransacttype.TabIndex = 5
        '
        'TextBoxcustname
        '
        Me.TextBoxcustname.Enabled = False
        Me.TextBoxcustname.Location = New System.Drawing.Point(86, 78)
        Me.TextBoxcustname.Name = "TextBoxcustname"
        Me.TextBoxcustname.Size = New System.Drawing.Size(218, 20)
        Me.TextBoxcustname.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(366, 533)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total : Php"
        '
        'LabelTotalamount
        '
        Me.LabelTotalamount.AutoSize = True
        Me.LabelTotalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalamount.Location = New System.Drawing.Point(455, 533)
        Me.LabelTotalamount.Name = "LabelTotalamount"
        Me.LabelTotalamount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelTotalamount.Size = New System.Drawing.Size(16, 16)
        Me.LabelTotalamount.TabIndex = 4
        Me.LabelTotalamount.Text = "0"
        '
        'DataGridViewcompletedorders
        '
        Me.DataGridViewcompletedorders.AllowUserToAddRows = False
        Me.DataGridViewcompletedorders.AllowUserToDeleteRows = False
        Me.DataGridViewcompletedorders.AutoGenerateColumns = False
        Me.DataGridViewcompletedorders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewcompletedorders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewcompletedorders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewcompletedorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewcompletedorders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.QuantityDataGridViewTextBoxColumn, Me.Unit, Me.Column1DataGridViewTextBoxColumn, Me.ProductpriceDataGridViewTextBoxColumn, Me.SubtotalDataGridViewTextBoxColumn})
        Me.DataGridViewcompletedorders.DataSource = Me.SproccompletedordersBindingSource2
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewcompletedorders.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewcompletedorders.Enabled = False
        Me.DataGridViewcompletedorders.Location = New System.Drawing.Point(21, 164)
        Me.DataGridViewcompletedorders.Name = "DataGridViewcompletedorders"
        Me.DataGridViewcompletedorders.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewcompletedorders.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewcompletedorders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewcompletedorders.Size = New System.Drawing.Size(507, 358)
        Me.DataGridViewcompletedorders.TabIndex = 3
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "quantity"
        Me.QuantityDataGridViewTextBoxColumn.FillWeight = 49.28387!
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QuantityDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        Me.QuantityDataGridViewTextBoxColumn.ReadOnly = True
        Me.QuantityDataGridViewTextBoxColumn.Width = 48
        '
        'Unit
        '
        Me.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Unit.FillWeight = 38.07106!
        Me.Unit.HeaderText = "Unit"
        Me.Unit.MinimumWidth = 10
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        Me.Unit.ToolTipText = "Unit"
        Me.Unit.Width = 51
        '
        'Column1DataGridViewTextBoxColumn
        '
        Me.Column1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.Column1DataGridViewTextBoxColumn.DataPropertyName = "Column1"
        Me.Column1DataGridViewTextBoxColumn.FillWeight = 187.371!
        Me.Column1DataGridViewTextBoxColumn.HeaderText = "Product Name"
        Me.Column1DataGridViewTextBoxColumn.Name = "Column1DataGridViewTextBoxColumn"
        Me.Column1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductpriceDataGridViewTextBoxColumn
        '
        Me.ProductpriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.ProductpriceDataGridViewTextBoxColumn.DataPropertyName = "productprice"
        Me.ProductpriceDataGridViewTextBoxColumn.FillWeight = 187.371!
        Me.ProductpriceDataGridViewTextBoxColumn.HeaderText = "Unit Price"
        Me.ProductpriceDataGridViewTextBoxColumn.Name = "ProductpriceDataGridViewTextBoxColumn"
        Me.ProductpriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductpriceDataGridViewTextBoxColumn.Width = 78
        '
        'SubtotalDataGridViewTextBoxColumn
        '
        Me.SubtotalDataGridViewTextBoxColumn.DataPropertyName = "subtotal"
        Me.SubtotalDataGridViewTextBoxColumn.FillWeight = 37.90305!
        Me.SubtotalDataGridViewTextBoxColumn.HeaderText = "Sub Total"
        Me.SubtotalDataGridViewTextBoxColumn.Name = "SubtotalDataGridViewTextBoxColumn"
        Me.SubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SproccompletedordersBindingSource2
        '
        Me.SproccompletedordersBindingSource2.DataMember = "sproc_completedorders"
        Me.SproccompletedordersBindingSource2.DataSource = Me.FinalprojectDataSet17
        '
        'FinalprojectDataSet17
        '
        Me.FinalprojectDataSet17.DataSetName = "finalprojectDataSet17"
        Me.FinalprojectDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(310, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Address :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer :"
        '
        'FinalprojectDataSet15
        '
        Me.FinalprojectDataSet15.DataSetName = "finalprojectDataSet15"
        Me.FinalprojectDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SproccompletedordersBindingSource
        '
        Me.SproccompletedordersBindingSource.DataMember = "sproc_completedorders"
        Me.SproccompletedordersBindingSource.DataSource = Me.FinalprojectDataSet15
        '
        'Sproc_completedordersTableAdapter
        '
        Me.Sproc_completedordersTableAdapter.ClearBeforeFill = True
        '
        'FinalprojectDataSet16
        '
        Me.FinalprojectDataSet16.DataSetName = "finalprojectDataSet16"
        Me.FinalprojectDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SproccompletedordersBindingSource1
        '
        Me.SproccompletedordersBindingSource1.DataMember = "sproc_completedorders"
        Me.SproccompletedordersBindingSource1.DataSource = Me.FinalprojectDataSet16
        '
        'Sproc_completedordersTableAdapter1
        '
        Me.Sproc_completedordersTableAdapter1.ClearBeforeFill = True
        '
        'Sproc_completedordersTableAdapter2
        '
        Me.Sproc_completedordersTableAdapter2.ClearBeforeFill = True
        '
        'viewtransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 616)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "viewtransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewtransactions"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridViewcompletedorders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SproccompletedordersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalprojectDataSet17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalprojectDataSet15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SproccompletedordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalprojectDataSet16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SproccompletedordersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxcontactno As TextBox
    Friend WithEvents Labelcontactno As Label
    Friend WithEvents TextBoxtransactempname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxcustadrs As TextBox
    Friend WithEvents ComboBoxtransacttype As ComboBox
    Friend WithEvents TextBoxcustname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelTotalamount As Label
    Friend WithEvents DataGridViewcompletedorders As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Labelstatus As Label
    Friend WithEvents TextBoxreceivedby As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Buttoncompleted As Button
    Friend WithEvents Buttonedit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerreceived As DateTimePicker
    Friend WithEvents SproccompletedordersBindingSource As BindingSource
    Friend WithEvents FinalprojectDataSet15 As finalprojectDataSet15
    Friend WithEvents Sproc_completedordersTableAdapter As finalprojectDataSet15TableAdapters.sproc_completedordersTableAdapter
    Friend WithEvents SproccompletedordersBindingSource2 As BindingSource
    Friend WithEvents FinalprojectDataSet17 As finalprojectDataSet17
    Friend WithEvents FinalprojectDataSet16 As finalprojectDataSet16
    Friend WithEvents SproccompletedordersBindingSource1 As BindingSource
    Friend WithEvents Sproc_completedordersTableAdapter1 As finalprojectDataSet16TableAdapters.sproc_completedordersTableAdapter
    Friend WithEvents Sproc_completedordersTableAdapter2 As finalprojectDataSet17TableAdapters.sproc_completedordersTableAdapter
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Unit As DataGridViewTextBoxColumn
    Friend WithEvents Column1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductpriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SubtotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Labelinvoice As Label
    Friend WithEvents TextBoxinvoice As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
