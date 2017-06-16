Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim wh As Integer
        Dim position As String
        Dim salary As Integer
        Dim overtime As Integer
        wh = CInt(TextBox1.Text)
        position = TextBox1.Text
        If (wh < 5) Then
            salary = wh * 100
        Else
            salary = wh * 110
            If (wh > 70) Then
                If (position = "A") Then
                    overtime = (wh - 70) * 50
                ElseIf (position = "B") Then
                    overtime = (wh - 70) * 60
                Else
                    overtime = (wh - 70) * 70
                End If
                TextBox3.Text = overtime
            End If


            
        End If
        TextBox4.Text = salary

    End Sub
End Class
