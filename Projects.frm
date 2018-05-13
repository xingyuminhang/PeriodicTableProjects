VERSION 5.00
Begin VB.Form PeriodicTable 
   Caption         =   "元素周期表Projects 2.0"
   ClientHeight    =   6270
   ClientLeft      =   120
   ClientTop       =   450
   ClientWidth     =   13935
   Icon            =   "Projects.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   6270
   ScaleWidth      =   13935
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton ElectronicShellTool 
      Caption         =   "电子层工具"
      Height          =   495
      Left            =   10320
      TabIndex        =   153
      Top             =   120
      Width           =   1095
   End
   Begin VB.CommandButton IonTool 
      Caption         =   "离子工具"
      Height          =   495
      Left            =   11520
      TabIndex        =   152
      Top             =   120
      Width           =   1095
   End
   Begin VB.CommandButton AboutTool 
      Caption         =   "关于"
      Height          =   495
      Left            =   12720
      TabIndex        =   151
      Top             =   120
      Width           =   1095
   End
   Begin VB.TextBox qt 
      Height          =   615
      Left            =   7680
      TabIndex        =   149
      Text            =   "Hi!单击您想要查询的元素即可开始!"
      Top             =   720
      Width           =   2895
   End
   Begin VB.Frame Frame2 
      Caption         =   "电子数与化合价"
      Height          =   2175
      Left            =   4560
      TabIndex        =   91
      Top             =   480
      Width           =   3015
      Begin VB.TextBox xdyzzl 
         Height          =   270
         Left            =   1320
         TabIndex        =   133
         Text            =   "以12C=12为基准"
         Top             =   1560
         Width           =   1455
      End
      Begin VB.TextBox fl 
         Height          =   270
         Left            =   1320
         TabIndex        =   132
         Text            =   "主副/金非/类别"
         Top             =   1200
         Width           =   1455
      End
      Begin VB.TextBox cjhhj 
         Height          =   270
         Left            =   1320
         TabIndex        =   130
         Text            =   "常见的化合价"
         Top             =   840
         Width           =   1455
      End
      Begin VB.TextBox wcdz 
         Height          =   270
         Left            =   1320
         TabIndex        =   128
         Text            =   "外层电子数"
         Top             =   480
         Width           =   1455
      End
      Begin VB.Label Label35 
         Caption         =   "相对原子质量:"
         Height          =   255
         Left            =   120
         TabIndex        =   134
         Top             =   1560
         Width           =   1215
      End
      Begin VB.Label Label34 
         Caption         =   "分类:"
         Height          =   255
         Left            =   120
         TabIndex        =   131
         Top             =   1200
         Width           =   1095
      End
      Begin VB.Label Label33 
         Caption         =   "常见化合价:"
         Height          =   255
         Left            =   120
         TabIndex        =   129
         Top             =   840
         Width           =   1095
      End
      Begin VB.Label Label32 
         Caption         =   "外层电子："
         Height          =   255
         Left            =   120
         TabIndex        =   127
         Top             =   480
         Width           =   1095
      End
   End
   Begin VB.CommandButton ar18 
      Caption         =   "18氩"
      Height          =   735
      Left            =   10680
      TabIndex        =   89
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton cl17 
      Caption         =   "17氯"
      Height          =   735
      Left            =   10080
      TabIndex        =   88
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton s16 
      Caption         =   "16硫"
      Height          =   735
      Left            =   9480
      TabIndex        =   87
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton p15 
      Caption         =   "15磷"
      Height          =   735
      Left            =   8880
      TabIndex        =   86
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton si14 
      Caption         =   "14硅"
      Height          =   735
      Left            =   8280
      TabIndex        =   85
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton al13 
      Caption         =   "13铝"
      Height          =   735
      Left            =   7680
      TabIndex        =   84
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton ne10 
      Caption         =   "10氖"
      Height          =   735
      Left            =   10680
      TabIndex        =   83
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton f9 
      Caption         =   "9氟"
      Height          =   735
      Left            =   10080
      TabIndex        =   82
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton o8 
      Caption         =   "8氧"
      Height          =   735
      Left            =   9480
      TabIndex        =   81
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton n7 
      Caption         =   "7氮"
      Height          =   735
      Left            =   8880
      TabIndex        =   80
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton c6 
      Caption         =   "6碳"
      Height          =   735
      Left            =   8280
      TabIndex        =   79
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton b5 
      Caption         =   "5硼"
      Height          =   735
      Left            =   7680
      TabIndex        =   78
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton he2 
      Caption         =   "2氦"
      Height          =   735
      Left            =   10680
      TabIndex        =   77
      Top             =   1080
      Width           =   615
   End
   Begin VB.CommandButton mg12 
      Caption         =   "12镁"
      Height          =   735
      Left            =   1080
      TabIndex        =   76
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton be4 
      Caption         =   "4铍"
      Height          =   735
      Left            =   1080
      TabIndex        =   75
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton og118 
      Caption         =   "118奥气"
      Height          =   735
      Left            =   10680
      TabIndex        =   74
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton ts117 
      Caption         =   "117石田"
      Height          =   735
      Left            =   10080
      TabIndex        =   73
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton lv116 
      Caption         =   "116鉝"
      Height          =   735
      Left            =   9480
      TabIndex        =   72
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton mc115 
      Caption         =   "115镆"
      Height          =   735
      Left            =   8880
      TabIndex        =   71
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton fl114 
      Caption         =   "114鈇"
      Height          =   735
      Left            =   8280
      TabIndex        =   70
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton nh113 
      Caption         =   "113鉨"
      Height          =   735
      Left            =   7680
      TabIndex        =   69
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton cn112 
      Caption         =   "112鎶"
      Height          =   735
      Left            =   7080
      TabIndex        =   68
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton rg111 
      Caption         =   "111錀"
      Height          =   735
      Left            =   6480
      TabIndex        =   67
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton ds110 
      Caption         =   "110鐽"
      Height          =   735
      Left            =   5880
      TabIndex        =   66
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton mt109 
      Appearance      =   0  'Flat
      Caption         =   "109?钅麦(梦)"
      Height          =   735
      Left            =   5280
      TabIndex        =   65
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton hs108 
      Caption         =   "108钅黑"
      Height          =   735
      Left            =   4680
      TabIndex        =   64
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton bh107 
      Caption         =   "107钅波"
      Height          =   735
      Left            =   4080
      TabIndex        =   63
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton sg106 
      Caption         =   "106钅喜"
      Height          =   735
      Left            =   3480
      TabIndex        =   62
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton db105 
      Caption         =   "105钅杜"
      Height          =   735
      Left            =   2880
      TabIndex        =   61
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton rf104 
      Caption         =   "104鑪"
      Height          =   735
      Left            =   2280
      TabIndex        =   60
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton aclr 
      Caption         =   "锕系"
      Height          =   735
      Left            =   1680
      TabIndex        =   59
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton rr88 
      Caption         =   "88镭"
      Height          =   735
      Left            =   1080
      TabIndex        =   58
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton fr87 
      Caption         =   "87钫"
      Height          =   735
      Left            =   480
      TabIndex        =   57
      Top             =   5400
      Width           =   615
   End
   Begin VB.CommandButton rn86 
      Caption         =   "86氡"
      Height          =   735
      Left            =   10680
      TabIndex        =   56
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton at85 
      Caption         =   "85砹"
      Height          =   735
      Left            =   10080
      TabIndex        =   55
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton po84 
      Caption         =   "84钋"
      Height          =   735
      Left            =   9480
      TabIndex        =   54
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton bi83 
      Caption         =   "83铋"
      Height          =   735
      Left            =   8880
      TabIndex        =   53
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton pb82 
      Caption         =   "82铅"
      Height          =   735
      Left            =   8280
      TabIndex        =   52
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton tl81 
      Caption         =   "81铊"
      Height          =   735
      Left            =   7680
      TabIndex        =   51
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton hg80 
      Caption         =   "80汞"
      Height          =   735
      Left            =   7080
      TabIndex        =   50
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton au79 
      Caption         =   "79金"
      Height          =   735
      Left            =   6480
      TabIndex        =   49
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton pt78 
      Caption         =   "78铂"
      Height          =   735
      Left            =   5880
      TabIndex        =   48
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton ir77 
      Caption         =   "77铱"
      Height          =   735
      Left            =   5280
      TabIndex        =   47
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton os76 
      Caption         =   "76锇"
      Height          =   735
      Left            =   4680
      TabIndex        =   46
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton re75 
      Caption         =   "75铼"
      Height          =   735
      Left            =   4080
      TabIndex        =   45
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton w74 
      Caption         =   "74钨"
      Height          =   735
      Left            =   3480
      TabIndex        =   44
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton ta73 
      Caption         =   "73钽"
      Height          =   735
      Left            =   2880
      TabIndex        =   43
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton hf72 
      Caption         =   "72铪"
      Height          =   735
      Left            =   2280
      TabIndex        =   42
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton lalu 
      Caption         =   "镧系"
      Height          =   735
      Left            =   1680
      TabIndex        =   41
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton ba56 
      Caption         =   "56钡"
      Height          =   735
      Left            =   1080
      TabIndex        =   40
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton cs55 
      Caption         =   "55铯"
      Height          =   735
      Left            =   480
      TabIndex        =   39
      Top             =   4680
      Width           =   615
   End
   Begin VB.CommandButton xe54 
      Caption         =   "54氙"
      Height          =   735
      Left            =   10680
      TabIndex        =   38
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton i53 
      Caption         =   "53碘"
      Height          =   735
      Left            =   10080
      TabIndex        =   37
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton te52 
      Caption         =   "52碲"
      Height          =   735
      Left            =   9480
      TabIndex        =   36
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton sb51 
      Caption         =   "51锑"
      Height          =   735
      Left            =   8880
      TabIndex        =   35
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton sn50 
      Caption         =   "50锡"
      Height          =   735
      Left            =   8280
      TabIndex        =   34
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton in49 
      Caption         =   "49铟"
      Height          =   735
      Left            =   7680
      TabIndex        =   33
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton cd48 
      Caption         =   "48镉"
      Height          =   735
      Left            =   7080
      TabIndex        =   32
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton ag47 
      Caption         =   "47银"
      Height          =   735
      Left            =   6480
      TabIndex        =   31
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton pd46 
      Caption         =   "46钯"
      Height          =   735
      Left            =   5880
      TabIndex        =   30
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton rh45 
      Caption         =   "45铑"
      Height          =   735
      Left            =   5280
      TabIndex        =   29
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton ru44 
      Caption         =   "44钌"
      Height          =   735
      Left            =   4680
      TabIndex        =   28
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton tc43 
      Caption         =   "43锝"
      Height          =   735
      Left            =   4080
      TabIndex        =   27
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton mo42 
      Caption         =   "42钼"
      Height          =   735
      Left            =   3480
      TabIndex        =   26
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton nb41 
      Caption         =   "41铌"
      Height          =   735
      Left            =   2880
      TabIndex        =   25
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton zr40 
      Caption         =   "40锆"
      Height          =   735
      Left            =   2280
      TabIndex        =   24
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton y39 
      Caption         =   "39钇"
      Height          =   735
      Left            =   1680
      TabIndex        =   23
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton sr38 
      Caption         =   "38锶"
      Height          =   735
      Left            =   1080
      TabIndex        =   22
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton rb37 
      Caption         =   "37铷"
      Height          =   735
      Left            =   480
      TabIndex        =   21
      Top             =   3960
      Width           =   615
   End
   Begin VB.CommandButton kr36 
      Caption         =   "36氪"
      Height          =   735
      Left            =   10680
      TabIndex        =   20
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton br35 
      Caption         =   "35溴"
      Height          =   735
      Left            =   10080
      TabIndex        =   19
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton se34 
      Caption         =   "34硒"
      Height          =   735
      Left            =   9480
      TabIndex        =   18
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton as33 
      Caption         =   "33砷"
      Height          =   735
      Left            =   8880
      TabIndex        =   17
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton ge32 
      Caption         =   "32锗"
      Height          =   735
      Left            =   8280
      TabIndex        =   16
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton ga31 
      Caption         =   "31镓"
      Height          =   735
      Left            =   7680
      TabIndex        =   15
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton zn30 
      Caption         =   "30锌"
      Height          =   735
      Left            =   7080
      TabIndex        =   14
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton cu29 
      Caption         =   "29铜"
      Height          =   735
      Left            =   6480
      TabIndex        =   13
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton ni28 
      Caption         =   "28镍"
      Height          =   735
      Left            =   5880
      TabIndex        =   12
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton co27 
      Caption         =   "27钴"
      Height          =   735
      Left            =   5280
      TabIndex        =   11
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton fe26 
      Caption         =   "26铁"
      Height          =   735
      Left            =   4680
      TabIndex        =   10
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton mn25 
      Caption         =   "25锰"
      Height          =   735
      Left            =   4080
      TabIndex        =   9
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton cr24 
      Caption         =   "24铬"
      Height          =   735
      Left            =   3480
      TabIndex        =   8
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton v23 
      Caption         =   "23钒"
      Height          =   735
      Left            =   2880
      TabIndex        =   7
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton ti22 
      Caption         =   "22钛"
      Height          =   735
      Left            =   2280
      TabIndex        =   6
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton sc21 
      Caption         =   "21钪"
      Height          =   735
      Left            =   1680
      TabIndex        =   5
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton ca20 
      Caption         =   "20钙"
      Height          =   735
      Left            =   1080
      TabIndex        =   4
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton k19 
      Caption         =   "19钾"
      Height          =   735
      Left            =   480
      TabIndex        =   3
      Top             =   3240
      Width           =   615
   End
   Begin VB.CommandButton na11 
      Caption         =   "11钠"
      Height          =   735
      Left            =   480
      TabIndex        =   2
      Top             =   2520
      Width           =   615
   End
   Begin VB.CommandButton li3 
      Caption         =   "3锂"
      Height          =   735
      Left            =   480
      TabIndex        =   1
      Top             =   1800
      Width           =   615
   End
   Begin VB.CommandButton h1 
      Caption         =   "1氢"
      Height          =   735
      Left            =   480
      TabIndex        =   0
      Top             =   1080
      Width           =   615
   End
   Begin VB.Frame Frame1 
      Caption         =   "名称"
      Height          =   2175
      Left            =   1920
      TabIndex        =   90
      Top             =   480
      Width           =   2655
      Begin VB.TextBox yyyb 
         Height          =   270
         Left            =   1200
         TabIndex        =   126
         Text            =   "英文名音标"
         Top             =   1560
         Width           =   1335
      End
      Begin VB.TextBox ywm 
         Height          =   270
         Left            =   1200
         TabIndex        =   125
         Text            =   "英文名"
         Top             =   1200
         Width           =   1335
      End
      Begin VB.TextBox hypy 
         Height          =   270
         Left            =   1200
         TabIndex        =   124
         Text            =   "汉字汉语拼音"
         Top             =   840
         Width           =   1335
      End
      Begin VB.TextBox ysfh 
         Height          =   270
         Left            =   1200
         TabIndex        =   123
         Text            =   "国际通用符号"
         Top             =   480
         Width           =   1335
      End
      Begin VB.Label Label31 
         Caption         =   "英语音标："
         Height          =   255
         Left            =   120
         TabIndex        =   122
         Top             =   1560
         Width           =   975
      End
      Begin VB.Label Label30 
         Caption         =   "英文名："
         Height          =   255
         Left            =   120
         TabIndex        =   121
         Top             =   1200
         Width           =   975
      End
      Begin VB.Label Label29 
         Caption         =   "汉语拼音："
         Height          =   255
         Left            =   120
         TabIndex        =   120
         Top             =   840
         Width           =   975
      End
      Begin VB.Label Label28 
         Caption         =   "元素符号："
         Height          =   255
         Left            =   120
         TabIndex        =   119
         Top             =   480
         Width           =   975
      End
   End
   Begin VB.Label Label36 
      Caption         =   "其它"
      Height          =   255
      Left            =   7680
      TabIndex        =   150
      Top             =   360
      Width           =   975
   End
   Begin VB.Label Label50 
      Caption         =   "8,18,32,32,18,8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   148
      Top             =   5400
      Width           =   1575
   End
   Begin VB.Label Label49 
      Caption         =   "8,18,32,18,8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   147
      Top             =   4800
      Width           =   1575
   End
   Begin VB.Label Label48 
      Caption         =   "8,18,18,8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   146
      Top             =   3960
      Width           =   1575
   End
   Begin VB.Label Label47 
      Caption         =   "8,18,8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   145
      Top             =   3240
      Width           =   1575
   End
   Begin VB.Label Label46 
      Caption         =   "8,8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   144
      Top             =   2520
      Width           =   1575
   End
   Begin VB.Label Label45 
      Caption         =   "8,2"
      Height          =   735
      Left            =   12120
      TabIndex        =   143
      Top             =   1920
      Width           =   1575
   End
   Begin VB.Label Label44 
      Caption         =   "2"
      Height          =   735
      Left            =   12120
      TabIndex        =   142
      Top             =   1080
      Width           =   1575
   End
   Begin VB.Label Label43 
      Caption         =   "QPONMLK"
      Height          =   735
      Left            =   11280
      TabIndex        =   141
      Top             =   5400
      Width           =   735
   End
   Begin VB.Label Label42 
      Caption         =   "PONMLK"
      Height          =   735
      Left            =   11280
      TabIndex        =   140
      Top             =   4800
      Width           =   735
   End
   Begin VB.Label Label41 
      Caption         =   "ONMLK"
      Height          =   735
      Left            =   11280
      TabIndex        =   139
      Top             =   3960
      Width           =   735
   End
   Begin VB.Label Label40 
      Caption         =   "NMLK"
      Height          =   735
      Left            =   11280
      TabIndex        =   138
      Top             =   3240
      Width           =   735
   End
   Begin VB.Label Label39 
      Caption         =   "MLK"
      Height          =   735
      Left            =   11280
      TabIndex        =   137
      Top             =   2520
      Width           =   735
   End
   Begin VB.Label Label38 
      Caption         =   "LK"
      Height          =   735
      Left            =   11280
      TabIndex        =   136
      Top             =   1920
      Width           =   735
   End
   Begin VB.Label Label37 
      Caption         =   "K"
      Height          =   735
      Left            =   11280
      TabIndex        =   135
      Top             =   1080
      Width           =   735
   End
   Begin VB.Label Label27 
      Caption         =   "7"
      Height          =   735
      Left            =   120
      TabIndex        =   118
      Top             =   5400
      Width           =   375
   End
   Begin VB.Label Label26 
      Caption         =   "6"
      Height          =   735
      Left            =   120
      TabIndex        =   117
      Top             =   4680
      Width           =   375
   End
   Begin VB.Label Label25 
      Caption         =   "5"
      Height          =   735
      Left            =   120
      TabIndex        =   116
      Top             =   3960
      Width           =   375
   End
   Begin VB.Label Label24 
      Caption         =   "4"
      Height          =   735
      Left            =   120
      TabIndex        =   115
      Top             =   3240
      Width           =   375
   End
   Begin VB.Label Label23 
      Caption         =   "3"
      Height          =   735
      Left            =   120
      TabIndex        =   114
      Top             =   2520
      Width           =   375
   End
   Begin VB.Label Label22 
      Caption         =   "2"
      Height          =   735
      Left            =   120
      TabIndex        =   113
      Top             =   1800
      Width           =   375
   End
   Begin VB.Label Label21 
      Caption         =   "1"
      Height          =   735
      Left            =   120
      TabIndex        =   112
      Top             =   1080
      Width           =   375
   End
   Begin VB.Label Label20 
      Caption         =   "0族电子数"
      Height          =   375
      Left            =   12120
      TabIndex        =   111
      Top             =   720
      Width           =   1575
   End
   Begin VB.Label Label19 
      Caption         =   "电子层"
      Height          =   375
      Left            =   11280
      TabIndex        =   110
      Top             =   720
      Width           =   735
   End
   Begin VB.Label Label18 
      Caption         =   "0 18"
      Height          =   375
      Left            =   10680
      TabIndex        =   109
      Top             =   720
      Width           =   615
   End
   Begin VB.Label Label17 
      Caption         =   "ⅦA 17"
      Height          =   375
      Left            =   10080
      TabIndex        =   108
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label16 
      Caption         =   "ⅥA 16"
      Height          =   375
      Left            =   9480
      TabIndex        =   107
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label15 
      Caption         =   "ⅤA 15"
      Height          =   375
      Left            =   8880
      TabIndex        =   106
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label14 
      Caption         =   "ⅣA 14"
      Height          =   375
      Left            =   8280
      TabIndex        =   105
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label13 
      Caption         =   "ⅢA 13"
      Height          =   375
      Left            =   7680
      TabIndex        =   104
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label12 
      Caption         =   "ⅡB 12"
      Height          =   375
      Left            =   7080
      TabIndex        =   103
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label11 
      Caption         =   "ⅠB 11"
      Height          =   375
      Left            =   6480
      TabIndex        =   102
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label10 
      Caption         =   "   10"
      Height          =   375
      Left            =   5880
      TabIndex        =   101
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label9 
      Caption         =   "Ⅷ  9"
      Height          =   375
      Left            =   5280
      TabIndex        =   100
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label8 
      Caption         =   "   8"
      Height          =   375
      Left            =   4680
      TabIndex        =   99
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label7 
      Caption         =   "ⅦB 7"
      Height          =   375
      Left            =   4080
      TabIndex        =   98
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label6 
      Caption         =   "ⅥB 6"
      Height          =   375
      Left            =   3480
      TabIndex        =   97
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label5 
      Caption         =   "ⅤB 5"
      Height          =   375
      Left            =   2880
      TabIndex        =   96
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label4 
      Caption         =   "ⅣB 4"
      Height          =   375
      Left            =   2280
      TabIndex        =   95
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label3 
      Caption         =   "ⅢB 3"
      Height          =   375
      Left            =   1680
      TabIndex        =   94
      Top             =   2880
      Width           =   615
   End
   Begin VB.Label Label2 
      Caption         =   "ⅡA 2"
      Height          =   375
      Left            =   1080
      TabIndex        =   93
      Top             =   1440
      Width           =   615
   End
   Begin VB.Label Label1 
      Caption         =   "ⅠA 1"
      Height          =   375
      Left            =   480
      TabIndex        =   92
      Top             =   720
      Width           =   615
   End
