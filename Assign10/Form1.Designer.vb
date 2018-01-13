<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.ClockControl1 = New ClockControl.ClockControl()
        Me.cmdNightColors = New System.Windows.Forms.Button()
        Me.cmdDayColors = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SuspendLayout()
        '
        'ClockControl1
        '
        Me.ClockControl1.Location = New System.Drawing.Point(68, 13)
        Me.ClockControl1.Name = "ClockControl1"
        Me.ClockControl1.Size = New System.Drawing.Size(146, 150)
        Me.ClockControl1.TabIndex = 0
        '
        'cmdNightColors
        '
        Me.cmdNightColors.Location = New System.Drawing.Point(79, 169)
        Me.cmdNightColors.Name = "cmdNightColors"
        Me.cmdNightColors.Size = New System.Drawing.Size(122, 23)
        Me.cmdNightColors.TabIndex = 1
        Me.cmdNightColors.Text = "Use Night Colors"
        Me.cmdNightColors.UseVisualStyleBackColor = True
        '
        'cmdDayColors
        '
        Me.cmdDayColors.Location = New System.Drawing.Point(79, 198)
        Me.cmdDayColors.Name = "cmdDayColors"
        Me.cmdDayColors.Size = New System.Drawing.Size(122, 23)
        Me.cmdDayColors.TabIndex = 2
        Me.cmdDayColors.Text = "Use Day Colors"
        Me.cmdDayColors.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cmdDayColors)
        Me.Controls.Add(Me.cmdNightColors)
        Me.Controls.Add(Me.ClockControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm Clock"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ClockControl1 As ClockControl.ClockControl
    Friend WithEvents cmdNightColors As Button
    Friend WithEvents cmdDayColors As Button
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
