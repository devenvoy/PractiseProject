Imports System.Data.SqlClient

Public Class GroceryInfo


    Dim conString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Insert into GroceryMaster(ItemName,mrp,SellPrice,Qty) values(@name,@mrp,@sell,@qty)", con)
                con.Open()
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@mrp", txtmrp.Text)
                cmd.Parameters.AddWithValue("@sell", txtsell.Text)
                cmd.Parameters.AddWithValue("@qty", txtqty.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("1 Record Inserted")
            End Using
        End Using
    End Sub

    Private Sub btnupd_Click(sender As Object, e As EventArgs) Handles btnupd.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Update GroceryMaster set ItemName = @name,mrp = @mrp,SellPrice=@sell,Qty=@qty where Itemno = @id", con)
                con.Open()
                Dim id As Integer = Integer.Parse(takeInput("Enter Id For Update Data", "Request Id"))
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@name", txtname.Text)
                cmd.Parameters.AddWithValue("@mrp", txtmrp.Text)
                cmd.Parameters.AddWithValue("@sell", txtsell.Text)
                cmd.Parameters.AddWithValue("@qty", txtqty.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Updated")
            End Using
        End Using
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Using con = New SqlConnection(conString)
            Using cmd = New SqlCommand("Delete From GroceryMaster Where ItemNo = @id", con)
                con.Open()
                Dim id As Integer = Integer.Parse(takeInput("Enter Id For Update Data", "Request Id"))
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Deleted")
            End Using
        End Using
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        Dim str As String = takeInput("Enter Item Name To Get Result", "Search")
        Dim qry As String = "Select * from GroceryMaster Where ItemName Like '%" & str & "%'"
        Dim obj As New frmResult
        obj.rQry = qry
        obj.Show()
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        Dim qry As String = "Select * from GroceryMaster Where Qty <= 0"
        Dim obj As New frmResult
        obj.rQry = qry
        obj.Show()
    End Sub

    Function takeInput(ByVal msg As String, ByVal title As String) As String
        Dim str = InputBox(msg, title)
        If Not (str = "") Then
            Return str
        Else
            MsgBox("No Data Found")
        End If
        Return ""
    End Function

End Class