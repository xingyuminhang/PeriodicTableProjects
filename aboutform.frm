VERSION 5.00
Begin VB.Form aboutform 
   BorderStyle     =   3  'Fixed Dialog
   Caption         =   "关于"
   ClientHeight    =   3855
   ClientLeft      =   45
   ClientTop       =   375
   ClientWidth     =   9345
   Icon            =   "aboutform.frx":0000
   LinkTopic       =   "Form4"
   MaxButton       =   0   'False
   MinButton       =   0   'False
   ScaleHeight     =   3855
   ScaleWidth      =   9345
   ShowInTaskbar   =   0   'False
   StartUpPosition =   3  '窗口缺省
   Begin VB.Image Image1 
      Height          =   3600
      Left            =   120
      Picture         =   "aboutform.frx":3A24A
      Top             =   120
      Width           =   3600
   End
   Begin VB.Label Label1 
      Caption         =   $"aboutform.frx":74494
      Height          =   2175
      Left            =   4080
      TabIndex        =   0
      Top             =   120
      Width           =   5055
   End
End
Attribute VB_Name = "aboutform"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Private Sub Image1_Click()
Shell "explorer.exe " & "  https://github.com/xingyuminhang/yszqb-Projects"
End Sub
