using PInvoke;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using static LibWindows.LibImport;
using static LibWindows.LibImport.WindowAccentStateFlags;

namespace LibWindows.Example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Chk1.Checked = true;
            Chk2.Checked = true;
            Chk3.Checked = true;
            radioButton1.Checked = true;
            DescriptionBox.Text = string.Empty;
        }

        private void Chk1_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Mica_Effect(Handle, !Chk1.Checked);
            DescriptionBox.Text = LibCore.About_Method_Description("Apply_Mica_Effect");
        }

        private void Chk2_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Light_Theme(Handle, !Chk2.Checked);
            DescriptionBox.Text = LibCore.About_Method_Description("Apply_Light_Theme");
        }

        private void Chk3_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Transparent_Form(this, !Chk3.Checked);
            DescriptionBox.Text = LibCore.About_Method_Description("Apply_Transparent_Form");
        }

        private void Chk4_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Rounded_Corners(Handle, !Chk4.Checked);
            DescriptionBox.Text = LibCore.About_Method_Description("Apply_Rounded_Corners");
        }

        private void Chk5_CheckedChanged(object sender, EventArgs e)
        {
            Chk6.Enabled = radioButton1.Enabled = radioButton2.Enabled = radioButton3.Enabled = radioButton4.Enabled = radioButton5.Enabled = radioButton6.Enabled = Chk5.Checked;
            DescriptionBox.Text = LibCore.About_Method_Description("Apply_Window_Composition");
            LibCore.Apply_Window_Composition(Handle, Chk5.Checked ? flag : default, _GradientColor: Chk6.Checked ? Color.Blue.ToArgb() : default);
        }

        private void Chk6_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Window_Composition(Handle, flag, _GradientColor: Chk6.Checked ? Color.Blue.ToArgb() : default);
        }

        private void Chk7_CheckedChanged(object sender, EventArgs e)
        {
            LibCore.Apply_Extend_Frame(Handle, !Chk7.Checked);
        }

        private WindowAccentStateFlags flag = ACCENT_INVALID_STATE;
        private void FlagButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton o = (RadioButton)sender;
            switch (o.Text)
            {
                case "ACCENT_DISABLED":
                    flag = ACCENT_DISABLED;
                    break;
                case "ACCENT_ENABLE_GRADIENT":
                    flag = ACCENT_ENABLE_GRADIENT;
                    break;
                case "ACCENT_ENABLE_TRANSPARENTGRADIENT":
                    flag = ACCENT_ENABLE_TRANSPARENTGRADIENT;
                    break;
                case "ACCENT_ENABLE_BLURBEHIND":
                    flag = ACCENT_ENABLE_BLURBEHIND;
                    break;
                case "ACCENT_ENABLE_ACRYLICBLURBEHIND":
                    flag = ACCENT_ENABLE_ACRYLICBLURBEHIND;
                    break;
            }
            LibCore.Apply_Window_Composition(Handle, flag, _GradientColor: Chk6.Checked ? Color.Blue.ToArgb() : default);
            DescriptionBox.Text = LibCore.About_Flag_Description(flag);

        }
    }
}