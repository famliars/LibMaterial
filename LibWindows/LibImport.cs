using PInvoke;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace LibWindows
{
    public static class LibImport
    {
        #region Dll Import
        
        [DllImport("user32.dll")]
        internal static extern HResult SetWindowCompositionAttribute(IntPtr hwnd, ref WindowCompositionAttribute data);

        [DllImport("dwmapi.dll")]
        internal static extern HResult DwmSetWindowAttribute(IntPtr hwnd, DwmSetWindowAttributeFlags dwAttribute, ref int pvAttribute, int cbAttribute);

        [DllImport("DwmApi.dll")]
        internal static extern HResult DwmExtendFrameIntoClientArea(IntPtr hwnd,UxTheme.MARGINS margins);

        #endregion

        #region Dll Struct

        public struct AccentPolicy
        {
            public WindowAccentStateFlags AccentState;
            public int AccentFlags;
            public int GradientColor;
            public int AnimationId;
        }

        public struct WindowCompositionAttribute
        {
            public IntPtr Attribute;
            public IntPtr Data;
            public int SizeOfData;
        }

        #endregion

        #region Dll Enum

        public enum DwmSetWindowAttributeFlags
        {
            DWM_NCRENDERING_ENABLED,
            DWM_NCRENDERING_POLICY,
            DWM_TRANSITIONS_FORCEDISABLED,
            DWM_ALLOW_NCPAINT,
            DWM_CAPTION_BUTTON_BOUNDS,
            DWM_NONCLIENT_RTL_LAYOUT,
            DWM_FORCE_ICONIC_REPRESENTATION,
            DWM_FLIP3D_POLICY,
            DWM_EXTENDED_FRAME_BOUNDS,
            DWM_HAS_ICONIC_BITMAP,
            DWM_DISALLOW_PEEK,
            DWM_EXCLUDED_FROM_PEEK,
            DWM_CLOAK,
            DWM_CLOAKED,
            DWM_FREEZE_REPRESENTATION,
            DWM_PASSIVE_UPDATE_MODE,
            DWM_USE_HOSTBACKDROPBRUSH,
            DWM_USE_IMMERSIVE_DARK_MODE = 20,
            DWM_WINDOW_CORNER_PREFERENCE = 33,
            DWM_BORDER_COLOR,
            DWM_CAPTION_COLOR,
            DWM_TEXT_COLOR,
            DWM_VISIBLE_FRAME_BORDER_THICKNESS,
            DWM_SYSTEMBACKDROP_TYPE,
            DWM_LAST,
            DWM_MICA_EFFECT = 1029
        };

        public enum WindowAccentStateFlags
        {
            [Description("默认的背景样式")]
            ACCENT_DISABLED,
            [Description("背景颜色为叠加色(AccentPolicy.GradientColor)")]
            ACCENT_ENABLE_GRADIENT,
            [Description("背景颜色为系统主题色")]
            ACCENT_ENABLE_TRANSPARENTGRADIENT,
            [Description("背景颜色为半透明模糊")]
            ACCENT_ENABLE_BLURBEHIND,
            [Description("背景颜色为叠加色半透明模糊")]
            ACCENT_ENABLE_ACRYLICBLURBEHIND,
            [Description("与默认的背景样式相同")]
            ACCENT_INVALID_STATE,
        }

        public enum WindowCornerPreferenceFlags
        {
            [Description("让系统决定是否对窗口采用圆角设置。")]
            DWMWCP_DEFAULT,
            [Description("绝不对窗口采用圆角设置。")]
            DWMWCP_DONOTROUND,
            [Description("适当时采用圆角设置。")]
            DWMWCP_ROUND,
            [Description("适当时可采用半径较小的圆角设置。")]
            DWMWCP_ROUNDSMALL
        }

        #endregion

        #region Dll Macro

        public static bool IsColorLight(Color clr)
        {
            return (((5 * clr.G) + (2 * clr.R) + clr.B) > (8 * 128));
        }

        public static Point GET_HIT_PARAM(IntPtr LParam)
        {
            return new Point((int)LParam & 0xFFFF, (int)LParam >> 16 & 0xFFFF);
        }

        public static Color GetTransparentColor(Color Clr)
        {
            return (Clr.R != Clr.B) ? Clr : Color.FromArgb(Clr.ToArgb() | 0x1);
        }

        #endregion


    }

}
