VERSION 5.00
Begin VB.Form lanthanideelement
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "镧系元素"
   ClientHeight    =   1695
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   10020
   Icon            =   "LanthanideElement.frx":0000
   LinkTopic       =   "Form2"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   1695
   ScaleWidth      =   10020
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  '窗口缺省
   Begin VB.Frame Frame1 
      Caption         =   "57-71"
      Height          =   1455
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9735
      Begin VB.CommandButton la57 
         Caption         =   "57镧"
         Height          =   735
         Left            =   360
         TabIndex        =   15
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton ce58 
         Caption         =   "58铈"
         Height          =   735
         Left            =   960
         TabIndex        =   14
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pr58 
         Caption         =   "59镨"
         Height          =   735
         Left            =   1560
         TabIndex        =   13
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton nd60 
         Caption         =   "60钕"
         Height          =   735
         Left            =   2160
         TabIndex        =   12
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pm61 
         Caption         =   "61钷"
         Height          =   735
         Left            =   2760
         TabIndex        =   11
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton sm62 
         Caption         =   "62钐"
         Height          =   735
         Left            =   3360
         TabIndex        =   10
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton eu63 
         Caption         =   "63铕"
         Height          =   735
         Left            =   3960
         TabIndex        =   9
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton gd64 
         Caption         =   "64钆"
         Height          =   735
         Left            =   4560
         TabIndex        =   8
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton tb65 
         Caption         =   "65铽"
         Height          =   735
         Left            =   5160
         TabIndex        =   7
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton dy66 
         Caption         =   "66镝"
         Height          =   735
         Left            =   5760
         TabIndex        =   6
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton ho67 
         Caption         =   "67钬"
         Height          =   735
         Left            =   6360
         TabIndex        =   5
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton er68 
         Caption         =   "68铒"
         Height          =   735
         Left            =   6960
         TabIndex        =   4
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton tm69 
         Caption         =   "69铥"
         Height          =   735
         Left            =   7560
         TabIndex        =   3
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton yb70 
         Caption         =   "70镱"
         Height          =   735
         Left            =   8160
         TabIndex        =   2
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton lu71 
         Caption         =   "71镥"
         Height          =   735
         Left            =   8760
         TabIndex        =   1
         Top             =   360
         Width           =   615
      End
   End
End
Attribute VB_Name = "lanthanideelement"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub ce58_Click()
PeriodicTable.ysfh.Text = "Ce"
PeriodicTable.hypy.Text = "shì"
PeriodicTable.ywm.Text = "Cerium"
PeriodicTable.yyyb.Text = "['si?ri?m]"
PeriodicTable.wcdz.Text = "4f1 5d1 6s2"
PeriodicTable.cjhhj.Text = "3、4"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "140.12"
End Sub

Private Sub dy66_Click()
PeriodicTable.ysfh.Text = "Dy"
PeriodicTable.hypy.Text = "dī"
PeriodicTable.ywm.Text = "Dysprosium"
PeriodicTable.yyyb.Text = "[dis'pr?usi?m]"
PeriodicTable.wcdz.Text = "4f10 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "162.50"
End Sub

Private Sub er68_Click()
PeriodicTable.ysfh.Text = "Er"
PeriodicTable.hypy.Text = "ěr"
PeriodicTable.ywm.Text = "Erbium"
PeriodicTable.yyyb.Text = "['?:bi?m]"
PeriodicTable.wcdz.Text = "4f12 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "167.26"
End Sub

Private Sub eu63_Click()
PeriodicTable.ysfh.Text = "Eu"
PeriodicTable.hypy.Text = "yǒu"
PeriodicTable.ywm.Text = "Europium"
PeriodicTable.yyyb.Text = "[ju?'r?upi?m]"
PeriodicTable.wcdz.Text = "4f7 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "151.96"
End Sub

