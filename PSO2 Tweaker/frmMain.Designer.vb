﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtHTML = New System.Windows.Forms.TextBox()
        Me.rtbDebug = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.chkRemoveCensor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRemovePC = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRemoveVita = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager()
        Me.PB1 = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.QatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
        Me.chkRemoveNVidia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRemoveSEGA = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkSwapOP = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.Label1 = New DevComponents.DotNetBar.LabelX()
        Me.lblDirectory = New DevComponents.DotNetBar.LabelX()
        Me.lblStatus = New DevComponents.DotNetBar.LabelX()
        Me.chkRestoreCensor = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRestorePC = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRestoreVita = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRestoreNVidia = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.chkRestoreSEGA = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.btnApplyChanges = New DevComponents.DotNetBar.ButtonX()
        Me.btnLaunchPSO2 = New DevComponents.DotNetBar.ButtonX()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmRestartDownload = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelDownloadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelProcessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.seconds = New System.Windows.Forms.Timer(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.RibbonControl1 = New DevComponents.DotNetBar.RibbonControl()
        Me.Office2007StartButton1 = New DevComponents.DotNetBar.Office2007StartButton()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer2 = New DevComponents.DotNetBar.ItemContainer()
        Me.ItemContainer3 = New DevComponents.DotNetBar.ItemContainer()
        Me.Button1 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonInstall = New DevComponents.DotNetBar.ButtonItem()
        Me.btnENPatch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnLargeFiles = New DevComponents.DotNetBar.ButtonItem()
        Me.btnStory = New DevComponents.DotNetBar.ButtonItem()
        Me.btnStoryPatchNew = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRussianPatch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnInstallSpanishPatch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnJPETrials = New DevComponents.DotNetBar.ButtonItem()
        Me.btnJPEnemyNames = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreBackups = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreENBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreLargeFilesBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreStoryBackup = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreJPNames = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRestoreJPETrials = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem1 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnUninstallENPatch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnUninstallLargeFiles = New DevComponents.DotNetBar.ButtonItem()
        Me.btnUninstallStory = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem2 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnAnalyze = New DevComponents.DotNetBar.ButtonItem()
        Me.Button2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem10 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnConnection = New DevComponents.DotNetBar.ButtonItem()
        Me.btnGameguard = New DevComponents.DotNetBar.ButtonItem()
        Me.Button6 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnFixPermissions = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCopyInfo = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem17 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnResetTweaker = New DevComponents.DotNetBar.ButtonItem()
        Me.btnResumePatching = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem12 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnTerminate = New DevComponents.DotNetBar.ButtonItem()
        Me.btnOtherStuff = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem7 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnPredownloadLobbyVideos = New DevComponents.DotNetBar.ButtonItem()
        Me.btnChooseProxyServer = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRevertPSO2ProxyToJP = New DevComponents.DotNetBar.ButtonItem()
        Me.btnClearSACache = New DevComponents.DotNetBar.ButtonItem()
        Me.btnInstallPSO2 = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem3 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnBumped = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCirno = New DevComponents.DotNetBar.ButtonItem()
        Me.btnArksCash = New DevComponents.DotNetBar.ButtonItem()
        Me.btnErrors = New DevComponents.DotNetBar.ButtonItem()
        Me.btnOfficialPSO2JP = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRegistration = New DevComponents.DotNetBar.ButtonItem()
        Me.btnTweaker = New DevComponents.DotNetBar.ButtonItem()
        Me.btnRunPSO2Linux = New DevComponents.DotNetBar.ButtonItem()
        Me.btnSymbolEditor = New DevComponents.DotNetBar.ButtonItem()
        Me.btnEXPFULL = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDonations = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDonateToBumped = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDonateToCirno = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDonateToENPatchHost = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDonateToTweaker = New DevComponents.DotNetBar.ButtonItem()
        Me.btnNewShit = New DevComponents.DotNetBar.ButtonItem()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.btnDownloadPrepatch = New DevComponents.DotNetBar.ButtonItem()
        Me.btnCheckForStoryUpdates = New DevComponents.DotNetBar.ButtonItem()
        Me.chkAlwaysOnTop = New DevComponents.DotNetBar.CheckBoxItem()
        Me.chkItemTranslation = New DevComponents.DotNetBar.CheckBoxItem()
        Me.btnConfigureItemTranslation = New DevComponents.DotNetBar.ButtonItem()
        Me.ItemContainer4 = New DevComponents.DotNetBar.ItemContainer()
        Me.btnPSO2Options = New DevComponents.DotNetBar.ButtonItem()
        Me.btnOptions = New DevComponents.DotNetBar.ButtonItem()
        Me.btnExit = New DevComponents.DotNetBar.ButtonItem()
        Me.LabelItem1 = New DevComponents.DotNetBar.LabelItem()
        Me.StyleManager2 = New DevComponents.DotNetBar.StyleManager()
        Me.btnAnnouncements = New DevComponents.DotNetBar.ButtonX()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.txtPSO2DefaultINI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.tmrCheckServerStatus = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHTML
        '
        resources.ApplyResources(Me.txtHTML, "txtHTML")
        Me.txtHTML.Name = "txtHTML"
        '
        'rtbDebug
        '
        Me.rtbDebug.BackColor = System.Drawing.Color.White
        Me.rtbDebug.HideSelection = False
        resources.ApplyResources(Me.rtbDebug, "rtbDebug")
        Me.rtbDebug.Name = "rtbDebug"
        Me.rtbDebug.ReadOnly = True
        Me.rtbDebug.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenPatchDialog"
        '
        'chkRemoveCensor
        '
        resources.ApplyResources(Me.chkRemoveCensor, "chkRemoveCensor")
        Me.chkRemoveCensor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRemoveCensor.BackgroundStyle.Class = ""
        Me.chkRemoveCensor.Name = "chkRemoveCensor"
        Me.chkRemoveCensor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRemovePC
        '
        resources.ApplyResources(Me.chkRemovePC, "chkRemovePC")
        Me.chkRemovePC.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRemovePC.BackgroundStyle.Class = ""
        Me.chkRemovePC.Name = "chkRemovePC"
        Me.chkRemovePC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRemoveVita
        '
        resources.ApplyResources(Me.chkRemoveVita, "chkRemoveVita")
        Me.chkRemoveVita.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRemoveVita.BackgroundStyle.Class = ""
        Me.chkRemoveVita.Name = "chkRemoveVita"
        Me.chkRemoveVita.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerColorTint = System.Drawing.SystemColors.ActiveBorder
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        '
        'PB1
        '
        '
        '
        '
        Me.PB1.BackgroundStyle.Class = ""
        Me.PB1.ChunkColor2 = System.Drawing.Color.Red
        resources.ApplyResources(Me.PB1, "PB1")
        Me.PB1.Name = "PB1"
        Me.PB1.TabStop = False
        Me.PB1.TextVisible = True
        '
        'QatCustomizeItem1
        '
        Me.QatCustomizeItem1.Name = "QatCustomizeItem1"
        '
        'chkRemoveNVidia
        '
        resources.ApplyResources(Me.chkRemoveNVidia, "chkRemoveNVidia")
        Me.chkRemoveNVidia.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRemoveNVidia.BackgroundStyle.Class = ""
        Me.chkRemoveNVidia.Name = "chkRemoveNVidia"
        Me.chkRemoveNVidia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRemoveSEGA
        '
        resources.ApplyResources(Me.chkRemoveSEGA, "chkRemoveSEGA")
        Me.chkRemoveSEGA.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRemoveSEGA.BackgroundStyle.Class = ""
        Me.chkRemoveSEGA.Name = "chkRemoveSEGA"
        Me.chkRemoveSEGA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkSwapOP
        '
        resources.ApplyResources(Me.chkSwapOP, "chkSwapOP")
        Me.chkSwapOP.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkSwapOP.BackgroundStyle.Class = ""
        Me.chkSwapOP.Name = "chkSwapOP"
        Me.chkSwapOP.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.Label1.BackgroundStyle.Class = ""
        Me.Label1.Name = "Label1"
        '
        'lblDirectory
        '
        Me.lblDirectory.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblDirectory.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.lblDirectory, "lblDirectory")
        Me.lblDirectory.Name = "lblDirectory"
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.lblStatus.BackgroundStyle.Class = ""
        resources.ApplyResources(Me.lblStatus, "lblStatus")
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'chkRestoreCensor
        '
        resources.ApplyResources(Me.chkRestoreCensor, "chkRestoreCensor")
        Me.chkRestoreCensor.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRestoreCensor.BackgroundStyle.Class = ""
        Me.chkRestoreCensor.Name = "chkRestoreCensor"
        Me.chkRestoreCensor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRestorePC
        '
        resources.ApplyResources(Me.chkRestorePC, "chkRestorePC")
        Me.chkRestorePC.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRestorePC.BackgroundStyle.Class = ""
        Me.chkRestorePC.Name = "chkRestorePC"
        Me.chkRestorePC.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRestoreVita
        '
        resources.ApplyResources(Me.chkRestoreVita, "chkRestoreVita")
        Me.chkRestoreVita.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRestoreVita.BackgroundStyle.Class = ""
        Me.chkRestoreVita.Name = "chkRestoreVita"
        Me.chkRestoreVita.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRestoreNVidia
        '
        resources.ApplyResources(Me.chkRestoreNVidia, "chkRestoreNVidia")
        Me.chkRestoreNVidia.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRestoreNVidia.BackgroundStyle.Class = ""
        Me.chkRestoreNVidia.Name = "chkRestoreNVidia"
        Me.chkRestoreNVidia.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'chkRestoreSEGA
        '
        resources.ApplyResources(Me.chkRestoreSEGA, "chkRestoreSEGA")
        Me.chkRestoreSEGA.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.chkRestoreSEGA.BackgroundStyle.Class = ""
        Me.chkRestoreSEGA.Name = "chkRestoreSEGA"
        Me.chkRestoreSEGA.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnApplyChanges
        '
        Me.btnApplyChanges.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnApplyChanges.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnApplyChanges, "btnApplyChanges")
        Me.btnApplyChanges.Name = "btnApplyChanges"
        Me.btnApplyChanges.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'btnLaunchPSO2
        '
        Me.btnLaunchPSO2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLaunchPSO2.BackColor = System.Drawing.Color.Transparent
        Me.btnLaunchPSO2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnLaunchPSO2, "btnLaunchPSO2")
        Me.btnLaunchPSO2.Name = "btnLaunchPSO2"
        Me.btnLaunchPSO2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmRestartDownload, Me.CancelDownloadToolStripMenuItem, Me.CancelProcessToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.ContextMenuStrip1, "ContextMenuStrip1")
        '
        'tsmRestartDownload
        '
        Me.tsmRestartDownload.Name = "tsmRestartDownload"
        resources.ApplyResources(Me.tsmRestartDownload, "tsmRestartDownload")
        '
        'CancelDownloadToolStripMenuItem
        '
        Me.CancelDownloadToolStripMenuItem.Name = "CancelDownloadToolStripMenuItem"
        resources.ApplyResources(Me.CancelDownloadToolStripMenuItem, "CancelDownloadToolStripMenuItem")
        '
        'CancelProcessToolStripMenuItem
        '
        Me.CancelProcessToolStripMenuItem.Name = "CancelProcessToolStripMenuItem"
        resources.ApplyResources(Me.CancelProcessToolStripMenuItem, "CancelProcessToolStripMenuItem")
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'seconds
        '
        Me.seconds.Interval = 10
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'WebBrowser1
        '
        resources.ApplyResources(Me.WebBrowser1, "WebBrowser1")
        Me.WebBrowser1.Name = "WebBrowser1"
        '
        'WebBrowser2
        '
        resources.ApplyResources(Me.WebBrowser2, "WebBrowser2")
        Me.WebBrowser2.Name = "WebBrowser2"
        '
        'WebBrowser3
        '
        resources.ApplyResources(Me.WebBrowser3, "WebBrowser3")
        Me.WebBrowser3.Name = "WebBrowser3"
        '
        'RibbonControl1
        '
        '
        '
        '
        Me.RibbonControl1.BackgroundStyle.Class = ""
        Me.RibbonControl1.CaptionVisible = True
        resources.ApplyResources(Me.RibbonControl1, "RibbonControl1")
        Me.RibbonControl1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Office2007StartButton1, Me.LabelItem1})
        Me.RibbonControl1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.RibbonControl1.TabGroupHeight = 14
        '
        'Office2007StartButton1
        '
        Me.Office2007StartButton1.AutoExpandOnClick = True
        Me.Office2007StartButton1.CanCustomize = False
        Me.Office2007StartButton1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.Image
        Me.Office2007StartButton1.ImagePaddingHorizontal = 2
        Me.Office2007StartButton1.ImagePaddingVertical = 2
        Me.Office2007StartButton1.Name = "Office2007StartButton1"
        Me.Office2007StartButton1.ShowSubItems = False
        Me.Office2007StartButton1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        resources.ApplyResources(Me.Office2007StartButton1, "Office2007StartButton1")
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.Class = "RibbonFileMenuContainer"
        Me.ItemContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer2, Me.ItemContainer4})
        '
        'ItemContainer2
        '
        '
        '
        '
        Me.ItemContainer2.BackgroundStyle.Class = "RibbonFileMenuTwoColumnContainer"
        Me.ItemContainer2.ItemSpacing = 0
        Me.ItemContainer2.Name = "ItemContainer2"
        Me.ItemContainer2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer3})
        '
        'ItemContainer3
        '
        '
        '
        '
        Me.ItemContainer3.BackgroundStyle.Class = "RibbonFileMenuColumnOneContainer"
        Me.ItemContainer3.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemContainer3.MinimumSize = New System.Drawing.Size(120, 0)
        Me.ItemContainer3.Name = "ItemContainer3"
        Me.ItemContainer3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.Button1, Me.ButtonInstall, Me.btnRestoreBackups, Me.ButtonItem1, Me.ButtonItem2, Me.btnOtherStuff, Me.ButtonItem3, Me.btnDonations, Me.btnNewShit, Me.ButtonItem5, Me.btnDownloadPrepatch, Me.btnCheckForStoryUpdates, Me.chkAlwaysOnTop, Me.chkItemTranslation, Me.btnConfigureItemTranslation})
        '
        'Button1
        '
        Me.Button1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.Button1.Name = "Button1"
        Me.Button1.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.Button1, "Button1")
        '
        'ButtonInstall
        '
        Me.ButtonInstall.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonInstall.Name = "ButtonInstall"
        Me.ButtonInstall.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnENPatch, Me.btnLargeFiles, Me.btnStory, Me.btnStoryPatchNew, Me.btnRussianPatch, Me.btnInstallSpanishPatch, Me.btnJPETrials, Me.btnJPEnemyNames})
        Me.ButtonInstall.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.ButtonInstall, "ButtonInstall")
        '
        'btnENPatch
        '
        Me.btnENPatch.Name = "btnENPatch"
        resources.ApplyResources(Me.btnENPatch, "btnENPatch")
        '
        'btnLargeFiles
        '
        Me.btnLargeFiles.Name = "btnLargeFiles"
        resources.ApplyResources(Me.btnLargeFiles, "btnLargeFiles")
        '
        'btnStory
        '
        Me.btnStory.Name = "btnStory"
        resources.ApplyResources(Me.btnStory, "btnStory")
        '
        'btnStoryPatchNew
        '
        Me.btnStoryPatchNew.Name = "btnStoryPatchNew"
        resources.ApplyResources(Me.btnStoryPatchNew, "btnStoryPatchNew")
        '
        'btnRussianPatch
        '
        Me.btnRussianPatch.Name = "btnRussianPatch"
        resources.ApplyResources(Me.btnRussianPatch, "btnRussianPatch")
        '
        'btnInstallSpanishPatch
        '
        Me.btnInstallSpanishPatch.Name = "btnInstallSpanishPatch"
        resources.ApplyResources(Me.btnInstallSpanishPatch, "btnInstallSpanishPatch")
        Me.btnInstallSpanishPatch.Visible = False
        '
        'btnJPETrials
        '
        Me.btnJPETrials.Name = "btnJPETrials"
        resources.ApplyResources(Me.btnJPETrials, "btnJPETrials")
        '
        'btnJPEnemyNames
        '
        Me.btnJPEnemyNames.Name = "btnJPEnemyNames"
        resources.ApplyResources(Me.btnJPEnemyNames, "btnJPEnemyNames")
        '
        'btnRestoreBackups
        '
        Me.btnRestoreBackups.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnRestoreBackups.Name = "btnRestoreBackups"
        Me.btnRestoreBackups.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnRestoreENBackup, Me.btnRestoreLargeFilesBackup, Me.btnRestoreStoryBackup, Me.btnRestoreJPNames, Me.btnRestoreJPETrials})
        Me.btnRestoreBackups.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnRestoreBackups, "btnRestoreBackups")
        '
        'btnRestoreENBackup
        '
        Me.btnRestoreENBackup.Name = "btnRestoreENBackup"
        resources.ApplyResources(Me.btnRestoreENBackup, "btnRestoreENBackup")
        '
        'btnRestoreLargeFilesBackup
        '
        Me.btnRestoreLargeFilesBackup.Name = "btnRestoreLargeFilesBackup"
        resources.ApplyResources(Me.btnRestoreLargeFilesBackup, "btnRestoreLargeFilesBackup")
        '
        'btnRestoreStoryBackup
        '
        Me.btnRestoreStoryBackup.Name = "btnRestoreStoryBackup"
        resources.ApplyResources(Me.btnRestoreStoryBackup, "btnRestoreStoryBackup")
        '
        'btnRestoreJPNames
        '
        Me.btnRestoreJPNames.Name = "btnRestoreJPNames"
        resources.ApplyResources(Me.btnRestoreJPNames, "btnRestoreJPNames")
        Me.btnRestoreJPNames.Visible = False
        '
        'btnRestoreJPETrials
        '
        Me.btnRestoreJPETrials.Name = "btnRestoreJPETrials"
        resources.ApplyResources(Me.btnRestoreJPETrials, "btnRestoreJPETrials")
        Me.btnRestoreJPETrials.Visible = False
        '
        'ButtonItem1
        '
        Me.ButtonItem1.Name = "ButtonItem1"
        Me.ButtonItem1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnUninstallENPatch, Me.btnUninstallLargeFiles, Me.btnUninstallStory})
        resources.ApplyResources(Me.ButtonItem1, "ButtonItem1")
        '
        'btnUninstallENPatch
        '
        Me.btnUninstallENPatch.Name = "btnUninstallENPatch"
        resources.ApplyResources(Me.btnUninstallENPatch, "btnUninstallENPatch")
        '
        'btnUninstallLargeFiles
        '
        Me.btnUninstallLargeFiles.Name = "btnUninstallLargeFiles"
        resources.ApplyResources(Me.btnUninstallLargeFiles, "btnUninstallLargeFiles")
        '
        'btnUninstallStory
        '
        Me.btnUninstallStory.Name = "btnUninstallStory"
        resources.ApplyResources(Me.btnUninstallStory, "btnUninstallStory")
        '
        'ButtonItem2
        '
        Me.ButtonItem2.Name = "ButtonItem2"
        Me.ButtonItem2.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnAnalyze, Me.Button2, Me.ButtonItem10, Me.btnConnection, Me.btnGameguard, Me.Button6, Me.btnFixPermissions, Me.btnCopyInfo, Me.ButtonItem17, Me.btnResetTweaker, Me.btnResumePatching, Me.ButtonItem12, Me.btnTerminate})
        resources.ApplyResources(Me.ButtonItem2, "ButtonItem2")
        '
        'btnAnalyze
        '
        Me.btnAnalyze.Name = "btnAnalyze"
        resources.ApplyResources(Me.btnAnalyze, "btnAnalyze")
        '
        'Button2
        '
        Me.Button2.Name = "Button2"
        resources.ApplyResources(Me.Button2, "Button2")
        '
        'ButtonItem10
        '
        Me.ButtonItem10.Name = "ButtonItem10"
        resources.ApplyResources(Me.ButtonItem10, "ButtonItem10")
        '
        'btnConnection
        '
        Me.btnConnection.Name = "btnConnection"
        resources.ApplyResources(Me.btnConnection, "btnConnection")
        Me.btnConnection.Visible = False
        '
        'btnGameguard
        '
        Me.btnGameguard.Name = "btnGameguard"
        resources.ApplyResources(Me.btnGameguard, "btnGameguard")
        '
        'Button6
        '
        Me.Button6.Name = "Button6"
        resources.ApplyResources(Me.Button6, "Button6")
        '
        'btnFixPermissions
        '
        Me.btnFixPermissions.Name = "btnFixPermissions"
        resources.ApplyResources(Me.btnFixPermissions, "btnFixPermissions")
        '
        'btnCopyInfo
        '
        Me.btnCopyInfo.Name = "btnCopyInfo"
        resources.ApplyResources(Me.btnCopyInfo, "btnCopyInfo")
        '
        'ButtonItem17
        '
        Me.ButtonItem17.Name = "ButtonItem17"
        resources.ApplyResources(Me.ButtonItem17, "ButtonItem17")
        '
        'btnResetTweaker
        '
        Me.btnResetTweaker.Name = "btnResetTweaker"
        resources.ApplyResources(Me.btnResetTweaker, "btnResetTweaker")
        '
        'btnResumePatching
        '
        Me.btnResumePatching.Name = "btnResumePatching"
        resources.ApplyResources(Me.btnResumePatching, "btnResumePatching")
        '
        'ButtonItem12
        '
        Me.ButtonItem12.Name = "ButtonItem12"
        resources.ApplyResources(Me.ButtonItem12, "ButtonItem12")
        '
        'btnTerminate
        '
        Me.btnTerminate.Name = "btnTerminate"
        resources.ApplyResources(Me.btnTerminate, "btnTerminate")
        '
        'btnOtherStuff
        '
        Me.btnOtherStuff.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnOtherStuff.Name = "btnOtherStuff"
        Me.btnOtherStuff.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem7, Me.btnPredownloadLobbyVideos, Me.btnChooseProxyServer, Me.btnRevertPSO2ProxyToJP, Me.btnClearSACache, Me.btnInstallPSO2})
        Me.btnOtherStuff.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnOtherStuff, "btnOtherStuff")
        '
        'ButtonItem7
        '
        Me.ButtonItem7.Name = "ButtonItem7"
        resources.ApplyResources(Me.ButtonItem7, "ButtonItem7")
        '
        'btnPredownloadLobbyVideos
        '
        Me.btnPredownloadLobbyVideos.Name = "btnPredownloadLobbyVideos"
        resources.ApplyResources(Me.btnPredownloadLobbyVideos, "btnPredownloadLobbyVideos")
        Me.btnPredownloadLobbyVideos.Visible = False
        '
        'btnChooseProxyServer
        '
        Me.btnChooseProxyServer.Name = "btnChooseProxyServer"
        resources.ApplyResources(Me.btnChooseProxyServer, "btnChooseProxyServer")
        '
        'btnRevertPSO2ProxyToJP
        '
        Me.btnRevertPSO2ProxyToJP.Name = "btnRevertPSO2ProxyToJP"
        resources.ApplyResources(Me.btnRevertPSO2ProxyToJP, "btnRevertPSO2ProxyToJP")
        '
        'btnClearSACache
        '
        Me.btnClearSACache.Name = "btnClearSACache"
        resources.ApplyResources(Me.btnClearSACache, "btnClearSACache")
        '
        'btnInstallPSO2
        '
        Me.btnInstallPSO2.Name = "btnInstallPSO2"
        resources.ApplyResources(Me.btnInstallPSO2, "btnInstallPSO2")
        '
        'ButtonItem3
        '
        Me.ButtonItem3.Name = "ButtonItem3"
        Me.ButtonItem3.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnBumped, Me.btnCirno, Me.btnArksCash, Me.btnErrors, Me.btnOfficialPSO2JP, Me.btnRegistration, Me.btnTweaker, Me.btnRunPSO2Linux, Me.btnSymbolEditor, Me.btnEXPFULL})
        resources.ApplyResources(Me.ButtonItem3, "ButtonItem3")
        '
        'btnBumped
        '
        Me.btnBumped.Name = "btnBumped"
        resources.ApplyResources(Me.btnBumped, "btnBumped")
        '
        'btnCirno
        '
        Me.btnCirno.Name = "btnCirno"
        resources.ApplyResources(Me.btnCirno, "btnCirno")
        '
        'btnArksCash
        '
        Me.btnArksCash.Name = "btnArksCash"
        resources.ApplyResources(Me.btnArksCash, "btnArksCash")
        '
        'btnErrors
        '
        Me.btnErrors.Name = "btnErrors"
        resources.ApplyResources(Me.btnErrors, "btnErrors")
        '
        'btnOfficialPSO2JP
        '
        Me.btnOfficialPSO2JP.Name = "btnOfficialPSO2JP"
        resources.ApplyResources(Me.btnOfficialPSO2JP, "btnOfficialPSO2JP")
        '
        'btnRegistration
        '
        Me.btnRegistration.Name = "btnRegistration"
        resources.ApplyResources(Me.btnRegistration, "btnRegistration")
        '
        'btnTweaker
        '
        Me.btnTweaker.Name = "btnTweaker"
        resources.ApplyResources(Me.btnTweaker, "btnTweaker")
        '
        'btnRunPSO2Linux
        '
        Me.btnRunPSO2Linux.Name = "btnRunPSO2Linux"
        resources.ApplyResources(Me.btnRunPSO2Linux, "btnRunPSO2Linux")
        '
        'btnSymbolEditor
        '
        Me.btnSymbolEditor.Name = "btnSymbolEditor"
        resources.ApplyResources(Me.btnSymbolEditor, "btnSymbolEditor")
        '
        'btnEXPFULL
        '
        Me.btnEXPFULL.Name = "btnEXPFULL"
        resources.ApplyResources(Me.btnEXPFULL, "btnEXPFULL")
        '
        'btnDonations
        '
        Me.btnDonations.Name = "btnDonations"
        Me.btnDonations.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnDonateToBumped, Me.btnDonateToCirno, Me.btnDonateToENPatchHost, Me.btnDonateToTweaker})
        resources.ApplyResources(Me.btnDonations, "btnDonations")
        '
        'btnDonateToBumped
        '
        Me.btnDonateToBumped.Name = "btnDonateToBumped"
        resources.ApplyResources(Me.btnDonateToBumped, "btnDonateToBumped")
        '
        'btnDonateToCirno
        '
        Me.btnDonateToCirno.Name = "btnDonateToCirno"
        resources.ApplyResources(Me.btnDonateToCirno, "btnDonateToCirno")
        '
        'btnDonateToENPatchHost
        '
        Me.btnDonateToENPatchHost.Name = "btnDonateToENPatchHost"
        resources.ApplyResources(Me.btnDonateToENPatchHost, "btnDonateToENPatchHost")
        '
        'btnDonateToTweaker
        '
        Me.btnDonateToTweaker.Name = "btnDonateToTweaker"
        resources.ApplyResources(Me.btnDonateToTweaker, "btnDonateToTweaker")
        '
        'btnNewShit
        '
        Me.btnNewShit.BeginGroup = True
        Me.btnNewShit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnNewShit.Name = "btnNewShit"
        Me.btnNewShit.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnNewShit, "btnNewShit")
        Me.btnNewShit.Visible = False
        '
        'ButtonItem5
        '
        Me.ButtonItem5.BeginGroup = True
        Me.ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.ButtonItem5, "ButtonItem5")
        '
        'btnDownloadPrepatch
        '
        Me.btnDownloadPrepatch.Name = "btnDownloadPrepatch"
        resources.ApplyResources(Me.btnDownloadPrepatch, "btnDownloadPrepatch")
        '
        'btnCheckForStoryUpdates
        '
        Me.btnCheckForStoryUpdates.Name = "btnCheckForStoryUpdates"
        resources.ApplyResources(Me.btnCheckForStoryUpdates, "btnCheckForStoryUpdates")
        '
        'chkAlwaysOnTop
        '
        Me.chkAlwaysOnTop.Name = "chkAlwaysOnTop"
        resources.ApplyResources(Me.chkAlwaysOnTop, "chkAlwaysOnTop")
        '
        'chkItemTranslation
        '
        Me.chkItemTranslation.Name = "chkItemTranslation"
        resources.ApplyResources(Me.chkItemTranslation, "chkItemTranslation")
        '
        'btnConfigureItemTranslation
        '
        Me.btnConfigureItemTranslation.Name = "btnConfigureItemTranslation"
        resources.ApplyResources(Me.btnConfigureItemTranslation, "btnConfigureItemTranslation")
        '
        'ItemContainer4
        '
        '
        '
        '
        Me.ItemContainer4.BackgroundStyle.Class = "RibbonFileMenuBottomContainer"
        Me.ItemContainer4.HorizontalItemAlignment = DevComponents.DotNetBar.eHorizontalItemsAlignment.Right
        Me.ItemContainer4.Name = "ItemContainer4"
        Me.ItemContainer4.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.btnPSO2Options, Me.btnOptions, Me.btnExit})
        '
        'btnPSO2Options
        '
        Me.btnPSO2Options.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnPSO2Options.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnPSO2Options.Name = "btnPSO2Options"
        Me.btnPSO2Options.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnPSO2Options, "btnPSO2Options")
        '
        'btnOptions
        '
        Me.btnOptions.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnOptions.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnOptions, "btnOptions")
        '
        'btnExit
        '
        Me.btnExit.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
        Me.btnExit.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.btnExit.Name = "btnExit"
        Me.btnExit.SubItemsExpandWidth = 24
        resources.ApplyResources(Me.btnExit, "btnExit")
        '
        'LabelItem1
        '
        Me.LabelItem1.Name = "LabelItem1"
        resources.ApplyResources(Me.LabelItem1, "LabelItem1")
        '
        'StyleManager2
        '
        Me.StyleManager2.ManagerColorTint = System.Drawing.SystemColors.ActiveBorder
        Me.StyleManager2.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        '
        'btnAnnouncements
        '
        Me.btnAnnouncements.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnAnnouncements.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.btnAnnouncements, "btnAnnouncements")
        Me.btnAnnouncements.Name = "btnAnnouncements"
        Me.btnAnnouncements.Shape = New DevComponents.DotNetBar.RoundRectangleShapeDescriptor()
        Me.btnAnnouncements.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'WebBrowser4
        '
        resources.ApplyResources(Me.WebBrowser4, "WebBrowser4")
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.Url = New System.Uri("", System.UriKind.Relative)
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.BackColor = System.Drawing.Color.Transparent
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        resources.ApplyResources(Me.ButtonX1, "ButtonX1")
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        '
        'txtPSO2DefaultINI
        '
        resources.ApplyResources(Me.txtPSO2DefaultINI, "txtPSO2DefaultINI")
        Me.txtPSO2DefaultINI.Name = "txtPSO2DefaultINI"
        Me.txtPSO2DefaultINI.ReadOnly = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'LabelX1
        '
        resources.ApplyResources(Me.LabelX1, "LabelX1")
        Me.LabelX1.BackColor = System.Drawing.Color.Transparent
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.Name = "LabelX1"
        '
        'tmrCheckServerStatus
        '
        Me.tmrCheckServerStatus.Enabled = True
        Me.tmrCheckServerStatus.Interval = 120000
        '
        'frmMain
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabelX1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnApplyChanges)
        Me.Controls.Add(Me.txtPSO2DefaultINI)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me.WebBrowser4)
        Me.Controls.Add(Me.btnAnnouncements)
        Me.Controls.Add(Me.WebBrowser3)
        Me.Controls.Add(Me.WebBrowser2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnLaunchPSO2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblDirectory)
        Me.Controls.Add(Me.chkRestoreSEGA)
        Me.Controls.Add(Me.chkRestoreNVidia)
        Me.Controls.Add(Me.chkRestoreVita)
        Me.Controls.Add(Me.chkRestorePC)
        Me.Controls.Add(Me.chkRestoreCensor)
        Me.Controls.Add(Me.chkRemoveSEGA)
        Me.Controls.Add(Me.chkRemoveNVidia)
        Me.Controls.Add(Me.PB1)
        Me.Controls.Add(Me.chkRemoveVita)
        Me.Controls.Add(Me.chkRemovePC)
        Me.Controls.Add(Me.chkRemoveCensor)
        Me.Controls.Add(Me.rtbDebug)
        Me.Controls.Add(Me.txtHTML)
        Me.Controls.Add(Me.chkSwapOP)
        Me.Controls.Add(Me.RibbonControl1)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FlattenMDIBorder = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHTML As System.Windows.Forms.TextBox
    Public WithEvents rtbDebug As System.Windows.Forms.RichTextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chkRemoveCensor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRemovePC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRemoveVita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents PB1 As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents QatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
    Friend WithEvents chkRemoveNVidia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRemoveSEGA As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkSwapOP As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Label1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblDirectory As DevComponents.DotNetBar.LabelX
    Friend WithEvents lblStatus As DevComponents.DotNetBar.LabelX
    Friend WithEvents chkRestoreCensor As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRestorePC As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRestoreVita As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRestoreNVidia As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents chkRestoreSEGA As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents btnApplyChanges As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnLaunchPSO2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents CancelDownloadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents seconds As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents CancelProcessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents RibbonControl1 As DevComponents.DotNetBar.RibbonControl
    Friend WithEvents Office2007StartButton1 As DevComponents.DotNetBar.Office2007StartButton
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer2 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents ItemContainer4 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents btnOptions As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnExit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents StyleManager2 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents btnPSO2Options As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAnnouncements As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelItem1 As DevComponents.DotNetBar.LabelItem
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtPSO2DefaultINI As System.Windows.Forms.TextBox
    Friend WithEvents tsmRestartDownload As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents tmrCheckServerStatus As System.Windows.Forms.Timer
    Friend WithEvents ItemContainer3 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents Button1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonInstall As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnENPatch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnLargeFiles As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnStory As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRussianPatch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnInstallSpanishPatch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreBackups As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreENBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreLargeFilesBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreStoryBackup As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreJPNames As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRestoreJPETrials As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem1 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUninstallENPatch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUninstallLargeFiles As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnUninstallStory As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnAnalyze As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Button2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem10 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnConnection As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnGameguard As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents Button6 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnFixPermissions As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCopyInfo As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem17 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnResetTweaker As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnResumePatching As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem12 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnTerminate As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnOtherStuff As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem7 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnPredownloadLobbyVideos As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnChooseProxyServer As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRevertPSO2ProxyToJP As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnClearSACache As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnInstallPSO2 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem3 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnBumped As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCirno As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnArksCash As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnErrors As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnOfficialPSO2JP As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRegistration As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnTweaker As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnRunPSO2Linux As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnSymbolEditor As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnEXPFULL As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDonations As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDonateToBumped As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDonateToCirno As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDonateToENPatchHost As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDonateToTweaker As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnNewShit As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnDownloadPrepatch As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnCheckForStoryUpdates As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents chkAlwaysOnTop As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents chkItemTranslation As DevComponents.DotNetBar.CheckBoxItem
    Friend WithEvents btnConfigureItemTranslation As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnStoryPatchNew As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnJPETrials As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents btnJPEnemyNames As DevComponents.DotNetBar.ButtonItem

End Class
