<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class color
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(color))
        Dim Color_idLabel As System.Windows.Forms.Label
        Dim Colore_nameLabel As System.Windows.Forms.Label
        Me.AYZAN_GROUPDataSet = New AYZAN_PROJECT.AYZAN_GROUPDataSet()
        Me.ColorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ColorTableAdapter = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.ColorTableAdapter()
        Me.TableAdapterManager = New AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager()
        Me.ColorBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ColorBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ColorDataGridView = New System.Windows.Forms.DataGridView()
        Me.Color_idTextBox = New System.Windows.Forms.TextBox()
        Me.Colore_nameTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Color_idLabel = New System.Windows.Forms.Label()
        Colore_nameLabel = New System.Windows.Forms.Label()
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ColorBindingNavigator.SuspendLayout()
        CType(Me.ColorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AYZAN_GROUPDataSet
        '
        Me.AYZAN_GROUPDataSet.DataSetName = "AYZAN_GROUPDataSet"
        Me.AYZAN_GROUPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BrandTableAdapter = Nothing
        Me.TableAdapterManager.CarTableAdapter = Nothing
        Me.TableAdapterManager.CategoryTableAdapter = Nothing
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.ColorTableAdapter = Me.ColorTableAdapter
        Me.TableAdapterManager.ModelTableAdapter = Nothing
        Me.TableAdapterManager.RentalTableAdapter = Nothing
        Me.TableAdapterManager.StyleTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AYZAN_PROJECT.AYZAN_GROUPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ColorBindingNavigator
        '
        Me.ColorBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ColorBindingNavigator.BindingSource = Me.ColorBindingSource
        Me.ColorBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ColorBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ColorBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ColorBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ColorBindingNavigatorSaveItem})
        Me.ColorBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ColorBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ColorBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ColorBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ColorBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ColorBindingNavigator.Name = "ColorBindingNavigator"
        Me.ColorBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ColorBindingNavigator.Size = New System.Drawing.Size(1096, 27)
        Me.ColorBindingNavigator.TabIndex = 0
        Me.ColorBindingNavigator.Text = "BindingNavigator1"
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
        'ColorBindingNavigatorSaveItem
        '
        Me.ColorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ColorBindingNavigatorSaveItem.Image = CType(resources.GetObject("ColorBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ColorBindingNavigatorSaveItem.Name = "ColorBindingNavigatorSaveItem"
        Me.ColorBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.ColorBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ColorDataGridView
        '
        Me.ColorDataGridView.AutoGenerateColumns = False
        Me.ColorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ColorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ColorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.ColorDataGridView.DataSource = Me.ColorBindingSource
        Me.ColorDataGridView.Location = New System.Drawing.Point(54, 172)
        Me.ColorDataGridView.Name = "ColorDataGridView"
        Me.ColorDataGridView.RowTemplate.Height = 24
        Me.ColorDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ColorDataGridView.TabIndex = 1
        '
        'Color_idLabel
        '
        Color_idLabel.AutoSize = True
        Color_idLabel.Location = New System.Drawing.Point(51, 75)
        Color_idLabel.Name = "Color_idLabel"
        Color_idLabel.Size = New System.Drawing.Size(25, 17)
        Color_idLabel.TabIndex = 2
        Color_idLabel.Text = "ID:"
        '
        'Color_idTextBox
        '
        Me.Color_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColorBindingSource, "color_id", True))
        Me.Color_idTextBox.Location = New System.Drawing.Point(147, 72)
        Me.Color_idTextBox.Name = "Color_idTextBox"
        Me.Color_idTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Color_idTextBox.TabIndex = 3
        '
        'Colore_nameLabel
        '
        Colore_nameLabel.AutoSize = True
        Colore_nameLabel.Location = New System.Drawing.Point(51, 103)
        Colore_nameLabel.Name = "Colore_nameLabel"
        Colore_nameLabel.Size = New System.Drawing.Size(61, 17)
        Colore_nameLabel.TabIndex = 4
        Colore_nameLabel.Text = "COLOR:"
        '
        'Colore_nameTextBox
        '
        Me.Colore_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ColorBindingSource, "colore_name", True))
        Me.Colore_nameTextBox.Location = New System.Drawing.Point(147, 100)
        Me.Colore_nameTextBox.Name = "Colore_nameTextBox"
        Me.Colore_nameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Colore_nameTextBox.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "color_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "colore_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "COLOR"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1009, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'color
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1096, 523)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Color_idLabel)
        Me.Controls.Add(Me.Color_idTextBox)
        Me.Controls.Add(Colore_nameLabel)
        Me.Controls.Add(Me.Colore_nameTextBox)
        Me.Controls.Add(Me.ColorDataGridView)
        Me.Controls.Add(Me.ColorBindingNavigator)
        Me.Name = "color"
        Me.Text = "color"
        CType(Me.AYZAN_GROUPDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ColorBindingNavigator.ResumeLayout(False)
        Me.ColorBindingNavigator.PerformLayout()
        CType(Me.ColorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AYZAN_GROUPDataSet As AYZAN_GROUPDataSet
    Friend WithEvents ColorBindingSource As BindingSource
    Friend WithEvents ColorTableAdapter As AYZAN_GROUPDataSetTableAdapters.ColorTableAdapter
    Friend WithEvents TableAdapterManager As AYZAN_GROUPDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ColorBindingNavigator As BindingNavigator
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
    Friend WithEvents ColorBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ColorDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Color_idTextBox As TextBox
    Friend WithEvents Colore_nameTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
