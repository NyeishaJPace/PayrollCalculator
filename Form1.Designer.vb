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
        Me.btnTaxCalc = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFicaTax = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.lblFicoPay = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateT = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnTaxCalc
        '
        Me.btnTaxCalc.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnTaxCalc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaxCalc.ForeColor = System.Drawing.Color.White
        Me.btnTaxCalc.Location = New System.Drawing.Point(113, 279)
        Me.btnTaxCalc.Name = "btnTaxCalc"
        Me.btnTaxCalc.Size = New System.Drawing.Size(104, 37)
        Me.btnTaxCalc.TabIndex = 0
        Me.btnTaxCalc.Text = "Compute Taxes"
        Me.btnTaxCalc.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(287, 279)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 37)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(468, 279)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 37)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(263, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Payroll Calculator"
        '
        'lblFicaTax
        '
        Me.lblFicaTax.AutoSize = True
        Me.lblFicaTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicaTax.Location = New System.Drawing.Point(119, 339)
        Me.lblFicaTax.Name = "lblFicaTax"
        Me.lblFicaTax.Size = New System.Drawing.Size(38, 13)
        Me.lblFicaTax.TabIndex = 4
        Me.lblFicaTax.Text = "FICA:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalTax.Location = New System.Drawing.Point(293, 339)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(78, 13)
        Me.lblFederalTax.TabIndex = 5
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.Location = New System.Drawing.Point(477, 339)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(66, 13)
        Me.lblStateTax.TabIndex = 6
        Me.lblStateTax.Text = "State Tax:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 223)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(268, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Enter Gross Pay:"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(433, 240)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(100, 20)
        Me.txtIncome.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(400, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 58)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Paycheck" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetIncome.Location = New System.Drawing.Point(156, 379)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(177, 18)
        Me.lblNetIncome.TabIndex = 11
        Me.lblNetIncome.Text = "Net Paycheck Income:"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.Location = New System.Drawing.Point(378, 381)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(57, 18)
        Me.lblNetPay.TabIndex = 12
        Me.lblNetPay.Text = "Label8"
        '
        'lblFicoPay
        '
        Me.lblFicoPay.AutoSize = True
        Me.lblFicoPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFicoPay.Location = New System.Drawing.Point(163, 338)
        Me.lblFicoPay.Name = "lblFicoPay"
        Me.lblFicoPay.Size = New System.Drawing.Size(45, 13)
        Me.lblFicoPay.TabIndex = 13
        Me.lblFicoPay.Text = "Label2"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.Location = New System.Drawing.Point(378, 338)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(45, 13)
        Me.lblFedTax.TabIndex = 14
        Me.lblFedTax.Text = "Label3"
        '
        'lblStateT
        '
        Me.lblStateT.AutoSize = True
        Me.lblStateT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateT.Location = New System.Drawing.Point(549, 338)
        Me.lblStateT.Name = "lblStateT"
        Me.lblStateT.Size = New System.Drawing.Size(45, 13)
        Me.lblStateT.TabIndex = 15
        Me.lblStateT.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 450)
        Me.Controls.Add(Me.lblStateT)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFicoPay)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFicaTax)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnTaxCalc)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnTaxCalc As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFicaTax As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents lblFicoPay As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateT As Label
End Class
