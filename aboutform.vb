Option Strict Off
Option Explicit On
Friend Class aboutform
	Inherits System.Windows.Forms.Form
    Dim show1way, show2way As Integer
	Private Sub Image1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image1.Click
        DataPanel.Show()
	End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Shell("explorer.exe " & "  https://github.com/xingyuminhang/PeriodicTableProjects")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        show1way = 0
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        show1way = 1
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            show2way = 1
        ElseIf CheckBox1.Checked = False Then
            show2way = 0
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If show1way = 0 Then
            PeriodicTable.h1.Text = "H"
            PeriodicTable.he2.Text = "He"
            PeriodicTable.li3.Text = "Li"

        ElseIf show1way = 1 Then
        End If
    End Sub
End Class