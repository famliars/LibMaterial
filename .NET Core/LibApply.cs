using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static LibMaterial.Core.LibImport;
using static LibMaterial.Core.LibImport.DwmSetWindowAttributeFlags;
using static LibMaterial.Core.LibImport.DwmSystemBackdropTypeFlgs;

namespace LibMaterial.Core
{
    public static class LibApply
    {
        [Description("亮色")]
        public static Color LightColor = Color.FromArgb(233, 233, 234);
        [Description("暗色")]
        public static Color DarkColor = Color.FromArgb(22, 22, 21);

        [Description("在 Win32 应用中支持背景材质")]
        public static void Apply_Backdrop_Effect(IntPtr HWnd, DwmSystemBackdropTypeFlgs BackdropFlag = DWMSBT_MAINWINDOW)
        {
            int key = (int)BackdropFlag;
            DwmSetWindowAttribute(HWnd, DWM_SYSTEMBACKDROP_TYPE, ref key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持深色和浅色主题")]
        public static void Apply_Light_Theme(IntPtr HWnd, bool Dark = false)
        {
            int key = Dark ? 1 : 0;
            DwmSetWindowAttribute(HWnd, DWM_USE_IMMERSIVE_DARK_MODE, ref key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中支持透明客户端区域")]
        public static void Apply_Transparent_Form(IntPtr HWnd, bool Dark = false)
        {
            Form form = (Form)Control.FromHandle(HWnd);
            form.ForeColor = Dark ? LightColor : DarkColor;
            form.TransparencyKey = form.BackColor = Dark ? DarkColor : LightColor;
        }
        [Description("在 Win32 应用中取消背景材质")]
        public static void Cancel_Backdrop_Effect(IntPtr HWnd)
        {
            int Key = 0;
            DwmSetWindowAttribute(HWnd, DWM_SYSTEMBACKDROP_TYPE, ref Key, Marshal.SizeOf(typeof(int)));
        }
        [Description("在 Win32 应用中取消透明客户端区域")]
        public static void Cancel_Transparent_Form(IntPtr HWnd)
        {
            ((Form)Control.FromHandle(HWnd)).TransparencyKey = Color.Empty;
        }
        [Description("获取关于指定方法的描述")]
        public static string About_Method_Description(string MethodName)
        {
            return typeof(LibApply).GetMethod(MethodName)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
        [Description("获取关于指定枚举的描述")]
        public static string About_Enum_Description(Enum EnumFlag)
        {
            Type type = EnumFlag.GetType();
            return type.GetField(Enum.GetName(type, EnumFlag)!)?.GetCustomAttribute<DescriptionAttribute>()?.Description;
        }
    }
}
