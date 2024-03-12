Imports System.Data.SqlClient
Public Class frmResult

    Public Property rQry As String

    Private Sub GResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size = Me.Size()
        DataGridView1.Width = size.Width
        DataGridView1.Height = size.Height
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" & "F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;" & "Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand(rQry, con)
                con.Open()
                cmd.ExecuteNonQuery()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
                con.Close()
            End Using
        End Using

    End Sub

    Private Sub frmResult_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Dim size = Me.Size()
        DataGridView1.Width = size.Width
        DataGridView1.Height = size.Height
    End Sub
End Class