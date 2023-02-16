# LibMica

> Plan ⟳: 状态栏

> Plan ↻: 系统交互特效

## Plan X

![image](https://user-images.githubusercontent.com/78424351/185796695-81eb8401-bc91-4dcd-b940-90eab628165d.png)

## Win32 API

> Pause

## Nuget Package

> Pinvoke.User32

> [Pinvoke.Dwmapi]

## 参考代码

> C++ MaxButton 响应贴靠布局

```C++

LRESULT CALLBACK TestWndProc(HWND window, UINT msg, WPARAM wParam, LPARAM lParam)
{
    switch (msg)
    {
          case WM_NCHITTEST:
        {
            // Get the point in screen coordinates.
            // GET_X_LPARAM and GET_Y_LPARAM are defined in windowsx.h
            POINT point = { GET_X_LPARAM(lParam), GET_Y_LPARAM(lParam) };
            // Map the point to client coordinates.
            ::MapWindowPoints(nullptr, window, &point, 1);
            // If the point is in your maximize button then return HTMAXBUTTON
            if (::PtInRect(&m_maximizeButtonRect, point))
            {
                return HTMAXBUTTON;
            }
        }
        break;
    }
    return ::DefWindowProcW(window, msg, wParam, lParam);
}

```
## 实现代码

> C# MaxButton 响应贴靠布局

```C#

public partial class Window : Form

    private new readonly bool ControlBox; 
    private Control? btnMAX = null;
    
    public Window()
    {
        InitializeComponent();
    }

    [DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern bool PtInRect(ref Rectangle lprc, Point pt);
    [DllImport("User32", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern int MapWindowPoints(IntPtr hWndFrom, IntPtr hWndTo, ref Point lpPoints, [MarshalAs(UnmanagedType.U4)] int cPoints);
    
    protected override void WndProc(ref Message m)
    {
        switch ((WindowMessage)m.Msg)
        {
            case WM_NCHITTEST:
            {
            
                Point NitPOINT = new Point((int)LParam & 0xFFFF, (int)LParam >> 16 & 0xFFFF);
                MapWindowPoints(IntPtr.Zero, m.HWnd, ref NitPOINT, 1);

                if (btnMAX != null && btnMAX.Bounds.Contains(NitPOINT))
                {
                    m.Result = IntPtrCode.HTMAXBUTTON;
                    return;
                }

            }
        }
        base.WndProc(ref m);
    }
}

```

## 参考资料

> SEARCH.BING.COM

> SEARCH.GOOGLE.COM

> LEARN.MICROSOFT.COM
