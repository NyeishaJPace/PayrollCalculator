Public Class Form1
    Const cdecFica As Decimal = 0.0765D
    Const cdecFed As Decimal = 0.22D
    Const cdecState As Decimal = 0.04D
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFicoPay.Text = ""
        lblFedTax.Text = ""
        lblStateT.Text = ""
        lblNetPay.Text = ""
        lblNetPay.Focus()
    End Sub

    Private Sub btnTaxCalc_Click(sender As Object, e As EventArgs) Handles btnTaxCalc.Click
        Dim strIncome As String = txtIncome.Text
        Dim decIncome As Decimal = 0
        Dim decFica As Decimal = 0
        Dim decFederal As Decimal = 0
        Dim decState As Decimal = 0
        Dim decNet As Decimal = 0

        If strIncome.Contains("$") Then
            strIncome = strIncome.Replace("$", "")

        End If

        If Decimal.TryParse(strIncome, decIncome) Then
            decFica = decIncome * cdecFica
            decFederal = decIncome * cdecFed
            decState = decIncome * cdecState
            decNet = decIncome - decFica - decFederal - decState


            lblFicoPay.Text = decFica.ToString("C2")
            lblFedTax.Text = decFederal.ToString("C2")
            lblStateT.Text = decState.ToString("C2")
            lblNetPay.Text = decNet.ToString("C2")

        Else
            MessageBox.Show("Invalid input. Please enter a valid biweekly income.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblNetPay.Text = ""
            lblNetPay.Focus()


        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFicoPay.Text = ""
        lblFedTax.Text = ""
        lblStateT.Text = ""
        lblNetPay.Text = ""
        lblNetPay.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