End
Attribute VB_Name = "PeriodicTable"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub Command39_Click()

End Sub

Private Sub Drive1_Change()

End Sub

Private Sub Text1_Change()

End Sub

Private Sub AboutTool_Click()
aboutform.Show
End Sub

Private Sub aclr_Click()
actinicleselement.Show
End Sub

Private Sub ag47_Click()
PeriodicTable.ysfh.Text = "Ag"
PeriodicTable.hypy.Text = "yín"
PeriodicTable.ywm.Text = "Silver"
PeriodicTable.yyyb.Text = "['silv?]"
PeriodicTable.wcdz.Text = "4d10 5s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "贵金属，曾经是全球范围内的硬通货"
PeriodicTable.xdyzzl.Text = "107.87"
End Sub

Private Sub al13_Click()
PeriodicTable.ysfh.Text = "Al"
PeriodicTable.hypy.Text = "lǚ"
PeriodicTable.ywm.Text = "Aluminum"
PeriodicTable.yyyb.Text = "[,&aelig;lju'minj?m]"
PeriodicTable.wcdz.Text = "3s2 3p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "主/金/气"
PeriodicTable.qt.Text = "地壳里含量最多的金属"
PeriodicTable.xdyzzl.Text = "26.98"
End Sub

Private Sub ar18_Click()
PeriodicTable.ysfh.Text = "Ar"
PeriodicTable.hypy.Text = "yà"
PeriodicTable.ywm.Text = "Argon"
PeriodicTable.yyyb.Text = "['ɑ:ɡ?n]"
PeriodicTable.wcdz.Text = "2s2 2p1"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "主/非/稀"
PeriodicTable.qt.Text = "稀有气体，在空气中含量最多的稀有气体"
PeriodicTable.xdyzzl.Text = "39.95"
End Sub

