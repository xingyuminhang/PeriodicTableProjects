Option Strict Off
Option Explicit On
Friend Class Ion
    Inherits System.Windows.Forms.Form
    ' (原来的定义方式)Dim ionpair, cation, anion As Integer
    'UPGRADE_WARNING: 初始化窗体时可能激发事件 ag.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub ag_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ag.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 140
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 al.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub al_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles al.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 80
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 ba.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub ba_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ba.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 50
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 ca.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub ca_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ca.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 60
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 cl.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub cl_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cl.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 3
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 co3.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub co3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles co3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 5
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 cu.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub cu_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cu.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 130
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 fe2.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub fe2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fe2.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 110
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 fe3.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub fe3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fe3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 120
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 h.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub h_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles h.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 10
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 k.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub k_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles k.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 30
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 mg.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub mg_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mg.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 70
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 mn.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub mn_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mn.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 90
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 na.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub na_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles na.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 40
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 nh4.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub nh4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nh4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 20
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 no3.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub no3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles no3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 2
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 oh.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub oh_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles oh.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 1
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 po4.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub po4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles po4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 6
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 so4.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub so4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles so4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.anionbox.Text = 4
        End If
    End Sub

    'UPGRADE_WARNING: 初始化窗体时可能激发事件 zn.CheckedChanged。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"”
    Private Sub zn_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles zn.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
            Me.cationbox.Text = 100
        End If
    End Sub
    '(以下是原来通过点击Command1进行判定的方法。)
    'Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
    '     Dim ionpair As Short
    '   'UPGRADE_WARNING: 未能解析对象 anion 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
    '   'UPGRADE_WARNING: 未能解析对象 cation 的默认属性。 单击以获得更多信息:“ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"”
    '     ionpair = cation + anion
    '   If ionpair = 11 Then
    '     ionpairbox.Text = "水，H2O"
    '   ElseIf ionpair = 12 Or ionpair = 13 Or ionpair = 15 Or ionpair = 21 Then
    '     ionpairbox.Text = "溶,挥"
    '   ElseIf ionpair = 54 Or ionpair = 55 Or ionpair = 56 Or ionpair = 65 Or ionpair = 66 Or ionpair = 71 Or ionpair = 81 Or ionpair = 86 Or ionpair = 91 Or ionpair = 95 Or ionpair = 96 Or ionpair = 101 Or ionpair = 105 Or ionpair = 106 Or ionpair = 111 Or ionpair = 115 Or ionpair = 116 Or ionpair = 121 Or ionpair = 126 Or ionpair = 131 Or ionpair = 136 Or ionpair = 143 Or ionpair = 145 Or ionpair = 146 Then
    '     ionpairbox.Text = "不"
    '   ElseIf ionpair = 61 Or ionpair = 64 Or ionpair = 75 Or ionpair = 144 Then
    '     ionpairbox.Text = "微"
    '   ElseIf ionpair = 85 Or ionpair = 125 Or ionpair = 135 Or ionpair = 141 Then
    '     ionpairbox.Text = "--"
    '   Else : ionpairbox.Text = "溶"
    '   End If
    'End Sub

    Private Sub cationbox_TextChanged(sender As Object, e As EventArgs) Handles cationbox.TextChanged
        ionpair = Me.cationbox.Text + Me.anionbox.Text
        If ionpair = 11 Then
            ionpairbox.Text = "水，H2O"
        ElseIf ionpair = 12 Or ionpair = 13 Or ionpair = 15 Or ionpair = 21 Then
            ionpairbox.Text = "溶,挥"
        ElseIf ionpair = 54 Or ionpair = 55 Or ionpair = 56 Or ionpair = 65 Or ionpair = 66 Or ionpair = 71 Or ionpair = 81 Or ionpair = 86 Or ionpair = 91 Or ionpair = 95 Or ionpair = 96 Or ionpair = 101 Or ionpair = 105 Or ionpair = 106 Or ionpair = 111 Or ionpair = 115 Or ionpair = 116 Or ionpair = 121 Or ionpair = 126 Or ionpair = 131 Or ionpair = 136 Or ionpair = 143 Or ionpair = 145 Or ionpair = 146 Then
            ionpairbox.Text = "不"
        ElseIf ionpair = 61 Or ionpair = 64 Or ionpair = 75 Or ionpair = 144 Then
            ionpairbox.Text = "微"
        ElseIf ionpair = 85 Or ionpair = 125 Or ionpair = 135 Or ionpair = 141 Then
            ionpairbox.Text = "--"
        Else : ionpairbox.Text = "溶"
        End If
    End Sub

    Private Sub anionbox_TextChanged(sender As Object, e As EventArgs) Handles anionbox.TextChanged
        ionpair = Me.cationbox.Text + Me.anionbox.Text
        If ionpair = 11 Then
            ionpairbox.Text = "水，H2O"
        ElseIf ionpair = 12 Or ionpair = 13 Or ionpair = 15 Or ionpair = 21 Then
            ionpairbox.Text = "溶,挥"
        ElseIf ionpair = 54 Or ionpair = 55 Or ionpair = 56 Or ionpair = 65 Or ionpair = 66 Or ionpair = 71 Or ionpair = 81 Or ionpair = 86 Or ionpair = 91 Or ionpair = 95 Or ionpair = 96 Or ionpair = 101 Or ionpair = 105 Or ionpair = 106 Or ionpair = 111 Or ionpair = 115 Or ionpair = 116 Or ionpair = 121 Or ionpair = 126 Or ionpair = 131 Or ionpair = 136 Or ionpair = 143 Or ionpair = 145 Or ionpair = 146 Then
            ionpairbox.Text = "不"
        ElseIf ionpair = 61 Or ionpair = 64 Or ionpair = 75 Or ionpair = 144 Then
            ionpairbox.Text = "微"
        ElseIf ionpair = 85 Or ionpair = 125 Or ionpair = 135 Or ionpair = 141 Then
            ionpairbox.Text = "--"
        Else : ionpairbox.Text = "溶"
        End If
    End Sub
End Class