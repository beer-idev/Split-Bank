Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    
    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim money As Integer
        money = Val(TextBox1.Text)
        If money >= 1000 Then
            'Label2.Visible = True
            Label1.Text = "ธนาบัตรใบละ 1000 บาท เป็นจำนวน " & Math.Floor(money / 1000) & " ใบ" & vbCrLf
            money = money Mod 1000
        End If
        If money >= 500 Then
            ' Label3.Visible = True
            Label1.Text &= "ธนาบัตรใบละ 500 บาท เป็นจำนวน " & Math.Floor(money / 500) & " ใบ" & vbCrLf
            money = money Mod 500
        End If
        If money >= 100 Then
            'Label4.Visible = True
            Label1.Text &= "ธนาบัตรใบละ 100 บาท เป็นจำนวน " & Math.Floor(money / 100) & " ใบ" & vbCrLf
            money = money Mod 100
        End If
        If money >= 20 Then
            'Label5.Visible = True
            Label1.Text &= "ธนาบัตรใบละ 20 บาท เป็นจำนวน " & Math.Floor(money / 20) & " ใบ" & vbCrLf
            money = money Mod 20
        End If
        If money >= 10 Then
            'Label6.Visible = True
            Label1.Text &= "ธนาบัตรใบละ 10 บาท เป็นจำนวน " & Math.Floor(money / 10) & " ใบ" & vbCrLf
            money = money Mod 10
        End If
        If money >= 5 Then
            'Label7.Visible = True
            Label1.Text &= "เหรียญ 5 บาท เป็นจำนวน " & Math.Floor(money / 5) & " เหรียญ" & vbCrLf
            money = money Mod 5
        End If
        If money >= 1 Then
            'Label8.Visible = True
            Label1.Text &= "เหรียญ 1 บาท เป็นจำนวน " & money & " เหรียญ"
        End If
    End Sub
End Class
