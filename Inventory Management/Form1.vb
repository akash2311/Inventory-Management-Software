Public Class Form1
    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If Len(Trim(user_txt.Text)) = 0 Then
            MessageBox.Show("Please Enter the User Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            user_txt.Focus()
            Exit Sub
        End If
        If Len(Trim(pwd_text.Text)) = 0 Then
            MessageBox.Show("Please Enter the Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            pwd_text.Focus()
            Exit Sub
        End If
        If user_txt.Text = "Admin" And pwd_text.Text = "12345" Then
            Me.Hide()
            home.Show()
            Exit Sub
        End If

        If Not user_txt.Text = "Admin" And Not pwd_text.Text = "12345" Then
            MessageBox.Show("Please Enter Correct User and Password!!", "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            user_txt.Focus()
            Exit Sub
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
