'Source from http://blog.csdn.net/bigheadsheep/article/details/10435529 

Public Class Common
    Private Declare Function GetSystemMenu Lib "User32" (ByVal hwnd As Integer, ByVal bRevert As Long) As Integer

    Private Declare Function RemoveMenu Lib "User32" (ByVal hMenu As Integer, ByVal nPosition As Integer, ByVal wFlags As Integer) As Integer

    Private Declare Function DrawMenuBar Lib "User32" (ByVal hwnd As Integer) As Integer

    Private Declare Function GetMenuItemCount Lib "User32" (ByVal hMenu As Integer) As Integer



    Private Const MF_BYPOSITION = &H400&

    Private Const MF_DISABLED = &H2&


    '禁用窗口右上角的“关闭”按钮  
    Public Sub DisableCloseButton(ByVal wnd As Form)

        Dim hMenu As Integer, nCount As Integer

        '得到系统Menu  

        hMenu = GetSystemMenu(wnd.Handle.ToInt32, 0)

        '得到系统Menu的个数  

        nCount = GetMenuItemCount(hMenu)

        '去除系统Menu  

        Call RemoveMenu(hMenu, nCount - 1, MF_BYPOSITION Or MF_DISABLED)

        '重画MenuBar  

        DrawMenuBar(wnd.Handle.ToInt32)

    End Sub

End Class
