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
cation = 140
End Sub

Private Sub al_Click()
cation = 80
End Sub

Private Sub ba_Click()
cation = 50
End Sub

Private Sub ca_Click()
cation = 60
End Sub

Private Sub cl_Click()
anion = 3
End Sub

Private Sub co3_Click()
anion = 5
End Sub

Private Sub Command1_Click()
Dim ionpair As Integer
ionpair = cation + anion
If ionpair = 11 Then
  Text1.Text = "水，H2O"
   ElseIf ionpair = 12 Or ionpair = 13 Or ionpair = 15 Or ionpair = 21 Then
    Text1.Text = "溶,挥"
ElseIf ionpair = 54 Or ionpair = 55 Or ionpair = 56 Or ionpair = 65 Or ionpair = 66 Or ionpair = 71 Or ionpair = 81 Or ionpair = 86 Or ionpair = 91 Or ionpair = 95 Or ionpair = 96 Or ionpair = 101 Or ionpair = 105 Or ionpair = 106 Or ionpair = 111 Or ionpair = 115 Or ionpair = 116 Or ionpair = 121 Or ionpair = 126 Or ionpair = 131 Or ionpair = 136 Or ionpair = 143 Or ionpair = 145 Or ionpair = 146 Then
Text1.Text = "不"
ElseIf ionpair = 61 Or ionpair = 64 Or ionpair = 75 Or ionpair = 144 Then
Text1.Text = "微"
ElseIf ionpair = 85 Or ionpair = 125 Or ionpair = 135 Or ionpair = 141 Then
Text1.Text = "--"
Else: Text1.Text = "溶"
End If
End Sub

Private Sub cu_Click()
cation = 130
End Sub

Private Sub fe2_Click()
cation = 110
End Sub

Private Sub fe3_Click()
cation = 120
End Sub

Private Sub h_Click()
cation = 10
End Sub

Private Sub k_Click()
cation = 30
End Sub

Private Sub mg_Click()
cation = 70
End Sub

Private Sub mn_Click()
cation = 90
End Sub

Private Sub na_Click()
cation = 40
End Sub

Private Sub nh4_Click()
cation = 20
End Sub

Private Sub no3_Click()
anion = 2
End Sub

Private Sub oh_Click()
anion = 1
End Sub

Private Sub po4_Click()
anion = 6
End Sub

Private Sub so4_Click()
anion = 4
End Sub

Private Sub zn_Click()
cation = 100
End Sub
