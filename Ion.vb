Option Strict Off
Option Explicit On
Friend Class Ion
    Inherits System.Windows.Forms.Form
    Dim ionpair, cation, anion As Integer

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� ag.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub ag_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ag.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 140
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� al.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub al_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles al.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 80
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� ba.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub ba_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ba.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 50
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� ca.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub ca_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ca.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 60
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� cl.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub cl_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cl.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 3
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� co3.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub co3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles co3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 5
        End If
    End Sub

    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Dim ionpair As Short
        'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
        'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
        ionpair = cation + anion
        If ionpair = 11 Then
            Text1.Text = "ˮ��H2O"
        ElseIf ionpair = 12 Or ionpair = 13 Or ionpair = 15 Or ionpair = 21 Then
            Text1.Text = "��,��"
        ElseIf ionpair = 54 Or ionpair = 55 Or ionpair = 56 Or ionpair = 65 Or ionpair = 66 Or ionpair = 71 Or ionpair = 81 Or ionpair = 86 Or ionpair = 91 Or ionpair = 95 Or ionpair = 96 Or ionpair = 101 Or ionpair = 105 Or ionpair = 106 Or ionpair = 111 Or ionpair = 115 Or ionpair = 116 Or ionpair = 121 Or ionpair = 126 Or ionpair = 131 Or ionpair = 136 Or ionpair = 143 Or ionpair = 145 Or ionpair = 146 Then
            Text1.Text = "��"
        ElseIf ionpair = 61 Or ionpair = 64 Or ionpair = 75 Or ionpair = 144 Then
            Text1.Text = "΢"
        ElseIf ionpair = 85 Or ionpair = 125 Or ionpair = 135 Or ionpair = 141 Then
            Text1.Text = "--"
        Else : Text1.Text = "��"
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� cu.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub cu_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cu.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 130
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� fe2.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub fe2_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fe2.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 110
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� fe3.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub fe3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fe3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 120
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� h.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub h_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles h.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 10
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� k.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub k_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles k.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 30
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� mg.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub mg_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mg.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 70
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� mn.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub mn_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mn.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 90
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� na.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub na_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles na.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 40
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� nh4.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub nh4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nh4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 20
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� no3.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub no3_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles no3.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 2
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� oh.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub oh_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles oh.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 1
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� po4.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub po4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles po4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 6
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� so4.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub so4_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles so4.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� anion ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            anion = 4
        End If
    End Sub

    'UPGRADE_WARNING: ��ʼ������ʱ���ܼ����¼� zn.CheckedChanged�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"��
    Private Sub zn_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles zn.CheckedChanged
        If eventSender.Checked Then
            'UPGRADE_WARNING: δ�ܽ������� cation ��Ĭ�����ԡ� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"��
            cation = 100
        End If
    End Sub
End Class