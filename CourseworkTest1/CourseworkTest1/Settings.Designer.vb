<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnChangeVAT = New System.Windows.Forms.Button()
        Me.btnAddPart = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnEditC = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Settings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 42)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AC Motors"
        '
        'btnChangeVAT
        '
        Me.btnChangeVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeVAT.Location = New System.Drawing.Point(19, 91)
        Me.btnChangeVAT.Name = "btnChangeVAT"
        Me.btnChangeVAT.Size = New System.Drawing.Size(196, 43)
        Me.btnChangeVAT.TabIndex = 4
        Me.btnChangeVAT.Text = "Change VAT %"
        Me.btnChangeVAT.UseVisualStyleBackColor = True
        '
        'btnAddPart
        '
        Me.btnAddPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPart.Location = New System.Drawing.Point(19, 140)
        Me.btnAddPart.Name = "btnAddPart"
        Me.btnAddPart.Size = New System.Drawing.Size(196, 43)
        Me.btnAddPart.TabIndex = 7
        Me.btnAddPart.Text = "Add a Part"
        Me.btnAddPart.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(19, 238)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(196, 43)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Main Menu"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnEditC
        '
        Me.btnEditC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditC.Location = New System.Drawing.Point(19, 189)
        Me.btnEditC.Name = "btnEditC"
        Me.btnEditC.Size = New System.Drawing.Size(196, 43)
        Me.btnEditC.TabIndex = 10
        Me.btnEditC.Text = "Edit Customer"
        Me.btnEditC.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 296)
        Me.Controls.Add(Me.btnEditC)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnAddPart)
        Me.Controls.Add(Me.btnChangeVAT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnChangeVAT As System.Windows.Forms.Button
    Friend WithEvents btnAddPart As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnEditC As System.Windows.Forms.Button
End Class
