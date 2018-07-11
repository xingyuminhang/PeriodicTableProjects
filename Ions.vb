Public Class Ions
    Dim cation, anion, ionpair As Integer
    Dim textcation, textanion, textionpair As Object
    '阳离子单选按钮的命名法：      rb（RadioButten）+（小写的）离子构成+（英语数字的)电荷数
    '阴离子单选按钮的命名法：r(Re)+rb（RadioButten）+（小写的）离子构成+（英语数字的)电荷数
    Private Sub rbhone_CheckedChanged(sender As Object, e As EventArgs) Handles rbhone.CheckedChanged
        numbercation.Text = 1
    End Sub

    Private Sub rbnh4one_CheckedChanged(sender As Object, e As EventArgs) Handles rbnh4one.CheckedChanged
        numbercation.Text = 2
    End Sub

    Private Sub rbkone_CheckedChanged(sender As Object, e As EventArgs) Handles rbkone.CheckedChanged
        numbercation.Text = 3
    End Sub

    Private Sub rbnaone_CheckedChanged(sender As Object, e As EventArgs) Handles rbnaone.CheckedChanged
        numbercation.Text = 4
    End Sub

    Private Sub rbbatwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbbatwo.CheckedChanged
        numbercation.Text = 5
    End Sub

    Private Sub rbcatwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcatwo.CheckedChanged
        numbercation.Text = 6
    End Sub

    Private Sub rbmgtwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbmgtwo.CheckedChanged
        numbercation.Text = 7
    End Sub

    Private Sub rbalthree_CheckedChanged(sender As Object, e As EventArgs) Handles rbalthree.CheckedChanged
        numbercation.Text = 8
    End Sub

    Private Sub rbmntwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbmntwo.CheckedChanged
        numbercation.Text = 9
    End Sub

    Private Sub rgzntwo_CheckedChanged(sender As Object, e As EventArgs) Handles rgzntwo.CheckedChanged
        numbercation.Text = 10
    End Sub

    Private Sub rbfetwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbfetwo.CheckedChanged
        numbercation.Text = 11
    End Sub

    Private Sub rbfethree_CheckedChanged(sender As Object, e As EventArgs) Handles rbfethree.CheckedChanged
        numbercation.Text = 12
    End Sub

    Private Sub rbcutwo_CheckedChanged(sender As Object, e As EventArgs) Handles rbcutwo.CheckedChanged
        numbercation.Text = 13
    End Sub

    Private Sub rbagone_CheckedChanged(sender As Object, e As EventArgs) Handles rbagone.CheckedChanged
        numbercation.Text = 14
    End Sub

    Private Sub rrbohone_CheckedChanged(sender As Object, e As EventArgs) Handles rrbohone.CheckedChanged
        numberanion.Text = 1
    End Sub

    Private Sub rrbclone_CheckedChanged(sender As Object, e As EventArgs) Handles rrbclone.CheckedChanged
        numberanion.Text = 2
    End Sub

    Private Sub rrbbrone_CheckedChanged(sender As Object, e As EventArgs) Handles rrbbrone.CheckedChanged
        numberanion.Text = 3
    End Sub

    Private Sub rrbione_CheckedChanged(sender As Object, e As EventArgs) Handles rrbione.CheckedChanged
        numberanion.Text = 4
    End Sub

    Private Sub rrbno3one_CheckedChanged(sender As Object, e As EventArgs) Handles rrbno3one.CheckedChanged
        numberanion.Text = 5
    End Sub

    Private Sub rrbpo3one_CheckedChanged(sender As Object, e As EventArgs) Handles rrbpo3one.CheckedChanged
        numberanion.Text = 6
    End Sub

    Private Sub rrbso4two_CheckedChanged(sender As Object, e As EventArgs) Handles rrbso4two.CheckedChanged
        numberanion.Text = 7
    End Sub

    Private Sub rrbso3two_CheckedChanged(sender As Object, e As EventArgs) Handles rrbso3two.CheckedChanged
        numberanion.Text = 8
    End Sub

    Private Sub rrbhso3one_CheckedChanged(sender As Object, e As EventArgs) Handles rrbhso3one.CheckedChanged
        numberanion.Text = 9
    End Sub

    Private Sub rrbco3two_CheckedChanged(sender As Object, e As EventArgs) Handles rrbco3two.CheckedChanged
        numberanion.Text = 10
    End Sub

    Private Sub rrbhco3one_CheckedChanged(sender As Object, e As EventArgs) Handles rrbhco3one.CheckedChanged
        numberanion.Text = 11
    End Sub

    Private Sub rrbsio3two_CheckedChanged(sender As Object, e As EventArgs) Handles rrbsio3two.CheckedChanged
        numberanion.Text = 12
    End Sub

    Private Sub numbercation_TextChanged(sender As Object, e As EventArgs)
        numbercation.Text = cation
        numberanion.Text = anion
        '定义名字
        '阴离子
        If anion = 1 Then
            textanion = "氢氧化"
        ElseIf anion = 2 Then
            textanion = "氯化"
        ElseIf anion = 3 Then
            textanion = "溴化"
        ElseIf anion = 4 Then
            textanion = "碘化"
        ElseIf anion = 5 Then
            textanion = "硝酸"
        ElseIf anion = 6 Then
            textanion = "磷酸"
        ElseIf anion = 7 Then
            textanion = "硫酸"
        ElseIf anion = 8 Then
            textanion = "亚硫酸"
        ElseIf anion = 9 Then
            textanion = "亚硫酸氢"
        ElseIf anion = 10 Then
            textanion = "碳酸"
        ElseIf anion = 11 Then
            textanion = "碳酸氢"
        ElseIf anion = 12 Then
            textanion = "硅酸"
        End If
        '阳离子
        If cation = 1 Then
            textcation = "氢"
        ElseIf cation = 2 Then
            textcation = "铵"
        ElseIf cation = 3 Then
            textcation = "钾"
        ElseIf cation = 4 Then
            textcation = "钠"
        ElseIf cation = 5 Then
            textcation = "钡"
        ElseIf cation = 6 Then
            textcation = "钙"
        ElseIf cation = 7 Then
            textcation = "镁"
        ElseIf cation = 8 Then
            textcation = "铝"
        ElseIf cation = 9 Then
            textcation = "锰"
        ElseIf cation = 10 Then
            textcation = "锌"
        ElseIf cation = 11 Then
            textcation = "亚铁"
        ElseIf cation = 12 Then
            textcation = "铁"
        ElseIf cation = 13 Then
            textcation = "铜"
        ElseIf cation = 14 Then
            textcation = "银"
        End If
        '开始生成名字
        textionpair = textcation + textanion
        ionpairname.Text = "这种物质的名称是：" + textionpair
        '定义溶解性
        'If空格=这种物质就是水。ElseIf溶、挥=这种物质可溶于水并具有挥发性。微=这种物质微溶于水。不=这种物质不溶于水。--=这种物质不存在或遇到水就分解了。Else溶=这种物质可溶于水。
        If anion = 1 Then '氢氧根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质就是水。"
            ElseIf cation = 2 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 6 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 7 Or cation = 8 Or cation = 9 Or cation = 10 Or cation = 11 Or cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 2 Then '氯离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 3 Then '溴离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 4 Then '碘离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 5 Then '硝酸根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 6 Then '磷酸根离子
            If cation = 5 Or cation = 6 Or cation = 8 Or cation = 10 Or cation = 11 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 7 Then '硫酸根离子
            If cation = 6 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 5 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        
        ElseIf anion = 9 Then '亚硫酸氢根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 10 Then '碳酸根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 7 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 11 Then '碳酸氢根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 12 Then '硅酸根离子
            If cation = 1 Or cation = 5 Or cation = 6 Or cation = 7 Or cation = 9 Or cation = 10 Or cation = 11 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 2 Or cation = 8 Or cation = 12 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        End If
    End Sub

    Private Sub numberanion_TextChanged(sender As Object, e As EventArgs) Handles numberanion.TextChanged
        numbercation.Text = cation
        numberanion.Text = anion
        '定义名字
        '阴离子
        If anion = 1 Then
            textanion = "氢氧化"
        ElseIf anion = 2 Then
            textanion = "氯化"
        ElseIf anion = 3 Then
            textanion = "溴化"
        ElseIf anion = 4 Then
            textanion = "碘化"
        ElseIf anion = 5 Then
            textanion = "硝酸"
        ElseIf anion = 6 Then
            textanion = "磷酸"
        ElseIf anion = 7 Then
            textanion = "硫酸"
        ElseIf anion = 8 Then
            textanion = "亚硫酸"
        ElseIf anion = 9 Then
            textanion = "亚硫酸氢"
        ElseIf anion = 10 Then
            textanion = "碳酸"
        ElseIf anion = 11 Then
            textanion = "碳酸氢"
        ElseIf anion = 12 Then
            textanion = "硅酸"
        End If
        '阳离子
        If cation = 1 Then
            textcation = "氢"
        ElseIf cation = 2 Then
            textcation = "铵"
        ElseIf cation = 3 Then
            textcation = "钾"
        ElseIf cation = 4 Then
            textcation = "钠"
        ElseIf cation = 5 Then
            textcation = "钡"
        ElseIf cation = 6 Then
            textcation = "钙"
        ElseIf cation = 7 Then
            textcation = "镁"
        ElseIf cation = 8 Then
            textcation = "铝"
        ElseIf cation = 9 Then
            textcation = "锰"
        ElseIf cation = 10 Then
            textcation = "锌"
        ElseIf cation = 11 Then
            textcation = "亚铁"
        ElseIf cation = 12 Then
            textcation = "铁"
        ElseIf cation = 13 Then
            textcation = "铜"
        ElseIf cation = 14 Then
            textcation = "银"
        End If
        '开始生成名字
        textionpair = textcation + textanion
        ionpairname.Text = "这种物质的名称是：" + textionpair
        '定义溶解性
        'If空格=这种物质就是水。ElseIf溶、挥=这种物质可溶于水并具有挥发性。微=这种物质微溶于水。不=这种物质不溶于水。--=这种物质不存在或遇到水就分解了。Else溶=这种物质可溶于水。
        If anion = 1 Then '氢氧根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质就是水。"
            ElseIf cation = 2 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 6 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 7 Or cation = 8 Or cation = 9 Or cation = 10 Or cation = 11 Or cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 2 Then '氯离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 3 Then '溴离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 4 Then '碘离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 5 Then '硝酸根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 6 Then '磷酸根离子
            If cation = 5 Or cation = 6 Or cation = 8 Or cation = 10 Or cation = 11 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 7 Then '硫酸根离子
            If cation = 6 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 5 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If

        ElseIf anion = 9 Then '亚硫酸氢根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 10 Then '碳酸根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 7 Then
                ionpairsolubility.Text = "这种物质微溶于水。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 11 Then '碳酸氢根离子
            If cation = 1 Then
                ionpairsolubility.Text = "这种物质可溶于水并具有挥发性。"
            ElseIf cation = 8 Or cation = 12 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        ElseIf anion = 12 Then '硅酸根离子
            If cation = 1 Or cation = 5 Or cation = 6 Or cation = 7 Or cation = 9 Or cation = 10 Or cation = 11 Or cation = 13 Or cation = 14 Then
                ionpairsolubility.Text = "这种物质不溶于水。"
            ElseIf cation = 2 Or cation = 8 Or cation = 12 Then
                ionpairsolubility.Text = "这种物质不存在或遇到水就分解了。"
            Else : ionpairsolubility.Text = "这种物质可溶于水。"
            End If
        End If
    End Sub
End Class