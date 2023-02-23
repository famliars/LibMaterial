using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using static LibMaterial.LibImport;
using static LibMaterial.LibImport.DwmSetWindowAttributeFlags;
using static LibMaterial.LibImport.DwmSystemBackdropTypeFlgs;

namespace LibMaterial
{
    public static class LibApply
    {
        [Description("在 Win32 应用中支持背景材质")]
        public static void Apply_Backdrop_Effect(IntPtr HWnd, bool Disable = false, DwmSystemBackdropTypeFlgs BackdropFlag = DWMSBT_MAINWINDOW)
        {
            int Key = (int)(Disable ? DWMSBT_NONE : BackdropFlag);
            DwmSetWindowAttribute(HWnd, DWM_SYSTEMBACKDROP_TYPE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持深色和浅色主题")]
        public static void Apply_Light_Theme(IntPtr HWnd, bool Disable = false)
        {
            int Key = Disable ? 1 : 0;
            DwmSetWindowAttribute(HWnd, DWM_USE_IMMERSIVE_DARK_MODE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持透明客户端区域")]
        public static void Apply_Transparent_Form(IntPtr HWnd, bool Disable = false)
        {
            Form form = (Form)Control.FromHandle(HWnd);
            form.TransparencyKey = Disable ? Color.Empty : form.BackColor = CalcTransparentColor(form.BackColor);
        }
        [Description("获取关于指定方法的描述")]
        public static string? About_Method_Description(string MethodName)
        {
            return typeof(LibApply).GetMethod(MethodName)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
        [Description("获取关于指定枚举的描述")]
        public static string? About_Enum_Description(Enum EnumFlag)
        {
            Type type = EnumFlag.GetType();
            return type.GetField(Enum.GetName(type, EnumFlag)!)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
    }
}
