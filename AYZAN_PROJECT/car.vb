Public Class car
    Private Sub CarBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CarBindingNavigatorSaveItem.Click, CarBindingNavigatorSaveItem.Click, CarBindingNavigatorSaveItem.Click, CarBindingNavigatorSaveItem.Click, CarBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CarBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Color)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Style' table. You can move, or remove it, as needed.
        Me.StyleTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Style)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Brand' table. You can move, or remove it, as needed.
        Me.BrandTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Brand)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Model' table. You can move, or remove it, as needed.
        Me.ModelTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Model)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Car)

    End Sub

    Private Sub ColorDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ColorDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class