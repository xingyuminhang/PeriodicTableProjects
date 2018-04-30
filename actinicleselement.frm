VERSION 5.00
Begin VB.Form actinicleselement
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "锕系元素"
   ClientHeight    =   1695
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   9960
   Icon            =   "ActiniclEselement.frx":0000
   LinkTopic       =   "Form3"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1695
   ScaleWidth      =   9960
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  '窗口缺省
   Begin VB.Frame Frame1 
      Caption         =   "89-103"
      Height          =   1455
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9735
      Begin VB.CommandButton lr103 
         Caption         =   "103铹"
         Height          =   735
         Left            =   8760
         TabIndex        =   15
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton no102 
         Caption         =   "102锘"
         Height          =   735
         Left            =   8160
         TabIndex        =   14
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton md101 
         Caption         =   "101钔"
         Height          =   735
         Left            =   7560
         TabIndex        =   13
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton fm100 
         Caption         =   "100镄"
         Height          =   735
         Left            =   6960
         TabIndex        =   12
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton es99 
         Caption         =   "99锿"
         Height          =   735
         Left            =   6360
         TabIndex        =   11
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cf98 
         Caption         =   "98锎"
         Height          =   735
         Left            =   5760
         TabIndex        =   10
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton bk97 
         Caption         =   "97锫"
         Height          =   735
         Left            =   5160
         TabIndex        =   9
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cm96 
         Caption         =   "96锔"
         Height          =   735
         Left            =   4560
         TabIndex        =   8
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton am95 
         Caption         =   "95镅"
         Height          =   735
         Left            =   3960
         TabIndex        =   7
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pu94 
         Caption         =   "94钚"
         Height          =   735
         Left            =   3360
         TabIndex        =   6
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton np93 
         Caption         =   "93镎"
         Height          =   735
         Left            =   2760
         TabIndex        =   5
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton u92 
         Caption         =   "92铀"
         Height          =   735
         Left            =   2160
         TabIndex        =   4
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pa91 
         Caption         =   "91镤"
         Height          =   735
         Left            =   1560
         TabIndex        =   3
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton th90 
         Caption         =   "90钍"
         Height          =   735
         Left            =   960
         TabIndex        =   2
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton ac89 
         Caption         =   "89锕"
         Height          =   735
         Left            =   360
         TabIndex        =   1
         Top             =   360
         Width           =   615
      End
   End
End
Attribute VB_Name = "actinicleselement"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub ac89_Click()
PeriodicTable.ysfh.Text = "Ac"
PeriodicTable.hypy.Text = "ā"
PeriodicTable.ywm.Text = "Actinium"
PeriodicTable.yyyb.Text = "[&aelig;k'tini?m]"
PeriodicTable.wcdz.Text = "6d1 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(227)"
End Sub

Private Sub am95_Click()
PeriodicTable.ysfh.Text = "Am"
PeriodicTable.hypy.Text = "méi"
PeriodicTable.ywm.Text = "Americium"
PeriodicTable.yyyb.Text = "[,&aelig;m?'risi?m]"
PeriodicTable.wcdz.Text = "5f7 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射 用于烟雾报警器中 "
PeriodicTable.xdyzzl.Text = "(243)"
End Sub

Private Sub bk97_Click()
PeriodicTable.ysfh.Text = "Bk"
PeriodicTable.hypy.Text = "péi"
PeriodicTable.ywm.Text = "Berkelium"
PeriodicTable.yyyb.Text = "['b?:kli?m]"
PeriodicTable.wcdz.Text = "5f9 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(247)"
End Sub

Private Sub cf98_Click()
PeriodicTable.ysfh.Text = "Cf"
PeriodicTable.hypy.Text = "kāi"
PeriodicTable.ywm.Text = "Californium"
PeriodicTable.yyyb.Text = "[,k&aelig;li'f?:ni?m]"
PeriodicTable.wcdz.Text = "5f10 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射，最贵金属"
PeriodicTable.xdyzzl.Text = "(251)"
End Sub

