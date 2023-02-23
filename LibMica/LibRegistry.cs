using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMica
{
    public static class LibRegistry
    {
        [Description(@$"{Personalize}")]
        public const string Personalize = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";

        [Description(@$"{Personalize}\{AppsUseLightTheme}")]
        public const string AppsUseLightTheme = "AppsUseLightTheme";

        [Description(@$"{Personalize}\{SystemUsesLightTheme}")]
        public const string SystemUsesLightTheme = "SystemUsesLightTheme";

        [Description(@$"{Colors}")]
        public const string Colors = @"Software\Microsoft\Windows\CurrentVersion\Themes\History\Colors";

        [Description($@"{DWM}")]
        public const string DWM = @"Software\Microsoft\Windows\DWM";

        [Description($@"{DWM}\{AccentColor}")]
        public const string AccentColor = "AccentColor";

        [Description($@"{DWM}\{ColorizationColor}")]
        public const string ColorizationColor = "ColorizationColor";

        [Description($@"{DWM}\{ColorizationAfterglow}")]
        public const string ColorizationAfterglow = "ColorizationAfterglow";


        [Description("App 颜色模板是否亮色")]
        public static bool GetAppUseLightTheme()
        {
            return GetValueToBoolean(Personalize, AppsUseLightTheme);
        }

        [Description("System 颜色模板是否亮色")]
        public static bool GetSysUseLightTheme()
        {
            return GetValueToBoolean(Personalize, SystemUsesLightTheme);
        }

        [Description("获取最近的颜色组")]
        public static Color[]? GetHistoryColors()
        {
            RegistryKey? SubKey = Registry.CurrentUser.OpenSubKey(Colors);
            if (SubKey == null) return null;
            string[]? Names = SubKey?.GetValueNames();
            if (Names == null) return null;

            List<Color> ColorList = new();
            ColorList.AddRange(Names.Select(ValueName => GetValueToColor(Colors, ValueName)));
            return ColorList.ToArray();
        }

        [Description("获取强调色")]
        public static Color GetAccentColor()
        {
            return GetValueToColor(DWM, AccentColor);
        }
        [Description("获取重点色")]
        public static Color GetColorizationColor()
        {
            return GetValueToColor(DWM, ColorizationColor);
        }
        [Description("获取近似色")]
        public static Color GetColorizationAfterglow()
        {
            return GetValueToColor(DWM, ColorizationAfterglow);
        }
        [Description("获取 bool")]
        private static bool GetValueToBoolean(string subkey, string subvalue)
        {
            RegistryKey? key = Registry.CurrentUser.OpenSubKey(subkey);
            return default != Convert.ToInt32(key?.GetValue(subvalue)); ;
        }
        [Description("获取 Color")]
        private static Color GetValueToColor(string subkey, string subvalue)
        {
            RegistryKey? key = Registry.CurrentUser.OpenSubKey(subkey);
            return Color.FromArgb(Convert.ToInt32(key?.GetValue(subvalue)));
        }

    }
}
