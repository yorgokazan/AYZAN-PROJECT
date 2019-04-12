Public Class client
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientBindingNavigatorSaveItem.Click, ClientBindingNavigatorSaveItem.Click, ClientBindingNavigatorSaveItem.Click, ClientBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AYZAN_GROUPDataSet)

    End Sub

    Private Sub client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AYZAN_GROUPDataSet.Client' table. You can move, or remove it, as needed.
        Me.ClientTableAdapter.Fill(Me.AYZAN_GROUPDataSet.Client)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class