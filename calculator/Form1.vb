Public Class frmcalculator

    Private Sub btntotal_Click(sender As Object, e As EventArgs) Handles btntotal.Click
        txttotal.Text = Val(txtnum1.Text) + Val(txtnum2.Text)
    End Sub
End Class