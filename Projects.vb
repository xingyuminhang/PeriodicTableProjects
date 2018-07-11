Option Strict Off
Option Explicit On
Friend Class PeriodicTable
    Inherits System.Windows.Forms.Form

    Private Sub AboutTool_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles AboutTool.Click
        aboutform.Show()
    End Sub

    Private Sub aclr_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles aclr.Click
        actinides.Show()
    End Sub

    Private Sub ag47_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ag47.Click
        DataPanel.boxchname.Text = "Ag"
        DataPanel.boxchpinyin.Text = "yín"
        DataPanel.boxenname.Text = "Silver"
        DataPanel.boxensymbol.Text = "['silvə]"
        DataPanel.boxoutelec.Text = "4d10 5s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "贵金属，曾经是全球范围内的硬通货"
        DataPanel.boxrelaatomass.Text = "107.87"
    End Sub

    Private Sub al13_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles al13.Click
        DataPanel.boxchname.Text = "Al"
        DataPanel.boxchpinyin.Text = "lǚ"
        DataPanel.boxenname.Text = "Aluminum"
        DataPanel.boxensymbol.Text = "[,&aelig;lju'minjəm]"
        DataPanel.boxoutelec.Text = "3s2 3p1"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "主/金/气"
        DataPanel.boxintro.Text = "地壳里含量最多的金属"
        DataPanel.boxrelaatomass.Text = "26.98"
    End Sub

    Private Sub ar18_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ar18.Click
        DataPanel.boxchname.Text = "Ar"
        DataPanel.boxchpinyin.Text = "yà"
        DataPanel.boxenname.Text = "Argon"
        DataPanel.boxensymbol.Text = "['ɑ:ɡɔn]"
        DataPanel.boxoutelec.Text = "2s2 2p1"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "主/非/稀"
        DataPanel.boxintro.Text = "稀有气体，在空气中含量最多的稀有气体"
        DataPanel.boxrelaatomass.Text = "39.95"
    End Sub

    Private Sub as33_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles as33.Click
        DataPanel.boxchname.Text = "As"
        DataPanel.boxchpinyin.Text = "shēn"
        DataPanel.boxenname.Text = "Arsenic"
        DataPanel.boxensymbol.Text = "['ɑ:sənik]"
        DataPanel.boxoutelec.Text = "4s2 4p3"
        DataPanel.boxvalence.Text = "-3、3、5"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "有毒"
        DataPanel.boxrelaatomass.Text = "74.92"
    End Sub

    Private Sub at85_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles at85.Click
        DataPanel.boxchname.Text = "At"
        DataPanel.boxchpinyin.Text = "ài"
        DataPanel.boxenname.Text = "Astatine"
        DataPanel.boxensymbol.Text = "['&aelig;stəti:n]"
        DataPanel.boxoutelec.Text = "6s2 6p5"
        DataPanel.boxvalence.Text = "1、3"
        DataPanel.boxclassifi.Text = "主/非/卤"
        DataPanel.boxintro.Text = "活泼"
        DataPanel.boxrelaatomass.Text = "(210)"
    End Sub

    Private Sub au79_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles au79.Click
        DataPanel.boxchname.Text = "Au"
        DataPanel.boxchpinyin.Text = "jīn"
        DataPanel.boxenname.Text = "Gold"
        DataPanel.boxensymbol.Text = "[ɡəuld]"
        DataPanel.boxoutelec.Text = "5d10 6s1"
        DataPanel.boxvalence.Text = "1、3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "原子结构最稳定，人类最早发现及应用的贵金属，全球硬通货"
        DataPanel.boxrelaatomass.Text = "196.97"
    End Sub

    Private Sub b5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles b5.Click
        DataPanel.boxchname.Text = "B"
        DataPanel.boxchpinyin.Text = "péng"
        DataPanel.boxenname.Text = "Boron"
        DataPanel.boxensymbol.Text = "['bɔ:rɔn]"
        DataPanel.boxoutelec.Text = "2s2 2p1"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "硬度仅次于金刚石的非金属元素"
        DataPanel.boxrelaatomass.Text = "10.81"
    End Sub

    Private Sub ba56_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ba56.Click
        DataPanel.boxchname.Text = "Ba"
        DataPanel.boxchpinyin.Text = "bèi"
        DataPanel.boxenname.Text = "Barium"
        DataPanel.boxensymbol.Text = "['bεəriəm]"
        DataPanel.boxoutelec.Text = "6s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/碱土"
        DataPanel.boxintro.Text = "硫酸钡被应用于钡餐透视"
        DataPanel.boxrelaatomass.Text = "137.33"
    End Sub

    Private Sub be4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles be4.Click
        DataPanel.boxchname.Text = "Be"
        DataPanel.boxchpinyin.Text = "pí"
        DataPanel.boxenname.Text = "Beryllium"
        DataPanel.boxensymbol.Text = "[be'riliəm]"
        DataPanel.boxoutelec.Text = "2s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/金/碱土"
        DataPanel.boxintro.Text = "最轻碱土金属元素"
        DataPanel.boxrelaatomass.Text = "9.012"
    End Sub

    Private Sub bh107_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bh107.Click
        DataPanel.boxchname.Text = "Bh"
        DataPanel.boxchpinyin.Text = "bō"
        DataPanel.boxenname.Text = "Bohrium"
        DataPanel.boxensymbol.Text = "['bəuəriəm]"
        DataPanel.boxoutelec.Text = "6d5 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "264"
    End Sub

    Private Sub bi83_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles bi83.Click
        DataPanel.boxchname.Text = "Bi"
        DataPanel.boxchpinyin.Text = "bì"
        DataPanel.boxenname.Text = "Bismuth"
        DataPanel.boxensymbol.Text = "['bizməθ]"
        DataPanel.boxoutelec.Text = "6s2 6p3"
        DataPanel.boxvalence.Text = "3、5"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = "208.98"
    End Sub

    Private Sub br35_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles br35.Click
        DataPanel.boxchname.Text = "Br"
        DataPanel.boxchpinyin.Text = "xiù"
        DataPanel.boxenname.Text = "Bromine"
        DataPanel.boxensymbol.Text = "['brəumi:n]"
        DataPanel.boxoutelec.Text = "4s2 4p5"
        DataPanel.boxvalence.Text = "-1、7"
        DataPanel.boxclassifi.Text = "主/非/卤"
        DataPanel.boxintro.Text = "活泼，单质为红棕色液体"
        DataPanel.boxrelaatomass.Text = "79.90"
    End Sub

    Private Sub c6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles c6.Click
        DataPanel.boxchname.Text = "C"
        DataPanel.boxchpinyin.Text = "tàn"
        DataPanel.boxenname.Text = "Carbon"
        DataPanel.boxensymbol.Text = "['kɑ:bən]"
        DataPanel.boxoutelec.Text = "2s2 2p2"
        DataPanel.boxvalence.Text = "2、4、-4"
        DataPanel.boxclassifi.Text = "主/非/气"
        DataPanel.boxintro.Text = "硬度最高"
        DataPanel.boxrelaatomass.Text = "12.01"
    End Sub

    Private Sub ca20_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ca20.Click
        DataPanel.boxchname.Text = "Ca"
        DataPanel.boxchpinyin.Text = "gài"
        DataPanel.boxenname.Text = "Calcium"
        DataPanel.boxensymbol.Text = "['k&aelig;lsiəm]"
        DataPanel.boxoutelec.Text = "4s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/金/碱土"
        DataPanel.boxintro.Text = "骨骼主要组成成分"
        DataPanel.boxrelaatomass.Text = "40.08"
    End Sub

    Private Sub cd48_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cd48.Click
        DataPanel.boxchname.Text = "Cd"
        DataPanel.boxchpinyin.Text = "gé"
        DataPanel.boxenname.Text = "Cadmium"
        DataPanel.boxensymbol.Text = "['k&aelig;dmiəm]"
        DataPanel.boxoutelec.Text = "4d10 5s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "重金属，过量摄入会导致痛痛病"
        DataPanel.boxrelaatomass.Text = "112.41"
    End Sub

    Private Sub cl17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cl17.Click
        DataPanel.boxchname.Text = "Cl"
        DataPanel.boxchpinyin.Text = "lǜ"
        DataPanel.boxenname.Text = "Chlorine"
        DataPanel.boxensymbol.Text = "['klɔ:ri:n]"
        DataPanel.boxoutelec.Text = "3s2 3p5"
        DataPanel.boxvalence.Text = "-1、1、3、5、7"
        DataPanel.boxclassifi.Text = "主/非/卤"
        DataPanel.boxintro.Text = "有毒 活泼"
        DataPanel.boxrelaatomass.Text = "35.45"
    End Sub

    Private Sub cn112_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cn112.Click
        DataPanel.boxchname.Text = "Cn"
        DataPanel.boxchpinyin.Text = "gē"
        DataPanel.boxenname.Text = "Copernicium"
        DataPanel.boxensymbol.Text = "kōpərˈnisēəm"
        DataPanel.boxoutelec.Text = "6d10 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金"
        DataPanel.boxintro.Text = "超重元素"
        DataPanel.boxrelaatomass.Text = "(277)"
    End Sub

    Private Sub co27_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles co27.Click
        DataPanel.boxchname.Text = "Co"
        DataPanel.boxchpinyin.Text = "gǔ"
        DataPanel.boxenname.Text = "Cobalt"
        DataPanel.boxensymbol.Text = "[kəu'bɔ:lt]"
        DataPanel.boxoutelec.Text = "3d7 4s2"
        DataPanel.boxvalence.Text = "2、3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "同位素钴60被应用于X光发生器中"
        DataPanel.boxrelaatomass.Text = "58.93"
    End Sub

    Private Sub cr24_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cr24.Click
        DataPanel.boxchname.Text = "Cr"
        DataPanel.boxchpinyin.Text = "gè"
        DataPanel.boxenname.Text = "Chromium"
        DataPanel.boxensymbol.Text = "['krəumjəm]"
        DataPanel.boxoutelec.Text = "3d5 4s1"
        DataPanel.boxvalence.Text = "3、6"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "硬度最高的金属"
        DataPanel.boxrelaatomass.Text = "52.00"
    End Sub

    Private Sub cs55_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cs55.Click
        DataPanel.boxchname.Text = "Cs"
        DataPanel.boxchpinyin.Text = "sè"
        DataPanel.boxenname.Text = "Cesium"
        DataPanel.boxensymbol.Text = "['si:ziəm]"
        DataPanel.boxoutelec.Text = "6s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "主/金/碱"
        DataPanel.boxintro.Text = "活泼"
        DataPanel.boxrelaatomass.Text = "132.91"
    End Sub

    Private Sub cu29_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cu29.Click
        DataPanel.boxchname.Text = "Cu"
        DataPanel.boxchpinyin.Text = "tóng"
        DataPanel.boxenname.Text = "Copper"
        DataPanel.boxensymbol.Text = "['kɔpə]"
        DataPanel.boxoutelec.Text = "3d10 4s1"
        DataPanel.boxvalence.Text = "1、2"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人类发现最早金属之一"
        DataPanel.boxrelaatomass.Text = "63.55"
    End Sub

    Private Sub db105_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles db105.Click
        DataPanel.boxchname.Text = "Db"
        DataPanel.boxchpinyin.Text = "dù"
        DataPanel.boxenname.Text = "Dubnium"
        DataPanel.boxensymbol.Text = "['du:bniəm]"
        DataPanel.boxoutelec.Text = "6d3 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(262)"
    End Sub

    Private Sub ds110_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ds110.Click
        DataPanel.boxchname.Text = "Ds"
        DataPanel.boxchpinyin.Text = "dá"
        DataPanel.boxenname.Text = "Darmstadtium"
        DataPanel.boxensymbol.Text = "-ˈSHtät-,därmˈstatēəm"
        DataPanel.boxoutelec.Text = "6d8 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(269)"
    End Sub

    Private Sub ElectronicShellTool_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ElectronicShellTool.Click
        ElectronicShell.Show()
    End Sub

    Private Sub f9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles f9.Click
        DataPanel.boxchname.Text = "F"
        DataPanel.boxchpinyin.Text = "fú"
        DataPanel.boxenname.Text = "Fluorine"
        DataPanel.boxensymbol.Text = "['fluəri:n]"
        DataPanel.boxoutelec.Text = "2s2 2p5"
        DataPanel.boxvalence.Text = "-1"
        DataPanel.boxclassifi.Text = "主/非/卤"
        DataPanel.boxintro.Text = "最活泼，非金属，不能被氧化"
        DataPanel.boxrelaatomass.Text = "19.00"
    End Sub

    Private Sub fe26_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fe26.Click
        DataPanel.boxchname.Text = "Fe"
        DataPanel.boxchpinyin.Text = "tiě"
        DataPanel.boxenname.Text = "Iron"
        DataPanel.boxensymbol.Text = "['aɪən]"
        DataPanel.boxoutelec.Text = "1s1"
        DataPanel.boxvalence.Text = "2、3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "地壳含量第二高的金属，开采最多金属"
        DataPanel.boxrelaatomass.Text = "55.84"
    End Sub

    Private Sub fl114_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fl114.Click
        DataPanel.boxchname.Text = "Fl"
        DataPanel.boxchpinyin.Text = "fū"
        DataPanel.boxenname.Text = "Flerovium"
        DataPanel.boxensymbol.Text = "Flerovium"
        DataPanel.boxoutelec.Text = "5f6d7s7p2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "人造 放射,第一种表现出惰性气体特征的超重元素"
        DataPanel.boxrelaatomass.Text = "(289)"
    End Sub

    Private Sub fr87_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles fr87.Click
        DataPanel.boxchname.Text = "Fr"
        DataPanel.boxchpinyin.Text = "fāng"
        DataPanel.boxenname.Text = "Francium"
        DataPanel.boxensymbol.Text = "['frænsɪəm]"
        DataPanel.boxoutelec.Text = "7s1"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "碱金属"
        DataPanel.boxintro.Text = "放射"
        DataPanel.boxrelaatomass.Text = "(223)"
    End Sub

    Private Sub ga31_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ga31.Click
        DataPanel.boxchname.Text = "Ga"
        DataPanel.boxchpinyin.Text = "jiā"
        DataPanel.boxenname.Text = "Gallium"
        DataPanel.boxensymbol.Text = "['ɡ&aelig;liəm]"
        DataPanel.boxoutelec.Text = "4s2 4p1"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "燃点低沸点高　"
        DataPanel.boxrelaatomass.Text = "69.72"
    End Sub

    Private Sub ge32_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ge32.Click
        DataPanel.boxchname.Text = "Ge"
        DataPanel.boxchpinyin.Text = "zhě"
        DataPanel.boxenname.Text = "4s2 4p2"
        DataPanel.boxensymbol.Text = "[dʒə:'meiniəm]"
        DataPanel.boxoutelec.Text = "1s1"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "是一种重要的半导体材料"
        DataPanel.boxrelaatomass.Text = "72.61"
    End Sub

    Private Sub h1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles h1.Click
        DataPanel.boxchname.Text = "H"
        DataPanel.boxchpinyin.Text = "qīng"
        DataPanel.boxenname.Text = "Hydrogen"
        DataPanel.boxensymbol.Text = "['haidrədʒən]"
        DataPanel.boxoutelec.Text = "1s1"
        DataPanel.boxvalence.Text = "1、-1"
        DataPanel.boxclassifi.Text = "主/非/气"
        DataPanel.boxintro.Text = "轻，同位素为氕、氘和氚"
        DataPanel.boxrelaatomass.Text = "1.0079"
    End Sub

    Private Sub he2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles he2.Click
        DataPanel.boxchname.Text = "He"
        DataPanel.boxchpinyin.Text = "hài"
        DataPanel.boxenname.Text = "Helium"
        DataPanel.boxensymbol.Text = "['hi:liəm]"
        DataPanel.boxoutelec.Text = "1s2"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "主/非/稀"
        DataPanel.boxintro.Text = "最难液化"
        DataPanel.boxrelaatomass.Text = "4.003"
    End Sub

    Private Sub hf72_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles hf72.Click
        DataPanel.boxchname.Text = "Hf"
        DataPanel.boxchpinyin.Text = "hā"
        DataPanel.boxenname.Text = "Hafnium"
        DataPanel.boxensymbol.Text = "['h&aelig;fniəm]"
        DataPanel.boxoutelec.Text = "5d2 6s2"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = "178.49"
    End Sub

    Private Sub hg80_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles hg80.Click
        DataPanel.boxchname.Text = "Hg"
        DataPanel.boxchpinyin.Text = "gǒng"
        DataPanel.boxenname.Text = "Mercury"
        DataPanel.boxensymbol.Text = "['mə:kjuri]"
        DataPanel.boxoutelec.Text = "5d10 6s2"
        DataPanel.boxvalence.Text = "1、2"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "　唯一一种在常温下为液态的金属"
        DataPanel.boxrelaatomass.Text = "200.59"
    End Sub

    Private Sub hs108_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles hs108.Click
        DataPanel.boxchname.Text = "Hs"
        DataPanel.boxchpinyin.Text = "hēi"
        DataPanel.boxenname.Text = "Hassium"
        DataPanel.boxensymbol.Text = "['h&aelig;siəm]"
        DataPanel.boxoutelec.Text = "6d6 7s2"
        DataPanel.boxvalence.Text = "-1、7"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(265)"
    End Sub

    Private Sub i53_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles i53.Click
        DataPanel.boxchname.Text = "I"
        DataPanel.boxchpinyin.Text = "diǎn"
        DataPanel.boxenname.Text = "Indium"
        DataPanel.boxensymbol.Text = "['aiəudi:n]"
        DataPanel.boxoutelec.Text = "5s2 5p5"
        DataPanel.boxvalence.Text = "-1、7"
        DataPanel.boxclassifi.Text = "主/非/卤"
        DataPanel.boxintro.Text = "活泼，甲状腺所需的微量元素"
        DataPanel.boxrelaatomass.Text = "126.90"
    End Sub

    Private Sub in49_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles in49.Click
        DataPanel.boxchname.Text = "In"
        DataPanel.boxchpinyin.Text = "yīn"
        DataPanel.boxenname.Text = "Indium"
        DataPanel.boxensymbol.Text = "['indiəm]"
        DataPanel.boxoutelec.Text = "5s2 5p1"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "可塑性强，有延展性，In115是主要核素，但有放射性"
        DataPanel.boxrelaatomass.Text = "114.82"
    End Sub

    Private Sub IonTool_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles IonTool.Click
        Ion.Show()
    End Sub

    Private Sub IonsTool_Click(sender As Object, e As EventArgs) Handles IonsTool.Click
        Ions.Show()
    End Sub
    Private Sub ir77_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ir77.Click
        DataPanel.boxchname.Text = "Ir"
        DataPanel.boxchpinyin.Text = "yī"
        DataPanel.boxenname.Text = "Iridium"
        DataPanel.boxensymbol.Text = "[ai'ridiəm]"
        DataPanel.boxoutelec.Text = "5d7 6s2"
        DataPanel.boxvalence.Text = "3,4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = " "
        DataPanel.boxrelaatomass.Text = "192.22"
    End Sub

    Private Sub k19_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles k19.Click
        DataPanel.boxchname.Text = "K"
        DataPanel.boxchpinyin.Text = "jiǎ"
        DataPanel.boxenname.Text = "Potassium"
        DataPanel.boxensymbol.Text = "[pə't&aelig;sjəm]"
        DataPanel.boxoutelec.Text = "4s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "主/金/碱"
        DataPanel.boxintro.Text = "活泼，与空气或水接触发生反应，只能储存在煤油、稀有气体中"
        DataPanel.boxrelaatomass.Text = "39.10"
    End Sub

    Private Sub kr36_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles kr36.Click
        DataPanel.boxchname.Text = "Kr"
        DataPanel.boxchpinyin.Text = "kè"
        DataPanel.boxenname.Text = "Krypton"
        DataPanel.boxensymbol.Text = "['kriptɔn]"
        DataPanel.boxoutelec.Text = "4s2 4p6"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "是一种无色无味无臭的惰性气体"
        DataPanel.boxintro.Text = "性质活泼"
        DataPanel.boxrelaatomass.Text = "83.80"
    End Sub

    Private Sub lalu_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lalu.Click
        lanthanides.Show()
    End Sub

    Private Sub li3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles li3.Click
        DataPanel.boxchname.Text = "Li"
        DataPanel.boxchpinyin.Text = "lǐ"
        DataPanel.boxenname.Text = "Lithium"
        DataPanel.boxensymbol.Text = "['liθiəm]"
        DataPanel.boxoutelec.Text = "2s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "主/金/碱"
        DataPanel.boxintro.Text = "性质活泼"
        DataPanel.boxrelaatomass.Text = "6.941"
    End Sub

    Private Sub lv116_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lv116.Click
        DataPanel.boxchname.Text = "Lv"
        DataPanel.boxchpinyin.Text = "lì"
        DataPanel.boxenname.Text = "Livermorium"
        DataPanel.boxensymbol.Text = "Livermorium"
        DataPanel.boxoutelec.Text = "5f6d7s7p4"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "人造 放射,人工合成的放射性金属元素"
        DataPanel.boxrelaatomass.Text = "(293)"
    End Sub

    Private Sub mc115_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mc115.Click
        DataPanel.boxchname.Text = "Mc"
        DataPanel.boxchpinyin.Text = "mò"
        DataPanel.boxenname.Text = "Moscovium"
        DataPanel.boxensymbol.Text = "Moscovium"
        DataPanel.boxoutelec.Text = "5f6d7s7p3"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "人造 放射,人工合成的放射性金属元素"
        DataPanel.boxrelaatomass.Text = "(288)"
    End Sub

    Private Sub mg12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mg12.Click
        DataPanel.boxchname.Text = "Mg"
        DataPanel.boxchpinyin.Text = "měi"
        DataPanel.boxenname.Text = "Magnesium"
        DataPanel.boxensymbol.Text = "[m&aelig;ɡ'ni:ziəm]"
        DataPanel.boxoutelec.Text = "3s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/金/碱土"
        DataPanel.boxintro.Text = "轻金属之一"
        DataPanel.boxrelaatomass.Text = "24.31"
    End Sub

    Private Sub mn25_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mn25.Click
        DataPanel.boxchname.Text = "Mn"
        DataPanel.boxchpinyin.Text = "měng"
        DataPanel.boxenname.Text = "Manganese"
        DataPanel.boxensymbol.Text = "['m&aelig;ŋɡə,ni:s]"
        DataPanel.boxoutelec.Text = "3d5 4s2"
        DataPanel.boxvalence.Text = "2、4、6、7"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "在地壳中分布广泛"
        DataPanel.boxrelaatomass.Text = "54.96"
    End Sub

    Private Sub mo42_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mo42.Click
        DataPanel.boxchname.Text = "Mo"
        DataPanel.boxchpinyin.Text = "mù"
        DataPanel.boxenname.Text = "Molybdenum"
        DataPanel.boxensymbol.Text = "[mɔ'libdinəm]"
        DataPanel.boxoutelec.Text = "4d5 5s1"
        DataPanel.boxvalence.Text = "6"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "植物生长所需的微量元素　"
        DataPanel.boxrelaatomass.Text = "95.94"
    End Sub

    Private Sub mt109_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mt109.Click
        DataPanel.boxchname.Text = "Mt"
        DataPanel.boxchpinyin.Text = "mài"
        DataPanel.boxenname.Text = "Mietnerium"
        DataPanel.boxensymbol.Text = "mītˈni(ə)rēəm"
        DataPanel.boxoutelec.Text = "6d7 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(266)"
    End Sub

    Private Sub n7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles n7.Click
        DataPanel.boxchname.Text = "N"
        DataPanel.boxchpinyin.Text = "dàn"
        DataPanel.boxenname.Text = "Nitrogen"
        DataPanel.boxensymbol.Text = "['naitrədʒən]"
        DataPanel.boxoutelec.Text = "2s2 2p3"
        DataPanel.boxvalence.Text = "-3、 1 、2、 3、 4、5"
        DataPanel.boxclassifi.Text = "主/非/气"
        DataPanel.boxintro.Text = "空气中含量最多的元素"
        DataPanel.boxrelaatomass.Text = "14.01"
    End Sub

    Private Sub na11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles na11.Click
        DataPanel.boxchname.Text = "Na"
        DataPanel.boxchpinyin.Text = "nà"
        DataPanel.boxenname.Text = "Sodium"
        DataPanel.boxensymbol.Text = "['səudiəm]"
        DataPanel.boxoutelec.Text = "3s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "主/金/碱"
        DataPanel.boxintro.Text = "活泼"
        DataPanel.boxrelaatomass.Text = "22.99"
    End Sub

    Private Sub nb41_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nb41.Click
        DataPanel.boxchname.Text = "Nb"
        DataPanel.boxchpinyin.Text = "ní"
        DataPanel.boxenname.Text = "Niobium"
        DataPanel.boxensymbol.Text = "[nai'əubiəm]"
        DataPanel.boxoutelec.Text = "4d4 5s1"
        DataPanel.boxvalence.Text = "5"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "铌钢被用于制作汽车外壳　"
        DataPanel.boxrelaatomass.Text = "92.91"
    End Sub

    Private Sub ne10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ne10.Click
        DataPanel.boxchname.Text = "Ne"
        DataPanel.boxchpinyin.Text = "nǎi"
        DataPanel.boxenname.Text = "Neon"
        DataPanel.boxensymbol.Text = "['ni:ɔn]"
        DataPanel.boxoutelec.Text = "2s2 2p6"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "主/非/稀"
        DataPanel.boxintro.Text = "稀有气体"
        DataPanel.boxrelaatomass.Text = "20.18"
    End Sub

    Private Sub nh113_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles nh113.Click
        DataPanel.boxchname.Text = "Nh"
        DataPanel.boxchpinyin.Text = "nǐ"
        DataPanel.boxenname.Text = "Nihonium"
        DataPanel.boxensymbol.Text = "Nihonium"
        DataPanel.boxoutelec.Text = "5f6d7s7p1"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "人造 放射,不稳定的超重元素"
        DataPanel.boxrelaatomass.Text = "(286)"
    End Sub

    Private Sub ni28_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ni28.Click
        DataPanel.boxchname.Text = "59"
        DataPanel.boxchpinyin.Text = "niè"
        DataPanel.boxenname.Text = "Nickel"
        DataPanel.boxensymbol.Text = "['nikəl]"
        DataPanel.boxoutelec.Text = "3d8 4s2"
        DataPanel.boxvalence.Text = "2、3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "有磁性和良好可塑性"
        DataPanel.boxrelaatomass.Text = "58.69"
    End Sub

    Private Sub o8_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles o8.Click
        DataPanel.boxchname.Text = "O"
        DataPanel.boxchpinyin.Text = "yǎng"
        DataPanel.boxenname.Text = "Oxygen"
        DataPanel.boxensymbol.Text = "['ɔksidʒən]"
        DataPanel.boxoutelec.Text = "2s2 2p4"
        DataPanel.boxvalence.Text = "-2、-1、2"
        DataPanel.boxclassifi.Text = "主/非/气"
        DataPanel.boxintro.Text = "地壳中最多"
        DataPanel.boxrelaatomass.Text = "16.00"
    End Sub

    Private Sub og118_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles og118.Click
        DataPanel.boxchname.Text = "Og"
        DataPanel.boxchpinyin.Text = "ào"
        DataPanel.boxenname.Text = "Oganesson"
        DataPanel.boxensymbol.Text = "Oganesson"
        DataPanel.boxoutelec.Text = "5f6d7s7p6"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/非/稀"
        DataPanel.boxintro.Text = "人造 放射,人工合成的稀有气体元素"
        DataPanel.boxrelaatomass.Text = "(294)"
    End Sub

    Private Sub os76_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles os76.Click
        DataPanel.boxchname.Text = "Os"
        DataPanel.boxchpinyin.Text = "é"
        DataPanel.boxenname.Text = "Osmium"
        DataPanel.boxensymbol.Text = "['ɔzmiəm]"
        DataPanel.boxoutelec.Text = "5d6 6s2"
        DataPanel.boxvalence.Text = "4,6,8"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "密度最大的金属"
        DataPanel.boxrelaatomass.Text = "190.23"
    End Sub

    Private Sub p15_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles p15.Click
        DataPanel.boxchname.Text = "P"
        DataPanel.boxchpinyin.Text = "lín"
        DataPanel.boxenname.Text = "Phosphorus"
        DataPanel.boxensymbol.Text = "['fɔsfərəs]"
        DataPanel.boxoutelec.Text = "3s2 3p3"
        DataPanel.boxvalence.Text = "-3、3、5"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "白磷有剧毒"
        DataPanel.boxrelaatomass.Text = "30.97"
    End Sub

    Private Sub pb82_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pb82.Click
        DataPanel.boxchname.Text = "Pb"
        DataPanel.boxchpinyin.Text = "qiān"
        DataPanel.boxenname.Text = "Lead"
        DataPanel.boxensymbol.Text = "[led]"
        DataPanel.boxoutelec.Text = "6s2 6p2"
        DataPanel.boxvalence.Text = "2,4"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "　密度大，熔点低，对人体有毒性。许多化妆品中必须含有的元素"
        DataPanel.boxrelaatomass.Text = "207.2"
    End Sub

    Private Sub pd46_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pd46.Click
        DataPanel.boxchname.Text = "Pd"
        DataPanel.boxchpinyin.Text = "bǎ"
        DataPanel.boxenname.Text = "Palladium"
        DataPanel.boxensymbol.Text = "[pə'leidiəm]"
        DataPanel.boxoutelec.Text = "4d10"
        DataPanel.boxvalence.Text = "2,4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "被应用于酒精检测中"
        DataPanel.boxrelaatomass.Text = "106.42"
    End Sub

    Private Sub po84_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles po84.Click
        DataPanel.boxchname.Text = "Po"
        DataPanel.boxchpinyin.Text = "pō"
        DataPanel.boxenname.Text = "Polonium"
        DataPanel.boxensymbol.Text = "[pə'ləuniəm]"
        DataPanel.boxoutelec.Text = "6s2 6p4"
        DataPanel.boxvalence.Text = "-2、6"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "放射"
        DataPanel.boxrelaatomass.Text = "(209)"
    End Sub

    Private Sub pt78_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pt78.Click
        DataPanel.boxchname.Text = "Pt"
        DataPanel.boxchpinyin.Text = "bó"
        DataPanel.boxenname.Text = "Platinum"
        DataPanel.boxensymbol.Text = "['pl&aelig;tinəm]"
        DataPanel.boxoutelec.Text = "5d9 6s1"
        DataPanel.boxvalence.Text = "2,4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "被应用于珠宝首饰中的贵金属，俗称铂金　"
        DataPanel.boxrelaatomass.Text = "195.08"
    End Sub

    Private Sub rb37_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rb37.Click
        DataPanel.boxchname.Text = "Rb"
        DataPanel.boxchpinyin.Text = "rú"
        DataPanel.boxenname.Text = "Rubidium"
        DataPanel.boxensymbol.Text = "[ru:'bidiəm]"
        DataPanel.boxoutelec.Text = "5s1"
        DataPanel.boxvalence.Text = "1"
        DataPanel.boxclassifi.Text = "主/金/碱"
        DataPanel.boxintro.Text = "活泼"
        DataPanel.boxrelaatomass.Text = "85.47"
    End Sub

    Private Sub re75_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles re75.Click
        DataPanel.boxchname.Text = "Re"
        DataPanel.boxchpinyin.Text = "lái"
        DataPanel.boxenname.Text = "Rhenium"
        DataPanel.boxensymbol.Text = "['ri:niəm]"
        DataPanel.boxoutelec.Text = "5d5 6s2"
        DataPanel.boxvalence.Text = "7"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "最晚被发现的稳定元素　"
        DataPanel.boxrelaatomass.Text = "186.21"
    End Sub

    Private Sub rf104_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rf104.Click
        DataPanel.boxchname.Text = "Rf"
        DataPanel.boxchpinyin.Text = "lú"
        DataPanel.boxenname.Text = "Rutherfordium"
        DataPanel.boxensymbol.Text = "[,rʌ&eth;ə'fɔ:diəm]"
        DataPanel.boxoutelec.Text = "6d2 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(261)"
    End Sub

    Private Sub rg111_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rg111.Click
        DataPanel.boxchname.Text = "Rg"
        DataPanel.boxchpinyin.Text = "lún"
        DataPanel.boxenname.Text = "Roentgenium"
        DataPanel.boxensymbol.Text = "rentˈgenēəm,rənt-"
        DataPanel.boxoutelec.Text = "6d9 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金"
        DataPanel.boxintro.Text = "超重元素"
        DataPanel.boxrelaatomass.Text = "(272)"
    End Sub

    Private Sub rh45_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rh45.Click
        DataPanel.boxchname.Text = "Rh"
        DataPanel.boxchpinyin.Text = "lǎo"
        DataPanel.boxenname.Text = "Rhodium"
        DataPanel.boxensymbol.Text = "['rəudiəm]"
        DataPanel.boxoutelec.Text = "4d8 5s1"
        DataPanel.boxvalence.Text = "3，4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "现代珠宝制作过程进行表面处理的必须元素　"
        DataPanel.boxrelaatomass.Text = "102.91"
    End Sub

    Private Sub rn86_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles rn86.Click
        DataPanel.boxchname.Text = "Rn"
        DataPanel.boxchpinyin.Text = "dōng"
        DataPanel.boxenname.Text = "Radon"
        DataPanel.boxensymbol.Text = "['reidɔn]"
        DataPanel.boxoutelec.Text = "6s2 6p6"
        DataPanel.boxvalence.Text = "--"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "放射"
        DataPanel.boxrelaatomass.Text = "(222)"
    End Sub

    Private Sub ra88_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ra88.Click
        DataPanel.boxchname.Text = "Ra"
        DataPanel.boxchpinyin.Text = "léi"
        DataPanel.boxenname.Text = "Radium"
        DataPanel.boxensymbol.Text = "['reidiəm]"
        DataPanel.boxoutelec.Text = "7s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/金/碱土"
        DataPanel.boxintro.Text = "放射"
        DataPanel.boxrelaatomass.Text = "(226)"
    End Sub

    Private Sub ru44_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ru44.Click
        DataPanel.boxchname.Text = "Ru"
        DataPanel.boxchpinyin.Text = "liǎo"
        DataPanel.boxenname.Text = "Ruthenium"
        DataPanel.boxensymbol.Text = "[ru:'θi:niəm]"
        DataPanel.boxoutelec.Text = "4d7 5s1"
        DataPanel.boxvalence.Text = "3、8"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "多价稀有金属元素"
        DataPanel.boxrelaatomass.Text = "101.07"
    End Sub

    Private Sub s16_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles s16.Click
        DataPanel.boxchname.Text = "S"
        DataPanel.boxchpinyin.Text = "liú"
        DataPanel.boxenname.Text = "Sulfur"
        DataPanel.boxensymbol.Text = "['sʌlfə]"
        DataPanel.boxoutelec.Text = "3s2 3p4"
        DataPanel.boxvalence.Text = "-2、4、6"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "质地柔软，轻。与氧气燃烧形成有毒的二氧化硫"
        DataPanel.boxrelaatomass.Text = "32.07"
    End Sub

    Private Sub sb51_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sb51.Click
        DataPanel.boxchname.Text = "Sb"
        DataPanel.boxchpinyin.Text = "tī"
        DataPanel.boxenname.Text = "Antimony"
        DataPanel.boxensymbol.Text = "['&aelig;ntiməni]"
        DataPanel.boxoutelec.Text = "5s2 5p3"
        DataPanel.boxvalence.Text = "-3、3、5"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "熔点低，被用于制作保险丝　"
        DataPanel.boxrelaatomass.Text = "121.76"
    End Sub

    Private Sub sc21_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sc21.Click
        DataPanel.boxchname.Text = "Sc"
        DataPanel.boxchpinyin.Text = "kàng"
        DataPanel.boxenname.Text = "Scandium"
        DataPanel.boxensymbol.Text = "['sk&aelig;ndiəm]"
        DataPanel.boxoutelec.Text = "3d1 4s2"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "一种柔软过渡金属，常与钆，铒混合存在"
        DataPanel.boxrelaatomass.Text = "44.96"
    End Sub

    Private Sub se34_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles se34.Click
        DataPanel.boxchname.Text = "Se"
        DataPanel.boxchpinyin.Text = "xī"
        DataPanel.boxenname.Text = "Selenium"
        DataPanel.boxensymbol.Text = "[si'li:niəm]"
        DataPanel.boxoutelec.Text = "4s2 4p4"
        DataPanel.boxvalence.Text = "-2、4、6"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "可使玻璃致色为鲜红色　"
        DataPanel.boxrelaatomass.Text = "78.96"
    End Sub

    Private Sub sg106_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sg106.Click
        DataPanel.boxchname.Text = "Sg"
        DataPanel.boxchpinyin.Text = "xǐ"
        DataPanel.boxenname.Text = "Seaborgium"
        DataPanel.boxensymbol.Text = "[si:bɔ:ɡiəm]"
        DataPanel.boxoutelec.Text = "6d4 7s2"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人造 放射"
        DataPanel.boxrelaatomass.Text = "(263)"
    End Sub

    Private Sub si14_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles si14.Click
        DataPanel.boxchname.Text = "Si"
        DataPanel.boxchpinyin.Text = "guī"
        DataPanel.boxenname.Text = "Silicon"
        DataPanel.boxensymbol.Text = "['silikən]"
        DataPanel.boxoutelec.Text = "3s2 3p2"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "地壳中含量仅次于氧"
        DataPanel.boxrelaatomass.Text = "28.09"
    End Sub

    Private Sub sn50_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sn50.Click
        DataPanel.boxchname.Text = "Sn"
        DataPanel.boxchpinyin.Text = "xī"
        DataPanel.boxenname.Text = "Tin"
        DataPanel.boxensymbol.Text = "[tin]"
        DataPanel.boxoutelec.Text = "5s2 5p2"
        DataPanel.boxvalence.Text = "2、4"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "人类最早发现应用的元素之一，被用于制造容器"
        DataPanel.boxrelaatomass.Text = "118.71"
    End Sub

    Private Sub sr38_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sr38.Click
        DataPanel.boxchname.Text = "Sr"
        DataPanel.boxchpinyin.Text = "sī"
        DataPanel.boxenname.Text = "Strontium"
        DataPanel.boxensymbol.Text = "['strɔntiəm]"
        DataPanel.boxoutelec.Text = "5s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "主/金/碱土"
        DataPanel.boxintro.Text = "是碱土元素中丰度最小的元素　"
        DataPanel.boxrelaatomass.Text = "87.62"
    End Sub

    Private Sub ta73_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ta73.Click
        DataPanel.boxchname.Text = "Ta"
        DataPanel.boxchpinyin.Text = "tǎn"
        DataPanel.boxenname.Text = "Tantalum"
        DataPanel.boxensymbol.Text = "['t&aelig;ntələm]"
        DataPanel.boxoutelec.Text = "5d3 6s2"
        DataPanel.boxvalence.Text = "5"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = "180.95"
    End Sub

    Private Sub tc43_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tc43.Click
        DataPanel.boxchname.Text = "Tc"
        DataPanel.boxchpinyin.Text = "dé"
        DataPanel.boxenname.Text = "Technetium"
        DataPanel.boxensymbol.Text = "[tek'ni:ʃiəm]"
        DataPanel.boxoutelec.Text = "4d5 5s2"
        DataPanel.boxvalence.Text = "7"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "原子序数最小的放射性元素"
        DataPanel.boxrelaatomass.Text = "(99)"
    End Sub

    Private Sub te52_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles te52.Click
        DataPanel.boxchname.Text = "Te"
        DataPanel.boxchpinyin.Text = "dì"
        DataPanel.boxenname.Text = "Tellurium"
        DataPanel.boxensymbol.Text = "[te'ljuəriəm]"
        DataPanel.boxoutelec.Text = "5s2 5p4"
        DataPanel.boxvalence.Text = "-2、2、4、6"
        DataPanel.boxclassifi.Text = "主/非"
        DataPanel.boxintro.Text = "密度最大的非金属"
        DataPanel.boxrelaatomass.Text = "127.60"
    End Sub

    Private Sub ti22_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ti22.Click
        DataPanel.boxchname.Text = "Ti"
        DataPanel.boxchpinyin.Text = "tài"
        DataPanel.boxenname.Text = "Titanium"
        DataPanel.boxensymbol.Text = "[tai'teiniəm]"
        DataPanel.boxoutelec.Text = "3d2 4s2"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "能在氮气中燃烧，熔点高"
        DataPanel.boxrelaatomass.Text = "47.87"
    End Sub

    Private Sub tl81_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tl81.Click
        DataPanel.boxchname.Text = "Tl"
        DataPanel.boxchpinyin.Text = "tā"
        DataPanel.boxenname.Text = "Thallium"
        DataPanel.boxensymbol.Text = "['θ&aelig;liəm]"
        DataPanel.boxoutelec.Text = "6s2 6p1"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = "204.38"
    End Sub

    Private Sub ts117_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ts117.Click
        DataPanel.boxchname.Text = "Ts"
        DataPanel.boxchpinyin.Text = "tián"
        DataPanel.boxenname.Text = "Tennessine"
        DataPanel.boxensymbol.Text = "Tennessine"
        DataPanel.boxoutelec.Text = "5f6d7s7p5"
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = "主/金"
        DataPanel.boxintro.Text = "卤族元素,人工合成的放射性化学元素"
        DataPanel.boxrelaatomass.Text = "(294)"
    End Sub

    Private Sub v23_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles v23.Click
        DataPanel.boxchname.Text = "V"
        DataPanel.boxchpinyin.Text = "fán"
        DataPanel.boxenname.Text = "Vanadium"
        DataPanel.boxensymbol.Text = "[və'neidiəm]"
        DataPanel.boxoutelec.Text = "3d3 4s2"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "高熔点稀有金属"
        DataPanel.boxrelaatomass.Text = "50.94"
    End Sub

    Private Sub w74_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles w74.Click
        DataPanel.boxchname.Text = "W"
        DataPanel.boxchpinyin.Text = "wū"
        DataPanel.boxenname.Text = "Tungsten"
        DataPanel.boxensymbol.Text = "['tʌŋstən]"
        DataPanel.boxoutelec.Text = "5d4 6s2"
        DataPanel.boxvalence.Text = "6"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "熔点最高"
        DataPanel.boxrelaatomass.Text = "183.84"
    End Sub

    Private Sub xe54_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles xe54.Click
        DataPanel.boxchname.Text = "Xe"
        DataPanel.boxchpinyin.Text = "xiān"
        DataPanel.boxenname.Text = "Xenon"
        DataPanel.boxensymbol.Text = "['zenɔn]"
        DataPanel.boxoutelec.Text = "5s2 5p6"
        DataPanel.boxvalence.Text = "4、6、8"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "可被用于制作氙灯　"
        DataPanel.boxrelaatomass.Text = "131.29"
    End Sub

    Private Sub y39_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles y39.Click
        DataPanel.boxchname.Text = "Y"
        DataPanel.boxchpinyin.Text = "yǐ"
        DataPanel.boxenname.Text = "Yttrium"
        DataPanel.boxensymbol.Text = "['itriəm]"
        DataPanel.boxoutelec.Text = "4d1 5s2"
        DataPanel.boxvalence.Text = "3"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人工合成的钇铝榴石曾被当做钻石的替代品　"
        DataPanel.boxrelaatomass.Text = "88.91"
    End Sub

    Private Sub zn30_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles zn30.Click
        DataPanel.boxchname.Text = "Zn"
        DataPanel.boxchpinyin.Text = "xīn"
        DataPanel.boxenname.Text = "Zinc"
        DataPanel.boxensymbol.Text = "[ziŋk]"
        DataPanel.boxoutelec.Text = "3d10 4s2"
        DataPanel.boxvalence.Text = "2"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "人体需要的微量元素"
        DataPanel.boxrelaatomass.Text = "69.72"
    End Sub

    Private Sub zr40_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles zr40.Click
        DataPanel.boxchname.Text = "Zr"
        DataPanel.boxchpinyin.Text = "gào"
        DataPanel.boxenname.Text = "Zirconium"
        DataPanel.boxensymbol.Text = "[zə:'kəuniəm]"
        DataPanel.boxoutelec.Text = "4d2 5s2"
        DataPanel.boxvalence.Text = "4"
        DataPanel.boxclassifi.Text = "副/金/过"
        DataPanel.boxintro.Text = "氧化物立方氧化锆为钻石的人工替代品　"
        DataPanel.boxrelaatomass.Text = "91.22"
    End Sub

    Private Sub uue119_Click(sender As Object, e As EventArgs) Handles uue119.Click
        DataPanel.boxchname.Text = "Uue"
        DataPanel.boxchpinyin.Text = ""
        DataPanel.boxenname.Text = ""
        DataPanel.boxensymbol.Text = ""
        DataPanel.boxoutelec.Text = ""
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = ""
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = ""
    End Sub

    Private Sub ubn120_Click(sender As Object, e As EventArgs) Handles ubn120.Click
        DataPanel.boxchname.Text = "Ubn"
        DataPanel.boxchpinyin.Text = ""
        DataPanel.boxenname.Text = ""
        DataPanel.boxensymbol.Text = ""
        DataPanel.boxoutelec.Text = ""
        DataPanel.boxvalence.Text = ""
        DataPanel.boxclassifi.Text = ""
        DataPanel.boxintro.Text = ""
        DataPanel.boxrelaatomass.Text = ""
    End Sub
End Class