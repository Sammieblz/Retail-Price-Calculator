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

    Private Function CalculateRetail(ByVal wholesaleCost As Double, ByVal markupPercentage As Double) As Double
            If wholesaleCost < 0 Or markupPercentage < 0 Then
                Throw New ArgumentException("Wholesale cost and markup percentage must not be negative.")
            End If
            Dim retailPrice As Double = wholesaleCost * (1 + markupPercentage / 100)
            Return retailPrice
        End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
