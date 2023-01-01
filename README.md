# LibMica

> Plan ⟳: 状态栏

> Plan ↻: 系统交互特效

## Plan X

![image](https://user-images.githubusercontent.com/78424351/185796695-81eb8401-bc91-4dcd-b940-90eab628165d.png)

## Win32 API

> Pause

## Nuget Package

> Pinvoke.Dwmapi

> Pinvoke.User32

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

  // Unimplemented

```

## 参考资料

> SEARCH.BING.COM

> SEARCH.GOOGLE.COM

> LEARN.MICROSOFT.COM
