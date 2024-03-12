<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducts
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
        Me.components = New System.ComponentModel.Container()
        Me.txtpid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpname = New System.Windows.Forms.TextBox()
        Me.btnincrase = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.btnremove = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpexpiry = New System.Windows.Forms.DateTimePicker()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtpid
        '
        Me.txtpid.Location = New System.Drawing.Point(99, 5)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.Size = New System.Drawing.Size(135, 20)
        Me.txtpid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ProductId"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(265, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(265, 48)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(75, 23)
        Me.btnsearch.TabIndex = 14
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "ProductName"
        '
        'txtpname
        '
        Me.txtpname.Location = New System.Drawing.Point(99, 48)
        Me.txtpname.Name = "txtpname"
        Me.txtpname.Size = New System.Drawing.Size(135, 20)
        Me.txtpname.TabIndex = 12
        '
        'btnincrase
        '
        Me.btnincrase.Location = New System.Drawing.Point(265, 135)
        Me.btnincrase.Name = "btnincrase"
        Me.btnincrase.Size = New System.Drawing.Size(75, 23)
        Me.btnincrase.TabIndex = 20
        Me.btnincrase.Text = "Increase"
        Me.btnincrase.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Quantity"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(99, 135)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(135, 20)
        Me.txtqty.TabIndex = 18
        '
        'btnremove
        '
        Me.btnremove.Location = New System.Drawing.Point(265, 92)
        Me.btnremove.Name = "btnremove"
        Me.btnremove.Size = New System.Drawing.Size(75, 23)
        Me.btnremove.TabIndex = 17
        Me.btnremove.Text = "Remove Expire"
        Me.btnremove.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Product Price"
        '
        'txtprice
        '
        Me.txtprice.Location = New System.Drawing.Point(99, 92)
        Me.txtprice.Name = "txtprice"
        Me.txtprice.Size = New System.Drawing.Size(135, 20)
        Me.txtprice.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 178)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Expiry Date"
        '
        'dtpexpiry
        '
        Me.dtpexpiry.Location = New System.Drawing.Point(99, 172)
        Me.dtpexpiry.Name = "dtpexpiry"
        Me.dtpexpiry.Size = New System.Drawing.Size(241, 20)
        Me.dtpexpiry.TabIndex = 22
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(12, 212)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(328, 180)
        Me.dgvTable.TabIndex = 23
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 419)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.dtpexpiry)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnincrase)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.btnremove)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprice)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpname)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtpid)
        Me.Name = "frmProducts"
        Me.Text = "Products"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtpid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpname As TextBox
    Friend WithEvents btnincrase As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents btnremove As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtprice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpexpiry As DateTimePicker
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
