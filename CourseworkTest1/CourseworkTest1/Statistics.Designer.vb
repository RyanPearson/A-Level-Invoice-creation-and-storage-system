<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStatistics
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStatistics))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAvgIT = New System.Windows.Forms.TextBox()
        Me.txtAvgLC = New System.Windows.Forms.TextBox()
        Me.txtMostPU = New System.Windows.Forms.TextBox()
        Me.txtMostCC = New System.Windows.Forms.TextBox()
        Me.dgvHidden = New System.Windows.Forms.DataGridView()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvHidden2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalInvs = New System.Windows.Forms.TextBox()
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvHidden2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 29)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Statistics"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AC Motors"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Average invoice total this month:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Average labour cost this month:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Most common part used:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Most common car make:"
        '
        'txtAvgIT
        '
        Me.txtAvgIT.Location = New System.Drawing.Point(287, 140)
        Me.txtAvgIT.Name = "txtAvgIT"
        Me.txtAvgIT.ReadOnly = True
        Me.txtAvgIT.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgIT.TabIndex = 10
        '
        'txtAvgLC
        '
        Me.txtAvgLC.Location = New System.Drawing.Point(287, 167)
        Me.txtAvgLC.Name = "txtAvgLC"
        Me.txtAvgLC.ReadOnly = True
        Me.txtAvgLC.Size = New System.Drawing.Size(100, 20)
        Me.txtAvgLC.TabIndex = 11
        '
        'txtMostPU
        '
        Me.txtMostPU.Location = New System.Drawing.Point(287, 193)
        Me.txtMostPU.Name = "txtMostPU"
        Me.txtMostPU.ReadOnly = True
        Me.txtMostPU.Size = New System.Drawing.Size(100, 20)
        Me.txtMostPU.TabIndex = 12
        '
        'txtMostCC
        '
        Me.txtMostCC.Location = New System.Drawing.Point(287, 221)
        Me.txtMostCC.Name = "txtMostCC"
        Me.txtMostCC.ReadOnly = True
        Me.txtMostCC.Size = New System.Drawing.Size(100, 20)
        Me.txtMostCC.TabIndex = 13
        '
        'dgvHidden
        '
        Me.dgvHidden.AllowUserToAddRows = False
        Me.dgvHidden.AllowUserToDeleteRows = False
        Me.dgvHidden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHidden.Location = New System.Drawing.Point(93, 249)
        Me.dgvHidden.Name = "dgvHidden"
        Me.dgvHidden.ReadOnly = True
        Me.dgvHidden.Size = New System.Drawing.Size(97, 23)
        Me.dgvHidden.TabIndex = 14
        Me.dgvHidden.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(312, 249)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 15
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 249)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvHidden2
        '
        Me.dgvHidden2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHidden2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvHidden2.Location = New System.Drawing.Point(196, 249)
        Me.dgvHidden2.Name = "dgvHidden2"
        Me.dgvHidden2.Size = New System.Drawing.Size(85, 23)
        Me.dgvHidden2.TabIndex = 17
        Me.dgvHidden2.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Total income this month:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(262, 20)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Total number of invoices this month:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(287, 114)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 20
        '
        'txtTotalInvs
        '
        Me.txtTotalInvs.Location = New System.Drawing.Point(287, 88)
        Me.txtTotalInvs.Name = "txtTotalInvs"
        Me.txtTotalInvs.ReadOnly = True
        Me.txtTotalInvs.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalInvs.TabIndex = 21
        '
        'frmStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 284)
        Me.Controls.Add(Me.txtTotalInvs)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvHidden2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.dgvHidden)
        Me.Controls.Add(Me.txtMostCC)
        Me.Controls.Add(Me.txtMostPU)
        Me.Controls.Add(Me.txtAvgLC)
        Me.Controls.Add(Me.txtAvgIT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics"
        CType(Me.dgvHidden, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvHidden2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAvgIT As System.Windows.Forms.TextBox
    Friend WithEvents txtAvgLC As System.Windows.Forms.TextBox
    Friend WithEvents txtMostPU As System.Windows.Forms.TextBox
    Friend WithEvents txtMostCC As System.Windows.Forms.TextBox
    Friend WithEvents dgvHidden As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvHidden2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalInvs As System.Windows.Forms.TextBox
End Class