Private Sub as33_Click()
PeriodicTable.ysfh.Text = "As"
PeriodicTable.hypy.Text = "shēn"
PeriodicTable.ywm.Text = "Arsenic"
PeriodicTable.yyyb.Text = "['ɑ:s?nik]"
PeriodicTable.wcdz.Text = "4s2 4p3"
PeriodicTable.cjhhj.Text = "-3、3、5"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "有毒"
PeriodicTable.xdyzzl.Text = "74.92"
End Sub

Private Sub at85_Click()
PeriodicTable.ysfh.Text = "At"
PeriodicTable.hypy.Text = "ài"
PeriodicTable.ywm.Text = "Astatine"
PeriodicTable.yyyb.Text = "['&aelig;st?ti:n]"
PeriodicTable.wcdz.Text = "6s2 6p5"
PeriodicTable.cjhhj.Text = "1、3"
PeriodicTable.fl.Text = "主/非/卤"
PeriodicTable.qt.Text = "活泼"
PeriodicTable.xdyzzl.Text = "(210)"
End Sub

Private Sub au79_Click()
PeriodicTable.ysfh.Text = "Au"
PeriodicTable.hypy.Text = "jīn"
PeriodicTable.ywm.Text = "Gold"
PeriodicTable.yyyb.Text = "[ɡ?uld]"
PeriodicTable.wcdz.Text = "5d10 6s1"
PeriodicTable.cjhhj.Text = "1、3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "原子结构最稳定，人类最早发现及应用的贵金属，全球硬通货"
PeriodicTable.xdyzzl.Text = "196.97"
End Sub

