<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salesvb
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
        Me.cmbDboyname = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpOdate = New System.Windows.Forms.DateTimePicker()
        Me.dtpDdate = New System.Windows.Forms.DateTimePicker()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.txtOno = New System.Windows.Forms.TextBox()
        Me.txtCname = New System.Windows.Forms.TextBox()
        Me.txtstatus = New System.Windows.Forms.TextBox()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.btnseach = New System.Windows.Forms.Button()
        Me.btndesc = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnasc = New System.Windows.Forms.Button()
        Me.btnUpd = New System.Windows.Forms.Button()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbDboyname
        '
        Me.cmbDboyname.FormattingEnabled = True
        Me.cmbDboyname.Items.AddRange(New Object() {"boy1", "boy2", "boy3", "boy4", "boy5"})
        Me.cmbDboyname.Location = New System.Drawing.Point(169, 181)
        Me.cmbDboyname.Name = "cmbDboyname"
        Me.cmbDboyname.Size = New System.Drawing.Size(121, 21)
        Me.cmbDboyname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Order Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Client Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Delivery Add."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 189)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Delivery Boy Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Deliver Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Order Status"
        '
        'dtpOdate
        '
        Me.dtpOdate.Location = New System.Drawing.Point(169, 216)
        Me.dtpOdate.Name = "dtpOdate"
        Me.dtpOdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpOdate.TabIndex = 8
        '
        'dtpDdate
        '
        Me.dtpDdate.Location = New System.Drawing.Point(169, 94)
        Me.dtpDdate.Name = "dtpDdate"
        Me.dtpDdate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDdate.TabIndex = 9
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(169, 123)
        Me.txtAdd.Multiline = True
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(200, 41)
        Me.txtAdd.TabIndex = 10
        '
        'txtOno
        '
        Me.txtOno.Location = New System.Drawing.Point(169, 21)
        Me.txtOno.Name = "txtOno"
        Me.txtOno.Size = New System.Drawing.Size(200, 20)
        Me.txtOno.TabIndex = 11
        '
        'txtCname
        '
        Me.txtCname.Location = New System.Drawing.Point(169, 52)
        Me.txtCname.Name = "txtCname"
        Me.txtCname.Size = New System.Drawing.Size(200, 20)
        Me.txtCname.TabIndex = 12
        '
        'txtstatus
        '
        Me.txtstatus.Location = New System.Drawing.Point(169, 254)
        Me.txtstatus.Name = "txtstatus"
        Me.txtstatus.Size = New System.Drawing.Size(200, 20)
        Me.txtstatus.TabIndex = 13
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(394, 24)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.Size = New System.Drawing.Size(394, 378)
        Me.dgvTable.TabIndex = 14
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(26, 326)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 15
        Me.btnInsert.Text = "Insert"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'btnseach
        '
        Me.btnseach.Location = New System.Drawing.Point(26, 369)
        Me.btnseach.Name = "btnseach"
        Me.btnseach.Size = New System.Drawing.Size(75, 23)
        Me.btnseach.TabIndex = 16
        Me.btnseach.Text = "Search"
        Me.btnseach.UseVisualStyleBackColor = True
        '
        'btndesc
        '
        Me.btndesc.Location = New System.Drawing.Point(263, 369)
        Me.btndesc.Name = "btndesc"
        Me.btndesc.Size = New System.Drawing.Size(75, 23)
        Me.btndesc.TabIndex = 18
        Me.btndesc.Text = "Descending"
        Me.btndesc.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(263, 326)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(75, 23)
        Me.btnDel.TabIndex = 17
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnasc
        '
        Me.btnasc.Location = New System.Drawing.Point(143, 369)
        Me.btnasc.Name = "btnasc"
        Me.btnasc.Size = New System.Drawing.Size(75, 23)
        Me.btnasc.TabIndex = 20
        Me.btnasc.Text = "Ascending"
        Me.btnasc.UseVisualStyleBackColor = True
        '
        'btnUpd
        '
        Me.btnUpd.Location = New System.Drawing.Point(143, 326)
        Me.btnUpd.Name = "btnUpd"
        Me.btnUpd.Size = New System.Drawing.Size(75, 23)
        Me.btnUpd.TabIndex = 19
        Me.btnUpd.Text = "Update"
        Me.btnUpd.UseVisualStyleBackColor = True
        '
        'Salesvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnasc)
        Me.Controls.Add(Me.btnUpd)
        Me.Controls.Add(Me.btndesc)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnseach)
        Me.Controls.Add(Me.btnInsert)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.txtstatus)
        Me.Controls.Add(Me.txtCname)
        Me.Controls.Add(Me.txtOno)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.dtpDdate)
        Me.Controls.Add(Me.dtpOdate)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDboyname)
        Me.Name = "Salesvb"
        Me.Text = "Salesvb"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbDboyname As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpOdate As DateTimePicker
    Friend WithEvents dtpDdate As DateTimePicker
    Friend WithEvents txtAdd As TextBox
    Friend WithEvents txtOno As TextBox
    Friend WithEvents txtCname As TextBox
    Friend WithEvents txtstatus As TextBox
    Friend WithEvents dgvTable As DataGridView
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnseach As Button
    Friend WithEvents btndesc As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnasc As Button
    Friend WithEvents btnUpd As Button
End Class
