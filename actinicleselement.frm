VERSION 5.00
Begin VB.Form actinicleselement
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "�ϵԪ��"
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
   StartUpPosition =   3  '����ȱʡ
   Begin VB.Frame Frame1 
      Caption         =   "89-103"
      Height          =   1455
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   9735
      Begin VB.CommandButton lr103 
         Caption         =   "103�"
         Height          =   735
         Left            =   8760
         TabIndex        =   15
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton no102 
         Caption         =   "102�"
         Height          =   735
         Left            =   8160
         TabIndex        =   14
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton md101 
         Caption         =   "101��"
         Height          =   735
         Left            =   7560
         TabIndex        =   13
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton fm100 
         Caption         =   "100��"
         Height          =   735
         Left            =   6960
         TabIndex        =   12
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton es99 
         Caption         =   "99��"
         Height          =   735
         Left            =   6360
         TabIndex        =   11
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cf98 
         Caption         =   "98�"
         Height          =   735
         Left            =   5760
         TabIndex        =   10
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton bk97 
         Caption         =   "97��"
         Height          =   735
         Left            =   5160
         TabIndex        =   9
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton cm96 
         Caption         =   "96�"
         Height          =   735
         Left            =   4560
         TabIndex        =   8
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton am95 
         Caption         =   "95��"
         Height          =   735
         Left            =   3960
         TabIndex        =   7
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pu94 
         Caption         =   "94��"
         Height          =   735
         Left            =   3360
         TabIndex        =   6
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton np93 
         Caption         =   "93��"
         Height          =   735
         Left            =   2760
         TabIndex        =   5
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton u92 
         Caption         =   "92��"
         Height          =   735
         Left            =   2160
         TabIndex        =   4
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton pa91 
         Caption         =   "91��"
         Height          =   735
         Left            =   1560
         TabIndex        =   3
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton th90 
         Caption         =   "90��"
         Height          =   735
         Left            =   960
         TabIndex        =   2
         Top             =   360
         Width           =   615
      End
      Begin VB.CommandButton ac89 
         Caption         =   "89�"
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
PeriodicTable.hypy.Text = "��"
PeriodicTable.ywm.Text = "Actinium"
PeriodicTable.yyyb.Text = "[&aelig;k'tini?m]"
PeriodicTable.wcdz.Text = "6d1 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "����"
PeriodicTable.xdyzzl.Text = "(227)"
End Sub

Private Sub am95_Click()
PeriodicTable.ysfh.Text = "Am"
PeriodicTable.hypy.Text = "m��i"
PeriodicTable.ywm.Text = "Americium"
PeriodicTable.yyyb.Text = "[,&aelig;m?'risi?m]"
PeriodicTable.wcdz.Text = "5f7 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ���� �������������� "
PeriodicTable.xdyzzl.Text = "(243)"
End Sub

Private Sub bk97_Click()
PeriodicTable.ysfh.Text = "Bk"
PeriodicTable.hypy.Text = "p��i"
PeriodicTable.ywm.Text = "Berkelium"
PeriodicTable.yyyb.Text = "['b?:kli?m]"
PeriodicTable.wcdz.Text = "5f9 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(247)"
End Sub

Private Sub cf98_Click()
PeriodicTable.ysfh.Text = "Cf"
PeriodicTable.hypy.Text = "k��i"
PeriodicTable.ywm.Text = "Californium"
PeriodicTable.yyyb.Text = "[,k&aelig;li'f?:ni?m]"
PeriodicTable.wcdz.Text = "5f10 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ���䣬������"
PeriodicTable.xdyzzl.Text = "(251)"
End Sub

Private Sub cm96_Click()
PeriodicTable.ysfh.Text = "Cm"
PeriodicTable.hypy.Text = "j��"
PeriodicTable.ywm.Text = "Curium"
PeriodicTable.yyyb.Text = "['kju?ri?m]"
PeriodicTable.wcdz.Text = "5f7 6d1 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(247)"
End Sub

