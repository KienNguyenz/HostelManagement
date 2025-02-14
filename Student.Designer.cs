
using HotelMangagementSystem;

namespace HostelMangagementSystem
{
    partial class Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton26 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton27 = new Bunifu.Framework.UI.BunifuThinButton2();
            bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            comboBox2 = new ComboBox();
            panel2 = new Panel();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(317, 10);
            label1.Name = "label1";
            label1.Size = new Size(397, 37);
            label1.TabIndex = 0;
            label1.Text = "STUDENT INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.Crimson;
            textBox1.Location = new Point(50, 126);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 30);
            textBox1.TabIndex = 5;
            textBox1.Text = "Student USN";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = Color.Crimson;
            textBox2.Location = new Point(50, 460);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(274, 30);
            textBox2.TabIndex = 6;
            textBox2.Text = "College";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Crimson;
            textBox3.Location = new Point(50, 391);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(274, 30);
            textBox3.TabIndex = 7;
            textBox3.Text = "Address";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox5.ForeColor = Color.Crimson;
            textBox5.Location = new Point(50, 250);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(274, 30);
            textBox5.TabIndex = 9;
            textBox5.Text = "FatherName";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox6.ForeColor = Color.Crimson;
            textBox6.Location = new Point(50, 186);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(274, 30);
            textBox6.TabIndex = 10;
            textBox6.Text = "StudentName";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.Crimson;
            textBox4.Location = new Point(50, 322);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(274, 30);
            textBox4.TabIndex = 11;
            textBox4.Text = "MotherName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(12, 518);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 12;
            label3.Text = "Room Num";
            // 
            // comboBox1
            // 
            comboBox1.ForeColor = Color.DodgerBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "NotActive" });
            comboBox1.Location = new Point(173, 516);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(593, 119);
            label2.Name = "label2";
            label2.Size = new Size(197, 37);
            label2.TabIndex = 14;
            label2.Text = "ROOM LIST";
            // 
            // bunifuThinButton25
            // 
            bunifuThinButton25.ActiveBorderThickness = 1;
            bunifuThinButton25.ActiveCornerRadius = 20;
            bunifuThinButton25.ActiveFillColor = Color.Crimson;
            bunifuThinButton25.ActiveForecolor = Color.White;
            bunifuThinButton25.ActiveLineColor = Color.Crimson;
            bunifuThinButton25.BackColor = SystemColors.Control;
            bunifuThinButton25.BackgroundImage = (Image)resources.GetObject("bunifuThinButton25.BackgroundImage");
            bunifuThinButton25.ButtonText = "ADD";
            bunifuThinButton25.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton25.ForeColor = Color.Crimson;
            bunifuThinButton25.IdleBorderThickness = 1;
            bunifuThinButton25.IdleCornerRadius = 20;
            bunifuThinButton25.IdleFillColor = Color.White;
            bunifuThinButton25.IdleForecolor = Color.Crimson;
            bunifuThinButton25.IdleLineColor = Color.Crimson;
            bunifuThinButton25.Location = new Point(50, 591);
            bunifuThinButton25.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton25.Name = "bunifuThinButton25";
            bunifuThinButton25.Size = new Size(90, 40);
            bunifuThinButton25.TabIndex = 16;
            bunifuThinButton25.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton25.Click += bunifuThinButton25_Click;
            // 
            // bunifuThinButton26
            // 
            bunifuThinButton26.ActiveBorderThickness = 1;
            bunifuThinButton26.ActiveCornerRadius = 20;
            bunifuThinButton26.ActiveFillColor = Color.Crimson;
            bunifuThinButton26.ActiveForecolor = Color.White;
            bunifuThinButton26.ActiveLineColor = Color.Crimson;
            bunifuThinButton26.BackColor = SystemColors.Control;
            bunifuThinButton26.BackgroundImage = (Image)resources.GetObject("bunifuThinButton26.BackgroundImage");
            bunifuThinButton26.ButtonText = "UPDATE";
            bunifuThinButton26.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton26.ForeColor = Color.Crimson;
            bunifuThinButton26.IdleBorderThickness = 1;
            bunifuThinButton26.IdleCornerRadius = 20;
            bunifuThinButton26.IdleFillColor = Color.White;
            bunifuThinButton26.IdleForecolor = Color.Crimson;
            bunifuThinButton26.IdleLineColor = Color.Crimson;
            bunifuThinButton26.Location = new Point(155, 591);
            bunifuThinButton26.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton26.Name = "bunifuThinButton26";
            bunifuThinButton26.Size = new Size(90, 40);
            bunifuThinButton26.TabIndex = 17;
            bunifuThinButton26.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton26.Click += bunifuThinButton26_Click;
            // 
            // bunifuThinButton27
            // 
            bunifuThinButton27.ActiveBorderThickness = 1;
            bunifuThinButton27.ActiveCornerRadius = 20;
            bunifuThinButton27.ActiveFillColor = Color.Crimson;
            bunifuThinButton27.ActiveForecolor = Color.White;
            bunifuThinButton27.ActiveLineColor = Color.Crimson;
            bunifuThinButton27.BackColor = SystemColors.Control;
            bunifuThinButton27.BackgroundImage = (Image)resources.GetObject("bunifuThinButton27.BackgroundImage");
            bunifuThinButton27.ButtonText = "DELETE";
            bunifuThinButton27.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton27.ForeColor = Color.Crimson;
            bunifuThinButton27.IdleBorderThickness = 1;
            bunifuThinButton27.IdleCornerRadius = 20;
            bunifuThinButton27.IdleFillColor = Color.White;
            bunifuThinButton27.IdleForecolor = Color.Crimson;
            bunifuThinButton27.IdleLineColor = Color.Crimson;
            bunifuThinButton27.Location = new Point(258, 591);
            bunifuThinButton27.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton27.Name = "bunifuThinButton27";
            bunifuThinButton27.Size = new Size(90, 40);
            bunifuThinButton27.TabIndex = 18;
            bunifuThinButton27.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton27.Click += bunifuThinButton27_Click;
            // 
            // bunifuThinButton28
            // 
            bunifuThinButton28.ActiveBorderThickness = 1;
            bunifuThinButton28.ActiveCornerRadius = 20;
            bunifuThinButton28.ActiveFillColor = Color.Crimson;
            bunifuThinButton28.ActiveForecolor = Color.White;
            bunifuThinButton28.ActiveLineColor = Color.Crimson;
            bunifuThinButton28.BackColor = SystemColors.Control;
            bunifuThinButton28.BackgroundImage = (Image)resources.GetObject("bunifuThinButton28.BackgroundImage");
            bunifuThinButton28.ButtonText = "BACK";
            bunifuThinButton28.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton28.ForeColor = Color.Crimson;
            bunifuThinButton28.IdleBorderThickness = 1;
            bunifuThinButton28.IdleCornerRadius = 20;
            bunifuThinButton28.IdleFillColor = Color.White;
            bunifuThinButton28.IdleForecolor = Color.Crimson;
            bunifuThinButton28.IdleLineColor = Color.Crimson;
            bunifuThinButton28.Location = new Point(155, 657);
            bunifuThinButton28.Margin = new Padding(6, 5, 6, 5);
            bunifuThinButton28.Name = "bunifuThinButton28";
            bunifuThinButton28.Size = new Size(90, 40);
            bunifuThinButton28.TabIndex = 19;
            bunifuThinButton28.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton28.Click += bunifuThinButton28_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(10, 551);
            label4.Name = "label4";
            label4.Size = new Size(163, 20);
            label4.TabIndex = 12;
            label4.Text = "Student Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Active", "NotActive" });
            comboBox2.Location = new Point(173, 549);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 204, 254);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(1017, 15);
            panel2.TabIndex = 23;
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
            RoomDGV.Location = new Point(439, 186);
            RoomDGV.Name = "RoomDGV";
            RoomDGV.RowHeadersVisible = false;
            RoomDGV.RowHeadersWidth = 51;
            RoomDGV.Size = new Size(508, 408);
            RoomDGV.TabIndex = 16;
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
            // 
            // Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 696);
            Controls.Add(RoomDGV);
            Controls.Add(panel2);
            Controls.Add(bunifuThinButton28);
            Controls.Add(bunifuThinButton27);
            Controls.Add(bunifuThinButton26);
            Controls.Add(bunifuThinButton25);
            Controls.Add(label2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Student";
            Text = "Student";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RoomDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            Form1 Home = new Form1();
            Home.Show();
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox4;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton26;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton27;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
        private Label label4;
        private ComboBox comboBox2;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView RoomDGV;
    }
}