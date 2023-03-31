Public Class Form1


    Private Sub GetRetailButton_Click(sender As Object, e As EventArgs) Handles btnGetRetail.Click
        Try
            Dim wholesaleCost As Double = Double.Parse(txtWholesale.Text)
            Dim markupPercentage As Double = Double.Parse(txtMarkup.Text)
            Dim retailPrice As Double = CalculateRetail(wholesaleCost, markupPercentage)
            txtRetailPrice.Text = retailPrice.ToString("0.00")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
