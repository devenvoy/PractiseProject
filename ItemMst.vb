Imports System.Data.SqlClient

Public Class ItemMst
    Dim _
        conString As String =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"

    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Application.Exit()
    End Sub

    Sub clearText()
        txtid.Clear()
        txtname.Clear()
        txtrate.Clear()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If btnAdd.Text = "Add" Then
            btnAdd.Text = "Save"
            clearText()
        Else
            If Validate() Then
                Using con = New SqlConnection(conString)
                    Using cmd = New SqlCommand("Insert into ItemMst(Iname,Irate) values(@name,@rate)", con)
                        con.Open()
                        cmd.Parameters.AddWithValue("@name", txtname.Text)
                        cmd.Parameters.AddWithValue("@rate", txtrate.Text)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("1 record Inserted")
                    End Using
                End Using
                btnAdd.Text = "Add"
                loadData()
            End If
        End If
    End Sub

    Function Validate() As Boolean
        If txtname.Text = "" OrElse txtrate.Text = "" Then
            MsgBox("Enter Item Name And Rate", MsgBoxStyle.Critical, "Alert")
            Return False
        End If
        Return True
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        If btnsearch.Text = "Search" Then
            txtid.Enabled = True
            btnsearch.Text = "Fetch"
            clearText()
        Else
            Using con = New SqlConnection(conString)
                Using cmd = New SqlCommand("Select * from ItemMst where ItemNo = @itemno", con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@itemno", txtid.Text)
                    cmd.ExecuteNonQuery()
                    Using da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        Using dt As New DataTable
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                txtname.Text = dt.Rows(0)(1)
                                txtrate.Text = dt.Rows(0)(2)
                            End If
                        End Using
                    End Using
                    con.Close()
                End Using
            End Using
            btnsearch.Text = "Search"
            txtid.Enabled = False
        End If
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        If btndelete.Text = "Delete" Then
            txtid.Enabled = True
            btndelete.Text = "Save"
            clearText()
        Else
            Using con = New SqlConnection(conString)
                Using cmd = New SqlCommand("Delete from ItemMst where ItemNo = @itemno", con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@itemno", txtid.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Record Deleted")
                End Using
            End Using
            btndelete.Text = "Delete"
            clearText()
            txtid.Enabled = False
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If btnupdate.Text = "Update" Then
            txtid.Enabled = True
            btnupdate.Text = "Save"
            clearText()
        Else
            Using con = New SqlConnection(conString)
                Using cmd = New SqlCommand("Update ItemMst set Iname = @name,Irate = @rate where ItemNo = @itemno", con)
                    con.Open()
                    cmd.Parameters.AddWithValue("@name", txtname.Text)
                    cmd.Parameters.AddWithValue("@rate", txtrate.Text)
                    cmd.Parameters.AddWithValue("@itemno", txtid.Text)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("record Updated")
                End Using
            End Using
            btnupdate.Text = "Update"
            txtid.Enabled = False
            loadData()
        End If
    End Sub

    Private Sub ItemMst_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub loadData()
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Select * from ItemMst", con)
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