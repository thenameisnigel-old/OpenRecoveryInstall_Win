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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ROMToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecoveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFromArchiveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateFomWebToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ROMToolsToolStripMenuItem, Me.RecoveryToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.WindowToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ROMToolsToolStripMenuItem
        '
        Me.ROMToolsToolStripMenuItem.Name = "ROMToolsToolStripMenuItem"
        Me.ROMToolsToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.ROMToolsToolStripMenuItem.Text = "ROM Tools"
        '
        'RecoveryToolStripMenuItem
        '
        Me.RecoveryToolStripMenuItem.Name = "RecoveryToolStripMenuItem"
        Me.RecoveryToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.RecoveryToolStripMenuItem.Text = "Recovery"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "Extras"
        '
        'WindowToolStripMenuItem
        '
        Me.WindowToolStripMenuItem.Name = "WindowToolStripMenuItem"
        Me.WindowToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.WindowToolStripMenuItem.Text = "Window"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForUpdatesToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(248, 64)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "I accept the terms of use."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(720, 440)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(280, 64)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "I DO NOT accept the terms of use."
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateFromArchiveToolStripMenuItem, Me.UpdateFomWebToolStripMenuItem})
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check for Updates..."
        '
        'UpdateFromArchiveToolStripMenuItem
        '
        Me.UpdateFromArchiveToolStripMenuItem.Name = "UpdateFromArchiveToolStripMenuItem"
        Me.UpdateFromArchiveToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UpdateFromArchiveToolStripMenuItem.Text = "Update from archive..."
        '
        'UpdateFomWebToolStripMenuItem
        '
        Me.UpdateFomWebToolStripMenuItem.Name = "UpdateFomWebToolStripMenuItem"
        Me.UpdateFomWebToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.UpdateFomWebToolStripMenuItem.Text = "Update fom web"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(189, 185)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(607, 249)
        Me.WebBrowser1.TabIndex = 3
        Me.WebBrowser1.Url = New System.Uri("https://raw.github.com/thenameisnigel/hudson/master/notice.txt", System.UriKind.Absolute)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(154, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(703, 56)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "OpenRecovery Installer Alpha" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(235, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "This is an extremely alpha version of potentionally dangerous software." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not" & _
    " expect this to work perfectly, and ALWAYS REMEMBER to go to the help menu and c" & _
    "heck for updates." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 516)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Welcome to OpenRecovery Installer!"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ROMToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecoveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForUpdatesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFromArchiveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateFomWebToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
