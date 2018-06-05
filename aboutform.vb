Option Strict Off
Option Explicit On
Friend Class aboutform
	Inherits System.Windows.Forms.Form
	
	Private Sub Image1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image1.Click
        DataPanel.Show()
	End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Shell("explorer.exe " & "  https://github.com/xingyuminhang/PeriodicTableProjects")
    End Sub
End Class