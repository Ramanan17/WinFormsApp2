Public Class Form1
    Public c As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Calculate.Click
        Dim grosspay As Single
        Dim hourrate As Single
        Dim rateofpay As Single
        Dim tax As Single
        grosspay = Val(TextBox1.Text) * (TextBox2.Text)
        If grosspay <= 199 Then
            tax = 0
        ElseIf grosspay > 199 And grosspay < 500 Then
            tax = 0.05
        ElseIf grosspay >= 500 Then
            tax = 0.08
        End If
        TextBox3.Text = grosspay - (grosspay * tax)


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label4.Text = ""
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Count_Click(sender As Object, e As EventArgs) Handles Count.Click
        c = c + 1
        ListBox1.Items.Add(c)
    End Sub


End Class
