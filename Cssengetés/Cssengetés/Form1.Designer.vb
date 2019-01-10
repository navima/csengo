<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.tabl = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonFire = New System.Windows.Forms.Button()
        Me.NumericUpDownFire = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ButtonRingStop = New System.Windows.Forms.Button()
        Me.ButtonRingStart = New System.Windows.Forms.Button()
        Me.MyTime = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SzünetVanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HétvégiCsengetésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JelzőToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxJelzoperc = New System.Windows.Forms.ToolStripTextBox()
        Me.ErősítőToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBoxErositoMp = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripDropDownButton2 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.AlapállásToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RövidítettToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BetöltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripDropDownButton3 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.BecsengőToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KicsengőToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JelzőToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBoxBeDisplay = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBoxkidisplay = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBoxjedisplay = New System.Windows.Forms.ToolStripTextBox()
        Me.Browser = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.tabl.SuspendLayout()
        CType(Me.NumericUpDownFire, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabl
        '
        Me.tabl.AutoSize = True
        Me.tabl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.tabl.ColumnCount = 7
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.tabl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.tabl.Controls.Add(Me.Label4, 4, 0)
        Me.tabl.Controls.Add(Me.Label18, 6, 1)
        Me.tabl.Controls.Add(Me.Label14, 4, 1)
        Me.tabl.Controls.Add(Me.Label12, 2, 1)
        Me.tabl.Controls.Add(Me.Label1, 1, 1)
        Me.tabl.Controls.Add(Me.Label2, 5, 1)
        Me.tabl.Controls.Add(Me.Label16, 0, 0)
        Me.tabl.Controls.Add(Me.Label17, 3, 0)
        Me.tabl.Controls.Add(Me.Label19, 6, 0)
        Me.tabl.Controls.Add(Me.Label20, 0, 1)
        Me.tabl.Controls.Add(Me.Label21, 3, 1)
        Me.tabl.Controls.Add(Me.Label3, 1, 0)
        Me.tabl.Location = New System.Drawing.Point(16, 34)
        Me.tabl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tabl.Name = "tabl"
        Me.tabl.RowCount = 2
        Me.tabl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tabl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tabl.Size = New System.Drawing.Size(480, 383)
        Me.tabl.TabIndex = 0
        '
        'Label4
        '
        Me.tabl.SetColumnSpan(Me.Label4, 2)
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(223, 1)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 94
        Me.Label4.Text = "Kicsengők"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label18.Location = New System.Drawing.Point(385, 27)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 355)
        Me.Label18.TabIndex = 85
        Me.Label18.Text = "#"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label14.Location = New System.Drawing.Point(223, 27)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 355)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Óra"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label12.Location = New System.Drawing.Point(114, 27)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 355)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Perc"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(33, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 355)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Óra"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(304, 27)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 355)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Perc"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(5, 1)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 16)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = " "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(195, 1)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 16)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = " "
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(385, 1)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 16)
        Me.Label19.TabIndex = 90
        Me.Label19.Text = " "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(5, 27)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 16)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = " "
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(195, 27)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(11, 16)
        Me.Label21.TabIndex = 92
        Me.Label21.Text = " "
        '
        'Label3
        '
        Me.tabl.SetColumnSpan(Me.Label3, 2)
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(33, 1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 25)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Becsengők"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ButtonFire
        '
        Me.ButtonFire.Location = New System.Drawing.Point(504, 362)
        Me.ButtonFire.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonFire.Name = "ButtonFire"
        Me.ButtonFire.Size = New System.Drawing.Size(132, 119)
        Me.ButtonFire.TabIndex = 1
        Me.ButtonFire.Text = "Tűz!"
        Me.ButtonFire.UseVisualStyleBackColor = True
        '
        'NumericUpDownFire
        '
        Me.NumericUpDownFire.Location = New System.Drawing.Point(504, 330)
        Me.NumericUpDownFire.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NumericUpDownFire.Name = "NumericUpDownFire"
        Me.NumericUpDownFire.Size = New System.Drawing.Size(132, 22)
        Me.NumericUpDownFire.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(521, 310)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(105, 16)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Meddig van tűz?"
        '
        'ButtonRingStop
        '
        Me.ButtonRingStop.Location = New System.Drawing.Point(504, 33)
        Me.ButtonRingStop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRingStop.Name = "ButtonRingStop"
        Me.ButtonRingStop.Size = New System.Drawing.Size(132, 119)
        Me.ButtonRingStop.TabIndex = 4
        Me.ButtonRingStop.Text = "Stop!"
        Me.ButtonRingStop.UseVisualStyleBackColor = True
        '
        'ButtonRingStart
        '
        Me.ButtonRingStart.Location = New System.Drawing.Point(504, 160)
        Me.ButtonRingStart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonRingStart.Name = "ButtonRingStart"
        Me.ButtonRingStart.Size = New System.Drawing.Size(132, 119)
        Me.ButtonRingStart.TabIndex = 5
        Me.ButtonRingStart.Text = "Csengess!"
        Me.ButtonRingStart.UseVisualStyleBackColor = True
        '
        'MyTime
        '
        Me.MyTime.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.MyTime.CustomFormat = "HH:mm:ss dddd"
        Me.MyTime.Enabled = False
        Me.MyTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.MyTime.Location = New System.Drawing.Point(16, 489)
        Me.MyTime.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MyTime.Name = "MyTime"
        Me.MyTime.Size = New System.Drawing.Size(619, 38)
        Me.MyTime.TabIndex = 15
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.ToolStripDropDownButton2, Me.ToolStripDropDownButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(652, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SzünetVanToolStripMenuItem, Me.HétvégiCsengetésToolStripMenuItem, Me.JelzőToolStripMenuItem, Me.ErősítőToolStripMenuItem})
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripDropDownButton1.Text = "Beállítások"
        '
        'SzünetVanToolStripMenuItem
        '
        Me.SzünetVanToolStripMenuItem.CheckOnClick = True
        Me.SzünetVanToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.SzünetVanToolStripMenuItem.Name = "SzünetVanToolStripMenuItem"
        Me.SzünetVanToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SzünetVanToolStripMenuItem.Text = "Szünet van"
        '
        'HétvégiCsengetésToolStripMenuItem
        '
        Me.HétvégiCsengetésToolStripMenuItem.CheckOnClick = True
        Me.HétvégiCsengetésToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.HétvégiCsengetésToolStripMenuItem.Name = "HétvégiCsengetésToolStripMenuItem"
        Me.HétvégiCsengetésToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.HétvégiCsengetésToolStripMenuItem.Text = "Hétvégi Csengetés"
        '
        'JelzőToolStripMenuItem
        '
        Me.JelzőToolStripMenuItem.CheckOnClick = True
        Me.JelzőToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.JelzőToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxJelzoperc})
        Me.JelzőToolStripMenuItem.Name = "JelzőToolStripMenuItem"
        Me.JelzőToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.JelzőToolStripMenuItem.Text = "Jelző"
        '
        'ToolStripTextBoxJelzoperc
        '
        Me.ToolStripTextBoxJelzoperc.MaxLength = 2
        Me.ToolStripTextBoxJelzoperc.Name = "ToolStripTextBoxJelzoperc"
        Me.ToolStripTextBoxJelzoperc.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBoxJelzoperc.Text = "5"
        '
        'ErősítőToolStripMenuItem
        '
        Me.ErősítőToolStripMenuItem.CheckOnClick = True
        Me.ErősítőToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxErositoMp})
        Me.ErősítőToolStripMenuItem.Name = "ErősítőToolStripMenuItem"
        Me.ErősítőToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ErősítőToolStripMenuItem.Text = "Erősítő"
        '
        'ToolStripTextBoxErositoMp
        '
        Me.ToolStripTextBoxErositoMp.Name = "ToolStripTextBoxErositoMp"
        Me.ToolStripTextBoxErositoMp.Size = New System.Drawing.Size(100, 23)
        Me.ToolStripTextBoxErositoMp.Text = "7"
        '
        'ToolStripDropDownButton2
        '
        Me.ToolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlapállásToolStripMenuItem, Me.RövidítettToolStripMenuItem, Me.MentToolStripMenuItem, Me.BetöltToolStripMenuItem})
        Me.ToolStripDropDownButton2.Image = CType(resources.GetObject("ToolStripDropDownButton2.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton2.Name = "ToolStripDropDownButton2"
        Me.ToolStripDropDownButton2.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton2.Text = "Profilok"
        '
        'AlapállásToolStripMenuItem
        '
        Me.AlapállásToolStripMenuItem.Name = "AlapállásToolStripMenuItem"
        Me.AlapállásToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AlapállásToolStripMenuItem.Text = "Alapállás"
        '
        'RövidítettToolStripMenuItem
        '
        Me.RövidítettToolStripMenuItem.Name = "RövidítettToolStripMenuItem"
        Me.RövidítettToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.RövidítettToolStripMenuItem.Text = "Rövidített"
        '
        'MentToolStripMenuItem
        '
        Me.MentToolStripMenuItem.Name = "MentToolStripMenuItem"
        Me.MentToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.MentToolStripMenuItem.Text = "Ment"
        '
        'BetöltToolStripMenuItem
        '
        Me.BetöltToolStripMenuItem.Name = "BetöltToolStripMenuItem"
        Me.BetöltToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.BetöltToolStripMenuItem.Text = "Betölt"
        '
        'ToolStripDropDownButton3
        '
        Me.ToolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BecsengőToolStripMenuItem, Me.KicsengőToolStripMenuItem, Me.JelzőToolStripMenuItem1, Me.ToolStripSeparator1, Me.ToolStripTextBoxBeDisplay, Me.ToolStripTextBoxkidisplay, Me.ToolStripTextBoxjedisplay})
        Me.ToolStripDropDownButton3.Image = CType(resources.GetObject("ToolStripDropDownButton3.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton3.Name = "ToolStripDropDownButton3"
        Me.ToolStripDropDownButton3.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripDropDownButton3.Text = "Hangok"
        '
        'BecsengőToolStripMenuItem
        '
        Me.BecsengőToolStripMenuItem.Name = "BecsengőToolStripMenuItem"
        Me.BecsengőToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BecsengőToolStripMenuItem.Text = "Becsengő..."
        '
        'KicsengőToolStripMenuItem
        '
        Me.KicsengőToolStripMenuItem.Name = "KicsengőToolStripMenuItem"
        Me.KicsengőToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.KicsengőToolStripMenuItem.Text = "Kicsengő..."
        '
        'JelzőToolStripMenuItem1
        '
        Me.JelzőToolStripMenuItem1.Name = "JelzőToolStripMenuItem1"
        Me.JelzőToolStripMenuItem1.Size = New System.Drawing.Size(210, 22)
        Me.JelzőToolStripMenuItem1.Text = "Jelző..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(207, 6)
        '
        'ToolStripTextBoxBeDisplay
        '
        Me.ToolStripTextBoxBeDisplay.Enabled = False
        Me.ToolStripTextBoxBeDisplay.Name = "ToolStripTextBoxBeDisplay"
        Me.ToolStripTextBoxBeDisplay.Size = New System.Drawing.Size(150, 23)
        '
        'ToolStripTextBoxkidisplay
        '
        Me.ToolStripTextBoxkidisplay.Enabled = False
        Me.ToolStripTextBoxkidisplay.Name = "ToolStripTextBoxkidisplay"
        Me.ToolStripTextBoxkidisplay.Size = New System.Drawing.Size(150, 23)
        '
        'ToolStripTextBoxjedisplay
        '
        Me.ToolStripTextBoxjedisplay.Enabled = False
        Me.ToolStripTextBoxjedisplay.Name = "ToolStripTextBoxjedisplay"
        Me.ToolStripTextBoxjedisplay.Size = New System.Drawing.Size(150, 23)
        '
        'Browser
        '
        Me.Browser.DefaultExt = "wav"
        Me.Browser.FileName = "asd"
        Me.Browser.Filter = "Waveform files|*.wav"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 551)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MyTime)
        Me.Controls.Add(Me.ButtonRingStart)
        Me.Controls.Add(Me.ButtonRingStop)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NumericUpDownFire)
        Me.Controls.Add(Me.ButtonFire)
        Me.Controls.Add(Me.tabl)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Csengő config"
        Me.tabl.ResumeLayout(False)
        Me.tabl.PerformLayout()
        CType(Me.NumericUpDownFire, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tabl As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ButtonFire As Button
    Friend WithEvents NumericUpDownFire As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents ButtonRingStop As Button
    Friend WithEvents ButtonRingStart As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents MyTime As DateTimePicker
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents SzünetVanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HétvégiCsengetésToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JelzőToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxJelzoperc As ToolStripTextBox
    Friend WithEvents ErősítőToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripTextBoxErositoMp As ToolStripTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripDropDownButton2 As ToolStripDropDownButton
    Friend WithEvents AlapállásToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RövidítettToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BetöltToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripDropDownButton3 As ToolStripDropDownButton
    Friend WithEvents BecsengőToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KicsengőToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JelzőToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Browser As OpenFileDialog
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBoxBeDisplay As ToolStripTextBox
    Friend WithEvents ToolStripTextBoxkidisplay As ToolStripTextBox
    Friend WithEvents ToolStripTextBoxjedisplay As ToolStripTextBox
    Friend WithEvents Timer1 As Timer
End Class
