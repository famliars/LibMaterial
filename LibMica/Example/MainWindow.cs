using static LibMica.LibDll.DwmSystemBackdropTypeFlgs;

namespace LibMica.Example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Chk1.Checked =
            Chk2.Checked =
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
                        LibMica.Apply_Mica_Effect(Handle, !ApplyBox.Checked, BackdropFlag);
                    }
                    break;
                case 2:
                    {
                        LibMica.Apply_Light_Theme(Handle, !ApplyBox.Checked);
                    }
                    break;
                case 3:
                    {
                        LibMica.Apply_Transparent_Form(this, !ApplyBox.Checked);
                    }
                    break;
            }
            DescriptionBox.Text = LibMica.About_Method_Description(ApplyBox.Text);
        }

        private LibDll.DwmSystemBackdropTypeFlgs BackdropFlag;
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
            LibMica.Apply_Mica_Effect(Handle, !Chk1.Checked, BackdropFlag);
            DescriptionBox.Text = LibMica.About_Enum_Description(BackdropFlag);
        }

    }
}