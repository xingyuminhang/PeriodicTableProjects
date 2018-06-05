<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataPanel
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataPanel))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.boxintro = New System.Windows.Forms.TextBox()
        Me.boxclassifi = New System.Windows.Forms.TextBox()
        Me.boxensymbol = New System.Windows.Forms.TextBox()
        Me.boxenname = New System.Windows.Forms.TextBox()
        Me.boxchpinyin = New System.Windows.Forms.TextBox()
        Me.boxchname = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.boxvalence = New System.Windows.Forms.TextBox()
        Me.boxoutelec = New System.Windows.Forms.TextBox()
        Me.boxisotope = New System.Windows.Forms.TextBox()
        Me.boxelement = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.boxoutelecnum = New System.Windows.Forms.TextBox()
        Me.boxneunum = New System.Windows.Forms.TextBox()
        Me.boxnucnum = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.boxrelaatomass = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.boxintro)
        Me.GroupBox1.Controls.Add(Me.boxclassifi)
        Me.GroupBox1.Controls.Add(Me.boxensymbol)
        Me.GroupBox1.Controls.Add(Me.boxenname)
        Me.GroupBox1.Controls.Add(Me.boxchpinyin)
        Me.GroupBox1.Controls.Add(Me.boxchname)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'boxintro
        '
        Me.boxintro.Location = New System.Drawing.Point(100, 49)
        Me.boxintro.Name = "boxintro"
        Me.boxintro.Size = New System.Drawing.Size(79, 21)
        Me.boxintro.TabIndex = 5
        '
        'boxclassifi
        '
        Me.boxclassifi.Location = New System.Drawing.Point(15, 49)
        Me.boxclassifi.Name = "boxclassifi"
        Me.boxclassifi.Size = New System.Drawing.Size(79, 21)
        Me.boxclassifi.TabIndex = 4
        '
        'boxensymbol
        '
        Me.boxensymbol.Location = New System.Drawing.Point(270, 22)
        Me.boxensymbol.Name = "boxensymbol"
        Me.boxensymbol.Size = New System.Drawing.Size(79, 21)
        Me.boxensymbol.TabIndex = 3
        '
        'boxenname
        '
        Me.boxenname.Location = New System.Drawing.Point(185, 22)
        Me.boxenname.Name = "boxenname"
        Me.boxenname.Size = New System.Drawing.Size(79, 21)
        Me.boxenname.TabIndex = 2
        '
        'boxchpinyin
        '
        Me.boxchpinyin.Location = New System.Drawing.Point(100, 22)
        Me.boxchpinyin.Name = "boxchpinyin"
        Me.boxchpinyin.Size = New System.Drawing.Size(79, 21)
        Me.boxchpinyin.TabIndex = 1
        '
        'boxchname
        '
        Me.boxchname.Location = New System.Drawing.Point(15, 22)
        Me.boxchname.Name = "boxchname"
        Me.boxchname.Size = New System.Drawing.Size(79, 21)
        Me.boxchname.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.boxvalence)
        Me.GroupBox2.Controls.Add(Me.boxoutelec)
        Me.GroupBox2.Controls.Add(Me.boxisotope)
        Me.GroupBox2.Controls.Add(Me.boxelement)
        Me.GroupBox2.Location = New System.Drawing.Point(381, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 162)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'boxvalence
        '
        Me.boxvalence.Location = New System.Drawing.Point(261, 22)
        Me.boxvalence.Name = "boxvalence"
        Me.boxvalence.Size = New System.Drawing.Size(79, 21)
        Me.boxvalence.TabIndex = 4
        '
        'boxoutelec
        '
        Me.boxoutelec.Location = New System.Drawing.Point(176, 22)
        Me.boxoutelec.Name = "boxoutelec"
        Me.boxoutelec.Size = New System.Drawing.Size(79, 21)
        Me.boxoutelec.TabIndex = 3
        '
        'boxisotope
        '
        Me.boxisotope.Location = New System.Drawing.Point(91, 22)
        Me.boxisotope.Name = "boxisotope"
        Me.boxisotope.Size = New System.Drawing.Size(79, 21)
        Me.boxisotope.TabIndex = 2
        '
        'boxelement
        '
        Me.boxelement.Location = New System.Drawing.Point(6, 22)
        Me.boxelement.Name = "boxelement"
        Me.boxelement.Size = New System.Drawing.Size(79, 21)
        Me.boxelement.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.boxoutelecnum)
        Me.GroupBox3.Controls.Add(Me.boxneunum)
        Me.GroupBox3.Controls.Add(Me.boxnucnum)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 180)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 162)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'boxoutelecnum
        '
        Me.boxoutelecnum.Location = New System.Drawing.Point(185, 20)
        Me.boxoutelecnum.Name = "boxoutelecnum"
        Me.boxoutelecnum.Size = New System.Drawing.Size(79, 21)
        Me.boxoutelecnum.TabIndex = 3
        '
        'boxneunum
        '
        Me.boxneunum.Location = New System.Drawing.Point(100, 20)
        Me.boxneunum.Name = "boxneunum"
        Me.boxneunum.Size = New System.Drawing.Size(79, 21)
        Me.boxneunum.TabIndex = 2
        '
        'boxnucnum
        '
        Me.boxnucnum.Location = New System.Drawing.Point(15, 20)
        Me.boxnucnum.Name = "boxnucnum"
        Me.boxnucnum.Size = New System.Drawing.Size(79, 21)
        Me.boxnucnum.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.boxrelaatomass)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 180)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(363, 162)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'boxrelaatomass
        '
        Me.boxrelaatomass.Location = New System.Drawing.Point(6, 20)
        Me.boxrelaatomass.Name = "boxrelaatomass"
        Me.boxrelaatomass.Size = New System.Drawing.Size(79, 21)
        Me.boxrelaatomass.TabIndex = 1
        '
        'DataPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 346)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DataPanel"
        Me.Text = "数据面板"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents boxintro As System.Windows.Forms.TextBox
    Friend WithEvents boxclassifi As System.Windows.Forms.TextBox
    Friend WithEvents boxensymbol As System.Windows.Forms.TextBox
    Friend WithEvents boxenname As System.Windows.Forms.TextBox
    Friend WithEvents boxchpinyin As System.Windows.Forms.TextBox
    Friend WithEvents boxchname As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents boxvalence As System.Windows.Forms.TextBox
    Friend WithEvents boxoutelec As System.Windows.Forms.TextBox
    Friend WithEvents boxisotope As System.Windows.Forms.TextBox
    Friend WithEvents boxelement As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents boxoutelecnum As System.Windows.Forms.TextBox
    Friend WithEvents boxneunum As System.Windows.Forms.TextBox
    Friend WithEvents boxnucnum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents boxrelaatomass As System.Windows.Forms.TextBox
End Class
