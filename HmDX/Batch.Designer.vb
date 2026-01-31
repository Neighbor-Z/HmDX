<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Batch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Batch))
        Me.LsvQueue = New System.Windows.Forms.ListView()
        Me.ClhStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhTaskName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhURL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClhOptions = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnRemoveAll = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.LblTaskName = New System.Windows.Forms.Label()
        Me.TxtTaskName = New System.Windows.Forms.TextBox()
        Me.LblSequence = New System.Windows.Forms.Label()
        Me.LblConcurrent = New System.Windows.Forms.Label()
        Me.NumConcurrent = New System.Windows.Forms.NumericUpDown()
        Me.LblSeqCurrent = New System.Windows.Forms.Label()
        Me.NumSeqCurrent = New System.Windows.Forms.NumericUpDown()
        Me.BtnAddLocal = New System.Windows.Forms.Button()
        Me.NumSeqSupplement = New System.Windows.Forms.NumericUpDown()
        Me.LblSeqSupplement = New System.Windows.Forms.Label()
        Me.NumSeqAscend = New System.Windows.Forms.NumericUpDown()
        Me.LblSeqAscend = New System.Windows.Forms.Label()
        Me.LblURL = New System.Windows.Forms.Label()
        Me.TxtURL = New System.Windows.Forms.TextBox()
        Me.LblArgs = New System.Windows.Forms.Label()
        Me.BtnWorkPathBrowse = New System.Windows.Forms.Button()
        Me.TxtWorkPath = New System.Windows.Forms.TextBox()
        Me.LblWorkPath = New System.Windows.Forms.Label()
        Me.RadBinary = New System.Windows.Forms.RadioButton()
        Me.RadTS = New System.Windows.Forms.RadioButton()
        Me.RadMP4 = New System.Windows.Forms.RadioButton()
        Me.LblContainerFormat = New System.Windows.Forms.Label()
        Me.ChkAutoExit = New System.Windows.Forms.CheckBox()
        Me.ChkIsLive = New System.Windows.Forms.CheckBox()
        Me.ChkTwoPass = New System.Windows.Forms.CheckBox()
        Me.ChkAutoStart = New System.Windows.Forms.CheckBox()
        Me.ChkMute = New System.Windows.Forms.CheckBox()
        Me.ChkNoStream = New System.Windows.Forms.CheckBox()
        Me.ChkAutoSelectHigh = New System.Windows.Forms.CheckBox()
        Me.ChkThreads = New System.Windows.Forms.CheckBox()
        Me.ChkTimeout = New System.Windows.Forms.CheckBox()
        Me.TxtThreads = New System.Windows.Forms.TextBox()
        Me.TxtTimeout = New System.Windows.Forms.TextBox()
        Me.ChkMinimize = New System.Windows.Forms.CheckBox()
        Me.LblOptions = New System.Windows.Forms.Label()
        Me.TxtOptions = New System.Windows.Forms.TextBox()
        Me.LblTask = New System.Windows.Forms.Label()
        Me.BtnTaskStart = New System.Windows.Forms.Button()
        Me.BtnTaskQueue = New System.Windows.Forms.Button()
        Me.ChkTaskSuspend = New System.Windows.Forms.CheckBox()
        Me.BtnTaskOverride = New System.Windows.Forms.Button()
        Me.LblQueue = New System.Windows.Forms.Label()
        Me.FbdWorkPath = New System.Windows.Forms.FolderBrowserDialog()
        Me.OfdAddLocal = New System.Windows.Forms.OpenFileDialog()
        Me.TmrQueue = New System.Windows.Forms.Timer(Me.components)
        Me.ChkNoAutoClean = New System.Windows.Forms.CheckBox()
        Me.LblIdentifier = New System.Windows.Forms.Label()
        Me.TxtIdentifier = New System.Windows.Forms.TextBox()
        Me.BtnIdentifierClear = New System.Windows.Forms.Button()
        Me.TmrClipboard = New System.Windows.Forms.Timer(Me.components)
        Me.ChkAutoPowerOff = New System.Windows.Forms.CheckBox()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.SFDExport = New System.Windows.Forms.SaveFileDialog()
        Me.TotIdentifier = New System.Windows.Forms.ToolTip(Me.components)
        Me.TotTaskName = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnTop = New System.Windows.Forms.Button()
        Me.BtnBottom = New System.Windows.Forms.Button()
        CType(Me.NumConcurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSeqCurrent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSeqSupplement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumSeqAscend, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LsvQueue
        '
        Me.LsvQueue.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LsvQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClhStatus, Me.ClhTaskName, Me.ClhURL, Me.ClhOptions})
        Me.LsvQueue.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LsvQueue.FullRowSelect = True
        Me.LsvQueue.HideSelection = False
        Me.LsvQueue.Location = New System.Drawing.Point(17, 22)
        Me.LsvQueue.MaximumSize = New System.Drawing.Size(1272, 259)
        Me.LsvQueue.MinimumSize = New System.Drawing.Size(1272, 259)
        Me.LsvQueue.Name = "LsvQueue"
        Me.LsvQueue.Size = New System.Drawing.Size(1272, 259)
        Me.LsvQueue.TabIndex = 10
        Me.LsvQueue.UseCompatibleStateImageBehavior = False
        Me.LsvQueue.View = System.Windows.Forms.View.Details
        '
        'ClhStatus
        '
        Me.ClhStatus.Text = "状态"
        Me.ClhStatus.Width = 77
        '
        'ClhTaskName
        '
        Me.ClhTaskName.Text = "任务名"
        Me.ClhTaskName.Width = 320
        '
        'ClhURL
        '
        Me.ClhURL.Text = "URL"
        Me.ClhURL.Width = 400
        '
        'ClhOptions
        '
        Me.ClhOptions.Text = "发送参数"
        Me.ClhOptions.Width = 2000
        '
        'BtnRemoveAll
        '
        Me.BtnRemoveAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemoveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemoveAll.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnRemoveAll.ForeColor = System.Drawing.Color.White
        Me.BtnRemoveAll.Location = New System.Drawing.Point(1494, 184)
        Me.BtnRemoveAll.Name = "BtnRemoveAll"
        Me.BtnRemoveAll.Size = New System.Drawing.Size(80, 71)
        Me.BtnRemoveAll.TabIndex = 37
        Me.BtnRemoveAll.Text = "×"
        Me.BtnRemoveAll.UseVisualStyleBackColor = False
        '
        'BtnRemove
        '
        Me.BtnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRemove.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnRemove.ForeColor = System.Drawing.Color.White
        Me.BtnRemove.Location = New System.Drawing.Point(1408, 184)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(80, 71)
        Me.BtnRemove.TabIndex = 35
        Me.BtnRemove.Text = "-"
        Me.BtnRemove.UseVisualStyleBackColor = False
        '
        'LblTaskName
        '
        Me.LblTaskName.AutoSize = True
        Me.LblTaskName.Location = New System.Drawing.Point(12, 620)
        Me.LblTaskName.Name = "LblTaskName"
        Me.LblTaskName.Size = New System.Drawing.Size(136, 41)
        Me.LblTaskName.TabIndex = 108
        Me.LblTaskName.Text = "[任务名]"
        '
        'TxtTaskName
        '
        Me.TxtTaskName.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtTaskName.Location = New System.Drawing.Point(21, 672)
        Me.TxtTaskName.Name = "TxtTaskName"
        Me.TxtTaskName.Size = New System.Drawing.Size(436, 44)
        Me.TxtTaskName.TabIndex = 111
        '
        'LblSequence
        '
        Me.LblSequence.AutoSize = True
        Me.LblSequence.Location = New System.Drawing.Point(15, 729)
        Me.LblSequence.Name = "LblSequence"
        Me.LblSequence.Size = New System.Drawing.Size(82, 41)
        Me.LblSequence.TabIndex = 110
        Me.LblSequence.Text = "序列"
        '
        'LblConcurrent
        '
        Me.LblConcurrent.AutoSize = True
        Me.LblConcurrent.Location = New System.Drawing.Point(1315, 63)
        Me.LblConcurrent.Name = "LblConcurrent"
        Me.LblConcurrent.Size = New System.Drawing.Size(178, 41)
        Me.LblConcurrent.TabIndex = 111
        Me.LblConcurrent.Text = "并行任务数"
        '
        'NumConcurrent
        '
        Me.NumConcurrent.Location = New System.Drawing.Point(1322, 107)
        Me.NumConcurrent.Maximum = New Decimal(New Integer() {256, 0, 0, 0})
        Me.NumConcurrent.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumConcurrent.Name = "NumConcurrent"
        Me.NumConcurrent.Size = New System.Drawing.Size(80, 50)
        Me.NumConcurrent.TabIndex = 21
        Me.NumConcurrent.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblSeqCurrent
        '
        Me.LblSeqCurrent.AutoSize = True
        Me.LblSeqCurrent.Location = New System.Drawing.Point(244, 729)
        Me.LblSeqCurrent.Name = "LblSeqCurrent"
        Me.LblSeqCurrent.Size = New System.Drawing.Size(82, 41)
        Me.LblSeqCurrent.TabIndex = 113
        Me.LblSeqCurrent.Text = "当前"
        '
        'NumSeqCurrent
        '
        Me.NumSeqCurrent.Location = New System.Drawing.Point(348, 726)
        Me.NumSeqCurrent.Maximum = New Decimal(New Integer() {2147483647, 0, 0, 0})
        Me.NumSeqCurrent.Name = "NumSeqCurrent"
        Me.NumSeqCurrent.Size = New System.Drawing.Size(109, 50)
        Me.NumSeqCurrent.TabIndex = 121
        Me.NumSeqCurrent.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BtnAddLocal
        '
        Me.BtnAddLocal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnAddLocal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddLocal.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnAddLocal.ForeColor = System.Drawing.Color.White
        Me.BtnAddLocal.Location = New System.Drawing.Point(1408, 107)
        Me.BtnAddLocal.Name = "BtnAddLocal"
        Me.BtnAddLocal.Size = New System.Drawing.Size(80, 71)
        Me.BtnAddLocal.TabIndex = 31
        Me.BtnAddLocal.Text = "+"
        Me.BtnAddLocal.UseVisualStyleBackColor = False
        '
        'NumSeqSupplement
        '
        Me.NumSeqSupplement.Location = New System.Drawing.Point(348, 792)
        Me.NumSeqSupplement.Maximum = New Decimal(New Integer() {128, 0, 0, 0})
        Me.NumSeqSupplement.Name = "NumSeqSupplement"
        Me.NumSeqSupplement.Size = New System.Drawing.Size(109, 50)
        Me.NumSeqSupplement.TabIndex = 127
        Me.NumSeqSupplement.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'LblSeqSupplement
        '
        Me.LblSeqSupplement.AutoSize = True
        Me.LblSeqSupplement.Location = New System.Drawing.Point(244, 794)
        Me.LblSeqSupplement.Name = "LblSeqSupplement"
        Me.LblSeqSupplement.Size = New System.Drawing.Size(82, 41)
        Me.LblSeqSupplement.TabIndex = 116
        Me.LblSeqSupplement.Text = "位数"
        '
        'NumSeqAscend
        '
        Me.NumSeqAscend.Location = New System.Drawing.Point(115, 792)
        Me.NumSeqAscend.Maximum = New Decimal(New Integer() {1048576, 0, 0, 0})
        Me.NumSeqAscend.Name = "NumSeqAscend"
        Me.NumSeqAscend.Size = New System.Drawing.Size(109, 50)
        Me.NumSeqAscend.TabIndex = 124
        Me.NumSeqAscend.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LblSeqAscend
        '
        Me.LblSeqAscend.AutoSize = True
        Me.LblSeqAscend.Location = New System.Drawing.Point(15, 794)
        Me.LblSeqAscend.Name = "LblSeqAscend"
        Me.LblSeqAscend.Size = New System.Drawing.Size(82, 41)
        Me.LblSeqAscend.TabIndex = 118
        Me.LblSeqAscend.Text = "增量"
        '
        'LblURL
        '
        Me.LblURL.AutoSize = True
        Me.LblURL.Location = New System.Drawing.Point(10, 313)
        Me.LblURL.Name = "LblURL"
        Me.LblURL.Size = New System.Drawing.Size(104, 41)
        Me.LblURL.TabIndex = 120
        Me.LblURL.Text = "[链接]"
        '
        'TxtURL
        '
        Me.TxtURL.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtURL.Location = New System.Drawing.Point(14, 375)
        Me.TxtURL.MaxLength = 0
        Me.TxtURL.Multiline = True
        Me.TxtURL.Name = "TxtURL"
        Me.TxtURL.Size = New System.Drawing.Size(443, 150)
        Me.TxtURL.TabIndex = 107
        '
        'LblArgs
        '
        Me.LblArgs.AutoSize = True
        Me.LblArgs.Location = New System.Drawing.Point(507, 314)
        Me.LblArgs.Name = "LblArgs"
        Me.LblArgs.Size = New System.Drawing.Size(104, 41)
        Me.LblArgs.TabIndex = 122
        Me.LblArgs.Text = "[参数]"
        '
        'BtnWorkPathBrowse
        '
        Me.BtnWorkPathBrowse.Location = New System.Drawing.Point(999, 375)
        Me.BtnWorkPathBrowse.Name = "BtnWorkPathBrowse"
        Me.BtnWorkPathBrowse.Size = New System.Drawing.Size(53, 44)
        Me.BtnWorkPathBrowse.TabIndex = 202
        Me.BtnWorkPathBrowse.Text = "&..."
        Me.BtnWorkPathBrowse.UseVisualStyleBackColor = True
        '
        'TxtWorkPath
        '
        Me.TxtWorkPath.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtWorkPath.Location = New System.Drawing.Point(694, 375)
        Me.TxtWorkPath.Name = "TxtWorkPath"
        Me.TxtWorkPath.ReadOnly = True
        Me.TxtWorkPath.Size = New System.Drawing.Size(291, 44)
        Me.TxtWorkPath.TabIndex = 201
        '
        'LblWorkPath
        '
        Me.LblWorkPath.AutoSize = True
        Me.LblWorkPath.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblWorkPath.Location = New System.Drawing.Point(510, 380)
        Me.LblWorkPath.Name = "LblWorkPath"
        Me.LblWorkPath.Size = New System.Drawing.Size(178, 41)
        Me.LblWorkPath.TabIndex = 129
        Me.LblWorkPath.Text = "工作目录："
        '
        'RadBinary
        '
        Me.RadBinary.AutoSize = True
        Me.RadBinary.Checked = True
        Me.RadBinary.Location = New System.Drawing.Point(876, 449)
        Me.RadBinary.Name = "RadBinary"
        Me.RadBinary.Size = New System.Drawing.Size(190, 45)
        Me.RadBinary.TabIndex = 217
        Me.RadBinary.TabStop = True
        Me.RadBinary.Text = "&RAW输出"
        Me.RadBinary.UseVisualStyleBackColor = True
        '
        'RadTS
        '
        Me.RadTS.AutoSize = True
        Me.RadTS.Location = New System.Drawing.Point(785, 450)
        Me.RadTS.Name = "RadTS"
        Me.RadTS.Size = New System.Drawing.Size(85, 45)
        Me.RadTS.TabIndex = 214
        Me.RadTS.Text = "&TS"
        Me.RadTS.UseVisualStyleBackColor = True
        '
        'RadMP4
        '
        Me.RadMP4.AutoSize = True
        Me.RadMP4.Location = New System.Drawing.Point(674, 450)
        Me.RadMP4.Name = "RadMP4"
        Me.RadMP4.Size = New System.Drawing.Size(119, 45)
        Me.RadMP4.TabIndex = 211
        Me.RadMP4.Text = "MP&4"
        Me.RadMP4.UseVisualStyleBackColor = True
        '
        'LblContainerFormat
        '
        Me.LblContainerFormat.AutoSize = True
        Me.LblContainerFormat.Location = New System.Drawing.Point(510, 450)
        Me.LblContainerFormat.Name = "LblContainerFormat"
        Me.LblContainerFormat.Size = New System.Drawing.Size(178, 41)
        Me.LblContainerFormat.TabIndex = 123
        Me.LblContainerFormat.Text = "封装格式："
        '
        'ChkAutoExit
        '
        Me.ChkAutoExit.AutoSize = True
        Me.ChkAutoExit.Checked = True
        Me.ChkAutoExit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutoExit.Location = New System.Drawing.Point(1069, 450)
        Me.ChkAutoExit.Name = "ChkAutoExit"
        Me.ChkAutoExit.Size = New System.Drawing.Size(178, 45)
        Me.ChkAutoExit.TabIndex = 219
        Me.ChkAutoExit.Text = "自动退出"
        Me.ChkAutoExit.UseVisualStyleBackColor = True
        '
        'ChkIsLive
        '
        Me.ChkIsLive.AutoSize = True
        Me.ChkIsLive.Location = New System.Drawing.Point(759, 515)
        Me.ChkIsLive.Name = "ChkIsLive"
        Me.ChkIsLive.Size = New System.Drawing.Size(114, 45)
        Me.ChkIsLive.TabIndex = 234
        Me.ChkIsLive.Text = "直播"
        Me.ChkIsLive.UseVisualStyleBackColor = True
        '
        'ChkTwoPass
        '
        Me.ChkTwoPass.AutoSize = True
        Me.ChkTwoPass.Location = New System.Drawing.Point(995, 515)
        Me.ChkTwoPass.Name = "ChkTwoPass"
        Me.ChkTwoPass.Size = New System.Drawing.Size(215, 45)
        Me.ChkTwoPass.TabIndex = 237
        Me.ChkTwoPass.Text = "2-Pass校验"
        Me.ChkTwoPass.UseVisualStyleBackColor = True
        '
        'ChkAutoStart
        '
        Me.ChkAutoStart.AutoSize = True
        Me.ChkAutoStart.Checked = True
        Me.ChkAutoStart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutoStart.Location = New System.Drawing.Point(1069, 379)
        Me.ChkAutoStart.Name = "ChkAutoStart"
        Me.ChkAutoStart.Size = New System.Drawing.Size(178, 45)
        Me.ChkAutoStart.TabIndex = 208
        Me.ChkAutoStart.Text = "自动开始"
        Me.ChkAutoStart.UseVisualStyleBackColor = True
        '
        'ChkMute
        '
        Me.ChkMute.AutoSize = True
        Me.ChkMute.Location = New System.Drawing.Point(759, 587)
        Me.ChkMute.Name = "ChkMute"
        Me.ChkMute.Size = New System.Drawing.Size(210, 45)
        Me.ChkMute.TabIndex = 254
        Me.ChkMute.Text = "关闭提示音"
        Me.ChkMute.UseVisualStyleBackColor = True
        '
        'ChkNoStream
        '
        Me.ChkNoStream.AutoSize = True
        Me.ChkNoStream.Location = New System.Drawing.Point(517, 587)
        Me.ChkNoStream.Name = "ChkNoStream"
        Me.ChkNoStream.Size = New System.Drawing.Size(210, 45)
        Me.ChkNoStream.TabIndex = 251
        Me.ChkNoStream.Text = "仅下载列表"
        Me.ChkNoStream.UseVisualStyleBackColor = True
        '
        'ChkAutoSelectHigh
        '
        Me.ChkAutoSelectHigh.AutoSize = True
        Me.ChkAutoSelectHigh.Location = New System.Drawing.Point(517, 719)
        Me.ChkAutoSelectHigh.Name = "ChkAutoSelectHigh"
        Me.ChkAutoSelectHigh.Size = New System.Drawing.Size(178, 45)
        Me.ChkAutoSelectHigh.TabIndex = 274
        Me.ChkAutoSelectHigh.Text = "最高质量"
        Me.ChkAutoSelectHigh.UseVisualStyleBackColor = True
        '
        'ChkThreads
        '
        Me.ChkThreads.AutoSize = True
        Me.ChkThreads.Location = New System.Drawing.Point(759, 719)
        Me.ChkThreads.Name = "ChkThreads"
        Me.ChkThreads.Size = New System.Drawing.Size(210, 45)
        Me.ChkThreads.TabIndex = 291
        Me.ChkThreads.Text = "下载线程数"
        Me.ChkThreads.UseVisualStyleBackColor = True
        '
        'ChkTimeout
        '
        Me.ChkTimeout.AutoSize = True
        Me.ChkTimeout.Location = New System.Drawing.Point(759, 652)
        Me.ChkTimeout.Name = "ChkTimeout"
        Me.ChkTimeout.Size = New System.Drawing.Size(200, 45)
        Me.ChkTimeout.TabIndex = 257
        Me.ChkTimeout.Text = "超时(毫秒)"
        Me.ChkTimeout.UseVisualStyleBackColor = True
        '
        'TxtThreads
        '
        Me.TxtThreads.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtThreads.Location = New System.Drawing.Point(978, 724)
        Me.TxtThreads.Name = "TxtThreads"
        Me.TxtThreads.Size = New System.Drawing.Size(232, 44)
        Me.TxtThreads.TabIndex = 292
        '
        'TxtTimeout
        '
        Me.TxtTimeout.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtTimeout.Location = New System.Drawing.Point(978, 654)
        Me.TxtTimeout.Name = "TxtTimeout"
        Me.TxtTimeout.Size = New System.Drawing.Size(232, 44)
        Me.TxtTimeout.TabIndex = 258
        '
        'ChkMinimize
        '
        Me.ChkMinimize.AutoSize = True
        Me.ChkMinimize.Checked = True
        Me.ChkMinimize.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMinimize.Location = New System.Drawing.Point(517, 515)
        Me.ChkMinimize.Name = "ChkMinimize"
        Me.ChkMinimize.Size = New System.Drawing.Size(146, 45)
        Me.ChkMinimize.TabIndex = 231
        Me.ChkMinimize.Text = "最小化"
        Me.ChkMinimize.UseVisualStyleBackColor = True
        '
        'LblOptions
        '
        Me.LblOptions.AutoSize = True
        Me.LblOptions.Location = New System.Drawing.Point(510, 794)
        Me.LblOptions.Name = "LblOptions"
        Me.LblOptions.Size = New System.Drawing.Size(178, 41)
        Me.LblOptions.TabIndex = 144
        Me.LblOptions.Text = "更多参数："
        '
        'TxtOptions
        '
        Me.TxtOptions.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtOptions.Location = New System.Drawing.Point(674, 794)
        Me.TxtOptions.MaxLength = 0
        Me.TxtOptions.Multiline = True
        Me.TxtOptions.Name = "TxtOptions"
        Me.TxtOptions.Size = New System.Drawing.Size(573, 47)
        Me.TxtOptions.TabIndex = 301
        '
        'LblTask
        '
        Me.LblTask.AutoSize = True
        Me.LblTask.Location = New System.Drawing.Point(1284, 377)
        Me.LblTask.Name = "LblTask"
        Me.LblTask.Size = New System.Drawing.Size(104, 41)
        Me.LblTask.TabIndex = 146
        Me.LblTask.Text = "[任务]"
        '
        'BtnTaskStart
        '
        Me.BtnTaskStart.BackColor = System.Drawing.Color.DarkGreen
        Me.BtnTaskStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTaskStart.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTaskStart.ForeColor = System.Drawing.Color.White
        Me.BtnTaskStart.Location = New System.Drawing.Point(1288, 684)
        Me.BtnTaskStart.Name = "BtnTaskStart"
        Me.BtnTaskStart.Size = New System.Drawing.Size(286, 63)
        Me.BtnTaskStart.TabIndex = 531
        Me.BtnTaskStart.Text = "启动任务(&S)"
        Me.BtnTaskStart.UseVisualStyleBackColor = False
        '
        'BtnTaskQueue
        '
        Me.BtnTaskQueue.BackColor = System.Drawing.Color.SteelBlue
        Me.BtnTaskQueue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTaskQueue.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTaskQueue.ForeColor = System.Drawing.Color.White
        Me.BtnTaskQueue.Location = New System.Drawing.Point(1288, 552)
        Me.BtnTaskQueue.Name = "BtnTaskQueue"
        Me.BtnTaskQueue.Size = New System.Drawing.Size(286, 61)
        Me.BtnTaskQueue.TabIndex = 511
        Me.BtnTaskQueue.Text = "添加至队列(&Q)"
        Me.BtnTaskQueue.UseVisualStyleBackColor = False
        '
        'ChkTaskSuspend
        '
        Me.ChkTaskSuspend.BackColor = System.Drawing.Color.Olive
        Me.ChkTaskSuspend.Checked = True
        Me.ChkTaskSuspend.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkTaskSuspend.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ChkTaskSuspend.ForeColor = System.Drawing.Color.White
        Me.ChkTaskSuspend.Location = New System.Drawing.Point(1288, 487)
        Me.ChkTaskSuspend.Name = "ChkTaskSuspend"
        Me.ChkTaskSuspend.Size = New System.Drawing.Size(286, 59)
        Me.ChkTaskSuspend.TabIndex = 505
        Me.ChkTaskSuspend.Text = "挂起队列(&P)"
        Me.ChkTaskSuspend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkTaskSuspend.UseVisualStyleBackColor = False
        '
        'BtnTaskOverride
        '
        Me.BtnTaskOverride.BackColor = System.Drawing.Color.Teal
        Me.BtnTaskOverride.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTaskOverride.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnTaskOverride.ForeColor = System.Drawing.Color.White
        Me.BtnTaskOverride.Location = New System.Drawing.Point(1288, 619)
        Me.BtnTaskOverride.Name = "BtnTaskOverride"
        Me.BtnTaskOverride.Size = New System.Drawing.Size(286, 63)
        Me.BtnTaskOverride.TabIndex = 521
        Me.BtnTaskOverride.Text = "应用参数(&A)"
        Me.BtnTaskOverride.UseVisualStyleBackColor = False
        '
        'LblQueue
        '
        Me.LblQueue.AutoSize = True
        Me.LblQueue.Location = New System.Drawing.Point(1315, 22)
        Me.LblQueue.Name = "LblQueue"
        Me.LblQueue.Size = New System.Drawing.Size(104, 41)
        Me.LblQueue.TabIndex = 151
        Me.LblQueue.Text = "[队列]"
        '
        'OfdAddLocal
        '
        Me.OfdAddLocal.Filter = "所有文件|*.*"
        Me.OfdAddLocal.Multiselect = True
        '
        'TmrQueue
        '
        Me.TmrQueue.Interval = 5000
        '
        'ChkNoAutoClean
        '
        Me.ChkNoAutoClean.AutoSize = True
        Me.ChkNoAutoClean.Location = New System.Drawing.Point(517, 652)
        Me.ChkNoAutoClean.Name = "ChkNoAutoClean"
        Me.ChkNoAutoClean.Size = New System.Drawing.Size(210, 45)
        Me.ChkNoAutoClean.TabIndex = 271
        Me.ChkNoAutoClean.Text = "不清除缓存"
        Me.ChkNoAutoClean.UseVisualStyleBackColor = True
        '
        'LblIdentifier
        '
        Me.LblIdentifier.AutoSize = True
        Me.LblIdentifier.Location = New System.Drawing.Point(14, 553)
        Me.LblIdentifier.Name = "LblIdentifier"
        Me.LblIdentifier.Size = New System.Drawing.Size(178, 41)
        Me.LblIdentifier.TabIndex = 532
        Me.LblIdentifier.Text = "鉴别字符串"
        '
        'TxtIdentifier
        '
        Me.TxtIdentifier.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtIdentifier.Location = New System.Drawing.Point(185, 553)
        Me.TxtIdentifier.Name = "TxtIdentifier"
        Me.TxtIdentifier.Size = New System.Drawing.Size(209, 44)
        Me.TxtIdentifier.TabIndex = 103
        '
        'BtnIdentifierClear
        '
        Me.BtnIdentifierClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIdentifierClear.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnIdentifierClear.Location = New System.Drawing.Point(407, 552)
        Me.BtnIdentifierClear.Name = "BtnIdentifierClear"
        Me.BtnIdentifierClear.Size = New System.Drawing.Size(50, 51)
        Me.BtnIdentifierClear.TabIndex = 104
        Me.BtnIdentifierClear.Text = "←"
        Me.BtnIdentifierClear.UseVisualStyleBackColor = False
        '
        'TmrClipboard
        '
        Me.TmrClipboard.Interval = 1000
        '
        'ChkAutoPowerOff
        '
        Me.ChkAutoPowerOff.BackColor = System.Drawing.Color.Teal
        Me.ChkAutoPowerOff.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ChkAutoPowerOff.ForeColor = System.Drawing.Color.White
        Me.ChkAutoPowerOff.Location = New System.Drawing.Point(1288, 430)
        Me.ChkAutoPowerOff.Name = "ChkAutoPowerOff"
        Me.ChkAutoPowerOff.Size = New System.Drawing.Size(286, 51)
        Me.ChkAutoPowerOff.TabIndex = 501
        Me.ChkAutoPowerOff.Text = "完成后关机(&D)"
        Me.ChkAutoPowerOff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkAutoPowerOff.UseVisualStyleBackColor = False
        '
        'BtnExport
        '
        Me.BtnExport.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExport.Font = New System.Drawing.Font("微软雅黑", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnExport.ForeColor = System.Drawing.Color.White
        Me.BtnExport.Location = New System.Drawing.Point(1494, 107)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(80, 71)
        Me.BtnExport.TabIndex = 33
        Me.BtnExport.Tag = ""
        Me.BtnExport.Text = "o"
        Me.BtnExport.UseVisualStyleBackColor = False
        '
        'SFDExport
        '
        Me.SFDExport.Filter = "文本文档|*.txt|所有文件|*.*"
        Me.SFDExport.Title = "导出任务列表"
        '
        'TotIdentifier
        '
        Me.TotIdentifier.AutoPopDelay = 20000
        Me.TotIdentifier.InitialDelay = 50
        Me.TotIdentifier.ReshowDelay = 100
        Me.TotIdentifier.Tag = ""
        Me.TotIdentifier.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TotIdentifier.ToolTipTitle = "提示"
        '
        'TotTaskName
        '
        Me.TotTaskName.AutoPopDelay = 20000
        Me.TotTaskName.InitialDelay = 50
        Me.TotTaskName.ReshowDelay = 100
        Me.TotTaskName.Tag = ""
        Me.TotTaskName.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.TotTaskName.ToolTipTitle = "提示"
        '
        'BtnTop
        '
        Me.BtnTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTop.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnTop.ForeColor = System.Drawing.Color.White
        Me.BtnTop.Location = New System.Drawing.Point(1408, 266)
        Me.BtnTop.Name = "BtnTop"
        Me.BtnTop.Size = New System.Drawing.Size(80, 71)
        Me.BtnTop.TabIndex = 38
        Me.BtnTop.Text = "▲"
        Me.BtnTop.UseVisualStyleBackColor = False
        '
        'BtnBottom
        '
        Me.BtnBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBottom.Font = New System.Drawing.Font("微软雅黑", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnBottom.ForeColor = System.Drawing.Color.White
        Me.BtnBottom.Location = New System.Drawing.Point(1494, 266)
        Me.BtnBottom.Name = "BtnBottom"
        Me.BtnBottom.Size = New System.Drawing.Size(80, 71)
        Me.BtnBottom.TabIndex = 39
        Me.BtnBottom.Text = "▼"
        Me.BtnBottom.UseVisualStyleBackColor = False
        '
        'Batch
        '
        Me.AllowDrop = True
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1605, 869)
        Me.Controls.Add(Me.BtnBottom)
        Me.Controls.Add(Me.BtnTop)
        Me.Controls.Add(Me.BtnExport)
        Me.Controls.Add(Me.ChkAutoPowerOff)
        Me.Controls.Add(Me.BtnIdentifierClear)
        Me.Controls.Add(Me.TxtIdentifier)
        Me.Controls.Add(Me.LblIdentifier)
        Me.Controls.Add(Me.ChkNoAutoClean)
        Me.Controls.Add(Me.LblQueue)
        Me.Controls.Add(Me.BtnTaskOverride)
        Me.Controls.Add(Me.ChkTaskSuspend)
        Me.Controls.Add(Me.BtnTaskQueue)
        Me.Controls.Add(Me.BtnTaskStart)
        Me.Controls.Add(Me.LblTask)
        Me.Controls.Add(Me.TxtOptions)
        Me.Controls.Add(Me.LblOptions)
        Me.Controls.Add(Me.ChkMinimize)
        Me.Controls.Add(Me.TxtTimeout)
        Me.Controls.Add(Me.TxtThreads)
        Me.Controls.Add(Me.ChkTimeout)
        Me.Controls.Add(Me.ChkThreads)
        Me.Controls.Add(Me.ChkAutoSelectHigh)
        Me.Controls.Add(Me.ChkNoStream)
        Me.Controls.Add(Me.ChkMute)
        Me.Controls.Add(Me.ChkAutoStart)
        Me.Controls.Add(Me.ChkTwoPass)
        Me.Controls.Add(Me.ChkIsLive)
        Me.Controls.Add(Me.ChkAutoExit)
        Me.Controls.Add(Me.BtnWorkPathBrowse)
        Me.Controls.Add(Me.TxtWorkPath)
        Me.Controls.Add(Me.LblWorkPath)
        Me.Controls.Add(Me.RadBinary)
        Me.Controls.Add(Me.RadTS)
        Me.Controls.Add(Me.RadMP4)
        Me.Controls.Add(Me.LblContainerFormat)
        Me.Controls.Add(Me.LblArgs)
        Me.Controls.Add(Me.TxtURL)
        Me.Controls.Add(Me.LblURL)
        Me.Controls.Add(Me.NumSeqAscend)
        Me.Controls.Add(Me.LblSeqAscend)
        Me.Controls.Add(Me.NumSeqSupplement)
        Me.Controls.Add(Me.LblSeqSupplement)
        Me.Controls.Add(Me.BtnAddLocal)
        Me.Controls.Add(Me.NumSeqCurrent)
        Me.Controls.Add(Me.LblSeqCurrent)
        Me.Controls.Add(Me.NumConcurrent)
        Me.Controls.Add(Me.LblConcurrent)
        Me.Controls.Add(Me.LblSequence)
        Me.Controls.Add(Me.TxtTaskName)
        Me.Controls.Add(Me.LblTaskName)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnRemoveAll)
        Me.Controls.Add(Me.LsvQueue)
        Me.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.Name = "Batch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "批量任务控制器"
        CType(Me.NumConcurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSeqCurrent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSeqSupplement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumSeqAscend, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Public WithEvents LsvQueue As ListView
    Friend WithEvents ClhStatus As ColumnHeader
    Friend WithEvents ClhTaskName As ColumnHeader
    Friend WithEvents ClhURL As ColumnHeader
    Friend WithEvents ClhOptions As ColumnHeader
    Friend WithEvents BtnRemoveAll As Button
    Friend WithEvents BtnRemove As Button
    Friend WithEvents LblTaskName As Label
    Friend WithEvents TxtTaskName As TextBox
    Friend WithEvents LblSequence As Label
    Friend WithEvents LblConcurrent As Label
    Friend WithEvents NumConcurrent As NumericUpDown
    Friend WithEvents LblSeqCurrent As Label
    Friend WithEvents NumSeqCurrent As NumericUpDown
    Friend WithEvents BtnAddLocal As Button
    Friend WithEvents NumSeqSupplement As NumericUpDown
    Friend WithEvents LblSeqSupplement As Label
    Friend WithEvents NumSeqAscend As NumericUpDown
    Friend WithEvents LblSeqAscend As Label
    Friend WithEvents LblURL As Label
    Friend WithEvents TxtURL As TextBox
    Friend WithEvents LblArgs As Label
    Friend WithEvents BtnWorkPathBrowse As Button
    Friend WithEvents TxtWorkPath As TextBox
    Friend WithEvents LblWorkPath As Label
    Friend WithEvents RadBinary As RadioButton
    Friend WithEvents RadTS As RadioButton
    Friend WithEvents RadMP4 As RadioButton
    Friend WithEvents LblContainerFormat As Label
    Friend WithEvents ChkAutoExit As CheckBox
    Friend WithEvents ChkIsLive As CheckBox
    Friend WithEvents ChkTwoPass As CheckBox
    Friend WithEvents ChkAutoStart As CheckBox
    Friend WithEvents ChkMute As CheckBox
    Friend WithEvents ChkNoStream As CheckBox
    Friend WithEvents ChkAutoSelectHigh As CheckBox
    Friend WithEvents ChkThreads As CheckBox
    Friend WithEvents ChkTimeout As CheckBox
    Friend WithEvents TxtThreads As TextBox
    Friend WithEvents TxtTimeout As TextBox
    Friend WithEvents ChkMinimize As CheckBox
    Friend WithEvents LblOptions As Label
    Friend WithEvents TxtOptions As TextBox
    Friend WithEvents LblTask As Label
    Friend WithEvents BtnTaskStart As Button
    Friend WithEvents BtnTaskQueue As Button
    Friend WithEvents ChkTaskSuspend As CheckBox
    Friend WithEvents BtnTaskOverride As Button
    Friend WithEvents LblQueue As Label
    Friend WithEvents FbdWorkPath As FolderBrowserDialog
    Friend WithEvents OfdAddLocal As OpenFileDialog
    Friend WithEvents TmrQueue As Timer
    Friend WithEvents ChkNoAutoClean As CheckBox
    Friend WithEvents LblIdentifier As Label
    Friend WithEvents TxtIdentifier As TextBox
    Friend WithEvents BtnIdentifierClear As Button
    Friend WithEvents TmrClipboard As Timer
    Friend WithEvents ChkAutoPowerOff As CheckBox
    Friend WithEvents BtnExport As Button
    Friend WithEvents SFDExport As SaveFileDialog
    Friend WithEvents TotIdentifier As ToolTip
    Friend WithEvents TotTaskName As ToolTip
    Friend WithEvents BtnTop As Button
    Friend WithEvents BtnBottom As Button
End Class
