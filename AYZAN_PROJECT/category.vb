Public Class category
    Private Sub CategoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CategoryBindingNavigatorSaveItem.Click, CategoryBindingNavigatorSaveItem.Click, CategoryBindingNavigatorSaveItem.Click, CategoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CategoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Category' table. You can move, or remove it, as needed.
        Me.CategoryTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Category)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class