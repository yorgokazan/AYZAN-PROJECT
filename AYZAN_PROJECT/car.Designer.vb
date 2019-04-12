<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class car
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
        Dim Car_idLabel As System.Windows.Forms.Label
        Dim Chassis_numLabel As System.Windows.Forms.Label
        Dim Model_idLabel As System.Windows.Forms.Label
        Dim Brand_idLabel As System.Windows.Forms.Label
        Dim Style_idLabel As System.Windows.Forms.Label
        Dim Color_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(car))
        Me.AYZAN_GROUPDataSet = New AYZAN_PROJECT.AYZAN_GROUPDataSet()
        Me.CarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CarTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.CarTableAdapter()
        Me.TableAdapterManager = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager()
        Me.CarBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CarBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CarDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Car_idTextBox = New System.Windows.Forms.TextBox()
        Me.Chassis_numTextBox = New System.Windows.Forms.TextBox()
        Me.Model_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Brand_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Style_idComboBox = New System.Windows.Forms.ComboBox()
        Me.Color_idComboBox = New System.Windows.Forms.ComboBox()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.ModelTableAdapter()
        Me.ModelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.BrandTableAdapter()
        Me.BrandDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StyleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StyleTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.StyleTableAdapter()
        Me.StyleDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.ColorTableAdapter()
        Me.ColorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Car_idLabel = New System.Windows.Forms.Label()
        Chassis_numLabel = New System.Windows.Forms.Label()
        Model_idLabel = New System.Windows.Forms.Label()
        Brand_idLabel = New System.Windows.Forms.Label()
        Style_idLabel = New System.Windows.Forms.Label()
        Color_idLabel = New System.Windows.Forms.Label()
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CarBindingNavigator.SuspendLayout()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StyleDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car_idLabel
        '
        Car_idLabel.AutoSize = True
        Car_idLabel.Location = New System.Drawing.Point(12, 49)
        Car_idLabel.Name = "Car_idLabel"
        Car_idLabel.Size = New System.Drawing.Size(25, 17)
        Car_idLabel.TabIndex = 2
        Car_idLabel.Text = "ID:"
        '
        'Chassis_numLabel
        '
        Chassis_numLabel.AutoSize = True
        Chassis_numLabel.Location = New System.Drawing.Point(12, 77)
        Chassis_numLabel.Name = "Chassis_numLabel"
        Chassis_numLabel.Size = New System.Drawing.Size(124, 17)
        Chassis_numLabel.TabIndex = 4
        Chassis_numLabel.Text = "CHASSI NUMBER:"
        '
        'Model_idLabel
        '
        Model_idLabel.AutoSize = True
        Model_idLabel.Location = New System.Drawing.Point(12, 105)
        Model_idLabel.Name = "Model_idLabel"
        Model_idLabel.Size = New System.Drawing.Size(61, 17)
        Model_idLabel.TabIndex = 6
        Model_idLabel.Text = "MODEL:"
        '
        'Brand_idLabel
        '
        Brand_idLabel.AutoSize = True
        Brand_idLabel.Location = New System.Drawing.Point(12, 136)
        Brand_idLabel.Name = "Brand_idLabel"
        Brand_idLabel.Size = New System.Drawing.Size(60, 17)
        Brand_idLabel.TabIndex = 8
        Brand_idLabel.Text = "BRAND:"
        '
        'Style_idLabel
        '
        Style_idLabel.AutoSize = True
        Style_idLabel.Location = New System.Drawing.Point(12, 167)
        Style_idLabel.Name = "Style_idLabel"
        Style_idLabel.Size = New System.Drawing.Size(56, 17)
        Style_idLabel.TabIndex = 10
        Style_idLabel.Text = "STYLE:"
        '
        'Color_idLabel
        '
        Color_idLabel.AutoSize = True
        Color_idLabel.Location = New System.Drawing.Point(12, 198)
        Color_idLabel.Name = "Color_idLabel"
        Color_idLabel.Size = New System.Drawing.Size(61, 17)
        Color_idLabel.TabIndex = 12
        Color_idLabel.Text = "COLOR:"
        '
        'AYZAN_GROUPDataSet
        '
        Me.AYZAN_GROUPDataSet.DataSetName = "AYZAN_GROUPDataSet"
        Me.AYZAN_GROUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Me.CarTableAdapter
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.ColorTableAdapter = Nothing
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CarBindingNavigator
        '
        Me.CarBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CarBindingNavigator.BindingSource = Me.CarBindingSource
        Me.CarBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CarBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CarBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CarBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CarBindingNavigatorSaveItem})
        Me.CarBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CarBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CarBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CarBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CarBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CarBindingNavigator.Name = "CarBindingNavigator"
        Me.CarBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CarBindingNavigator.Size = New System.Drawing.Size(1226, 27)
        Me.CarBindingNavigator.TabIndex = 0
        Me.CarBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'CarBindingNavigatorSaveItem
        '
        Me.CarBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CarBindingNavigatorSaveItem.Image = CType(resources.GetObject("CarBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CarBindingNavigatorSaveItem.Name = "CarBindingNavigatorSaveItem"
        Me.CarBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.CarBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CarDataGridView
        '
        Me.CarDataGridView.AutoGenerateColumns = False
        Me.CarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CarDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.CarDataGridView.DataSource = Me.CarBindingSource
        Me.CarDataGridView.Location = New System.Drawing.Point(12, 240)
        Me.CarDataGridView.Name = "CarDataGridView"
        Me.CarDataGridView.RowTemplate.Height = 24
        Me.CarDataGridView.Size = New System.Drawing.Size(579, 220)
        Me.CarDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "car_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "chassis_num"
        Me.DataGridViewTextBoxColumn2.HeaderText = "CHASSI NUMBER"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "model_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "MODEL"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "brand_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BRAND"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "style_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "STYLE"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "color_id"
        Me.DataGridViewTextBoxColumn6.HeaderText = "COLOR"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Car_idTextBox
        '
        Me.Car_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "car_id", True))
        Me.Car_idTextBox.Location = New System.Drawing.Point(167, 49)
        Me.Car_idTextBox.Name = "Car_idTextBox"
        Me.Car_idTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Car_idTextBox.TabIndex = 3
        '
        'Chassis_numTextBox
        '
        Me.Chassis_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "chassis_num", True))
        Me.Chassis_numTextBox.Location = New System.Drawing.Point(167, 77)
        Me.Chassis_numTextBox.Name = "Chassis_numTextBox"
        Me.Chassis_numTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Chassis_numTextBox.TabIndex = 5
        '
        'Model_idComboBox
        '
        Me.Model_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "model_id", True))
        Me.Model_idComboBox.FormattingEnabled = True
        Me.Model_idComboBox.Location = New System.Drawing.Point(167, 105)
        Me.Model_idComboBox.Name = "Model_idComboBox"
        Me.Model_idComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Model_idComboBox.TabIndex = 7
        '
        'Brand_idComboBox
        '
        Me.Brand_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "brand_id", True))
        Me.Brand_idComboBox.FormattingEnabled = True
        Me.Brand_idComboBox.Location = New System.Drawing.Point(167, 136)
        Me.Brand_idComboBox.Name = "Brand_idComboBox"
        Me.Brand_idComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Brand_idComboBox.TabIndex = 9
        '
        'Style_idComboBox
        '
        Me.Style_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "style_id", True))
        Me.Style_idComboBox.FormattingEnabled = True
        Me.Style_idComboBox.Location = New System.Drawing.Point(167, 167)
        Me.Style_idComboBox.Name = "Style_idComboBox"
        Me.Style_idComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Style_idComboBox.TabIndex = 11
        '
        'Color_idComboBox
        '
        Me.Color_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CarBindingSource, "color_id", True))
        Me.Color_idComboBox.FormattingEnabled = True
        Me.Color_idComboBox.Location = New System.Drawing.Point(167, 198)
        Me.Color_idComboBox.Name = "Color_idComboBox"
        Me.Color_idComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Color_idComboBox.TabIndex = 13
        '
        'ModelBindingSource
        '
        Me.ModelBindingSource.DataMember = "Model"
        Me.ModelBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'ModelTableAdapter
        '
        Me.ModelTableAdapter.ClearBeforeFill = True
        '
        'ModelDataGridView
        '
        Me.ModelDataGridView.AllowUserToAddRows = False
        Me.ModelDataGridView.AllowUserToDeleteRows = False
        Me.ModelDataGridView.AutoGenerateColumns = False
        Me.ModelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.ModelDataGridView.DataSource = Me.ModelBindingSource
        Me.ModelDataGridView.Location = New System.Drawing.Point(612, 74)
        Me.ModelDataGridView.Name = "ModelDataGridView"
        Me.ModelDataGridView.ReadOnly = True
        Me.ModelDataGridView.RowTemplate.Height = 24
        Me.ModelDataGridView.Size = New System.Drawing.Size(250, 141)
        Me.ModelDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "model_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "model_id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "model_name"
        Me.DataGridViewTextBoxColumn8.HeaderText = "model_name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'BrandBindingSource
        '
        Me.BrandBindingSource.DataMember = "Brand"
        Me.BrandBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'BrandTableAdapter
        '
        Me.BrandTableAdapter.ClearBeforeFill = True
        '
        'BrandDataGridView
        '
        Me.BrandDataGridView.AllowUserToAddRows = False
        Me.BrandDataGridView.AllowUserToDeleteRows = False
        Me.BrandDataGridView.AutoGenerateColumns = False
        Me.BrandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrandDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.BrandDataGridView.DataSource = Me.BrandBindingSource
        Me.BrandDataGridView.Location = New System.Drawing.Point(878, 74)
        Me.BrandDataGridView.Name = "BrandDataGridView"
        Me.BrandDataGridView.ReadOnly = True
        Me.BrandDataGridView.RowTemplate.Height = 24
        Me.BrandDataGridView.Size = New System.Drawing.Size(250, 141)
        Me.BrandDataGridView.TabIndex = 15
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "brand_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "brand_id"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "brand_name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "brand_name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'StyleBindingSource
        '
        Me.StyleBindingSource.DataMember = "Style"
        Me.StyleBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'StyleTableAdapter
        '
        Me.StyleTableAdapter.ClearBeforeFill = True
        '
        'StyleDataGridView
        '
        Me.StyleDataGridView.AllowUserToAddRows = False
        Me.StyleDataGridView.AllowUserToDeleteRows = False
        Me.StyleDataGridView.AutoGenerateColumns = False
        Me.StyleDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StyleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StyleDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.StyleDataGridView.DataSource = Me.StyleBindingSource
        Me.StyleDataGridView.Location = New System.Drawing.Point(612, 240)
        Me.StyleDataGridView.Name = "StyleDataGridView"
        Me.StyleDataGridView.ReadOnly = True
        Me.StyleDataGridView.RowTemplate.Height = 24
        Me.StyleDataGridView.Size = New System.Drawing.Size(250, 141)
        Me.StyleDataGridView.TabIndex = 16
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "style_id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "style_id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "style_name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "style_name"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'ColorBindingSource
        '
        Me.ColorBindingSource.DataMember = "Color"
        Me.ColorBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'ColorTableAdapter
        '
        Me.ColorTableAdapter.ClearBeforeFill = True
        '
        'ColorDataGridView
        '
        Me.ColorDataGridView.AllowUserToAddRows = False
        Me.ColorDataGridView.AllowUserToDeleteRows = False
        Me.ColorDataGridView.AutoGenerateColumns = False
        Me.ColorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.ColorDataGridView.DataSource = Me.ColorBindingSource
        Me.ColorDataGridView.Location = New System.Drawing.Point(878, 240)
        Me.ColorDataGridView.Name = "ColorDataGridView"
        Me.ColorDataGridView.ReadOnly = True
        Me.ColorDataGridView.RowTemplate.Height = 24
        Me.ColorDataGridView.Size = New System.Drawing.Size(250, 141)
        Me.ColorDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "color_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "color_id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "colore_name"
        Me.DataGridViewTextBoxColumn14.HeaderText = "colore_name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1053, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(793, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 25)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "REFERENCES:"
        '
        'car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1226, 529)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ColorDataGridView)
        Me.Controls.Add(Me.StyleDataGridView)
        Me.Controls.Add(Me.BrandDataGridView)
        Me.Controls.Add(Me.ModelDataGridView)
        Me.Controls.Add(Car_idLabel)
        Me.Controls.Add(Me.Car_idTextBox)
        Me.Controls.Add(Chassis_numLabel)
        Me.Controls.Add(Me.Chassis_numTextBox)
        Me.Controls.Add(Model_idLabel)
        Me.Controls.Add(Me.Model_idComboBox)
        Me.Controls.Add(Brand_idLabel)
        Me.Controls.Add(Me.Brand_idComboBox)
        Me.Controls.Add(Style_idLabel)
        Me.Controls.Add(Me.Style_idComboBox)
        Me.Controls.Add(Color_idLabel)
        Me.Controls.Add(Me.Color_idComboBox)
        Me.Controls.Add(Me.CarDataGridView)
        Me.Controls.Add(Me.CarBindingNavigator)
        Me.Name = "car"
        Me.Text = "car"
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CarBindingNavigator.ResumeLayout(False)
        Me.CarBindingNavigator.PerformLayout()
        CType(Me.CarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StyleDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AYZAN_GROUPDataSet As AYZAN_GROUPDataSet
    Friend WithEvents CarBindingSource As BindingSource
    Friend WithEvents CarTableAdapter As AYZAN_GROUPDataSetTableAdapters.CarTableAdapter
    Friend WithEvents TableAdapterManager As AYZAN_GROUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CarBindingNavigator As BindingNavigator
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
    Friend WithEvents CarBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CarDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents Car_idTextBox As TextBox
    Friend WithEvents Chassis_numTextBox As TextBox
    Friend WithEvents Model_idComboBox As ComboBox
    Friend WithEvents Brand_idComboBox As ComboBox
    Friend WithEvents Style_idComboBox As ComboBox
    Friend WithEvents Color_idComboBox As ComboBox
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents ModelTableAdapter As AYZAN_GROUPDataSetTableAdapters.ModelTableAdapter
    Friend WithEvents ModelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandTableAdapter As AYZAN_GROUPDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents BrandDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents StyleBindingSource As BindingSource
    Friend WithEvents StyleTableAdapter As AYZAN_GROUPDataSetTableAdapters.StyleTableAdapter
    Friend WithEvents StyleDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As AYZAN_GROUPDataSetTableAdapters.ColorTableAdapter
    Friend WithEvents ColorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
