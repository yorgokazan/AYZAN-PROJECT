<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rental
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rental))
        Dim Rental_idLabel As System.Windows.Forms.Label
        Dim Client_idLabel As System.Windows.Forms.Label
        Dim Car_idLabel As System.Windows.Forms.Label
        Dim R_dateLabel As System.Windows.Forms.Label
        Dim Current_kmLabel As System.Windows.Forms.Label
        Dim TotalLabel As System.Windows.Forms.Label
        Me.AYZAN_GROUPDataSet = New AYZAN_PROJECT.AYZAN_GROUPDataSet()
        Me.RentalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RentalTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.RentalTableAdapter()
        Me.TableAdapterManager = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager()
        Me.RentalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RentalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RentalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rental_idTextBox = New System.Windows.Forms.TextBox()
        Me.Client_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Car_idComboBox = New System.Windows.Forms.ComboBox()
        Me.R_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Current_kmTextBox = New System.Windows.Forms.TextBox()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.ClientTableAdapter()
        Me.ClientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.CarTableAdapter()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Rental_idLabel = New System.Windows.Forms.Label()
        Client_idLabel = New System.Windows.Forms.Label()
        Car_idLabel = New System.Windows.Forms.Label()
        R_dateLabel = New System.Windows.Forms.Label()
        Current_kmLabel = New System.Windows.Forms.Label()
        TotalLabel = New System.Windows.Forms.Label()
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RentalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentalBindingNavigator.SuspendLayout()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AYZAN_GROUPDataSet
        '
        Me.AYZAN_GROUPDataSet.DataSetName = "AYZAN_GROUPDataSet"
        Me.AYZAN_GROUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RentalBindingSource
        '
        Me.RentalBindingSource.DataMember = "Rental"
        Me.RentalBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'RentalTableAdapter
        '
        Me.RentalTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Me.CarTableAdapter
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.ColorTableAdapter = Nothing
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Me.RentalTableAdapter
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RentalBindingNavigator
        '
        Me.RentalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RentalBindingNavigator.BindingSource = Me.RentalBindingSource
        Me.RentalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RentalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RentalBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.RentalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RentalBindingNavigatorSaveItem})
        Me.RentalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RentalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RentalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RentalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RentalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RentalBindingNavigator.Name = "RentalBindingNavigator"
        Me.RentalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RentalBindingNavigator.Size = New System.Drawing.Size(1174, 27)
        Me.RentalBindingNavigator.TabIndex = 0
        Me.RentalBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RentalBindingNavigatorSaveItem
        '
        Me.RentalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RentalBindingNavigatorSaveItem.Image = CType(resources.GetObject("RentalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RentalBindingNavigatorSaveItem.Name = "RentalBindingNavigatorSaveItem"
        Me.RentalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.RentalBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RentalDataGridView
        '
        Me.RentalDataGridView.AutoGenerateColumns = False
        Me.RentalDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.RentalDataGridView.DataSource = Me.RentalBindingSource
        Me.RentalDataGridView.Location = New System.Drawing.Point(40, 227)
        Me.RentalDataGridView.Name = "RentalDataGridView"
        Me.RentalDataGridView.RowTemplate.Height = 24
        Me.RentalDataGridView.Size = New System.Drawing.Size(629, 220)
        Me.RentalDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "rental_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "client_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CLIENT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "car_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CAR"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "R_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "RENTAL DATE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "current_km"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CURRENT KM"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "total"
        Me.DataGridViewTextBoxColumn6.HeaderText = "TOTAL"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Rental_idLabel
        '
        Rental_idLabel.AutoSize = True
        Rental_idLabel.Location = New System.Drawing.Point(37, 47)
        Rental_idLabel.Name = "Rental_idLabel"
        Rental_idLabel.Size = New System.Drawing.Size(25, 17)
        Rental_idLabel.TabIndex = 2
        Rental_idLabel.Text = "ID:"
        '
        'Rental_idTextBox
        '
        Me.Rental_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "rental_id", True))
        Me.Rental_idTextBox.Location = New System.Drawing.Point(159, 44)
        Me.Rental_idTextBox.Name = "Rental_idTextBox"
        Me.Rental_idTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Rental_idTextBox.TabIndex = 3
        '
        'Client_idLabel
        '
        Client_idLabel.AutoSize = True
        Client_idLabel.Location = New System.Drawing.Point(37, 75)
        Client_idLabel.Name = "Client_idLabel"
        Client_idLabel.Size = New System.Drawing.Size(60, 17)
        Client_idLabel.TabIndex = 4
        Client_idLabel.Text = "CLIENT:"
        '
        'Client_idComboBox
        '
        Me.Client_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "client_id", True))
        Me.Client_idComboBox.FormattingEnabled = True
        Me.Client_idComboBox.Location = New System.Drawing.Point(159, 72)
        Me.Client_idComboBox.Name = "Client_idComboBox"
        Me.Client_idComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Client_idComboBox.TabIndex = 5
        '
        'Car_idLabel
        '
        Car_idLabel.AutoSize = True
        Car_idLabel.Location = New System.Drawing.Point(37, 106)
        Car_idLabel.Name = "Car_idLabel"
        Car_idLabel.Size = New System.Drawing.Size(40, 17)
        Car_idLabel.TabIndex = 6
        Car_idLabel.Text = "CAR:"
        '
        'Car_idComboBox
        '
        Me.Car_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "car_id", True))
        Me.Car_idComboBox.FormattingEnabled = True
        Me.Car_idComboBox.Location = New System.Drawing.Point(159, 103)
        Me.Car_idComboBox.Name = "Car_idComboBox"
        Me.Car_idComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Car_idComboBox.TabIndex = 7
        '
        'R_dateLabel
        '
        R_dateLabel.AutoSize = True
        R_dateLabel.Location = New System.Drawing.Point(37, 138)
        R_dateLabel.Name = "R_dateLabel"
        R_dateLabel.Size = New System.Drawing.Size(108, 17)
        R_dateLabel.TabIndex = 8
        R_dateLabel.Text = "RENTAL DATE:"
        '
        'R_dateDateTimePicker
        '
        Me.R_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RentalBindingSource, "R_date", True))
        Me.R_dateDateTimePicker.Location = New System.Drawing.Point(159, 134)
        Me.R_dateDateTimePicker.Name = "R_dateDateTimePicker"
        Me.R_dateDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.R_dateDateTimePicker.TabIndex = 9
        '
        'Current_kmLabel
        '
        Current_kmLabel.AutoSize = True
        Current_kmLabel.Location = New System.Drawing.Point(37, 165)
        Current_kmLabel.Name = "Current_kmLabel"
        Current_kmLabel.Size = New System.Drawing.Size(103, 17)
        Current_kmLabel.TabIndex = 10
        Current_kmLabel.Text = "CURRENT KM:"
        '
        'Current_kmTextBox
        '
        Me.Current_kmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "current_km", True))
        Me.Current_kmTextBox.Location = New System.Drawing.Point(159, 162)
        Me.Current_kmTextBox.Name = "Current_kmTextBox"
        Me.Current_kmTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Current_kmTextBox.TabIndex = 11
        '
        'TotalLabel
        '
        TotalLabel.AutoSize = True
        TotalLabel.Location = New System.Drawing.Point(37, 193)
        TotalLabel.Name = "TotalLabel"
        TotalLabel.Size = New System.Drawing.Size(58, 17)
        TotalLabel.TabIndex = 12
        TotalLabel.Text = "TOTAL:"
        '
        'TotalTextBox
        '
        Me.TotalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RentalBindingSource, "total", True))
        Me.TotalTextBox.Location = New System.Drawing.Point(159, 190)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TotalTextBox.TabIndex = 13
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'ClientDataGridView
        '
        Me.ClientDataGridView.AllowUserToAddRows = False
        Me.ClientDataGridView.AllowUserToDeleteRows = False
        Me.ClientDataGridView.AutoGenerateColumns = False
        Me.ClientDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ClientDataGridView.DataSource = Me.ClientBindingSource
        Me.ClientDataGridView.Location = New System.Drawing.Point(688, 249)
        Me.ClientDataGridView.Name = "ClientDataGridView"
        Me.ClientDataGridView.ReadOnly = True
        Me.ClientDataGridView.RowTemplate.Height = 24
        Me.ClientDataGridView.Size = New System.Drawing.Size(438, 140)
        Me.ClientDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "client_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "client_name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "NAME"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'CarBindingSource
        '
        Me.CarBindingSource.DataMember = "Car"
        Me.CarBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'CarTableAdapter
        '
        Me.CarTableAdapter.ClearBeforeFill = True
        '
        'CarDataGridView
        '
        Me.CarDataGridView.AllowUserToAddRows = False
        Me.CarDataGridView.AllowUserToDeleteRows = False
        Me.CarDataGridView.AutoGenerateColumns = False
        Me.CarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.CarDataGridView.DataSource = Me.CarBindingSource
        Me.CarDataGridView.Location = New System.Drawing.Point(688, 75)
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.ReadOnly = True
        Me.CarDataGridView.RowTemplate.Height = 24
        Me.CarDataGridView.Size = New System.Drawing.Size(438, 138)
        Me.CarDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "car_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "model_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "MODEL"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "brand_id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "BRAND"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "style_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "STYLE"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "color_id"
        Me.DataGridViewTextBoxColumn14.HeaderText = "COLOR"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(826, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "REFERENCES:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1051, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1174, 591)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CarDataGridView)
        Me.Controls.Add(Me.ClientDataGridView)
        Me.Controls.Add(Rental_idLabel)
        Me.Controls.Add(Me.Rental_idTextBox)
        Me.Controls.Add(Client_idLabel)
        Me.Controls.Add(Me.Client_idComboBox)
        Me.Controls.Add(Car_idLabel)
        Me.Controls.Add(Me.Car_idComboBox)
        Me.Controls.Add(R_dateLabel)
        Me.Controls.Add(Me.R_dateDateTimePicker)
        Me.Controls.Add(Current_kmLabel)
        Me.Controls.Add(Me.Current_kmTextBox)
        Me.Controls.Add(TotalLabel)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.RentalDataGridView)
        Me.Controls.Add(Me.RentalBindingNavigator)
        Me.Name = "rental"
        Me.Text = "rental"
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RentalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentalBindingNavigator.ResumeLayout(False)
        Me.RentalBindingNavigator.PerformLayout()
        CType(Me.RentalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AYZAN_GROUPDataSet As AYZAN_GROUPDataSet
    Friend WithEvents RentalBindingSource As BindingSource
    Friend WithEvents RentalTableAdapter As AYZAN_GROUPDataSetTableAdapters.RentalTableAdapter
    Friend WithEvents TableAdapterManager As AYZAN_GROUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RentalBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents RentalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents RentalDataGridView As DataGridView
    Friend WithEvents ClientTableAdapter As AYZAN_GROUPDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Rental_idTextBox As TextBox
    Friend WithEvents Client_idComboBox As ComboBox
    Friend WithEvents Car_idComboBox As ComboBox
    Friend WithEvents R_dateDateTimePicker As DateTimePicker
    Friend WithEvents Current_kmTextBox As TextBox
    Friend WithEvents TotalTextBox As TextBox
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As AYZAN_GROUPDataSetTableAdapters.CarTableAdapter
    Friend WithEvents ClientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
