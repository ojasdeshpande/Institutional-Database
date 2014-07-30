Public Class Form6
    Dim inst As New ArrayList() 'stores institute names
    Dim info As New ArrayList() 'stores institute information
    Dim add As New ArrayList()  'stores institute location
    Dim web As New ArrayList()  'stores institute website link
    Dim a As Integer 'used to store the index of combobox1
    Dim b As Integer 'used to store the index of combobox2
    Dim j As Integer = 0
    Dim choice As String
    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'stores institute names in inst array
        Dim FILE_NAME1 As String =
"C:\Users\Admin\Documents\inst.txt"
        If System.IO.File.Exists(FILE_NAME1) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME1)
            While objReader.Peek() <> -1
                choice = objReader.ReadLine()
                inst.Add(choice)
                Me.ComboBox1.Items.Add(choice) 'populates combobox1
                Me.ComboBox2.Items.Add(choice) 'populates combobox2
                j = j + 1
            End While
        End If
        'stores institute information in info array
        Dim FILE_NAME2 As String =
"C:\Users\Admin\Documents\info.txt"
        If System.IO.File.Exists(FILE_NAME2) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME2)
            While objReader.Peek() <> -1
                choice = objReader.ReadLine()
                info.Add(choice)
            End While
        End If
        'stores institute address in add array
        Dim FILE_NAME3 As String =
"C:\Users\Admin\Documents\cont.txt"
        If System.IO.File.Exists(FILE_NAME3) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME3)
            While objReader.Peek() <> -1
                choice = objReader.ReadLine()
                add.Add(choice)
            End While
        End If
        'stores institute website links in web array
        Dim FILE_NAME4 As String =
"C:\Users\Admin\Documents\link.txt"
        If System.IO.File.Exists(FILE_NAME4) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME4)
            While objReader.Peek() <> -1
                choice = objReader.ReadLine()
                Web.Add(choice)
            End While
        End If
    End Sub
    'back button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Close()
    End Sub
    ' stores combobox1's selected index in a
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        a = ComboBox1.SelectedIndex + 1
    End Sub
    ' if both comboboxes are selected and compare button in hit then loads the images in respective pictureboxes
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (a > 0 And b > 0 And a = b) Then
            PictureBox1.Image = Nothing
            PictureBox2.Image = Nothing
            MessageBox.Show("Choose two different institutes to compare!") 'if both institutes are same message is displayed
        ElseIf (a > 0 And b > 0) Then 'else loads the respective stats in the pictureboxes
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & a)
            PictureBox2.Image = My.Resources.ResourceManager.GetObject("img" & b)
        End If
    End Sub
    'This function handles the Keydown event
    Dim bHandled As Boolean
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            'if Enter key is pressed, follow the same procedure as when the compare button is hit
            Case Keys.Enter
                If (a > 0 And b > 0 And a = b) Then
                    PictureBox1.Image = Nothing
                    PictureBox2.Image = Nothing
                    MessageBox.Show("Choose two different institutes to compare!")
                ElseIf (a > 0 And b > 0) Then
                    PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & a)
                    PictureBox2.Image = My.Resources.ResourceManager.GetObject("img" & b)
                End If
        End Select
        Return bHandled
    End Function
    ' stores combobox2's selected index in b
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        b = ComboBox2.SelectedIndex + 1
    End Sub
End Class