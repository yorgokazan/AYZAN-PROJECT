Public Class rental
    Private Sub RentalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RentalBindingNavigatorSaveItem.Click, RentalBindingNavigatorSaveItem.Click, RentalBindingNavigatorSaveItem.Click, RentalBindingNavigatorSaveItem.Click, RentalBindingNavigatorSaveItem.Click, RentalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RentalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub rental_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Car' table. You can move, or remove it, as needed.
        Me.CarTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Car)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Client)
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Rental' table. You can move, or remove it, as needed.
        Me.RentalTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Rental)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class