<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.shootTimer = New System.Windows.Forms.Timer(Me.components)
        Me.duck3 = New System.Windows.Forms.PictureBox()
        Me.shot3 = New System.Windows.Forms.PictureBox()
        Me.shot2 = New System.Windows.Forms.PictureBox()
        Me.shot1 = New System.Windows.Forms.PictureBox()
        Me.shot0 = New System.Windows.Forms.PictureBox()
        Me.reload3 = New System.Windows.Forms.PictureBox()
        Me.reload2 = New System.Windows.Forms.PictureBox()
        Me.reload1 = New System.Windows.Forms.PictureBox()
        Me.gun1 = New System.Windows.Forms.PictureBox()
        Me.duck2 = New System.Windows.Forms.PictureBox()
        Me.field = New System.Windows.Forms.PictureBox()
        Me.duck1 = New System.Windows.Forms.PictureBox()
        Me.duck4 = New System.Windows.Forms.PictureBox()
        Me.duck5 = New System.Windows.Forms.PictureBox()
        Me.duck6 = New System.Windows.Forms.PictureBox()
        Me.duckfall = New System.Windows.Forms.PictureBox()
        Me.hit = New System.Windows.Forms.PictureBox()
        Me.duckanimation = New System.Windows.Forms.Timer(Me.components)
        Me.duck = New System.Windows.Forms.PictureBox()
        Me.moveDuck = New System.Windows.Forms.Timer(Me.components)
        Me.duckFallTimer = New System.Windows.Forms.Timer(Me.components)
        Me.goalOg = New System.Windows.Forms.PictureBox()
        Me.lblLevelUp = New System.Windows.Forms.Label()
        Me.duckLeft = New System.Windows.Forms.PictureBox()
        Me.duckLeft1 = New System.Windows.Forms.PictureBox()
        Me.duckLeft2 = New System.Windows.Forms.PictureBox()
        Me.duckLeft3 = New System.Windows.Forms.PictureBox()
        Me.duckLeft4 = New System.Windows.Forms.PictureBox()
        Me.duckLeft5 = New System.Windows.Forms.PictureBox()
        Me.duckLeft6 = New System.Windows.Forms.PictureBox()
        Me.duckFallLeft = New System.Windows.Forms.PictureBox()
        Me.duckHitLeft = New System.Windows.Forms.PictureBox()
        Me.duckLeftAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.moveLeftDuck = New System.Windows.Forms.Timer(Me.components)
        Me.duckFallLeftTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblStart = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.shotMiss = New System.Windows.Forms.PictureBox()
        Me.hideMissShot = New System.Windows.Forms.Timer(Me.components)
        CType(Me.duck3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shot0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reload3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reload2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.reload1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.field, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckfall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.goalOg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckLeft6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckFallLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.duckHitLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.shotMiss, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'shootTimer
        '
        '
        'duck3
        '
        Me.duck3.BackColor = System.Drawing.Color.Transparent
        Me.duck3.Image = Global.duckHunt.My.Resources.Resources.duck3
        Me.duck3.Location = New System.Drawing.Point(577, 236)
        Me.duck3.Name = "duck3"
        Me.duck3.Size = New System.Drawing.Size(55, 53)
        Me.duck3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duck3.TabIndex = 9
        Me.duck3.TabStop = False
        Me.duck3.Visible = False
        '
        'shot3
        '
        Me.shot3.BackColor = System.Drawing.Color.Transparent
        Me.shot3.Image = Global.duckHunt.My.Resources.Resources.shot3
        Me.shot3.Location = New System.Drawing.Point(516, 295)
        Me.shot3.Name = "shot3"
        Me.shot3.Size = New System.Drawing.Size(116, 95)
        Me.shot3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shot3.TabIndex = 8
        Me.shot3.TabStop = False
        Me.shot3.Visible = False
        '
        'shot2
        '
        Me.shot2.BackColor = System.Drawing.Color.Transparent
        Me.shot2.Image = Global.duckHunt.My.Resources.Resources.shot2
        Me.shot2.Location = New System.Drawing.Point(404, 295)
        Me.shot2.Name = "shot2"
        Me.shot2.Size = New System.Drawing.Size(115, 95)
        Me.shot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shot2.TabIndex = 7
        Me.shot2.TabStop = False
        Me.shot2.Visible = False
        '
        'shot1
        '
        Me.shot1.BackColor = System.Drawing.Color.Transparent
        Me.shot1.Image = Global.duckHunt.My.Resources.Resources.shot1
        Me.shot1.Location = New System.Drawing.Point(296, 295)
        Me.shot1.Name = "shot1"
        Me.shot1.Size = New System.Drawing.Size(115, 95)
        Me.shot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shot1.TabIndex = 6
        Me.shot1.TabStop = False
        Me.shot1.Visible = False
        '
        'shot0
        '
        Me.shot0.BackColor = System.Drawing.Color.Transparent
        Me.shot0.Image = Global.duckHunt.My.Resources.Resources.shot0
        Me.shot0.Location = New System.Drawing.Point(184, 295)
        Me.shot0.Name = "shot0"
        Me.shot0.Size = New System.Drawing.Size(115, 95)
        Me.shot0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shot0.TabIndex = 5
        Me.shot0.TabStop = False
        Me.shot0.Visible = False
        '
        'reload3
        '
        Me.reload3.BackColor = System.Drawing.Color.Transparent
        Me.reload3.Image = Global.duckHunt.My.Resources.Resources.reload3
        Me.reload3.Location = New System.Drawing.Point(404, 386)
        Me.reload3.Name = "reload3"
        Me.reload3.Size = New System.Drawing.Size(115, 95)
        Me.reload3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reload3.TabIndex = 4
        Me.reload3.TabStop = False
        Me.reload3.Visible = False
        '
        'reload2
        '
        Me.reload2.BackColor = System.Drawing.Color.Transparent
        Me.reload2.Image = Global.duckHunt.My.Resources.Resources.reload2
        Me.reload2.Location = New System.Drawing.Point(296, 386)
        Me.reload2.Name = "reload2"
        Me.reload2.Size = New System.Drawing.Size(115, 95)
        Me.reload2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reload2.TabIndex = 3
        Me.reload2.TabStop = False
        Me.reload2.Visible = False
        '
        'reload1
        '
        Me.reload1.BackColor = System.Drawing.Color.Transparent
        Me.reload1.Image = Global.duckHunt.My.Resources.Resources.reload
        Me.reload1.Location = New System.Drawing.Point(184, 386)
        Me.reload1.Name = "reload1"
        Me.reload1.Size = New System.Drawing.Size(115, 95)
        Me.reload1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.reload1.TabIndex = 2
        Me.reload1.TabStop = False
        Me.reload1.Visible = False
        '
        'gun1
        '
        Me.gun1.BackColor = System.Drawing.Color.Transparent
        Me.gun1.Image = Global.duckHunt.My.Resources.Resources.Doom
        Me.gun1.Location = New System.Drawing.Point(0, 396)
        Me.gun1.Name = "gun1"
        Me.gun1.Size = New System.Drawing.Size(115, 95)
        Me.gun1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gun1.TabIndex = 1
        Me.gun1.TabStop = False
        '
        'duck2
        '
        Me.duck2.BackColor = System.Drawing.Color.Transparent
        Me.duck2.Image = Global.duckHunt.My.Resources.Resources.Duck2
        Me.duck2.Location = New System.Drawing.Point(577, 177)
        Me.duck2.Name = "duck2"
        Me.duck2.Size = New System.Drawing.Size(55, 53)
        Me.duck2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duck2.TabIndex = 10
        Me.duck2.TabStop = False
        Me.duck2.Visible = False
        '
        'field
        '
        Me.field.BackColor = System.Drawing.Color.Transparent
        Me.field.Location = New System.Drawing.Point(0, 50)
        Me.field.Name = "field"
        Me.field.Size = New System.Drawing.Size(600, 311)
        Me.field.TabIndex = 11
        Me.field.TabStop = False
        '
        'duck1
        '
        Me.duck1.BackColor = System.Drawing.Color.Transparent
        Me.duck1.Image = Global.duckHunt.My.Resources.Resources.Duck1
        Me.duck1.Location = New System.Drawing.Point(577, 118)
        Me.duck1.Name = "duck1"
        Me.duck1.Size = New System.Drawing.Size(55, 53)
        Me.duck1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duck1.TabIndex = 12
        Me.duck1.TabStop = False
        Me.duck1.Visible = False
        '
        'duck4
        '
        Me.duck4.BackColor = System.Drawing.Color.Transparent
        Me.duck4.Image = Global.duckHunt.My.Resources.Resources.Duck4
        Me.duck4.Location = New System.Drawing.Point(516, 118)
        Me.duck4.Name = "duck4"
        Me.duck4.Size = New System.Drawing.Size(55, 53)
        Me.duck4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duck4.TabIndex = 13
        Me.duck4.TabStop = False
        Me.duck4.Visible = False
        '
        'duck5
        '
        Me.duck5.BackColor = System.Drawing.Color.Transparent
        Me.duck5.Image = Global.duckHunt.My.Resources.Resources.Duck5
        Me.duck5.Location = New System.Drawing.Point(516, 177)
        Me.duck5.Name = "duck5"
        Me.duck5.Size = New System.Drawing.Size(55, 53)
        Me.duck5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duck5.TabIndex = 14
        Me.duck5.TabStop = False
        Me.duck5.Visible = False
        '
        'duck6
        '
        Me.duck6.BackColor = System.Drawing.Color.Transparent
        Me.duck6.Image = Global.duckHunt.My.Resources.Resources.duck6
        Me.duck6.Location = New System.Drawing.Point(516, 236)
        Me.duck6.Name = "duck6"
        Me.duck6.Size = New System.Drawing.Size(55, 53)
        Me.duck6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duck6.TabIndex = 15
        Me.duck6.TabStop = False
        Me.duck6.Visible = False
        '
        'duckfall
        '
        Me.duckfall.BackColor = System.Drawing.Color.Transparent
        Me.duckfall.Image = Global.duckHunt.My.Resources.Resources.DuckFall
        Me.duckfall.Location = New System.Drawing.Point(454, 177)
        Me.duckfall.Name = "duckfall"
        Me.duckfall.Size = New System.Drawing.Size(55, 53)
        Me.duckfall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckfall.TabIndex = 16
        Me.duckfall.TabStop = False
        Me.duckfall.Visible = False
        '
        'hit
        '
        Me.hit.BackColor = System.Drawing.Color.Transparent
        Me.hit.Image = Global.duckHunt.My.Resources.Resources.Hit
        Me.hit.Location = New System.Drawing.Point(454, 236)
        Me.hit.Name = "hit"
        Me.hit.Size = New System.Drawing.Size(55, 53)
        Me.hit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.hit.TabIndex = 17
        Me.hit.TabStop = False
        Me.hit.Visible = False
        '
        'duckanimation
        '
        Me.duckanimation.Enabled = True
        Me.duckanimation.Interval = 110
        '
        'duck
        '
        Me.duck.BackColor = System.Drawing.Color.Transparent
        Me.duck.Image = Global.duckHunt.My.Resources.Resources.Duck1
        Me.duck.Location = New System.Drawing.Point(422, 107)
        Me.duck.Name = "duck"
        Me.duck.Size = New System.Drawing.Size(55, 53)
        Me.duck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duck.TabIndex = 18
        Me.duck.TabStop = False
        Me.duck.Visible = False
        '
        'moveDuck
        '
        Me.moveDuck.Enabled = True
        Me.moveDuck.Interval = 20
        '
        'duckFallTimer
        '
        '
        'goalOg
        '
        Me.goalOg.BackColor = System.Drawing.Color.Transparent
        Me.goalOg.Image = Global.duckHunt.My.Resources.Resources.Untitled_1
        Me.goalOg.Location = New System.Drawing.Point(184, 22)
        Me.goalOg.Name = "goalOg"
        Me.goalOg.Size = New System.Drawing.Size(25, 22)
        Me.goalOg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.goalOg.TabIndex = 19
        Me.goalOg.TabStop = False
        Me.goalOg.Visible = False
        '
        'lblLevelUp
        '
        Me.lblLevelUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblLevelUp.Font = New System.Drawing.Font("Impact", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevelUp.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblLevelUp.Location = New System.Drawing.Point(187, 177)
        Me.lblLevelUp.Name = "lblLevelUp"
        Me.lblLevelUp.Size = New System.Drawing.Size(261, 82)
        Me.lblLevelUp.TabIndex = 20
        Me.lblLevelUp.Text = "Level Up"
        Me.lblLevelUp.Visible = False
        '
        'duckLeft
        '
        Me.duckLeft.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft.Image = Global.duckHunt.My.Resources.Resources.duckLeft1
        Me.duckLeft.Location = New System.Drawing.Point(201, 107)
        Me.duckLeft.Name = "duckLeft"
        Me.duckLeft.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duckLeft.TabIndex = 21
        Me.duckLeft.TabStop = False
        Me.duckLeft.Visible = False
        '
        'duckLeft1
        '
        Me.duckLeft1.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft1.Image = Global.duckHunt.My.Resources.Resources.duckLeft1
        Me.duckLeft1.Location = New System.Drawing.Point(12, 118)
        Me.duckLeft1.Name = "duckLeft1"
        Me.duckLeft1.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duckLeft1.TabIndex = 22
        Me.duckLeft1.TabStop = False
        Me.duckLeft1.Visible = False
        '
        'duckLeft2
        '
        Me.duckLeft2.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft2.Image = Global.duckHunt.My.Resources.Resources.duckLeft2
        Me.duckLeft2.Location = New System.Drawing.Point(12, 177)
        Me.duckLeft2.Name = "duckLeft2"
        Me.duckLeft2.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckLeft2.TabIndex = 23
        Me.duckLeft2.TabStop = False
        Me.duckLeft2.Visible = False
        '
        'duckLeft3
        '
        Me.duckLeft3.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft3.Image = Global.duckHunt.My.Resources.Resources.duckLeft3
        Me.duckLeft3.Location = New System.Drawing.Point(12, 236)
        Me.duckLeft3.Name = "duckLeft3"
        Me.duckLeft3.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duckLeft3.TabIndex = 24
        Me.duckLeft3.TabStop = False
        Me.duckLeft3.Visible = False
        '
        'duckLeft4
        '
        Me.duckLeft4.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft4.Image = Global.duckHunt.My.Resources.Resources.duckLeft4
        Me.duckLeft4.Location = New System.Drawing.Point(73, 118)
        Me.duckLeft4.Name = "duckLeft4"
        Me.duckLeft4.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.duckLeft4.TabIndex = 25
        Me.duckLeft4.TabStop = False
        Me.duckLeft4.Visible = False
        '
        'duckLeft5
        '
        Me.duckLeft5.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft5.Image = Global.duckHunt.My.Resources.Resources.duckLeft5
        Me.duckLeft5.Location = New System.Drawing.Point(73, 177)
        Me.duckLeft5.Name = "duckLeft5"
        Me.duckLeft5.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckLeft5.TabIndex = 26
        Me.duckLeft5.TabStop = False
        Me.duckLeft5.Visible = False
        '
        'duckLeft6
        '
        Me.duckLeft6.BackColor = System.Drawing.Color.Transparent
        Me.duckLeft6.Image = Global.duckHunt.My.Resources.Resources.duckLeft6
        Me.duckLeft6.Location = New System.Drawing.Point(73, 236)
        Me.duckLeft6.Name = "duckLeft6"
        Me.duckLeft6.Size = New System.Drawing.Size(55, 53)
        Me.duckLeft6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckLeft6.TabIndex = 27
        Me.duckLeft6.TabStop = False
        Me.duckLeft6.Visible = False
        '
        'duckFallLeft
        '
        Me.duckFallLeft.BackColor = System.Drawing.Color.Transparent
        Me.duckFallLeft.Image = Global.duckHunt.My.Resources.Resources.DuckLeftFall
        Me.duckFallLeft.Location = New System.Drawing.Point(134, 177)
        Me.duckFallLeft.Name = "duckFallLeft"
        Me.duckFallLeft.Size = New System.Drawing.Size(55, 53)
        Me.duckFallLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckFallLeft.TabIndex = 28
        Me.duckFallLeft.TabStop = False
        Me.duckFallLeft.Visible = False
        '
        'duckHitLeft
        '
        Me.duckHitLeft.BackColor = System.Drawing.Color.Transparent
        Me.duckHitLeft.Image = Global.duckHunt.My.Resources.Resources.duckLeftHit
        Me.duckHitLeft.Location = New System.Drawing.Point(134, 236)
        Me.duckHitLeft.Name = "duckHitLeft"
        Me.duckHitLeft.Size = New System.Drawing.Size(55, 53)
        Me.duckHitLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.duckHitLeft.TabIndex = 29
        Me.duckHitLeft.TabStop = False
        Me.duckHitLeft.Visible = False
        '
        'duckLeftAnimation
        '
        Me.duckLeftAnimation.Enabled = True
        Me.duckLeftAnimation.Interval = 110
        '
        'moveLeftDuck
        '
        Me.moveLeftDuck.Enabled = True
        Me.moveLeftDuck.Interval = 20
        '
        'duckFallLeftTimer
        '
        '
        'lblStart
        '
        Me.lblStart.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblStart.Font = New System.Drawing.Font("Impact", 50.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.LawnGreen
        Me.lblStart.Location = New System.Drawing.Point(227, 177)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(171, 82)
        Me.lblStart.TabIndex = 30
        Me.lblStart.Text = "Start"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 15)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "LEVEL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label2.Location = New System.Drawing.Point(73, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label3.Location = New System.Drawing.Point(481, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Impact", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LawnGreen
        Me.Label4.Location = New System.Drawing.Point(524, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "%"
        '
        'shotMiss
        '
        Me.shotMiss.BackColor = System.Drawing.Color.Transparent
        Me.shotMiss.Image = Global.duckHunt.My.Resources.Resources.firework_blast
        Me.shotMiss.Location = New System.Drawing.Point(281, 95)
        Me.shotMiss.Name = "shotMiss"
        Me.shotMiss.Size = New System.Drawing.Size(94, 76)
        Me.shotMiss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.shotMiss.TabIndex = 35
        Me.shotMiss.TabStop = False
        '
        'hideMissShot
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.duckHunt.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(714, 466)
        Me.Controls.Add(Me.shotMiss)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.duckHitLeft)
        Me.Controls.Add(Me.duckFallLeft)
        Me.Controls.Add(Me.duckLeft6)
        Me.Controls.Add(Me.duckLeft5)
        Me.Controls.Add(Me.duckLeft4)
        Me.Controls.Add(Me.duckLeft3)
        Me.Controls.Add(Me.duckLeft2)
        Me.Controls.Add(Me.duckLeft1)
        Me.Controls.Add(Me.duckLeft)
        Me.Controls.Add(Me.lblLevelUp)
        Me.Controls.Add(Me.goalOg)
        Me.Controls.Add(Me.duck)
        Me.Controls.Add(Me.hit)
        Me.Controls.Add(Me.duckfall)
        Me.Controls.Add(Me.duck6)
        Me.Controls.Add(Me.duck5)
        Me.Controls.Add(Me.duck4)
        Me.Controls.Add(Me.duck1)
        Me.Controls.Add(Me.duck2)
        Me.Controls.Add(Me.duck3)
        Me.Controls.Add(Me.shot3)
        Me.Controls.Add(Me.shot2)
        Me.Controls.Add(Me.shot1)
        Me.Controls.Add(Me.shot0)
        Me.Controls.Add(Me.reload3)
        Me.Controls.Add(Me.reload2)
        Me.Controls.Add(Me.reload1)
        Me.Controls.Add(Me.gun1)
        Me.Controls.Add(Me.field)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.duck3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shot0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reload3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reload2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.reload1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gun1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.field, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckfall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.goalOg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckLeft6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckFallLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.duckHitLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.shotMiss, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gun1 As System.Windows.Forms.PictureBox
    Friend WithEvents reload1 As System.Windows.Forms.PictureBox

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles gun1.Click

    End Sub
    Friend WithEvents reload2 As System.Windows.Forms.PictureBox
    Friend WithEvents reload3 As System.Windows.Forms.PictureBox
    Friend WithEvents shot0 As System.Windows.Forms.PictureBox
    Friend WithEvents shot1 As System.Windows.Forms.PictureBox
    Friend WithEvents shot2 As System.Windows.Forms.PictureBox
    Friend WithEvents shot3 As System.Windows.Forms.PictureBox


    Friend WithEvents shootTimer As System.Windows.Forms.Timer
    Friend WithEvents duck3 As System.Windows.Forms.PictureBox
    Friend WithEvents duck2 As System.Windows.Forms.PictureBox
    Friend WithEvents field As System.Windows.Forms.PictureBox
    Friend WithEvents duck1 As System.Windows.Forms.PictureBox
    Friend WithEvents duck4 As System.Windows.Forms.PictureBox
    Friend WithEvents duck5 As System.Windows.Forms.PictureBox
    Friend WithEvents duck6 As System.Windows.Forms.PictureBox
    Friend WithEvents duckfall As System.Windows.Forms.PictureBox
    Friend WithEvents hit As System.Windows.Forms.PictureBox
    Friend WithEvents duckanimation As System.Windows.Forms.Timer
    Friend WithEvents duck As System.Windows.Forms.PictureBox
    Friend WithEvents moveDuck As System.Windows.Forms.Timer
    Friend WithEvents duckFallTimer As System.Windows.Forms.Timer
    Friend WithEvents goalOg As System.Windows.Forms.PictureBox
    Friend WithEvents lblLevelUp As System.Windows.Forms.Label
    Friend WithEvents duckLeft As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft1 As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft2 As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft3 As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft4 As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft5 As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeft6 As System.Windows.Forms.PictureBox
    Friend WithEvents duckFallLeft As System.Windows.Forms.PictureBox
    Friend WithEvents duckHitLeft As System.Windows.Forms.PictureBox
    Friend WithEvents duckLeftAnimation As System.Windows.Forms.Timer
    Friend WithEvents moveLeftDuck As System.Windows.Forms.Timer
    Friend WithEvents duckFallLeftTimer As System.Windows.Forms.Timer
    Friend WithEvents lblStart As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents shotMiss As System.Windows.Forms.PictureBox
    Friend WithEvents hideMissShot As System.Windows.Forms.Timer
End Class
