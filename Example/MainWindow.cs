using LibMaterial;
using System.Diagnostics;
using static LibMaterial.LibImport.DwmSystemBackdropTypeFlgs;

namespace Example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Chk1.Checked =
            Chk2.Checked = true;
            Chk3.Checked =
            SBT_2.Checked = true;
        }

        private void MainWindow_SystemColorsChanged(object sender, EventArgs e)
        {
            Chk2.Checked = LibRegistry.GetAppUseLightTheme();
        }

        private void Apply_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox ApplyBox = (CheckBox)sender;
            switch (ApplyBox.TabIndex)
            {
                case 1:
                    {
                        if (ApplyBox.Checked)
                        {
                            LibApply.Apply_Backdrop_Effect(Handle, BackdropFlag);
                        }
                        else
                        {
                            LibApply.Cancel_Backdrop_Effect(Handle);
                        }
                    }
                    break;
                case 2:
                    {
                        LibApply.Apply_Light_Theme(Handle, !ApplyBox.Checked);
                        if (Chk3.Checked)
                        {
                            LibApply.Apply_Transparent_Form(Handle, !Chk2.Checked);
                        }
                    }
                    break;
                case 3:
                    {
                        if (ApplyBox.Checked)
                        {
                            LibApply.Apply_Transparent_Form(Handle, !Chk2.Checked);
                        }
                        else
                        {
                            LibApply.Cancel_Transparent_Form(Handle);
                        }
                    }
                    break;
            }
            DescriptionBox.Text = LibApply.About_Method_Description(ApplyBox.Text);
        }

        private LibImport.DwmSystemBackdropTypeFlgs BackdropFlag;
        private void DWM_SBT_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton BackdropButton = (RadioButton)sender;
            switch (BackdropButton.TabIndex)
            {
                case 0:
                    {
                        BackdropFlag = DWMSBT_AUTO;
                    }
                    break;
                case 1:
                    {
                        BackdropFlag = DWMSBT_NONE;
                    }
                    break;
                case 2:
                    {
                        BackdropFlag = DWMSBT_MAINWINDOW;
                    }
                    break;
                case 3:
                    {
                        BackdropFlag = DWMSBT_TRANSIENTWINDOW;
                    }
                    break;
                case 4:
                    {
                        BackdropFlag = DWMSBT_TABBEDWINDOW;
                    }
                    break;
            }
            LibApply.Apply_Backdrop_Effect(Handle, BackdropFlag);
            DescriptionBox.Text = LibApply.About_Enum_Description(BackdropFlag);
        }

    }
}