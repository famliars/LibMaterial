namespace LibWindows.Example
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TableGrid = new TableLayoutPanel();
            FlowGrid1 = new FlowLayoutPanel();
            Chk1 = new CheckBox();
            Chk2 = new CheckBox();
            Chk3 = new CheckBox();
            Chk4 = new CheckBox();
            Chk5 = new CheckBox();
            FlowGrid2 = new FlowLayoutPanel();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            Chk6 = new CheckBox();
            DescriptionBox = new TextBox();
            Chk7 = new CheckBox();
            TableGrid.SuspendLayout();
            FlowGrid1.SuspendLayout();
            FlowGrid2.SuspendLayout();
            SuspendLayout();
            // 
            // TableGrid
            // 
            TableGrid.BackColor = Color.Transparent;
            TableGrid.ColumnCount = 4;
            TableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            TableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            TableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            TableGrid.Controls.Add(FlowGrid1, 1, 1);
            TableGrid.Controls.Add(FlowGrid2, 2, 1);
            TableGrid.Controls.Add(DescriptionBox, 1, 2);
            TableGrid.Dock = DockStyle.Fill;
            TableGrid.Location = new Point(0, 0);
            TableGrid.Name = "TableGrid";
            TableGrid.RowCount = 4;
            TableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            TableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            TableGrid.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            TableGrid.Size = new Size(834, 511);
            TableGrid.TabIndex = 5;
            // 
            // FlowGrid1
            // 
            FlowGrid1.AutoScroll = true;
            FlowGrid1.Controls.Add(Chk1);
            FlowGrid1.Controls.Add(Chk2);
            FlowGrid1.Controls.Add(Chk3);
            FlowGrid1.Controls.Add(Chk4);
            FlowGrid1.Controls.Add(Chk5);
            FlowGrid1.Controls.Add(Chk7);
            FlowGrid1.Dock = DockStyle.Fill;
            FlowGrid1.FlowDirection = FlowDirection.TopDown;
            FlowGrid1.Location = new Point(86, 79);
            FlowGrid1.Name = "FlowGrid1";
            FlowGrid1.Size = new Size(285, 198);
            FlowGrid1.TabIndex = 0;
            // 
            // Chk1
            // 
            Chk1.AutoSize = true;
            Chk1.Location = new Point(3, 3);
            Chk1.Name = "Chk1";
            Chk1.Size = new Size(130, 21);
            Chk1.TabIndex = 2;
            Chk1.Text = "Apply_Mica_Effect";
            Chk1.UseVisualStyleBackColor = true;
            Chk1.CheckedChanged += Chk1_CheckedChanged;
            // 
            // Chk2
            // 
            Chk2.AutoSize = true;
            Chk2.Location = new Point(3, 30);
            Chk2.Name = "Chk2";
            Chk2.Size = new Size(137, 21);
            Chk2.TabIndex = 4;
            Chk2.Text = "Apply_Light_Theme";
            Chk2.UseVisualStyleBackColor = true;
            Chk2.CheckedChanged += Chk2_CheckedChanged;
            // 
            // Chk3
            // 
            Chk3.AutoSize = true;
            Chk3.Location = new Point(3, 57);
            Chk3.Name = "Chk3";
            Chk3.Size = new Size(170, 21);
            Chk3.TabIndex = 0;
            Chk3.Text = "Apply_Transparent_Form";
            Chk3.UseVisualStyleBackColor = true;
            Chk3.CheckedChanged += Chk3_CheckedChanged;
            // 
            // Chk4
            // 
            Chk4.AutoSize = true;
            Chk4.Location = new Point(3, 84);
            Chk4.Name = "Chk4";
            Chk4.Size = new Size(169, 21);
            Chk4.TabIndex = 5;
            Chk4.Text = "Apply_Rounded_Corners";
            Chk4.UseVisualStyleBackColor = true;
            Chk4.CheckedChanged += Chk4_CheckedChanged;
            // 
            // Chk5
            // 
            Chk5.AutoSize = true;
            Chk5.Location = new Point(3, 111);
            Chk5.Name = "Chk5";
            Chk5.Size = new Size(191, 21);
            Chk5.TabIndex = 6;
            Chk5.Text = "Apply_Window_Composition";
            Chk5.UseVisualStyleBackColor = true;
            Chk5.CheckedChanged += Chk5_CheckedChanged;
            // 
            // FlowGrid2
            // 
            FlowGrid2.AutoScroll = true;
            FlowGrid2.Controls.Add(radioButton1);
            FlowGrid2.Controls.Add(radioButton2);
            FlowGrid2.Controls.Add(radioButton3);
            FlowGrid2.Controls.Add(radioButton4);
            FlowGrid2.Controls.Add(radioButton5);
            FlowGrid2.Controls.Add(radioButton6);
            FlowGrid2.Controls.Add(Chk6);
            FlowGrid2.Dock = DockStyle.Fill;
            FlowGrid2.FlowDirection = FlowDirection.TopDown;
            FlowGrid2.Location = new Point(377, 79);
            FlowGrid2.Name = "FlowGrid2";
            FlowGrid2.Size = new Size(369, 198);
            FlowGrid2.TabIndex = 6;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(137, 21);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "ACCENT_DISABLED";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(3, 30);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(192, 21);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "ACCENT_ENABLE_GRADIENT";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(3, 57);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(279, 21);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "ACCENT_ENABLE_TRANSPARENTGRADIENT";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(3, 84);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(208, 21);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.Text = "ACCENT_ENABLE_BLURBEHIND";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(3, 111);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(257, 21);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "ACCENT_ENABLE_ACRYLICBLURBEHIND";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(3, 138);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(169, 21);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.Text = "ACCENT_INVALID_STATE";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += FlagButton_CheckedChanged;
            // 
            // Chk6
            // 
            Chk6.AutoSize = true;
            Chk6.Location = new Point(3, 165);
            Chk6.Name = "Chk6";
            Chk6.Size = new Size(144, 21);
            Chk6.TabIndex = 6;
            Chk6.Text = "GradientColor : RED";
            Chk6.UseVisualStyleBackColor = true;
            Chk6.CheckedChanged += Chk6_CheckedChanged;
            // 
            // DescriptionBox
            // 
            TableGrid.SetColumnSpan(DescriptionBox, 2);
            DescriptionBox.Dock = DockStyle.Fill;
            DescriptionBox.Location = new Point(86, 283);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(660, 147);
            DescriptionBox.TabIndex = 7;
            // 
            // Chk7
            // 
            Chk7.AutoSize = true;
            Chk7.Location = new Point(3, 138);
            Chk7.Name = "Chk7";
            Chk7.Size = new Size(145, 21);
            Chk7.TabIndex = 7;
            Chk7.Text = "Apply_Extend_Frame";
            Chk7.UseVisualStyleBackColor = true;
            Chk7.CheckedChanged += Chk7_CheckedChanged;
            // 
            // MainWindow
            // 
            ClientSize = new Size(834, 511);
            Controls.Add(TableGrid);
            Name = "MainWindow";
            Text = "Example";
            TableGrid.ResumeLayout(false);
            TableGrid.PerformLayout();
            FlowGrid1.ResumeLayout(false);
            FlowGrid1.PerformLayout();
            FlowGrid2.ResumeLayout(false);
            FlowGrid2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TableGrid;
        private FlowLayoutPanel FlowGrid1;
        private CheckBox Chk3;
        private CheckBox Chk1;
        private CheckBox Chk2;
        private CheckBox Chk4;
        private FlowLayoutPanel FlowGrid2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private TextBox DescriptionBox;
        private CheckBox Chk6;
        private CheckBox Chk5;
        private CheckBox Chk7;
    }
}