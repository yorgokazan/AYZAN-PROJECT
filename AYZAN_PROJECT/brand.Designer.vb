<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class brand
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
        Dim Brand_idLabel As System.Windows.Forms.Label
        Dim Brand_nameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(brand))
        Me.AYZAN_GROUPDataSet = New AYZAN_PROJECT.AYZAN_GROUPDataSet()
        Me.BrandBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BrandTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.BrandTableAdapter()
        Me.TableAdapterManager = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager()
        Me.BrandBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BrandBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.BrandDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand_idTextBox = New System.Windows.Forms.TextBox()
        Me.Brand_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Brand_idLabel = New System.Windows.Forms.Label()
        Brand_nameLabel = New System.Windows.Forms.Label()
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BrandBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BrandBindingNavigator.SuspendLayout()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Brand_idLabel
        '
        Brand_idLabel.AutoSize = True
        Brand_idLabel.Location = New System.Drawing.Point(63, 70)
        Brand_idLabel.Name = "Brand_idLabel"
        Brand_idLabel.Size = New System.Drawing.Size(25, 17)
        Brand_idLabel.TabIndex = 2
        Brand_idLabel.Text = "ID:"
        '
        'Brand_nameLabel
        '
        Brand_nameLabel.AutoSize = True
        Brand_nameLabel.Location = New System.Drawing.Point(63, 98)
        Brand_nameLabel.Name = "Brand_nameLabel"
        Brand_nameLabel.Size = New System.Drawing.Size(60, 17)
        Brand_nameLabel.TabIndex = 4
        Brand_nameLabel.Text = "BRAND:"
        '
        'AYZAN_GROUPDataSet
        '
        Me.AYZAN_GROUPDataSet.DataSetName = "AYZAN_GROUPDataSet"
        Me.AYZAN_GROUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Me.BrandTableAdapter
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.ColorTableAdapter = Nothing
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BrandBindingNavigator
        '
        Me.BrandBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BrandBindingNavigator.BindingSource = Me.BrandBindingSource
        Me.BrandBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.BrandBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BrandBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BrandBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BrandBindingNavigatorSaveItem})
        Me.BrandBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.BrandBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BrandBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BrandBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BrandBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BrandBindingNavigator.Name = "BrandBindingNavigator"
        Me.BrandBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.BrandBindingNavigator.Size = New System.Drawing.Size(1118, 27)
        Me.BrandBindingNavigator.TabIndex = 0
        Me.BrandBindingNavigator.Text = "BindingNavigator1"
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
        'BrandBindingNavigatorSaveItem
        '
        Me.BrandBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BrandBindingNavigatorSaveItem.Image = CType(resources.GetObject("BrandBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BrandBindingNavigatorSaveItem.Name = "BrandBindingNavigatorSaveItem"
        Me.BrandBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.BrandBindingNavigatorSaveItem.Text = "Save Data"
        '
        'BrandDataGridView
        '
        Me.BrandDataGridView.AutoGenerateColumns = False
        Me.BrandDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.BrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BrandDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.BrandDataGridView.DataSource = Me.BrandBindingSource
        Me.BrandDataGridView.Location = New System.Drawing.Point(66, 161)
        Me.BrandDataGridView.Name = "BrandDataGridView"
        Me.BrandDataGridView.RowTemplate.Height = 24
        Me.BrandDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.BrandDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "brand_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "brand_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BRAND"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Brand_idTextBox
        '
        Me.Brand_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrandBindingSource, "brand_id", True))
        Me.Brand_idTextBox.Location = New System.Drawing.Point(157, 67)
        Me.Brand_idTextBox.Name = "Brand_idTextBox"
        Me.Brand_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Brand_idTextBox.TabIndex = 3
        '
        'Brand_nameTextBox
        '
        Me.Brand_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BrandBindingSource, "brand_name", True))
        Me.Brand_nameTextBox.Location = New System.Drawing.Point(157, 95)
        Me.Brand_nameTextBox.Name = "Brand_nameTextBox"
        Me.Brand_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Brand_nameTextBox.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1031, 358)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'brand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1118, 604)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Brand_idLabel)
        Me.Controls.Add(Me.Brand_idTextBox)
        Me.Controls.Add(Brand_nameLabel)
        Me.Controls.Add(Me.Brand_nameTextBox)
        Me.Controls.Add(Me.BrandDataGridView)
        Me.Controls.Add(Me.BrandBindingNavigator)
        Me.Name = "brand"
        Me.Text = "brand"
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BrandBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BrandBindingNavigator.ResumeLayout(False)
        Me.BrandBindingNavigator.PerformLayout()
        CType(Me.BrandDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AYZAN_GROUPDataSet As AYZAN_GROUPDataSet
    Friend WithEvents BrandBindingSource As BindingSource
    Friend WithEvents BrandTableAdapter As AYZAN_GROUPDataSetTableAdapters.BrandTableAdapter
    Friend WithEvents TableAdapterManager As AYZAN_GROUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BrandBindingNavigator As BindingNavigator
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
    Friend WithEvents BrandBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents BrandDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Brand_idTextBox As TextBox
    Friend WithEvents Brand_nameTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
