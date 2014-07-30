Public Class Form5
    Dim inst As New ArrayList() 'stores institute names
    Dim info As New ArrayList() 'stores institute information
    Dim add As New ArrayList()  'stores institute location
    Dim web As New ArrayList()  'stores institute website link
    Dim j As Integer = 0
    Dim counter As Integer 'current slide number
    Dim choice As String
    'Back button
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Form3.Show() 'show previous form and
        Me.Close() 'close this form
    End Sub
    'Pause/Play button : toggles between pause and play
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Timer1.Enabled = True Then 'if timer is enabled, then disable it
            Timer1.Enabled = False
        Else                        'else enable it back
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'stores institute names in inst array
        Dim FILE_NAME1 As String =
"C:\Users\Admin\Documents\inst.txt"
        If System.IO.File.Exists(FILE_NAME1) = True Then

            Dim objReader As New System.IO.StreamReader(FILE_NAME1)
            While objReader.Peek() <> -1
                choice = objReader.ReadLine()
                inst.Add(choice)
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
                web.Add(choice)
            End While
        End If
        'Now, load the corresponding elements in their respective containers
        'firstlt, when form loads, counter = 0 , i.e 1st slide will be shown
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & counter + 1)
        Label1.Text = inst(counter)
        Label2.Text = info(counter)
        Label3.Text = add(counter)
        LinkLabel1.Text = web(counter)
        BackgroundImage = My.Resources.ResourceManager.GetObject("bg" & counter + 1)
    End Sub
    'Previous button
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If counter = 0 Then  'check for condition if first slide
            counter = j - 1 'if yes, go to last slide
        Else
            counter = counter - 1 'if no, go to previous slide
        End If
        'load the elements of the slide
        Label1.Text = inst(counter)
        Label2.Text = info(counter)
        Label3.Text = add(counter)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & counter + 1)
        BackgroundImage = My.Resources.ResourceManager.GetObject("bg" & counter + 1)
        LinkLabel1.Text = web(counter)
    End Sub
    'Next button
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If counter = j - 1 Then 'check for condition if last slide
            counter = 0  'if yes, go to first slide
        Else
            counter = counter + 1 'if no, go to next slide
        End If
        'load the elements of the slide
        Label1.Text = inst(counter)
        Label2.Text = info(counter)
        Label3.Text = add(counter)
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & counter + 1)
        BackgroundImage = My.Resources.ResourceManager.GetObject("bg" & counter + 1)
        LinkLabel1.Text = web(counter)
    End Sub
    'This function takes care of keydown events. i.e. to control slide if the user presses arrow keys or space bar
    Dim bHandled As Boolean
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        Select Case keyData
            'if pressed key is right-arrow-key, follow same procedure as the Next button ->
            Case Keys.Right
                If counter = j - 1 Then
                    counter = 0
                Else
                    counter = counter + 1
                End If
                Label1.Text = inst(counter)
                Label2.Text = info(counter)
                Label3.Text = add(counter)
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & counter + 1)
                LinkLabel1.Text = web(counter)
                BackgroundImage = My.Resources.ResourceManager.GetObject("bg" & counter + 1)
                bHandled = True
                'if pressed key is leftarrowkey, follow the same procedure as the Previous button ->
            Case Keys.Left
                If counter = 0 Then
                    counter = j - 1
                Else
                    counter = counter - 1
                End If
                Label1.Text = inst(counter)
                Label2.Text = info(counter)
                Label3.Text = add(counter)
                PictureBox1.Image = My.Resources.ResourceManager.GetObject("img" & counter + 1)
                LinkLabel1.Text = web(counter)
                BackgroundImage = My.Resources.ResourceManager.GetObject("bg" & counter + 1)
                bHandled = True
                'if space-bar is pressed, follow the same procedure as the Pause/Play button ->
            Case Keys.Space
                If Timer1.Enabled = True Then
                    Timer1.Enabled = False
                Else
                    Timer1.Enabled = True
                End If
        End Select
        Return bHandled
    End Function
    'Timer control
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call Button1_Click(sender, e) 'on every timer click, go to the next slide, i.e., follow same procedure as the Next button
    End Sub
End Class