Private Sub b5_Click()
PeriodicTable.ysfh.Text = "B"
PeriodicTable.hypy.Text = "péng"
PeriodicTable.ywm.Text = "Boron"
PeriodicTable.yyyb.Text = "['b?:r?n]"
PeriodicTable.wcdz.Text = "2s2 2p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "硬度仅次于金刚石的非金属元素"
PeriodicTable.xdyzzl.Text = "10.81"
End Sub

Private Sub ba56_Click()
PeriodicTable.ysfh.Text = "Ba"
PeriodicTable.hypy.Text = "bèi"
PeriodicTable.ywm.Text = "Barium"
PeriodicTable.yyyb.Text = "['bε?ri?m]"
PeriodicTable.wcdz.Text = "6s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/碱土"
PeriodicTable.qt.Text = "硫酸钡被应用于钡餐透视"
PeriodicTable.xdyzzl.Text = "137.33"
End Sub

Private Sub be4_Click()
PeriodicTable.ysfh.Text = "Be"
PeriodicTable.hypy.Text = "pí"
PeriodicTable.ywm.Text = "Beryllium"
PeriodicTable.yyyb.Text = "[be'rili?m]"
PeriodicTable.wcdz.Text = "2s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/金/碱土"
PeriodicTable.qt.Text = "最轻碱土金属元素"
PeriodicTable.xdyzzl.Text = "9.012"
End Sub

Private Sub bh107_Click()
PeriodicTable.ysfh.Text = "Bh"
PeriodicTable.hypy.Text = "bō"
PeriodicTable.ywm.Text = "Bohrium"
PeriodicTable.yyyb.Text = "['b?u?ri?m]"
PeriodicTable.wcdz.Text = "6d5 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "270"
End Sub

Private Sub bi83_Click()
PeriodicTable.ysfh.Text = "Bi"
PeriodicTable.hypy.Text = "bì"
PeriodicTable.ywm.Text = "Bismuth"
PeriodicTable.yyyb.Text = "['bizm?θ]"
PeriodicTable.wcdz.Text = "6s2 6p3"
PeriodicTable.cjhhj.Text = "3、5"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "208.98"
End Sub

Private Sub br35_Click()
PeriodicTable.ysfh.Text = "Br"
PeriodicTable.hypy.Text = "xiù"
PeriodicTable.ywm.Text = "Bromine"
PeriodicTable.yyyb.Text = "['br?umi:n]"
PeriodicTable.wcdz.Text = "4s2 4p5"
PeriodicTable.cjhhj.Text = "-1、7"
PeriodicTable.fl.Text = "主/非/卤"
PeriodicTable.qt.Text = "活泼，单质为红棕色液体"
PeriodicTable.xdyzzl.Text = "79.90"
End Sub

Private Sub c6_Click()
PeriodicTable.ysfh.Text = "C"
PeriodicTable.hypy.Text = "tàn"
PeriodicTable.ywm.Text = "Carbon"
PeriodicTable.yyyb.Text = "['kɑ:b?n]"
PeriodicTable.wcdz.Text = "2s2 2p2"
PeriodicTable.cjhhj.Text = "2、4、-4"
PeriodicTable.fl.Text = "主/非/气"
PeriodicTable.qt.Text = "硬度最高"
PeriodicTable.xdyzzl.Text = "12.01"
End Sub

Private Sub ca20_Click()
PeriodicTable.ysfh.Text = "Ca"
PeriodicTable.hypy.Text = "gài"
PeriodicTable.ywm.Text = "Calcium"
PeriodicTable.yyyb.Text = "['k&aelig;lsi?m]"
PeriodicTable.wcdz.Text = "4s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/金/碱土"
PeriodicTable.qt.Text = "骨骼主要组成成分"
PeriodicTable.xdyzzl.Text = "40.08"
End Sub

Private Sub cd48_Click()
PeriodicTable.ysfh.Text = "Cd"
PeriodicTable.hypy.Text = "gé"
PeriodicTable.ywm.Text = "Cadmium"
PeriodicTable.yyyb.Text = "['k&aelig;dmi?m]"
PeriodicTable.wcdz.Text = "4d10 5s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "重金属，过量摄入会导致痛痛病"
PeriodicTable.xdyzzl.Text = "112.41"
End Sub

Private Sub cl17_Click()
PeriodicTable.ysfh.Text = "Cl"
PeriodicTable.hypy.Text = "lǜ"
PeriodicTable.ywm.Text = "Chlorine"
PeriodicTable.yyyb.Text = "['kl?:ri:n]"
PeriodicTable.wcdz.Text = "3s2 3p5"
PeriodicTable.cjhhj.Text = "-1、1、3、5、7"
PeriodicTable.fl.Text = "主/非/卤"
PeriodicTable.qt.Text = "有毒 活泼"
PeriodicTable.xdyzzl.Text = "35.45"
End Sub

Private Sub cn112_Click()
PeriodicTable.ysfh.Text = "Cn"
PeriodicTable.hypy.Text = "gē"
PeriodicTable.ywm.Text = "Copernicium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = "超重元素"
PeriodicTable.xdyzzl.Text = "(285)"
End Sub

Private Sub co27_Click()
PeriodicTable.ysfh.Text = "Co"
PeriodicTable.hypy.Text = "gǔ"
PeriodicTable.ywm.Text = "Cobalt"
PeriodicTable.yyyb.Text = "[k?u'b?:lt]"
PeriodicTable.wcdz.Text = "3d7 4s2"
PeriodicTable.cjhhj.Text = "2、3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "同位素钴60被应用于X光发生器中"
PeriodicTable.xdyzzl.Text = "58.93"
End Sub

