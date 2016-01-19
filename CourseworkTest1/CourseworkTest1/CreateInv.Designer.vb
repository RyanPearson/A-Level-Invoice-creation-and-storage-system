<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCreateInv
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCreateInv))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblForename = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.btnSearchC = New System.Windows.Forms.Button()
        Me.btnCreateC = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblALine1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblALine2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblALine3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblPostcode = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblRegistration_Number = New System.Windows.Forms.Label()
        Me.btnSelectV = New System.Windows.Forms.Button()
        Me.btnCreateV = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnParts = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtParts_Total = New System.Windows.Forms.TextBox()
        Me.txtLabour_Total = New System.Windows.Forms.TextBox()
        Me.txtPreVAT_Total = New System.Windows.Forms.TextBox()
        Me.txtVAT_Total = New System.Windows.Forms.TextBox()
        Me.txtInvoice_Total = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.lblContact_Mobile = New System.Windows.Forms.Label()
        Me.lblContact_Home = New System.Windows.Forms.Label()
        Me.lblCustomer_ID = New System.Windows.Forms.Label()
        Me.lblVehicle_ID = New System.Windows.Forms.Label()
        Me.dgvPart = New System.Windows.Forms.DataGridView()
        Me.Delete_Row = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Part_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Part_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Additional_Info = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.lblContact_EMail = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.txtMileage = New System.Windows.Forms.TextBox()
        Me.btnTotals = New System.Windows.Forms.Button()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.lblInvoice_ID = New System.Windows.Forms.Label()
        Me.lblSaved = New System.Windows.Forms.Label()
        Me.lblTotalsGen = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AC Motors"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(246, 37)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Invoice Creation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Customer Details:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Forename:"
        '
        'lblForename
        '
        Me.lblForename.AutoSize = True
        Me.lblForename.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForename.Location = New System.Drawing.Point(113, 164)
        Me.lblForename.Name = "lblForename"
        Me.lblForename.Size = New System.Drawing.Size(100, 20)
        Me.lblForename.TabIndex = 4
        Me.lblForename.Text = "<Forename>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Surname:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(113, 192)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(92, 20)
        Me.lblSurname.TabIndex = 6
        Me.lblSurname.Text = "<Surname>"
        '
        'btnSearchC
        '
        Me.btnSearchC.Location = New System.Drawing.Point(301, 129)
        Me.btnSearchC.Name = "btnSearchC"
        Me.btnSearchC.Size = New System.Drawing.Size(126, 31)
        Me.btnSearchC.TabIndex = 7
        Me.btnSearchC.Text = "Search For Customer"
        Me.btnSearchC.UseVisualStyleBackColor = True
        '
        'btnCreateC
        '
        Me.btnCreateC.Location = New System.Drawing.Point(301, 168)
        Me.btnCreateC.Name = "btnCreateC"
        Me.btnCreateC.Size = New System.Drawing.Size(126, 31)
        Me.btnCreateC.TabIndex = 8
        Me.btnCreateC.Text = "Create New Customer"
        Me.btnCreateC.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 228)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 24)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Address:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Line 1:"
        '
        'lblALine1
        '
        Me.lblALine1.AutoSize = True
        Me.lblALine1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALine1.Location = New System.Drawing.Point(113, 264)
        Me.lblALine1.Name = "lblALine1"
        Me.lblALine1.Size = New System.Drawing.Size(133, 20)
        Me.lblALine1.TabIndex = 11
        Me.lblALine1.Text = "<Address Line 1>"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 291)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 20)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Line 2:"
        '
        'lblALine2
        '
        Me.lblALine2.AutoSize = True
        Me.lblALine2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALine2.Location = New System.Drawing.Point(113, 291)
        Me.lblALine2.Name = "lblALine2"
        Me.lblALine2.Size = New System.Drawing.Size(133, 20)
        Me.lblALine2.TabIndex = 13
        Me.lblALine2.Text = "<Address Line 2>"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 20)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Line 3:"
        '
        'lblALine3
        '
        Me.lblALine3.AutoSize = True
        Me.lblALine3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblALine3.Location = New System.Drawing.Point(113, 320)
        Me.lblALine3.Name = "lblALine3"
        Me.lblALine3.Size = New System.Drawing.Size(133, 20)
        Me.lblALine3.TabIndex = 15
        Me.lblALine3.Text = "<Address Line 3>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 348)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Postcode:"
        '
        'lblPostcode
        '
        Me.lblPostcode.AutoSize = True
        Me.lblPostcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostcode.Location = New System.Drawing.Point(113, 348)
        Me.lblPostcode.Name = "lblPostcode"
        Me.lblPostcode.Size = New System.Drawing.Size(94, 20)
        Me.lblPostcode.TabIndex = 17
        Me.lblPostcode.Text = "<Postcode>"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 513)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(155, 24)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Vehicle Details:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 548)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Make:"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(116, 548)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(66, 20)
        Me.lblMake.TabIndex = 20
        Me.lblMake.Text = "<Make>"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 574)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 20)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Model:"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(116, 574)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(70, 20)
        Me.lblModel.TabIndex = 22
        Me.lblModel.Text = "<Model>"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 601)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 20)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Reg No:"
        '
        'lblRegistration_Number
        '
        Me.lblRegistration_Number.AutoSize = True
        Me.lblRegistration_Number.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration_Number.Location = New System.Drawing.Point(116, 601)
        Me.lblRegistration_Number.Name = "lblRegistration_Number"
        Me.lblRegistration_Number.Size = New System.Drawing.Size(81, 20)
        Me.lblRegistration_Number.TabIndex = 24
        Me.lblRegistration_Number.Text = "<Reg No>"
        '
        'btnSelectV
        '
        Me.btnSelectV.Location = New System.Drawing.Point(301, 544)
        Me.btnSelectV.Name = "btnSelectV"
        Me.btnSelectV.Size = New System.Drawing.Size(126, 31)
        Me.btnSelectV.TabIndex = 25
        Me.btnSelectV.Text = "Select Vehicle"
        Me.btnSelectV.UseVisualStyleBackColor = True
        '
        'btnCreateV
        '
        Me.btnCreateV.Location = New System.Drawing.Point(301, 583)
        Me.btnCreateV.Name = "btnCreateV"
        Me.btnCreateV.Size = New System.Drawing.Size(126, 31)
        Me.btnCreateV.TabIndex = 26
        Me.btnCreateV.Text = "Create New Vehicle"
        Me.btnCreateV.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(458, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 24)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(457, 175)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(116, 24)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Parts Used:"
        '
        'btnParts
        '
        Me.btnParts.Location = New System.Drawing.Point(806, 210)
        Me.btnParts.Name = "btnParts"
        Me.btnParts.Size = New System.Drawing.Size(85, 72)
        Me.btnParts.TabIndex = 31
        Me.btnParts.Text = "Add Parts Used"
        Me.btnParts.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(457, 348)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(161, 24)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Job Description:"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(461, 386)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(430, 138)
        Me.txtDescription.TabIndex = 33
        Me.txtDescription.Text = "This will be filled out based upon what parts have been selected."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(458, 528)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 24)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Totals:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(458, 581)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 20)
        Me.Label19.TabIndex = 35
        Me.Label19.Text = "Parts:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(458, 555)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(70, 20)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Labour:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(458, 610)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(125, 20)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Pre VAT Total:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(458, 637)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 20)
        Me.Label22.TabIndex = 38
        Me.Label22.Text = "VAT:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(458, 662)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 20)
        Me.Label23.TabIndex = 39
        Me.Label23.Text = "Net Total:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(600, 581)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(19, 20)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "£"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(600, 555)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(19, 20)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "£"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(600, 610)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(19, 20)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "£"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(600, 637)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(19, 20)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "£"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(600, 662)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(19, 20)
        Me.Label28.TabIndex = 44
        Me.Label28.Text = "£"
        '
        'txtParts_Total
        '
        Me.txtParts_Total.Location = New System.Drawing.Point(625, 581)
        Me.txtParts_Total.Name = "txtParts_Total"
        Me.txtParts_Total.ReadOnly = True
        Me.txtParts_Total.Size = New System.Drawing.Size(100, 20)
        Me.txtParts_Total.TabIndex = 45
        '
        'txtLabour_Total
        '
        Me.txtLabour_Total.Location = New System.Drawing.Point(625, 555)
        Me.txtLabour_Total.MaxLength = 5
        Me.txtLabour_Total.Name = "txtLabour_Total"
        Me.txtLabour_Total.Size = New System.Drawing.Size(100, 20)
        Me.txtLabour_Total.TabIndex = 46
        '
        'txtPreVAT_Total
        '
        Me.txtPreVAT_Total.Location = New System.Drawing.Point(625, 610)
        Me.txtPreVAT_Total.Name = "txtPreVAT_Total"
        Me.txtPreVAT_Total.ReadOnly = True
        Me.txtPreVAT_Total.Size = New System.Drawing.Size(100, 20)
        Me.txtPreVAT_Total.TabIndex = 47
        '
        'txtVAT_Total
        '
        Me.txtVAT_Total.Location = New System.Drawing.Point(625, 637)
        Me.txtVAT_Total.Name = "txtVAT_Total"
        Me.txtVAT_Total.ReadOnly = True
        Me.txtVAT_Total.Size = New System.Drawing.Size(100, 20)
        Me.txtVAT_Total.TabIndex = 48
        '
        'txtInvoice_Total
        '
        Me.txtInvoice_Total.Location = New System.Drawing.Point(625, 662)
        Me.txtInvoice_Total.Name = "txtInvoice_Total"
        Me.txtInvoice_Total.ReadOnly = True
        Me.txtInvoice_Total.Size = New System.Drawing.Size(100, 20)
        Me.txtInvoice_Total.TabIndex = 49
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(763, 579)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(127, 31)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "Save Invoice"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(763, 616)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(127, 31)
        Me.btnPrint.TabIndex = 52
        Me.btnPrint.Text = "Print and Save Invoice"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(763, 653)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(127, 31)
        Me.btnMainMenu.TabIndex = 53
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(12, 140)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(48, 20)
        Me.Label29.TabIndex = 54
        Me.Label29.Text = "Title:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(113, 140)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(56, 20)
        Me.lblTitle.TabIndex = 55
        Me.lblTitle.Text = "<Title>"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 386)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 24)
        Me.Label30.TabIndex = 56
        Me.Label30.Text = "Contact:"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(12, 423)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 20)
        Me.Label31.TabIndex = 57
        Me.Label31.Text = "Mobile No:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(12, 446)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 20)
        Me.Label32.TabIndex = 58
        Me.Label32.Text = "Home No:"
        '
        'lblContact_Mobile
        '
        Me.lblContact_Mobile.AutoSize = True
        Me.lblContact_Mobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Mobile.Location = New System.Drawing.Point(113, 423)
        Me.lblContact_Mobile.Name = "lblContact_Mobile"
        Me.lblContact_Mobile.Size = New System.Drawing.Size(97, 20)
        Me.lblContact_Mobile.TabIndex = 59
        Me.lblContact_Mobile.Text = "<Mobile No>"
        '
        'lblContact_Home
        '
        Me.lblContact_Home.AutoSize = True
        Me.lblContact_Home.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_Home.Location = New System.Drawing.Point(113, 446)
        Me.lblContact_Home.Name = "lblContact_Home"
        Me.lblContact_Home.Size = New System.Drawing.Size(94, 20)
        Me.lblContact_Home.TabIndex = 60
        Me.lblContact_Home.Text = "<Home No>"
        '
        'lblCustomer_ID
        '
        Me.lblCustomer_ID.AutoSize = True
        Me.lblCustomer_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer_ID.Location = New System.Drawing.Point(460, 5)
        Me.lblCustomer_ID.Name = "lblCustomer_ID"
        Me.lblCustomer_ID.Size = New System.Drawing.Size(122, 20)
        Me.lblCustomer_ID.TabIndex = 63
        Me.lblCustomer_ID.Text = "<Customer_ID>"
        Me.lblCustomer_ID.Visible = False
        '
        'lblVehicle_ID
        '
        Me.lblVehicle_ID.AutoSize = True
        Me.lblVehicle_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVehicle_ID.Location = New System.Drawing.Point(588, 5)
        Me.lblVehicle_ID.Name = "lblVehicle_ID"
        Me.lblVehicle_ID.Size = New System.Drawing.Size(105, 20)
        Me.lblVehicle_ID.TabIndex = 65
        Me.lblVehicle_ID.Text = "<Vehicle_ID>"
        Me.lblVehicle_ID.Visible = False
        '
        'dgvPart
        '
        Me.dgvPart.AllowUserToAddRows = False
        Me.dgvPart.AllowUserToDeleteRows = False
        Me.dgvPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete_Row, Me.Part_ID, Me.Part_Name, Me.Quantity, Me.Unit_Price, Me.Total_Unit_Price, Me.Description, Me.Additional_Info})
        Me.dgvPart.Location = New System.Drawing.Point(461, 210)
        Me.dgvPart.Name = "dgvPart"
        Me.dgvPart.ReadOnly = True
        Me.dgvPart.Size = New System.Drawing.Size(339, 130)
        Me.dgvPart.TabIndex = 66
        '
        'Delete_Row
        '
        Me.Delete_Row.HeaderText = ""
        Me.Delete_Row.Name = "Delete_Row"
        Me.Delete_Row.ReadOnly = True
        Me.Delete_Row.Text = "Delete Row"
        Me.Delete_Row.UseColumnTextForButtonValue = True
        '
        'Part_ID
        '
        Me.Part_ID.HeaderText = "Part_ID"
        Me.Part_ID.Name = "Part_ID"
        Me.Part_ID.ReadOnly = True
        Me.Part_ID.Visible = False
        '
        'Part_Name
        '
        Me.Part_Name.HeaderText = "Part_Name"
        Me.Part_Name.Name = "Part_Name"
        Me.Part_Name.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.HeaderText = "Quantity"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Unit_Price
        '
        Me.Unit_Price.HeaderText = "Unit_Price"
        Me.Unit_Price.Name = "Unit_Price"
        Me.Unit_Price.ReadOnly = True
        '
        'Total_Unit_Price
        '
        Me.Total_Unit_Price.HeaderText = "Total_Price"
        Me.Total_Unit_Price.Name = "Total_Unit_Price"
        Me.Total_Unit_Price.ReadOnly = True
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Visible = False
        '
        'Additional_Info
        '
        Me.Additional_Info.HeaderText = "Additional_Info"
        Me.Additional_Info.Name = "Additional_Info"
        Me.Additional_Info.ReadOnly = True
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(806, 285)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(85, 72)
        Me.btnGenerate.TabIndex = 68
        Me.btnGenerate.Text = "Generate Job Description"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(532, 140)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(62, 20)
        Me.lblDate.TabIndex = 69
        Me.lblDate.Text = "<Date>"
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(765, 136)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(126, 31)
        Me.btnDate.TabIndex = 70
        Me.btnDate.Text = "Use Selected Date"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(12, 471)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(64, 20)
        Me.Label36.TabIndex = 71
        Me.Label36.Text = "E-Mail:"
        '
        'lblContact_EMail
        '
        Me.lblContact_EMail.AutoSize = True
        Me.lblContact_EMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContact_EMail.Location = New System.Drawing.Point(113, 471)
        Me.lblContact_EMail.Name = "lblContact_EMail"
        Me.lblContact_EMail.Size = New System.Drawing.Size(71, 20)
        Me.lblContact_EMail.TabIndex = 72
        Me.lblContact_EMail.Text = "<E-Mail>"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(15, 629)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(76, 20)
        Me.Label38.TabIndex = 73
        Me.Label38.Text = "Mileage:"
        '
        'txtMileage
        '
        Me.txtMileage.Location = New System.Drawing.Point(120, 631)
        Me.txtMileage.MaxLength = 6
        Me.txtMileage.Name = "txtMileage"
        Me.txtMileage.Size = New System.Drawing.Size(160, 20)
        Me.txtMileage.TabIndex = 74
        '
        'btnTotals
        '
        Me.btnTotals.Location = New System.Drawing.Point(763, 542)
        Me.btnTotals.Name = "btnTotals"
        Me.btnTotals.Size = New System.Drawing.Size(127, 31)
        Me.btnTotals.TabIndex = 75
        Me.btnTotals.Text = "Generate Totals"
        Me.btnTotals.UseVisualStyleBackColor = True
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(458, 140)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(53, 20)
        Me.Label35.TabIndex = 76
        Me.Label35.Text = "Date:"
        '
        'lblInvoice_ID
        '
        Me.lblInvoice_ID.AutoSize = True
        Me.lblInvoice_ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvoice_ID.Location = New System.Drawing.Point(699, 5)
        Me.lblInvoice_ID.Name = "lblInvoice_ID"
        Me.lblInvoice_ID.Size = New System.Drawing.Size(103, 20)
        Me.lblInvoice_ID.TabIndex = 77
        Me.lblInvoice_ID.Text = "<Invoice_ID>"
        Me.lblInvoice_ID.Visible = False
        '
        'lblSaved
        '
        Me.lblSaved.AutoSize = True
        Me.lblSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaved.Location = New System.Drawing.Point(808, 5)
        Me.lblSaved.Name = "lblSaved"
        Me.lblSaved.Size = New System.Drawing.Size(18, 20)
        Me.lblSaved.TabIndex = 78
        Me.lblSaved.Text = "0"
        Me.lblSaved.Visible = False
        '
        'lblTotalsGen
        '
        Me.lblTotalsGen.AutoSize = True
        Me.lblTotalsGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalsGen.Location = New System.Drawing.Point(832, 5)
        Me.lblTotalsGen.Name = "lblTotalsGen"
        Me.lblTotalsGen.Size = New System.Drawing.Size(18, 20)
        Me.lblTotalsGen.TabIndex = 79
        Me.lblTotalsGen.Text = "0"
        Me.lblTotalsGen.Visible = False
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(536, 111)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 82
        '
        'frmCreateInv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 694)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.lblTotalsGen)
        Me.Controls.Add(Me.lblSaved)
        Me.Controls.Add(Me.lblInvoice_ID)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.btnTotals)
        Me.Controls.Add(Me.txtMileage)
        Me.Controls.Add(Me.Label38)
        Me.Controls.Add(Me.lblContact_EMail)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.btnDate)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnGenerate)
        Me.Controls.Add(Me.dgvPart)
        Me.Controls.Add(Me.lblVehicle_ID)
        Me.Controls.Add(Me.lblCustomer_ID)
        Me.Controls.Add(Me.lblContact_Home)
        Me.Controls.Add(Me.lblContact_Mobile)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtInvoice_Total)
        Me.Controls.Add(Me.txtVAT_Total)
        Me.Controls.Add(Me.txtPreVAT_Total)
        Me.Controls.Add(Me.txtLabour_Total)
        Me.Controls.Add(Me.txtParts_Total)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.btnParts)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.btnCreateV)
        Me.Controls.Add(Me.btnSelectV)
        Me.Controls.Add(Me.lblRegistration_Number)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lblPostcode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblALine3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblALine2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblALine1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCreateC)
        Me.Controls.Add(Me.btnSearchC)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblForename)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmCreateInv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice Creation"
        CType(Me.dgvPart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblForename As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents btnSearchC As System.Windows.Forms.Button
    Friend WithEvents btnCreateC As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblALine1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblALine2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblALine3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblPostcode As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblMake As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblModel As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblRegistration_Number As System.Windows.Forms.Label
    Friend WithEvents btnSelectV As System.Windows.Forms.Button
    Friend WithEvents btnCreateV As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnParts As System.Windows.Forms.Button
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtParts_Total As System.Windows.Forms.TextBox
    Friend WithEvents txtLabour_Total As System.Windows.Forms.TextBox
    Friend WithEvents txtPreVAT_Total As System.Windows.Forms.TextBox
    Friend WithEvents txtVAT_Total As System.Windows.Forms.TextBox
    Friend WithEvents txtInvoice_Total As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents lblContact_Mobile As System.Windows.Forms.Label
    Friend WithEvents lblContact_Home As System.Windows.Forms.Label
    Friend WithEvents lblCustomer_ID As System.Windows.Forms.Label
    Friend WithEvents lblVehicle_ID As System.Windows.Forms.Label
    Friend WithEvents dgvPart As System.Windows.Forms.DataGridView
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnDate As System.Windows.Forms.Button
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents lblContact_EMail As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtMileage As System.Windows.Forms.TextBox
    Friend WithEvents btnTotals As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents lblInvoice_ID As System.Windows.Forms.Label
    Friend WithEvents lblSaved As System.Windows.Forms.Label
    Friend WithEvents lblTotalsGen As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Delete_Row As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Part_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Part_Name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_Unit_Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Additional_Info As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
