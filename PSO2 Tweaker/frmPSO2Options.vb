﻿Imports System.IO
Imports System.Runtime.InteropServices
Imports PSO2_Tweaker.My

Public Class FrmPso2Options
    ReadOnly _documents As String = (Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\")
    ReadOnly _usersettingsfile As String = (_documents & "SEGA\PHANTASYSTARONLINE2\user.pso2")
    'Shared INICache As New Dictionary(Of String, String)

    Private Sub frmPSO2Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Not File.Exists(_usersettingsfile) Then
                File.WriteAllText(_usersettingsfile, Program.MainForm.txtPSO2DefaultINI.Text)
                Helper.WriteDebugInfo("Generating new PSO2 Settings file... Done!")
            End If

            SuspendLayout()

            Dim tmpBackColor As Color = BackColor
            TabControlPanel1.Style.BackColor1.Color = tmpBackColor
            TabControlPanel1.Style.BackColor2.Color = tmpBackColor
            TabControlPanel1.StyleMouseOver.BackColor1.Color = tmpBackColor
            TabControlPanel1.StyleMouseOver.BackColor2.Color = tmpBackColor
            TabControlPanel1.StyleMouseDown.BackColor1.Color = tmpBackColor
            TabControlPanel1.StyleMouseDown.BackColor2.Color = tmpBackColor

            TabControlPanel2.Style.BackColor1.Color = tmpBackColor
            TabControlPanel2.Style.BackColor2.Color = tmpBackColor
            TabControlPanel2.StyleMouseOver.BackColor1.Color = tmpBackColor
            TabControlPanel2.StyleMouseOver.BackColor2.Color = tmpBackColor
            TabControlPanel2.StyleMouseDown.BackColor1.Color = tmpBackColor
            TabControlPanel2.StyleMouseDown.BackColor2.Color = tmpBackColor

            TabControlPanel3.Style.BackColor1.Color = tmpBackColor
            TabControlPanel3.Style.BackColor2.Color = tmpBackColor
            TabControlPanel3.StyleMouseOver.BackColor1.Color = tmpBackColor
            TabControlPanel3.StyleMouseOver.BackColor2.Color = tmpBackColor
            TabControlPanel3.StyleMouseDown.BackColor1.Color = tmpBackColor
            TabControlPanel3.StyleMouseDown.BackColor2.Color = tmpBackColor

            TabControlPanel4.Style.BackColor1.Color = tmpBackColor
            TabControlPanel4.Style.BackColor2.Color = tmpBackColor
            TabControlPanel4.StyleMouseOver.BackColor1.Color = tmpBackColor
            TabControlPanel4.StyleMouseOver.BackColor2.Color = tmpBackColor
            TabControlPanel4.StyleMouseDown.BackColor1.Color = tmpBackColor
            TabControlPanel4.StyleMouseDown.BackColor2.Color = tmpBackColor

            TabControlPanel5.Style.BackColor1.Color = tmpBackColor
            TabControlPanel5.Style.BackColor2.Color = tmpBackColor
            TabControlPanel5.StyleMouseOver.BackColor1.Color = tmpBackColor
            TabControlPanel5.StyleMouseOver.BackColor2.Color = tmpBackColor
            TabControlPanel5.StyleMouseDown.BackColor1.Color = tmpBackColor
            TabControlPanel5.StyleMouseDown.BackColor2.Color = tmpBackColor

            Dim devM As External.Devmode
            devM.dmDeviceName = New String(Chr(0), 32)
            devM.dmFormName = New String(Chr(0), 32)
            devM.dmSize = CShort(Marshal.SizeOf(GetType(External.Devmode)))

            Dim modeIndex As Integer = 0
            ' 0 = The first mode
            While External.EnumDisplaySettings(Nothing, modeIndex, devM)
                ' Mode found
                If Not ComboBoxEx5.Items.Contains(devM.dmPelsWidth & "x" & devM.dmPelsHeight) Then ComboBoxEx5.Items.Add(devM.dmPelsWidth & "x" & devM.dmPelsHeight)

                ' The next mode
                modeIndex += 1
            End While

            Dim currentHeight As String = ReadINISetting("Height3d")
            Dim currentWidth As String = ReadINISetting("Width3d")

            Dim fullRes As String = currentWidth & "x" & currentHeight

            ComboBoxEx5.Text = fullRes
            Slider1.Value = Convert.ToInt32(ReadINISetting("DrawLevel"))
            SBGM.Value = Convert.ToInt32(ReadINISetting("Bgm"))
            SSE.Value = Convert.ToInt32(ReadINISetting("Se"))
            SVOICE.Value = Convert.ToInt32(ReadINISetting("Voice"))
            SIGM.Value = Convert.ToInt32(ReadINISetting("Movie"))
            ComboBoxEx1.SelectedIndex = Convert.ToInt32(ReadINISetting("TextureResolution"))
            ComboBoxEx7.SelectedIndex = Convert.ToInt32(ReadINISetting("InterfaceSize"))
            ComboBoxEx6.Text = ReadINISetting("FrameKeep") & " FPS"
            If ComboBoxEx6.Text = "0 FPS" Then ComboBoxEx6.Text = "Unlimited FPS"
            If ReadINISetting("ShaderQuality") = "true" Then ComboBoxEx2.SelectedIndex = 0
            If ReadINISetting("ShaderQuality") = "false" Then ComboBoxEx2.SelectedIndex = 1
            If ReadINISetting("MoviePlay") = "true" Then ComboBoxEx3.SelectedIndex = 0
            If ReadINISetting("MoviePlay") = "false" Then ComboBoxEx3.SelectedIndex = 1
            If ReadINISetting("FullScreen") = "false" Then
                ComboBoxEx4.SelectedIndex = 0
            End If
            If ReadINISetting("FullScreen") = "true" Then
                ComboBoxEx4.SelectedIndex = 1
            End If
            If ReadINISetting("VirtualFullScreen") = "true" Then
                ComboBoxEx4.SelectedIndex = 2
                'Disable resolution thingie
            End If
            'ComboBoxEx5.Text = ReadINISetting("Width", 240) & "x" & ReadINISetting("Height", 240)
            If Not ComboBoxEx5.Items.Contains(ComboBoxEx5.Text) Then ComboBoxEx5.SelectedIndex = 0
            CheckBoxX1.Checked = False
            If ReadINISetting("Y") = "99999" Then
                If ReadINISetting("X") = "99999" Then
                    CheckBoxX1.Checked = True
                End If
            End If
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        Finally
            ResumeLayout(False)
        End Try
    End Sub

    Private Function ReadIniSetting(settingToRead As String, Optional ByVal lineToStartAt As Integer = 0) As String
        Try
            'Dim returnValue = ""
            'If INICache.TryGetValue(SettingToRead, returnValue) Then Return returnValue

            Dim textLines As String() = File.ReadAllLines(_usersettingsfile)
            For i As Integer = lineToStartAt To (textLines.Length - 1)
                If Not String.IsNullOrEmpty(textLines(i)) Then
                    If textLines(i).Contains(" " & settingToRead & " ") Then
                        Dim strLine As String = textLines(i).Replace(vbTab, "")
                        Dim strReturn As String() = strLine.Split("="c)
                        Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "").Replace(" "c, "")
                        'If FinalString IsNot Nothing Then INICache.Add(SettingToRead, FinalString)
                        Return finalString
                    End If
                End If
            Next
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
        Return ""
    End Function

    Private Sub SaveIniSetting(settingToSave As String, value As String)
        Try
            'INICache(SettingToSave) = Value

            TextBoxX1.Text = ""
            Dim settingString As String = File.ReadAllText(_usersettingsfile)
            Dim textLines As String() = settingString.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            Dim i As Integer
            Dim j As Integer
            For i = 0 To (textLines.Length - 1)
                If textLines(i).Contains(" " & settingToSave & " ") Then
                    Dim strLine As String = textLines(i).Replace(vbTab, "")
                    Dim strReturn As String() = strLine.Split("="c)
                    Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "")
                    textLines(i) = textLines(i).Replace(finalString, (" " & value))
                    For j = 0 To textLines.Length
                        If j + 1 = textLines.Length Then
                            TextBoxX1.AppendText("}")
                            File.Delete(_usersettingsfile)
                            File.WriteAllText(_usersettingsfile, TextBoxX1.Text)
                            Return
                        End If
                        TextBoxX1.AppendText(textLines(j) & vbCrLf)
                    Next j
                End If
            Next i
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
    End Sub

    Private Sub SaveResolutionHeight(value As String)
        Try
            TextBoxX1.Text = ""
            Dim settingString As String = File.ReadAllText(_usersettingsfile)
            Dim textLines As String() = settingString.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            Dim i As Integer
            Dim j As Integer
            Dim contains As Boolean = False
            For i = 0 To (textLines.Length - 1)
                If textLines(i).Contains("Windows = {") Then
                    For x As Integer = 1 To 9
                        If textLines(i + x).Contains("Height =") Then
                            i += x
                            contains = True
                            Exit For
                        End If
                    Next x

                    If Not contains Then
                        Helper.WriteDebugInfo("Couldn't find Height in user settings. This is OKAY. If you notice your resolution not changing, try resetting your PSO2 Settings to default. If everything works, feel free to ignore this error.")
                        Return
                    End If

                    Dim strLine As String = textLines(i).Replace(vbTab, "")
                    Dim strReturn As String() = strLine.Split("="c)
                    Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "")
                    textLines(i) = textLines(i).Replace(finalString, (" " & value))
                    For j = 0 To textLines.Length
                        If j + 1 = textLines.Length Then
                            TextBoxX1.AppendText("}")
                            File.Delete(_usersettingsfile)
                            File.WriteAllText(_usersettingsfile, TextBoxX1.Text)
                            Return
                        End If
                        TextBoxX1.AppendText(textLines(j) & vbCrLf)
                    Next j
                End If
            Next i
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
    End Sub

    Private Sub SaveResolutionWidth(value As String)
        Try
            TextBoxX1.Text = ""
            Dim settingString As String = File.ReadAllText(_usersettingsfile)
            Dim textLines As String() = settingString.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            Dim i As Integer
            Dim j As Integer
            Dim contains As Boolean = False
            For i = 0 To (textLines.Length - 1)
                If textLines(i).Contains("Windows = {") Then
                    For x As Integer = 1 To 9
                        If textLines(i + x).Contains("Width =") Then
                            i += x
                            contains = True
                            Exit For
                        End If
                    Next x

                    If Not contains Then
                        Helper.WriteDebugInfo("Couldn't find Width in user settings. This is OKAY. If you notice your resolution not changing, try resetting your PSO2 Settings to default. If everything works, feel free to ignore this error.")
                        Return
                    End If

                    Dim strLine As String = textLines(i).Replace(vbTab, "")
                    Dim strReturn As String() = strLine.Split("="c)
                    Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "")
                    textLines(i) = textLines(i).Replace(finalString, (" " & value))

                    For j = 0 To textLines.Length
                        If j + 1 = textLines.Length Then
                            TextBoxX1.AppendText("}")
                            File.Delete(_usersettingsfile)
                            File.WriteAllText(_usersettingsfile, TextBoxX1.Text)
                            Return
                        End If
                        TextBoxX1.AppendText(textLines(j) & vbCrLf)
                    Next j

                End If
            Next i
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
    End Sub

    Private Sub SaveResolutionHeight3D(value As String)
        Try
            TextBoxX1.Text = ""
            Dim settingString As String = File.ReadAllText(_usersettingsfile)
            Dim textLines As String() = settingString.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            Dim i As Integer
            Dim j As Integer
            Dim contains As Boolean = False
            For i = 0 To (textLines.Length - 1)
                If textLines(i).Contains("Windows = {") Then
                    For x As Integer = 1 To 9
                        If textLines(i + x).Contains("Height3d =") Then
                            i += x
                            contains = True
                            Exit For
                        End If
                    Next x

                    If Not contains Then
                        Helper.WriteDebugInfo("Couldn't find Height3D in user settings. This is OKAY. If you notice your resolution not changing, try resetting your PSO2 Settings to default. If everything works, feel free to ignore this error.")
                        Return
                    End If

                    Dim strLine As String = textLines(i).Replace(vbTab, "")
                    Dim strReturn As String() = strLine.Split("="c)
                    Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "")
                    textLines(i) = textLines(i).Replace(finalString, (" " & value))
                    For j = 0 To textLines.Length
                        If j + 1 = textLines.Length Then
                            TextBoxX1.AppendText("}")
                            File.Delete(_usersettingsfile)
                            File.WriteAllText(_usersettingsfile, TextBoxX1.Text)
                            Return
                        End If
                        TextBoxX1.AppendText(textLines(j) & vbCrLf)
                    Next j
                End If
            Next i
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
    End Sub

    Private Sub SaveResolutionWidth3D(value As String)
        Try
            TextBoxX1.Text = ""
            Dim settingString As String = File.ReadAllText(_usersettingsfile)
            Dim textLines As String() = settingString.Split(Environment.NewLine.ToCharArray, StringSplitOptions.RemoveEmptyEntries)
            Dim i As Integer
            Dim j As Integer
            Dim contains As Boolean = False
            For i = 0 To (textLines.Length - 1)
                If textLines(i).Contains("Windows = {") Then
                    For x As Integer = 1 To 9
                        If textLines(i + x).Contains("Width3d =") Then
                            i += x
                            contains = True
                            Exit For
                        End If
                    Next x

                    If Not contains Then
                        Helper.WriteDebugInfo("Couldn't find Width3D in user settings. This is OKAY. If you notice your resolution not changing, try resetting your PSO2 Settings to default. If everything works, feel free to ignore this error.")
                        Return
                    End If

                    Dim strLine As String = textLines(i).Replace(vbTab, "")
                    Dim strReturn As String() = strLine.Split("="c)
                    Dim finalString As String = strReturn(1).Replace("""", "").Replace(","c, "")
                    textLines(i) = textLines(i).Replace(finalString, (" " & value))

                    For j = 0 To textLines.Length
                        If j + 1 = textLines.Length Then
                            TextBoxX1.AppendText("}")
                            File.Delete(_usersettingsfile)
                            File.WriteAllText(_usersettingsfile, TextBoxX1.Text)
                            Return
                        End If
                        TextBoxX1.AppendText(textLines(j) & vbCrLf)
                    Next j

                End If
            Next i
        Catch ex As Exception
            Helper.Log(ex.Message)
            Helper.WriteDebugInfo(Resources.strERROR & ex.Message)
        End Try
    End Sub
    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        'Try
        Helper.Log("Saving Draw Level...")
        SaveINISetting("DrawLevel", Slider1.Value.ToString())
        Helper.Log("Saving Texture Resolution...")
        SaveINISetting("TextureResolution", ComboBoxEx1.SelectedIndex.ToString())
        Helper.Log("Saving Interface Size...")
        SaveINISetting("InterfaceSize", ComboBoxEx7.SelectedIndex.ToString())
        Helper.Log("Saving Shader Quality...")
        If ComboBoxEx2.SelectedIndex = 0 Then SaveINISetting("ShaderQuality", "true")
        If ComboBoxEx2.SelectedIndex = 1 Then SaveINISetting("ShaderQuality", "false")
        Helper.Log("Saving Movie Play...")
        If ComboBoxEx3.SelectedIndex = 0 Then SaveINISetting("MoviePlay", "true")
        If ComboBoxEx3.SelectedIndex = 1 Then SaveINISetting("MoviePlay", "false")

        If ComboBoxEx4.SelectedIndex = 0 Then
            Helper.Log("Saving Window Mode (Windowed)...")
            SaveINISetting("FullScreen", "false")
            SaveINISetting("VirtualFullScreen", "false")
        End If

        If ComboBoxEx4.SelectedIndex = 1 Then
            Helper.Log("Saving Window Mode (Fullscreen)...")
            SaveINISetting("FullScreen", "true")
            SaveINISetting("VirtualFullScreen", "false")
        End If

        If ComboBoxEx4.SelectedIndex = 2 Then
            Helper.Log("Saving Window Mode (Virtual Fullscreen)...")
            SaveINISetting("FullScreen", "false")
            SaveINISetting("VirtualFullScreen", "true")
        End If

        If Not ComboBoxEx5.Items.Contains(ComboBoxEx5.Text) Then
            MsgBox("Please select a supported resolution!")
            Return
        End If

        Helper.Log("Saving Resolution...")
        'If ComboBoxEx5.SelectedText <> "x" Then
        Dim strResolution As String = ComboBoxEx5.SelectedItem.ToString()

        Dim realResolution As String() = strResolution.Split("x"c)
        SaveResolutionWidth(realResolution(0))
        SaveResolutionHeight(realResolution(1))
        SaveResolutionWidth3D(realResolution(0))
        SaveResolutionHeight3D(realResolution(1))
        'End If

        Dim fps As String = ComboBoxEx6.SelectedItem.ToString().Replace(" FPS", "").Replace("Unlimited", "0")

        Helper.Log("Saving FPS...")
        SaveINISetting("FrameKeep", fps)

        Helper.Log("Saving Volume...")
        SaveINISetting("Bgm", SBGM.Value.ToString())
        SaveINISetting("Voice", SVOICE.Value.ToString())
        SaveINISetting("Movie", SIGM.Value.ToString())
        SaveINISetting("Se", SSE.Value.ToString())

        If CheckBoxX1.Checked Then
            Helper.Log("Disabling Interface...")
            If ReadINISetting("X") <> "99999" Then
                If ReadINISetting("Y") <> "99999" Then
                    RegKey.SetValue(Of String)(RegKey.OldX, ReadINISetting("X"))
                    RegKey.SetValue(Of String)(RegKey.OldY, ReadINISetting("Y"))
                    SaveINISetting("X", "99999")
                    SaveINISetting("Y", "99999")
                End If
            End If
        End If

        If Not CheckBoxX1.Checked Then
            Helper.Log("Enabling Interface...")
            If ReadINISetting("X") = "99999" Then
                If ReadINISetting("Y") = "99999" Then
                    SaveINISetting("X", RegKey.GetValue(Of String)(RegKey.OldX))
                    SaveINISetting("Y", RegKey.GetValue(Of String)(RegKey.OldY))
                End If
            End If
        End If

        MsgBox("Settings saved!")
        'Catch ex As Exception
        'My.Program.MainForm.Log(ex.Message)
        'My.Program.MainForm.WriteDebugInfo(My.Resources.strERROR & ex.Message)
        'End Try
    End Sub

    Private Sub SBGM_ValueChanged(sender As Object, e As EventArgs) Handles SBGM.ValueChanged
        SBGM.Text = "Background Music Volume - " & SBGM.Value
    End Sub

    Private Sub SSE_ValueChanged(sender As Object, e As EventArgs) Handles SSE.ValueChanged
        SSE.Text = "Sound Effect Volume - " & SSE.Value
    End Sub

    Private Sub SVOICE_ValueChanged(sender As Object, e As EventArgs) Handles SVOICE.ValueChanged
        SVOICE.Text = "Character Voice Volume - " & SVOICE.Value
    End Sub

    Private Sub SIGM_ValueChanged(sender As Object, e As EventArgs) Handles SIGM.ValueChanged
        SIGM.Text = "In-Game Movie Volume - " & SIGM.Value
    End Sub
End Class
