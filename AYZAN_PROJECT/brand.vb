Public Class brand
    Private Sub BrandBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BrandBindingNavigatorSaveItem.Click, BrandBindingNavigatorSaveItem.Click, BrandBindingNavigatorSaveItem.Click, BrandBindingNavigatorSaveItem.Click, BrandBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BrandBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub brand_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Brand)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class