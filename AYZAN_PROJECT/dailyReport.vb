
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration
Public Class dailyReport
    Private Sub dailyReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker2.CustomFormat = "yyyy-MM-dd"


    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection("Server=YORGO; Database = AYZAN_GROUP; Integrated Security = True")
        Dim query As String = "select r_date as 'Rental date',client_name as 'Client name',brand_name as 'Car brand',model_name as 'Model'
  from rental as r,client as c,brand as b,model as m, car as ca
  where r.client_id = c.client_id
and r.car_id = ca.car_id
  and  ca.brand_id = b.brand_id
  and ca.model_id = m.model_id	
  and r_date = '" & DateTimePicker2.Value & "'"
        Dim cmd As New SqlCommand(query, con)


        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable
        Try
            adapter.Fill(table)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        DataGridView1.DataSource = table
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class