Private Sub cr24_Click()
PeriodicTable.ysfh.Text = "Cr"
PeriodicTable.hypy.Text = "gè"
PeriodicTable.ywm.Text = "Chromium"
PeriodicTable.yyyb.Text = "['kr?umj?m]"
PeriodicTable.wcdz.Text = "3d5 4s1"
PeriodicTable.cjhhj.Text = "3、6"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "硬度最高的金属"
PeriodicTable.xdyzzl.Text = "52.00"
End Sub

Private Sub cs55_Click()
PeriodicTable.ysfh.Text = "Cs"
PeriodicTable.hypy.Text = "sè"
PeriodicTable.ywm.Text = "Cesium"
PeriodicTable.yyyb.Text = "['si:zi?m]"
PeriodicTable.wcdz.Text = "6s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "主/金/碱"
PeriodicTable.qt.Text = "活泼"
PeriodicTable.xdyzzl.Text = "132.91"
End Sub

Private Sub cu29_Click()
PeriodicTable.ysfh.Text = "Cu"
PeriodicTable.hypy.Text = "tóng"
PeriodicTable.ywm.Text = "Copper"
PeriodicTable.yyyb.Text = "['k?p?]"
PeriodicTable.wcdz.Text = "3d10 4s1"
PeriodicTable.cjhhj.Text = "1、2"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人类发现最早金属之一"
PeriodicTable.xdyzzl.Text = "63.55"
End Sub

Private Sub db105_Click()
PeriodicTable.ysfh.Text = "Db"
PeriodicTable.hypy.Text = "dù"
PeriodicTable.ywm.Text = "Dubnium"
PeriodicTable.yyyb.Text = "['du:bni?m]"
PeriodicTable.wcdz.Text = "6d3 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(268)"
End Sub

Private Sub ds110_Click()
PeriodicTable.ysfh.Text = "Ds"
PeriodicTable.hypy.Text = "dá"
PeriodicTable.ywm.Text = "Darmstadtium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = "6d8 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(281)"
End Sub

Private Sub ElectronicShellTool_Click()
ElectronicShell.Show
End Sub

Private Sub f9_Click()
PeriodicTable.ysfh.Text = "F"
PeriodicTable.hypy.Text = "fú"
PeriodicTable.ywm.Text = "Fluorine"
PeriodicTable.yyyb.Text = "['flu?ri:n]"
PeriodicTable.wcdz.Text = "2s2 2p5"
PeriodicTable.cjhhj.Text = "-1"
PeriodicTable.fl.Text = "主/非/卤"
PeriodicTable.qt.Text = "最活泼，非金属，不能被氧化"
PeriodicTable.xdyzzl.Text = "19.00"
End Sub

Private Sub fe26_Click()
PeriodicTable.ysfh.Text = "Fe"
PeriodicTable.hypy.Text = "tiě"
PeriodicTable.ywm.Text = "Iron"
PeriodicTable.yyyb.Text = "['a??n]"
PeriodicTable.wcdz.Text = "1s1"
PeriodicTable.cjhhj.Text = "2、3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "地壳含量第二高的金属，开采最多金属"
PeriodicTable.xdyzzl.Text = "55.84"
End Sub

Private Sub fl114_Click()
PeriodicTable.ysfh.Text = "Fl"
PeriodicTable.hypy.Text = "fū"
PeriodicTable.ywm.Text = "Flerovium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(289)"
End Sub

Private Sub fr87_Click()
PeriodicTable.ysfh.Text = "Fr"
PeriodicTable.hypy.Text = "fāng"
PeriodicTable.ywm.Text = "Francium"
PeriodicTable.yyyb.Text = "['fr?ns??m]"
PeriodicTable.wcdz.Text = "7s1"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "碱金属"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(223)"
End Sub

Private Sub ga31_Click()
PeriodicTable.ysfh.Text = "Ga"
PeriodicTable.hypy.Text = "jiā"
PeriodicTable.ywm.Text = "Gallium"
PeriodicTable.yyyb.Text = "['ɡ&aelig;li?m]"
PeriodicTable.wcdz.Text = "4s2 4p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "燃点低沸点高　"
PeriodicTable.xdyzzl.Text = "69.72"
End Sub

Private Sub ge32_Click()
PeriodicTable.ysfh.Text = "Ge"
PeriodicTable.hypy.Text = "zhě"
PeriodicTable.ywm.Text = "4s2 4p2"
PeriodicTable.yyyb.Text = "[d??:'meini?m]"
PeriodicTable.wcdz.Text = "1s1"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "是一种重要的半导体材料"
PeriodicTable.xdyzzl.Text = "72.61"
End Sub

Private Sub h1_Click()
PeriodicTable.ysfh.Text = "H"
PeriodicTable.hypy.Text = "qīng"
PeriodicTable.ywm.Text = "Hydrogen"
PeriodicTable.yyyb.Text = "['haidr?d??n]"
PeriodicTable.wcdz.Text = "1s1"
PeriodicTable.cjhhj.Text = "1、-1"
PeriodicTable.fl.Text = "主/非/气"
PeriodicTable.qt.Text = "轻，同位素为氕、氘和氚"
PeriodicTable.xdyzzl.Text = "1.0079"
End Sub

Private Sub Label360_Click()

End Sub

Private Sub he2_Click()
PeriodicTable.ysfh.Text = "He"
PeriodicTable.hypy.Text = "hài"
PeriodicTable.ywm.Text = "Helium"
PeriodicTable.yyyb.Text = "['hi:li?m]"
PeriodicTable.wcdz.Text = "1s2"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "主/非/稀"
PeriodicTable.qt.Text = "最难液化"
PeriodicTable.xdyzzl.Text = "4.003"
End Sub

Private Sub hf72_Click()
PeriodicTable.ysfh.Text = "Hf"
PeriodicTable.hypy.Text = "hā"
PeriodicTable.ywm.Text = "Hafnium"
PeriodicTable.yyyb.Text = "['h&aelig;fni?m]"
PeriodicTable.wcdz.Text = "5d2 6s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "178.49"
End Sub

Private Sub hg80_Click()
PeriodicTable.ysfh.Text = "Hg"
PeriodicTable.hypy.Text = "gǒng"
PeriodicTable.ywm.Text = "Mercury"
PeriodicTable.yyyb.Text = "['m?:kjuri]"
PeriodicTable.wcdz.Text = "5d10 6s2"
PeriodicTable.cjhhj.Text = "1、2"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "　唯一一种在常温下为液态的金属"
PeriodicTable.xdyzzl.Text = "200.59"
End Sub

Private Sub hs108_Click()
PeriodicTable.ysfh.Text = "Hs"
PeriodicTable.hypy.Text = "hēi"
PeriodicTable.ywm.Text = "Hassium"
PeriodicTable.yyyb.Text = "['h&aelig;si?m]"
PeriodicTable.wcdz.Text = "6d6 7s2"
PeriodicTable.cjhhj.Text = "-1、7"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(271)"
End Sub

Private Sub i53_Click()
PeriodicTable.ysfh.Text = "I"
PeriodicTable.hypy.Text = "diǎn"
PeriodicTable.ywm.Text = "Indium"
PeriodicTable.yyyb.Text = "['indi?m]"
PeriodicTable.wcdz.Text = "5s2 5p5"
PeriodicTable.cjhhj.Text = "-1、7"
PeriodicTable.fl.Text = "主/非/卤"
PeriodicTable.qt.Text = "活泼，甲状腺所需的微量元素"
PeriodicTable.xdyzzl.Text = "126.90"
End Sub

