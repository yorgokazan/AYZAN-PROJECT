Public Class model
    Private Sub ModelBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ModelBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ModelBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Category)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Model' table. You can move, or remove it, as needed.
        Me.ModelTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Model)

    End Sub

    Private Sub CategoryDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CategoryDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
