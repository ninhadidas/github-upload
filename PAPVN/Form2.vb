Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Dim b As Double
        Dim c As Double
        Dim X As Double


        a = TextBox1.Text * TextBox5.Text
        b = TextBox2.Text * TextBox6.Text
        c = TextBox3.Text * TextBox7.Text
        X = (a + b + c) / 100


        If X >= 1.45 And X <= 2.44 Then
            X = 2
        Else
            If X >= 2.45 Then
                X = 3
            Else
                If X >= 0 And X < 1.45 Then
                    X = 1
                End If
            End If
        End If
        TextBox4.Text = X
    End Sub
End Class