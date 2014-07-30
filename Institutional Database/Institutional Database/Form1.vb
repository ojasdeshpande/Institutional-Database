Public Class Form1
    'The START button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show() 'open next form
    End Sub
    'The CLOSE button
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close() 'exit application
    End Sub
End Class
