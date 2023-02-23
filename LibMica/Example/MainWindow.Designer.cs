namespace LibMica.Example
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
            FlowGrid2 = new FlowLayoutPanel();
            DescriptionBox = new TextBox();
            TableGrid.SuspendLayout();
            FlowGrid1.SuspendLayout();
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
            Chk1.TabIndex = 1;
            Chk1.Text = "Apply_Mica_Effect";
            Chk1.UseVisualStyleBackColor = true;
            Chk1.CheckedChanged += Apply_CheckedChanged;
            // 
            // Chk2
            // 
            Chk2.AutoSize = true;
            Chk2.Location = new Point(3, 30);
            Chk2.Name = "Chk2";
            Chk2.Size = new Size(137, 21);
            Chk2.TabIndex = 2;
            Chk2.Text = "Apply_Light_Theme";
            Chk2.UseVisualStyleBackColor = true;
            Chk2.CheckedChanged += Apply_CheckedChanged;
            // 
            // Chk3
            // 
            Chk3.AutoSize = true;
            Chk3.Location = new Point(3, 57);
            Chk3.Name = "Chk3";
            Chk3.Size = new Size(170, 21);
            Chk3.TabIndex = 3;
            Chk3.Text = "Apply_Transparent_Form";
            Chk3.UseVisualStyleBackColor = true;
            Chk3.CheckedChanged += Apply_CheckedChanged;
            // 
            // FlowGrid2
            // 
            FlowGrid2.AutoScroll = true;
            FlowGrid2.Dock = DockStyle.Fill;
            FlowGrid2.FlowDirection = FlowDirection.TopDown;
            FlowGrid2.Location = new Point(377, 79);
            FlowGrid2.Name = "FlowGrid2";
            FlowGrid2.Size = new Size(369, 198);
            FlowGrid2.TabIndex = 6;
            // 
            // DescriptionBox
            // 
            TableGrid.SetColumnSpan(DescriptionBox, 2);
            DescriptionBox.Dock = DockStyle.Fill;
            DescriptionBox.Location = new Point(86, 283);
            DescriptionBox.Multiline = true;
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(660, 147);
            DescriptionBox.TabIndex = 0;
            // 
            // MainWindow
            // 
            ClientSize = new Size(834, 511);
            Controls.Add(TableGrid);
            Name = "MainWindow";
            Text = "Example";
            SystemColorsChanged += MainWindow_SystemColorsChanged;
            TableGrid.ResumeLayout(false);
            TableGrid.PerformLayout();
            FlowGrid1.ResumeLayout(false);
            FlowGrid1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel TableGrid;
        private FlowLayoutPanel FlowGrid1;
        private CheckBox Chk3;
        private CheckBox Chk1;
        private CheckBox Chk2;
        private FlowLayoutPanel FlowGrid2;
        private TextBox DescriptionBox;
    }
}