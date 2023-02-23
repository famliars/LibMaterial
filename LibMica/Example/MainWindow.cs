namespace LibMica.Example
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
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
                        LibMica.Apply_Mica_Effect(Handle, !ApplyBox.Checked);
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

    }
}