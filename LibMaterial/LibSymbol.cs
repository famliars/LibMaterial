using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMaterial
{
    public static class LibSymbol
    {
        [Description("从 font 中获取 Symbol 对应的 Bitmap")]
        public static Bitmap GetSymbolBitmap(string symbol, Font font, Brush brush, bool rectangle = true)
        {
            using var control = new Control();

            var size = control.CreateGraphics().MeasureString(symbol, font).ToSize();
            var border = size.Width > size.Height ? size.Width : size.Height;
            var bitmap = new Bitmap(border, border);

            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                graphics.DrawString(symbol, font, brush, rectangle ? (border - size.Width) / 2 : 0, rectangle ? (border - size.Height) / 2 : 0);
            }
            return bitmap;
        }
        [Description("从 Font 中获取 SymbolCode 对应的 Bitmap")]
        public static Bitmap GetSymbolBitmap(int symbol, Font font, Brush brush, bool rectangle = false)
        {
            return GetSymbolBitmap(GetSymbolString(symbol), font, brush, rectangle);
        }
        [Description("从 SymbolCode 转换为 String")]
        public static String GetSymbolString(int symbol)
        {
            return Convert.ToString(Convert.ToChar(symbol));
        }

    }
}
