VERSION 5.00
Begin VB.Form Ion 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "酸碱盐的溶解性表(20°C)"
   ClientHeight    =   3420
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   9555
   Icon            =   "Ion.frx":0000
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3420
   ScaleWidth      =   9555
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  '窗口缺省
   Begin VB.CommandButton Command1 
      Caption         =   "生成离子对"
      Height          =   495
      Left            =   5280
      TabIndex        =   23
      Top             =   2760
      Width           =   1215
   End
   Begin VB.TextBox Text1 
      Height          =   1215
      Left            =   6840
      TabIndex        =   22
      Text            =   "选择离子,按动按钮。"
      Top             =   2160
      Width           =   2535
   End
   Begin VB.Frame Frame2 
      Caption         =   "阴离子(氢氧根离子和酸根离子)"
      Height          =   1455
      Left            =   5160
      TabIndex        =   1
      Top             =   600
      Width           =   4215
      Begin VB.OptionButton po4 
         Caption         =   "PO4(3-)"
         Height          =   375
         Left            =   2760
         TabIndex        =   21
         Top             =   840
         Width           =   1095
      End
      Begin VB.OptionButton co3 
         Caption         =   "CO3(2-)"
         Height          =   375
         Left            =   2760
         TabIndex        =   20
         Top             =   360
         Width           =   1095
      End
      Begin VB.OptionButton so4 
         Caption         =   "SO4(2-)"
         Height          =   375
         Left            =   1560
         TabIndex        =   19
         Top             =   840
         Width           =   1095
      End
      Begin VB.OptionButton cl 
         Caption         =   "Cl(-)"
         Height          =   375
         Left            =   1560
         TabIndex        =   18
         Top             =   360
         Width           =   1095
      End
      Begin VB.OptionButton no3 
         Caption         =   "NO(3-)"
         Height          =   375
         Left            =   360
         TabIndex        =   17
         Top             =   840
         Width           =   1095
      End
      Begin VB.OptionButton oh 
         Caption         =   "OH(-)"
         Height          =   375
         Left            =   360
         TabIndex        =   16
         Top             =   360
         Width           =   1095
      End
   End
   Begin VB.Frame Frame1 
      Caption         =   "阳离子(金属离子,氢离子和铵根离子)"
      Height          =   2655
      Left            =   120
      TabIndex        =   0
      Top             =   600
      Width           =   4575
      Begin VB.OptionButton ag 
         Caption         =   "Ag(+)"
         Height          =   375
         Left            =   3480
         TabIndex        =   15
         Top             =   960
         Width           =   975
      End
      Begin VB.OptionButton cu 
         Caption         =   "Cu(2+)"
         Height          =   375
         Left            =   3480
         TabIndex        =   14
         Top             =   360
         Width           =   975
      End
      Begin VB.OptionButton fe3 
         Caption         =   "Fe(3+)"
         Height          =   375
         Left            =   2400
         TabIndex        =   13
         Top             =   2160
         Width           =   975
      End
      Begin VB.OptionButton fe2 
         Caption         =   "Fe(2+)"
         Height          =   375
         Left            =   2400
         TabIndex        =   12
         Top             =   1560
         Width           =   975
      End
      Begin VB.OptionButton zn 
         Caption         =   "Zn(2+)"
         Height          =   375
         Left            =   2400
         TabIndex        =   11
         Top             =   960
         Width           =   975
      End
      Begin VB.OptionButton mn 
         Caption         =   "Mn(2+)"
         Height          =   375
         Left            =   2400
         TabIndex        =   10
         Top             =   360
         Width           =   975
      End
      Begin VB.OptionButton al 
         Caption         =   "Al(3+)"
         Height          =   375
         Left            =   1320
         TabIndex        =   9
         Top             =   2160
         Width           =   975
      End
      Begin VB.OptionButton mg 
         Caption         =   "Mg(2+)"
         Height          =   375
         Left            =   1320
         TabIndex        =   8
         Top             =   1560
         Width           =   975
      End
      Begin VB.OptionButton ca 
         Caption         =   "Ca(2+)"
         Height          =   375
         Left            =   1320
         TabIndex        =   7
         Top             =   960
         Width           =   975
      End
      Begin VB.OptionButton ba 
         Caption         =   "Ba(2+)"
         Height          =   375
         Left            =   1320
         TabIndex        =   6
         Top             =   360
         Width           =   975
      End
      Begin VB.OptionButton na 
         Caption         =   "Na(+)"
         Height          =   375
         Left            =   240
         TabIndex        =   5
         Top             =   2160
         Width           =   975
      End
      Begin VB.OptionButton k 
         Caption         =   "K(+)"
         Height          =   375
         Left            =   240
         TabIndex        =   4
         Top             =   1560
         Width           =   975
      End
      Begin VB.OptionButton nh4 
         Caption         =   "NH4(+)"
         Height          =   375
         Left            =   240
         TabIndex        =   3
         Top             =   960
         Width           =   975
      End
      Begin VB.OptionButton h 
         Caption         =   "H(+)"
         Height          =   375
         Left            =   240
         TabIndex        =   2
         Top             =   360
         Width           =   975
      End
   End
   Begin VB.Label Label1 
      Caption         =   "此工具的诞生离不开张老师和Forever  95120___________________________________@spam4.me,我们对此表示感谢!"
      Height          =   375
      Left            =   120
      TabIndex        =   24
      Top             =   120
      Width           =   9255
   End
End
Attribute VB_Name = "Ion"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Option8_Click()

End Sub

Private Sub ag_Click()
X = 140
End Sub

Private Sub al_Click()
X = 80
End Sub

Private Sub ba_Click()
X = 50
End Sub

Private Sub ca_Click()
X = 60
End Sub

Private Sub cl_Click()
Y = 3
End Sub

Private Sub co3_Click()
Y = 5
End Sub

Private Sub Command1_Click()
Dim i As Integer
i = X + Y
If i = 11 Then
  Text1.Text = "水，H2O"
   ElseIf i = 12 Or i = 13 Or i = 15 Or i = 21 Then
    Text1.Text = "溶,挥"
ElseIf i = 54 Or i = 55 Or i = 56 Or i = 65 Or i = 66 Or i = 71 Or i = 81 Or i = 86 Or i = 91 Or i = 95 Or i = 96 Or i = 101 Or i = 105 Or i = 106 Or i = 111 Or i = 115 Or i = 116 Or i = 121 Or i = 126 Or i = 131 Or i = 136 Or i = 143 Or i = 145 Or i = 146 Then
Text1.Text = "不"
ElseIf i = 61 Or i = 64 Or i = 75 Or i = 144 Then
Text1.Text = "微"
ElseIf i = 85 Or i = 125 Or i = 135 Or i = 141 Then
Text1.Text = "--"
Else: Text1.Text = "溶"
End If
End Sub

Private Sub cu_Click()
X = 130
End Sub

Private Sub fe2_Click()
X = 110
End Sub

Private Sub fe3_Click()
X = 120
End Sub

Private Sub h_Click()
X = 10
End Sub

Private Sub k_Click()
X = 30
End Sub

Private Sub mg_Click()
X = 70
End Sub

Private Sub mn_Click()
X = 90
End Sub

Private Sub na_Click()
X = 40
End Sub

Private Sub nh4_Click()
X = 20
End Sub

Private Sub no3_Click()
Y = 2
End Sub

Private Sub oh_Click()
Y = 1
End Sub

Private Sub po4_Click()
Y = 6
End Sub

Private Sub so4_Click()
Y = 4
End Sub

Private Sub zn_Click()
X = 100
End Sub
