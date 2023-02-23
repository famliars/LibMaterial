using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using static LibMica.LibDll;
using static LibMica.LibDll.DwmSetWindowAttributeFlags;
namespace LibMica
{
    public static class LibMica
    {
        [Description("在 Win32 应用中支持云母材质")]
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
        [Description("在 Win32 应用中支持透明客户端区域")]
        public static void Apply_Transparent_Form(Form form, bool Disable = false)
        {
            form.TransparencyKey = Disable ? Color.Empty : form.BackColor = CalcTransparentColor(form.BackColor);
        }
        [Description("获取关于指定方法的描述")]
        public static string? About_Method_Description(string MethodName)
        {
            return typeof(LibMica).GetMethod(MethodName)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
    }
}
