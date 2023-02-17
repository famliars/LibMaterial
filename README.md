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

> WPF Area Glass 效果 [url:https://github.com/Nukepayload2/sample-win10-aeroglass](Source)

```C#

using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;

namespace BlurBehindDemo
{
	internal enum AccentState
	{
		ACCENT_DISABLED = 0,
		ACCENT_ENABLE_GRADIENT = 1,
		ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
		ACCENT_ENABLE_BLURBEHIND = 3,
		ACCENT_INVALID_STATE = 4
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct AccentPolicy
	{
		public AccentState AccentState;
		public int AccentFlags;
		public int GradientColor;
		public int AnimationId;
	}

	[StructLayout(LayoutKind.Sequential)]
	internal struct WindowCompositionAttributeData
	{
		public WindowCompositionAttribute Attribute;
		public IntPtr Data;
		public int SizeOfData;
	}

	internal enum WindowCompositionAttribute
	{
		// ...
		WCA_ACCENT_POLICY = 19
		// ...
	}

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		[DllImport("user32.dll")]
		internal static extern int SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttributeData data);

		public MainWindow()
		{
			InitializeComponent();
		}
		
		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			EnableBlur();
		}
		
		internal void EnableBlur()
		{
			var windowHelper = new WindowInteropHelper(this);
			
			var accent = new AccentPolicy();
			accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

			var accentStructSize = Marshal.SizeOf(accent);

			var accentPtr = Marshal.AllocHGlobal(accentStructSize);
			Marshal.StructureToPtr(accent, accentPtr, false);

			var data = new WindowCompositionAttributeData();
			data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
			data.SizeOfData = accentStructSize;
			data.Data = accentPtr;
			
			SetWindowCompositionAttribute(windowHelper.Handle, ref data);

			Marshal.FreeHGlobal(accentPtr);
		}


	}
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

> WinForm Area Glass 效果

```C#

    public enum AccentState
    {
        ACCENT_DISABLED = 0,
        ACCENT_ENABLE_GRADIENT = 1,
        ACCENT_ENABLE_TRANSPARENTGRADIENT = 2,
        ACCENT_ENABLE_BLURBEHIND = 3,
        ACCENT_INVALID_STATE = 4
    }
    
     public enum WindowCompositionAttribute
    {
        // ...
        WCA_ACCENT_POLICY = 19
        // ...
    }
    
    public struct AccentPolicy
    {
        public AccentState AccentState;
        public int AccentFlags;
        public int GradientColor;
        public int AnimationId;
    }

    
    public struct WindowCompositionAttributeData
    {
        public WindowCompositionAttribute Attribute;
        public IntPtr Data;
        public int SizeOfData;
    }

    public partial class DwmWindow : Form
    {
        public DwmWindow()
        {
            InitializeComponent();
        }


        private void DwmWindow_Load(object sender, EventArgs e)
        {
            EnableBlur();
        }

        void EnableBlur()
        {
            // BackColor = Black 时 blur 才可以生效
            BackColor = Color.Black;

            var accent = new AccentPolicy();
            accent.AccentState = AccentState.ACCENT_ENABLE_BLURBEHIND;

            var accentStructSize = Marshal.SizeOf(accent);

            var accentPtr = Marshal.AllocHGlobal(accentStructSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            var data = new WindowCompositionAttributeData();
            data.Attribute = WindowCompositionAttribute.WCA_ACCENT_POLICY;
            data.SizeOfData = accentStructSize;
            data.Data = accentPtr;

            SetWindowCompositionAttribute(Handle, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }

        
    }


```

## 参考资料

> SEARCH.BING.COM

> SEARCH.GOOGLE.COM

> LEARN.MICROSOFT.COM
