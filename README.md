# LibMaterial

> 为 WinForm 应用 Mica，Acrylic

> Plan ↻: Mica Effect

> Plan ↻: System Theme

## Plan X

![image](https://raw.githubusercontent.com/Simple-2021/LibMaterial/main/Images/DWMSBT_MAINWINDOW.jpg)

![image](https://raw.githubusercontent.com/Simple-2021/LibMaterial/main/Images/DWMSBT_TRANSIENTWINDOW.jpg)

## Win32 API

> DwmSetWindowAttribute

## Nuget Package

> 无引用

## 参考代码

> 在 Win32 应用中支持云母材质

> 在 Win32 应用中支持深色和浅色主题，[阅读更多](https://learn.microsoft.com/zh-cn/windows/apps/desktop/modernize/apply-windows-themes)

> 在 Win32 应用中支持透明客户端区域，[阅读更多](https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.forms.form.transparencykey?view=windowsdesktop-6.0)

## 实现代码

> Example，[阅读更多](https://github.com/Simple-2021/LibMaterial/tree/main/Example)

> Demo

```csharp

using LibMaterial;

namespace Win11Forms
{
    public partial class Window : Form
    {

        public Window()
        {
            InitializeComponent();
            base.OnSystemColorsChanged(EventArgs.Empty);
            LibApply.Apply_Backdrop_Effect(HWnd: Handle, BackdropFlag: LibImport.DwmSystemBackdropTypeFlgs.DWMSBT_MAINWINDOW);
        }

        private void Window_SystemColorsChanged(object sender, EventArgs e)
        {
            bool DarkStatus = !LibRegistry.GetAppUseLightTheme();
            LibApply.Apply_Light_Theme(HWnd: Handle, Dark: DarkStatus);
            LibApply.Apply_Transparent_Form(HWnd: Handle, Dark: DarkStatus);
        }

    }

}

```

## 版本支持

> LibMaterial(.NET)
>+ .NET 6.0+

> LibMaterial.Core
>+ .NET Core 3.1+

> LibMaterial.Framework
>+ .NET Framework 4.7.1+

## 参考资料

> SEARCH.BING.COM

> SEARCH.GOOGLE.COM

> LEARN.MICROSOFT.COM
