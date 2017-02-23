<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.grpRemunerations = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblOvertimeHrs = New System.Windows.Forms.Label()
        Me.txtLeaveAllowance = New System.Windows.Forms.TextBox()
        Me.txtOvertimeHrs = New System.Windows.Forms.TextBox()
        Me.lblLeaveAllowance = New System.Windows.Forms.Label()
        Me.lblHouseAllowance = New System.Windows.Forms.Label()
        Me.lblTotalRemunerations = New System.Windows.Forms.Label()
        Me.txtHouseAllowance = New System.Windows.Forms.TextBox()
        Me.txtTotalRemunerations = New System.Windows.Forms.TextBox()
        Me.grpDeductions = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTotalDeductions = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtAdvance = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.lblAdvance = New System.Windows.Forms.Label()
        Me.lblNssf = New System.Windows.Forms.Label()
        Me.lblNhif = New System.Windows.Forms.Label()
        Me.txtNssf = New System.Windows.Forms.TextBox()
        Me.lblTotalDeductions = New System.Windows.Forms.Label()
        Me.txtNhif = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grpPersonalDetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblMaritalStatus = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.cboMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.grpJobDetails = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblTookLeave = New System.Windows.Forms.Label()
        Me.lblTookAdvance = New System.Windows.Forms.Label()
        Me.lblWorkedOvertime = New System.Windows.Forms.Label()
        Me.chkTookLeave = New System.Windows.Forms.CheckBox()
        Me.chkTookAdvance = New System.Windows.Forms.CheckBox()
        Me.chkWorkedOvertime = New System.Windows.Forms.CheckBox()
        Me.cboTookLeave = New System.Windows.Forms.ComboBox()
        Me.cboTookAdvance = New System.Windows.Forms.ComboBox()
        Me.grpIncome = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNetSalaryInKsh = New System.Windows.Forms.Label()
        Me.txtNetSalaryInKsh = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.grpPaySlip = New System.Windows.Forms.GroupBox()
        Me.txtSlip = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblEmpName = New System.Windows.Forms.Label()
        Me.txtBasicSalary = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.lblBasicSalary = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProcessData = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpRemunerations.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.grpDeductions.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grpPersonalDetails.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.grpJobDetails.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.grpIncome.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpPaySlip.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpRemunerations
        '
        Me.grpRemunerations.Controls.Add(Me.TableLayoutPanel4)
        Me.grpRemunerations.Location = New System.Drawing.Point(309, 273)
        Me.grpRemunerations.Name = "grpRemunerations"
        Me.grpRemunerations.Size = New System.Drawing.Size(313, 165)
        Me.grpRemunerations.TabIndex = 0
        Me.grpRemunerations.TabStop = False
        Me.grpRemunerations.Text = "Remunerations"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.lblOvertimeHrs, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.txtLeaveAllowance, 1, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.txtOvertimeHrs, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.lblLeaveAllowance, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.lblHouseAllowance, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.lblTotalRemunerations, 0, 3)
        Me.TableLayoutPanel4.Controls.Add(Me.txtHouseAllowance, 1, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.txtTotalRemunerations, 1, 3)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 5
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(295, 126)
        Me.TableLayoutPanel4.TabIndex = 3
        '
        'lblOvertimeHrs
        '
        Me.lblOvertimeHrs.AutoSize = True
        Me.lblOvertimeHrs.Location = New System.Drawing.Point(3, 0)
        Me.lblOvertimeHrs.Name = "lblOvertimeHrs"
        Me.lblOvertimeHrs.Size = New System.Drawing.Size(66, 13)
        Me.lblOvertimeHrs.TabIndex = 0
        Me.lblOvertimeHrs.Text = "Overtime hrs"
        '
        'txtLeaveAllowance
        '
        Me.txtLeaveAllowance.Location = New System.Drawing.Point(150, 27)
        Me.txtLeaveAllowance.Name = "txtLeaveAllowance"
        Me.txtLeaveAllowance.Size = New System.Drawing.Size(142, 20)
        Me.txtLeaveAllowance.TabIndex = 3
        '
        'txtOvertimeHrs
        '
        Me.txtOvertimeHrs.Enabled = False
        Me.txtOvertimeHrs.Location = New System.Drawing.Point(150, 3)
        Me.txtOvertimeHrs.Name = "txtOvertimeHrs"
        Me.txtOvertimeHrs.Size = New System.Drawing.Size(142, 20)
        Me.txtOvertimeHrs.TabIndex = 2
        '
        'lblLeaveAllowance
        '
        Me.lblLeaveAllowance.AutoSize = True
        Me.lblLeaveAllowance.Location = New System.Drawing.Point(3, 24)
        Me.lblLeaveAllowance.Name = "lblLeaveAllowance"
        Me.lblLeaveAllowance.Size = New System.Drawing.Size(88, 13)
        Me.lblLeaveAllowance.TabIndex = 1
        Me.lblLeaveAllowance.Text = "Leave allowance"
        '
        'lblHouseAllowance
        '
        Me.lblHouseAllowance.AutoSize = True
        Me.lblHouseAllowance.Location = New System.Drawing.Point(3, 50)
        Me.lblHouseAllowance.Name = "lblHouseAllowance"
        Me.lblHouseAllowance.Size = New System.Drawing.Size(89, 13)
        Me.lblHouseAllowance.TabIndex = 7
        Me.lblHouseAllowance.Text = "House allowance"
        '
        'lblTotalRemunerations
        '
        Me.lblTotalRemunerations.AutoSize = True
        Me.lblTotalRemunerations.Location = New System.Drawing.Point(3, 74)
        Me.lblTotalRemunerations.Name = "lblTotalRemunerations"
        Me.lblTotalRemunerations.Size = New System.Drawing.Size(100, 13)
        Me.lblTotalRemunerations.TabIndex = 9
        Me.lblTotalRemunerations.Text = "Total remunerations"
        '
        'txtHouseAllowance
        '
        Me.txtHouseAllowance.Location = New System.Drawing.Point(150, 53)
        Me.txtHouseAllowance.Name = "txtHouseAllowance"
        Me.txtHouseAllowance.Size = New System.Drawing.Size(142, 20)
        Me.txtHouseAllowance.TabIndex = 6
        '
        'txtTotalRemunerations
        '
        Me.txtTotalRemunerations.Location = New System.Drawing.Point(150, 77)
        Me.txtTotalRemunerations.Name = "txtTotalRemunerations"
        Me.txtTotalRemunerations.Size = New System.Drawing.Size(142, 20)
        Me.txtTotalRemunerations.TabIndex = 5
        '
        'grpDeductions
        '
        Me.grpDeductions.Controls.Add(Me.TableLayoutPanel3)
        Me.grpDeductions.Location = New System.Drawing.Point(12, 273)
        Me.grpDeductions.Name = "grpDeductions"
        Me.grpDeductions.Size = New System.Drawing.Size(291, 165)
        Me.grpDeductions.TabIndex = 0
        Me.grpDeductions.TabStop = False
        Me.grpDeductions.Text = "Deductions"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.txtTotalDeductions, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTax, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtAdvance, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtTax, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.lblAdvance, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.lblNssf, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblNhif, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNssf, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.lblTotalDeductions, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.txtNhif, 1, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(279, 126)
        Me.TableLayoutPanel3.TabIndex = 2
        '
        'txtTotalDeductions
        '
        Me.txtTotalDeductions.Location = New System.Drawing.Point(142, 102)
        Me.txtTotalDeductions.Name = "txtTotalDeductions"
        Me.txtTotalDeductions.Size = New System.Drawing.Size(134, 20)
        Me.txtTotalDeductions.TabIndex = 11
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Location = New System.Drawing.Point(3, 0)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(25, 13)
        Me.lblTax.TabIndex = 0
        Me.lblTax.Text = "Tax"
        '
        'txtAdvance
        '
        Me.txtAdvance.Enabled = False
        Me.txtAdvance.Location = New System.Drawing.Point(142, 27)
        Me.txtAdvance.Name = "txtAdvance"
        Me.txtAdvance.Size = New System.Drawing.Size(134, 20)
        Me.txtAdvance.TabIndex = 3
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(142, 3)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(134, 20)
        Me.txtTax.TabIndex = 2
        '
        'lblAdvance
        '
        Me.lblAdvance.AutoSize = True
        Me.lblAdvance.Location = New System.Drawing.Point(3, 24)
        Me.lblAdvance.Name = "lblAdvance"
        Me.lblAdvance.Size = New System.Drawing.Size(44, 13)
        Me.lblAdvance.TabIndex = 1
        Me.lblAdvance.Text = "Avance"
        '
        'lblNssf
        '
        Me.lblNssf.AutoSize = True
        Me.lblNssf.Location = New System.Drawing.Point(3, 50)
        Me.lblNssf.Name = "lblNssf"
        Me.lblNssf.Size = New System.Drawing.Size(35, 13)
        Me.lblNssf.TabIndex = 7
        Me.lblNssf.Text = "NSSF"
        '
        'lblNhif
        '
        Me.lblNhif.AutoSize = True
        Me.lblNhif.Location = New System.Drawing.Point(3, 74)
        Me.lblNhif.Name = "lblNhif"
        Me.lblNhif.Size = New System.Drawing.Size(32, 13)
        Me.lblNhif.TabIndex = 9
        Me.lblNhif.Text = "NHIF"
        '
        'txtNssf
        '
        Me.txtNssf.Location = New System.Drawing.Point(142, 53)
        Me.txtNssf.Name = "txtNssf"
        Me.txtNssf.Size = New System.Drawing.Size(134, 20)
        Me.txtNssf.TabIndex = 6
        '
        'lblTotalDeductions
        '
        Me.lblTotalDeductions.AutoSize = True
        Me.lblTotalDeductions.Location = New System.Drawing.Point(3, 99)
        Me.lblTotalDeductions.Name = "lblTotalDeductions"
        Me.lblTotalDeductions.Size = New System.Drawing.Size(86, 13)
        Me.lblTotalDeductions.TabIndex = 10
        Me.lblTotalDeductions.Text = "Total deductions"
        '
        'txtNhif
        '
        Me.txtNhif.Location = New System.Drawing.Point(142, 77)
        Me.txtNhif.Name = "txtNhif"
        Me.txtNhif.Size = New System.Drawing.Size(134, 20)
        Me.txtNhif.TabIndex = 5
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.grpPersonalDetails)
        Me.GroupBox3.Controls.Add(Me.grpJobDetails)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 110)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(610, 157)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'grpPersonalDetails
        '
        Me.grpPersonalDetails.Controls.Add(Me.TableLayoutPanel5)
        Me.grpPersonalDetails.Location = New System.Drawing.Point(6, 19)
        Me.grpPersonalDetails.Name = "grpPersonalDetails"
        Me.grpPersonalDetails.Size = New System.Drawing.Size(285, 119)
        Me.grpPersonalDetails.TabIndex = 0
        Me.grpPersonalDetails.TabStop = False
        Me.grpPersonalDetails.Text = "Personal details"
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.lblMaritalStatus, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.lblSex, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.cboMaritalStatus, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.cboSex, 1, 1)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(273, 52)
        Me.TableLayoutPanel5.TabIndex = 2
        '
        'lblMaritalStatus
        '
        Me.lblMaritalStatus.AutoSize = True
        Me.lblMaritalStatus.Location = New System.Drawing.Point(3, 0)
        Me.lblMaritalStatus.Name = "lblMaritalStatus"
        Me.lblMaritalStatus.Size = New System.Drawing.Size(69, 13)
        Me.lblMaritalStatus.TabIndex = 0
        Me.lblMaritalStatus.Text = "Marital status"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(3, 24)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(25, 13)
        Me.lblSex.TabIndex = 1
        Me.lblSex.Text = "Sex"
        '
        'cboMaritalStatus
        '
        Me.cboMaritalStatus.FormattingEnabled = True
        Me.cboMaritalStatus.Items.AddRange(New Object() {"Single", "Married"})
        Me.cboMaritalStatus.Location = New System.Drawing.Point(139, 3)
        Me.cboMaritalStatus.Name = "cboMaritalStatus"
        Me.cboMaritalStatus.Size = New System.Drawing.Size(131, 21)
        Me.cboMaritalStatus.TabIndex = 2
        Me.cboMaritalStatus.Text = "--Select--"
        '
        'cboSex
        '
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Items.AddRange(New Object() {"Male", "Female"})
        Me.cboSex.Location = New System.Drawing.Point(139, 27)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(131, 21)
        Me.cboSex.TabIndex = 3
        Me.cboSex.Text = "--Select--"
        '
        'grpJobDetails
        '
        Me.grpJobDetails.Controls.Add(Me.TableLayoutPanel6)
        Me.grpJobDetails.Location = New System.Drawing.Point(297, 19)
        Me.grpJobDetails.Name = "grpJobDetails"
        Me.grpJobDetails.Size = New System.Drawing.Size(307, 119)
        Me.grpJobDetails.TabIndex = 0
        Me.grpJobDetails.TabStop = False
        Me.grpJobDetails.Text = "Job details"
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 3
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.lblTookLeave, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.lblTookAdvance, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.lblWorkedOvertime, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.chkTookLeave, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.chkTookAdvance, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.chkWorkedOvertime, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.cboTookLeave, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.cboTookAdvance, 2, 1)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(295, 76)
        Me.TableLayoutPanel6.TabIndex = 2
        '
        'lblTookLeave
        '
        Me.lblTookLeave.AutoSize = True
        Me.lblTookLeave.Location = New System.Drawing.Point(36, 0)
        Me.lblTookLeave.Name = "lblTookLeave"
        Me.lblTookLeave.Size = New System.Drawing.Size(61, 13)
        Me.lblTookLeave.TabIndex = 0
        Me.lblTookLeave.Text = "Took leave"
        '
        'lblTookAdvance
        '
        Me.lblTookAdvance.AutoSize = True
        Me.lblTookAdvance.Location = New System.Drawing.Point(36, 23)
        Me.lblTookAdvance.Name = "lblTookAdvance"
        Me.lblTookAdvance.Size = New System.Drawing.Size(77, 13)
        Me.lblTookAdvance.TabIndex = 1
        Me.lblTookAdvance.Text = "Took advance"
        '
        'lblWorkedOvertime
        '
        Me.lblWorkedOvertime.AutoSize = True
        Me.lblWorkedOvertime.Location = New System.Drawing.Point(36, 48)
        Me.lblWorkedOvertime.Name = "lblWorkedOvertime"
        Me.lblWorkedOvertime.Size = New System.Drawing.Size(88, 13)
        Me.lblWorkedOvertime.TabIndex = 4
        Me.lblWorkedOvertime.Text = "Worked overtime"
        '
        'chkTookLeave
        '
        Me.chkTookLeave.AutoSize = True
        Me.chkTookLeave.Location = New System.Drawing.Point(3, 3)
        Me.chkTookLeave.Name = "chkTookLeave"
        Me.chkTookLeave.Size = New System.Drawing.Size(15, 14)
        Me.chkTookLeave.TabIndex = 5
        Me.chkTookLeave.UseVisualStyleBackColor = True
        '
        'chkTookAdvance
        '
        Me.chkTookAdvance.AutoSize = True
        Me.chkTookAdvance.Location = New System.Drawing.Point(3, 26)
        Me.chkTookAdvance.Name = "chkTookAdvance"
        Me.chkTookAdvance.Size = New System.Drawing.Size(15, 14)
        Me.chkTookAdvance.TabIndex = 6
        Me.chkTookAdvance.UseVisualStyleBackColor = True
        '
        'chkWorkedOvertime
        '
        Me.chkWorkedOvertime.AutoSize = True
        Me.chkWorkedOvertime.Location = New System.Drawing.Point(3, 51)
        Me.chkWorkedOvertime.Name = "chkWorkedOvertime"
        Me.chkWorkedOvertime.Size = New System.Drawing.Size(15, 14)
        Me.chkWorkedOvertime.TabIndex = 7
        Me.chkWorkedOvertime.UseVisualStyleBackColor = True
        '
        'cboTookLeave
        '
        Me.cboTookLeave.Enabled = False
        Me.cboTookLeave.FormattingEnabled = True
        Me.cboTookLeave.Items.AddRange(New Object() {"Annual allowance", "House allowance"})
        Me.cboTookLeave.Location = New System.Drawing.Point(168, 3)
        Me.cboTookLeave.Name = "cboTookLeave"
        Me.cboTookLeave.Size = New System.Drawing.Size(121, 21)
        Me.cboTookLeave.TabIndex = 8
        Me.cboTookLeave.Text = "--Select--"
        '
        'cboTookAdvance
        '
        Me.cboTookAdvance.Enabled = False
        Me.cboTookAdvance.FormattingEnabled = True
        Me.cboTookAdvance.Items.AddRange(New Object() {"25% basic salary", "50% basic salary"})
        Me.cboTookAdvance.Location = New System.Drawing.Point(168, 26)
        Me.cboTookAdvance.Name = "cboTookAdvance"
        Me.cboTookAdvance.Size = New System.Drawing.Size(121, 21)
        Me.cboTookAdvance.TabIndex = 9
        Me.cboTookAdvance.Text = "--Select--"
        '
        'grpIncome
        '
        Me.grpIncome.Controls.Add(Me.TableLayoutPanel2)
        Me.grpIncome.Location = New System.Drawing.Point(309, 16)
        Me.grpIncome.Name = "grpIncome"
        Me.grpIncome.Size = New System.Drawing.Size(313, 88)
        Me.grpIncome.TabIndex = 0
        Me.grpIncome.TabStop = False
        Me.grpIncome.Text = "Income"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblNetSalaryInKsh, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtNetSalaryInKsh, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDate, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DateTimePicker1, 1, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(15, 21)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(292, 52)
        Me.TableLayoutPanel2.TabIndex = 2
        '
        'lblNetSalaryInKsh
        '
        Me.lblNetSalaryInKsh.AutoSize = True
        Me.lblNetSalaryInKsh.Location = New System.Drawing.Point(3, 0)
        Me.lblNetSalaryInKsh.Name = "lblNetSalaryInKsh"
        Me.lblNetSalaryInKsh.Size = New System.Drawing.Size(85, 13)
        Me.lblNetSalaryInKsh.TabIndex = 0
        Me.lblNetSalaryInKsh.Text = "Net salary in ksh"
        '
        'txtNetSalaryInKsh
        '
        Me.txtNetSalaryInKsh.Location = New System.Drawing.Point(149, 3)
        Me.txtNetSalaryInKsh.Name = "txtNetSalaryInKsh"
        Me.txtNetSalaryInKsh.Size = New System.Drawing.Size(140, 20)
        Me.txtNetSalaryInKsh.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(3, 24)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(149, 27)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePicker1.TabIndex = 3
        '
        'grpPaySlip
        '
        Me.grpPaySlip.Controls.Add(Me.txtSlip)
        Me.grpPaySlip.Location = New System.Drawing.Point(649, 16)
        Me.grpPaySlip.Name = "grpPaySlip"
        Me.grpPaySlip.Size = New System.Drawing.Size(272, 479)
        Me.grpPaySlip.TabIndex = 0
        Me.grpPaySlip.TabStop = False
        Me.grpPaySlip.Text = "Pay slip"
        '
        'txtSlip
        '
        Me.txtSlip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSlip.Location = New System.Drawing.Point(6, 19)
        Me.txtSlip.Multiline = True
        Me.txtSlip.Name = "txtSlip"
        Me.txtSlip.Size = New System.Drawing.Size(260, 454)
        Me.txtSlip.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblEmpName, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBasicSalary, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtEmpName, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblBasicSalary, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 33)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.07692!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.92308!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(285, 52)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'lblEmpName
        '
        Me.lblEmpName.AutoSize = True
        Me.lblEmpName.Location = New System.Drawing.Point(3, 0)
        Me.lblEmpName.Name = "lblEmpName"
        Me.lblEmpName.Size = New System.Drawing.Size(60, 13)
        Me.lblEmpName.TabIndex = 0
        Me.lblEmpName.Text = "Emp_name"
        '
        'txtBasicSalary
        '
        Me.txtBasicSalary.Location = New System.Drawing.Point(145, 27)
        Me.txtBasicSalary.Name = "txtBasicSalary"
        Me.txtBasicSalary.Size = New System.Drawing.Size(137, 20)
        Me.txtBasicSalary.TabIndex = 3
        '
        'txtEmpName
        '
        Me.txtEmpName.Location = New System.Drawing.Point(145, 3)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(137, 20)
        Me.txtEmpName.TabIndex = 2
        '
        'lblBasicSalary
        '
        Me.lblBasicSalary.AutoSize = True
        Me.lblBasicSalary.Location = New System.Drawing.Point(3, 24)
        Me.lblBasicSalary.Name = "lblBasicSalary"
        Me.lblBasicSalary.Size = New System.Drawing.Size(63, 13)
        Me.lblBasicSalary.TabIndex = 1
        Me.lblBasicSalary.Text = "Basic salary"
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.26389!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.73611!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.btnProcessData, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.btnClose, 1, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(12, 456)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(610, 39)
        Me.TableLayoutPanel7.TabIndex = 2
        '
        'btnProcessData
        '
        Me.btnProcessData.Location = New System.Drawing.Point(3, 3)
        Me.btnProcessData.Name = "btnProcessData"
        Me.btnProcessData.Size = New System.Drawing.Size(133, 33)
        Me.btnProcessData.TabIndex = 0
        Me.btnProcessData.Text = "Process data"
        Me.btnProcessData.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(146, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(143, 33)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 520)
        Me.Controls.Add(Me.TableLayoutPanel7)
        Me.Controls.Add(Me.grpDeductions)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.grpRemunerations)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grpIncome)
        Me.Controls.Add(Me.grpPaySlip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "TOM'S PAYROLL"
        Me.grpRemunerations.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.grpDeductions.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.grpPersonalDetails.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.grpJobDetails.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        Me.grpIncome.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpPaySlip.ResumeLayout(False)
        Me.grpPaySlip.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpRemunerations As GroupBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents lblOvertimeHrs As Label
    Friend WithEvents txtLeaveAllowance As TextBox
    Friend WithEvents txtOvertimeHrs As TextBox
    Friend WithEvents lblLeaveAllowance As Label
    Friend WithEvents lblHouseAllowance As Label
    Friend WithEvents lblTotalRemunerations As Label
    Friend WithEvents txtHouseAllowance As TextBox
    Friend WithEvents txtTotalRemunerations As TextBox
    Friend WithEvents grpDeductions As GroupBox
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents txtAdvance As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents lblAdvance As Label
    Friend WithEvents lblNssf As Label
    Friend WithEvents lblNhif As Label
    Friend WithEvents txtNssf As TextBox
    Friend WithEvents lblTotalDeductions As Label
    Friend WithEvents txtNhif As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents grpPersonalDetails As GroupBox
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents lblMaritalStatus As Label
    Friend WithEvents lblSex As Label
    Friend WithEvents grpJobDetails As GroupBox
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents lblTookLeave As Label
    Friend WithEvents lblTookAdvance As Label
    Friend WithEvents lblWorkedOvertime As Label
    Friend WithEvents chkTookLeave As CheckBox
    Friend WithEvents chkTookAdvance As CheckBox
    Friend WithEvents chkWorkedOvertime As CheckBox
    Friend WithEvents grpIncome As GroupBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblNetSalaryInKsh As Label
    Friend WithEvents txtNetSalaryInKsh As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents grpPaySlip As GroupBox
    Friend WithEvents txtSlip As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lblEmpName As Label
    Friend WithEvents txtBasicSalary As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents lblBasicSalary As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents btnProcessData As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents cboMaritalStatus As ComboBox
    Friend WithEvents cboSex As ComboBox
    Friend WithEvents cboTookLeave As ComboBox
    Friend WithEvents cboTookAdvance As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
