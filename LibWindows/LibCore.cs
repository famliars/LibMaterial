using PInvoke;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using static LibWindows.LibImport;
using static LibWindows.LibImport.DwmSetWindowAttributeFlags;
using static LibWindows.LibImport.WindowCornerPreferenceFlags;
namespace LibWindows
{
    public static class LibCore
    {
        [Description("在 Win32 应用中支持 DWM 窗口合成")]
        public static void Apply_Window_Composition(IntPtr HWnd, WindowAccentStateFlags _AccentState, int _AccentFlags = 0, int _AnimationId = 0, int _GradientColor = 0)
        {
            var accent = new AccentPolicy()
            {
                AccentState = _AccentState,
                AccentFlags = _AccentFlags,
                AnimationId = _AnimationId,
                GradientColor = _GradientColor,
            };
            var accentSize = Marshal.SizeOf(accent);
            var accentPtr = Marshal.AllocHGlobal(accentSize);
            Marshal.StructureToPtr(accent, accentPtr, false);

            IntPtr WCA_ACCENT_POLICY = (IntPtr)19;
            var data = new WindowCompositionAttribute()
            {
                Attribute = WCA_ACCENT_POLICY,
                SizeOfData = accentSize,
                Data = accentPtr,
            };

            SetWindowCompositionAttribute(HWnd, ref data);

            Marshal.FreeHGlobal(accentPtr);
        }
        [Description("在 Win32 应用中支持 Mica 材质渲染")]
        public static void Apply_Mica_Effect(IntPtr HWnd, bool Disable = false)
        {
            var IsOld = Environment.OSVersion.Version < new Version("10.0.22523");
            int Key = IsOld ? 1 : 2;
            Key = Disable ? 0 : Key;
            DwmSetWindowAttribute(HWnd, IsOld ? DWM_MICA_EFFECT : DWM_SYSTEMBACKDROP_TYPE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持深色和浅色主题")]
        public static void Apply_Light_Theme(IntPtr HWnd, bool Disable = false)
        {
            int Key = Disable ? 1 : 0;
            DwmSetWindowAttribute(HWnd, DWM_USE_IMMERSIVE_DARK_MODE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持直角和圆角窗体")]
        public static void Apply_Rounded_Corners(IntPtr HWnd, bool Disable = false)
        {
            int Key = Disable ? 1 : 2;
            DwmSetWindowAttribute(HWnd, DWM_WINDOW_CORNER_PREFERENCE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持透明客户端区域")]
        public static void Apply_Transparent_Form(Form form, bool Disable = false)
        {
            form.TransparencyKey = Disable ? Color.Empty : form.BackColor = GetTransparentColor(form.BackColor);
        }
        [Description("获取关于指定方法的描述")]
        public static string? About_Method_Description(string MethodName)
        {
            return typeof(LibCore).GetMethod(MethodName)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
        [Description("获取关于指定方法的描述")]
        public static string? About_Flag_Description(Enum FlagItem)
        {
            Type type = FlagItem.GetType();
            return type.GetField(Enum.GetName(type, FlagItem)!)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
    }
}
