Public Class color
    Private Sub ColorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ColorBindingNavigatorSaveItem.Click, ColorBindingNavigatorSaveItem.Click, ColorBindingNavigatorSaveItem.Click, ColorBindingNavigatorSaveItem.Click, ColorBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ColorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub color_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Color' table. You can move, or remove it, as needed.
        Me.ColorTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Color)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class