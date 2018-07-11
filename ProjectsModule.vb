Module ProjectsModule
    Public chname, chpinyin, enname, ensymbol, classifi, intro As Object
    'chname元素汉语名称(Chinese Name),chpinyin汉语拼音(Chinese pinyin)，enname英语名称(English Name)，ensymbol英语音标（English phonetic symbols），classifi分类(Classification),intro简介(Introduction)
    Public element, isotope, outelec, valence As Object
    'element元素(符号)（Element），isotope同位素(Isotope),outelec外层电子排布(),valence化合价(Valence)
    Public nucnum, neunum, outelecnum As Integer
    'nucnum核电荷数/原子序数(Nuclear charge number/atomic number),neunum中子数(Number of neutrons),outelecnum最外层电子数（number of The outermost electronics)
    Public relaatomass As Double
    ' relaatomass相对原子质量(relative atomic mass)
    REM （旧版本写法范例。）
    'Me.ysfh.Text = "H"
    ' Me.hypy.Text = "qīng"
    ' Me.ywm.Text = "Hydrogen"
    ' Me.yyyb.Text = "['haidrədʒən]"
    ' Me.wcdz.Text = "1s1"
    ' Me.cjhhj.Text = "1、-1"
    ' Me.fl.Text = "主/非/气"
    ' Me.qt.Text = "轻，同位素为氕、氘和氚"
    ' Me.xdyzzl.Text = "1.0079
    REM (la与ac系元素旧版本写法范例。)
    'PeriodicTable.ysfh.Text = "La"
    'PeriodicTable.hypy.Text = "lán"
    'PeriodicTable.ywm.Text = "Lanthanum"
    'PeriodicTable.yyyb.Text = "['l&aelig;nθənəm]"
    'PeriodicTable.wcdz.Text = "5d1 6s2"
    'PeriodicTable.cjhhj.Text = "3"
    'PeriodicTable.fl.Text = "副/金/镧"
    'PeriodicTable.qt.Text = ""
    'PeriodicTable.xdyzzl.Text = "138.91"
End Module
