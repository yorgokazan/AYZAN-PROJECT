Public Class main
    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub RENTALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RENTALToolStripMenuItem.Click
        rental.Show()

    End Sub

    Private Sub CLIENTSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CLIENTSToolStripMenuItem.Click
        client.Show()

    End Sub

    Private Sub CARSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CARSToolStripMenuItem.Click
        car.Show()
    End Sub

    Private Sub STYLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STYLEToolStripMenuItem.Click
        style.Show()
    End Sub

    Private Sub CATEGORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CATEGORYToolStripMenuItem.Click
        category.Show()
    End Sub

    Private Sub MODELToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODELToolStripMenuItem.Click
        model.Show()
    End Sub

    Private Sub COLORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORToolStripMenuItem.Click
        color.Show()
    End Sub

    Private Sub BRANDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BRANDToolStripMenuItem.Click
        brand.Show()

    End Sub
End Class