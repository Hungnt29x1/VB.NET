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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblThongDiep = New System.Windows.Forms.Label()
        Me.btnNoLeft = New System.Windows.Forms.Button()
        Me.btnNoRight = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblThongDiep
        '
        Me.lblThongDiep.AutoSize = True
        Me.lblThongDiep.Font = New System.Drawing.Font("Times New Roman", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblThongDiep.Location = New System.Drawing.Point(218, 91)
        Me.lblThongDiep.Name = "lblThongDiep"
        Me.lblThongDiep.Size = New System.Drawing.Size(0, 33)
        Me.lblThongDiep.TabIndex = 0
        '
        'btnNoLeft
        '
        Me.btnNoLeft.Location = New System.Drawing.Point(31, 217)
        Me.btnNoLeft.Name = "btnNoLeft"
        Me.btnNoLeft.Size = New System.Drawing.Size(94, 45)
        Me.btnNoLeft.TabIndex = 1
        Me.btnNoLeft.Text = "No"
        Me.btnNoLeft.UseVisualStyleBackColor = True
        '
        'btnNoRight
        '
        Me.btnNoRight.Location = New System.Drawing.Point(170, 217)
        Me.btnNoRight.Name = "btnNoRight"
        Me.btnNoRight.Size = New System.Drawing.Size(94, 45)
        Me.btnNoRight.TabIndex = 2
        Me.btnNoRight.Text = "No"
        Me.btnNoRight.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.btnClose.Location = New System.Drawing.Point(456, 217)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 45)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnYes
        '
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.Location = New System.Drawing.Point(311, 217)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(94, 45)
        Me.btnYes.TabIndex = 3
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 427)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnNoRight)
        Me.Controls.Add(Me.btnNoLeft)
        Me.Controls.Add(Me.lblThongDiep)
        Me.Cursor = System.Windows.Forms.Cursors.Help
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblThongDiep As Label
    Friend WithEvents btnNoLeft As Button
    Friend WithEvents btnNoRight As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnYes As Button
End Class
