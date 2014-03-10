Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "Enter" Or ComboBox1.Text = "Select" Or ComboBox2.Text = "Select") Then
            MsgBox("Please Enter Appropriate values", MsgBoxStyle.Critical, "Error")
            Return
        End If
        Try
            TextBox2.Text = TextBox1.Text.ToString + " " + ComboBox1.SelectedItem.ToString + " " + ComboBox2.SelectedItem.ToString
        Catch
            MsgBox("Please Select Values From Dromdown", MsgBoxStyle.Critical, "Error")
            Return
        End Try
        PrintForm1.Print(Me, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 1 To 100
            ComboBox1.Items.Add(index)
        Next
        ComboBox2.Items.Add("Chennai")
        ComboBox2.Items.Add("Kolkata")
        ComboBox2.Items.Add("Mumbai")
    End Sub

End Class
