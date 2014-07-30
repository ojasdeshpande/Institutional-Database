'Stream Selection Form
Public Class Form2
    'Technical
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show() 'opens technical institutions form
        Me.Close()

    End Sub
    'Management
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form4.Show() 'opens management institutions form
        Me.Close()

    End Sub
    'Exit Button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() 'Exits back to the home page
    End Sub
End Class