Private Sub in49_Click()
PeriodicTable.ysfh.Text = "In"
PeriodicTable.hypy.Text = "yīn"
PeriodicTable.ywm.Text = "Indium"
PeriodicTable.yyyb.Text = "['indi?m]"
PeriodicTable.wcdz.Text = "5s2 5p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "可塑性强，有延展性，In115是主要核素，但有放射性"
PeriodicTable.xdyzzl.Text = "114.82"
End Sub

Private Sub IonTool_Click()
Ion.Show
End Sub

Private Sub ir77_Click()
PeriodicTable.ysfh.Text = "Ir"
PeriodicTable.hypy.Text = "yī"
PeriodicTable.ywm.Text = "Iridium"
PeriodicTable.yyyb.Text = "[ai'ridi?m]"
PeriodicTable.wcdz.Text = "5d7 6s2"
PeriodicTable.cjhhj.Text = "3,4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = " "
PeriodicTable.xdyzzl.Text = "192.22"
End Sub

Private Sub k19_Click()
PeriodicTable.ysfh.Text = "K"
PeriodicTable.hypy.Text = "jiǎ"
PeriodicTable.ywm.Text = "Potassium"
PeriodicTable.yyyb.Text = "[p?'t&aelig;sj?m]"
PeriodicTable.wcdz.Text = "4s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "主/金/碱"
PeriodicTable.qt.Text = "活泼，与空气或水接触发生反应，只能储存在煤油、稀有气体中"
PeriodicTable.xdyzzl.Text = "39.10"
End Sub

Private Sub kr36_Click()
PeriodicTable.ysfh.Text = "Kr"
PeriodicTable.hypy.Text = "kè"
PeriodicTable.ywm.Text = "Krypton"
PeriodicTable.yyyb.Text = "['kript?n]"
PeriodicTable.wcdz.Text = "4s2 4p6"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "是一种无色无味无臭的惰性气体"
PeriodicTable.qt.Text = "性质活泼"
PeriodicTable.xdyzzl.Text = "83.80"
End Sub

Private Sub Label50_Click()

End Sub

Private Sub lalu_Click()
lanthanideelement.Show
End Sub

Private Sub li3_Click()
PeriodicTable.ysfh.Text = "Li"
PeriodicTable.hypy.Text = "lǐ"
PeriodicTable.ywm.Text = "Lithium"
PeriodicTable.yyyb.Text = "['liθi?m]"
PeriodicTable.wcdz.Text = "2s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "主/金/碱"
PeriodicTable.qt.Text = "性质活泼"
PeriodicTable.xdyzzl.Text = "6.941"
End Sub

Private Sub lv116_Click()
PeriodicTable.ysfh.Text = "Lv"
PeriodicTable.hypy.Text = "lì"
PeriodicTable.ywm.Text = "Livermorium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(293)"
End Sub

Private Sub mc115_Click()
PeriodicTable.ysfh.Text = "Mc"
PeriodicTable.hypy.Text = "mò"
PeriodicTable.ywm.Text = "Moscovium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(288)"
End Sub

Private Sub mg12_Click()
PeriodicTable.ysfh.Text = "Mg"
PeriodicTable.hypy.Text = "měi"
PeriodicTable.ywm.Text = "Magnesium"
PeriodicTable.yyyb.Text = "m&aelig;ɡ'ni:zi?m]"
PeriodicTable.wcdz.Text = "3s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/金/碱土"
PeriodicTable.qt.Text = "轻金属之一"
PeriodicTable.xdyzzl.Text = "24.31"
End Sub

Private Sub mn25_Click()
PeriodicTable.ysfh.Text = "Mn"
PeriodicTable.hypy.Text = "měng"
PeriodicTable.ywm.Text = "Manganese"
PeriodicTable.yyyb.Text = "['m&aelig;?ɡ?,ni:s]"
PeriodicTable.wcdz.Text = "3d5 4s2"
PeriodicTable.cjhhj.Text = "2、4、6、7"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "在地壳中分布广泛"
PeriodicTable.xdyzzl.Text = "54.96"
End Sub

Private Sub mo42_Click()
PeriodicTable.ysfh.Text = "Mo"
PeriodicTable.hypy.Text = "mù"
PeriodicTable.ywm.Text = "Molybdenum"
PeriodicTable.yyyb.Text = "[m?'libdin?m]"
PeriodicTable.wcdz.Text = "4d5 5s1"
PeriodicTable.cjhhj.Text = "6"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "植物生长所需的微量元素　"
PeriodicTable.xdyzzl.Text = "95.94"
End Sub

Private Sub mt109_Click()
PeriodicTable.ysfh.Text = "Mt"
PeriodicTable.hypy.Text = "mài"
PeriodicTable.ywm.Text = "Mietnerium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = "6d7 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(276)"
End Sub

Private Sub n7_Click()
PeriodicTable.ysfh.Text = "N"
PeriodicTable.hypy.Text = "dàn"
PeriodicTable.ywm.Text = "Nitrogen"
PeriodicTable.yyyb.Text = "['naitr?d??n]"
PeriodicTable.wcdz.Text = "2s2 2p3"
PeriodicTable.cjhhj.Text = "-3、 1 、2、 3、 4、5"
PeriodicTable.fl.Text = "主/非/气"
PeriodicTable.qt.Text = "空气中含量最多的元素"
PeriodicTable.xdyzzl.Text = "14.01"
End Sub

Private Sub na11_Click()
PeriodicTable.ysfh.Text = "Na"
PeriodicTable.hypy.Text = "nà"
PeriodicTable.ywm.Text = "Sodium"
PeriodicTable.yyyb.Text = "['s?udi?m]"
PeriodicTable.wcdz.Text = "3s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "主/金/碱"
PeriodicTable.qt.Text = "活泼"
PeriodicTable.xdyzzl.Text = "22.99"
End Sub

Private Sub nb41_Click()
PeriodicTable.ysfh.Text = "Nb"
PeriodicTable.hypy.Text = "ní"
PeriodicTable.ywm.Text = "Niobium"
PeriodicTable.yyyb.Text = "[nai'?ubi?m]"
PeriodicTable.wcdz.Text = "4d4 5s1"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "铌钢被用于制作汽车外壳　"
PeriodicTable.xdyzzl.Text = "92.91"
End Sub

Private Sub ne10_Click()
PeriodicTable.ysfh.Text = "Ne"
PeriodicTable.hypy.Text = "nǎi"
PeriodicTable.ywm.Text = "Neon"
PeriodicTable.yyyb.Text = "['ni:?n]"
PeriodicTable.wcdz.Text = "2s2 2p6"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "主/非/稀"
PeriodicTable.qt.Text = "稀有气体"
PeriodicTable.xdyzzl.Text = "20.18"
End Sub

Private Sub nh113_Click()
PeriodicTable.ysfh.Text = "Nh"
PeriodicTable.hypy.Text = "nǐ"
PeriodicTable.ywm.Text = "Nihonium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(284)"
End Sub

Private Sub ni28_Click()
PeriodicTable.ysfh.Text = "59"
PeriodicTable.hypy.Text = "niè"
PeriodicTable.ywm.Text = "Nickel"
PeriodicTable.yyyb.Text = "['nik?l]"
PeriodicTable.wcdz.Text = "3d8 4s2"
PeriodicTable.cjhhj.Text = "2、3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "有磁性和良好可塑性"
PeriodicTable.xdyzzl.Text = "58.69"
End Sub

Private Sub o8_Click()
PeriodicTable.ysfh.Text = "O"
PeriodicTable.hypy.Text = "yǎng"
PeriodicTable.ywm.Text = "Oxygen"
PeriodicTable.yyyb.Text = "['?ksid??n]"
PeriodicTable.wcdz.Text = "2s2 2p4"
PeriodicTable.cjhhj.Text = "-2、-1、2"
PeriodicTable.fl.Text = "主/非/气"
PeriodicTable.qt.Text = "地壳中最多"
PeriodicTable.xdyzzl.Text = "16.00"
End Sub

