<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInsurance
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtagentname = New System.Windows.Forms.TextBox()
        Me.txtagentCity = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdagecode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddAge = New System.Windows.Forms.Button()
        Me.btnupdAge = New System.Windows.Forms.Button()
        Me.btnsearcgAge = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdpagecode = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtpno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpstart = New System.Windows.Forms.DateTimePicker()
        Me.dtpend = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtamt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnsearchp = New System.Windows.Forms.Button()
        Me.btnupdp = New System.Windows.Forms.Button()
        Me.btnAddp = New System.Windows.Forms.Button()
        Me.btnreport1 = New System.Windows.Forms.Button()
        Me.btnreport2 = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.dgvTable = New System.Windows.Forms.DataGridView()
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(980, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Agent Name"
        '
        'txtagentname
        '
        Me.txtagentname.Location = New System.Drawing.Point(1139, 95)
        Me.txtagentname.Name = "txtagentname"
        Me.txtagentname.Size = New System.Drawing.Size(176, 31)
        Me.txtagentname.TabIndex = 1
        '
        'txtagentCity
        '
        Me.txtagentCity.Location = New System.Drawing.Point(1139, 149)
        Me.txtagentCity.Name = "txtagentCity"
        Me.txtagentCity.Size = New System.Drawing.Size(176, 31)
        Me.txtagentCity.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(980, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "City"
        '
        'cmdagecode
        '
        Me.cmdagecode.Enabled = False
        Me.cmdagecode.FormattingEnabled = True
        Me.cmdagecode.Location = New System.Drawing.Point(1139, 34)
        Me.cmdagecode.Name = "cmdagecode"
        Me.cmdagecode.Size = New System.Drawing.Size(176, 33)
        Me.cmdagecode.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(980, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Agent Code"
        '
        'btnAddAge
        '
        Me.btnAddAge.Location = New System.Drawing.Point(1075, 231)
        Me.btnAddAge.Name = "btnAddAge"
        Me.btnAddAge.Size = New System.Drawing.Size(160, 42)
        Me.btnAddAge.TabIndex = 6
        Me.btnAddAge.Text = "Add Agent"
        Me.btnAddAge.UseVisualStyleBackColor = True
        '
        'btnupdAge
        '
        Me.btnupdAge.Location = New System.Drawing.Point(1075, 389)
        Me.btnupdAge.Name = "btnupdAge"
        Me.btnupdAge.Size = New System.Drawing.Size(160, 42)
        Me.btnupdAge.TabIndex = 7
        Me.btnupdAge.Text = "Update"
        Me.btnupdAge.UseVisualStyleBackColor = True
        '
        'btnsearcgAge
        '
        Me.btnsearcgAge.Location = New System.Drawing.Point(1075, 307)
        Me.btnsearcgAge.Name = "btnsearcgAge"
        Me.btnsearcgAge.Size = New System.Drawing.Size(160, 42)
        Me.btnsearcgAge.TabIndex = 8
        Me.btnsearcgAge.Text = "Search"
        Me.btnsearcgAge.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Agent Code"
        '
        'cmdpagecode
        '
        Me.cmdpagecode.FormattingEnabled = True
        Me.cmdpagecode.Location = New System.Drawing.Point(219, 87)
        Me.cmdpagecode.Name = "cmdpagecode"
        Me.cmdpagecode.Size = New System.Drawing.Size(176, 33)
        Me.cmdpagecode.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 25)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Start Date"
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(219, 148)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(176, 31)
        Me.txtcustname.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 154)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Customer Name"
        '
        'txtpno
        '
        Me.txtpno.Location = New System.Drawing.Point(219, 28)
        Me.txtpno.Name = "txtpno"
        Me.txtpno.Size = New System.Drawing.Size(176, 31)
        Me.txtpno.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Policy No"
        '
        'dtpstart
        '
        Me.dtpstart.Location = New System.Drawing.Point(219, 202)
        Me.dtpstart.Name = "dtpstart"
        Me.dtpstart.Size = New System.Drawing.Size(378, 31)
        Me.dtpstart.TabIndex = 17
        '
        'dtpend
        '
        Me.dtpend.Location = New System.Drawing.Point(219, 267)
        Me.dtpend.Name = "dtpend"
        Me.dtpend.Size = New System.Drawing.Size(378, 31)
        Me.dtpend.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 273)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "End Date"
        '
        'txtamt
        '
        Me.txtamt.Location = New System.Drawing.Point(219, 327)
        Me.txtamt.Name = "txtamt"
        Me.txtamt.Size = New System.Drawing.Size(176, 31)
        Me.txtamt.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 25)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Policy Amount"
        '
        'btnsearchp
        '
        Me.btnsearchp.Location = New System.Drawing.Point(637, 103)
        Me.btnsearchp.Name = "btnsearchp"
        Me.btnsearchp.Size = New System.Drawing.Size(160, 42)
        Me.btnsearchp.TabIndex = 24
        Me.btnsearchp.Text = "Search Policy"
        Me.btnsearchp.UseVisualStyleBackColor = True
        '
        'btnupdp
        '
        Me.btnupdp.Location = New System.Drawing.Point(637, 172)
        Me.btnupdp.Name = "btnupdp"
        Me.btnupdp.Size = New System.Drawing.Size(160, 42)
        Me.btnupdp.TabIndex = 23
        Me.btnupdp.Text = "Update"
        Me.btnupdp.UseVisualStyleBackColor = True
        '
        'btnAddp
        '
        Me.btnAddp.Location = New System.Drawing.Point(637, 34)
        Me.btnAddp.Name = "btnAddp"
        Me.btnAddp.Size = New System.Drawing.Size(160, 42)
        Me.btnAddp.TabIndex = 22
        Me.btnAddp.Text = "Add Policy"
        Me.btnAddp.UseVisualStyleBackColor = True
        '
        'btnreport1
        '
        Me.btnreport1.Location = New System.Drawing.Point(637, 315)
        Me.btnreport1.Name = "btnreport1"
        Me.btnreport1.Size = New System.Drawing.Size(160, 42)
        Me.btnreport1.TabIndex = 27
        Me.btnreport1.Text = "Report 1"
        Me.btnreport1.UseVisualStyleBackColor = True
        '
        'btnreport2
        '
        Me.btnreport2.Location = New System.Drawing.Point(637, 388)
        Me.btnreport2.Name = "btnreport2"
        Me.btnreport2.Size = New System.Drawing.Size(160, 42)
        Me.btnreport2.TabIndex = 26
        Me.btnreport2.Text = "Report 2"
        Me.btnreport2.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(637, 244)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(160, 42)
        Me.btnDel.TabIndex = 25
        Me.btnDel.Text = "Delete"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'dgvTable
        '
        Me.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTable.Location = New System.Drawing.Point(35, 448)
        Me.dgvTable.Name = "dgvTable"
        Me.dgvTable.RowHeadersWidth = 82
        Me.dgvTable.RowTemplate.Height = 33
        Me.dgvTable.Size = New System.Drawing.Size(762, 381)
        Me.dgvTable.TabIndex = 28
        '
        'frmInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1354, 866)
        Me.Controls.Add(Me.dgvTable)
        Me.Controls.Add(Me.btnreport1)
        Me.Controls.Add(Me.btnreport2)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.btnsearchp)
        Me.Controls.Add(Me.btnupdp)
        Me.Controls.Add(Me.btnAddp)
        Me.Controls.Add(Me.txtamt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dtpend)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dtpstart)
        Me.Controls.Add(Me.txtpno)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdpagecode)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnsearcgAge)
        Me.Controls.Add(Me.btnupdAge)
        Me.Controls.Add(Me.btnAddAge)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdagecode)
        Me.Controls.Add(Me.txtagentCity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtagentname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmInsurance"
        Me.Text = "Insurance Info"
        CType(Me.dgvTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtagentname As TextBox
    Friend WithEvents txtagentCity As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmdagecode As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddAge As Button
    Friend WithEvents btnupdAge As Button
    Friend WithEvents btnsearcgAge As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cmdpagecode As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtcustname As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtpno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dtpstart As DateTimePicker
    Friend WithEvents dtpend As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtamt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnsearchp As Button
    Friend WithEvents btnupdp As Button
    Friend WithEvents btnAddp As Button
    Friend WithEvents btnreport1 As Button
    Friend WithEvents btnreport2 As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents dgvTable As DataGridView
End Class
