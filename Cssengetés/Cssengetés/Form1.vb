Public Class Form1

    Declare Function Beep Lib "kernel32.dll" Alias "Beep" (
                                                          ByVal dwFrew As UInt32,
                                                          ByVal dwDuration As UInt32
                                                          ) As Boolean


    Dim csengek(19) As cseng
    Dim jelzo_ = 5
    Dim jelzovan_ = True
    Dim erosito_ = 7
    Dim erositovan_ = True
    Dim besound, jesound, kisound As String
    Dim stopall_ = False
    Dim ringWe_ = False
    Dim zenehossz_ = 5

    'PROPERTIES

    Property stopall As Boolean
        Get
            Return stopall_
        End Get
        Set(value As Boolean)
            SzünetVanToolStripMenuItem.Checked = value
            stopall_ = value
        End Set
    End Property

    Property ringWe As Boolean
        Get
            Return ringWe_
        End Get
        Set(value As Boolean)
            HétvégiCsengetésToolStripMenuItem.Checked = value
            ringWe_ = value
        End Set
    End Property

    Property zenehossz As Double
        Get
            Return zenehossz_
        End Get
        Set(value As Double)
            zenehossz_ = value
            ToolStripTextBoxZenehosszMp.Text = value
        End Set
    End Property

    Property erositovan As Boolean
        Get
            Return erositovan_
        End Get
        Set(value As Boolean)
            erositovan_ = value
            ErősítőToolStripMenuItem.Checked = value
        End Set
    End Property

    Property erosito As Integer
        Get
            Return erosito_
        End Get
        Set(value As Integer)
            erosito_ = value
            ToolStripTextBoxErositoMp.Text = value
        End Set
    End Property

    Property jelzo As Integer
        Get
            Return jelzo_
        End Get
        Set(value As Integer)
            jelzo_ = value
            ToolStripTextBoxJelzoperc.Text = value
        End Set
    End Property

    Property jelzovan As Boolean
        Get
            Return jelzovan_
        End Get
        Set(value As Boolean)
            jelzovan_ = value
            JelzőToolStripMenuItem.Checked = value
        End Set
    End Property


    'LOAD / main stuff

    Sub Main() Handles MyBase.Load

        For k = 0 To 9
            Dim be = New cseng With {.ki = False}
            be.add(tabl.Controls)
            csengek(k * 2) = be

            Dim ki = New cseng With {.ki = True}
            ki.add(tabl.Controls)
            csengek(k * 2 + 1) = ki

            tabl.Controls.Add(New Label With {.Text = k.ToString + ". Óra", .Dock = DockStyle.Fill, .AutoSize = False, .TextAlign = ContentAlignment.MiddleCenter})
        Next



    End Sub

    Class cseng

        Public csekk As New CheckBox With {.Checked = True}
        Public ora As New NumericUpDown With {.Width = 40, .Minimum = 0, .Maximum = 23}
        Public perc As New NumericUpDown With {.Width = 40, .Minimum = 0, .Maximum = 59}
        Public ki As Boolean

        Property ido() As Integer
            Get
                Return perc.Value + 60 * ora.Value
            End Get
            Set(value As Integer)
                ora.Value = Int(value / 60)
                perc.Value = value Mod 60
            End Set
        End Property

        Sub add(ctls As TableLayoutControlCollection)
            ctls.Add(csekk)
            ctls.Add(ora)
            ctls.Add(perc)
        End Sub

    End Class

    'FILE HANDLING

    Sub update_sounds()
        ToolStripTextBoxBeDisplay.Text = "Becsengő: " + getFilenameFromPath(besound)
        ToolStripTextBoxjedisplay.Text = "Jelzőcsengő: " + getFilenameFromPath(jesound)
        ToolStripTextBoxkidisplay.Text = "Kicsengő: " + getFilenameFromPath(kisound)
    End Sub

    Function getFilenameFromPath(path As String) As String
        If path Is Nothing Then Return ""
        Dim asd = path.Split("\")
        Return asd(asd.Length - 1)
    End Function

    Function browse_sound(type As String) As DialogResult
        Browser.FileName = ""
        Browser.Title = "Válassz " + type + "!"

        Return Browser.ShowDialog()
    End Function

    Sub browse_besound() Handles BecsengőToolStripMenuItem.Click
        If browse_sound("becsengőhangot") = DialogResult.OK Then besound = Browser.FileName
        update_sounds()
    End Sub

    Sub browse_jelszound() Handles JelzőToolStripMenuItem1.Click
        If browse_sound("jezőcsengőhangot") = DialogResult.OK Then jesound = Browser.FileName
        update_sounds()
    End Sub

    Sub browse_kisound() Handles KicsengőToolStripMenuItem.Click
        If browse_sound("kicsengőhangot") = DialogResult.OK Then kisound = Browser.FileName
        update_sounds()
    End Sub

    '    profiles

    Sub load_handler() Handles BetöltToolStripMenuItem.Click
        load_from_file("save.xml")
    End Sub

    Sub save_handler() Handles MentToolStripMenuItem.Click
        save_to_file("save.xml")
    End Sub

    Sub default_handler() Handles AlapállásToolStripMenuItem.Click
        load_from_file("default.xml")
    End Sub

    Sub defaultshort_handler() Handles RövidítettToolStripMenuItem.Click
        load_from_file("defaultshort.xml")
    End Sub

    Class save
        Public idok(19) As Integer
        Public enabled(19) As Boolean
        Public besound, kisound, jelzosound As String
        Public vanjelzo, vanerosito As Boolean
        Public jelzo, erosito As Integer
        Public zenehossz As Double
    End Class

    Sub load_from_file(filename As String)
        Dim r As New IO.StreamReader(filename)
        Dim filesave As New save
        Dim x As New Xml.Serialization.XmlSerializer(filesave.GetType)
        filesave = x.Deserialize(r)

        besound = filesave.besound
        kisound = filesave.kisound
        jesound = filesave.jelzosound

        jelzo = filesave.jelzo
        jelzovan = filesave.vanjelzo
        erosito = filesave.erosito
        erositovan = filesave.vanerosito
        zenehossz = filesave.zenehossz

        For k = 0 To 19
            Dim elem = csengek(k)
            elem.ido = filesave.idok(k)
            elem.csekk.Checked = filesave.enabled(k)
        Next

        r.Close()

        update_sounds()
    End Sub

    Sub save_to_file(filename As String)
        Dim writer As New IO.StreamWriter(filename)
        Dim filesave As New save

        filesave.besound = besound
        filesave.kisound = kisound
        filesave.jelzosound = jesound

        filesave.jelzo = jelzo
        filesave.vanjelzo = jelzovan
        filesave.erosito = erosito
        filesave.vanerosito = erositovan
        filesave.zenehossz = zenehossz


        For k = 0 To 19
            Dim elem = csengek(k)
            filesave.enabled(k) = elem.csekk.Checked
            filesave.idok(k) = elem.ido
        Next

        Dim x As New Xml.Serialization.XmlSerializer(filesave.GetType)
        x.Serialize(writer, filesave)
        writer.Close()
    End Sub


    Public last_perc

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim now = DateTime.Now
        MyTime.Value = now
        Dim timeinmins = now.Hour * 60 + now.Minute
        If Not last_perc = timeinmins Then
            last_perc = timeinmins
            If Not stopall And (ringWe Or Not (now.DayOfWeek = DayOfWeek.Sunday Or now.DayOfWeek = DayOfWeek.Saturday)) Then
                For Each cseng In csengek
                    If cseng.ido = timeinmins Then
                        csenges(If(cseng.ki, kisound, besound))
                    End If
                    If jelzovan And cseng.ki And cseng.ido - jelzo = timeinmins Then
                        csenges(jesound)
                    End If
                Next
            End If
        End If
    End Sub

    Sub csenges(path As String)
        Dim thread As New Threading.Thread(AddressOf csenges_worker)
        thread.Start(path)
    End Sub

    Sub csenges_worker(path As String)
        Dim thread As New Threading.Thread(Sub()
                                               Beep(444, erosito * 1000 + zenehossz * 1000)
                                           End Sub)

        'If erositovan Then Beep(444, erosito * 1000)

        thread.Start()

        Threading.Thread.Sleep(erosito * 1000)


        Try
            My.Computer.Audio.Play(path, AudioPlayMode.WaitToComplete)
        Catch ex As InvalidOperationException
            MessageBox.Show("Nem .wav formátumú / hibás a fájl!")
        Catch ex As ArgumentNullException
            MessageBox.Show("Nincs fájl megadva!")
        Catch ex As IO.FileNotFoundException
            MessageBox.Show("Nem létezik a megadott fájl!")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


        thread.Abort()

    End Sub

    Private Sub ButtonRingStart_Click(sender As Object, e As EventArgs) Handles ButtonRingStart.Click
        csenges(besound)
    End Sub

    Private Sub ButtonRingStop_Click(sender As Object, e As EventArgs) Handles ButtonRingStop.Click
        My.Computer.Audio.Stop()
    End Sub

    Private Sub SzünetVanToolStripMenuItem_Click(sender As ToolStripMenuItem, e As EventArgs) Handles SzünetVanToolStripMenuItem.Click
        stopall = sender.Checked
    End Sub

    Private Sub HétvégiCsengetésToolStripMenuItem_Click(sender As ToolStripMenuItem, e As EventArgs) Handles HétvégiCsengetésToolStripMenuItem.Click
        ringWe = sender.Checked
    End Sub

    Private Sub ButtonFire_Click(sender As Object, e As EventArgs) Handles ButtonFire.Click
        csenges("fire.wav")
    End Sub

    Private Sub ToolStripTextBoxZenehosszMp_Click(sender As Object, e As EventArgs) Handles ToolStripTextBoxZenehosszMp.Click, ToolStripTextBoxZenehosszMp.LostFocus
        zenehossz = sender.text
    End Sub

    Private Sub JelzoCheck(sender As Object, e As EventArgs) Handles JelzőToolStripMenuItem.Click, ToolStripTextBoxJelzoperc.LostFocus
        jelzovan = JelzőToolStripMenuItem.Checked
        jelzo = ToolStripTextBoxJelzoperc.Text
    End Sub

    Private Sub ErositoCheck(sender As Object, e As EventArgs) Handles ErősítőToolStripMenuItem.Click, ToolStripTextBoxErositoMp.LostFocus
        erositovan = ErősítőToolStripMenuItem.Checked
        erosito = ToolStripTextBoxErositoMp.Text
    End Sub

End Class