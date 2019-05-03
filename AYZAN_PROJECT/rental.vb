Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
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

        Dim con As New SqlConnection("Server=YORGO; Database = AYZAN_GROUP; Integrated Security= true")

        Dim query As String = "Select car_id, chassis_num, model_name, brand_name, style_name, colore_name from Car,model,brand,style,color
where  model.model_id = car.model_id
and brand.brand_id= car.brand_id
and style.style_id = car.style_id
and color.color_id = car.color_id"

        Dim cmd As New SqlCommand(query, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.DataSource = table


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class