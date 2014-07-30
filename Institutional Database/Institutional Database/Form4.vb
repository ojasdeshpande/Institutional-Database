Public Class Form4

    'Back button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show() 'show previous form and
        Me.Close()   'close this form
    End Sub
    'Start Slide Show
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form7.Show() 'management institutes slideshow
        Me.Close()
    End Sub
    'Compare
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form8.Show() 'management institutes comparison mode
        Me.Close()
    End Sub
End Class