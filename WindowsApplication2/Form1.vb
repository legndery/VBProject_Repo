Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim value, copy, rim, sum As Integer
        value = CInt(TextBox1.Text)
        copy = value
        rim = 0
        sum = 0
        While copy > 0
            rim = copy Mod 10
            sum += rim ^ 3
            copy -= rim
            copy = copy \ 10
        End While
        If sum = value Then
            MsgBox(CStr(value) + " is an armstrong Number", MsgBoxStyle.Information, "Alert")
        Else
            MsgBox(CStr(value) + " is not an armstrong Number", MsgBoxStyle.Critical, "Error")
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        Dim startD, stopD As Integer
        startD = CInt(TextBox2.Text)
        stopD = CInt(TextBox3.Text)

        For index = startD To stopD
            Dim copy, rim, sum As Integer
            copy = index
            sum = 0
            While copy > 0
                rim = copy Mod 10
                sum += rim ^ 3
                copy -= rim
                copy = copy \ 10
            End While
            If index = sum Then
                ListBox1.Items.Add(index)
            End If

        Next

    End Sub
End Class
