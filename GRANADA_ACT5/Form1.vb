Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Txttwo.TextChanged

    End Sub

    Private Sub DIVIDE_Click(sender As Object, e As EventArgs) Handles DIVIDE.Click
        If Txtone.Text = "" Or Txttwo.Text = "" Then
            MessageBox.Show("Please complete the entry first!")
        Else
            Try
                Dim a, b As Integer
                a = Txtone.Text
                b = Txttwo.Text
                rstdivide.Text = a / b


            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
        End If


    End Sub
End Class
