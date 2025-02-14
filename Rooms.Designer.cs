namespace HostelMangagementSystem
{
    partial class Rooms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rooms));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            RoomNumbertb = new TextBox();
            RoomStatusCb = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            YesRadio = new RadioButton();
            NoRadio = new RadioButton();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            RoomDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1017, 60);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(989, 9);
            label5.Name = "label5";
            label5.Size = new Size(16, 20);
            label5.TabIndex = 2;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(333, 10);
            label1.Name = "label1";
            label1.Size = new Size(337, 37);
            label1.TabIndex = 0;
            label1.Text = "ROOM INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 204, 254);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 15);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(594, 146);
            label2.Name = "label2";
            label2.Size = new Size(197, 37);
            label2.TabIndex = 2;
            label2.Text = "ROOM LIST";
            // 
            // RoomNumbertb
            // 
            RoomNumbertb.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RoomNumbertb.ForeColor = Color.Crimson;
            RoomNumbertb.Location = new Point(69, 172);
            RoomNumbertb.Name = "RoomNumbertb";
            RoomNumbertb.Size = new Size(125, 30);
            RoomNumbertb.TabIndex = 4;
            RoomNumbertb.Text = "RoomNumber";
            // 
            // RoomStatusCb
            // 
            RoomStatusCb.FormattingEnabled = true;
            RoomStatusCb.Items.AddRange(new object[] { "Active", "NotActive" });
            RoomStatusCb.Location = new Point(158, 232);
            RoomStatusCb.Name = "RoomStatusCb";
            RoomStatusCb.Size = new Size(151, 28);
            RoomStatusCb.TabIndex = 6;
            RoomStatusCb.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(12, 234);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 7;
            label3.Text = "ROOM STATUS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(12, 283);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 8;
            label4.Text = "BOOK";
            // 
            // YesRadio
            // 
            YesRadio.AutoSize = true;
            YesRadio.Checked = true;
            YesRadio.ForeColor = Color.Blue;
            YesRadio.Location = new Point(158, 283);
            YesRadio.Name = "YesRadio";
            YesRadio.Size = new Size(51, 24);
            YesRadio.TabIndex = 9;
            YesRadio.TabStop = true;
            YesRadio.Text = "Yes";
            YesRadio.UseVisualStyleBackColor = true;
            // 
            // NoRadio
            // 
            NoRadio.AutoSize = true;
            NoRadio.ForeColor = Color.Blue;
            NoRadio.Location = new Point(237, 282);
            NoRadio.Name = "NoRadio";
            NoRadio.Size = new Size(50, 24);
            NoRadio.TabIndex = 10;
            NoRadio.Text = "No";
            NoRadio.UseVisualStyleBackColor = true;
            NoRadio.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.Crimson;
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.Crimson;
            bunifuThinButton21.BackColor = SystemColors.Control;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "ADD";
            bunifuThinButton21.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton21.ForeColor = Color.Crimson;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.Crimson;
            bunifuThinButton21.IdleLineColor = Color.Crimson;
            bunifuThinButton21.Location = new Point(31, 429);
            bunifuThinButton21.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(90, 40);
            bunifuThinButton21.TabIndex = 11;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // bunifuThinButton22
            // 
            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = Color.Crimson;
            bunifuThinButton22.ActiveForecolor = Color.White;
            bunifuThinButton22.ActiveLineColor = Color.Crimson;
            bunifuThinButton22.BackColor = SystemColors.Control;
            bunifuThinButton22.BackgroundImage = (Image)resources.GetObject("bunifuThinButton22.BackgroundImage");
            bunifuThinButton22.ButtonText = "UPDATE";
            bunifuThinButton22.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton22.ForeColor = Color.Crimson;
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = Color.White;
            bunifuThinButton22.IdleForecolor = Color.Crimson;
            bunifuThinButton22.IdleLineColor = Color.Crimson;
            bunifuThinButton22.Location = new Point(136, 429);
            bunifuThinButton22.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new Size(90, 40);
            bunifuThinButton22.TabIndex = 12;
            bunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton22.Click += bunifuThinButton22_Click;
            // 
            // bunifuThinButton23
            // 
            bunifuThinButton23.ActiveBorderThickness = 1;
            bunifuThinButton23.ActiveCornerRadius = 20;
            bunifuThinButton23.ActiveFillColor = Color.Crimson;
            bunifuThinButton23.ActiveForecolor = Color.White;
            bunifuThinButton23.ActiveLineColor = Color.Crimson;
            bunifuThinButton23.BackColor = SystemColors.Control;
            bunifuThinButton23.BackgroundImage = (Image)resources.GetObject("bunifuThinButton23.BackgroundImage");
            bunifuThinButton23.ButtonText = "DELETE";
            bunifuThinButton23.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton23.ForeColor = Color.Crimson;
            bunifuThinButton23.IdleBorderThickness = 1;
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleFillColor = Color.White;
            bunifuThinButton23.IdleForecolor = Color.Crimson;
            bunifuThinButton23.IdleLineColor = Color.Crimson;
            bunifuThinButton23.Location = new Point(239, 429);
            bunifuThinButton23.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton23.Name = "bunifuThinButton23";
            bunifuThinButton23.Size = new Size(90, 40);
            bunifuThinButton23.TabIndex = 13;
            bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton23.Click += bunifuThinButton23_Click;
            // 
            // bunifuThinButton24
            // 
            bunifuThinButton24.ActiveBorderThickness = 1;
            bunifuThinButton24.ActiveCornerRadius = 20;
            bunifuThinButton24.ActiveFillColor = Color.Crimson;
            bunifuThinButton24.ActiveForecolor = Color.White;
            bunifuThinButton24.ActiveLineColor = Color.Crimson;
            bunifuThinButton24.BackColor = SystemColors.Control;
            bunifuThinButton24.BackgroundImage = (Image)resources.GetObject("bunifuThinButton24.BackgroundImage");
            bunifuThinButton24.ButtonText = "BACK";
            bunifuThinButton24.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton24.ForeColor = Color.Crimson;
            bunifuThinButton24.IdleBorderThickness = 1;
            bunifuThinButton24.IdleCornerRadius = 20;
            bunifuThinButton24.IdleFillColor = Color.White;
            bunifuThinButton24.IdleForecolor = Color.Crimson;
            bunifuThinButton24.IdleLineColor = Color.Crimson;
            bunifuThinButton24.Location = new Point(136, 495);
            bunifuThinButton24.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton24.Name = "bunifuThinButton24";
            bunifuThinButton24.Size = new Size(90, 40);
            bunifuThinButton24.TabIndex = 14;
            bunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton24.Click += bunifuThinButton24_Click;
            // 
            // RoomDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            RoomDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            RoomDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            RoomDGV.ColumnHeadersHeight = 4;
            RoomDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            RoomDGV.DefaultCellStyle = dataGridViewCellStyle3;
            RoomDGV.GridColor = Color.FromArgb(231, 229, 255);
            RoomDGV.Location = new Point(448, 232);
            RoomDGV.Name = "RoomDGV";
            RoomDGV.RowHeadersVisible = false;
            RoomDGV.RowHeadersWidth = 51;
            RoomDGV.Size = new Size(508, 408);
            RoomDGV.TabIndex = 15;
            RoomDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            RoomDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            RoomDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            RoomDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            RoomDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            RoomDGV.ThemeStyle.BackColor = Color.White;
            RoomDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            RoomDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            RoomDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            RoomDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            RoomDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            RoomDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            RoomDGV.ThemeStyle.HeaderStyle.Height = 4;
            RoomDGV.ThemeStyle.ReadOnly = false;
            RoomDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            RoomDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            RoomDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            RoomDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            RoomDGV.ThemeStyle.RowsStyle.Height = 29;
            RoomDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            RoomDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            RoomDGV.CellContentClick += RoomDGV_CellContentClick;
            // 
            // Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 696);
            Controls.Add(RoomDGV);
            Controls.Add(bunifuThinButton24);
            Controls.Add(bunifuThinButton23);
            Controls.Add(bunifuThinButton22);
            Controls.Add(bunifuThinButton21);
            Controls.Add(NoRadio);
            Controls.Add(YesRadio);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(RoomStatusCb);
            Controls.Add(RoomNumbertb);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rooms";
            Text = "Rooms";
            Load += Rooms_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private TextBox RoomNumbertb;
        private ComboBox RoomStatusCb;
        private Label label3;
        private Label label4;
        private RadioButton YesRadio;
        private RadioButton NoRadio;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView RoomDGV;
    }
}