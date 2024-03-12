Imports System.Data.SqlClient

Public Class frmEmp
    Dim _
        conString As String =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"

    Dim con As SqlConnection
    Dim cmd As SqlCommand


    Private Sub btnDisp_Click(sender As Object, e As EventArgs) Handles btnDisp.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select Dept, count(Eid) as EmplyeeCount from Employee Group by Dept ", con)
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

    Private Sub btnincrase_Click(sender As Object, e As EventArgs) Handles btnincrase.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Update Employee set Salary = Salary * 1.1", con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Database Updated")
            End Using
        End Using
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If btnsearch.Text = "Search" Then
            txteid.Enabled = False
            txtename.Enabled = False
            txtsalary.Enabled = False
            btnsearch.Text = "Fetch"
        Else
            txteid.Enabled = True
            txtename.Enabled = True
            txtsalary.Enabled = True
            btnsearch.Text = "Search"
            Using con = New SqlConnection(conString)
                Using cmd = New SqlCommand("Select * from Employee where Dept = @dept and Designation = @desg", con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@dept", txtedept.Text)
                    cmd.Parameters.AddWithValue("@desg", txtedesig.Text)
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
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Insert into Employee values(@eid,@ename,@edept,@edesg,@esal)", con)
                con.Open()
                cmd.Parameters.AddWithValue("@eid", txteid.Text)
                cmd.Parameters.AddWithValue("@ename", txtename.Text)
                cmd.Parameters.AddWithValue("@edept", txtedept.Text)
                cmd.Parameters.AddWithValue("@edesg", txtedesig.Text)
                cmd.Parameters.AddWithValue("@esal", txtsalary.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("1 Record Inserted")
            End Using
        End Using
    End Sub
End Class