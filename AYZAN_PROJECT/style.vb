Public Class style
    Private Sub StyleBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StyleBindingNavigatorSaveItem.Click, StyleBindingNavigatorSaveItem.Click, StyleBindingNavigatorSaveItem.Click, StyleBindingNavigatorSaveItem.Click, StyleBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StyleBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub style_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Style' table. You can move, or remove it, as needed.
        Me.StyleTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Style)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class