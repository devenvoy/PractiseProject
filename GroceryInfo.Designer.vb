<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GroceryInfo
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
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtmrp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsell = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnupd = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btnreport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Item Name"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(211, 23)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(261, 31)
        Me.txtname.TabIndex = 1
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(26, 265)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(109, 42)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Insert"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtmrp
        '
        Me.txtmrp.Location = New System.Drawing.Point(211, 75)
        Me.txtmrp.Name = "txtmrp"
        Me.txtmrp.Size = New System.Drawing.Size(261, 31)
        Me.txtmrp.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mrp"
        '
        'txtsell
        '
        Me.txtsell.Location = New System.Drawing.Point(211, 138)
        Me.txtsell.Name = "txtsell"
        Me.txtsell.Size = New System.Drawing.Size(261, 31)
        Me.txtsell.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Sell Price"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(211, 196)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(261, 31)
        Me.txtqty.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Quantity"
        '
        'btnupd
        '
        Me.btnupd.Location = New System.Drawing.Point(170, 265)
        Me.btnupd.Name = "btnupd"
        Me.btnupd.Size = New System.Drawing.Size(109, 42)
        Me.btnupd.TabIndex = 9
        Me.btnupd.Text = "Update"
        Me.btnupd.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Location = New System.Drawing.Point(324, 265)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(109, 42)
        Me.btndel.TabIndex = 10
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Location = New System.Drawing.Point(101, 340)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(109, 42)
        Me.btnsearch.TabIndex = 11
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnreport
        '
        Me.btnreport.Location = New System.Drawing.Point(257, 340)
        Me.btnreport.Name = "btnreport"
        Me.btnreport.Size = New System.Drawing.Size(109, 42)
        Me.btnreport.TabIndex = 12
        Me.btnreport.Text = "Report 2"
        Me.btnreport.UseVisualStyleBackColor = True
        '
        'GroceryInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 427)
        Me.Controls.Add(Me.btnreport)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupd)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsell)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtmrp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label1)
        Me.Name = "GroceryInfo"
        Me.Text = "GroceryInfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtname As TextBox
    Friend WithEvents btnadd As Button
    Friend WithEvents txtmrp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsell As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtqty As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnupd As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnsearch As Button
    Friend WithEvents btnreport As Button
End Class
