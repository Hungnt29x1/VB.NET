<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmThongtin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.mskPhone = New System.Windows.Forms.MaskedTextBox()
        Me.rdbMale = New System.Windows.Forms.RadioButton()
        Me.rdbFemale = New System.Windows.Forms.RadioButton()
        Me.rdbOthers = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbNo = New System.Windows.Forms.RadioButton()
        Me.rdbYes = New System.Windows.Forms.RadioButton()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbOthers)
        Me.GroupBox1.Controls.Add(Me.rdbFemale)
        Me.GroupBox1.Controls.Add(Me.rdbMale)
        Me.GroupBox1.Controls.Add(Me.mskPhone)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblSex)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblAddress)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(422, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Thông tin cá nhân"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(21, 78)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(73, 26)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Họ tên"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(21, 138)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(79, 26)
        Me.lblAddress.TabIndex = 1
        Me.lblAddress.Text = "Địa chỉ"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(21, 202)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(74, 26)
        Me.lblPhone.TabIndex = 2
        Me.lblPhone.Text = "Số ĐT"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Location = New System.Drawing.Point(6, 266)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(94, 26)
        Me.lblSex.TabIndex = 3
        Me.lblSex.Text = "Giới tính"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(243, 34)
        Me.txtName.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(152, 130)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(243, 34)
        Me.txtAddress.TabIndex = 5
        '
        'mskPhone
        '
        Me.mskPhone.Location = New System.Drawing.Point(152, 199)
        Me.mskPhone.Mask = "0000-000-000"
        Me.mskPhone.Name = "mskPhone"
        Me.mskPhone.Size = New System.Drawing.Size(243, 34)
        Me.mskPhone.TabIndex = 6
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(135, 266)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(77, 30)
        Me.rdbMale.TabIndex = 7
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Nam"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(227, 266)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(61, 30)
        Me.rdbFemale.TabIndex = 8
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Nữ"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'rdbOthers
        '
        Me.rdbOthers.AutoSize = True
        Me.rdbOthers.Location = New System.Drawing.Point(314, 266)
        Me.rdbOthers.Name = "rdbOthers"
        Me.rdbOthers.Size = New System.Drawing.Size(81, 30)
        Me.rdbOthers.TabIndex = 9
        Me.rdbOthers.TabStop = True
        Me.rdbOthers.Text = "Khác"
        Me.rdbOthers.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox1)
        Me.GroupBox2.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox2.Controls.Add(Me.rdbNo)
        Me.GroupBox2.Controls.Add(Me.rdbYes)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(474, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(437, 422)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin y tế"
        '
        'rdbNo
        '
        Me.rdbNo.AutoSize = True
        Me.rdbNo.Location = New System.Drawing.Point(293, 138)
        Me.rdbNo.Name = "rdbNo"
        Me.rdbNo.Size = New System.Drawing.Size(96, 30)
        Me.rdbNo.TabIndex = 8
        Me.rdbNo.TabStop = True
        Me.rdbNo.Text = "Không"
        Me.rdbNo.UseVisualStyleBackColor = True
        '
        'rdbYes
        '
        Me.rdbYes.AutoSize = True
        Me.rdbYes.Location = New System.Drawing.Point(152, 138)
        Me.rdbYes.Name = "rdbYes"
        Me.rdbYes.Size = New System.Drawing.Size(60, 30)
        Me.rdbYes.TabIndex = 7
        Me.rdbYes.TabStop = True
        Me.rdbYes.Text = "Có"
        Me.rdbYes.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(152, 70)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 34)
        Me.TextBox2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Thuốc đang dùng"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Bệnh sử"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "BHYT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Tuổi"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(207, 262)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(188, 34)
        Me.MaskedTextBox2.TabIndex = 9
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(152, 202)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(243, 34)
        Me.MaskedTextBox1.TabIndex = 10
        '
        'frmThongtin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(941, 484)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.Name = "frmThongtin"
        Me.Text = "Thông tin y tế cá nhân"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblSex As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblName As Label
    Friend WithEvents rdbOthers As RadioButton
    Friend WithEvents rdbFemale As RadioButton
    Friend WithEvents rdbMale As RadioButton
    Friend WithEvents mskPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents rdbNo As RadioButton
    Friend WithEvents rdbYes As RadioButton
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
