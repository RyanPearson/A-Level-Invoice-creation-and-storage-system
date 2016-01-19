<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddParts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddParts))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvAddParts = New System.Windows.Forms.DataGridView()
        Me.Part = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Additional_Info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAddParts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Parts Used"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(390, 363)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(91, 32)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 363)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(91, 32)
        Me.btnBack.TabIndex = 44
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvAddParts
        '
        Me.dgvAddParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAddParts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Part, Me.Quantity, Me.Unit_Price, Me.Additional_Info})
        Me.dgvAddParts.Location = New System.Drawing.Point(12, 49)
        Me.dgvAddParts.Name = "dgvAddParts"
        Me.dgvAddParts.Size = New System.Drawing.Size(469, 302)
        Me.dgvAddParts.TabIndex = 46
        '
        'Part
        '
        Me.Part.HeaderText = "Part"
        Me.Part.Name = "Part"
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.MaxInputLength = 3
        Me.Quantity.Name = "Quantity"
        '
        'Unit_Price
        '
        Me.Unit_Price.HeaderText = "Unit Cost"
        Me.Unit_Price.MaxInputLength = 5
        Me.Unit_Price.Name = "Unit_Price"
        '
        'Additional_Info
        '
        Me.Additional_Info.HeaderText = "Additional Info"
        Me.Additional_Info.Name = "Additional_Info"
        '
        'frmAddParts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 405)
        Me.Controls.Add(Me.dgvAddParts)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddParts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add/Edit Parts Used"
        CType(Me.dgvAddParts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents dgvAddParts As System.Windows.Forms.DataGridView
    Friend WithEvents Part As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Additional_Info As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
