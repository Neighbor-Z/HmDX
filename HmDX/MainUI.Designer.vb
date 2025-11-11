<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUI
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainUI))
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.PicBadge = New System.Windows.Forms.PictureBox()
        Me.LblURL = New System.Windows.Forms.Label()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.LblTaskName = New System.Windows.Forms.Label()
        Me.TxtTaskName = New System.Windows.Forms.TextBox()
        Me.LblContainerFormat = New System.Windows.Forms.Label()
        Me.RadMP4 = New System.Windows.Forms.RadioButton()
        Me.RadTS = New System.Windows.Forms.RadioButton()
        Me.RadBinary = New System.Windows.Forms.RadioButton()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.ChkTwoPass = New System.Windows.Forms.CheckBox()
        Me.LblProgress = New System.Windows.Forms.Label()
        Me.LblDownError = New System.Windows.Forms.Label()
        Me.LblDone = New System.Windows.Forms.Label()
        Me.VideoWorker = New System.ComponentModel.BackgroundWorker()
        Me.TxtWorkPath = New System.Windows.Forms.TextBox()
        Me.LblWorkPath = New System.Windows.Forms.Label()
        Me.BtnWorkPathBrowse = New System.Windows.Forms.Button()
        Me.FbdWorkPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.ChkLive = New System.Windows.Forms.CheckBox()
        Me.LblFileDamage = New System.Windows.Forms.Label()
        Me.ChkLocal = New System.Windows.Forms.CheckBox()
        Me.OfdLocalM3U8 = New System.Windows.Forms.OpenFileDialog()
        Me.TxtOptions = New System.Windows.Forms.TextBox()
        Me.LblOptions = New System.Windows.Forms.Label()
        Me.LblLiveInterrupt = New System.Windows.Forms.Label()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.CMSMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsiNewTaskWParam = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiUpgradeBatch = New System.Windows.Forms.ToolStripMenuItem()
        Me.TssMenu1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsiSkin = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinWave = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinSilver = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinGold = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinHatsuneMiku = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinNone = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiSkinCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.TssMenu2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsiCleanAllCache = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiOnlineHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnMenu = New System.Windows.Forms.Button()
        Me.BtnNewTask = New System.Windows.Forms.Button()
        Me.LblSpeed = New System.Windows.Forms.Label()
        Me.TmrClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.TmrAutoRestart = New System.Windows.Forms.Timer(Me.components)
        Me.BtnPathHistory = New System.Windows.Forms.Button()
        Me.CMSPathHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TsiPathHistory1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiPathHistory2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiPathHistory3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiPathHistory4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TsiPathHistory5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TssPathHistory1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TsiPathHistoryDisable = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblIndicator = New System.Windows.Forms.Label()
        Me.LblWorking = New System.Windows.Forms.Label()
        Me.OfdSkin = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMSMenu.SuspendLayout()
        Me.CMSPathHistory.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblTitle.Location = New System.Drawing.Point(119, 30)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(330, 64)
        Me.LblTitle.TabIndex = 1
        Me.LblTitle.Text = "很萌下载器"
        '
        'PicBadge
        '
        Me.PicBadge.BackColor = System.Drawing.Color.Transparent
        Me.PicBadge.Image = CType(resources.GetObject("PicBadge.Image"), System.Drawing.Image)
        Me.PicBadge.Location = New System.Drawing.Point(13, 15)
        Me.PicBadge.Name = "PicBadge"
        Me.PicBadge.Size = New System.Drawing.Size(100, 100)
        Me.PicBadge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBadge.TabIndex = 3
        Me.PicBadge.TabStop = False
        '
        'LblURL
        '
        Me.LblURL.AutoSize = True
        Me.LblURL.BackColor = System.Drawing.Color.Transparent
        Me.LblURL.Location = New System.Drawing.Point(9, 127)
        Me.LblURL.Name = "LblURL"
        Me.LblURL.Size = New System.Drawing.Size(207, 41)
        Me.LblURL.TabIndex = 201
        Me.LblURL.Text = "M3U8链接："
        '
        'TxtURL
        '
        Me.TxtURL.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtURL.Location = New System.Drawing.Point(16, 194)
        Me.TxtURL.MaxLength = 0
        Me.TxtURL.Multiline = True
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(818, 122)
        Me.TxtURL.TabIndex = 211
        '
        'LblTaskName
        '
        Me.LblTaskName.AutoSize = True
        Me.LblTaskName.BackColor = System.Drawing.Color.Transparent
        Me.LblTaskName.Location = New System.Drawing.Point(9, 362)
        Me.LblTaskName.Name = "LblTaskName"
        Me.LblTaskName.Size = New System.Drawing.Size(146, 41)
        Me.LblTaskName.TabIndex = 220
        Me.LblTaskName.Text = "任务名："
        '
        'TxtTaskName
        '
        Me.TxtTaskName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtTaskName.Location = New System.Drawing.Point(216, 363)
        Me.TxtTaskName.Name = "TxtTaskName"
        Me.TxtTaskName.Size = New System.Drawing.Size(407, 44)
        Me.TxtTaskName.TabIndex = 221
        '
        'LblContainerFormat
        '
        Me.LblContainerFormat.AutoSize = True
        Me.LblContainerFormat.BackColor = System.Drawing.Color.Transparent
        Me.LblContainerFormat.Location = New System.Drawing.Point(9, 528)
        Me.LblContainerFormat.Name = "LblContainerFormat"
        Me.LblContainerFormat.Size = New System.Drawing.Size(178, 41)
        Me.LblContainerFormat.TabIndex = 250
        Me.LblContainerFormat.Text = "封装格式："
        '
        'RadMP4
        '
        Me.RadMP4.AutoSize = True
        Me.RadMP4.BackColor = System.Drawing.Color.Transparent
        Me.RadMP4.Location = New System.Drawing.Point(207, 528)
        Me.RadMP4.Name = "RadMP4"
        Me.RadMP4.Size = New System.Drawing.Size(119, 45)
        Me.RadMP4.TabIndex = 251
        Me.RadMP4.Text = "MP&4"
        Me.RadMP4.UseVisualStyleBackColor = False
        '
        'RadTS
        '
        Me.RadTS.AutoSize = True
        Me.RadTS.BackColor = System.Drawing.Color.Transparent
        Me.RadTS.Location = New System.Drawing.Point(382, 526)
        Me.RadTS.Name = "RadTS"
        Me.RadTS.Size = New System.Drawing.Size(85, 45)
        Me.RadTS.TabIndex = 254
        Me.RadTS.Text = "&TS"
        Me.RadTS.UseVisualStyleBackColor = False
        '
        'RadBinary
        '
        Me.RadBinary.AutoSize = True
        Me.RadBinary.BackColor = System.Drawing.Color.Transparent
        Me.RadBinary.Checked = True
        Me.RadBinary.Location = New System.Drawing.Point(527, 526)
        Me.RadBinary.Name = "RadBinary"
        Me.RadBinary.Size = New System.Drawing.Size(199, 45)
        Me.RadBinary.TabIndex = 257
        Me.RadBinary.TabStop = True
        Me.RadBinary.Text = "&RAW 输出"
        Me.RadBinary.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(362, 739)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(240, 84)
        Me.BtnStart.TabIndex = 302
        Me.BtnStart.Text = "开始(&S)"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'ChkTwoPass
        '
        Me.ChkTwoPass.AutoSize = True
        Me.ChkTwoPass.BackColor = System.Drawing.Color.Transparent
        Me.ChkTwoPass.Location = New System.Drawing.Point(676, 126)
        Me.ChkTwoPass.Name = "ChkTwoPass"
        Me.ChkTwoPass.Size = New System.Drawing.Size(158, 45)
        Me.ChkTwoPass.TabIndex = 207
        Me.ChkTwoPass.Text = "&校验(&V)"
        Me.ChkTwoPass.UseVisualStyleBackColor = False
        '
        'LblProgress
        '
        Me.LblProgress.BackColor = System.Drawing.Color.Transparent
        Me.LblProgress.Font = New System.Drawing.Font("微软雅黑", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblProgress.Location = New System.Drawing.Point(648, 729)
        Me.LblProgress.Name = "LblProgress"
        Me.LblProgress.Size = New System.Drawing.Size(185, 44)
        Me.LblProgress.TabIndex = 600
        Me.LblProgress.Text = "0/0"
        Me.LblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblProgress.Visible = False
        '
        'LblDownError
        '
        Me.LblDownError.BackColor = System.Drawing.Color.DarkRed
        Me.LblDownError.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDownError.ForeColor = System.Drawing.Color.White
        Me.LblDownError.Location = New System.Drawing.Point(119, 794)
        Me.LblDownError.Name = "LblDownError"
        Me.LblDownError.Size = New System.Drawing.Size(30, 15)
        Me.LblDownError.TabIndex = 520
        Me.LblDownError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblDownError.Visible = False
        '
        'LblDone
        '
        Me.LblDone.BackColor = System.Drawing.Color.YellowGreen
        Me.LblDone.Font = New System.Drawing.Font("微软雅黑 Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblDone.ForeColor = System.Drawing.Color.White
        Me.LblDone.Location = New System.Drawing.Point(365, 753)
        Me.LblDone.Name = "LblDone"
        Me.LblDone.Size = New System.Drawing.Size(237, 53)
        Me.LblDone.TabIndex = 94
        Me.LblDone.Text = "任务完成"
        Me.LblDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblDone.Visible = False
        '
        'VideoWorker
        '
        '
        'TxtWorkPath
        '
        Me.TxtWorkPath.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtWorkPath.Location = New System.Drawing.Point(216, 441)
        Me.TxtWorkPath.Name = "TxtWorkPath"
        Me.TxtWorkPath.ReadOnly = True
        Me.TxtWorkPath.Size = New System.Drawing.Size(407, 44)
        Me.TxtWorkPath.TabIndex = 231
        '
        'LblWorkPath
        '
        Me.LblWorkPath.AutoSize = True
        Me.LblWorkPath.BackColor = System.Drawing.Color.Transparent
        Me.LblWorkPath.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblWorkPath.Location = New System.Drawing.Point(9, 444)
        Me.LblWorkPath.Name = "LblWorkPath"
        Me.LblWorkPath.Size = New System.Drawing.Size(178, 41)
        Me.LblWorkPath.TabIndex = 230
        Me.LblWorkPath.Text = "工作目录："
        '
        'BtnWorkPathBrowse
        '
        Me.BtnWorkPathBrowse.Location = New System.Drawing.Point(710, 441)
        Me.BtnWorkPathBrowse.Name = "BtnWorkPathBrowse"
        Me.BtnWorkPathBrowse.Size = New System.Drawing.Size(50, 44)
        Me.BtnWorkPathBrowse.TabIndex = 235
        Me.BtnWorkPathBrowse.Text = "&..."
        Me.BtnWorkPathBrowse.UseVisualStyleBackColor = True
        '
        'FbdWorkPath
        '
        '
        'ChkLive
        '
        Me.ChkLive.AutoSize = True
        Me.ChkLive.BackColor = System.Drawing.Color.Transparent
        Me.ChkLive.Location = New System.Drawing.Point(471, 126)
        Me.ChkLive.Name = "ChkLive"
        Me.ChkLive.Size = New System.Drawing.Size(152, 45)
        Me.ChkLive.TabIndex = 205
        Me.ChkLive.Text = "&直播(&L)"
        Me.ChkLive.UseVisualStyleBackColor = False
        '
        'LblFileDamage
        '
        Me.LblFileDamage.BackColor = System.Drawing.Color.RosyBrown
        Me.LblFileDamage.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblFileDamage.ForeColor = System.Drawing.Color.White
        Me.LblFileDamage.Location = New System.Drawing.Point(202, 794)
        Me.LblFileDamage.Name = "LblFileDamage"
        Me.LblFileDamage.Size = New System.Drawing.Size(30, 15)
        Me.LblFileDamage.TabIndex = 530
        Me.LblFileDamage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblFileDamage.Visible = False
        '
        'ChkLocal
        '
        Me.ChkLocal.AutoSize = True
        Me.ChkLocal.BackColor = System.Drawing.Color.Transparent
        Me.ChkLocal.Checked = True
        Me.ChkLocal.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.ChkLocal.Location = New System.Drawing.Point(258, 126)
        Me.ChkLocal.Name = "ChkLocal"
        Me.ChkLocal.Size = New System.Drawing.Size(162, 45)
        Me.ChkLocal.TabIndex = 203
        Me.ChkLocal.Text = "本地(&O)"
        Me.ChkLocal.UseVisualStyleBackColor = False
        '
        'OfdLocalM3U8
        '
        Me.OfdLocalM3U8.Filter = "所有文件|*.*"
        '
        'TxtOptions
        '
        Me.TxtOptions.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtOptions.Location = New System.Drawing.Point(216, 608)
        Me.TxtOptions.MaxLength = 0
        Me.TxtOptions.Multiline = True
        Me.TxtOptions.Name = "TxtOptions"
        Me.TxtOptions.Size = New System.Drawing.Size(618, 80)
        Me.TxtOptions.TabIndex = 271
        '
        'LblOptions
        '
        Me.LblOptions.AutoSize = True
        Me.LblOptions.BackColor = System.Drawing.Color.Transparent
        Me.LblOptions.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblOptions.Location = New System.Drawing.Point(9, 607)
        Me.LblOptions.Name = "LblOptions"
        Me.LblOptions.Size = New System.Drawing.Size(178, 41)
        Me.LblOptions.TabIndex = 270
        Me.LblOptions.Text = "附加选项："
        '
        'LblLiveInterrupt
        '
        Me.LblLiveInterrupt.BackColor = System.Drawing.Color.Orange
        Me.LblLiveInterrupt.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblLiveInterrupt.ForeColor = System.Drawing.Color.White
        Me.LblLiveInterrupt.Location = New System.Drawing.Point(282, 794)
        Me.LblLiveInterrupt.Name = "LblLiveInterrupt"
        Me.LblLiveInterrupt.Size = New System.Drawing.Size(30, 15)
        Me.LblLiveInterrupt.TabIndex = 540
        Me.LblLiveInterrupt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblLiveInterrupt.Visible = False
        '
        'BtnPause
        '
        Me.BtnPause.Font = New System.Drawing.Font("微软雅黑", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnPause.Location = New System.Drawing.Point(362, 739)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(240, 84)
        Me.BtnPause.TabIndex = 301
        Me.BtnPause.Text = "暂停(&P)"
        Me.BtnPause.UseVisualStyleBackColor = True
        Me.BtnPause.Visible = False
        '
        'CMSMenu
        '
        Me.CMSMenu.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CMSMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsiNewTaskWParam, Me.TsiUpgradeBatch, Me.TssMenu1, Me.TsiSkin, Me.TssMenu2, Me.TsiCleanAllCache, Me.TsiOnlineHelp, Me.TsiAbout})
        Me.CMSMenu.Name = "ContextMenuStrip1"
        Me.CMSMenu.Size = New System.Drawing.Size(459, 244)
        '
        'TsiNewTaskWParam
        '
        Me.TsiNewTaskWParam.Name = "TsiNewTaskWParam"
        Me.TsiNewTaskWParam.Size = New System.Drawing.Size(458, 38)
        Me.TsiNewTaskWParam.Text = "新建任务并携带此实例的参数(&N)"
        '
        'TsiUpgradeBatch
        '
        Me.TsiUpgradeBatch.Name = "TsiUpgradeBatch"
        Me.TsiUpgradeBatch.Size = New System.Drawing.Size(458, 38)
        Me.TsiUpgradeBatch.Text = "将此实例提升为批量任务控制器(&U)"
        '
        'TssMenu1
        '
        Me.TssMenu1.Name = "TssMenu1"
        Me.TssMenu1.Size = New System.Drawing.Size(455, 6)
        '
        'TsiSkin
        '
        Me.TsiSkin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsiSkinDefault, Me.TsiSkinWave, Me.TsiSkinSilver, Me.TsiSkinGold, Me.TsiSkinHatsuneMiku, Me.TsiSkinNone, Me.TsiSkinCustomize})
        Me.TsiSkin.Name = "TsiSkin"
        Me.TsiSkin.Size = New System.Drawing.Size(458, 38)
        Me.TsiSkin.Text = "皮肤设置(&S)"
        '
        'TsiSkinDefault
        '
        Me.TsiSkinDefault.Name = "TsiSkinDefault"
        Me.TsiSkinDefault.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinDefault.Text = "默认皮肤"
        '
        'TsiSkinWave
        '
        Me.TsiSkinWave.Name = "TsiSkinWave"
        Me.TsiSkinWave.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinWave.Text = "轻盈波澜"
        '
        'TsiSkinSilver
        '
        Me.TsiSkinSilver.Name = "TsiSkinSilver"
        Me.TsiSkinSilver.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinSilver.Text = "银光点缀"
        '
        'TsiSkinGold
        '
        Me.TsiSkinGold.Name = "TsiSkinGold"
        Me.TsiSkinGold.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinGold.Text = "土豪金"
        '
        'TsiSkinHatsuneMiku
        '
        Me.TsiSkinHatsuneMiku.Name = "TsiSkinHatsuneMiku"
        Me.TsiSkinHatsuneMiku.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinHatsuneMiku.Text = "初音未来"
        Me.TsiSkinHatsuneMiku.Visible = False
        '
        'TsiSkinNone
        '
        Me.TsiSkinNone.Name = "TsiSkinNone"
        Me.TsiSkinNone.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinNone.Text = "无皮肤"
        Me.TsiSkinNone.Visible = False
        '
        'TsiSkinCustomize
        '
        Me.TsiSkinCustomize.Name = "TsiSkinCustomize"
        Me.TsiSkinCustomize.Size = New System.Drawing.Size(243, 44)
        Me.TsiSkinCustomize.Text = "自定义"
        '
        'TssMenu2
        '
        Me.TssMenu2.Name = "TssMenu2"
        Me.TssMenu2.Size = New System.Drawing.Size(455, 6)
        '
        'TsiCleanAllCache
        '
        Me.TsiCleanAllCache.Name = "TsiCleanAllCache"
        Me.TsiCleanAllCache.Size = New System.Drawing.Size(458, 38)
        Me.TsiCleanAllCache.Text = "清理缓存(&C)"
        '
        'TsiOnlineHelp
        '
        Me.TsiOnlineHelp.Name = "TsiOnlineHelp"
        Me.TsiOnlineHelp.Size = New System.Drawing.Size(458, 38)
        Me.TsiOnlineHelp.Text = "在线帮助(&H)"
        Me.TsiOnlineHelp.Visible = False
        '
        'TsiAbout
        '
        Me.TsiAbout.Name = "TsiAbout"
        Me.TsiAbout.Size = New System.Drawing.Size(458, 38)
        Me.TsiAbout.Text = "关于(&A)"
        '
        'BtnMenu
        '
        Me.BtnMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMenu.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnMenu.ForeColor = System.Drawing.Color.White
        Me.BtnMenu.Location = New System.Drawing.Point(754, 28)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(80, 72)
        Me.BtnMenu.TabIndex = 104
        Me.BtnMenu.Text = "···"
        Me.BtnMenu.UseVisualStyleBackColor = False
        '
        'BtnNewTask
        '
        Me.BtnNewTask.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.BtnNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewTask.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnNewTask.ForeColor = System.Drawing.Color.White
        Me.BtnNewTask.Location = New System.Drawing.Point(655, 28)
        Me.BtnNewTask.Name = "BtnNewTask"
        Me.BtnNewTask.Size = New System.Drawing.Size(77, 72)
        Me.BtnNewTask.TabIndex = 101
        Me.BtnNewTask.Text = "+"
        Me.BtnNewTask.UseVisualStyleBackColor = False
        '
        'LblSpeed
        '
        Me.LblSpeed.BackColor = System.Drawing.Color.LightSteelBlue
        Me.LblSpeed.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSpeed.ForeColor = System.Drawing.Color.White
        Me.LblSpeed.Location = New System.Drawing.Point(643, 777)
        Me.LblSpeed.Name = "LblSpeed"
        Me.LblSpeed.Size = New System.Drawing.Size(190, 46)
        Me.LblSpeed.TabIndex = 610
        Me.LblSpeed.Text = "0.00 MB/s"
        Me.LblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblSpeed.Visible = False
        '
        'TmrClipboard
        '
        Me.TmrClipboard.Interval = 1000
        '
        'TmrAutoRestart
        '
        Me.TmrAutoRestart.Interval = 100000
        '
        'BtnPathHistory
        '
        Me.BtnPathHistory.Location = New System.Drawing.Point(638, 441)
        Me.BtnPathHistory.Name = "BtnPathHistory"
        Me.BtnPathHistory.Size = New System.Drawing.Size(53, 44)
        Me.BtnPathHistory.TabIndex = 233
        Me.BtnPathHistory.Text = "▼"
        Me.BtnPathHistory.UseVisualStyleBackColor = True
        '
        'CMSPathHistory
        '
        Me.CMSPathHistory.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.CMSPathHistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TsiPathHistory1, Me.TsiPathHistory2, Me.TsiPathHistory3, Me.TsiPathHistory4, Me.TsiPathHistory5, Me.TssPathHistory1, Me.TsiPathHistoryDisable})
        Me.CMSPathHistory.Name = "ContextMenuStrip1"
        Me.CMSPathHistory.Size = New System.Drawing.Size(329, 238)
        '
        'TsiPathHistory1
        '
        Me.TsiPathHistory1.Name = "TsiPathHistory1"
        Me.TsiPathHistory1.Size = New System.Drawing.Size(328, 38)
        '
        'TsiPathHistory2
        '
        Me.TsiPathHistory2.Name = "TsiPathHistory2"
        Me.TsiPathHistory2.Size = New System.Drawing.Size(328, 38)
        '
        'TsiPathHistory3
        '
        Me.TsiPathHistory3.Name = "TsiPathHistory3"
        Me.TsiPathHistory3.Size = New System.Drawing.Size(328, 38)
        '
        'TsiPathHistory4
        '
        Me.TsiPathHistory4.Name = "TsiPathHistory4"
        Me.TsiPathHistory4.Size = New System.Drawing.Size(328, 38)
        '
        'TsiPathHistory5
        '
        Me.TsiPathHistory5.Name = "TsiPathHistory5"
        Me.TsiPathHistory5.Size = New System.Drawing.Size(328, 38)
        '
        'TssPathHistory1
        '
        Me.TssPathHistory1.Name = "TssPathHistory1"
        Me.TssPathHistory1.Size = New System.Drawing.Size(325, 6)
        '
        'TsiPathHistoryDisable
        '
        Me.TsiPathHistoryDisable.Name = "TsiPathHistoryDisable"
        Me.TsiPathHistoryDisable.Size = New System.Drawing.Size(328, 38)
        Me.TsiPathHistoryDisable.Text = "禁用工作目录历史记录"
        '
        'LblIndicator
        '
        Me.LblIndicator.BackColor = System.Drawing.Color.Transparent
        Me.LblIndicator.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblIndicator.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblIndicator.Location = New System.Drawing.Point(9, 733)
        Me.LblIndicator.Name = "LblIndicator"
        Me.LblIndicator.Size = New System.Drawing.Size(328, 40)
        Me.LblIndicator.TabIndex = 500
        Me.LblIndicator.Text = "WRK  ERR   VER   LOS"
        Me.LblIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWorking
        '
        Me.LblWorking.BackColor = System.Drawing.Color.RoyalBlue
        Me.LblWorking.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblWorking.ForeColor = System.Drawing.Color.White
        Me.LblWorking.Location = New System.Drawing.Point(28, 794)
        Me.LblWorking.Name = "LblWorking"
        Me.LblWorking.Size = New System.Drawing.Size(30, 15)
        Me.LblWorking.TabIndex = 510
        Me.LblWorking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LblWorking.Visible = False
        '
        'OfdSkin
        '
        Me.OfdSkin.Filter = "图片文件|*.png;*.jpg;*.jpeg"
        '
        'MainUI
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(863, 865)
        Me.Controls.Add(Me.LblWorking)
        Me.Controls.Add(Me.LblIndicator)
        Me.Controls.Add(Me.BtnPathHistory)
        Me.Controls.Add(Me.LblSpeed)
        Me.Controls.Add(Me.BtnNewTask)
        Me.Controls.Add(Me.BtnMenu)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.LblLiveInterrupt)
        Me.Controls.Add(Me.TxtOptions)
        Me.Controls.Add(Me.LblOptions)
        Me.Controls.Add(Me.ChkLocal)
        Me.Controls.Add(Me.LblFileDamage)
        Me.Controls.Add(Me.ChkLive)
        Me.Controls.Add(Me.BtnWorkPathBrowse)
        Me.Controls.Add(Me.TxtWorkPath)
        Me.Controls.Add(Me.LblWorkPath)
        Me.Controls.Add(Me.LblDone)
        Me.Controls.Add(Me.LblDownError)
        Me.Controls.Add(Me.LblProgress)
        Me.Controls.Add(Me.ChkTwoPass)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.RadBinary)
        Me.Controls.Add(Me.RadTS)
        Me.Controls.Add(Me.RadMP4)
        Me.Controls.Add(Me.LblContainerFormat)
        Me.Controls.Add(Me.TxtTaskName)
        Me.Controls.Add(Me.LblTaskName)
        Me.Controls.Add(Me.TxtURL)
        Me.Controls.Add(Me.LblURL)
        Me.Controls.Add(Me.PicBadge)
        Me.Controls.Add(Me.LblTitle)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "MainUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HmDX"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PicBadge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMSMenu.ResumeLayout(False)
        Me.CMSPathHistory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents PicBadge As PictureBox
    Friend WithEvents LblURL As Label
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents LblTaskName As Label
    Friend WithEvents TxtTaskName As TextBox
    Friend WithEvents LblContainerFormat As Label
    Friend WithEvents RadMP4 As RadioButton
    Friend WithEvents RadTS As RadioButton
    Friend WithEvents RadBinary As RadioButton
    Friend WithEvents BtnStart As Button
    Friend WithEvents ChkTwoPass As CheckBox
    Friend WithEvents LblProgress As Label
    Friend WithEvents LblDownError As Label
    Friend WithEvents LblDone As Label
    Friend WithEvents VideoWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents TxtWorkPath As TextBox
    Friend WithEvents LblWorkPath As Label
    Friend WithEvents BtnWorkPathBrowse As Button
    Friend WithEvents FbdWorkPath As FolderBrowserDialog
    Friend WithEvents ChkLive As CheckBox
    Friend WithEvents LblFileDamage As Label
    Friend WithEvents ChkLocal As CheckBox
    Friend WithEvents OfdLocalM3U8 As OpenFileDialog
    Friend WithEvents TxtOptions As TextBox
    Friend WithEvents LblOptions As Label
    Friend WithEvents LblLiveInterrupt As Label
    Friend WithEvents BtnPause As Button
    Friend WithEvents CMSMenu As ContextMenuStrip
    Friend WithEvents TsiNewTaskWParam As ToolStripMenuItem
    Friend WithEvents TssMenu1 As ToolStripSeparator
    Friend WithEvents TsiAbout As ToolStripMenuItem
    Friend WithEvents BtnMenu As Button
    Friend WithEvents BtnNewTask As Button
    Friend WithEvents TsiUpgradeBatch As ToolStripMenuItem
    Friend WithEvents LblSpeed As Label
    Friend WithEvents TsiOnlineHelp As ToolStripMenuItem
    Friend WithEvents TsiSkin As ToolStripMenuItem
    Friend WithEvents TssMenu2 As ToolStripSeparator
    Friend WithEvents TsiSkinDefault As ToolStripMenuItem
    Friend WithEvents TsiSkinHatsuneMiku As ToolStripMenuItem
    Friend WithEvents TsiSkinWave As ToolStripMenuItem
    Friend WithEvents TsiSkinGold As ToolStripMenuItem
    Friend WithEvents TsiSkinSilver As ToolStripMenuItem
    Friend WithEvents TsiSkinNone As ToolStripMenuItem
    Friend WithEvents TsiCleanAllCache As ToolStripMenuItem
    Friend WithEvents TmrClipboard As Timer
    Friend WithEvents TmrAutoRestart As Timer
    Friend WithEvents BtnPathHistory As Button
    Friend WithEvents CMSPathHistory As ContextMenuStrip
    Friend WithEvents TsiPathHistory1 As ToolStripMenuItem
    Friend WithEvents TsiPathHistory5 As ToolStripMenuItem
    Friend WithEvents TssPathHistory1 As ToolStripSeparator
    Friend WithEvents TsiPathHistoryDisable As ToolStripMenuItem
    Friend WithEvents TsiPathHistory2 As ToolStripMenuItem
    Friend WithEvents TsiPathHistory3 As ToolStripMenuItem
    Friend WithEvents TsiPathHistory4 As ToolStripMenuItem
    Friend WithEvents LblIndicator As Label
    Friend WithEvents LblWorking As Label
    Friend WithEvents TsiSkinCustomize As ToolStripMenuItem
    Friend WithEvents OfdSkin As OpenFileDialog
End Class
