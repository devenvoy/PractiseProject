Imports System.Data.SqlClient

Public Class frmProducts

    Dim conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim insert As String = "Insert into Products values(@pid,@pname,@pprice,@pqty,@pexp)"

        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand(insert, con)
                If validate() Then
                    con.Open()
                    cmd.Parameters.AddWithValue("@pid", txtpid.Text)
                    cmd.Parameters.AddWithValue("@pname", txtpname.Text)
                    cmd.Parameters.AddWithValue("@pprice", txtprice.Text)
                    cmd.Parameters.AddWithValue("@pqty", txtqty.Text)
                    cmd.Parameters.AddWithValue("@pexp", dtpexpiry.Value.Date)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("1 Record Inserted")
                    clearText()
                End If
            End Using
        End Using
    End Sub

    Private Sub clearText()
        txtpid.Clear()
        txtpname.Clear()
        txtprice.Clear()
        txtqty.Clear()
    End Sub

    Function validate() As Boolean
        If txtpid.Text = "" Then
            ErrorProvider1.SetError(txtpid, "Field Can't be Empty")
            Return False
        Else
            ErrorProvider1.SetError(txtpid, "")
        End If

        If txtpname.Text = "" Then
            ErrorProvider1.SetError(txtpname, "Enter Product name")
            Return False
        Else
            ErrorProvider1.SetError(txtpname, "")
        End If

        If txtprice.Text = "" Then
            ErrorProvider1.SetError(txtprice, "Enter Product Price")
            Return False
        Else
            ErrorProvider1.SetError(txtprice, "")
        End If

        If txtqty.Text = "" Then
            ErrorProvider1.SetError(txtqty, "Enter Product Quantity")
            Return False
        Else
            ErrorProvider1.SetError(txtqty, "")
        End If

        Dim d As Date = dtpexpiry.Value.Date
        If d < Date.Today Then
            ErrorProvider1.SetError(dtpexpiry, "Enter Valid Date")
            MsgBox("Expiry Date already Gone")
            Return False
        Else
            ErrorProvider1.SetError(dtpexpiry, "")
        End If
        Return True
    End Function

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim query As String = InputBox("Enter Product Name", "Search Product")
        Console.Write(query)
        If Not (query = "") Then
            Console.Write(query)
            Dim search = "Select * from Products where ProductName Like '%" & query & "%'"
            Using con = New SqlConnection(conString)
                Using cmd = New SqlCommand(search, con)
                    con.Open()
                    cmd.ExecuteNonQuery()
                    Using da As New SqlDataAdapter
                        da.SelectCommand = cmd
                        Using dt As New DataTable
                            da.Fill(dt)
                            If dt.Rows.Count > 0 Then
                                dgvTable.DataSource = dt
                            Else
                                MsgBox("No Data Found")
                            End If
                        End Using
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub btnremove_Click(sender As Object, e As EventArgs) Handles btnremove.Click
        Dim dt As Date = Date.Today.Date
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Delete from Products where ExpiryDate < @date", con)
                con.Open()
                cmd.Parameters.AddWithValue("@date", dt)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("DataBase Updated")
            End Using
        End Using
    End Sub

    Private Sub btnincrase_Click(sender As Object, e As EventArgs) Handles btnincrase.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Update Products set Price = Price * 1.05", con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("DataBase Updated")
            End Using
        End Using
    End Sub
End Class