Private Sub es99_Click()
PeriodicTable.ysfh.Text = "Es"
PeriodicTable.hypy.Text = "��i"
PeriodicTable.ywm.Text = "Einsteinium"
PeriodicTable.yyyb.Text = "[ain'staini?m]"
PeriodicTable.wcdz.Text = "5f11 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(252)"
End Sub

Private Sub fm100_Click()
PeriodicTable.ysfh.Text = "Fm"
PeriodicTable.hypy.Text = "f��i"
PeriodicTable.ywm.Text = "Fermium"
PeriodicTable.yyyb.Text = "['f?:mi?m]"
PeriodicTable.wcdz.Text = "5s12 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(257)"
End Sub

Private Sub lr103_Click()
PeriodicTable.ysfh.Text = "Lr"
PeriodicTable.hypy.Text = "l��o"
PeriodicTable.ywm.Text = "Lawrencium"
PeriodicTable.yyyb.Text = "[l?:'rensi?m]"
PeriodicTable.wcdz.Text = "5f14 7s27p1"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(262)"
End Sub

Private Sub md101_Click()
PeriodicTable.ysfh.Text = "��"
PeriodicTable.hypy.Text = "m��n"
PeriodicTable.ywm.Text = "Mendelevium"
PeriodicTable.yyyb.Text = "[,mend?'li:vi?m]"
PeriodicTable.wcdz.Text = "5f13 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(258)"
End Sub

Private Sub no102_Click()
PeriodicTable.ysfh.Text = "No"
PeriodicTable.hypy.Text = "nu��"
PeriodicTable.ywm.Text = "Nobelium"
PeriodicTable.yyyb.Text = "[n?u'bi:li?m]"
PeriodicTable.wcdz.Text = "5f14 7s2"
PeriodicTable.cjhhj.Text = "3"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���� ����"
PeriodicTable.xdyzzl.Text = "(259)"
End Sub

Private Sub np93_Click()
PeriodicTable.ysfh.Text = "Np"
PeriodicTable.hypy.Text = "n��"
PeriodicTable.ywm.Text = "Neptunium"
PeriodicTable.yyyb.Text = "[nep'tju:ni?m]"
PeriodicTable.wcdz.Text = "5f4 6d1 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "����"
PeriodicTable.xdyzzl.Text = "(237)"
End Sub

Private Sub pa91_Click()
PeriodicTable.ysfh.Text = "Pa"
PeriodicTable.hypy.Text = "p��"
PeriodicTable.ywm.Text = "Protactinium"
PeriodicTable.yyyb.Text = "[,pr?ut&aelig;k'tini?m]"
PeriodicTable.wcdz.Text = "5f2 6d1 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "����"
PeriodicTable.xdyzzl.Text = "231.04"
End Sub

Private Sub pu94_Click()
PeriodicTable.ysfh.Text = "Pu"
PeriodicTable.hypy.Text = "b��"
PeriodicTable.ywm.Text = "Plutonium"
PeriodicTable.yyyb.Text = "[plu:'t?uni?m]"
PeriodicTable.wcdz.Text = "5f6 7s2"
PeriodicTable.cjhhj.Text = "5"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "����"
PeriodicTable.xdyzzl.Text = "(244)"
End Sub

Private Sub th90_Click()
PeriodicTable.ysfh.Text = "Th"
PeriodicTable.hypy.Text = "t��"
PeriodicTable.ywm.Text = "Thorium"
PeriodicTable.yyyb.Text = "['��?:ri?m]"
PeriodicTable.wcdz.Text = "6d2 7s2"
PeriodicTable.cjhhj.Text = "4"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "����"
PeriodicTable.xdyzzl.Text = "232.04"
End Sub

Private Sub u92_Click()
PeriodicTable.ysfh.Text = "U"
PeriodicTable.hypy.Text = "y��u"
PeriodicTable.ywm.Text = "Uranium"
PeriodicTable.yyyb.Text = "[ju'reini?m]"
PeriodicTable.wcdz.Text = "5f3 6d1 7s2"
PeriodicTable.cjhhj.Text = "4��5"
PeriodicTable.fl.Text = "��/��/�"
PeriodicTable.qt.Text = "���䣬ͬλ����235����������ԭ�ӵ�"
PeriodicTable.xdyzzl.Text = "238.03"
End Sub