Private Sub og118_Click()
PeriodicTable.ysfh.Text = "Og"
PeriodicTable.hypy.Text = "ào"
PeriodicTable.ywm.Text = "Oganesson"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(294)"
End Sub

Private Sub os76_Click()
PeriodicTable.ysfh.Text = "Os"
PeriodicTable.hypy.Text = "é"
PeriodicTable.ywm.Text = "Osmium"
PeriodicTable.yyyb.Text = "['?zmi?m]"
PeriodicTable.wcdz.Text = "5d6 6s2"
PeriodicTable.cjhhj.Text = "4,6,8"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "密度最大的金属"
PeriodicTable.xdyzzl.Text = "190.23"
End Sub

Private Sub p15_Click()
PeriodicTable.ysfh.Text = "P"
PeriodicTable.hypy.Text = "lín"
PeriodicTable.ywm.Text = "Phosphorus"
PeriodicTable.yyyb.Text = "['f?sf?r?s]"
PeriodicTable.wcdz.Text = "3s2 3p3"
PeriodicTable.cjhhj.Text = "-3、3、5"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "白磷有剧毒"
PeriodicTable.xdyzzl.Text = "30.97"
End Sub

Private Sub pb82_Click()
PeriodicTable.ysfh.Text = "Pb"
PeriodicTable.hypy.Text = "qiān"
PeriodicTable.ywm.Text = "Lead"
PeriodicTable.yyyb.Text = "[led]"
PeriodicTable.wcdz.Text = "6s2 6p2"
PeriodicTable.cjhhj.Text = "2,4"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "　密度大，熔点低，对人体有毒性。许多化妆品中必须含有的元素"
PeriodicTable.xdyzzl.Text = "207.2"
End Sub

Private Sub pd46_Click()
PeriodicTable.ysfh.Text = "Pd"
PeriodicTable.hypy.Text = "bǎ"
PeriodicTable.ywm.Text = "Palladium"
PeriodicTable.yyyb.Text = "[p?'leidi?m]"
PeriodicTable.wcdz.Text = "4d10"
PeriodicTable.cjhhj.Text = "2,4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "被应用于酒精检测中"
PeriodicTable.xdyzzl.Text = "106.42"
End Sub

Private Sub po84_Click()
PeriodicTable.ysfh.Text = "Po"
PeriodicTable.hypy.Text = "pō"
PeriodicTable.ywm.Text = "Polonium"
PeriodicTable.yyyb.Text = "[p?'l?uni?m]"
PeriodicTable.wcdz.Text = "6s2 6p4"
PeriodicTable.cjhhj.Text = "-2、6"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(209)"
End Sub

Private Sub pt78_Click()
PeriodicTable.ysfh.Text = "Pt"
PeriodicTable.hypy.Text = "bó"
PeriodicTable.ywm.Text = "Platinum"
PeriodicTable.yyyb.Text = "['pl&aelig;tin?m]"
PeriodicTable.wcdz.Text = "5d9 6s1"
PeriodicTable.cjhhj.Text = "2,4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "被应用于珠宝首饰中的贵金属，俗称铂金　"
PeriodicTable.xdyzzl.Text = "195.08"
End Sub

Private Sub rb37_Click()
PeriodicTable.ysfh.Text = "Rb"
PeriodicTable.hypy.Text = "rú"
PeriodicTable.ywm.Text = "Rubidium"
PeriodicTable.yyyb.Text = "[ru:'bidi?m]"
PeriodicTable.wcdz.Text = "5s1"
PeriodicTable.cjhhj.Text = "1"
PeriodicTable.fl.Text = "主/金/碱"
PeriodicTable.qt.Text = "活泼"
PeriodicTable.xdyzzl.Text = "85.47"
End Sub

Private Sub re75_Click()
PeriodicTable.ysfh.Text = "Re"
PeriodicTable.hypy.Text = "lái"
PeriodicTable.ywm.Text = "Rhenium"
PeriodicTable.yyyb.Text = "['ri:ni?m]"
PeriodicTable.wcdz.Text = "5d5 6s2"
PeriodicTable.cjhhj.Text = "7"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "最晚被发现的稳定元素　"
PeriodicTable.xdyzzl.Text = "186.21"
End Sub

Private Sub rf104_Click()
PeriodicTable.ysfh.Text = "Rf"
PeriodicTable.hypy.Text = "lú"
PeriodicTable.ywm.Text = "Rutherfordium"
PeriodicTable.yyyb.Text = "[,r?&eth;?'f?:di?m]"
PeriodicTable.wcdz.Text = "6d2 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(265)"
End Sub

Private Sub rg111_Click()
PeriodicTable.ysfh.Text = "Rg"
PeriodicTable.hypy.Text = "lún"
PeriodicTable.ywm.Text = "Roentgenium"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = "超重元素"
PeriodicTable.xdyzzl.Text = "(280)"
End Sub

Private Sub rh45_Click()
PeriodicTable.ysfh.Text = "Rh"
PeriodicTable.hypy.Text = "lǎo"
PeriodicTable.ywm.Text = "Rhodium"
PeriodicTable.yyyb.Text = "['r?udi?m]"
PeriodicTable.wcdz.Text = "4d8 5s1"
PeriodicTable.cjhhj.Text = "3，4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "现代珠宝制作过程进行表面处理的必须元素　"
PeriodicTable.xdyzzl.Text = "102.91"
End Sub

Private Sub rn86_Click()
PeriodicTable.ysfh.Text = "Rn"
PeriodicTable.hypy.Text = "dōng"
PeriodicTable.ywm.Text = "Radon"
PeriodicTable.yyyb.Text = "['reid?n]"
PeriodicTable.wcdz.Text = "6s2 6p6"
PeriodicTable.cjhhj.Text = "--"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(222)"
End Sub

Private Sub rr88_Click()
PeriodicTable.ysfh.Text = "Ra"
PeriodicTable.hypy.Text = "léi"
PeriodicTable.ywm.Text = "Radium"
PeriodicTable.yyyb.Text = "['reidi?m]"
PeriodicTable.wcdz.Text = "7s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/金/碱土"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(226)"
End Sub

Private Sub ru44_Click()
PeriodicTable.ysfh.Text = "Ru"
PeriodicTable.hypy.Text = "liǎo"
PeriodicTable.ywm.Text = "Ruthenium"
PeriodicTable.yyyb.Text = "[ru:'θi:ni?m]"
PeriodicTable.wcdz.Text = "4d7 5s1"
PeriodicTable.cjhhj.Text = "3、8"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "多价稀有金属元素"
PeriodicTable.xdyzzl.Text = "101.07"
End Sub

Private Sub s16_Click()
PeriodicTable.ysfh.Text = "S"
PeriodicTable.hypy.Text = "liú"
PeriodicTable.ywm.Text = "Sulfur"
PeriodicTable.yyyb.Text = "['s?lf?]"
PeriodicTable.wcdz.Text = "3s2 3p4"
PeriodicTable.cjhhj.Text = "-2、4、6"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "质地柔软，轻。与氧气燃烧形成有毒的二氧化硫"
PeriodicTable.xdyzzl.Text = "32.07"
End Sub

Private Sub sb51_Click()
PeriodicTable.ysfh.Text = "Sb"
PeriodicTable.hypy.Text = "tī"
PeriodicTable.ywm.Text = "Antimony"
PeriodicTable.yyyb.Text = "['&aelig;ntim?ni]"
PeriodicTable.wcdz.Text = "5s2 5p3"
PeriodicTable.cjhhj.Text = "-3、3、5"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "熔点低，被用于制作保险丝　"
PeriodicTable.xdyzzl.Text = "121.76"
End Sub

Private Sub sc21_Click()
PeriodicTable.ysfh.Text = "Sc"
PeriodicTable.hypy.Text = "kàng"
PeriodicTable.ywm.Text = "Scandium"
PeriodicTable.yyyb.Text = "['sk&aelig;ndi?m]"
PeriodicTable.wcdz.Text = "3d1 4s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "一种柔软过渡金属，常与钆，铒混合存在"
PeriodicTable.xdyzzl.Text = "44.96"
End Sub

