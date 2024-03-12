Imports System.Data.SqlClient

Public Class frmInsurance

    Dim constring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\dev\BCA\Sy BCA SEM-4\406 PRACTICAL\404\PractiseProject\PractiseDB.mdf;Integrated Security=True"
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim agentcodes As New List(Of Integer)

    Sub updateData()
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Select * From Agent_Master", con)
                con.Open()
                cmd.ExecuteNonQuery()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        For Each row As DataRow In dt.Rows
                            agentcodes.Add(row(0))
                        Next
                    End Using
                End Using
                con.Close()
            End Using
        End Using
        cmdpagecode.DataSource = New List(Of Integer)(agentcodes)
        cmdagecode.DataSource = New List(Of Integer)(agentcodes)
        cmdagecode.Enabled = True
    End Sub

    Private Sub btnAddAge_Click(sender As Object, e As EventArgs) Handles btnAddAge.Click
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Insert into Agent_Master(Agent_name,City) values(@name,@city)", con)
                con.Open()
                cmd.Parameters.AddWithValue("@name", txtagentname.Text)
                cmd.Parameters.AddWithValue("@city", txtagentCity.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("1 Agent Added")
            End Using
        End Using
        updateData()
        cmdagecode.Enabled = True
    End Sub

    Private Sub btnsearcgAge_Click(sender As Object, e As EventArgs) Handles btnsearcgAge.Click

        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Select * from Agent_Master Where Agent_code = @id", con)
                con.Open()
                cmd.Parameters.AddWithValue("@id", cmdagecode.Text)
                cmd.ExecuteNonQuery()
                Using da As New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then
                            txtagentname.Text = dt.Rows(0)(1)
                            txtagentCity.Text = dt.Rows(0)(2)
                        Else
                            MsgBox("No Agent Found")
                        End If
                    End Using
                End Using
                con.Close()
            End Using
        End Using

    End Sub

    Private Sub btnupdAge_Click(sender As Object, e As EventArgs) Handles btnupdAge.Click

        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Update Agent_Master set Agent_name=@name , City =@city where Agent_code= @id", con)
                con.Open()
                cmd.Parameters.AddWithValue("@name", txtagentname.Text)
                cmd.Parameters.AddWithValue("@city", txtagentCity.Text)
                cmd.Parameters.AddWithValue("@id", cmdagecode.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Updated")
            End Using
        End Using
        updateData()
    End Sub

    Private Sub frmInsurance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateData()
        For Each i As Integer In agentcodes
            Console.WriteLine(i)
        Next
    End Sub

    Private Sub btnAddp_Click(sender As Object, e As EventArgs) Handles btnAddp.Click
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Insert into Policy_Master(Agent_code,Customer_name,start_date,end_date,policy_amt)" &
                            "values(@aco,@cname,@sdate,@edate,@pamt)", con)
                con.Open()
                cmd.Parameters.AddWithValue("@aco", cmdpagecode.Text)
                cmd.Parameters.AddWithValue("@cname", txtcustname.Text)
                cmd.Parameters.AddWithValue("@sdate", dtpstart.Value.Date)
                cmd.Parameters.AddWithValue("@edate", dtpend.Value.Date)
                cmd.Parameters.AddWithValue("@pamt", txtamt.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("1 Record Inserted")
            End Using
        End Using
    End Sub

    Private Sub btnupdp_Click(sender As Object, e As EventArgs) Handles btnupdp.Click
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand  '(, con)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End Using
        End Using
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Delete From Policy_Master Where Policy_no=@pno", con)
                con.Open()
                cmd.Parameters.AddWithValue("@pno", cmdpagecode.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Deleted")
            End Using
        End Using
    End Sub

    Private Sub btnreport1_Click(sender As Object, e As EventArgs) Handles btnreport1.Click

        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand("Select Policy_no,Agent_code,Customer_name from Policy_Master Order by policy_amt", con)
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

    Private Sub btnreport2_Click(sender As Object, e As EventArgs) Handles btnreport2.Click

        Dim sqry As String = "Select am.Agent_name as AgentName,pm.Customer_name as CustomerName,SUM(pm.policy_amt) as TotalAmount " &
                             "From Agent_Master am Join Policy_Master pm " &
                             "ON am.Agent_code = pm.Agent_code " &
                             "Group by am.Agent_name , pm.Customer_name"
        Using con = New SqlConnection(constring)
            Using cmd = New SqlCommand(sqry, con)
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



'Using con = New SqlConnection(constring)
'Using cmd = New SqlCommand(, con)
'con.Open()
'cmd.ExecuteNonQuery()
'con.Close()
'End Using
'End Using
