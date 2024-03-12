Imports System.Data.SqlClient

Public Class Salesvb
    Dim _
        conString As String =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Using con = New SqlConnection(conString)
            Using _
                cmd =
                    New SqlCommand("Insert into SalesOrder values(@ono,@odate,@cname,@add,@boyname,@ddate,@status)", con)
                con.Open()
                cmd.Parameters.AddWithValue("@ono", txtOno.Text)
                cmd.Parameters.AddWithValue("@odate", dtpOdate.Value.Date)
                cmd.Parameters.AddWithValue("@cname", txtCname.Text)
                cmd.Parameters.AddWithValue("@add", txtAdd.Text)
                cmd.Parameters.AddWithValue("@boyname", cmbDboyname.Text)
                cmd.Parameters.AddWithValue("@ddate", dtpDdate.Value.Date)
                cmd.Parameters.AddWithValue("@status", txtstatus.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("1 Record Inserted")
            End Using
        End Using
        loadData()
        clearText()
    End Sub

    Private Sub clearText()
        txtOno.Clear()
        txtAdd.Clear()
        txtCname.Clear()
        txtstatus.Clear()
        cmbDboyname.SelectedIndex = 0
        dtpDdate.Value = Date.Today
        dtpOdate.Value = Date.Today
    End Sub

    Private Sub btnUpd_Click(sender As Object, e As EventArgs) Handles btnUpd.Click
        Using con = New SqlConnection(conString)
            Using _
                cmd =
                    New SqlCommand(
                        "Update SalesOrder set OrderDate=@odate , ClientName=@cname,DAdd=@add,D_bo_name=@dboyname,D_Data=@ddate,order_status=@status where OrderNo=@ono",
                        con)
                con.Open()
                cmd.Parameters.AddWithValue("@ono", txtOno.Text)
                cmd.Parameters.AddWithValue("@odate", dtpOdate.Value.Date)
                cmd.Parameters.AddWithValue("@cname", txtCname.Text)
                cmd.Parameters.AddWithValue("@add", txtAdd.Text)
                cmd.Parameters.AddWithValue("@dboyname", cmbDboyname.Text)
                cmd.Parameters.AddWithValue("@ddate", dtpDdate.Value.Date)
                cmd.Parameters.AddWithValue("@status", txtstatus.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Updated")
            End Using
        End Using
        loadData()
        clearText()
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Delete From SalesOrder Where OrderNo =@ono", con)
                con.Open()
                cmd.Parameters.AddWithValue("@ono", txtOno.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Deleted")
            End Using
        End Using
    End Sub

    Private Sub btnseach_Click(sender As Object, e As EventArgs) Handles btnseach.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select * from SalesOrder Where D_boy_name = @dboyname", con)
                con.Open()
                cmd.Parameters.AddWithValue("@dboyname", cmbDboyname.Text)
                cmd.ExecuteNonQuery()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        dgvTable.DataSource = dt
                    End Using
                End Using
                con.Close()
            End Using
        End Using
    End Sub

    Private Sub btnasc_Click(sender As Object, e As EventArgs) Handles btnasc.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select * From SalesOrder Order by ClientName Asc", con)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        dgvTable.DataSource = dt
                    End Using
                End Using
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Private Sub btndesc_Click(sender As Object, e As EventArgs) Handles btndesc.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select * From SalesOrder Order by ClientName Desc", con)
                con.Open()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        dgvTable.DataSource = dt
                    End Using
                End Using
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Private Sub Salesvb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select * from SalesOrder", con)
                con.Open()
                cmd.ExecuteNonQuery()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        dgvTable.DataSource = dt
                    End Using
                End Using
                con.Close()
            End Using
        End Using
    End Sub
End Class