Private Sub cm96_Click()
PeriodicTable.ysfh.Text = "Cm"
PeriodicTable.hypy.Text = "jú"
PeriodicTable.ywm.Text = "Curium"
PeriodicTable.yyyb.Text = "['kju?ri?m]"
PeriodicTable.wcdz.Text = "5f7 6d1 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(247)"
End Sub

Private Sub es99_Click()
PeriodicTable.ysfh.Text = "Es"
PeriodicTable.hypy.Text = "āi"
PeriodicTable.ywm.Text = "Einsteinium"
PeriodicTable.yyyb.Text = "[ain'staini?m]"
PeriodicTable.wcdz.Text = "5f11 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(252)"
End Sub

Private Sub fm100_Click()
PeriodicTable.ysfh.Text = "Fm"
PeriodicTable.hypy.Text = "fèi"
PeriodicTable.ywm.Text = "Fermium"
PeriodicTable.yyyb.Text = "['f?:mi?m]"
PeriodicTable.wcdz.Text = "5s12 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(257)"
End Sub

Private Sub lr103_Click()
PeriodicTable.ysfh.Text = "Lr"
PeriodicTable.hypy.Text = "láo"
PeriodicTable.ywm.Text = "Lawrencium"
PeriodicTable.yyyb.Text = "[l?:'rensi?m]"
PeriodicTable.wcdz.Text = "5f14 7s27p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(262)"
End Sub

Private Sub md101_Click()
PeriodicTable.ysfh.Text = "钔"
PeriodicTable.hypy.Text = "mén"
PeriodicTable.ywm.Text = "Mendelevium"
PeriodicTable.yyyb.Text = "[,mend?'li:vi?m]"
PeriodicTable.wcdz.Text = "5f13 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(258)"
End Sub

Private Sub no102_Click()
PeriodicTable.ysfh.Text = "No"
PeriodicTable.hypy.Text = "nuò"
PeriodicTable.ywm.Text = "Nobelium"
PeriodicTable.yyyb.Text = "[n?u'bi:li?m]"
PeriodicTable.wcdz.Text = "5f14 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "人造 放射"
PeriodicTable.xdyzzl.Text = "(259)"
End Sub

Private Sub np93_Click()
PeriodicTable.ysfh.Text = "Np"
PeriodicTable.hypy.Text = "ná"
PeriodicTable.ywm.Text = "Neptunium"
PeriodicTable.yyyb.Text = "[nep'tju:ni?m]"
PeriodicTable.wcdz.Text = "5f4 6d1 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(237)"
End Sub

Private Sub pa91_Click()
PeriodicTable.ysfh.Text = "Pa"
PeriodicTable.hypy.Text = "pú"
PeriodicTable.ywm.Text = "Protactinium"
PeriodicTable.yyyb.Text = "[,pr?ut&aelig;k'tini?m]"
PeriodicTable.wcdz.Text = "5f2 6d1 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "231.04"
End Sub

Private Sub pu94_Click()
PeriodicTable.ysfh.Text = "Pu"
PeriodicTable.hypy.Text = "bù"
PeriodicTable.ywm.Text = "Plutonium"
PeriodicTable.yyyb.Text = "[plu:'t?uni?m]"
PeriodicTable.wcdz.Text = "5f6 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(244)"
End Sub

Private Sub th90_Click()
PeriodicTable.ysfh.Text = "Th"
PeriodicTable.hypy.Text = "tǔ"
PeriodicTable.ywm.Text = "Thorium"
PeriodicTable.yyyb.Text = "['θ?:ri?m]"
PeriodicTable.wcdz.Text = "6d2 7s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "232.04"
End Sub

Private Sub u92_Click()
PeriodicTable.ysfh.Text = "U"
PeriodicTable.hypy.Text = "yóu"
PeriodicTable.ywm.Text = "Uranium"
PeriodicTable.yyyb.Text = "[ju'reini?m]"
PeriodicTable.wcdz.Text = "5f3 6d1 7s2"
PeriodicTable.cjhhj.Text = "4，5"
PeriodicTable.fl.Text = "副/金/锕"
PeriodicTable.qt.Text = "放射，同位素铀235被用于制作原子弹"
PeriodicTable.xdyzzl.Text = "238.03"
End Sub