Private Sub se34_Click()
PeriodicTable.ysfh.Text = "Se"
PeriodicTable.hypy.Text = "xī"
PeriodicTable.ywm.Text = "Selenium"
PeriodicTable.yyyb.Text = "[si'li:ni?m]"
PeriodicTable.wcdz.Text = "4s2 4p4"
PeriodicTable.cjhhj.Text = "-2、4、6"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "可使玻璃致色为鲜红色　"
PeriodicTable.xdyzzl.Text = "78.96"
End Sub

Private Sub sg106_Click()
PeriodicTable.ysfh.Text = "Sg"
PeriodicTable.hypy.Text = "xǐ"
PeriodicTable.ywm.Text = "Seaborgium"
PeriodicTable.yyyb.Text = "[si:b?:ɡi?m]"
PeriodicTable.wcdz.Text = "6d4 7s2"
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(271)"
End Sub

Private Sub si14_Click()
PeriodicTable.ysfh.Text = "Si"
PeriodicTable.hypy.Text = "guī"
PeriodicTable.ywm.Text = "Silicon"
PeriodicTable.yyyb.Text = "['silik?n]"
PeriodicTable.wcdz.Text = "3s2 3p2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "地壳中含量仅次于氧"
PeriodicTable.xdyzzl.Text = "28.09"
End Sub

Private Sub sn50_Click()
PeriodicTable.ysfh.Text = "Sn"
PeriodicTable.hypy.Text = "xī"
PeriodicTable.ywm.Text = "Tin"
PeriodicTable.yyyb.Text = "[tin]"
PeriodicTable.wcdz.Text = "5s2 5p2"
PeriodicTable.cjhhj.Text = "2、4"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = "人类最早发现应用的元素之一，被用于制造容器"
PeriodicTable.xdyzzl.Text = "118.71"
End Sub

Private Sub sr38_Click()
PeriodicTable.ysfh.Text = "Sr"
PeriodicTable.hypy.Text = "sī"
PeriodicTable.ywm.Text = "Strontium"
PeriodicTable.yyyb.Text = "['str?nti?m]"
PeriodicTable.wcdz.Text = "5s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "主/金/碱土"
PeriodicTable.qt.Text = "是碱土元素中丰度最小的元素　"
PeriodicTable.xdyzzl.Text = "87.62"
End Sub

Private Sub ta73_Click()
PeriodicTable.ysfh.Text = "Ta"
PeriodicTable.hypy.Text = "tǎn"
PeriodicTable.ywm.Text = "Tantalum"
PeriodicTable.yyyb.Text = "['t&aelig;nt?l?m]"
PeriodicTable.wcdz.Text = "5d3 6s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "180.95"
End Sub

Private Sub tc43_Click()
PeriodicTable.ysfh.Text = "Tc"
PeriodicTable.hypy.Text = "dé"
PeriodicTable.ywm.Text = "Technetium"
PeriodicTable.yyyb.Text = "[tek'ni:?i?m]"
PeriodicTable.wcdz.Text = "4d5 5s2"
PeriodicTable.cjhhj.Text = "7"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "原子序数最小的放射性元素"
PeriodicTable.xdyzzl.Text = "(99)"
End Sub

Private Sub te52_Click()
PeriodicTable.ysfh.Text = "Te"
PeriodicTable.hypy.Text = "dì"
PeriodicTable.ywm.Text = "Tellurium"
PeriodicTable.yyyb.Text = "[te'lju?ri?m]"
PeriodicTable.wcdz.Text = "5s2 5p4"
PeriodicTable.cjhhj.Text = "-2、2、4、6"
PeriodicTable.fl.Text = "主/非"
PeriodicTable.qt.Text = "密度最大的非金属"
PeriodicTable.xdyzzl.Text = "127.60"
End Sub

Private Sub ti22_Click()
PeriodicTable.ysfh.Text = "Ti"
PeriodicTable.hypy.Text = "tài"
PeriodicTable.ywm.Text = "Titanium"
PeriodicTable.yyyb.Text = "[tai'teini?m]"
PeriodicTable.wcdz.Text = "3d2 4s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "能在氮气中燃烧，熔点高"
PeriodicTable.xdyzzl.Text = "47.87"
End Sub

Private Sub tl81_Click()
PeriodicTable.ysfh.Text = "Tl"
PeriodicTable.hypy.Text = "tā"
PeriodicTable.ywm.Text = "Thallium"
PeriodicTable.yyyb.Text = "['θ&aelig;li?m]"
PeriodicTable.wcdz.Text = "6s2 6p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "主/金"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "204.38"
End Sub

Private Sub ts117_Click()
PeriodicTable.ysfh.Text = "Ts"
PeriodicTable.hypy.Text = "tián"
PeriodicTable.ywm.Text = "Tennessine"
PeriodicTable.yyyb.Text = ""
PeriodicTable.wcdz.Text = ""
PeriodicTable.cjhhj.Text = ""
PeriodicTable.fl.Text = ""
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "(294)"
End Sub

Private Sub v23_Click()
PeriodicTable.ysfh.Text = "V"
PeriodicTable.hypy.Text = "fán"
PeriodicTable.ywm.Text = "Vanadium"
PeriodicTable.yyyb.Text = "[v?'neidi?m]"
PeriodicTable.wcdz.Text = "3d3 4s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "高熔点稀有金属"
PeriodicTable.xdyzzl.Text = "50.94"
End Sub

Private Sub w74_Click()
PeriodicTable.ysfh.Text = "W"
PeriodicTable.hypy.Text = "wū"
PeriodicTable.ywm.Text = "Tungsten"
PeriodicTable.yyyb.Text = "['t??st?n]"
PeriodicTable.wcdz.Text = "5d4 6s2"
PeriodicTable.cjhhj.Text = "6"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "熔点最高"
PeriodicTable.xdyzzl.Text = "183.84"
End Sub

Private Sub xe54_Click()
PeriodicTable.ysfh.Text = "Xe"
PeriodicTable.hypy.Text = "xiān"
PeriodicTable.ywm.Text = "Xenon"
PeriodicTable.yyyb.Text = "['zen?n]"
PeriodicTable.wcdz.Text = "5s2 5p6"
PeriodicTable.cjhhj.Text = "4、6、8"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "可被用于制作氙灯　"
PeriodicTable.xdyzzl.Text = "131.29"
End Sub

Private Sub y39_Click()
PeriodicTable.ysfh.Text = "Y"
PeriodicTable.hypy.Text = "yǐ"
PeriodicTable.ywm.Text = "Yttrium"
PeriodicTable.yyyb.Text = "['itri?m]"
PeriodicTable.wcdz.Text = "4d1 5s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人工合成的钇铝榴石曾被当做钻石的替代品　"
PeriodicTable.xdyzzl.Text = "88.91"
End Sub

Private Sub zn30_Click()
PeriodicTable.ysfh.Text = "Zn"
PeriodicTable.hypy.Text = "xīn"
PeriodicTable.ywm.Text = "Zinc"
PeriodicTable.yyyb.Text = "[zi?k]"
PeriodicTable.wcdz.Text = "3d10 4s2"
PeriodicTable.cjhhj.Text = "2"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "人体需要的微量元素"
PeriodicTable.xdyzzl.Text = "69.72"
End Sub

Private Sub zr40_Click()
PeriodicTable.ysfh.Text = "Zr"
PeriodicTable.hypy.Text = "gào"
PeriodicTable.ywm.Text = "Zirconium"
PeriodicTable.yyyb.Text = "[z?:'k?uni?m]"
PeriodicTable.wcdz.Text = "4d2 5s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "副/金/过"
PeriodicTable.qt.Text = "氧化物立方氧化锆为钻石的人工替代品　"
PeriodicTable.xdyzzl.Text = "91.22"
End Sub
