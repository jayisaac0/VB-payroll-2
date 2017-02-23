Public Class Form1
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles txtSlip.TextChanged

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to close?") = MsgBoxResult.Ok Then Close()
    End Sub

    Private Sub btnProcessData_Click(sender As Object, e As EventArgs) Handles btnProcessData.Click
        Dim empName As String
        Dim basicSalary As Double
        Dim netSalaryInKsh As Double
        Dim tax As Double
        Dim advance As Double
        Dim nssf As Double
        Dim nhif As Double
        Dim totalDeductions As Double
        Dim overtimeHrs As Integer
        Dim leaveAllowance As Double
        Dim houseAllowance As Double
        Dim totalRemunerations As Double

        empName = Val(txtEmpName.Text)
        basicSalary = Val(txtBasicSalary.Text)
        netSalaryInKsh = Val(txtNetSalaryInKsh.Text)
        tax = Val(txtTax.Text)
        advance = Val(txtAdvance.Text)
        nssf = Val(txtNssf.Text)
        nhif = Val(txtNhif.Text)
        totalDeductions = Val(txtTotalDeductions.Text)
        overtimeHrs = Val(txtOvertimeHrs.Text)
        leaveAllowance = Val(txtLeaveAllowance.Text)
        houseAllowance = Val(txtHouseAllowance.Text)
        totalRemunerations = Val(txtTotalRemunerations.Text)

        If cboTookAdvance.SelectedItem = "25% basic salary" Then advance = (0.25 * basicSalary)
        txtAdvance.Text = advance
        If cboTookAdvance.SelectedItem = "50% basic salary" Then advance = (0.5 * basicSalary)
        txtAdvance.Text = advance

        totalDeductions = (tax + advance + nhif + nssf)
        txtTotalDeductions.Text = totalDeductions

        totalRemunerations = (100 * overtimeHrs) + leaveAllowance + houseAllowance
        txtTotalRemunerations.Text = totalRemunerations

        If cboTookLeave.SelectedItem = "Annual allowance" Then leaveAllowance = 3500
        txtLeaveAllowance.Text = leaveAllowance
        If cboTookLeave.SelectedItem = "House allowance" Then leaveAllowance = 7000
        txtLeaveAllowance.Text = leaveAllowance

        netSalaryInKsh = (basicSalary - totalDeductions) + totalRemunerations
        txtNetSalaryInKsh.Text = netSalaryInKsh

        houseAllowance = 7000
        txtHouseAllowance.Text = houseAllowance


        txtSlip.Text = ""
        txtSlip.AppendText("" + vbNewLine)

        txtSlip.AppendText("INFOTECH SYSTEMS SERVICE" + vbNewLine)
        txtSlip.AppendText("PAYSLIP" + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("Pay date: " + vbTab + vbTab & DateTimePicker1.Value + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("==========================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText("Personal details: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("NAME: " + vbTab + vbTab + vbTab & txtEmpName.Text + vbNewLine)
        txtSlip.AppendText("MARITAL STATUS: " + vbTab & cboMaritalStatus.Text + vbNewLine)
        txtSlip.AppendText("SEX: " + vbTab + vbTab + vbTab & cboSex.Text + vbNewLine)
        txtSlip.AppendText("LEAVE: " + vbTab + vbTab + vbTab & cboTookLeave.Text + vbNewLine)

        txtSlip.AppendText("==========================================" + vbNewLine)
        txtSlip.AppendText(vbNewLine)
        txtSlip.AppendText("BASIC SALARY: " + vbTab + vbTab & txtBasicSalary.Text + vbNewLine)
        txtSlip.AppendText("REMUNERATIONS: " + vbTab & txtTotalRemunerations.Text + vbNewLine)
        txtSlip.AppendText("GROSS PAY: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("DEDUCTIONS: " + vbNewLine)
        txtSlip.AppendText(vbNewLine)

        txtSlip.AppendText("Tax: " + vbTab + vbTab + vbTab & txtTax.Text + vbNewLine)
        txtSlip.AppendText("Advance: " + vbTab + vbTab & txtAdvance.Text + vbNewLine)
        txtSlip.AppendText("NSSF: " + vbTab + vbTab + vbTab & txtNssf.Text + vbNewLine)
        txtSlip.AppendText("NHIF: " + vbTab + vbTab + vbTab & txtNhif.Text + vbNewLine)
        txtSlip.AppendText("TOTAL DEDUCTIONS: " + vbTab & txtTotalDeductions.Text + vbNewLine)

        txtSlip.AppendText("==========================================" + vbNewLine)
        txtSlip.AppendText("NET SALARY IN KSH: " + vbTab & txtNetSalaryInKsh.Text + vbNewLine)

        txtSlip.AppendText("==========================================" + vbNewLine)


        txtSlip.AppendText("Compiled by: Infotech systems " + vbNewLine)




    End Sub

    Private Sub chkTookLeave_CheckedChanged(sender As Object, e As EventArgs) Handles chkTookLeave.CheckedChanged
        If chkTookLeave.Checked = True Then
            cboTookLeave.Enabled = True
        Else
            cboTookLeave.Enabled = False
        End If
    End Sub

    Private Sub chkTookAdvance_CheckedChanged(sender As Object, e As EventArgs) Handles chkTookAdvance.CheckedChanged
        If chkTookAdvance.Checked = True Then
            cboTookAdvance.Enabled = True
        Else
            cboTookAdvance.Enabled = False
        End If
    End Sub

    Private Sub chkWorkedOvertime_CheckedChanged(sender As Object, e As EventArgs) Handles chkWorkedOvertime.CheckedChanged
        If chkWorkedOvertime.Checked = True Then
            txtOvertimeHrs.Enabled = True
        Else
            txtOvertimeHrs.Enabled = False
        End If
    End Sub
End Class
