<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncome
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.dgvPaymentDetails = New System.Windows.Forms.DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.TextBox()
        Me.dtpBirth = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMemberID = New System.Windows.Forms.TextBox()
        Me.txtDescrip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboDepositType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtInid = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvIncomeDetails = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Me.dgvPaymentDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvIncomeDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'dgvPaymentDetails
        '
        Me.dgvPaymentDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPaymentDetails.Location = New System.Drawing.Point(566, 277)
        Me.dgvPaymentDetails.Name = "dgvPaymentDetails"
        Me.dgvPaymentDetails.Size = New System.Drawing.Size(657, 204)
        Me.dgvPaymentDetails.TabIndex = 27
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.Controls.Add(Me.GroupBox3)
        Me.Guna2GroupBox2.Controls.Add(Me.dtpBirth)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.Label13)
        Me.Guna2GroupBox2.Controls.Add(Me.txtMemberID)
        Me.Guna2GroupBox2.Controls.Add(Me.txtDescrip)
        Me.Guna2GroupBox2.Controls.Add(Me.Label2)
        Me.Guna2GroupBox2.Controls.Add(Me.cboDepositType)
        Me.Guna2GroupBox2.Controls.Add(Me.Label5)
        Me.Guna2GroupBox2.Controls.Add(Me.Label3)
        Me.Guna2GroupBox2.Controls.Add(Me.Label4)
        Me.Guna2GroupBox2.Controls.Add(Me.txtAmount)
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(12, 80)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(548, 401)
        Me.Guna2GroupBox2.TabIndex = 26
        Me.Guna2GroupBox2.Text = "Guna2GroupBox2"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDetails)
        Me.GroupBox3.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(69, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(426, 124)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "รายละเอียด"
        '
        'txtDetails
        '
        Me.txtDetails.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(6, 21)
        Me.txtDetails.Multiline = True
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.Size = New System.Drawing.Size(414, 97)
        Me.txtDetails.TabIndex = 1
        '
        'dtpBirth
        '
        Me.dtpBirth.BorderRadius = 10
        Me.dtpBirth.Checked = True
        Me.dtpBirth.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.dtpBirth.Font = New System.Drawing.Font("FC Minimal", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirth.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpBirth.Location = New System.Drawing.Point(153, 348)
        Me.dtpBirth.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBirth.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBirth.Name = "dtpBirth"
        Me.dtpBirth.Size = New System.Drawing.Size(197, 36)
        Me.dtpBirth.TabIndex = 10
        Me.dtpBirth.Value = New Date(2024, 9, 16, 20, 26, 3, 16)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(87, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "สมาชิก :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(102, 357)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 24)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "วันที่ :"
        '
        'txtMemberID
        '
        Me.txtMemberID.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberID.Location = New System.Drawing.Point(153, 64)
        Me.txtMemberID.Name = "txtMemberID"
        Me.txtMemberID.Size = New System.Drawing.Size(197, 31)
        Me.txtMemberID.TabIndex = 1
        '
        'txtDescrip
        '
        Me.txtDescrip.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrip.Location = New System.Drawing.Point(153, 229)
        Me.txtDescrip.Name = "txtDescrip"
        Me.txtDescrip.Size = New System.Drawing.Size(197, 31)
        Me.txtDescrip.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 276)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "เงินฝากเข้า :"
        '
        'cboDepositType
        '
        Me.cboDepositType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepositType.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepositType.FormattingEnabled = True
        Me.cboDepositType.Location = New System.Drawing.Point(153, 270)
        Me.cboDepositType.Name = "cboDepositType"
        Me.cboDepositType.Size = New System.Drawing.Size(197, 32)
        Me.cboDepositType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(74, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "คำอธิบาย :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 317)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "จำนวนเงิน :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(356, 317)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "บาท"
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(153, 311)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(197, 31)
        Me.txtAmount.TabIndex = 1
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1003, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 24)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "เลขที่รายรับ"
        '
        'txtInid
        '
        Me.txtInid.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.txtInid.Font = New System.Drawing.Font("TH SarabunPSK", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInid.Location = New System.Drawing.Point(1084, 36)
        Me.txtInid.Multiline = True
        Me.txtInid.Name = "txtInid"
        Me.txtInid.ReadOnly = True
        Me.txtInid.Size = New System.Drawing.Size(139, 40)
        Me.txtInid.TabIndex = 24
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnDelete.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDelete.Location = New System.Drawing.Point(463, 523)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(150, 75)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClear.Font = New System.Drawing.Font("TH SarabunPSK", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(779, 523)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 75)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "ล้างข้อมูล"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCalculate.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCalculate.Location = New System.Drawing.Point(623, 523)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 75)
        Me.btnCalculate.TabIndex = 20
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.Font = New System.Drawing.Font("TH SarabunPSK", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Location = New System.Drawing.Point(307, 523)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 75)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "บันทึก"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dgvIncomeDetails
        '
        Me.dgvIncomeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncomeDetails.Location = New System.Drawing.Point(566, 80)
        Me.dgvIncomeDetails.Name = "dgvIncomeDetails"
        Me.dgvIncomeDetails.Size = New System.Drawing.Size(657, 191)
        Me.dgvIncomeDetails.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.lblTotalAmount)
        Me.Panel1.Location = New System.Drawing.Point(1063, 498)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 45)
        Me.Panel1.TabIndex = 23
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("TH SarabunPSK", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalAmount.Location = New System.Drawing.Point(19, 6)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(62, 39)
        Me.lblTotalAmount.TabIndex = 10
        Me.lblTotalAmount.Text = "0.00"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(1235, 30)
        Me.Guna2Panel1.TabIndex = 28
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Red
        Me.Guna2ControlBox2.CustomIconSize = 30.0!
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.DarkSlateBlue
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Red
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1185, 1)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(38, 29)
        Me.Guna2ControlBox2.TabIndex = 15
        '
        'frmIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 606)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.dgvPaymentDetails)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtInid)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvIncomeDetails)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmIncome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmIncome"
        CType(Me.dgvPaymentDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvIncomeDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents dgvPaymentDetails As DataGridView
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtDetails As TextBox
    Friend WithEvents dtpBirth As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMemberID As TextBox
    Friend WithEvents txtDescrip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cboDepositType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtInid As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvIncomeDetails As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
End Class
