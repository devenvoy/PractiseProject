<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnincrase = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtedesig = New System.Windows.Forms.TextBox()
        Me.btnDisp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtedept = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtename = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txteid = New System.Windows.Forms.TextBox()
        Me.txtsalary = New System.Windows.Forms.TextBox()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(16, 213)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(328, 180)
        Me.dgvTable.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Salary"
        '
        'btnincrase
        '
        Me.btnincrase.Location = New System.Drawing.Point(269, 136)
        Me.btnincrase.Name = "btnincrase"
        Me.btnincrase.Size = New System.Drawing.Size(75, 23)
        Me.btnincrase.TabIndex = 35
        Me.btnincrase.Text = "Increase"
        Me.btnincrase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Designation"
        '
        'txtedesig
        '
        Me.txtedesig.Location = New System.Drawing.Point(103, 136)
        Me.txtedesig.Name = "txtedesig"
        Me.txtedesig.Size = New System.Drawing.Size(135, 20)
        Me.txtedesig.TabIndex = 33
        '
        'btnDisp
        '
        Me.btnDisp.Location = New System.Drawing.Point(269, 93)
        Me.btnDisp.Name = "btnDisp"
        Me.btnDisp.Size = New System.Drawing.Size(75, 23)
        Me.btnDisp.TabIndex = 32
        Me.btnDisp.Text = "Display"
        Me.btnDisp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Department"
        '
        'txtedept
        '
        Me.txtedept.Location = New System.Drawing.Point(103, 93)
        Me.txtedept.Name = "txtedept"
        Me.txtedept.Size = New System.Drawing.Size(135, 20)
        Me.txtedept.TabIndex = 30
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(269, 49)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 29
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Employee Name"
        '
        'txtename
        '
        Me.txtename.Location = New System.Drawing.Point(103, 49)
        Me.txtename.Name = "txtename"
        Me.txtename.Size = New System.Drawing.Size(135, 20)
        Me.txtename.TabIndex = 27
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(269, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Employee Id"
        '
        'txteid
        '
        Me.txteid.Location = New System.Drawing.Point(103, 6)
        Me.txteid.Name = "txteid"
        Me.txteid.Size = New System.Drawing.Size(135, 20)
        Me.txteid.TabIndex = 24
        '
        'txtsalary
        '
        Me.txtsalary.Location = New System.Drawing.Point(103, 179)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.Size = New System.Drawing.Size(135, 20)
        Me.txtsalary.TabIndex = 39
        '
        'frmEmp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 418)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnincrase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtedesig)
        Me.Controls.Add(Me.btnDisp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtedept)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtename)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txteid)
        Me.Name = "frmEmp"
        Me.Text = "EmployeData"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents btnincrase As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtedesig As TextBox
    Friend WithEvents btnDisp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtedept As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtename As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txteid As TextBox
    Friend WithEvents txtsalary As TextBox
End Class
