<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class model
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
        Dim Model_idLabel As System.Windows.Forms.Label
        Dim Model_nameLabel As System.Windows.Forms.Label
        Dim Category_idLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(model))
        Me.AYZAN_GROUPDataSet = New AYZAN_PROJECT.AYZAN_GROUPDataSet()
        Me.ModelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModelTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.ModelTableAdapter()
        Me.TableAdapterManager = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager()
        Me.CategoryTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.CategoryTableAdapter()
        Me.ModelBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ModelBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ModelDataGridView = New System.Windows.Forms.DataGridView()
        Me.Model_idTextBox = New System.Windows.Forms.TextBox()
        Me.Model_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Category_idComboBox = New System.Windows.Forms.ComboBox()
        Me.CategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Model_idLabel = New System.Windows.Forms.Label()
        Model_nameLabel = New System.Windows.Forms.Label()
        Category_idLabel = New System.Windows.Forms.Label()
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModelBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ModelBindingNavigator.SuspendLayout()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Model_idLabel
        '
        Model_idLabel.AutoSize = True
        Model_idLabel.Location = New System.Drawing.Point(64, 94)
        Model_idLabel.Name = "Model_idLabel"
        Model_idLabel.Size = New System.Drawing.Size(25, 17)
        Model_idLabel.TabIndex = 2
        Model_idLabel.Text = "ID:"
        '
        'Model_nameLabel
        '
        Model_nameLabel.AutoSize = True
        Model_nameLabel.Location = New System.Drawing.Point(64, 122)
        Model_nameLabel.Name = "Model_nameLabel"
        Model_nameLabel.Size = New System.Drawing.Size(61, 17)
        Model_nameLabel.TabIndex = 4
        Model_nameLabel.Text = "MODEL:"
        '
        'Category_idLabel
        '
        Category_idLabel.AutoSize = True
        Category_idLabel.Location = New System.Drawing.Point(64, 150)
        Category_idLabel.Name = "Category_idLabel"
        Category_idLabel.Size = New System.Drawing.Size(106, 17)
        Category_idLabel.TabIndex = 6
        Category_idLabel.Text = "CATEGORY ID:"
        '
        'AYZAN_GROUPDataSet
        '
        Me.AYZAN_GROUPDataSet.DataSetName = "AYZAN_GROUPDataSet"
        Me.AYZAN_GROUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Me.CategoryTableAdapter
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.ColorTableAdapter = Nothing
        Me.TableAdapterManager.ModelTableAdapter = Me.ModelTableAdapter
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoryTableAdapter
        '
        Me.CategoryTableAdapter.ClearBeforeFill = True
        '
        'ModelBindingNavigator
        '
        Me.ModelBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ModelBindingNavigator.BindingSource = Me.ModelBindingSource
        Me.ModelBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ModelBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ModelBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ModelBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ModelBindingNavigatorSaveItem})
        Me.ModelBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ModelBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ModelBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ModelBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ModelBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ModelBindingNavigator.Name = "ModelBindingNavigator"
        Me.ModelBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ModelBindingNavigator.Size = New System.Drawing.Size(1093, 27)
        Me.ModelBindingNavigator.TabIndex = 0
        Me.ModelBindingNavigator.Text = "BindingNavigator1"
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
        'ModelBindingNavigatorSaveItem
        '
        Me.ModelBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ModelBindingNavigatorSaveItem.Image = CType(resources.GetObject("ModelBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ModelBindingNavigatorSaveItem.Name = "ModelBindingNavigatorSaveItem"
        Me.ModelBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.ModelBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ModelDataGridView
        '
        Me.ModelDataGridView.AutoGenerateColumns = False
        Me.ModelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ModelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.ModelDataGridView.DataSource = Me.ModelBindingSource
        Me.ModelDataGridView.Location = New System.Drawing.Point(67, 196)
        Me.ModelDataGridView.Name = "ModelDataGridView"
        Me.ModelDataGridView.RowTemplate.Height = 24
        Me.ModelDataGridView.Size = New System.Drawing.Size(575, 220)
        Me.ModelDataGridView.TabIndex = 1
        '
        'Model_idTextBox
        '
        Me.Model_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "model_id", True))
        Me.Model_idTextBox.Location = New System.Drawing.Point(176, 91)
        Me.Model_idTextBox.Name = "Model_idTextBox"
        Me.Model_idTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Model_idTextBox.TabIndex = 3
        '
        'Model_nameTextBox
        '
        Me.Model_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "model_name", True))
        Me.Model_nameTextBox.Location = New System.Drawing.Point(176, 119)
        Me.Model_nameTextBox.Name = "Model_nameTextBox"
        Me.Model_nameTextBox.Size = New System.Drawing.Size(121, 22)
        Me.Model_nameTextBox.TabIndex = 5
        '
        'Category_idComboBox
        '
        Me.Category_idComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModelBindingSource, "category_id", True))
        Me.Category_idComboBox.DataSource = Me.CategoryBindingSource
        Me.Category_idComboBox.DisplayMember = "category_id"
        Me.Category_idComboBox.FormattingEnabled = True
        Me.Category_idComboBox.Location = New System.Drawing.Point(176, 147)
        Me.Category_idComboBox.Name = "Category_idComboBox"
        Me.Category_idComboBox.Size = New System.Drawing.Size(121, 24)
        Me.Category_idComboBox.TabIndex = 7
        '
        'CategoryBindingSource
        '
        Me.CategoryBindingSource.DataMember = "Category"
        Me.CategoryBindingSource.DataSource = Me.AYZAN_GROUPDataSet
        '
        'CategoryDataGridView
        '
        Me.CategoryDataGridView.AllowUserToAddRows = False
        Me.CategoryDataGridView.AllowUserToDeleteRows = False
        Me.CategoryDataGridView.AutoGenerateColumns = False
        Me.CategoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.CategoryDataGridView.DataSource = Me.CategoryBindingSource
        Me.CategoryDataGridView.Location = New System.Drawing.Point(742, 52)
        Me.CategoryDataGridView.Name = "CategoryDataGridView"
        Me.CategoryDataGridView.ReadOnly = True
        Me.CategoryDataGridView.RowTemplate.Height = 24
        Me.CategoryDataGridView.Size = New System.Drawing.Size(324, 115)
        Me.CategoryDataGridView.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(542, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 29)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "REFERENCES:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1006, 393)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "category_id"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "categroy_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CATEGORY"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "model_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "model_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "MODEL"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "category_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CATEGORY ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'model
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1093, 526)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CategoryDataGridView)
        Me.Controls.Add(Model_idLabel)
        Me.Controls.Add(Me.Model_idTextBox)
        Me.Controls.Add(Model_nameLabel)
        Me.Controls.Add(Me.Model_nameTextBox)
        Me.Controls.Add(Category_idLabel)
        Me.Controls.Add(Me.Category_idComboBox)
        Me.Controls.Add(Me.ModelDataGridView)
        Me.Controls.Add(Me.ModelBindingNavigator)
        Me.Name = "model"
        Me.Text = "MODEL"
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModelBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ModelBindingNavigator.ResumeLayout(False)
        Me.ModelBindingNavigator.PerformLayout()
        CType(Me.ModelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AYZAN_GROUPDataSet As AYZAN_GROUPDataSet
    Friend WithEvents ModelBindingSource As BindingSource
    Friend WithEvents ModelTableAdapter As AYZAN_GROUPDataSetTableAdapters.ModelTableAdapter
    Friend WithEvents TableAdapterManager As AYZAN_GROUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ModelBindingNavigator As BindingNavigator
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
    Friend WithEvents ModelBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ModelDataGridView As DataGridView
    Friend WithEvents Model_idTextBox As TextBox
    Friend WithEvents Model_nameTextBox As TextBox
    Friend WithEvents Category_idComboBox As ComboBox
    Friend WithEvents CategoryTableAdapter As AYZAN_GROUPDataSetTableAdapters.CategoryTableAdapter
    Friend WithEvents CategoryBindingSource As BindingSource
    Friend WithEvents CategoryDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