Private Sub gd64_Click()
PeriodicTable.ysfh.Text = "Gd"
PeriodicTable.hypy.Text = "gá"
PeriodicTable.ywm.Text = "Gadolinium"
PeriodicTable.yyyb.Text = "['ɡ&aelig;d?lini?m]"
PeriodicTable.wcdz.Text = "4f7 5d1 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "157.25"
End Sub

Private Sub ho67_Click()
PeriodicTable.ysfh.Text = "Ho"
PeriodicTable.hypy.Text = "huǒ"
PeriodicTable.ywm.Text = "Holmium"
PeriodicTable.yyyb.Text = "['h?ulmi?m]"
PeriodicTable.wcdz.Text = "4f11 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "164.93"
End Sub

Private Sub la57_Click()
PeriodicTable.ysfh.Text = "La"
PeriodicTable.hypy.Text = "lán"
PeriodicTable.ywm.Text = "Lanthanum"
PeriodicTable.yyyb.Text = "['l&aelig;nθ?n?m]"
PeriodicTable.wcdz.Text = "5d1 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "138.91"
End Sub

Private Sub lu71_Click()
PeriodicTable.ysfh.Text = "Lu"
PeriodicTable.hypy.Text = "lǔ"
PeriodicTable.ywm.Text = "Lutetium"
PeriodicTable.yyyb.Text = "[lju:'ti:?i?m]"
PeriodicTable.wcdz.Text = "4f14 5d1 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "174.97"
End Sub

Private Sub nd60_Click()
PeriodicTable.ysfh.Text = "Nd"
PeriodicTable.hypy.Text = "nǚ"
PeriodicTable.ywm.Text = "Neodymium"
PeriodicTable.yyyb.Text = "[,ni:?u'dimi?m]"
PeriodicTable.wcdz.Text = "4f4 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "144.24"
End Sub

Private Sub pm61_Click()
PeriodicTable.ysfh.Text = "Pm"
PeriodicTable.hypy.Text = "pǒ"
PeriodicTable.ywm.Text = "Promethium"
PeriodicTable.yyyb.Text = "[pr?u'mi:θi?m]"
PeriodicTable.wcdz.Text = "4f5 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = "放射"
PeriodicTable.xdyzzl.Text = "(145)"
End Sub

Private Sub pr58_Click()
PeriodicTable.ysfh.Text = "Pr"
PeriodicTable.hypy.Text = "pǔ"
PeriodicTable.ywm.Text = "Praseodymium"
PeriodicTable.yyyb.Text = "[,preizi?u'dimi?m]"
PeriodicTable.wcdz.Text = "4f3 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "140.91"
End Sub

Private Sub sm62_Click()
PeriodicTable.ysfh.Text = "Sm"
PeriodicTable.hypy.Text = "shān"
PeriodicTable.ywm.Text = "Samarium"
PeriodicTable.yyyb.Text = "[s?'m??ri?m]"
PeriodicTable.wcdz.Text = "4f6 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "150.36"
End Sub

Private Sub tb65_Click()
PeriodicTable.ysfh.Text = "Tb"
PeriodicTable.hypy.Text = "tè"
PeriodicTable.ywm.Text = "Terbium"
PeriodicTable.yyyb.Text = "['t?:bi?m]"
PeriodicTable.wcdz.Text = "4f9 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "158.93"
End Sub

Private Sub tm69_Click()
PeriodicTable.ysfh.Text = "Tm"
PeriodicTable.hypy.Text = "diū"
PeriodicTable.ywm.Text = "Thulium"
PeriodicTable.yyyb.Text = "['θju:li?m]"
PeriodicTable.wcdz.Text = "4f13 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "168.93"
End Sub

Private Sub yb70_Click()
PeriodicTable.ysfh.Text = "Yb"
PeriodicTable.hypy.Text = "yì"
PeriodicTable.ywm.Text = "Ytterbium"
PeriodicTable.yyyb.Text = "[i't?:bi?m]"
PeriodicTable.wcdz.Text = "4f14 6s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "副/金/镧"
PeriodicTable.qt.Text = ""
PeriodicTable.xdyzzl.Text = "173.04"
End Sub
