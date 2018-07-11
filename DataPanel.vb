Public Class DataPanel

    Private Sub boxchname_TextChanged(sender As Object, e As EventArgs) Handles boxchname.TextChanged
        element = Me.boxchname.Text
        PeriodicTable.ysfh.Text = element
        If element = "Uue" Or element = "Ubn" Then
            PeriodicTable.errornolabel.Visible = True
        Else : PeriodicTable.errornolabel.Visible = False
        End If
    End Sub

    Private Sub boxchpinyin_TextChanged(sender As Object, e As EventArgs) Handles boxchpinyin.TextChanged
        chpinyin = Me.boxchpinyin.Text
        PeriodicTable.hypy.Text = chpinyin
    End Sub

    Private Sub boxenname_TextChanged(sender As Object, e As EventArgs) Handles boxenname.TextChanged
        enname = Me.boxenname.Text
        PeriodicTable.ywm.Text = enname
    End Sub

    Private Sub boxensymbol_TextChanged(sender As Object, e As EventArgs) Handles boxensymbol.TextChanged
        ensymbol = Me.boxensymbol.Text
        PeriodicTable.yyyb.Text = ensymbol
    End Sub

    Private Sub boxclassifi_TextChanged(sender As Object, e As EventArgs) Handles boxclassifi.TextChanged
        classifi = Me.boxclassifi.Text
        PeriodicTable.fl.Text = classifi
    End Sub

    Private Sub boxintro_TextChanged(sender As Object, e As EventArgs) Handles boxintro.TextChanged
        intro = Me.boxintro.Text
    End Sub

    Private Sub boxelement_TextChanged(sender As Object, e As EventArgs) Handles boxelement.TextChanged
        element = Me.boxelement.Text
        PeriodicTable.ysfh.Text = element
    End Sub

    Private Sub boxisotope_TextChanged(sender As Object, e As EventArgs) Handles boxisotope.TextChanged
        isotope = Me.boxisotope.Text
    End Sub

    Private Sub boxoutelec_TextChanged(sender As Object, e As EventArgs) Handles boxoutelec.TextChanged
        outelec = Me.boxoutelec.Text
        PeriodicTable.wcdz.Text = outelec
    End Sub

    Private Sub boxvalence_TextChanged(sender As Object, e As EventArgs) Handles boxvalence.TextChanged
        valence = Me.boxvalence.Text
        PeriodicTable.cjhhj.Text = valence
    End Sub

    Private Sub boxnucnum_TextChanged(sender As Object, e As EventArgs) Handles boxnucnum.TextChanged
        nucnum = Me.boxnucnum.Text
    End Sub

    Private Sub boxneunum_TextChanged(sender As Object, e As EventArgs) Handles boxneunum.TextChanged
        neunum = Me.boxneunum.Text
    End Sub

    Private Sub boxoutelecnum_TextChanged(sender As Object, e As EventArgs) Handles boxoutelecnum.TextChanged
        outelecnum = Me.boxoutelecnum.Text
    End Sub

    Private Sub boxrelaatomass_TextChanged(sender As Object, e As EventArgs) Handles boxrelaatomass.TextChanged
        relaatomass = Me.boxrelaatomass.Text
        PeriodicTable.xdyzzl.Text = relaatomass
    End Sub
End Class